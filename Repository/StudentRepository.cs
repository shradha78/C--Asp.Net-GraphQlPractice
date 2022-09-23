using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPPractice.Data;

namespace ASPPractice.Repository
{
    public class StudentRepository 
    {
        public StudentContext _context;

       public StudentRepository( StudentContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<Student> GetStudents()
        {
            return _context.Details;
        }
        public Student GetStudentWithId(int id)
        {
            var studentFound = _context.Details.FirstOrDefault(s => s.Id == id);
            return studentFound;
        }
        public Student CreateStudent(Student student)
        {
            this._context.Details.Add(student);
            this._context.SaveChanges();
            return this._context.Details.First(s => s.Name == student.Name);
        }

       
    }
}
