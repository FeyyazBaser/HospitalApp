using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalApp.Core.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Patient Patient { get; set; }

    }
}
