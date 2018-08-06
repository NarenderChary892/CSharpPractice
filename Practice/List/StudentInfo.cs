using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.List
{
    class StudentInfo
    {
        public void GetStudentInfo()
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Bob",
               Section = 3
            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Alice",
                Section = 4
            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Jack",
                Section = 1
            };

            List<Student> studentsList = new List<Student>();
            {
                studentsList.Add(student1);
                studentsList.Add(student2);
                studentsList.Add(student3);
                studentsList.Insert(0, student3);
            }
            
            Console.WriteLine("\n\nList's");
            foreach(Student stu in studentsList)
            {
                Console.WriteLine("Id: {0}, Name: {1}, Section: {2}", stu.Id, stu.Name, stu.Section);
            }

            // Using IndexOf
            Console.WriteLine(studentsList.IndexOf(student3,1,3));

            // using Find only we can get one object
            //Student ss = studentsList.FindLast(stu => stu.Section > 2);
            
            Student s = studentsList.Find(stu => stu.Section > 2);
            Console.WriteLine("Using Find Method: Id: {0}, Name: {1}, Section: {2}", s.Id, s.Name, s.Section);

            // Uisng FindAll Method
            List<Student> ss = studentsList.FindAll(stu => stu.Section > 2);
            foreach(var sss in ss)
            {
                Console.WriteLine("Using FindAll Method: Id: {0}, Name: {1}, Section: {2}", sss.Id, sss.Name, sss.Section);
            }

            //if(studentsList.Exists(cust => cust.Name.StartsWith("Ali")))
            if (studentsList.Contains(student2))
            {
                Console.WriteLine("Exist in the List");
            }
            else
            {
                Console.WriteLine("Not Exist in the List");
            }

            // Similarly We can use FIndIndex() and FindLastIndex() mathods also.
        }
    }
}
