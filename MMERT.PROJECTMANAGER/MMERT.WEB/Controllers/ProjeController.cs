using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MMERT.DATA;

namespace MMERT.WEB.Controllers
{
    public class ProjeController : Controller
    {
        private Context _context;
        private IUnitOfWork _uow;
        MMERT.SERVICE.ProjectsService srvcProject;
        public ProjeController()
        {
            _context = new Context();
            _uow = new UnitOfWork(_context);
            srvcProject = new MMERT.SERVICE.ProjectsService(_uow);

        }
        //
        // GET: /Proje/

        public ActionResult Index(MMERT.MODEL.Projects prjcts)
        {
            List<MMERT.MODEL.Projects> ls = srvcProject.Listing(prjcts);
            return View(ls);
        }

        public ActionResult ProjeEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProjeEkle(MMERT.MODEL.Projects prjcts)
        {
            srvcProject.Insert(prjcts);
            _uow.SaveChanges();
            ViewBag.Ekle = "Eklendi";
            return View("Projeler"); 
        }

    }
}
