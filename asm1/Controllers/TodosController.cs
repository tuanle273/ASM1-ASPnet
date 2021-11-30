using asm1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asm1.Controllers
{
    public class TodosController : Controller
    {
        // GET: Todos

        public ActionResult Index()
        {
            var todos = new List<Todo>()
            {
                new Todo
                {
                    Id = 1,
                    Description = "Buy Food",
                    DueDate = new DateTime(2021,12,20),
                },
                new Todo
                {
                    Id=2,
                    Description =  "Buy Drink",
                    DueDate = new DateTime(2021,10,20)
                }
            };
            
            return View();
        }
    }
}