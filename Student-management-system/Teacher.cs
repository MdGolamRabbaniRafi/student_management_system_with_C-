using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system
{
    public class Teacher : Profile
    {
        public void TeacherMenu()
        {
            Console.WriteLine("Welcome, Teacher!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. View Students");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Exit");
            string option = Console.ReadLine();
           if (option == "1")
            {
                ViewStudents();
            }
            else if (option == "2")
            {
                AddStudent();
            }
            else if (option == "3")
            {
                RemoveStudent();
            }
            else if (option == "4")
            {
                UpdateStudent();
            }
            else if (option == "5")
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                TeacherMenu();
            }
        }
        private void ViewStudents()
        {

        }
        private void AddStudent()
        {
            // Code to add a student
        }
        private void RemoveStudent()
        {
            // Code to remove a student
        }
        private void UpdateStudent()
        {
            // Code to update a student
        }
    }
}
