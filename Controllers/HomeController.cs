using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoAPP.App_Start;
using TodoAPP.Models;

namespace TodoAPP.Controllers
{
    public class HomeController : Controller
    {
        private DBContext dbcontext;

        private IMongoCollection<TodoModel> tasksCollection;

        public HomeController()
        {
            dbcontext = new DBContext();
            tasksCollection = dbcontext.database.GetCollection<TodoModel>("tasks");
        }
        public ActionResult Index()
        {

            List<TodoModel> tasks = tasksCollection.AsQueryable<TodoModel>().ToList();
            return View(tasks);
        }

   
    }
}