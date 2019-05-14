using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    internal class ProjectRepository : Repository<Projects>, IProjectRepository
    {
        public ProjectRepository(ProjectTracerEntities Context) : base(Context)
        {
        }

        public ProjectTracerEntities ProjectTracerEntities
        {
               get { return Context as ProjectTracerEntities; } 
        }

        
    }
}
