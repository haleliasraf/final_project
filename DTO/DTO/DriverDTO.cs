using System;
using System.Collections.Generic;

namespace DTO.DTO;

public partial class DriverDTO
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phon { get; set; } = null!;
}

//    public virtual ICollection<ShipDTO> Ships { get; set; } = new List<ShipDTO>();

//    public virtual ICollection<UpcomingTravelDTO> UpcomingTravels { get; set; } = new List<UpcomingTravelDTO>();
//}
