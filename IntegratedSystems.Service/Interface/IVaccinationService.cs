using IntegratedSystems.Domain.Domain_Models;
using IntegratedSystems.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Service.Interface
{
    public interface IVaccinationService
    {
        public void ScheduleVaccine(VaccinationDTO dto);

        public List<Vaccine> GetVaccinesForCenter(Guid? centerId);

        public List<Vaccine> GetVaccinesForPatient(Guid? patientId);

    }
}
