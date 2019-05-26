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
            var projects = unit.Projects.GetAll().Where(p => p.Clients.Contains(unit.Clients.GetAll().FirstOrDefault(C => C.Client_Id == client_Id)));
            List<Teams> ListOfTeams = new List<Teams>();
            List<ListViewItem> TeamsItemList = new List<ListViewItem>();

            foreach (var project in projects)
            {

                foreach (var Team in project.Teams)
                {
                    ListViewItem item = new ListViewItem(Team.Team_ID.ToString());

                    if (Team.Seniors.Count > 0)
                    {
                        item.SubItems.Add(Team.Seniors.FirstOrDefault().Senior_Id);

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
            var developers = unit.Developers.GetAll();
            List<ListViewItem> developersItemList = new List<ListViewItem>();

            foreach (var developer in developers)
            {
                foreach (var team in developer.Teams)
                {
                    if (team.Team_ID == team_ID)
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
