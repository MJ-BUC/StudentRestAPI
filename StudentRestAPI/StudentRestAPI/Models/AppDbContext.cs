using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRestAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            // Send Student Table
            modelbuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Joe",
                    LastName = "Smith",
                    Email = "joe@smaplemail.com",
                    Gender = Gender.Male,
                    departmentId = 1,
                    PhotoPath = "Images/joe.png"
                });
            modelbuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 2,
                    FirstName = "John",
                    LastName = "Smith",
                    Email = "john@smaplemail.com",
                    Gender = Gender.Male,
                    departmentId = 2,
                    PhotoPath = "Images/john.png"
                });
            modelbuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 3,
                    FirstName = "James",
                    LastName = "Johnson",
                    Email = "james@smaplemail.com",
                    Gender = Gender.Male,
                    departmentId = 3,
                    PhotoPath = "Images/james.png"
                });
            modelbuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 4,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@smaplemail.com",
                    Gender = Gender.Male,
                    departmentId = 4,
                    PhotoPath = "Images/john.png"
                });
        }
    }
}
