using Microsoft.AspNetCore.Mvc;
using ScavengerHunt.Models;
using ScavengerHunt.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ScavengerHunt.Controllers
{
    public class QuestsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public QuestsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Quest> model = _db.Quests.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.ItemId = new SelectList(_db.Items, "ItemId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Quest quest)
        {
            _db.Quests.Add(quest);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Quest thisQuest = _db.Quests.FirstOrDefault(quests => quests.QuestId == id);
            return View(thisQuest);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            Quest thisQuest = _db.Quests.FirstOrDefault(quests => quests.QuestId == id);

            return View(thisQuest);
        }

        [HttpPost]
        public ActionResult Edit(Quest quest)
        {
            _db.Entry(quest).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}