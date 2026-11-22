using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system
{
    public class Teacher : Profile
    {
        public void TeacherMenu(Student[] students)
        {
            Console.WriteLine("Welcome, Teacher!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. View Students");
            Console.WriteLine("2. Find Student By Id");
            Console.WriteLine("3. Add Student");
            Console.WriteLine("4. Remove Student");
            Console.WriteLine("5. Update Student");

            Console.WriteLine("6. Exit");

            string option = Console.ReadLine()??"";


            if (option == "1")
            {
                ViewStudents(students);
                TeacherMenu(students);
            }
            else if (option == "2")
            {
                Console.Write("Enter Student Id: ");
                int id = int.Parse(Console.ReadLine());
                Student student = FindStudentById(students, id);
                if (student != null)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Description: {student.Description}, Status: {student.Status}");
                }
                else
                {
                    Console.WriteLine("Student not found!");
                }
                TeacherMenu(students);
            }
            else if (option == "3")
            {
                AddStudent(students);
                TeacherMenu(students);

            }
            else if (option == "4")
            {
                RemoveStudent(students);
                TeacherMenu(students);

            }
            else if (option == "5")
            {
                UpdateStudent(students);
                TeacherMenu(students);

            }
            else if (option == "6")
            {
                Console.WriteLine("\nEXIT !!!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                TeacherMenu(students);
            }
        }
        private void ViewStudents(Student[] students)
        {
           Student.ViewStudents(students);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
        }
        private void AddStudent(Student[] students)
        {
            Student.AddStudent(students);
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
        }
        private void RemoveStudent(Student[] students)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter The Student Id : ");
            //    int studentId = int.Parse(Console.ReadLine());
            //    if (studentId == 1)
            //    {
            //        Console.WriteLine($"Student with Id {studentId} removed successfully!");
            //    }else if (studentId == 2)
            //    {
            //        Console.WriteLine($"Student with Id {studentId} removed successfully!");
            //    }
            //    else if (studentId == 3)
            //    {
            //        Console.WriteLine($"Student with Id {studentId} removed successfully!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Student Id. Please try again.");
            //    }
            //}

        }
        private void UpdateStudent(Student[] students)
        {

            

            
            //Console.WriteLine("Enter The Student Id : ");
            //id = int.Parse(Console.ReadLine());
            

            //if(id == 1 || id == 2 || id == 3)
            //{

            //    Console.WriteLine("Enter The Student Name : ");
            //    name = Console.ReadLine();

            //    Console.WriteLine("Enter The Student Age : ");
            //    age = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter The Student Description : ");
            //    description = Console.ReadLine();

            //    Console.WriteLine("Enter The Student Status : ");
            //    status = Console.ReadLine();

            //    Console.WriteLine("Student updated successfully!");
            //}else
            //{
            //    Console.WriteLine("Invalid Student Id. Please try again.");
            //}




        }
        public Student FindStudentById(Student[] students, int id)
        {
           return Student.GetStudentById(students, id);
        }
    }
}
