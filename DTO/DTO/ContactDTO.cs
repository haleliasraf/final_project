using System;
using System.Collections.Generic;

namespace DTO.DTO;

public partial class ContactDTO
{
    public int Id { get; set; }

    public string Phon { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Details { get; set; } = null!;

    //public DateOnly Date { get; set; }
}
