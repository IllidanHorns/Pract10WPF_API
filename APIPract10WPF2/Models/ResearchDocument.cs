using System;
using System.Collections.Generic;

namespace APIPract10WPF2.Models;

public partial class ResearchDocument
{
    public int IdAppoinmentDocument { get; set; }

    public string Rtf { get; set; } = null!;

    public string NameResearch { get; set; } = null!;

    public byte[]? Attachment { get; set; }
}
