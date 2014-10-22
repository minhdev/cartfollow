using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cartfolo.Models;
using cartfolo.Services;

namespace cartfolo.Controllers
{
    public class GuestbookController : Controller
    {
        private IGuestbookService guestbookService;

        public GuestbookController(IGuestbookService guestbookService)
        {
            this.guestbookService = guestbookService;
        }

        // GET: Guestbook
        public ActionResult Index()
        {
            ViewBag.Entries = guestbookService.GetGuestbookEntries();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GuestbookEntry entry)
        {
            guestbookService.AddEntry(entry);
            return RedirectToAction("Index");
        }
    }
}