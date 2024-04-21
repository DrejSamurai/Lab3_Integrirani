using IntegratedSystems.Domain.Domain_Models;
using IntegratedSystems.Domain.DTOs;
using IntegratedSystems.Repository.Interface;
using IntegratedSystems.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Service.Implementation
{
    public class VaccinationService : IVaccinationService
    {
        private readonly IRepository<VaccinationCenter> _vaccinationCenterRepository;
        private readonly IRepository<Vaccine> _vaccineRepository;

        public VaccinationService(IRepository<VaccinationCenter> repository, IRepository<Vaccine> vaccineRepository)
        {
            this._vaccinationCenterRepository = repository;
            this._vaccineRepository = vaccineRepository;
        }

        public List<Vaccine> GetVaccinesForCenter(Guid? centerId)
        {
            return _vaccineRepository.GetAll().Where(z => z.Center.Id == centerId).ToList();
        }

        public List<Vaccine> GetVaccinesForPatient(Guid? patientId)
        {
            return _vaccineRepository.GetAll().Where(z => z.PatientId == patientId).ToList();
        }

        public void ScheduleVaccine(VaccinationDTO dto)
        {
            Vaccine vaccine = new Vaccine();
            vaccine.Manufacturer = dto.manufacturer;
            vaccine.Certificate = Guid.NewGuid();
            vaccine.VaccinationCenter = dto.vaccCenterId;
            vaccine.PatientId = dto.patientId;
            vaccine.DateTaken = dto.vaccinationDate;
            vaccine.Center = _vaccinationCenterRepository.Get(dto.vaccCenterId);
            _vaccineRepository.Insert(vaccine);
        }
    }
}
