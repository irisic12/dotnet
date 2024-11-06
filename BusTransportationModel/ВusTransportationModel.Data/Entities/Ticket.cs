using System.ComponentModel.DataAnnotations.Schema;

namespace BusTransportationModel.Data.Entities;

[Table("ticket")]
public class Ticket : BaseEntity
{
    public int VoyageId { get; set; }
    public Voyage Voyage { get; set; }
    
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
}