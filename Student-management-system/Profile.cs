using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system
{
    public class Profile
    {
        public int id;
        public string name;
        public int age;
        public string description;
        public string status;


        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }

        public string Status
        {
            get { return status; }
            set { this.status = value; }
        }

        //public Profile()
        //{
        //    this.id = 0;
        //    this.name = "";   // aita ki same?
        //    this.age = 0;
        //    this.description = "";
        //    this.status = "";

        //    Console.WriteLine("Profile Created");
        //}
    }
}
