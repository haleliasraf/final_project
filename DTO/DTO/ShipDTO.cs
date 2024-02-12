using System;
using System.Collections.Generic;

namespace DTO.DTO;

public partial class ShipDTO
{
    public int Id { get; set; }

    public string ShipAdress { get; set; } = null!;

    public int UserId { get; set; }

    public string Url { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly Data { get; set; }

    public int StatusId { get; set; }

    public int? DriverId { get; set; }

    //public virtual DriverDTO? Driver { get; set; }

    //public virtual StatusDTO Status { get; set; } = null!;

    //public virtual UserDTO User { get; set; } = null!;
}
