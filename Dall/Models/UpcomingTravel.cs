using System;
using System.Collections.Generic;

namespace DL.Models;

public partial class UpcomingTravel
{
    public int Id { get; set; }

    public int AreaId { get; set; }

    public string AdressExit { get; set; } = null!;

    public string AdressGounn { get; set; } = null!;

    public int UserId { get; set; }

    public int Payment { get; set; }

    public DateOnly Date { get; set; }

    public int DriverId { get; set; }

    public string Time { get; set; } = null!;

    public virtual Area Area { get; set; } = null!;

    public virtual Driver Driver { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
