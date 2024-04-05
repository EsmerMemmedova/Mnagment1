using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Managment
{
    public class Student
    {

        private static int _id;
        public int Id { get; }
        public static string FullName { get; set; }
        public double Point {  get; set; }

        public Student(string fullName, double point)
        {
            _id++;
            Id = _id;
            FullName = fullName;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"Id:{_id},FullName:{FullName},Point:{Point}");
        }
    }
}
