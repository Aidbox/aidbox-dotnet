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
        // var (patients, error) = await _aidbox.GetClient().Search<Patients>();
        return View();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(string id)
    {
        var (patient, error) = await _aidbox.GetClient().Read<Patient>(id);

        Console.WriteLine(error);
        Console.WriteLine(patient?.Active);

        return View(new
        {
            Name = patient?.Name?.First().Text,
            Active = patient?.Active,
            patient?.Gender,
            BirthDate = new DateOnly(2000, 1, 1),
            Address = patient?.Address?.First().City,
            PatientId = patient?.Id
        });
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
