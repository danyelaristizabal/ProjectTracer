using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    class SeniorRepository : Repository<Seniors>, ISeniorRepository
    {
        public SeniorRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public ProjectTracerEntities ProjectTracerEntities
        {
            get { return Context as ProjectTracerEntities; }
        }
        public bool CheckExistance(string id, string password)
        {
            var Senior = Context.Seniors.Find(id);
            return Senior.Password == password;
        }
    }
}
