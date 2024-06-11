using System;
using System.Collections.Generic;

namespace APIPract10WPF2.Models;

public partial class Appoinment
{
    public int? IdAppoinment { get; set; }

    public DateOnly AppointmentDate { get; set; }

    public TimeOnly AppointmentTime { get; set; }

    public int DoctorId { get; set; }

    public long PatientId { get; set; }

    public int? StatusId { get; set; }
}
