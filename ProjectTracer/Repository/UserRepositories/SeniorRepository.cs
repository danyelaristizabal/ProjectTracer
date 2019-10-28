namespace ProjectTracer.Repository
{
    public class SeniorRepository : Repository<Seniors>, ISeniorRepository
    {
        public SeniorRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public bool CheckExistance(string id, string password)
        {
            var Senior = Context.Seniors.Find(id);

            return Senior.Password.Contains(password);
        }
    }
}
