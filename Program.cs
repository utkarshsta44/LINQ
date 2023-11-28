using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            bool endProcess = false;
            do
            {
                Console.WriteLine("\nEnter a option :-");
                Console.WriteLine("1. DistinctElement");
                Console.WriteLine("2. FirstOrFirstDefault");
                Console.WriteLine("3. OrderByAndThenBy");
                Console.WriteLine("4. Select");
                Console.WriteLine("5. singleOrSingleDefault");
                Console.WriteLine("6.  SkipAndTake");
                Console.WriteLine("7. Where");
                Console.WriteLine("8. Exit");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        DistinctElement.Method();
                        break;

                    case "2":
                        FirstOrFirstDefault.Method();
                        break;

                    case "3":
                        OrderByAndThenBy.Method();
                        break;

                    case "4":
                        Select.Method();
                        break;

                    case "5":
                        SingleOrSingleDefault.Method();
                        break;

                    case "6":
                        SkipAndTake.Method();
                        break;

                    case "7":
                        Where.Method();
                        break;


                    case "8":
                        endProcess = true;
                        Console.WriteLine("\nExit.....");
                        break;

                    default:
                        Console.WriteLine("\nInvalid option, Please try again\n");
                        break;
                }
            } while (!endProcess);
            Console.ReadKey();
        }
    }
}