using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_calc_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input_line;
            double a = 0, b = 0, res = 0;
            string[] in_vals = { "0", "0", "0" };
            bool allright = false, go_on = true;
            Console.WriteLine("willkommen. It is test calculator, written by Evgenii Didin");
            Console.WriteLine("The input format is arg1 action arg2. For example 10divide4 will be 10 / 4. ");
            Console.WriteLine("Calc operators: '+', '-', '/', 'div', 'mod', '*', '^'");
            Console.WriteLine("To exit print '0 0 0' ");
            while (go_on)
            {
                while (!allright)
                {
                    input_line = Console.ReadLine();
                    in_vals = input_line.Split(' ');
                    try
                    {
                        a = Convert.ToDouble(in_vals[0]);
                        b = Convert.ToDouble(in_vals[2]);
                        allright = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: wrong arguments");
                    }
                }
                if ((in_vals[1] == "/" | in_vals[1] == "mod" | in_vals[1] == "div") & b == 0)
                {
                    Console.WriteLine("Error: Divizion by zero!");
                }
                else
                {
                    switch (in_vals[1])
                    {
                        case "+":
                            res = a + b;
                            break;
                        case "-":
                            res = a - b;
                            break;
                        case "/":
                            res = a / b;
                            break;
                        case "*":
                            res = a * b;
                            break;
                        case "mod":
                            res = a % b;
                            break;
                        case "div":
                            res = Convert.ToInt32(a) / Convert.ToInt32(b);
                            break;
                        case "^":
                            res = Math.Pow(a, b);
                            break;
                        case "0":
                            Console.WriteLine("Thanks for using my calc. See ya. Press an Key");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine("Wrong operator");
                            break;
                    }
                    Console.WriteLine("result: " + res.ToString());

                }
                allright = false;
            }
        }
    }
}
