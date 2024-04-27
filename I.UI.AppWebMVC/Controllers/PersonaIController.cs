using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using O.BL;
using O.EN;

namespace O.UI.AppWebMVC.Controllers
{
    public class PersonaOController : Controller
    {
        // GET: PersonaIController
        public async Task<ActionResult> Index1()
        {
            var persoO = await PersonaOBL.GetAll();
            return View(persoO);
        }

        // GET: PersonaIController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var persoO = await PersonaOBL.GetById(id);
            return View(persoO);
        }

        // GET: PersonaIController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaIController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Personao persoO)
        {
            try
            {
                var result = await PersonaOBL.Create(persoO);
                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaIController/Edit/5
        public async Task<ActionResult> Edit(int Id)
        {
            var result = await PersonaOBL.GetById(Id);
            return View(result);
        }

        // POST: PersonaIController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Personao persoO)
        {
            try
            {
                var result = await PersonaOBL.Update(persoO);
                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaIController/Delete/5
        public async Task<ActionResult> Delete(int Id)
        {
            var result = await PersonaOBL.GetById(Id);
            return View(result);
        }

        // POST: PersonaIController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Personao persoO)
        {
            try
            {
                var result = await PersonaOBL.Delete(persoO);
                return RedirectToAction(nameof(Index1));
            }
            catch
            {
                return View();
            }
        }
    }
}
