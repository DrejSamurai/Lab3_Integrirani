using IntegratedSystems.Domain.Domain_Models;
using IntegratedSystems.Repository.Interface;
using IntegratedSystems.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Service.Implementation
{
    public class VaccinationCentarService : IVaccinationCentarService
    {
        private readonly IRepository<VaccinationCenter> _vaccinationCentarRepository;

        public VaccinationCentarService(IRepository<VaccinationCenter> vaccinationCentarRepository)
        {
            _vaccinationCentarRepository = vaccinationCentarRepository;
        }

        public VaccinationCenter CreateNewVaccinationCenter(VaccinationCenter vaccinationCenter)
        {
            return _vaccinationCentarRepository.Insert(vaccinationCenter);
        }

        public VaccinationCenter DeleteVaccinationCenter(Guid id)
        {
            var vaccinationCentar = _vaccinationCentarRepository.Get(id);
            return _vaccinationCentarRepository.Delete(vaccinationCentar);
        }

        public VaccinationCenter GetVaccinationCenterById(Guid? id)
        {
           return _vaccinationCentarRepository.Get(id);
        }

        public List<VaccinationCenter> GetVaccinationCenters()
        {
            return _vaccinationCentarRepository.GetAll().ToList();
        }

        public VaccinationCenter UpdateVaccinationCenter(VaccinationCenter vaccinationCenter)
        {
            return _vaccinationCentarRepository.Update(vaccinationCenter);
        }

        public void LowerCapacity(Guid id)
        {
            var vaccCenter = this.GetVaccinationCenterById(id);
            vaccCenter.MaxCapacity--;
            this.UpdateVaccinationCenter(vaccCenter);
        }
    }
}
