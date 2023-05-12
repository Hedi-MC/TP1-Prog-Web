﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP2_Skyrim.Models;

namespace TP2_Skyrim.Controllers
{
    public class GestionEnfantController : Controller
    {
        private Database DB { get; set; }
        public GestionEnfantController(Database db) { this.DB = db; }

        //[Route("/GestionEnfant/Delete/{id:int?}")]
        // GET: GestionEnfantController/Delete/5
        public ActionResult Delete(int? id)
        {
            //if (id == null) return View("NotFound"); //un beau 404 page si ya rien
            //foreach (Enfant ef in DB.Enfants)
            //{
            //    if (ef.EnfantId == id) { return View("Delete", ef); } //retourne detail pour qu'il sache quel cshtml utiliser + le actual enfant
            //}
            //return View("NotFound");    //si ca mess up somehow, on mets un 404



            if (id == null) return View("NotFound"); //un beau 404 page si ya rien
            Enfant enfant = DB.Enfants.Where(e => e.EnfantId == id).Single();
            return View(enfant);
            return View("NotFound");    //si ca mess up somehow, on mets un 404

        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Enfant enfant)
        {
            try
            {
                Enfant ef = DB.Enfants.Where(e => e.EnfantId == id).Single();
               
                ef.Parent.Enfants.Remove(ef);

                DB.Enfants.Remove(ef);




                return RedirectToAction("Index","Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
