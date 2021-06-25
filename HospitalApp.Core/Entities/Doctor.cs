using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HospitalApp.Core.Entities
{
    public class Doctor
    {
        public Doctor()
        {
            Patients = new Collection<Patient>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }

    }
}
