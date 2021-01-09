using System;

namespace Oppstask
{
    class Program
    {   
        enum UniversityStaff :byte 
        {
            Student=1,
            Teacher,
            Lecturer,
            Professor
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please,enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your surname:");
            string surname = Console.ReadLine();
            Console.WriteLine("Please,enter your father's name:");
            string fathers_name = Console.ReadLine();

            Console.WriteLine("Select your Role");
            byte role = byte.Parse(Console.ReadLine());
            string greetingWord = "";
            int time = DateTime.Now.Hour;
            if (time >= 5 && time < 12)
                greetingWord = "Good Morning";
            else if (time >= 12 && time < 16)
                greetingWord="Good afternoon";
            else if (time >= 16 && time < 24)
                greetingWord="Good Evening";

            string staff = "";
            switch(role)
            {
                case (byte)UniversityStaff.Student:
                    staff = $"Welcome to our University,{name},{surname},{fathers_name}"; 
                    break;
                case (byte)UniversityStaff.Teacher:
                    staff = $"Our university is the best place for self-developing you as a teacher!";
                    break;
                case (byte)UniversityStaff.Lecturer:
                    staff = $"Welcome back!,{name}!Students are waiting for your lectures :";
                    break;
                case (byte)UniversityStaff.Professor:
                    staff = $"{greetingWord} Professor!";
                    break;
                default:
                    staff = "Bele bir rol yoxdur";
                    break;

            }
            Console.WriteLine(staff);
        }
    }
}
