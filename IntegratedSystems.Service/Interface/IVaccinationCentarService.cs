using IntegratedSystems.Domain.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Service.Interface
{
    public interface IVaccinationCentarService
    {
        public List<VaccinationCenter> GetVaccinationCenters();
        public VaccinationCenter GetVaccinationCenterById(Guid? id);
        public VaccinationCenter CreateNewVaccinationCenter(VaccinationCenter vaccinationCenter);
        public VaccinationCenter UpdateVaccinationCenter(VaccinationCenter vaccinationCenter);
        public VaccinationCenter DeleteVaccinationCenter(Guid id);

        public void LowerCapacity(Guid id);
    }
}
