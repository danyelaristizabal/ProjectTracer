using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    public class AdministratorRepository : Repository<Administrators>, IAdministratorRepository
    {
        public AdministratorRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public ProjectTracerEntities ProjectTracerEntities
        {
            get { return Context as ProjectTracerEntities; }
        }
        public bool CheckExistance(string id, string password)
        {
            var Admin = Context.Administrators.Find(id);
            return Admin.Password == password;
        }
    }
}
