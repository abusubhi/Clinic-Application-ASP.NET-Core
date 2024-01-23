using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Data.DTOS;
using Clinic.Data.Entities;
namespace Clinic.Service.Abstracts
{
    public interface IPatientService
    {
        public Task<List<Patient>> GetPatientsListAsync();
        public Task<Patient> CreatePaient(ReqPatientDTO model);
    }

    
}
