﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BusTransportationModel.Data.Entities;

[Table("role")]
public class Role : BaseEntity
{
    public string Title { get; set; }
}