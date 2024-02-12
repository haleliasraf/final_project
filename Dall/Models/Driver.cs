using System;
using System.Collections.Generic;

namespace DL.Models;

public partial class Driver
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phon { get; set; } = null!;

    public virtual ICollection<Ship> Ships { get; set; } = new List<Ship>();

    public virtual ICollection<UpcomingTravel> UpcomingTravels { get; set; } = new List<UpcomingTravel>();
}
