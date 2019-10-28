using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    public class TaskRepository : Repository<Tasks>, ITaskRepository
    {
        public TaskRepository(ProjectTracerEntities Context) : base(Context)
        {
        }

        public ProjectTracerEntities ProjectTracerEntities
        {
            get { return Context as ProjectTracerEntities; }
        }
    }
}
