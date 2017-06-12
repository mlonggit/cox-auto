using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace CoxAutoCode
{
    class Program
    {
        static void Main(string[] args)
        {

              /*Console Menu */
            bool done = false;
            Console.WindowWidth = 80;//Width-number of columns of text.
            Console.WindowHeight = 40;//Height- number of lines of text.
            Console.Title = "CoxAuto Code Demo";

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            do
            {
                Console.WriteLine("_____________________  Menu  ______________________");
                Console.WriteLine("  Select a number :");
                Console.WriteLine("\t 1. Key Count");
                Console.WriteLine("\t 2. Palindrome Detection");
                Console.WriteLine("\t 0. Exit");
                Console.WriteLine("___________________________________________________");
               
                Console.Write("  Enter Your selection (1 or 2 or 0 to exit): ");
                string strSelection = Console.ReadLine();
                int selected;
                try
                {
                    selected = int.Parse(strSelection);
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("\r\nError: You entered an invalid selection.\r\n");
                    continue;
                }
                Console.WriteLine("You selected  " + selected);
                switch (selected)
                {
                    case 0:
                        done = true;
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" 1.Key Count\r\n");
                            try
                            {
                                KeyCount.myKeyValuePair();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" 2.Palindrome Detection\r\n");
                        PalindromeDetection.checkPalindrone();
                        break;
                    
                    default:
                        Console.Clear();
                        Console.WriteLine(" You selected an invalid number: {0}\r\n", selected);
                        continue;
                }
                Console.WriteLine();
            } while (!done);

            Console.WriteLine("\n");
        }

        
    }
}
