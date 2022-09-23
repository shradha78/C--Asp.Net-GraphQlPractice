
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPPractice.Data;
using ASPPractice.Repository;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPPractice.Controllers
{
   /* public class Stud
    {
        private int id;
        private string name;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }*/
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /* private List<Stud> studs = new List<Stud>
         {
             new Stud {Id = 1,Name = "Alex"},
             new Stud {Id = 2,Name = "Bob"},
             new Stud {Id = 3,Name = "Mark"},
             new Stud {Id = 4,Name = "Sam"},
             new Stud {Id = 5,Name = "Lex"},
         }; //for postman queries*/
        /*  [HttpGet]
        public IEnumerable<Student> Get()
        {
            return studs;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Stud Get(int id)
        {
            return studs.First(s => s.Id == id);
        }
        // POST api/<ValuesController>
        [HttpPost]
        public Stud Post(Stud s)
        {
            this.studs.Add(s);
            return s;
        }
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public Stud Put(int id, Stud s)
        {
            var index = studs.IndexOf(studs.First(a => a.Id == id));
            studs[index] = s;
            return studs[index];
        }
        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Stud> Delete(int id)
        {
            var index = studs.IndexOf(studs.First(a => a.Id == id));
            studs.RemoveAt(index);
            return studs.ToArray();

        }*/
        // GET: api/<ValuesController>

        //Using Repository
        public StudentRepository _repo;
        public ValuesController(StudentRepository _repo)
        {
           this._repo = _repo;
        }
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _repo.GetStudents();
        }
     /*   public ValuesController(StudentContext studentContext)
        {
            this._context = studentContext;
        }
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Details;
        }*/
        // GET api/<ValuesController>/5
       /* [HttpGet("/{id}")]
        public Student Get(int id)
        {
            return _context.Details.First(s=> s.Id == id);
        }
        // POST api/<ValuesController>
        [HttpPost]
        public Student Post(Student s)
        {
            this._context.Details.Add(s);
            _context.SaveChanges();
            return s;
            
        }
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public Student Put(int id, Student s)
        {
            var studentToUpdate = _context.Details.First(s=>s.Id == id);
            studentToUpdate.Name = s.Name;
            _context.SaveChanges();
            return s ;
        }
        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var studentToDelete = _context.Details.First(s => s.Id == id);
            _context.Details.Remove(studentToDelete);
            _context.SaveChanges();

        }*/
    }
}



