using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Infrastructure;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class VnResourceController : Controller
    {
        private readonly VnResouceContext context;
        public VnResourceController(VnResouceContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult> Index()
        {
            IQueryable<KhoaHoc> items = from i in context.KhoaHoc orderby i.ID select i;

            List<KhoaHoc> todoList = await items.ToListAsync();

            return View(todoList);
        }

        public async Task<ActionResult> MonHoc(int id = 0)
        {
            ViewBag.NamePage = "Khoá học: " + context.KhoaHoc.Find(id).TenKhoaHoc;
            ViewBag.ListSubject = context.MonHoc.Where(x => x.KhoaHocID == id).ToList();
            return View();
        }
    }
}
