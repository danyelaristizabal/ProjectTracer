using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    class AdminDevelopersController
    { 
        public static object MewssageBox { get; private set; }

        internal static List<ListViewItem>  GetDevelopersItemList(UnityOfWork unit)
        {
            List<Developers> ListOfDevelopers = unit.Developers.GetAll().ToList();

            List<ListViewItem> DevelopersItemList = new List<ListViewItem>();

            foreach (var Developer in ListOfDevelopers)
            {
                ListViewItem item = new ListViewItem(Developer.Developer_Id);
                DevelopersItemList.Add(item);
            }
            return DevelopersItemList;
        }

        internal static List<ListViewItem>  GetTeamsItemList(UnityOfWork unit)
        {
            List<Teams> ListOfTeams = unit.Teams.GetAll().ToList(); 

            List<ListViewItem> TeamsItemList = new List<ListViewItem>();

            foreach (var Team in ListOfTeams)
            {
                ListViewItem item = new ListViewItem(Team.Team_ID.ToString());

               if(Team.Seniors.Count > 0 ) item.SubItems.Add(Team.Seniors.FirstOrDefault().Senior_Id);
                TeamsItemList.Add(item);
            }
            return TeamsItemList;
        }

        internal static  List<ListViewItem>  FindTeamsByProject(UnityOfWork unit, string projectId)
        {
            var projects = unit.Projects.GetAll();

            List<ListViewItem> Teams = new List<ListViewItem>();

            Projects MoreSimilarProject = new Projects(); 

            var SearchedProject = new Projects()
            {
                Project_ID = projectId
            };

            int MinimalDistance = 100;  

            foreach (var project in projects)
            {

                int Distance = LevenshteinDistance.Compute(SearchedProject.Project_ID, project.Project_ID);

                if (Distance <= 4 && Distance < MinimalDistance)
                {

                    MinimalDistance = Distance; 

                    MoreSimilarProject = project; 

                }
            }

            var teamsList = MoreSimilarProject.Teams.ToList();

            foreach (var Team in teamsList)
            {
                        ListViewItem item = new ListViewItem(Team.Team_ID.ToString());
                        item.SubItems.Add(Team.Seniors.FirstOrDefault().Senior_Id);
                        Teams.Add(item);
            }

            return Teams; 
        }

        internal static List<ListViewItem> FindDevelopersByProject(UnityOfWork unit, string projectId)
        {
            var projects = unit.Projects.GetAll();

            List<ListViewItem> Developers = new List<ListViewItem>();

            Projects MoreSimilarProject = new Projects();

            var SearchedProject = new Projects()
            {
                Project_ID = projectId
            };

            int MinimalDistance = 100;

            foreach (var project in projects)
            {

                int Distance = LevenshteinDistance.Compute(SearchedProject.Project_ID, project.Project_ID);

                if (Distance <= 4 && Distance < MinimalDistance)
                {

                    MinimalDistance = Distance;

                    MoreSimilarProject = project;

                }
            }

            var teamsList = MoreSimilarProject.Teams.ToList();

            foreach (var Team in teamsList)
            {
                foreach (var developer in Team.Developers)
                {
                    ListViewItem devItem = new ListViewItem(developer.Developer_Id);
                    Developers.Add(devItem);
                }
            }
            return Developers;
        }

        


        internal static List<ListViewItem> FindDevelopersByTeam(UnityOfWork unit, int teamId)
        {
            var developers = unit.Developers.GetAll();
            List<ListViewItem> developersItemList = new List<ListViewItem>();

            foreach (var developer in developers)
            {
                foreach (var team in developer.Teams)
                {
                    if (team.Team_ID == teamId)
                    {
                        ListViewItem item = new ListViewItem(developer.Developer_Id);

                        developersItemList.Add(item);
                    }

                }
            }
            return developersItemList;
        }

        internal static List<ListViewItem> FindTeamsByDeveloper(UnityOfWork unit, string devId)
        {
            var Developer = unit.Developers.GetAll().FirstOrDefault(d => d.Developer_Id == devId);

            List<ListViewItem> TeamItemList = new List<ListViewItem>();

            foreach (var team in Developer.Teams)
            {
                        ListViewItem item = new ListViewItem(team.Team_ID.ToString());

                        item.SubItems.Add(team.Seniors.FirstOrDefault().Senior_Id);

                        TeamItemList.Add(item);
            }
            return TeamItemList;
        }
        internal static List<ListViewItem> FindDeveloperById(UnityOfWork unit, string id)
        {
            var developers = unit.Developers.GetAll();

            List<ListViewItem> developersItemList = new List<ListViewItem>();

            var SearcheDeveloper = new Developers()
            {
                Developer_Id = id
            };

            foreach (var developer in developers)
            {
                int Distance = LevenshteinDistance.Compute(SearcheDeveloper.Developer_Id, developer.Developer_Id);

                int moresimilar = 30; 

                if (Distance <= 4)
                {
                    ListViewItem item = new ListViewItem(developer.Developer_Id);
                    developersItemList.Add(item);
                }
            }
            return developersItemList;
        }
        internal static void AddDevToTeam(UnityOfWork unit, string devId, int TeamId)
        {
            var teamWhereToAdd = unit.Teams
                .GetAll()
                .Where(SearchedTeam => SearchedTeam.Team_ID == TeamId)
                .FirstOrDefault();

            var devToAdd = teamWhereToAdd.Developers
                .Where(SearchedDev => SearchedDev.Developer_Id == devId)
                .FirstOrDefault();


            unit.Teams
                .GetAll()
                .Where(SearchedTeam => SearchedTeam.Team_ID == TeamId)
                .FirstOrDefault()
                .Developers.Add(devToAdd);

            unit.Complete();
        }

        internal static void RemoveDevFromTeam(UnityOfWork unit, string devId, int TeamId)
        {
            var teamWhereToDelete = unit.Teams
                .GetAll()
                .Where(SearchedTeam => SearchedTeam.Team_ID == TeamId)
                .FirstOrDefault();

            var devtoDelete =  teamWhereToDelete.Developers
                .Where(SearchedDev => SearchedDev.Developer_Id == devId)
                .FirstOrDefault();

            unit.Teams
                .GetAll()
                .Where(SearchedTeam => SearchedTeam.Team_ID == TeamId)
                .FirstOrDefault()
                .Developers.Remove(devtoDelete); 

            unit.Developers.Remove(devtoDelete);

            unit.Complete();
        }

        internal static void RemoveDev(UnityOfWork unit, Developers selectedDeveloper)
        {
            Developers devToDelete = new Developers(); 
            try
            {
                devToDelete = unit.context.Developers
                             .Include(dev => dev.Teams)
                             .FirstOrDefault(dev => dev.Developer_Id == selectedDeveloper.Developer_Id);

                foreach (var team in unit.context.Developers.FirstOrDefault(dev => dev.Developer_Id == devToDelete.Developer_Id).Teams.ToList())
                {
                    team.Developers.Remove(devToDelete); 
                }

                unit.Developers.Remove(devToDelete);

                unit.context.SaveChanges();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

            
        }

        internal static void AddTeam(UnityOfWork unit, string seniorId)
        {
            var allTeams = unit.context.Teams;
            var count = allTeams.Count() + 1;

            unit.Teams.Add(new Teams() {
                Team_ID = count,
            });

            var senior = unit.context.Seniors
                .FirstOrDefault(ssenior => ssenior.Senior_Id == seniorId);

            MessageBox.Show($"Senior id: {senior.Senior_Id}"); 

            unit.context.Teams
                .FirstOrDefault(team => team.Team_ID == count)
                .Seniors
                .Add(senior);

            unit.context.SaveChanges();
        }
    }
}
