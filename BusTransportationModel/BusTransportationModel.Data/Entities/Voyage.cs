using System.ComponentModel.DataAnnotations.Schema;

namespace BusTransportationModel.Data.Entities;

[Table("voyages")]
public class Voyage : BaseEntity
{
    public int RouteID { get; set; }
    public Route Route { get; set; }
    
    public int AdminId { get; set; }
    public User Admin { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }
    
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>(); 
    public ICollection<Voyage> AdminVoyages { get; set; } = new List<Voyage>(); 
}