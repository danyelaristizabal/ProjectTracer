namespace ProjectTracer.Repository
{
    internal class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
    }
}
