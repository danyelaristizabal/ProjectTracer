using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Models;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    public static class SeniorDevelopersController
    {
        internal static List<ListViewItem> GetTeamsItemList(UnityOfWork unit, string SeniorId )
        {
            List<Team> ListOfTeams = unit.Team
                        .GetAll()
                        .Where(T => T.Senior
                                     .Contains(unit.Senior.GetAll().FirstOrDefault(d => d.Id == SeniorId)))
                        .ToList();

            List<ListViewItem> TeamsItemList = new List<ListViewItem>();

            foreach (var Team in ListOfTeams)
            {
                ListViewItem item = new ListViewItem(Team.Team_ID.ToString());

                if (Team.Senior.Count > 0) item.SubItems.Add(Team.Senior.FirstOrDefault().Id);
                TeamsItemList.Add(item);
            }
            return TeamsItemList;
        }

        internal static List<ListViewItem> GetDevelopersItemList(UnityOfWork unit, string  senior_Id)
        {

          var teams  =  unit.Team
                        .GetAll()
                        .Where(T => T.Senior
                                     .Contains(unit.Senior.GetAll().FirstOrDefault(d => d.Id == senior_Id)));

            List<Developer> ListOfDevelopers = new List<Developer>(); 
            
            List<ListViewItem> DevelopersItemList = new List<ListViewItem>();

            foreach (var team in teams)
            {
                foreach (var dev in team.Developer )
                {
                    if (!ListOfDevelopers.Contains(dev))
                    {
                        ListOfDevelopers.Add(dev); 
                        ListViewItem item = new ListViewItem(dev.Id);
                        DevelopersItemList.Add(item);
                    }
                }
            }

            return DevelopersItemList;
        }

        internal static List<ListViewItem> FindDeveloperById(UnityOfWork unit, string id, string senior_Id)
        {
            var teams = unit.Team
                        .GetAll()
                        .Where(T => T.Senior
                                     .Contains(unit.Senior.GetAll().FirstOrDefault(d => d.Id == senior_Id)));

            List<Developer> developers = new List<Developer>();

            foreach (var team in teams)
            {
                foreach (var dev in team.Developer)
                {
                    if (!developers.Contains(dev))
                    {
                        developers.Add(dev); 
                    }
                }
            }


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

        internal static List<ListViewItem> FindDevelopersByTeam(UnityOfWork unit, int teamId, string senior_Id)
        {
            var teams = unit.Team
                        .GetAll()
                        .Where(T => T.Senior
                                     .Contains(unit.Senior.GetAll().FirstOrDefault(d => d.Id == senior_Id)));
            List<Developer> developers = new List<Developer>();


            foreach (var team in teams)
            {
                foreach (var dev in team.Developer)
                {
                    if (!developers.Contains(dev))
                    {
                        developers.Add(dev);
                    }
                }
            }
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
    }
}
