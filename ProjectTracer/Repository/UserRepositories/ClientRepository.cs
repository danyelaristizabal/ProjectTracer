namespace ProjectTracer.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        public ClientRepository(ProjectTracerEntities Context) : base(Context)
        {

        }
        public bool CheckExistance(string id, string password)
        {
            var client = Context.Client.Find(id);

            return client.Password.Contains(password);
        }

    }
} 
