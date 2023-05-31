using System;
using System.Collections.Generic;

namespace Paramotor.Models.Entities;

public partial class Team
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Image { get; set; }

    public string? Facebook { get; set; }

    public string? Twitter { get; set; }

    public string? Instagram { get; set; }

    public string? Youtube { get; set; }

    public string? Linkedin { get; set; }

    public bool? Isview { get; set; }

    public int? Order { get; set; }
}
