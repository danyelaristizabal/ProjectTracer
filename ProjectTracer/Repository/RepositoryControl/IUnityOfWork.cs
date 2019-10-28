using System;
namespace ProjectTracer.Repository
{
    public interface IUnityOfWork : IDisposable
    {
        IProjectRepository Project { get; }
        ITaskRepository Task { get; }
        IDocumentRepository Document { get; }
        ITeamRepository Team { get;  }
        IClientRepository Client { get; }
        IDeveloperRepository Developer { get;  } 
        ISeniorRepository Senior  { get;  }
        IAdministratorRepository Administrator { get; }
        int Complete();
    }
}
