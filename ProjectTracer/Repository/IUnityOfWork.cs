using System;
namespace ProjectTracer.Repository
{
    public interface IUnityOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        ITaskRepository Tasks { get; }
        IDocumentRepository Documents { get; }
        ITeamRepository Teams { get;  }
        IClientRepository Clients { get; }
        IDeveloperRepository Developers { get;  } 
        ISeniorRepository Seniors  { get;  }
        IAdministratorRepository Administrators { get; }
        int Complete();
    }
}
