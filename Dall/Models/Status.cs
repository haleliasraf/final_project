using System;
using System.Collections.Generic;

namespace DL.Models;

public partial class Status
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Ship> Ships { get; set; } = new List<Ship>();
}
