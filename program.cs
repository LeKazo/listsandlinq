using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listsandlinq
{
    class Program
    {
        Console.WriteLine("Enter numbers, or 0 to stop:");


List<int> values = new List<int>();


while (true)
{
   
    string line = Console.ReadLine();

        
        int value;
    if (!int.TryParse(line, out value)
        {
            Console.WriteLine("Please enter a valid number!");
            continue; 
        }

    if (value == 0)
    {
      
        break; 
    }
 
    
    values.Add(value);
}

    
    int total = 0;
foreach(int value in values)
{
   total += value;
}

Console.WriteLine("Sum of values = {0}", total);


    }
}
