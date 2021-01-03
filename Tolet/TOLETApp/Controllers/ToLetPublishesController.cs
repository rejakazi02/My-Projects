using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TOLETApp.Models;

namespace TOLETApp.Controllers
{
    public class ToLetPublishesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ToLetPublishes
        public ActionResult Index()
        {
            return View(db.ToLetPublishs.ToList());
        }

        // GET: ToLetPublishes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToLetPublish toLetPublish = db.ToLetPublishs.Find(id);
            if (toLetPublish == null)
            {
                return HttpNotFound();
            }
            return View(toLetPublish);
        }

        // GET: ToLetPublishes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToLetPublishes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AreaName,ToLetFromMonth,RoomType,HouseRent,Location,PhoneNumber,Note")] ToLetPublish toLetPublish)
        {
            if (ModelState.IsValid)
            {
                db.ToLetPublishs.Add(toLetPublish);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toLetPublish);
        }

        // GET: ToLetPublishes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToLetPublish toLetPublish = db.ToLetPublishs.Find(id);
            if (toLetPublish == null)
            {
                return HttpNotFound();
            }
            return View(toLetPublish);
        }

        // POST: ToLetPublishes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AreaName,ToLetFromMonth,RoomType,HouseRent,Location,PhoneNumber,Note")] ToLetPublish toLetPublish)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toLetPublish).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toLetPublish);
        }

        // GET: ToLetPublishes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ToLetPublish toLetPublish = db.ToLetPublishs.Find(id);
            if (toLetPublish == null)
            {
                return HttpNotFound();
            }
            return View(toLetPublish);
        }

        // POST: ToLetPublishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ToLetPublish toLetPublish = db.ToLetPublishs.Find(id);
            db.ToLetPublishs.Remove(toLetPublish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
