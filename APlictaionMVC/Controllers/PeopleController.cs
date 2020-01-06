using APlictaionMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APlictaionMVC.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            int i = 5 / p.age;

            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Tim", LastName="Corey", age=25}) ;
            people.Add(new PersonModel { FirstName = "Marysia", LastName = "Konopnicka", age = 17 });
            people.Add(new PersonModel { FirstName = "Andrzej", LastName = "Gołąbek", age = 38 });
            people.Add(new PersonModel { FirstName = "Albin", LastName = "Kolano", age = 42 });

            return View(people);
        }
    }
}