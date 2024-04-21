using IntegratedSystems.Domain.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Domain.DTOs
{
    public class CenterDetailsDTO
    {
        public List<Vaccine> vaccines { get; set; }
        public VaccinationCenter vaccCenter { get; set; }
    }
}
