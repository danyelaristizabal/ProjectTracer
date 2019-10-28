namespace ProjectTracer.Repository
{
     public class DeveloperRepository : Repository<Developers>, IDeveloperRepository
    {
        public DeveloperRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public bool CheckExistance(string id, string password)
        {
            var Developer = Context.Developers.Find(id);

            return Developer.Password.Contains(password);
        }

    }
}
