using System;
using System.Collections.Generic;

namespace APIPract10WPF2.Models;

public partial class AnalysDocument
{
    public int IdAppoinmentDocument { get; set; }

    public string NameAnalys { get; set; } = null!;

    public string Rtf { get; set; } = null!;
}
