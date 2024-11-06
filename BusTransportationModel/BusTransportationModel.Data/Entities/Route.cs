using System.ComponentModel.DataAnnotations.Schema;

namespace BusTransportationModel.Data.Entities;

[Table("route")]
public class Route : BaseEntity
{
    public int TotalPath {get; set;}
    public ICollection<Voyage> Voyages { get; set; } = new List<Voyage>();
}