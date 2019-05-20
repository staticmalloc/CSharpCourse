using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace UniversityDataBase.Models
{
    public class LoadData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new AppDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDBContext>>()))
            {
                if (EnumerableExtensions.Any(db.Students) || EnumerableExtensions.Any(db.Groups) || EnumerableExtensions.Any(db.Cafedras)
                    || EnumerableExtensions.Any(db.Journals) || EnumerableExtensions.Any(db.Teachers) || EnumerableExtensions.Any(db.Faculties)
                    || EnumerableExtensions.Any(db.Disciplines) || EnumerableExtensions.Any(db.Disertations) || EnumerableExtensions.Any(db.Diplomas))
                    return;
                var fit = new Faculty()
                {
                    Id = 1,
                    Name = "Faculty of IT Technologies"
                };
                var mmf = new Faculty()
                {
                    Id = 2,
                    Name = "Mechanic-Mathematic Faculty"
                };
                db.Faculties.AddRange(
                    fit,mmf
                );
                db.SaveChanges();
                var caf1 = new Cafedra()
                {
                    Id = 1,
                    Name = "Physical Education Cafedra"
                };
                var caf2 = new Cafedra()
                {
                    Id = 2,
                    Name = "Cafedra of Parallel Countings"
                };
                var caf3 = new Cafedra()
                {
                    Id = 3,
                    Name = "Cafedra of Math"
                };
                
                db.Cafedras.AddRange(
                    caf1,caf2,caf3
                );
                db.SaveChanges();
                db.FacultyCafedras.AddRange(
                    new FacultyCafedra()
                    {
                        Faculty = fit,
                        Cafedra = caf1
                    },
                    new FacultyCafedra()
                    {
                        Faculty = fit,
                        Cafedra = caf2
                    },
                    new FacultyCafedra()
                    {
                        Faculty = fit,
                        Cafedra = caf3
                    },
                    new FacultyCafedra()
                    {
                        Faculty = mmf,
                        Cafedra = caf1
                    },
                    new FacultyCafedra()
                    {
                        Faculty = mmf,
                        Cafedra = caf3
                    }
                );
                db.SaveChanges();
                Group g18201;
                Group g18701;
                Group g17201;
                Group g17701;
                Group g16201;
                Group g16701;
                Group g15201;
                Group g15701;
                db.Groups.AddRange(
                    g18201 = new Group()                          //18201
                    {
                        GroupNum = 18201,
                        Stage = 1,
                        FacultyId = 1,
                        BeginYear = DateTime.Parse("1/09/2018")
                    },
                    g18701 = new Group()                                        //18701
                    {
                        GroupNum = 18701,
                        Stage = 1,
                        FacultyId = 2,
                        BeginYear = DateTime.Parse("1/09/2018")
                    },
                    g17201 = new Group()
                    {
                        GroupNum = 17201,
                        Stage = 2,
                        FacultyId = 1,
                        BeginYear = DateTime.Parse("1/09/2017")
                    },
                    g17701 = new Group()
                    {
                        GroupNum = 17701,
                        Stage = 2,
                        FacultyId = 2,
                        BeginYear = DateTime.Parse("1/09/2017")
                    },
                    g16201 = new Group()
                    {
                        GroupNum = 16201,
                        Stage = 3,
                        FacultyId = 1,
                        BeginYear = DateTime.Parse("1/09/2016")
                    },
                    g16701  = new Group()
                    {
                        GroupNum = 16701,
                        Stage = 3,
                        FacultyId = 2,
                        BeginYear = DateTime.Parse("1/09/2016")
                    },
                    g15201 = new Group()
                    {
                        GroupNum = 15201,
                        Stage = 4,
                        FacultyId = 1,
                        BeginYear = DateTime.Parse("1/09/2015")
                    },
                    g15701 = new Group()
                    {
                        GroupNum = 15701,
                        Stage = 4,
                        FacultyId = 2,
                        BeginYear = DateTime.Parse("1/09/2015")
                    }
                );
                db.SaveChanges();
                
                db.Students.AddRange(
                    new Student()                         //1
                    {
                        Name = "Silvester Stallone",
                        Sex = 'm',
                        Birth = DateTime.Parse("15/06/1998"),
                        Age = 20,
                        Child = false,
                        Award = 3000,
                        GroupNum = 18201
                    },
                    new Student()                                      //2
                    {
                        Name = "Arnold Shwarznegger",
                        Sex = 'm',
                        Birth = DateTime.Parse("17/06/1998"),
                        Age = 20,
                        Child = false,
                        Award = 4000,
                        GroupNum = 18201
                    },
                    new Student()                                      //3
                    {
                        Name = "Julia Roberts",
                        Sex = 'f',
                        Birth = DateTime.Parse("17/04/1997"),
                        Age = 22,
                        Child = true,
                        Award = 0,
                        GroupNum = 18701
                    },
                    new Student()                                      //4
                    {
                        Name = "Natalie Portman",
                        Sex = 'f',
                        Birth = DateTime.Parse("1/12/1999"),
                        Age = 19,
                        Child = false,
                        Award = 3000,
                        GroupNum = 18701
                    },
                    new Student()                                      //5
                    {
                        Name = "Morgan Freeman",
                        Sex = 'm',
                        Birth = DateTime.Parse("24/06/1998"),
                        Age = 20,
                        Child = false,
                        Award = 3000,
                        GroupNum = 17201
                    },
                    new Student()                                      //6
                    {
                        Name = "Angelina Jolie",
                        Sex = 'f',
                        Birth = DateTime.Parse("1/02/1998"),
                        Age = 21,
                        Child = false,
                        Award = 0,
                        GroupNum = 17201
                    },
                    new Student()                                      //7
                    {
                        Name = "Robert Downey Yng",
                        Sex = 'm',
                        Birth = DateTime.Parse("22/08/1998"),
                        Age = 20,
                        Child = false,
                        Award = 12000,
                        GroupNum = 17701
                    },
                    new Student()                                      //8
                    {
                        Name = "Benedict Cumberbatch",
                        Sex = 'm',
                        Birth = DateTime.Parse("17/11/1997"),
                        Age = 21,
                        Child = false,
                        Award = 8000,
                        GroupNum = 17701
                    },
                    new Student()                                      //9
                    {
                        Name = "Jim Carrey",
                        Sex = 'm',
                        Birth = DateTime.Parse("9/07/1998"),
                        Age = 20,
                        Child = false,
                        Award = 4000,
                        GroupNum = 16201
                    },
                    new Student()                                      //10
                    {
                        Name = "Johny Depp",
                        Sex = 'm',
                        Birth = DateTime.Parse("5/10/1997"),
                        Age = 21,
                        Child = false,
                        Award = 4000,
                        GroupNum = 16201
                    },
                    new Student()                                      //11
                    {
                        Name = "Simon Afanasyev",
                        Sex = 'm',
                        Birth = DateTime.Parse("15/06/1998"),
                        Age = 20,
                        Child = false,
                        Award = 3000,
                        GroupNum = 16701
                    },
                    new Student()                                      //12
                    {
                        Name = "Pavel Holyavko",
                        Sex = 'm',
                        Birth = DateTime.Parse("17/06/1998"),
                        Age = 20,
                        Child = false,
                        Award = 0,
                        GroupNum = 16701
                    },
                    new Student()                                      //13
                    {
                        Name = "Elena Malovichko",
                        Sex = 'f',
                        Birth = DateTime.Parse("30/01/1997"),
                        Age = 22,
                        Child = false,
                        Award = 0,
                        GroupNum = 15201
                    },
                    new Student()                                      //14
                    {
                        Name = "Alexey Kozyakov",
                        Sex = 'm',
                        Birth = DateTime.Parse("17/06/1998"),
                        Age = 20,
                        Child = false,
                        Award = 4000,
                        GroupNum = 15201
                    },
                    new Student()                                      //15
                    {
                        Name = "Sergey Maximov",
                        Sex = 'm',
                        Birth = DateTime.Parse("14/02/1998"),
                        Age = 21,
                        Child = false,
                        Award = 4000,
                        GroupNum = 15701
                    },
                    new Student()                                      //16
                    {
                        Name = "Ilya Baryshnikov",
                        Sex = 'm',
                        Birth = DateTime.Parse("1/01/1998"),
                        Age = 21,
                        Child = false,
                        Award = 3000,
                        GroupNum = 15701
                    }
                );
                
                
                
                db.Teachers.AddRange(
                    new Teacher()
                    {
                        Id = 1,
                        Name = "Jason Stathem",
                        Sex = 'm',
                        Birth = DateTime.Parse("9/05/1978"),
                        Age = 42,
                        Childs = 2,
                        Salary = 80000,
                        Category = "Docent",
                        FacultyId = 1,
                        CafedraId = 1
                    },
                    new Teacher()
                    {
                        Id = 2,
                        Name = "Jackie Chan",
                        Sex = 'm',
                        Birth = DateTime.Parse("9/10/1968"),
                        Age = 50,
                        Childs = 1,
                        Salary = 80000,
                        Category = "Docent",
                        FacultyId = 2,
                        CafedraId = 1
                    },
                    new Teacher()
                    {
                        Id = 3,
                        Name = "Steven Hocking",
                        Sex = 'm',
                        Birth = DateTime.Parse("9/05/1978"),
                        Age = 42,
                        Childs = 0,
                        Salary = 180000,
                        Category = "Professor",
                        FacultyId = 2,
                        CafedraId = 3
                    },
                    new Teacher()
                    {
                        Id = 4,
                        Name = "Luyi Koshi",
                        Sex = 'm',
                        Birth = DateTime.Parse("9/11/1938"),
                        Age = 80,
                        Childs = 4,
                        Salary = 200000,
                        Category = "Professor",
                        FacultyId = 1,
                        CafedraId = 3
                    },
                    new Teacher()
                    {
                        Id = 5,
                        Name = "Kira Nightley",
                        Sex = 'f',
                        Birth = DateTime.Parse("9/05/1993"),
                        Age = 25,
                        Childs = 0,
                        Salary = 55000,
                        Category = "Assistant",
                        FacultyId = 1,
                        CafedraId = 2
                    },
                    new Teacher()
                    {
                        Id = 6,
                        Name = "Elwis Presley",
                        Sex = 'm',
                        Birth = DateTime.Parse("9/12/1944"),
                        Age = 75,
                        Childs = 0,
                        Salary = 180000,
                        Category = "Teacher",
                        FacultyId = 2,
                        CafedraId = 2
                    },
                    new Teacher()                          //7
                    {
                        Id = 7,
                        Name = "Elena Domanova",
                        Sex = 'f',
                        Birth = DateTime.Parse("9/11/1958"),
                        Age = 50,
                        Childs = 2,
                        Salary = 100000,
                        Category = "Docent",
                        FacultyId = 1,
                        CafedraId = 3
                    },
                    new Teacher()
                    {
                        Id = 8,
                        Name = "Daria Demchenko",
                        Sex = 'f',
                        Birth = DateTime.Parse("9/11/1991"),
                        Age = 28,
                        Childs = 4,
                        Salary = 200000,
                        Category = "Teacher",
                        FacultyId = 2,
                        CafedraId = 3
                    }
                 );
                db.SaveChanges();
                db.Disertations.AddRange(
                    new Disertation()
                    {
                        Theme = "Theory of Music",
                        TeacherId = 6
                    },
                    new Disertation()
                    {
                        Theme = "Theory of Cinema",
                        TeacherId = 5
                    },
                    new Disertation()
                    {
                        Theme = "Basics of MathAnalysis",
                        TeacherId = 4
                    },
                    new Disertation()
                    {
                        Theme = "Founds of MathAnalysis",
                        TeacherId = 4
                    },
                    new Disertation()
                    {
                        Theme = "Ends of MathAnalysis",
                        TeacherId = 4
                    },
                    new Disertation()
                    {
                        Theme = "Searching of clouds",
                        TeacherId = 3
                    },
                    new Disertation()
                    {
                        Theme = "Big data analize",
                        TeacherId = 2
                    },
                    new Disertation()
                    {
                        Theme = "NeuroNets algorhytms",
                        TeacherId = 1
                    }
                 );
                db.SaveChanges();
                var matlec4 = new Discipline()
                {
                    Id = 1,
                    Name = "Mathemathical analysis FIT",
                    Type = "lectures",
                    Stage = 1,
                    Semester = 1,
                    Hours = 68,
                    BeginDate = DateTime.Parse("1/09/2016"),
                    TeacherId = 4,
                    CafedraId = 3
                };
                var matsem7 = new Discipline()
                {
                    Id = 2,
                    Name = "Mathemathical analysis FIT",
                    Type = "Seminar",
                    Stage = 1,
                    Semester = 1,
                    Hours = 68,
                    BeginDate = DateTime.Parse("1/09/2016"),
                    TeacherId = 7,
                    CafedraId = 3
                };
                var matlec3 = new Discipline()
                {
                    Id = 3,
                    Name = "Mathemathical analysis MMF",
                    Type = "Lecture",
                    Stage = 1,
                    Semester = 1,
                    Hours = 68,
                    BeginDate = DateTime.Parse("1/09/2016"),
                    TeacherId = 3,
                    CafedraId = 3
                };

                var matsem8 = new Discipline()
                {
                    Id = 4,
                    Name = "Mathemathical analysis MMF",
                    Type = "Seminar",
                    Stage = 1,
                    Semester = 1,
                    Hours = 68,
                    BeginDate = DateTime.Parse("1/09/2016"),
                    TeacherId = 8,
                    CafedraId = 3
                };
                var fiz1 = new Discipline()
                {
                    Id = 5,
                    Name = "Physical Education FIT",
                    Type = "Practise",
                    Stage = 1,
                    Semester = 1,
                    Hours = 32,
                    BeginDate = DateTime.Parse("1/09/2016"),
                    TeacherId = 1,
                    CafedraId = 1
                };
                var fiz2 = new Discipline()
                {
                    Id = 6,
                    Name = "Physical Education MMF",
                    Type = "Practise",
                    Stage = 1,
                    Semester = 1,
                    Hours = 32,
                    BeginDate = DateTime.Parse("1/09/2016"),
                    TeacherId = 2,
                    CafedraId = 1
                };
                db.Disciplines.AddRange(
                    matlec3,matlec4,matsem7,matsem8,fiz1,fiz2
                 );
                db.SaveChanges();
                
                db.GroupsDisciplines.AddRange(
                    new GroupsDisciplines()
                    {
                        Group = g18201,
                        Discipline = fiz1
                    },
                    new GroupsDisciplines()
                    {
                        Group = g17201,
                        Discipline = fiz1
                    },
                    new GroupsDisciplines()
                    {
                        Group = g16201,
                        Discipline = fiz1
                    },
                    new GroupsDisciplines()
                    {
                        Group = g15201,
                        Discipline = fiz1
                    },
                    new GroupsDisciplines()
                    {
                        Group = g18701,
                        Discipline = fiz2
                    },
                    new GroupsDisciplines()
                    {
                        Group = g17701,
                        Discipline = fiz2
                    },
                    new GroupsDisciplines()
                    {
                        Group = g16701,
                        Discipline = fiz2
                    },
                    new GroupsDisciplines()
                    {
                        Group = g15701,
                        Discipline = fiz2
                    },
                    new GroupsDisciplines()
                    {
                        Group = g18201,
                        Discipline = matlec4
                    },
                    new GroupsDisciplines()
                    {
                        Group = g18201,
                        Discipline = matsem7
                    },
                    new GroupsDisciplines()
                    {
                        Group = g17201,
                        Discipline = matlec4
                    },
                    new GroupsDisciplines()
                    {
                        Group = g17201,
                        Discipline = matsem7
                    },
                    new GroupsDisciplines()
                    {
                        Group = g16201,
                        Discipline = matlec4
                    },
                    new GroupsDisciplines()
                    {
                        Group = g16201,
                        Discipline = matsem7
                    },
                    new GroupsDisciplines()
                    {
                        Group = g15201,
                        Discipline = matlec4
                    },
                    new GroupsDisciplines()
                    {
                        Group = g15201,
                        Discipline = matsem7
                    },
                    new GroupsDisciplines()
                    {
                        Group = g18701,
                        Discipline = matlec3
                    },
                    new GroupsDisciplines()
                    {
                        Group = g18701,
                        Discipline = matsem8
                    },
                    new GroupsDisciplines()
                    {
                        Group = g17701,
                        Discipline = matlec3
                    },
                    new GroupsDisciplines()
                    {
                        Group = g17701,
                        Discipline = matsem8
                    },
                    new GroupsDisciplines()
                    {
                        Group = g16701,
                        Discipline = matlec3
                    },
                    new GroupsDisciplines()
                    {
                        Group = g16701,
                        Discipline = matsem8
                    },
                    new GroupsDisciplines()
                    {
                        Group = g15701,
                        Discipline = matlec3
                    },
                    new GroupsDisciplines()
                    {
                        Group = g15701,
                        Discipline = matsem8
                    }
                 );
                db.SaveChanges();
                
                db.Sessions.AddRange(
                    new Session()
                    {
                        Date = DateTime.Parse("1/02/2019")
                    },
                    new Session()
                    {
                        Date = DateTime.Parse("1/06/2019")
                    },
                    new Session()
                    {
                        Date = DateTime.Parse("1/06/2018")
                    },
                    new Session()
                    {
                        Date = DateTime.Parse("1/02/2018")
                    }
                 );
                db.SaveChanges();
                db.Journals.AddRange(
                    new Journal()
                    {
                        Mark = 5,
                        StudentId = 1,
                        TeacherId = 1,
                        DisciplineId = 5,
                        SessionId = 1
                    },
                    new Journal()
                    {
                        Mark = 5,
                        StudentId = 2,
                        TeacherId = 1,
                        DisciplineId = 5,
                        SessionId = 1
                    },
                    new Journal()
                    {
                        Mark = 4,
                        StudentId = 3,
                        TeacherId = 2,
                        DisciplineId = 6,
                        SessionId = 1
                    },
                    new Journal()
                    {
                        Mark = 3,
                        StudentId = 4,
                        TeacherId = 2,
                        DisciplineId = 6,
                        SessionId = 1
                    },
                    new Journal()
                    {
                        Mark = 5,
                        StudentId = 4,
                        TeacherId = 2,
                        DisciplineId = 6,
                        SessionId = 2
                    },
                    new Journal()
                    {
                        Mark = 5,
                        StudentId = 3,
                        TeacherId = 2,
                        DisciplineId = 6,
                        SessionId = 2
                    }
                 );
                db.SaveChanges();
                db.Diplomas.AddRange(
                    new Diploma()
                    {
                        Theme = "Java Compiler Optimization",
                        StudentId = 6,
                        TeacherId = 6
                    },
                    new Diploma()
                    {
                        Theme = "Tsunami predetection",
                        StudentId = 4,
                        TeacherId = 4
                    }
                 );
                db.SaveChanges();
            }
        }
    }
}