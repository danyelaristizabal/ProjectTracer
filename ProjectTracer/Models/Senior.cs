namespace ProjectTracer.Models
{
    class Senior : IUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string InvitationCode { get; set; }
    }
}
