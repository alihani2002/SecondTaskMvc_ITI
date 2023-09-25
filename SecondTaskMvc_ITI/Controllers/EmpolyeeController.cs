using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using SecondTaskMvc_ITI.ContextData;
using SecondTaskMvc_ITI.Models;
using Microsoft.EntityFrameworkCore;

namespace SecondTaskMvc_ITI.Controllers
{
    public class EmpolyeeController : Controller
    {
        private ContextITI context;
        public EmpolyeeController() 
        { 
            context = new ContextITI();
        }
        // To show all data
        public IActionResult Index()
        {
            var empolyeeList = context.Empolyee.ToList();
            return View(empolyeeList);
        }

        public IActionResult NewForm()
        {
            List<Office> offices = context.Office.ToList();
            ViewBag.Office_Id = offices;
            return View();
        }

        public IActionResult AddToDatabase(Empolyee emp)
        {
            context.Empolyee.Add(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult details(int id)
        {
            var emp = context.Empolyee.Include(e => e.Office).SingleOrDefault(e => e.Id == id);
            if (emp == null)
                return Content("Error");

            return View(emp);
        }

        public IActionResult EditForm(int id)
        {
            Empolyee empolyee = context.Empolyee.SingleOrDefault(c => c.Id == id);

            ViewBag.Office_Id = context.Office.ToList();
            return View(empolyee);
        }
        public IActionResult EditInDB(Empolyee emp)
        {
            Empolyee OldCourse = context.Empolyee.SingleOrDefault(c => c.Id == emp.Id);

            if (OldCourse != null)
            {
                OldCourse.Name = emp.Name;
                OldCourse.Address = emp.Address;
                OldCourse.Salary = emp.Salary;
                OldCourse.email = emp.email;
                OldCourse.Office_Id = emp.Office_Id;
                OldCourse.email = emp.email;
                OldCourse.Password=emp.Password;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return Content("Employee not found");
            }
        }

        public IActionResult Delete(int id)
        {
            var emp = context.Empolyee.SingleOrDefault(d => d.Id == id);
            context.Empolyee.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
