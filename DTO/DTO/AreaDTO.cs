using System;
using System.Collections.Generic;

namespace DTO.DTO;

public partial class Area
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    //public virtual ICollection<UpcomingTravelDTO> UpcomingTravels { get; set; } = new List<UpcomingTravelDTO>();
}
