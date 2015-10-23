using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03ArraySlider
{
    class ArraySlider
    {
        
         public static void Main()
        {
            var arr = Console.ReadLine().Split(new char[] { },
                StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();
            string line = Console.ReadLine();
            int currentIndex = 0;
            while (line != "stop")
            {
                var lineArgs = line.Split(new char[] { },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                int offset = int.Parse(lineArgs[0])%arr.Length;
                string operatorr = lineArgs[1];
                BigInteger operand = BigInteger.Parse(lineArgs[2]);

                if (offset < 0)
                {
                    currentIndex = (currentIndex + offset + arr.Length) % arr.Length;
                }
                else
                {
                    currentIndex = (currentIndex + offset) % arr.Length;
                }
                ProcessCommand(arr, currentIndex, operatorr, operand);
                line = Console.ReadLine();
            }

            Console.WriteLine("[{0}]",string.Join (", ",arr));
        }

        private static void ProcessCommand(BigInteger[] arr, int currentIndex, string operatorr, BigInteger operand)
        {
            switch (operatorr)
            {
                case "&":
                    arr[currentIndex] &= operand;
                    break;
                case "|":
                    arr[currentIndex] |= operand;
                    break;
                case "^":
                    arr[currentIndex] ^= operand;
                    break;
                case "+":
                    arr[currentIndex] += operand;
                    break;
                case "-":
                    arr[currentIndex] -= operand;
                    if (arr[currentIndex]<0)
                    {
                        arr[currentIndex] = 0;
                    }
                    break;
                case "*":
                    arr[currentIndex] *= operand;
                    break;
                case "/":
                    arr[currentIndex] /= operand;
                    break;
                default:
                    break;
            }
        }
    }
}
