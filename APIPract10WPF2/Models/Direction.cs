using System;
using System.Collections.Generic;

namespace APIPract10WPF2.Models;

public partial class Direction
{
    public string IdDirection { get; set; } = null!;

    public int SpecialistId { get; set; }

    public long PatientId { get; set; }

}
