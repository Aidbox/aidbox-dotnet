using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AidboxClient.Models;
using Aidbox.FHIR.Resource;

namespace AidboxClient.Controllers;

[Route("[controller]")]
public class ObservationsController : Controller
{
    private readonly IAidboxClientService _aidbox;

    public ObservationsController(IAidboxClientService aidbox)
    {
        _aidbox = aidbox;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        // var (patients, error) = await _aidbox.GetClient().Search<Observation>();
        return View();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        var (patient, error) = await _aidbox.GetClient().Read<Patient>("f51bd184-f83e-4de3-818e-bed3715b54fe");
        
        Console.WriteLine(error);
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
