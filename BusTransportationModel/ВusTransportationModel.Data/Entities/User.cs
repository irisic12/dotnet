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
    
    
}