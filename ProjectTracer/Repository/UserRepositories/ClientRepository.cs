using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracer.Repository
{
    public class ClientRepository : Repository<Clients>, IClientRepository
    {
        public ClientRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public ProjectTracerEntities ProjectTracerEntities
        {
            get { return Context as ProjectTracerEntities; }
        }
        public bool CheckExistance(string id, string password)
        {
            var client = Context.Clients.Find(id);
            return client.Password == password; 
        }
    }
}
