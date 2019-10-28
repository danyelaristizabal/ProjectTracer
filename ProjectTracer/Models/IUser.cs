namespace ProjectTracer.Models
{
    public interface IUser
    {
      string Id { get; set;  }
      string Password { get; set; }
      string InvitationCode { get; set; }

    }
}
