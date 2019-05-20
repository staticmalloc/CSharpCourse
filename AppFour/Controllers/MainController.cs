using System.Linq;
using AppFour.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppFour.Controllers
{

    [Route("/")]
    public class MainController : Controller
    {

        private readonly AppDBContext _context;

        public MainController(AppDBContext context)
        {
            _context = context;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View(_context.Workers.ToList());
        }

        [Route("Worker")]
        public IActionResult Worker(int id)
        {
            Worker work;
            if (id > 0)
            {
                work = _context.Workers.Find(id);
                ViewBag.controller = "UpdateWorker";
            }
            else
            {
                work = new Worker();
                ViewBag.controller = "SaveWorker";
            }
            return View(work);
        }

        [Route("Project")]
        public IActionResult Project(int id)
        {
            var WorkersDesc = _context.Workers.ToList().Select(s => new
                {
                    WorkerId = s.WorkerId,
                    Description = s.Name
                });
                ViewBag.workers = new SelectList(WorkersDesc, "Id",
                    "Description",0);
                Project project;
                if (id > 0)
                {
                    project = _context.Projects.Find(id);
                    ViewBag.controller = "UpdateProject";
                }
                else
                {
                    project = new Project();
                    ViewBag.controller = "SaveProject";
                }
            return View(project);
        }

        [Route("Projects")]
        public IActionResult Projects(int id)
        {
            var work = _context.Workers.Find(id);
            ViewBag.WorkerInfo = work.Name;
            var projects = work.Projects.ToList();
            return View(projects);
        }

        [Route("RemoveWorker")]
        public IActionResult RemoveWorker(int id)
        {
            _context.Workers.Remove(_context.Workers.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [Route("RemoveProject")]
        public IActionResult RemoveProject(int id)
        {
            var project = _context.Projects.Find(id);
            _context.Projects.Remove(project);
            _context.SaveChanges();
            return RedirectToAction("Projects", "Main", new {id = project.WorkerId});
        }

        [Route("UpdateWorker")]
        public IActionResult UpdateWorker(Worker worker)
        {
            if (ModelState.IsValid)
            {
                _context.Workers.Update(worker);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Worker", "Main", new {id = worker.WorkerId});
        }

        [Route("UpdateProject")]
        public IActionResult UpdateProject(Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Projects.Update(project);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Project", "Main", new {id = project.WorkerId});
        }

        [Route("Awards")]
        public IActionResult Awards()
        {
            var res1 = _context.Projects
                .GroupBy(project => project.Worker);
            var res2 = res1
                .Select(p => new Award
                    {
                        Name = p.Key.Name,
                        Value = p.Sum(project => project.Award)
                    }
                                        )
                .OrderByDescending(p => p.Value)
                .ToList();
        return View(res2);
        }
        

    }
}