
namespace ProjectTracer.Repository
{
    class DocumentRepository  : Repository<Document>, IDocumentRepository
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
