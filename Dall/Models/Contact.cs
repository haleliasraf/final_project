using System;
using System.Collections.Generic;

namespace DL.Models;

public partial class Contact
{
    public int Id { get; set; }

    public string Phon { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Details { get; set; } = null!;

    public DateOnly Date { get; set; }

    public string Status { get; set; } = null!;
}
