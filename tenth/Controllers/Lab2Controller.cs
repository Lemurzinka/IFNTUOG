using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Entities;

namespace WebApplication1.Controllers
{
    public class Lab2Controller : Controller
    {
        // GET: Lab2
      
        public ActionResult ListOfPeople()
        {
            List<Person> people = new List<Person>();
            using (var db = new Model1Enities()) 
            {

                people = db.people.OrderByDescending(x => x.Age)
                                  .ThenBy(x => x.LastName)
                                  .ThenBy(x => x.FirstName).ToList();
            }
            return View(people); 
        }

        public ActionResult PersonDetails(Guid personId)
        {
            Person model = new Person();
            using (var db = new Model1Enities())
            {

                model = db.People.Find(personId);
                                 
            }
            return View(mode1);
        }
    }
}