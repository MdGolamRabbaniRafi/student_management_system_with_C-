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

            string option = Console.ReadLine()??"";


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
                Console.WriteLine("\nEXIT !!!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                TeacherMenu();
            }
        }
        private void ViewStudents()
        {
            Console.WriteLine("Student Id : 1");
            Console.WriteLine("Student Name : Auhin");
            Console.WriteLine("Student Age : 28");
            Console.WriteLine("Student Description : He Is A Math's Student");
            Console.WriteLine("Student Status : Active\n");

            Console.WriteLine("Student Id : 2");
            Console.WriteLine("Student Name : Rezwan");
            Console.WriteLine("Student Age : 27");
            Console.WriteLine("Student Description : He Is A Physics's Student");
            Console.WriteLine("Student Status : Active\n");

            Console.WriteLine("Student Id : 3");
            Console.WriteLine("Student Name : Rehan");
            Console.WriteLine("Student Age : 28");
            Console.WriteLine("Student Description : He Is A Chemistry's Student");
            Console.WriteLine("Student Status : Active\n");

        }
        private void AddStudent()
        {

            Console.WriteLine("Enter The Student Id : ");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Student Name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter The Student Age : ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Student Description : ");
            description = Console.ReadLine();

            Console.WriteLine("Enter The Student Status : ");
            status = Console.ReadLine();

            Console.WriteLine("Student added successfully!");

            
        }
        private void RemoveStudent()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter The Student Id : ");
                int studentId = int.Parse(Console.ReadLine());
                if (studentId == 1)
                {
                    Console.WriteLine($"Student with Id {studentId} removed successfully!");
                }else if (studentId == 2)
                {
                    Console.WriteLine($"Student with Id {studentId} removed successfully!");
                }
                else if (studentId == 3)
                {
                    Console.WriteLine($"Student with Id {studentId} removed successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid Student Id. Please try again.");
                }
            }

        }
        private void UpdateStudent()
        {

            

            
            Console.WriteLine("Enter The Student Id : ");
            id = int.Parse(Console.ReadLine());
            

            if(id == 1 || id == 2 || id == 3)
            {

                Console.WriteLine("Enter The Student Name : ");
                name = Console.ReadLine();

                Console.WriteLine("Enter The Student Age : ");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter The Student Description : ");
                description = Console.ReadLine();

                Console.WriteLine("Enter The Student Status : ");
                status = Console.ReadLine();

                Console.WriteLine("Student updated successfully!");
            }else
            {
                Console.WriteLine("Invalid Student Id. Please try again.");
            }


        }
    }
}
