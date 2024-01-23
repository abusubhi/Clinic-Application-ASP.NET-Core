using Clinic.Service.Abstracts;
using Clinic.Service.Implementation;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Clinic.Service
{
    public static class ModuleServiceDependancies
    {
        public static IServiceCollection AddServiceDependancies(this IServiceCollection services)
        {
            services.AddScoped<IPatientService, PatientServices>();
            return services;
        }

    }
}