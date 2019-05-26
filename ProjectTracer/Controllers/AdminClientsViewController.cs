using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTracer.Repository;

namespace ProjectTracer.Controllers
{
    public static class AdminClientsViewController
    {
        internal static List<ListViewItem> GetClientsList(UnityOfWork unit)
        {
            
                List<Clients> ListOfClients = unit.Clients.GetAll().ToList();

                List<ListViewItem> ClientsItemList = new List<ListViewItem>();

                foreach (var Client in ListOfClients)
                {
                    ListViewItem item = new ListViewItem(Client.Client_Id.ToString());
                    ClientsItemList.Add(item);
                }
                return ClientsItemList;
        }

        internal static List<ListViewItem> FindProjectsByClient(UnityOfWork unit, string client_Id)
        {
                var Projects = unit.Projects.GetAll();
                List<ListViewItem> ProjectsItemList = new List<ListViewItem>();

                foreach (var project in Projects)
                {
                    foreach (var client in project.Clients)
                    {
                        if (client.Client_Id == client_Id)
                        {
                            ListViewItem item = new ListViewItem(project.Project_ID);
                            item.SubItems.Add(project.Description);
                            item.SubItems.Add(project.Description);
                            item.SubItems.Add(project.DeadLine.ToString());
                            ProjectsItemList.Add(item);
                        }

                    }
                }
                return ProjectsItemList;
        }

        internal static List<ListViewItem> FindClientsByProject(UnityOfWork unit, string project_ID)
        {
            var Clients = unit.Clients.GetAll();
            List<ListViewItem> ClientsItemList = new List<ListViewItem>();

            foreach (var client in Clients)
            {
                foreach (var project in client.Projects)
                {
                    if (project.Project_ID == project_ID)
                    {
                        ListViewItem item = new ListViewItem(client.Client_Id);
                        ClientsItemList.Add(item);
                    }
                }
            }
            return ClientsItemList;
        }
    }
}
