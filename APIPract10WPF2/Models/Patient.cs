using System;
using System.Collections.Generic;

namespace APIPract10WPF2.Models;

public partial class Patient
{
    public long IdPatient { get; set; }

    public string Surname { get; set; } = null!;

    public string NamePatient { get; set; } = null!;

    public string? Patronymic { get; set; }

    public DateOnly BirhDate { get; set; }

    public string AddressOfPatient { get; set; } = null!;

    public string? LivingAddress { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Nickname { get; set; }

}
