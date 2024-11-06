using System.ComponentModel.DataAnnotations.Schema;

namespace BusTransportationModel.Data.Entities;

[Table("users")]
public class User : BaseEntity
{
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }
    public string PasswordHash { get; set; }
    public int RoleId { get; set; }
    public Role Role { get; set; }
    
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>(); 
    public ICollection<Voyage> UserVoyages { get; set; } = new List<Voyage>();
    public ICollection<Voyage> AdminVoyages { get; set; } = new List<Voyage>();
}