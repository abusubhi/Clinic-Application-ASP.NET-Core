using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Clinic.Data.Entities;
using Clinic.Service.Abstracts;
using Clinic.Data.DTOS;

namespace ClinicApplicat.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        public async Task<IActionResult> Index()
        {
            List<Patient> patients = await _patientService.GetPatientsListAsync();
            return View(patients); // Passing the patients list to the view
        }



        public IActionResult Create()
        {
            return View();
        }


        public IActionResult CreatePaient()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Create(IPatientService patientService)
        //{


        //    var result = await _patientService.CreatePatientAsync(patientService);

        //    return View(result);

        //}
    }
}

