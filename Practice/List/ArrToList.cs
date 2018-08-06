using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.List
{
    class ArrToList
    {
        public void GetArrToList()
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Mark",
                Section = 3
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Charls",
                Section = 4
            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Lin",
                Section = 1
            };


            // Converting Arrar to List
            Student[] students = new Student[3];
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;

            List<Student> studentsList = students.ToList();
            foreach (Student stu in studentsList)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Section: {2}", stu.Id, stu.Name, stu.Section);
            }

            //Converting List to Dictionary
            // Already Done in Dictionaries .. path: Practice -> Dictionaries -> ArratToDictionaries.cs file
               
             
        }
    }
}
