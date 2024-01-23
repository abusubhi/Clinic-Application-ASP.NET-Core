using Clinic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.DTOS
{
    public class ReqPatientDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Patient Convert()
        {
            return new Patient
            {
                Name = Name,
                Phone = Phone,
                Email = Email,
                Address = Address
            };
    }
    }

    
}
