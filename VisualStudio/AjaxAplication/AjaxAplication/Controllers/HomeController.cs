using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxAplication.Models;

namespace AjaxAplication.Controllers
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
            todoItems.Add(new TodoItem() { Id = 1, Description = "Todo item 1" });
            todoItems.Add(new TodoItem() { Id = 2, Description = "Todo item 2" });
            todoItems.Add(new TodoItem() { Id = 3, Description = "Todo item 3" });
            todoItems.Add(new TodoItem() { Id = 4, Description = "Todo item 4" });
            //return PartialView("Items", todoItems);
            return Json(todoItems);
        }

        public ActionResult TodoItemsPartial()
        {
            List<TodoItem> todoItems = new List<TodoItem>();
            todoItems.Add(new TodoItem() { Id = 1, Description = "Todo item 1" });
            todoItems.Add(new TodoItem() { Id = 2, Description = "Todo item 2" });
            todoItems.Add(new TodoItem() { Id = 3, Description = "Todo item 3" });
            todoItems.Add(new TodoItem() { Id = 4, Description = "Todo item 4" });
            //return PartialView("Items", todoItems);
            return PartialView("Items", todoItems);
        }
    }
}