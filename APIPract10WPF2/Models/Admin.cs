using System;
using System.Collections.Generic;

namespace APIPract10WPF2.Models;

public partial class Admin
{
    public int? IdAdmin { get; set; }

    public string Surname { get; set; } = null!;

    public string NameAdmin { get; set; } = null!;

    public string? Patronymic { get; set; }

    public string EnterPassword { get; set; } = null!;
}
