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
            List<Teams> ListOfTeams = unit.Teams
                        .GetAll()
                        .Where(T => T.Seniors
                                     .Contains(unit.Seniors.GetAll().FirstOrDefault(d => d.Senior_Id == SeniorId)))
                        .ToList();

            List<ListViewItem> TeamsItemList = new List<ListViewItem>();

            foreach (var Team in ListOfTeams)
            {
                ListViewItem item = new ListViewItem(Team.Team_ID.ToString());

                if (Team.Seniors.Count > 0) item.SubItems.Add(Team.Seniors.FirstOrDefault().Senior_Id);
                TeamsItemList.Add(item);
            }
            return TeamsItemList;
        }

        internal static List<ListViewItem> GetDevelopersItemList(UnityOfWork unit, string  senior_Id)
        {

          var teams  =  unit.Teams
                        .GetAll()
                        .Where(T => T.Seniors
                                     .Contains(unit.Seniors.GetAll().FirstOrDefault(d => d.Senior_Id == senior_Id)));

            List<Developers> ListOfDevelopers = new List<Developers>(); 
            
            List<ListViewItem> DevelopersItemList = new List<ListViewItem>();

            foreach (var team in teams)
            {
                foreach (var dev in team.Developers )
                {
                    if (!ListOfDevelopers.Contains(dev))
                    {
                        ListOfDevelopers.Add(dev); 
                        ListViewItem item = new ListViewItem(dev.Developer_Id);
                        DevelopersItemList.Add(item);
                    }
                }
            }

            return DevelopersItemList;
        }

        internal static List<ListViewItem> FindDeveloperById(UnityOfWork unit, string id, string senior_Id)
        {
            var teams = unit.Teams
                        .GetAll()
                        .Where(T => T.Seniors
                                     .Contains(unit.Seniors.GetAll().FirstOrDefault(d => d.Senior_Id == senior_Id)));

            List<Developers> developers = new List<Developers>();

            foreach (var team in teams)
            {
                foreach (var dev in team.Developers)
                {
                    if (!developers.Contains(dev))
                    {
                        developers.Add(dev); 
                    }
                }
            }


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

        internal static List<ListViewItem> FindDevelopersByTeam(UnityOfWork unit, int teamId, string senior_Id)
        {
            var teams = unit.Teams
                        .GetAll()
                        .Where(T => T.Seniors
                                     .Contains(unit.Seniors.GetAll().FirstOrDefault(d => d.Senior_Id == senior_Id)));
            List<Developers> developers = new List<Developers>();


            foreach (var team in teams)
            {
                foreach (var dev in team.Developers)
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
    }
}
