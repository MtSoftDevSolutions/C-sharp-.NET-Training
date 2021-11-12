using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                //creating and saving a new student
                Console.Write("Please enter the student's first name: ");
                var FirstName = Console.ReadLine();

                Console.Write("Please enter the student's last name: ");
                var LastName = Console.ReadLine();

                Console.Write("Please enter the student's Email Address: ");
                var EmailAddress = Console.ReadLine();

                Console.Write("Please enter the student's current GPA: ");
                decimal GPA = Convert.ToDecimal(Console.ReadLine());

                var student = new Student { FirstName = FirstName, LastName = LastName, EmailAddress = EmailAddress, GPA = GPA };
                db.Students.Add(student);
                db.SaveChanges();

                //Display all students from dB
                var total = from x in db.Students orderby x.GPA select x;

                Console.WriteLine("All students in the database: ");
                foreach (var item in total)
                {
                    Console.WriteLine(item.FirstName, item.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            }

    }

    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal GPA { get; set; }

        public virtual List<Student> Students { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    }

        
    
