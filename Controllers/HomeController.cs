using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PojistakNET.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using X.PagedList.Extensions;

namespace PojistakNET.Controllers;

public class HomeController : Controller
{
    // HomeController spravuje JEN samotné pojištěnce,
    // tj. tvorba, editace a mazání profilu pojištěnců

    private readonly ILogger<HomeController> _logger;
    private readonly InsuranceContext _context;

    // Konstruktor s oběma závislostmi
    public HomeController(InsuranceContext context, ILogger<HomeController> logger)
    {
        _context = context;  // Injikuje kontext pro práci s databází
        _logger = logger;    // Injikuje logger pro logování
    }

    public IActionResult Index()
    {
        return RedirectToAction(nameof(Insurer)); // Přesměrování na Insurer
    }

    // Pojištěnci
    public IActionResult Insurer(int? page)
    {
        // Nastavíme velikost stránky (počet pojištěnců na jedné stránce)
        int pageSize = 5;
        int pageNumber = page ?? 1; // Pokud není stránka definována, vezmeme první stránku

        // Načte seznam pojištěnců z databáze, stránkování přímo na úrovni databáze
        var insurersPagedList = _context.Insurers
            .OrderBy(i => i.LastName) // Řadíme podle příjmení
            .ToPagedList(pageNumber, pageSize); // Aplikujeme stránkování

        // Přidání logování pro diagnostiku
        _logger.LogInformation("Pojištěnci načteni: " + insurersPagedList.Count);

        // Předání seznamu pojištěnců do view
        return View(insurersPagedList);
    }

    // Pojištění
    public IActionResult Insurance()
    {
        return View();
    }

    // Události
    public IActionResult Events()
    {
        return View();
    }

    // O aplikaci
    public IActionResult About()
    {
        return View();
    }

    // Zobrazí formulář pro přidání nového pojištěnce
    [HttpGet]
    public IActionResult AddInsurer()
    {
        return View();
    }

    // Zpracuje odeslaný formulář a přidá nového pojištěnce do databáze
    [HttpPost]
    public IActionResult AddInsurer(Insurer insurer)
    {
        if (ModelState.IsValid)
        {
            // Odstraní mezery z telefonního čísla
            insurer.Phone = insurer.Phone.Replace(" ", "");

            _context.Insurers.Add(insurer);
            _context.SaveChanges();
            return RedirectToAction("Insurer"); // Přesměrování po úspěšném přidání
        }

        return View(insurer); // Zobrazí formulář znovu, pokud validace selže
    }


    // GET: Edit
    public IActionResult EditInsurer(int insurerId)
    {
        var insurer = _context.Insurers.Find(insurerId);
        if (insurer == null)
        {
            return NotFound();
        }
        return View(insurer);
    }

    // POST: Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult EditInsurer(int Id, [Bind("Id,FirstName,LastName,Email,Phone,Street,City,Postcode")] Insurer insurer)
    {
        if (Id != insurer.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(insurer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Insurers.Any(e => e.Id == insurer.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
        }
        return View(insurer);
    }

    // GET: Delete
    public IActionResult DeleteInsurer(int insurerId)
    {
        var insurer = _context.Insurers
            .Find(insurerId);

        if (insurer == null)
        {
            return NotFound();
        }

        return View(insurer);
    }

    // POST: Delete
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int Id)
    {
        // Najít pojištěnce skrze id a email
        var insurer = _context.Insurers
            .Find(Id);
        if (insurer == null)
        {
            return NotFound();
        }

        try
        {
            _context.Insurers.Remove(insurer);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            // Logování chyb
            _logger.LogError(ex, "Chyba při mazání pojištěnce s ID {Id}", Id);
            return StatusCode(500, "Chyba serveru. Záznam nebyl smazán.");
        }

        return RedirectToAction("Index", "Home");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}