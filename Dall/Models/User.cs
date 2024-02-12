using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DL.Models;

public partial class User
{
    public int Id { get; set; }

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Level { get; set; }

    public string FirstName { get; set; } = null!;

    [EmailAddress]
    public string? Email { get; set; }

    public string? LastName { get; set; }

    public virtual ICollection<Ship> Ships { get; set; } = new List<Ship>();

    public virtual ICollection<UpcomingTravel> UpcomingTravels { get; set; } = new List<UpcomingTravel>();
}
