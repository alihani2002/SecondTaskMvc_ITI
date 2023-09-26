using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SecondTaskMvc_ITI.ContextData;
using SecondTaskMvc_ITI.Models;

namespace SecondTaskMvc_ITI.Controllers
{
    public class OfficeController : Controller
    {
        private ContextITI contextITI;

        public OfficeController()
        {
            contextITI = new ContextITI();
        }
        public IActionResult Index()
        {
            List<Office> office = contextITI.Office.ToList();
            return View(office);
        }

        public IActionResult Details(int id)
        {
            var emp = contextITI.Office.Include(e => e.listOfEmpolyee).SingleOrDefault(e => e.Id == id);
            if (emp == null)
                return Content("Error");

            return View(emp);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var offices = contextITI.Office.ToList();
            return View(offices);
        }
       
        [HttpPost]
        public IActionResult Add(Office office)
        {
            contextITI.Office.Add(office);
            contextITI.SaveChanges();
            return RedirectToAction("Index");
        } public IActionResult AddToDatabase(Office emp)
        {
            contextITI.Office.Add(emp);
            contextITI.SaveChanges();
            return RedirectToAction("Index");
        }

      


        public IActionResult EditForm(int id)
        {
            var office = contextITI.Office.SingleOrDefault(c => c.Id == id);

            ViewBag.Office_Id = contextITI.Office.ToList();
            return View(office);
        }
        public IActionResult EditInDB(Office office)
        {
            var existingOffice = contextITI.Office.FirstOrDefault(o => o.Id == office.Id);

            if (existingOffice != null)
            {
                existingOffice.Name = office.Name;
                existingOffice.Location = office.Location;
            }
            else 
            {
               return NotFound();
            }
            // Update only the properties you want to change

            contextITI.SaveChanges();
            return RedirectToAction("Index");
        }

  
        public IActionResult Delete(int id)
        {
            var office = contextITI.Office.FirstOrDefault(o => o.Id == id);

            if (office == null)
            {
                return NotFound();
            }

            contextITI.Office.Remove(office);
            contextITI.SaveChanges();
            return RedirectToAction("Index");
        }
    }


}

