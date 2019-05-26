using ProjectTracer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTracer.Controllers
{
    public static class AdminAddTeamController
    {
        internal static void RegistrateTeam(string devId, string seniorId, UnityOfWork unit)
        {
            var teamId = unit.Teams.GetAll().Count() + 1; 
            unit.Teams
                 .Add(new Teams() { Team_ID = teamId });
            unit.Complete(); 

            unit.Seniors
                .GetAll()
                .FirstOrDefault(S => S.Senior_Id == seniorId)
                .Teams.Add(unit.Teams.GetAll().FirstOrDefault(T=>T.Team_ID == teamId));
            unit.Complete();

            unit.Developers
                .GetAll()
                .FirstOrDefault(D => D.Developer_Id == devId)
                .Teams
                .Add(unit.Teams.GetAll().FirstOrDefault(T => T.Team_ID == teamId));
            unit.Complete(); 
        }
    }
}
