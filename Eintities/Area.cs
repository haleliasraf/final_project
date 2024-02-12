using System;
using System.Collections.Generic;

namespace Eintitees;

public partial class Area
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<UpcomingTravel> UpcomingTravels { get; set; } = new List<UpcomingTravel>();
}
