﻿using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaNuevoRosario.Domain
{
    public class AppointmentState
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
