namespace Class_Managment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iastifadeci detallariini daxil et:");
            Console.Write("Full Name: ");
            string fullName = Console.ReadLine();
            Console.Write("Point: ");
            int point = int.Parse(Console.ReadLine());

            Student user = new Student(fullName, point);

            Console.WriteLine("\n1. Show info\n2. Create new group");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("istifADECİ MELUMATLARİ");
                user.StudentInfo();
            }
            else if (choice == 2)
            {
                Console.WriteLine("GROUP Detallarini daxil et:");
                Console.Write("Group No: ");
                string groupNo = Console.ReadLine();
                Console.Write("Student Limit: ");
                int studentLimit = int.Parse(Console.ReadLine());

                Group group = new Group(groupNo, studentLimit);
                Console.WriteLine("Group yarat.");
            }

            
        }


    }   
}
