
namespace ProjectTracer.Models
{
    class Client : IUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string InvitationCode { get; set; }
    }
}
