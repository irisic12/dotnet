using System.ComponentModel.DataAnnotations.Schema;

namespace BusTransportationModel.Data.Entities;

[Table("route")]
public class route : BaseEntity
{
    public int TotalPath {get; set;}    
}