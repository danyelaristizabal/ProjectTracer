namespace ProjectTracer.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        public readonly ProjectTracerEntities context;
        public IProjectRepository  Project  { get; private  set; }
        public ITaskRepository Task { get; private set; }
        public IDocumentRepository Document { get; private set; }
        public ITeamRepository Team { get; private set;  }
        public IClientRepository Client { get; private set; }
        public IDeveloperRepository Developer { get; private set; }
        public ISeniorRepository Senior { get; private set; }
        public IAdministratorRepository Administrator { get; private set; }

        public UnityOfWork(ProjectTracerEntities _context)
        {
            context = _context;
            Project = new ProjectRepository(_context);
            Task = new TaskRepository(_context);
            Document = new DocumentRepository(_context);
            Team = new TeamRepository(_context); 
            Client = new ClientRepository(_context);
            Developer = new DeveloperRepository(_context);
            Senior = new SeniorRepository(_context);
            Administrator  = new AdministratorRepository(_context);
        }
        public int Complete()
        {
            return context.SaveChanges();  
        }
        public void Dispose()
        {
           context.Dispose(); 
        }
    }
}
