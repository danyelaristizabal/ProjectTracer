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
    public static class ClientDevelopersController
    {
        internal static List<ListViewItem> GetTeamsItemList(UnityOfWork unit, string client_Id)
        {
            var projects = unit.Project.GetAll().Where(p => p.Client.Contains(unit.Client.GetAll().FirstOrDefault(C => C.Id == client_Id)));
            List<Team> ListOfTeams = new List<Team>();
            List<ListViewItem> TeamsItemList = new List<ListViewItem>();

            foreach (var project in projects)
            {

                foreach (var Team in project.Team)
                {
                    ListViewItem item = new ListViewItem(Team.Team_ID.ToString());

                    if (Team.Senior.Count > 0)
                    {
                        item.SubItems.Add(Team.Senior.FirstOrDefault().Id);

                    }
                    else
                    {
                        item.SubItems.Add("Not Assigned");
                    }
                    item.SubItems.Add(project.Project_ID);
                    TeamsItemList.Add(item);

                }

            }

            return TeamsItemList;
        }

        internal static List<ListViewItem> FindDevelopersByTeam(UnityOfWork unit, int team_ID)
        {
            var developers = unit.Developer.GetAll();
            List<ListViewItem> developersItemList = new List<ListViewItem>();

            foreach (var developer in developers)
            {
                foreach (var team in developer.Team)
                {
                    if (team.Team_ID == team_ID)
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
