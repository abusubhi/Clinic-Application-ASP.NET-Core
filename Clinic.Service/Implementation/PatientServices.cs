using Clinic.Data.DTOS;
using Clinic.Data.Entities;
using Clinic.Infrastructire.Data;
using Clinic.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Service.Implementation
{
    public class PatientServices : IPatientService
    {
        #region Fields
        private readonly ApplicationDbContext _dbContext;
    #endregion

    #region constructor
 public PatientServices(ApplicationDbContext dbContext)
        {
             _dbContext =  dbContext;
        }
    #endregion
        #region Handel Functions
        public async Task<List<Patient>> GetPatientsListAsync()
        {
            return await  _dbContext.Patients.ToListAsync();
        }

        #endregion

        public async Task<bool> CreatePatientAsync(Patient patient)
        {

            _dbContext.Patients.Add(patient);
            await _dbContext.SaveChangesAsync(); 

            return true;
        }

        public async Task<Patient> CreatePaient(ReqPatientDTO model)
        {
            if (model==null)
            {
                return null;
            }
            var newPatient = model.Convert();
            _dbContext.Add(newPatient);
            return newPatient;
        }
    }
}
