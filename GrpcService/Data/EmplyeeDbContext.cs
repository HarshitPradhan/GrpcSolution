using GrpcService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(
              GetEmployees()
            );
        }

        public DbSet<Employee> Employees { get; set; }

        private static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>() {
              new Employee() {    // 1
                EmployeeId=1,
                EmployeeName="Harshit Prad",
                EmployeeEmail="hp@gmail.com",
                EmployeeProfile="Technician",
              },
              new Employee() {    // 2
                EmployeeId=2,
                EmployeeName="Dev Prad",
                EmployeeEmail="dp@gmail.com",
                EmployeeProfile="Sales Manager",
              },
              new Employee() {    // 3
                EmployeeId=3,
                EmployeeName="Dhruv Prad",
                EmployeeEmail="Dhp@gmail.com",
                EmployeeProfile="Business head",
              },
              new Employee() {    // 4
                EmployeeId=4,
                EmployeeName="Kartik Prad",
                EmployeeEmail="kp@gmail.com",
                EmployeeProfile="software dev",
              },
              new Employee() {    // 5
                EmployeeId=5,
                EmployeeName="Deepu Prad",
                EmployeeEmail="Dep@gmail.com",
                EmployeeProfile="software dev in test",
              },
            };

            return employees;
        }
    }
}
