using ProjectTracer.Repository;
using System.Linq;

namespace ProjectTracer.Controllers
{
    public static class AdminAddTeamController
    {
        internal static void RegistrateTeam(string devId, string seniorId, UnityOfWork unit)
        {
            var teamId = unit.Team.GetAll().Count() + 1; 
            unit.Team
                 .Add(new Team() { Team_ID = teamId });
            unit.Complete(); 

            unit.Senior
                .GetAll()
                .FirstOrDefault(S => S.Id == seniorId)
                .Team.Add(unit.Team.GetAll().FirstOrDefault(T=>T.Team_ID == teamId));
            unit.Complete();

            unit.Developer
                .GetAll()
                .FirstOrDefault(D => D.Id == devId)
                .Team
                .Add(unit.Team.GetAll().FirstOrDefault(T => T.Team_ID == teamId));
            unit.Complete(); 
        }
    }
}
