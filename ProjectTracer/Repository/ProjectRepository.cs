namespace ProjectTracer.Repository
{
    internal class ProjectRepository : Repository<Projects>, IProjectRepository
    {
        public ProjectRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
    }
}
