using System;
using System.Collections.Generic;

namespace Eintitees;

public partial class Ship
{
    public int Id { get; set; }

    public string ShipAdress { get; set; } = null!;

    public int UserId { get; set; }

    public string Url { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly Data { get; set; }

    public int StatusId { get; set; }

    public int? DriverId { get; set; }

    public virtual Driver? Driver { get; set; }

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
