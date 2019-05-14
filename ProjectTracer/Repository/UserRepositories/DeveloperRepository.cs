using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    class DeveloperRepository : Repository<Developers>, IDeveloperRepository
    {
        public DeveloperRepository(ProjectTracerEntities Context) : base(Context)
        {
        }

        public ProjectTracerEntities ProjectTracerEntities
        {
            get { return Context as ProjectTracerEntities; }
        }
        public bool CheckExistance(string id, string password)
        {
            var Developer = Context.Developers.Find(id);
            return Developer.Password == password;
        }

    }
}
