using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AidboxClient.Models;
using Aidbox.FHIR.Resource;
using Aidbox.FHIR.Base;

namespace AidboxClient.Controllers;

[Route("[controller]")]
public class PatientsController : Controller
{
    private readonly IAidboxClientService _aidbox;

    public PatientsController(IAidboxClientService aidbox)
    {
        _aidbox = aidbox;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var (patients, error) = await _aidbox.GetClient().Search<Patient>();
        var patientVMs = patients?.Entry?
            .Where(patient => patient.Resource is not null)
            .Select(patient => new PatientItemViewModel(patient.Resource!));

        return View(patientVMs);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(string id)
    {
        var (patient, error) = await _aidbox.GetClient().Read<Patient>(id);
        var patientVM = new PatientItemViewModel(patient!);

        return View(patientVM);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
