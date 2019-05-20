using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace AppFour.Entities
{
    public class LoadData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new AppDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDBContext>>()))
            {
                if (db.Workers.Any() || db.Projects.Any())
                {
                    return;
                }

                db.Workers.AddRange(
                    new Worker()
                    {
                        Name = "Alexander Pushkin"
                    },
                    new Worker()
                    {
                        Name = "Sergey Bezrukov"
                    },
                    new Worker()
                    {
                        Name = "Chuck Norris"
                    },
                    new Worker()
                    {
                        Name = "Anton Chekhov"
                    },
                    new Worker()
                    {
                        Name = "July Cesar"
                    });
                
                db.Projects.AddRange(
                    new Project()
                    {
                        ProjectName = "Web application",
                        Award = 15000,
                        WorkerId = 1
                        
                    },
                    new Project()
                    {
                        ProjectName = "Qr design",
                        Award = 30000,
                        WorkerId = 1
                    },
                    new Project()
                    {
                        ProjectName = "Java programming",
                        Award = 24000,
                        WorkerId = 3
                    },
                    new Project()
                    {
                        ProjectName = "Operating systems",
                        Award = 150000,
                        WorkerId = 3
                    },
                    new Project()
                    {
                        ProjectName = "Parallel programming",
                        Award = 100000,
                        WorkerId = 4
                    });
                db.SaveChanges();
            }
        }
    }
}