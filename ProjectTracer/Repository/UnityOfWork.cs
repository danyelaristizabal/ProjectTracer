using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ProjectTracerEntities context;

        public IProjectRepository  Projects  { get; private  set; }

        public IClientRepository Clients { get; private set; }

        public IDeveloperRepository Developers { get; private set; }

        public ISeniorRepository Seniors { get; private set; }

        public IAdministratorRepository Administrators { get; private set; }

        public UnityOfWork(ProjectTracerEntities _context)
        {
            context = _context;
            Projects = new ProjectRepository(_context);
            Clients = new ClientRepository(_context);
            Developers = new DeveloperRepository(_context);
            Seniors = new SeniorRepository(_context);
            Administrators  = new AdministratorRepository(_context);
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
