using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    class DocumentRepository  : Repository<Documents>, IDocumentRepository
    {
        public DocumentRepository(ProjectTracerEntities Context) : base(Context)
        {

        }
        public ProjectTracerEntities ProjectTracerEntities
        {
            get { return Context as ProjectTracerEntities; }
        }
    }
}
