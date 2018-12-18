using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoAppV1.Models;

namespace TodoAppV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Repository<TODO_LIST> todoListRepository = new Repository<TODO_LIST>();
            List<TODO_LIST> todoList = todoListRepository.GetAll().ToList();
            List<TodoListDto> todoListDto = new List<TodoListDto>();
            foreach (var item in todoList)
            {
                TodoListDto todoLists = new TodoListDto
                {
                    Id = item.Id,
                    CategoriId = item.CategoriId,
                    Contents = item.Contents,
                    ImageUrl = item.ImageUrl,
                    IsActive = item.IsActive,
                    PriorityNo = item.PriorityNo,
                    Title = item.Title
                };
                todoListDto.Add(todoLists);
            }


            return View(todoListDto);
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
    }
}