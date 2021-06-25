using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HospitalApp.Core.Entities
{
    public class Patient
    {
        public Patient()
        {
            Doctors = new Collection<Doctor>();
            Appointments = new Collection<Appointment>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FileNumber { get; set; }
        public bool IsDeleted { get; set; }
        public int DoctorId { get; set; }
        public int AppointmentId { get; set; }
        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }


    }
}
