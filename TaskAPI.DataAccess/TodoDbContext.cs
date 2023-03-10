using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost; Database=MyTodos; User Id=sa; password=5503;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] 
            { 
                new Author{Id=1,Fullname="Nuwan",AddressNo="45",Street="Street 1",City="Colombo",JobRole="Developer" },
                new Author{Id=2,Fullname="Kasun",AddressNo="55",Street="Street 3",City="Kandy",JobRole="System Engineer"  },
                new Author{Id=3,Fullname="Kamal", AddressNo="65",Street="Street 9",City="Gampaha",JobRole="Developer"  },
                new Author{Id=4,Fullname="Nimal", AddressNo="75",Street="Street 7",City="Galla",JobRole="QA"  },
                new Author{Id=5,Fullname="Amal",AddressNo="80",Street="Street 5",City="Trinco",JobRole="QA"  }
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[] {
            new Todo{
                Id = 1,
                Title = "Get books for School from DB",
                Description = "Get Some text Books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress,
                AuthorId = 1
            },

            new Todo {
                Id = 2,
                Title = "Get books for School from DB",
                Description = "Get Some text Books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress,
                AuthorId = 2

            },

            new Todo
            {
                Id = 3,
                Title = "Get books for School from DB",
                Description = "Get Some text Books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress,
                AuthorId = 1

            }
            }
            );
        }


    }
}
