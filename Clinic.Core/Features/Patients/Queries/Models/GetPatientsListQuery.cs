using MediatR;
using Clinic.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Features.Patients.Queries.Models
{
    public class GetPatientsListQuery : IRequest<List<Patient>>
    {
        public int MyProperty { get; set; }
    }
}
