using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CommandInterpreter
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string line = Console.ReadLine();
        string[] command = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] output = new string[input.Length];
        while (line != "end")
        {
            if (line == ("reverse from " + command[2] + " count " + command[4]) &&
                int.Parse(command[2]) >= 0 && int.Parse(command[4]) > 0 && int.Parse(command[2])<input.Length)
            {
                ReversePartOfArray(input,command);
            }

            else if (line == ("sort from " + command[2] + " count " + command[4]) &&
                int.Parse(command[2]) >= 0 && int.Parse(command[4]) > 0 && int.Parse(command[2]) < input.Length)
            {
                SortPartOfArray(input, command);
            }
            //else if (line == ("rollLeft " + command[1] + " times") && 
            //    int.Parse(command[1]) >= 0)
            //{

            //}
            //else if (line == ("rollLeft " + command[1] + " times") && 
            //int.Parse(command[1]) >= 0)
            //{
            //
            //}
            else { Console.WriteLine("Invalid input parameters."); }
            line = Console.ReadLine();

        }
        Console.WriteLine("[" + string.Join(", ",input)+"]");
    }
    public static void ReversePartOfArray(string[] array, string[] command)
    {
        int start = int.Parse(command[2]);
        int count = int.Parse(command[4]);
        int j = 0;
        if (start + count - 1 >= array.Length)
        {
             j = array.Length -1;
        }
        else
        {
            j = start + count - 1;
        }
            for (int i = start; i <= j; i++)
        {
            var x = array[i];
            array[i] = array[j];
            array[j] = x;
            j--;
        }
    
    }
    public static void SortPartOfArray(string[] array, string[] command)
    {
        int start = int.Parse(command[2]);
        int count = int.Parse(command[4]);
        int my = 0;
        if (start + count - 1 >= array.Length)
        {
            my = array.Length - 1;
        }
        else
        {
            my = start + count - 1;
        }
        List<string> newList = new List<string>();
        for (int i = start; i <= my; i++)
        {
            newList.Add(array[i]);
        }
        newList.Reverse();

        int j = 0;
         
        for (int i = start; i < my; i++)
        {
            array[i] = newList[j];
            j++;
        }
    }
}

