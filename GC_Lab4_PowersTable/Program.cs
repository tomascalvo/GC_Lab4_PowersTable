using System;

namespace GC_Lab4_PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //WELCOME
            Console.WriteLine("Let's learn the powers table.");

            //LOOP
            bool repeat = true;
            do
            {
                //INPUT
                int integer = ReadIntegers("Enter an integer.");

                //PROCESSING
                ListPowers(integer);

                //REPETITION
                bool valid = false;
                do
                {
                    Console.WriteLine("Go again? y/n");

                    string repeatResponse = Console.ReadLine().ToLower();
                    if (repeatResponse == "y" || repeatResponse == "yes")
                    {

                        repeat = true;      
                        valid = true;
                    }
                    else if (repeatResponse == "n" || repeatResponse == "no")
                    {
                        Console.WriteLine("Bye.");
                        repeat = false;
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry.");
                        valid = false;
                    }
                } while (!valid);

            } while (repeat);
        }

        //ReadIntegers METHOD
        public static int ReadIntegers(string prompt)
        {
            int integer;
            bool valid = false;
            do
            {
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                bool isInteger = int.TryParse(response, out integer);
                if (isInteger)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid entry.");
                    valid = false;
                }
            } while (!valid);

            return integer;
        }

        //ListPowers METHOD
        //I used the method String.Format to format the table.
        //https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c

        public static void ListPowers(int integer)
        {
            Console.WriteLine(FormatTableHeadings("Number", "Squared", "Cubed"));

            Console.WriteLine(FormatTableHeadings("----------", "----------", "----------"));

            for (int i = 1; i <= integer; i++)
            {
                int squared = i * i;
                int cubed = i * i * i;

                Console.WriteLine(FormatTableContent(i, squared, cubed));
            }
        }

        //FormatTableHeadings METHOD
        public static string FormatTableHeadings(string column1, string column2, string column3)
        {
            return String.Format("{0,10}|{1,10}|{2,10}", column1, column2, column3);
        }

        //FormatTableContent METHOD
        public static string FormatTableContent(int column1, int column2, int column3)
        {
            return String.Format("{0,10}|{1,10}|{2,10}", column1, column2, column3);
        }
    }
}