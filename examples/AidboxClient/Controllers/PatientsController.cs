using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AidboxClient.Models;
using Aidbox.FHIR.Resource;
using Aidbox.FHIR.Search;

namespace AidboxClient.Controllers;

public class Deceased {
  private bool _valueBool;
  private DateTime _valueDateTime;
  
  public Deceased(DateTime value) {
    _valueDateTime = value;
  }
  
  public Deceased(bool value) {
    _valueBool = value;
  }
  
  public bool GetBool() {
    return _valueBool;
  }
  
  public DateTime GetDateTime() {
    return _valueDateTime;
  }
  
  public static implicit operator Deceased(bool value) {
    return new Deceased(value);
  }
  
  public static implicit operator Deceased(DateTime value) {
    return new Deceased(value);
  }
  
  public static implicit operator DateTime(Deceased value) {
    return value.GetDateTime();
  }
  
  public static implicit operator bool(Deceased value) {
    return value.GetBool();
  }
}

public class MyPatient {
  public Deceased? Deceased;
}

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
        // var pat = new MyPatient {
        //     Deceased = new DateTime(2000, 1, 1, 23, 59, 0)
        // };

        // Console.WriteLine(pat.Deceased.GetBool());

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

        Console.WriteLine("query string " + searchParams.ToQueryString());

        var (patients, error) = await _aidbox.GetClient().Search<Patient>(searchParams);

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
