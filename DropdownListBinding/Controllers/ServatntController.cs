using System.Collections.Generic;
using System.Web.Mvc;
using DropdownListBinding.Models;
using DropdownListBinding.Models.ViewModel;

namespace DropdownListBinding.Controllers
{
    public class ServantController : Controller
    {
        private Servants_DbContext _db = new Servants_DbContext();

        [HttpGet]
        public ActionResult Create()
        {
            var skillsList = new List<SelectListItem>
            {
                new SelectListItem {Value = "1", Text= "Junior Servant" },
                new SelectListItem {Value = "2", Text= "Senior Servant" },
                new SelectListItem {Value = "3", Text= "Clark" },
                new SelectListItem {Value = "4", Text= "Puine" },
            };
            var viewModel = new ServantsViewModel
            {
                Servants = new Servants(),
                SkillsList = skillsList
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServantsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _db.servants.Add(viewModel.Servants);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
