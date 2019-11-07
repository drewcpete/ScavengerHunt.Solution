using Microsoft.AspNetCore.Mvc;
using ScavengerHunt.Models;
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
            ViewBag.ItemId = new SelectList(_db.Items, "ItemsId", "ItemName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Quest quest, int ItemId)
        {

            _db.Quests.Add(quest);
            if (ItemId != 0)
            {
                _db.QuestItems.Add(new QuestItem() { ItemId = ItemId, QuestId = quest.QuestId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisQuest = _db.Quests

                .Include(quest => quest.Item)
                .ThenInclude(join => join.Item)
                .FirstOrDefault(quest => quest.QuestId == id);
            return View(thisQuest);
        }

        public ActionResult Edit(int id)
        {
            var thisQuest = _db.Quests.FirstOrDefault(quest => quest.QuestId == id);

            ViewBag.ItemId = new SelectList(_db.Items, "ItemId", "ItemName");
            return View(thisQuest);
        }

        [HttpPost]
        public ActionResult Edit(Quest quest, int ItemId)
        {

            if (ItemId != 0)
            {
                _db.QuestItems.Add(new QuestItem() { ItemId = ItemId, QuestId = quest.QuestId });
            }
            _db.Entry(quest).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult AddItems(int id)
        {
            var thisQuest = _db.Quests.FirstOrDefault(quest => quest.QuestId == id);
            ViewBag.ItemId = new SelectList(_db.Items, "ItemId", "ItemName");
            return View(thisQuest);
        }

        [HttpPost]
        public ActionResult AddItems(Quest quest, int ItemId)
        {
            if (ItemId != 0)
            {
                _db.QuestItems.Add(new QuestItem() { ItemId = ItemId, QuestId = quest.QuestId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var thisQuest = _db.Quests.FirstOrDefault(quest => quest.QuestId == id);
            return View(thisQuest);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisQuest = _db.Quests.FirstOrDefault(quest => quest.QuestId == id);
            _db.Quests.Remove(thisQuest);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult DeleteItem(int joinId)
        {
            var joinEntry = _db.QuestItems.FirstOrDefault(entry => entry.QuestItemId == joinId);
            _db.QuestItems.Remove(joinEntry);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}