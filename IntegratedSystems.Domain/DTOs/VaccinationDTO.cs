using IntegratedSystems.Domain.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Domain.DTOs
{
    public class VaccinationDTO
    {
        public List<Patient>? patients { get; set; }

        public List<String>? manufacturers { get; set; }

        public Guid patientId { get; set; }

        public DateTime vaccinationDate { get; set; }

        public Guid vaccCenterId { get; set; }

        public String? manufacturer { get; set; }
    }
}
