using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class EmppController1 : Controller
    {
        EmpDbContext db = new EmpDbContext();
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Index(Emp obj)
        {
            db.Emps.Add(obj);
            db.SaveChanges();
            return View();
        }
    }
}
