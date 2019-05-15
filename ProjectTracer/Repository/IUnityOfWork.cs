using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    public interface IUnityOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        IClientRepository Clients { get; }
        IDeveloperRepository Developers { get;  } 
        ISeniorRepository Seniors  { get;  }
        IAdministratorRepository Administrators { get; }
        int Complete();
    }
}
