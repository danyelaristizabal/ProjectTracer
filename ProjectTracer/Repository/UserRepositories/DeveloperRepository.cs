namespace ProjectTracer.Repository
{
     public class DeveloperRepository : Repository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public bool CheckExistance(string id, string password)
        {
            var Developer = Context.Developer.Find(id);

            return Developer.Password.Contains(password);
        }

    }
}
