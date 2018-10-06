using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace WebApplicationAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TodoItems()
        {
            List<TodoItem> todoItems = new List<TodoItem>();
            using (var db = new TodoContext())
            {
                todoItems = db.TodoItems.ToList();
            }
            return this.Json(todoItems, JsonRequestBehavior.AllowGet);
        }

        public ActionResult TodoItemsPartial()
        {
            List<TodoItem> todoItems;
            using(var db = new TodoContext())
            {
                todoItems = db.TodoItems.ToList();
            }
            return PartialView("Items", todoItems);
        }

        //[ActionName("SaveTodoItem")]
        public ActionResult Save(TodoItem todoItem)
        {
            using(var db = new TodoContext())
            {
                db.TodoItems.Add(todoItem);
                db.SaveChanges();
            }
            return Json("success");
        }
    }
}