using Clinic.Service.Abstracts;
using Clinic.Service.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Clinic.Core
{
    public static class ModuleCoreDependancies
    {
        public static IServiceCollection AddCoreDependancies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddTransient<IPatientService, PatientServices>();
            return services;
        }

    }
}