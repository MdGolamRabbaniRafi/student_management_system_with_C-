using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system
{
    public class Student : Profile
    {

        public static int studentCount = 0;

        public static void AddStudent(Student[] students)
        {
            if (studentCount >= students.Length)
            {
                Console.WriteLine("Student list is full!");
                return;
            }

            Student student = new Student();

            Console.WriteLine("Enter Student Id: ");
            student.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter Student Age: ");
            student.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Description: ");
            student.Description = Console.ReadLine();

            Console.WriteLine("Enter Student Status: ");
            student.Status = Console.ReadLine();

            students[studentCount] = student;

            studentCount++;

            Console.WriteLine("Student added successfully!");
        }
        public static void ViewStudents(Student[] students)
        {
            if (studentCount == 0)
            {
                Console.WriteLine("No students found!");
                return;
            }
            Console.WriteLine("Student List:");
            for (int i = 0; i < studentCount; i++)
            {
                Student student = students[i];
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Description: {student.Description}, Status: {student.Status}");
            }
        }
        public static Student GetStudentById(Student[] students, int id)
        {
            for (int i = 0; i < studentCount; i++)
            {
                if (students[i].Id == id)
                {
                    return students[i];
                }
            }
            return null;


        }
    }
}
