namespace ProjectTracer.Models
{
    public interface IUser
    {
      string Name { get;  set; }
      string Password { get; set; }
      string InvitationCode { get; set; }

    }
}
