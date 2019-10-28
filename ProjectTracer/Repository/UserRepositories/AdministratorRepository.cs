namespace ProjectTracer.Repository
{
    public class AdministratorRepository : Repository<Administrators>, IAdministratorRepository
    {
        public AdministratorRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public bool CheckExistance(string id, string password)
        {
            var Admin = Context.Administrators.Find(id);

            return Admin.Password == password;
        }
    }
}
