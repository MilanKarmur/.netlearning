using DN_9.Data;using DN_9.Models;using Microsoft.AspNetCore.Mvc;
namespace DN_9.Controllers;
public class PlacementController:Controller{
readonly PlacementRepository repo;public PlacementController(PlacementRepository r)=>repo=r;
public IActionResult Index(string? search,string? status){ViewBag.Stats=repo.Stats();ViewBag.Search=search;ViewBag.Status=status??"All";return View(repo.All(search,status));}
[HttpGet]public IActionResult Create()=>View(new Placement());
[HttpPost,ValidateAntiForgeryToken]public IActionResult Create(Placement p){if(!ModelState.IsValid)return View(p);repo.Add(p);TempData["Message"]="Record added.";return RedirectToAction(nameof(Index));}
public IActionResult Details(int id){var p=repo.Get(id);return p==null?NotFound():View(p);}
[HttpGet]public IActionResult Edit(int id){var p=repo.Get(id);return p==null?NotFound():View(p);}
[HttpPost,ValidateAntiForgeryToken]public IActionResult Edit(Placement p){if(!ModelState.IsValid)return View(p);if(!repo.Update(p))return NotFound();TempData["Message"]="Record updated.";return RedirectToAction(nameof(Index));}
[HttpGet]public IActionResult Delete(int id){var p=repo.Get(id);return p==null?NotFound():View(p);}
[HttpPost,ActionName("Delete"),ValidateAntiForgeryToken]public IActionResult DeleteConfirmed(int id){if(!repo.Delete(id))return NotFound();TempData["Message"]="Record deleted.";return RedirectToAction(nameof(Index));}
public IActionResult Report(string? status){ViewBag.Status=status??"All";ViewBag.Stats=repo.Stats();return View(repo.All(null,status));}
}