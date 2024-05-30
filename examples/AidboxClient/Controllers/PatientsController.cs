using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AidboxClient.Models;
using Aidbox.FHIR.Resource;
using Aidbox.FHIR.Search;
using Aidbox.FHIR.Utils;

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
    var query = this.Request.Query;
    var name = query["name"];
    var isActive = query["is-active"] == "true";
    var gender = query["gender"];
    var birthdate = query["birthdate"];

    var searchParams = new PatientSearchParameters {
      Name = name,
      Active = isActive ? "true" : null,
      Gender = gender,
      Birthdate = birthdate
    };

    var (patients, error) = await _aidbox.GetClient().Search<Patient>(searchParams);

    Console.WriteLine("zz" + error);

    var patientVMs = patients?.Entry?
        .Where(patient => patient.Resource is not null)
        .Select(patient => new PatientItemViewModel(patient.Resource!));

    return View(new
    {
      Patients = patientVMs,
      Search = new { name, isActive, gender, birthdate }
    });
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
