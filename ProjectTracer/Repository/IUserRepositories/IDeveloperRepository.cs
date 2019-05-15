using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    public interface IDeveloperRepository : IRepository<Developers>
    {
        bool CheckExistance(string id, string password);

    }
}
