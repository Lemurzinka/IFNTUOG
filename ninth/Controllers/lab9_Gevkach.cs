using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class lab9_GevkachController : Controller
    {
       //GET: lab9_Gevkach
        public ActionResult FirstViewMethod()
        {
            List<string> autos =  GetAutoList();
            return View(autos);
        }
        public ActionResult SecondViewMethod() 
        { 
        return View(GetAutoList().OrderBy(x=>x).ToList());
        }
        public ActionResult ThirdViewMethod()
        {
            return View(GetAutoList().OrderBy(x=>x).ToList());
        }

        public List<string> GetAutoList()
        {
            List<string> autos = new List<string>();
            autos.Add("BMW");
            autos.Add("Tesla");
            autos.Add("Mazda");
            autos.Add("Alfa Romeo");
            autos.Add("Maserati");
            autos.Add("Ferrari");
            autos.Add("Porsche");

            return autos;
        }
    }
}