using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_Managment
{
    public class Group
    {
        public string GroupName { get; set; }
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get
            {
                return StudentLimit;
            }
            set
            {
                if (value >= 8 && value <= 18)
                {
                    StudentLimit = value;
                }
            }

        }
        public  Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
           _students=new Student[studentLimit];
           
        }


        private Student[] _students;





        public bool CheckGroupNo(string groupNo)
        {
            bool upperCheck=false;
            bool digitCheck=false;
            if(groupNo.Length== 5)
            {
                return true;
            }
            if (char.IsUpper(groupNo[0]) && char.IsUpper(groupNo[1]))
            {
                return true;
            }
            if (char.IsDigit(groupNo[2]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
            {
                return true;
            }
            return upperCheck && digitCheck;
        } 


        public Student AddStudent(Student student)
        {
            Student[] newarr = new Student[0];

            if (_students.Length >= StudentLimit)
            {
                Array.Resize(ref newarr, _students.Length + 1);
            }
            return student;


        }

        public Student[] GetStudents()
        {
            return _students;
        }
    }
}
