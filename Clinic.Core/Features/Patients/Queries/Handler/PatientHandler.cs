using Clinic.Core.Features.Patients.Queries.Models;
using Clinic.Data.Entities;
using Clinic.Service.Abstracts;
using Clinic.Service.Implementation;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Features.Patients.Queries.Handler
{
    public class PatientHandler : IRequestHandler<GetPatientsListQuery, List<Patient>>
    {



        #region Fields
        private readonly IPatientService _patientService;

        #endregion

        #region Constructor
        public PatientHandler(IPatientService patientService)
        {
            _patientService = patientService;
        }
        #endregion

        #region Handel Function
        public async Task<List<Patient>> Handle(GetPatientsListQuery request, CancellationToken cancellationToken)
        {
            return await _patientService.GetPatientsListAsync();
        }
        #endregion

    }
}
