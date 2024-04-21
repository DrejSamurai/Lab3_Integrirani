using IntegratedSystems.Domain.Domain_Models;
using IntegratedSystems.Repository.Interface;
using IntegratedSystems.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Service.Implementation
{
    public class PatientService : IPatientService
    {
        private readonly IRepository<Patient> _patientRepository;

        public PatientService(IRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }


        public Patient CreateNewPatient(Patient patient)
        {
            return _patientRepository.Insert(patient);
          
        }

        public Patient DeletePatient(Guid id)
        {
            Patient patient = _patientRepository.Get(id);
            return _patientRepository.Delete(patient);
        }

        public Patient GetPatientById(Guid? id)
        {
            Patient patient = _patientRepository.Get(id);
            return patient;
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = _patientRepository.GetAll().ToList();
            return patients;
        }

        public Patient UpdatePatient(Patient patient)
        {
            return _patientRepository.Update(patient);
        }
    }
}
