using IntegratedSystems.Domain.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Service.Interface
{
    public interface IPatientService
    {
        public List<Patient> GetPatients();
        public Patient GetPatientById(Guid? id);
        public Patient CreateNewPatient(Patient patient);
        public Patient UpdatePatient(Patient patient);
        public Patient DeletePatient(Guid id);
    }
}
