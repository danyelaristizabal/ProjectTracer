namespace ProjectTracer.Repository
{
    public class SeniorRepository : Repository<Senior>, ISeniorRepository
    {
        public SeniorRepository(ProjectTracerEntities Context) : base(Context)
        {
        }
        public bool CheckExistance(string id, string password)
        {
            var Senior = Context.Senior.Find(id);

            return Senior.Password.Contains(password);
        }
    }
}
