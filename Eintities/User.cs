using System;
using System.Collections.Generic;

namespace Eintitees;

public class User
{
    public int Id { get; set; }

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Level { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Ship> Ships { get; set; } = new List<Ship>();

    public virtual ICollection<UpcomingTravel> UpcomingTravels { get; set; } = new List<UpcomingTravel>();
}
