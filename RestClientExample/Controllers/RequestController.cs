using RestClientExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RestClientExample.Controllers
{
    [Authorize]
    public class RequestController : Controller
    {
        private RequestDb db = new RequestDb();
        
        public ActionResult Index()
        {

            List<Request> requests = db.Requests.ToList();
            ViewBag.requests = requests;
            return View();
        }

        //Request/Create
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string name,string url,string action)
        {
            Request oRequest = new Request();
            oRequest.Name = name;
            oRequest.UrlBase = url;
            oRequest.Action = action;

            if (ModelState.IsValid)
            {
                db.Requests.Add(oRequest);
                db.SaveChanges();

            }
            return View();
        }
        public ActionResult Edit() 
        {
            return View();
        }
        public ActionResult Delete(int id = 0)
        {
            Request oRequest = db.Requests.Find(id);
            if (oRequest == null)
            {
                return HttpNotFound();
            }
            ViewBag.oRequest = oRequest;
            return View(oRequest);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Request oRequest = db.Requests.Find(id);
            db.Requests.Remove(oRequest);
            db.SaveChanges();
            return RedirectToAction("/Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }

}
