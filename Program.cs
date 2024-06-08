using System;

namespace IdentifyAge_Method_Salandanan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year of birth: ");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int age = calculation(yearOfBirth);

            string generation = gen(age);

            string stage = stages(age);

            Console.WriteLine($"{age} years old, {generation}, {stage}");
        }

        public static int calculation(int yearOfBirth) 
        {
            int age = 2024 - yearOfBirth;

            return age;
        }

        public static string gen(int age)
        {
            string generation = "";

            if (age >= 79 && age <= 96)
            {
                generation = "The Silent Generation";
            }
            else if (age >= 60 && age <= 78)
            {
                generation = "Baby Boomers";
            }
            else if (age >= 44 && age <= 59)
            {
                generation = "Gen X";
            }
            else if (age >= 28 && age <= 43)
            {
                generation = "Millenials";
            }
            else if (age >= 12 && age <= 27)
            {
                generation = "Gen Z";
            }
            else if (age >= 0 && age <= 11)
            {
                generation = "Gen Alpha";
            }

            return generation;
        }


        public static string stages(int age)
        {
            string stage = "";

            if (age >= 0 && age <= 3)
            {
                stage = "Infant";
            }
            else if (age >= 4 && age <= 6)
            {
                stage = "Early Childhood";
            }
            else if (age == 7 || age == 8)
            {
                stage = "Middle Childhood";
            }
            else if (age >= 9 && age <= 11)
            {
                stage = "Late Childhood";
            }
            else if (age >= 12 && age <= 20)
            {
                stage = "Adolescence";
            }
            else if (age >= 21 && age <= 35)
            {
                stage = "Early Adulthood";
            }
            else if (age >= 36 && age <= 50)
            {
                stage = "Midlife";
            }
            else if (age >= 51 && age <= 80)
            {
                stage = "Mature Adulthood";
            }
            else if (age > 80)
            {
                stage = "Late Adulthood";
            }

            return stage;
        }
    }
}
