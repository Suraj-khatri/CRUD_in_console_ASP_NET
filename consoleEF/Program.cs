using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace consoleEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            bool isTrue = true;
            while(isTrue)
            {
                Console.WriteLine("Choose");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Display Students");
                Console.WriteLine("3.Update Students");
                Console.WriteLine("4.Delete Students");
                Console.WriteLine("0.Exit");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    var stud = new Student();
                    stud.Id = Guid.NewGuid();
                    Console.WriteLine("enter student name:");
                    stud.Name = Console.ReadLine();
                    service.Add(stud);
                    Console.WriteLine("Added succesfully");
                }
                else if(input == "2")
                {
                    var students = service.GetAll();
                    foreach(var student in students)
                    {
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine($"Student Id ={student.Id}");
                        Console.WriteLine($"Student Name ={student.Name}");
                        Console.WriteLine("-------------------------------");
                    }
                }
                else if(input == "3")
                {
                    var stud = new Student();
                    Console.WriteLine("enter id to update");
                    var id = Console.ReadLine();
                    var isSuccess = Guid.TryParse(id, out Guid result);
                    if (isSuccess)
                    {
                        Console.WriteLine("Enter new name:");
                        stud.Name = Console.ReadLine();
                        service.Update(stud);
                        Console.WriteLine("updated");
                    }
                    else
                    {
                        Console.WriteLine("you have entered wrong Id");
                    }
                    
                }
                else if(input =="4")
                {

                    Console.WriteLine("enter student id to delete");
                    var id = Guid.Parse(Console.ReadLine());
                    service.Delete(id);
                    Console.WriteLine("Deleted successfully");
                }
                else if(input == "0")
                {
                    isTrue = false;
                }
            }
            
            
        }
    }
}
