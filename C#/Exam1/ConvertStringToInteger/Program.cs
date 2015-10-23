using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
        string something = Console.ReadLine();
        double number = 0;
        int helper = 0;
        
        if (something == null)
        {
            Console.WriteLine("OverflowExeption");
        }
        else
        {
            for (int i = something.Length - 1; i >= 0; i--)
            {

                try
                {
                    switch (something[i])
                    {
                        case '0': number += 0 * Math.Pow(10, helper); break;
                        case '1': number += 1 * Math.Pow(10, helper); break;
                        case '2': number += 2 * Math.Pow(10, helper); break;
                        case '3': number += 3 * Math.Pow(10, helper); break;
                        case '4': number += 4 * Math.Pow(10, helper); break;
                        case '5': number += 5 * Math.Pow(10, helper); break;
                        case '6': number += 6 * Math.Pow(10, helper); break;
                        case '7': number += 7 * Math.Pow(10, helper); break;
                        case '8': number += 8 * Math.Pow(10, helper); break;
                        case '9': number += 9 * Math.Pow(10, helper); break;
                        default: 
                            break;
                    }
                }
                catch (Exception) { Console.WriteLine("FormatException");  break; }
                
                helper++;
               
            }
            Console.WriteLine(number);
        }
        {

        }
        }
    }

