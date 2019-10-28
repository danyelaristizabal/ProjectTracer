using System.Windows.Forms; 
namespace ProjectTracer.Repository
{
    public class ClientRepository : Repository<Clients>, IClientRepository
    {
        public ClientRepository(ProjectTracerEntities Context) : base(Context)
        {

        }
        public bool CheckExistance(string id, string password)
        {
                var client = Context.Clients.Find(id);

                return client.Password.Contains(password);
        }
    }
}
