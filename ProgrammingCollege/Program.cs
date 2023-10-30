using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**** Date: 23/07/1402 & 30/07/1402****/
namespace ProgrammingCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World");*/

            /*******************/

            /*Console.WriteLine("Size of int: {0}", sizeof(int)); */

            /*******************/

            /*int num1, num2, sum;

            Console.Write("Enter Number 1:\t");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 1:\t");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;

            Console.Write("Number 1 + Number 2 =\t{0}", sum);*/

            /*******************/

            /* int myIntNumber = 1;
             string myString = myIntNumber.ToString();
             Console.WriteLine("Int 1 To String:          {0}\n", myString);

             double myDoubleNumber = 5555.5555;
             int myInt = (int)myDoubleNumber;
             Console.WriteLine("Double 5555.5555 To Int:  {0}\n", myInt);

             int i = 100;
             float f = 55.55f;
             double d = 55.555555;
             bool b = true;

             Console.WriteLine("Int 100 To String:        {0}\n", i.ToString());
             Console.WriteLine("Float 55.55 To String:    {0}\n", f.ToString());
             Console.WriteLine("Double 55.5555 To String: {0}\n", d.ToString());
             Console.WriteLine("Bool true Tp String:      {0}\n", b.ToString());*/

            /*******************/

            /* while (true)
             {
                 Console.Clear();

                 int num1, num2, sum;

                 Console.Write("Inter Number 1: \t");
                 num1 = int.Parse(Console.ReadLine());
                 Console.Write("Inter Number 2: \t");
                 num2 = int.Parse(Console.ReadLine());

                 sum = num1 + num2;

                 if (sum < 13)
                 {
                     Console.WriteLine("\n\n -------- sum < 13 -------- ");
                 }
                 else
                 {
                     Console.WriteLine("\n\n -------- sum > 13 -------- ");
                 }

                 Console.ReadKey();
             }*/

            /*******************/

            /*int number = 15;
            number = 20;
            Console.WriteLine("Your number is: {0}", number);*/

            /*******************/

            /*while (true) {
                float radius, pi = 3.14f;

                Console.Clear();
                Console.Write("Please enter the radius of the circle: \t");
                radius = float.Parse(Console.ReadLine());

                radius = 4 * pi * (radius * radius);

                Console.WriteLine("\n-----Area {0}-----\n", radius);
            }*/

            /*******************/

            /*while (true) {
                Console.Clear();

                int sum = 0, input = 0;

                do
                {
                    Console.Write("Please enter the input number (zero to exit): \t");
                    input = int.Parse(Console.ReadLine());
                    sum += input;
                } while (Convert.ToBoolean(input));

                Console.WriteLine("\t\n------------- Sum {0} -------------", sum);

                Console.ReadKey();
            }*/

            /*******************/

            /*while (true)
            {
               *//* Console.Clear();*//*

                string hello, world, helloWorld;
                Console.Write("Enter Hello:\t");
                hello = Console.ReadLine();
                Console.Write("Enter World:\t");
                world = Console.ReadLine();

                helloWorld = hello + world;

                *//*Console.WriteLine("\n\t---------- {0} {1} ----------\n", hello, world);*//*
                Console.WriteLine("\n\t---------- {0} ----------\n", helloWorld);

                *//*Console.ReadKey();*//*
            }*/

            /*     string bio = "Im Mobin Javari";
                 int age = 18;
                 float height = 184.5f;
                 bool male = true;
                 char id = 'M';

                 Console.WriteLine("bio: {0}\nage: {1}\nheight: {2}\nmale: {3}\nid: {4}", bio, age, height, male, id);
            */
            /*
                        while (true)
                        {
                            string mathAction;
                            int mathResult, mathValue1, mathValue2;

                            Console.Write("Enter Number 1:\t");
                            mathValue1 = int.Parse(Console.ReadLine());

                            Console.Write("Enter Math (+ - * /): \t");
                            mathAction = Console.ReadLine();

                            Console.Write("Enter Number 2:\t");
                            mathValue2 = int.Parse(Console.ReadLine());

                            switch (mathAction)
                            {
                                case "+":
                                    mathResult = mathValue1 + mathValue2;
                                    break;

                                case "-":
                                    mathResult = mathValue1 - mathValue2;
                                    break;

                                case "*":
                                    mathResult = mathValue1 * mathValue2;
                                    break;

                                case "/":
                                    mathResult = mathValue1 / mathValue2;
                                    break;

                                default:
                                    Console.WriteLine("Error Math Action !");
                                    mathResult = 0;
                                    break;
                            }

                            Console.WriteLine("\n\t-------- Math Result: {0} --------\n", mathResult);
                        }*/

            /*******************/

            /*char grade = 'A';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Char A");
                    break;

                case 'B':
                case 'C':
                    Console.WriteLine("Char B & C");
                    break;

                case 'D':
                    Console.WriteLine("Char D");
                    break;

                case 'F':
                    Console.WriteLine("Char F");
                    break;

                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }*/

            Console.ReadKey();
        }
    }
}
