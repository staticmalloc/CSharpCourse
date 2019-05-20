using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityDataBase.Models;
using System.Linq;
using Castle.Core;
using Microsoft.AspNetCore.Rewrite.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Xml;
using NpgsqlTypes;
using UniversityDataBase.Views.Main;

namespace UniversityDataBase.Controllers
{
    [Route("/")]
    public class MainController: Controller
    {
        private readonly AppDBContext _context;

        public MainController(AppDBContext context)
        {
            _context = context;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("AllStudents")]
        public IActionResult AllStudents()
        {
            return View(_context.Students.OrderBy(s=>s.GroupNum).ToList());
        }

        [Route("AllTeachers")]
        public IActionResult AllTeachers()
        {
            return View(_context.Teachers.ToList());
        }
        [Route("Teacher")]
        public IActionResult Teacher(int id)
        {
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id",
                "Description");
            var groupsDesc = _context.Cafedras.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.cafedras = new SelectList(groupsDesc, "Id",
                "Description");
            var catDesc = new List<Categ>();
            catDesc.Add(new Categ("Professor"));
            catDesc.Add(new Categ("Docent"));
            catDesc.Add(new Categ("Teacher"));
            catDesc.Add(new Categ("Assistant"));
            ViewBag.categories = new SelectList(catDesc, "Name","Name");
            Teacher teacher;
            if (id > 0)
            {
                teacher = _context.Teachers.Find(id);
                ViewBag.controller = "UpdateTeacher";
            }
            else
            {
                teacher = new Teacher();
                ViewBag.controller = "SaveTeacher";
            }
            return View(teacher);
        }
        
        [Route("UpdateTeacher")]
        public IActionResult UpdateTeacher(Teacher t)
        {
            if (ModelState.IsValid)
            {
                _context.Teachers.Update(t);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Teacher", "Main", new {id = t.Id});
        }
        
        [Route ("AllCafedras")]
        public IActionResult AllCafedras()
        {
            return View(_context.Cafedras.ToList());
        }
        
        [Route("Cafedra")]
        public IActionResult Cafedra(int id)
        {
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            Cafedra cafedra;
            if (id > 0)
            {
                cafedra = _context.Cafedras.Find(id);
                ViewBag.controller = "UpdateCafedra";
            }
            else
            {
                cafedra = new Cafedra();
                ViewBag.controller = "SaveCafedra";
            }
            return View(cafedra);
        }
        
        [Route("UpdateCafedra")]
        public IActionResult UpdateCafedra(Cafedra c)
        {
            if (ModelState.IsValid)
            {
                _context.Cafedras.Update(c);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Cafedra", "Main", new {id = c.Id});
        }
        
        [Route("Student")]
        public IActionResult Student(int id)
        {
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            Student student;
            if (id > 0)
            {
                student = _context.Students.Find(id);
                ViewBag.controller = "UpdateStudent";
            }
            else
            {
                student = new Student();
                ViewBag.controller = "SaveStudent";
            }
            return View(student);
        }
        
        [Route("UpdateStudent")]
        public IActionResult UpdateStudent(Student s)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(s);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Student", "Main", new {id = s.Id});
        }
        
        [Route("Request1")]
        public IActionResult Request1()
        {
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id",
                "Description");
            var courDesc = new List<Cours>();
            courDesc.Add(new Cours(1));
            courDesc.Add(new Cours(2));
            courDesc.Add(new Cours(3));
            courDesc.Add(new Cours(4));
            ViewBag.courses = new SelectList(courDesc, "Course","Course");
            return View();
        }

        class Cours
        {
            public int Course { get; set; }

            public Cours(int a)
            {
                Course = a;
            }
        }
        
        [Route("Request1_1")]
        public IActionResult Request1_1(Request request)
        {
                var res = _context.Students.Where(m => m.GroupNum == request.Group).OrderBy(m=>m.Name).ToList();
                return View(res);
        }
        
        [Route("Request1_2")]
        public IActionResult Request1_2(Request request)
        {
            IList<Student> res;
            if (request.Course != -1)
            {
                 res = (from a in _context.Students
                    join c in _context.Groups on a.GroupNum equals c.GroupNum
                    where c.Stage == request.Course && c.FacultyId == request.Faculty
                    select new Student()
                    {
                        Id = a.Id,
                        Name = a.Name,
                        Age = a.Age,
                        Award = a.Award,
                        Sex = a.Sex,
                        Child = a.Child,
                        Birth = a.Birth,
                        GroupNum = a.GroupNum
                    }).ToList();
            }
            else
            {
                 res = (from a in _context.Students
                    join c in _context.Groups on a.GroupNum equals c.GroupNum
                    where c.FacultyId == request.Faculty
                    select new Student()
                    {
                        Id = a.Id,
                        Name = a.Name,
                        Age = a.Age,
                        Award = a.Award,
                        Sex = a.Sex,
                        Child = a.Child,
                        Birth = a.Birth,
                        GroupNum = a.GroupNum
                    }).ToList();
            }

            return View(res);

        }
        
        [Route("Request2")]
        public IActionResult Request2(Request2 request)
        {
            var groupsDesc = _context.Cafedras.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.cafedras = new SelectList(groupsDesc, "Id",
                "Description");
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id",
                "Description");

            var catDesc = new List<Categ>();
            catDesc.Add(new Categ("Professor"));
            catDesc.Add(new Categ("Docent"));
            catDesc.Add(new Categ("Teacher"));
            catDesc.Add(new Categ("Assistant"));
            ViewBag.categories = new SelectList(catDesc, "Name","Name");
            return View();
        }
        class Categ
        {
            public string Name { get; set; }

            public Categ(string s)
            {
                Name = s;
            }
        }
        [Route("Request2_1")]
        public IActionResult Req2_1(Request2 request)
        {
            var res = _context.Teachers.Where(t => t.CafedraId == request.Cafedra).ToList();
            
            return View(res);
        }
        [Route("Request2_2")]
        public IActionResult Req2_2(Request2 request)
        {
            var res = _context.Teachers.Where(t => t.FacultyId == request.Faculty).ToList();
            
            return View(res);
        }
        [Route("Request2_3")]
        public IActionResult Req2_3(Request2 request)
        {
            var res = _context.Teachers.Where(t => t.Category == request.Category).ToList();
            return View(res);
        }
        [Route("Request3")]
        public IActionResult Request3(Request2 request)
        {
            var groupsDesc = _context.Cafedras.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.cafedras = new SelectList(groupsDesc, "Id",
                "Description");
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id",
                "Description");
            return View();
        }
        [Route("Request3_1")]
        public IActionResult Req3_1(Request2 request)
        {
            var res = (from a in _context.Disertations
                join c in _context.Teachers on a.TeacherId equals c.Id
                where c.CafedraId == request.Cafedra
                select new Disertation()
                {
                    Id = a.Id,
                    Theme = a.Theme,
                    Teacher = a.Teacher,
                    TeacherId = a.TeacherId
                }).ToList();
            
            return View(res);
        }
        
        [Route("Request3_2")]
        public IActionResult Req3_2(Request2 request)
        {
            var res = (from a in _context.Disertations
                join c in _context.Teachers on a.TeacherId equals c.Id
                where c.FacultyId == request.Faculty
                select new Disertation()
                {
                    Id = a.Id,
                    Theme = a.Theme,
                    Teacher = a.Teacher,
                    TeacherId = a.TeacherId
                }).ToList();
            
            return View(res);
        }
        [Route("Request4")]
        public IActionResult Request4()
        {
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id",
                "Description");
            var courDesc = new List<Cours>();
            courDesc.Add(new Cours(1));
            courDesc.Add(new Cours(2));
            courDesc.Add(new Cours(3));
            courDesc.Add(new Cours(4));
            ViewBag.courses = new SelectList(courDesc, "Course","Course");
            
            var semDesc = new List<Cours>();
            semDesc.Add(new Cours(1));
            semDesc.Add(new Cours(2));
            ViewBag.semesters = new SelectList(semDesc, "Course","Course");
            return View();
        }
        [Route("Request4_1")]
        public IActionResult Req4_1(Request4 request)
        {
            var res = (from c in _context.Cafedras
                    join d in _context.Disciplines on c.Id equals d.CafedraId
                    join gd in _context.GroupsDisciplines on d.Id equals gd.DisciplineId
                    where gd.GroupId == request.Group
                    select new Cafedra()
                    {
                        Id = c.Id,
                        Name = c.Name
                    }
                )
                .GroupBy(m => m.Name)
                .Select(c => new Cafedra(){Name = c.Key})
                .ToList();
            
            return View(res);
        }
        [Route("Request4_2")]
        public IActionResult Req4_2(Request4 request)
        {

            var res = (from c in _context.Cafedras
                join d in _context.Disciplines on c.Id equals d.CafedraId 
                join gd in _context.GroupsDisciplines on d.Id equals gd.DisciplineId
                join g in _context.Groups on gd.GroupId equals g.GroupNum
                where d.Stage == request.Course && d.Semester == request.Semester && g.FacultyId == request.Faculty
                select new Cafedra()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .GroupBy(m => m.Name)
                .Select(c => new Cafedra(){Name = c.Key})
                .ToList();
            
            return View(res);
        }
        [Route("Request4_3")]
        public IActionResult Req4_3(Request4 request)
        {
            var res = (from c in _context.Cafedras
                join d in _context.Disciplines on c.Id equals d.CafedraId
                    where request.End > d.BeginDate && request.End < d.BeginDate.AddMonths(5) 
                          || request.Begin > d.BeginDate && request.Begin < d.BeginDate.AddMonths(5)
                          || request.Begin < d.BeginDate && request.End > d.BeginDate.AddMonths(5)
                select new Cafedra()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .GroupBy(m => m.Name)
                .Select(c => new Cafedra(){Name = c.Key})
                .ToList();
            return View(res);
        }
        [Route("Request5")]
        public IActionResult Request5()
        {
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id",
                "Description");
            var courDesc = new List<Cours>();
            courDesc.Add(new Cours(1));
            courDesc.Add(new Cours(2));
            courDesc.Add(new Cours(3));
            courDesc.Add(new Cours(4));
            ViewBag.courses = new SelectList(courDesc, "Course","Course");
            
            var disDesc = _context.Disciplines.ToList().Select(s => new Discipline()
            {
                Id = s.Id,
                Name =  s.Name
            });
            ViewBag.disciplines = new SelectList(disDesc,"Id","Name");
            return View();
        }
        [Route("Request5_1")]
        public IActionResult Req5_1(Request5 request)
        {
            var res = (from t in _context.Teachers
                    join d in _context.Disciplines on t.Id equals d.TeacherId
                    join gd in _context.GroupsDisciplines on d.Id equals gd.DisciplineId
                    where gd.GroupId == request.Group && d.Id == request.Discipline1
                    select new Teacher()
                    {
                        Id = t.Id,
                        Name = t.Name
                    }
                    ).GroupBy(m => m.Name)
                    .Select(c => new Teacher(){Name = c.Key})
                    .ToList();
            
            return View(res);
        }
        [Route("Request5_2")]
        public IActionResult Req5_2(Request5 request)
        {

            var res = (from t in _context.Teachers
                join d in _context.Disciplines on t.Id equals d.TeacherId
                join gd in _context.GroupsDisciplines on d.Id equals gd.DisciplineId
                join g in _context.Groups on gd.GroupId equals g.GroupNum
                where d.Stage == request.Course && g.FacultyId == request.Faculty && d.Id == request.Discipline2
                select new Teacher()
                {
                    Id = t.Id,
                    Name = t.Name
                }
                ).GroupBy(m => m.Name)
                .Select(c => new Teacher(){Name = c.Key})
                .ToList();
            
            return View(res);
        }
        [Route("Request6")]
        public IActionResult Request6()
        {
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id",
                "Description");
            var courDesc = new List<Cours>();
            courDesc.Add(new Cours(1));
            courDesc.Add(new Cours(2));
            courDesc.Add(new Cours(3));
            courDesc.Add(new Cours(4));
            ViewBag.courses = new SelectList(courDesc, "Course","Course");
            
            var semDesc = new List<Cours>();
            semDesc.Add(new Cours(1));
            semDesc.Add(new Cours(2));
            ViewBag.semesters = new SelectList(semDesc, "Course","Course");

            var typeDesc = new List<Categ>();
            typeDesc.Add(new Categ("Lecture"));
            typeDesc.Add(new Categ("Seminar"));
            typeDesc.Add(new Categ("Practise"));
            ViewBag.types = new SelectList(typeDesc,"Name","Name");
            
            return View();
        }
        [Route("Request6_1")]
        public IActionResult Req6_1(Request6 request)
        {

                 var res = (from t in _context.Teachers
                        join d in _context.Disciplines on t.Id equals d.TeacherId
                        join gd in _context.GroupsDisciplines on d.Id equals gd.DisciplineId
                        where gd.GroupId == request.Group && d.Type == request.Type1
                        select new Teacher()
                        {
                            Id = t.Id,
                            Name = t.Name
                        }
                    )
                    .ToList();

            return View(res);
        }
        [Route("Request6_2")]
        public IActionResult Req6_2(Request6 request)
        {

              var  res = (from t in _context.Teachers
                        join d in _context.Disciplines on t.Id equals d.TeacherId
                        join gd in _context.GroupsDisciplines on d.Id equals gd.DisciplineId
                        join g in _context.Groups on gd.GroupId equals g.GroupNum
                        where d.Stage == request.Course && g.FacultyId == request.Faculty && d.Type == request.Type2 
                        select new Teacher()
                        {
                            Id = t.Id,
                            Name = t.Name
                        }
                    )
                    .ToList();

            return View(res);
        }
        [Route("Request6_3")]
        public IActionResult Req6_3(Request6 request)
        {


             var res = (from t in _context.Teachers
                        join d in _context.Disciplines on t.Id equals d.TeacherId
                        where request.End > d.BeginDate && request.End < d.BeginDate.AddMonths(5) 
                              || request.Begin > d.BeginDate && request.Begin < d.BeginDate.AddMonths(5)
                              || request.Begin < d.BeginDate && request.End > d.BeginDate.AddMonths(5) 
                              && d.Type == request.Type3
                        select new Teacher()
                        {
                            Id = t.Id,
                            Name = t.Name
                        }
                    )
                    .ToList();

            return View(res);
        }
        [Route("Request7")]
        public IActionResult Request7()
        {
            var markDesc = new List<Cours>();
            markDesc.Add(new Cours(2));
            markDesc.Add(new Cours(3));
            markDesc.Add(new Cours(4));
            markDesc.Add(new Cours(5));
            ViewBag.marks = new SelectList(markDesc, "Course","Course");
            
            var disDesc = _context.Disciplines.ToList().Select(s => new Discipline()
            {
                Id = s.Id,
                Name =  s.Name
            });
            ViewBag.disciplines = new SelectList(disDesc,"Id","Name");
            return View();
        }
        [Route("Request7_1")]
        public IActionResult Req7(Request7 request)
        {
            var res = (from s in _context.Students
                join j in _context.Journals on s.Id equals j.StudentId
                where j.Mark == request.Mark && j.DisciplineId == request.Discipline
                select new Student()
                {
                    Name = s.Name
                }).ToList();

            return View(res);
        }
        [Route("Request8")]
        public IActionResult Request8()
        {
            var markDesc = new List<Cours>();
            markDesc.Add(new Cours(3));
            markDesc.Add(new Cours(4));
            markDesc.Add(new Cours(5));
            ViewBag.marks = new SelectList(markDesc, "Course","Course");
            
            var sesDesc = _context.Sessions.ToList().Select(s => new Session()
            {
                Id = s.Id,
                Date =  s.Date
            });
            ViewBag.sessions = new SelectList(sesDesc,"Id","Date");
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id",
                "Description");
            var courDesc = new List<Cours>();
            courDesc.Add(new Cours(1));
            courDesc.Add(new Cours(2));
            courDesc.Add(new Cours(3));
            courDesc.Add(new Cours(4));
            ViewBag.courses = new SelectList(courDesc, "Course","Course");
            return View();
        }
        [Route("Request8_1")]
        public IActionResult Req8_1(Request8 request)
        {
            var res1 = (from s in _context.Students.Where(s=>s.GroupNum == request.Group)
                join j in _context.Journals on s.Id equals j.StudentId
                where j.Mark < request.Mark1 && j.SessionId == request.Session1
                select new Student()
                {
                    Id = s.Id,
                    Name = s.Name
                }).ToList();
            var res = _context.Students.Where(s=>s.GroupNum == request.Group).ToList();

            foreach (var s in res1)
            {
                foreach (var ss in res)
                {
                    if (ss.Id == s.Id)
                        res.Remove(ss);
                }
            }
            return View(res);
        }
        [Route("Request8_2")]
        public IActionResult Req8_2(Request8 request)
        {
            var res1 = (from s in _context.Students
                join j in _context.Journals on s.Id equals j.StudentId
                join g in _context.Groups on s.GroupNum equals g.GroupNum
                where j.Mark < request.Mark2 && j.SessionId == request.Session2
                                              && g.Stage == request.Course && g.FacultyId == request.Faculty
                select new Student()
                {
                    Id = s.Id,
                    Name = s.Name
                }).ToList();
            var res = _context.Students.ToList();

            foreach (var s in res1)
            {
                foreach (var ss in res)
                {
                    if (ss.Id == s.Id)
                        res.Remove(ss);
                }
            }
            return View(res);
        }
        [Route("Request9")]
        public IActionResult Request9()
        {
            
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            var semDesc = new List<Cours>();
            semDesc.Add(new Cours(1));
            semDesc.Add(new Cours(2));
            semDesc.Add(new Cours(3));
            semDesc.Add(new Cours(4));
            semDesc.Add(new Cours(5));
            semDesc.Add(new Cours(6));
            semDesc.Add(new Cours(7));
            semDesc.Add(new Cours(8));
            ViewBag.semesters = new SelectList(semDesc, "Course","Course");
            
            var disDesc = _context.Disciplines.ToList().Select(s => new Discipline()
            {
                Id = s.Id,
                Name =  s.Name
            });
            ViewBag.disciplines = new SelectList(disDesc,"Id","Name");
            return View();
        }
        [Route("Request9_1")]
        public IActionResult Request9_1(Request9 request)
        {
            var stud = (from student in _context.Students
                join gr in _context.Groups on student.GroupNum equals gr.GroupNum
                where student.GroupNum == request.Group
                select new
                {
                    StudentId = student.Id,
                    BeginDate = gr.BeginYear
                });
            var res = (from t in _context.Teachers
                join j in _context.Journals on t.Id equals j.TeacherId
                join st in stud on j.StudentId equals st.StudentId
                join ses in _context.Sessions on j.SessionId equals ses.Id
                where ses.Date.Year == st.BeginDate.AddMonths(request.Semester*6).Year
                      && ses.Date.Month == st.BeginDate.AddMonths(request.Semester*6).Month ||  ses.Date.Month == st.BeginDate.AddMonths(request.Semester*6 - 1).Month
                      && j.DisciplineId == request.Discipline
                select new Teacher()
                {
                    Name = t.Name
                }).ToList();
            return View(res);
        }
        [Route("Request10")]
        public IActionResult Request10()
        {
            
            var groupsDesc = _context.Groups.ToList().Select(s => new
            {
                s.GroupNum,
                Description = $" {s.GroupNum}"
            });
            ViewBag.groups = new SelectList(groupsDesc, "GroupNum",
                "Description");
            var semDesc = new List<Cours>();
            semDesc.Add(new Cours(1));
            semDesc.Add(new Cours(2));
            semDesc.Add(new Cours(3));
            semDesc.Add(new Cours(4));
            semDesc.Add(new Cours(5));
            semDesc.Add(new Cours(6));
            semDesc.Add(new Cours(7));
            semDesc.Add(new Cours(8));
            ViewBag.semesters = new SelectList(semDesc, "Course","Course");
            
            var disDesc = _context.Disciplines.ToList().Select(s => new Discipline()
            {
                Id = s.Id,
                Name =  s.Name
            });
            ViewBag.disciplines = new SelectList(disDesc,"Id","Name");
            var techDesc = _context.Teachers.ToList().Select(s => new Teacher()
            {
                Id = s.Id,
                Name =  s.Name
            });
            ViewBag.teachers = new SelectList(techDesc,"Id","Name");
            var markDesc = new List<Cours>();
            markDesc.Add(new Cours(2));
            markDesc.Add(new Cours(3));
            markDesc.Add(new Cours(4));
            markDesc.Add(new Cours(5));
            ViewBag.marks = new SelectList(markDesc, "Course","Course");
            return View();
        }
        [Route("Req10_1")]
        public IActionResult Req10_1(Request10 request)
        {
            var stud = (from student in _context.Students
                join gr in _context.Groups on student.GroupNum equals gr.GroupNum
                where student.GroupNum == request.Group1
                select new
                {
                    StudentId = student.Id,
                    StedentName = student.Name,
                    BeginDate = gr.BeginYear
                });
            var res = (from s in stud
                join j in _context.Journals on s.StudentId equals j.StudentId
                join ses in _context.Sessions on j.SessionId equals ses.Id
                where ses.Date.Year == s.BeginDate.AddMonths(request.Semester*6).Year
                      && ses.Date.Month == s.BeginDate.AddMonths(request.Semester*6).Month ||  ses.Date.Month == s.BeginDate.AddMonths(request.Semester*6 - 1).Month
                      && j.DisciplineId == request.Discipline
                      && j.TeacherId == request.Teacher
                select new Student()
                {
                    Name = s.StedentName
                }).ToList();
            return View(res);
        }
        [Route("Req10_2")]
        public IActionResult Req10_2(Request10 request)
        {
            var stud = (from student in _context.Students
                join gr in _context.Groups on student.GroupNum equals gr.GroupNum
                where student.GroupNum == request.Group2
                select new
                {
                    StudentId = student.Id,
                    StudentName = student.Name,
                    BeginDate = gr.BeginYear
                });
            var res = (from s in stud
                join j in _context.Journals on s.StudentId equals j.StudentId
                join ses in _context.Sessions on j.SessionId equals ses.Id
                where ses.Date >= request.Begin && ses.Date <= request.End
                select new Student()
                {
                    Name = s.StudentName
                }).ToList();
            return View(res);
        }
        [Route("Request11")]
        public IActionResult Request11()
        {
            var techDesc = _context.Teachers.ToList().Select(s => new Teacher()
            {
                Id = s.Id,
                Name =  s.Name
            });
            ViewBag.teachers = new SelectList(techDesc,"Id","Name");
            var cafDesc = _context.Cafedras.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.cafedras = new SelectList(cafDesc, "Id", "Description");
            return View();
        }

        [Route("Request11_1")]
        public IActionResult req11_1(Request11 request)
        {
            var res = (from c in _context.Cafedras
                join t in _context.Teachers on c.Id equals t.CafedraId
                join d in _context.Diplomas on t.Id equals d.TeacherId
                join s in _context.Students on d.StudentId equals s.Id
                where c.Id == request.Cafedra
                select new Request11_1()
                {
                    Name = s.Name,
                    Theme = d.Theme
                }).ToList();
            return View(res);
        }
        
        [Route("Request11_2")]
        public IActionResult req11_2(Request11 request)
        {
            var res = (from s in _context.Students
                join d in _context.Diplomas on s.Id equals d.StudentId
                where d.TeacherId == request.Teacher
                select new Request11_1()
                {
                    Name = s.Name,
                    Theme = d.Theme
                }).ToList();
            return View(res);
        }
        [Route("Request12")]
        public IActionResult Request12()
        {
            var cafDesc = _context.Cafedras.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.cafedras = new SelectList(cafDesc, "Id", "Description");
            var facultDesc = _context.Faculties.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.faculties = new SelectList(facultDesc, "Id", "Description");
            var catDesc = new List<Categ>();
            catDesc.Add(new Categ("All"));
            catDesc.Add(new Categ("Professor"));
            catDesc.Add(new Categ("Docent"));
            catDesc.Add(new Categ("Teacher"));
            catDesc.Add(new Categ("Assistant"));
            ViewBag.categories = new SelectList(catDesc, "Name","Name");    
            return View();
        }

        [Route("Request12_1")]
        public IActionResult req12_1(Request12 request)
        {
            var res1 = (from t in _context.Teachers
                join c in _context.Cafedras on t.CafedraId equals c.Id
                join d in _context.Diplomas on t.Id equals d.TeacherId
                where c.Id == request.Cafedra
                select new Teacher()
                {
                    Name = t.Name,
                    Category = t.Category
                });
            var res = res1.ToList();
            if (request.Category1 != "All")
                res = res1.Where(t => t.Category == request.Category1).ToList();
            return View(res);
        }
        
        [Route("Request12_2")]
        public IActionResult req12_2(Request12 request)
        {
            var res1 = (from t in _context.Teachers
                join f in _context.Faculties on t.FacultyId equals f.Id
                join d in _context.Diplomas on t.Id equals d.TeacherId
                where f.Id == request.Faculty
                select new Teacher()
                {
                    Name = t.Name,
                    Category = t.Category
                });
            var res = res1.ToList();
            if (request.Category1 != "All")
                res = res1.Where(t => t.Category == request.Category1).ToList();
            return View(res);
        }
        [Route("Request13")]
        public IActionResult Request13()
        {
            var techDesc = _context.Teachers.ToList().Select(s => new Teacher()
            {
                Id = s.Id,
                Name =  s.Name
            });
            ViewBag.teachers = new SelectList(techDesc,"Id","Name");
            var cafDesc = _context.Cafedras.ToList().Select(s => new
            {
                s.Id,
                Description = $" {s.Name}"
            });
            ViewBag.cafedras = new SelectList(cafDesc, "Id", "Description");
            return View();
        }
        [Route("Request13_1")]
        public IActionResult req13_1(Request13 request)
        {
            var res = new List<Request13_1>();
            var temp = _context.Disciplines
                .Where(d => d.TeacherId == request.Teacher)
                .GroupBy(d => d.Name);
            foreach (var t in temp)
            {
                int all = 0;
                int lect = 0;
                int sem = 0;
                int pract = 0;
                foreach (var d in t)
                {
                    all += d.Hours;
                    if (d.Type == "Lecture")
                        lect += d.Hours;
                    if (d.Type == "Seminar")
                        sem += d.Hours;
                    if (d.Type == "Practise")
                        pract += d.Hours;
                }
                res.Add(new Request13_1()
                {
                    DisciplineName = t.Key,
                    AllHours = all,
                    LectureHours = lect,
                    SeminarHours = sem,
                    PractiseHours = pract
                });
            }
            return View(res);
        }
        [Route("Request13_2")]
        public IActionResult req13_2(Request13 request)
        {
            var res = new List<Request13_1>();
            var teachers = _context.Teachers.Where(t => t.CafedraId == request.Cafedra);
            foreach (var teacher in teachers)
            {
                var temp = _context.Disciplines
                    .Where(d => d.TeacherId == teacher.Id)
                    .GroupBy(d => d.Name);
                foreach (var t in temp)
                {
                    int all = 0;
                    int lect = 0;
                    int sem = 0;
                    int pract = 0;
                    foreach (var d in t)
                    {
                        all += d.Hours;
                        if (d.Type == "Lecture")
                            lect += d.Hours;
                        if (d.Type == "Seminar")
                            sem += d.Hours;
                        if (d.Type == "Practise")
                            pract += d.Hours;
                    }
                    res.Add(new Request13_1()
                    {
                        TeacherName = teacher.Name,
                        DisciplineName = t.Key,
                        AllHours = all,
                        LectureHours = lect,
                        SeminarHours = sem,
                        PractiseHours = pract
                    });
                }
            }
            return View(res);
        }
    }
}