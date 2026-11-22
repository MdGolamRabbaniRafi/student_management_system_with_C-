using Student_management_system;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Student Management System!");
        Console.WriteLine("Please identify yourself:");
        Console.WriteLine("1. Teacher");
        Console.WriteLine("2. Student");
        Console.WriteLine("3. Admin");
        Console.WriteLine("Select an option:");


        string userType = Console.ReadLine();


        Student s1 = new Student();

        s1.Id = 1;
        s1.Name = "Auhin";
        s1.Description = "He Is A Math's Student";
        s1.Age = 28;
        s1.status = "Active";





        if (userType == "1")
        {
            Teacher teacher = new Teacher();
            teacher.TeacherMenu();
        }
        //else if (userType == "2")
        //{
        //    Student student = new Student();
        //    student.StudentMenu();
        //}
        //else if (userType == "3")
        //{
        //    Admin admin = new Admin();
        //    admin.AdminMenu();
        //}
        else
        {
            Console.WriteLine("Invalid option. Please try again.");
        }

       Console.ReadKey();

    }
}