using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPPractice.Data;
using Microsoft.EntityFrameworkCore;


namespace ASPPractice.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            this.Database.EnsureCreated();
  
        }
        public DbSet<Student> Details { get; set; } //mapped to the table
    }
}
//Database = DB context
//table = table set
//db.setStudent -> create table named student , columns are going to come from entity
//collegeDB contect inheriting form db context
//base is dbcontext
//when run -> connect my db to specific sql server else create new db in that server
//specify where to be created -> defined in appsetings.json-> configuration file
//create initialdata class in data
//in studentContext you will get method Seed
//dbConetxt.any have no students, add new student