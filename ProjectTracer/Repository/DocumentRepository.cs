
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
