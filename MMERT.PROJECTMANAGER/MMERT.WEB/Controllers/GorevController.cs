using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MMERT.WEB.Controllers
{
    public class GorevController : Controller
    {
        //
        // GET: /Gorev/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GorevEkle()
        {
            return View();
        }
        
        public IEnumerable<SelectListItem> DropDwnProje()
        {
            using(var db=new MMERT.DATA.Context())
            {
                var proje = db.Projects.ToList();
                IEnumerable<SelectListItem> prjctList = new List<SelectListItem>();
                prjctList = (from m in proje select m).AsEnumerable().Select(m => new SelectListItem() { Text = m.PROJECTNAME, Value = m.ID.ToString() });
                return prjctList;

            }
        }
                                              

    }
}
