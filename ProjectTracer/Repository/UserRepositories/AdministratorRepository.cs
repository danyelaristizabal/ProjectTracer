namespace ProjectTracer.Repository
{
    public class AdministratorRepository : Repository<Administrator>, IAdministratorRepository
    {
        public AdministratorRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public bool CheckExistance(string id, string password)
        {
            var Admin = Context.Administrator.Find(id);

            return Admin.Password.Contains(password);
        }
    }
}
