using System;
using System.Collections.Generic;

namespace Paramotor.Models.Entities;

public partial class Slide
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Subtitle { get; set; }

    public string? Url { get; set; }

    public string? Urltext { get; set; }

    public string? Urltarget { get; set; }

    public string? Image { get; set; }

    public bool? Isview { get; set; }

    public int? Order { get; set; }
}
