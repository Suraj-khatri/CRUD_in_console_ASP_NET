using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleEF
{
    public class Service
    {

        private readonly Context _context = new Context();

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public void Add(Student student)
        {
            
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void Update(Student student)
        {
            var stud = _context.Students.FirstOrDefault(x => x.Id == student.Id);
            if (stud == null)
            {
                Console.WriteLine("Student not found");
            }
            stud.Name = student.Name;
            _context.Students.Update(stud);
            _context.SaveChanges();
            
        }
        public void Delete(Guid id)
        {
            var stud = _context.Students.FirstOrDefault(x => x.Id == id);
            if (stud == null)
            {
                Console.WriteLine("Student not found");
            }
            _context.Students.Remove(stud);
            _context.SaveChanges();
        }
    }
}
