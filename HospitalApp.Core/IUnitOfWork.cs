using HospitalApp.Core.Entities;
using HospitalApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Core
{
    public interface IUnitOfWork
    {
        IRepository<Doctor> Doctors { get; }

        IRepository<Patient> Patients { get; }

        IRepository<Appointment> Appointments { get; }

        Task CommitAsync();

        void Commit();
    }
}
