using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            List<Developer> ListOfDevelopers = unit.Developer.GetAll().ToList();

            List<ListViewItem> DevelopersItemList = new List<ListViewItem>();

            foreach (var Developer in ListOfDevelopers)
            {
                ListViewItem item = new ListViewItem(Developer.Id);
                DevelopersItemList.Add(item);
            }
            return DevelopersItemList;
        }

        internal static List<ListViewItem>  GetTeamsItemList(UnityOfWork unit)
        {
            List<Team> ListOfTeams = unit.Team.GetAll().ToList(); 

            List<ListViewItem> TeamsItemList = new List<ListViewItem>();

            foreach (var Team in ListOfTeams)
            {
                ListViewItem item = new ListViewItem(Team.Team_ID.ToString());

               if(Team.Senior.Count > 0 ) item.SubItems.Add(Team.Senior.FirstOrDefault().Id);
                TeamsItemList.Add(item);
            }
            return TeamsItemList;
        }

        internal static  List<ListViewItem>  FindTeamsByProject(UnityOfWork unit, string projectId)
        {
            var projects = unit.Project.GetAll();

            List<ListViewItem> Teams = new List<ListViewItem>();

            Project MoreSimilarProject = new Project(); 

            var SearchedProject = new Project()
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

            var teamsList = MoreSimilarProject.Team.ToList();

            foreach (var Team in teamsList)
            {
                        ListViewItem item = new ListViewItem(Team.Team_ID.ToString());
                        item.SubItems.Add(Team.Senior.FirstOrDefault().Id);
                        Teams.Add(item);
            }

            return Teams; 
        }

        internal static List<ListViewItem> FindDevelopersByProject(UnityOfWork unit, string projectId)
        {
            var projects = unit.Project.GetAll();

            List<ListViewItem> Developers = new List<ListViewItem>();

            Project MoreSimilarProject = new Project();

            var SearchedProject = new Project()
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

            var teamsList = MoreSimilarProject.Team.ToList();

            foreach (var Team in teamsList)
            {
                foreach (var developer in Team.Developer)
                {
                    ListViewItem devItem = new ListViewItem(developer.Id);
                    Developers.Add(devItem);
                }
            }
            return Developers;
        }

        


        internal static List<ListViewItem> FindDevelopersByTeam(UnityOfWork unit, int teamId)
        {
            var developers = unit.Developer.GetAll();
            List<ListViewItem> developersItemList = new List<ListViewItem>();

            foreach (var developer in developers)
            {
                foreach (var team in developer.Team)
                {
                    if (team.Team_ID == teamId)
                    {
                        ListViewItem item = new ListViewItem(developer.Id);

                        developersItemList.Add(item);
                    }

                }
            }
            return developersItemList;
        }

        internal static List<ListViewItem> FindTeamsByDeveloper(UnityOfWork unit, string devId)
        {
            var Developer = unit.Developer.GetAll().FirstOrDefault(d => d.Id == devId);

            List<ListViewItem> TeamItemList = new List<ListViewItem>();

            foreach (var team in Developer.Team)
            {
                        ListViewItem item = new ListViewItem(team.Team_ID.ToString());

                        item.SubItems.Add(team.Senior.FirstOrDefault().Id);

                        TeamItemList.Add(item);
            }
            return TeamItemList;
        }
        internal static List<ListViewItem> FindDeveloperById(UnityOfWork unit, string id)
        {
            var developers = unit.Developer.GetAll();

            List<ListViewItem> developersItemList = new List<ListViewItem>();

            var SearcheDeveloper = new Developer()
            {
                Id = id
            };

            foreach (var developer in developers)
            {
                int Distance = LevenshteinDistance.Compute(SearcheDeveloper.Id, developer.Id);

                int moresimilar = 30; 

                if (Distance <= 4)
                {
                    ListViewItem item = new ListViewItem(developer.Id);
                    developersItemList.Add(item);
                }
            }
            return developersItemList;
        }
        internal static void AddDevToTeam(UnityOfWork unit, string devId, int TeamId)
        {
            unit.Developer
                .GetAll()
                .FirstOrDefault(D => D.Id == devId)
                .Team
                .Add(unit.Team.GetAll().FirstOrDefault(T => T.Team_ID == TeamId)); 

            unit.Complete();
        }

        internal static void RemoveDevFromTeam(UnityOfWork unit, string devId, int TeamId)
        {
            unit.Developer
                .GetAll()
                .FirstOrDefault(D => D.Id == devId)
                .Team
                .Remove(unit.Team.GetAll().FirstOrDefault(T => T.Team_ID == TeamId));

            unit.Complete();
        }

        internal static void RemoveDev(UnityOfWork unit, Developer selectedDeveloper)
        {
            Developer devToDelete = new Developer(); 
            try
            {
                devToDelete = unit.context.Developer
                             .Include(dev => dev.Team)
                             .FirstOrDefault(dev => dev.Id == selectedDeveloper.Id);

                foreach (var team in unit.context.Developer.FirstOrDefault(dev => dev.Id == devToDelete.Id).Team.ToList())
                {
                    team.Developer.Remove(devToDelete); 
                }

                unit.Developer.Remove(devToDelete);

                unit.context.SaveChanges();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

            
        }
        internal static void AddTeam(UnityOfWork unit, string seniorId)
        {
            var allTeams = unit.context.Team;
            var count = allTeams.Count() + 1;

            unit.Team.Add(new Team() {
                Team_ID = count,
            });

            var senior = unit.context.Senior
                .FirstOrDefault(ssenior => ssenior.Id == seniorId);

            MessageBox.Show($"Senior id: {senior.Id}"); 

            unit.context.Team
                .FirstOrDefault(team => team.Team_ID == count)
                .Senior
                .Add(senior);

            unit.context.SaveChanges();
        }
    }
}
