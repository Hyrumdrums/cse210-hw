using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, enter 0 when finished:");
        List<int> numbers = new List<int>();
        int number = 0;
        do
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // sum
        int sum = 0;
        foreach (int num in numbers)
        {
          sum+= num;
        }
        Console.WriteLine($"Sum: {sum}");

        // average
        float average = 0;
        if (numbers.Count > 0)
        {
          average = (float)sum / numbers.Count;
        }
        Console.WriteLine($"The average is: {average}");

        // max
        int max = 0;
        foreach (int num in numbers)
        {
          if (num > max)
          {
            max = num;
          }
        }
        Console.WriteLine($"The largest number is: {max}");

        // min positive
        int minPositive = int.MaxValue;
        foreach (int num in numbers)
        {
          if (num > 0 && num < minPositive)
          {
            minPositive = num;
          }
        }
        Console.WriteLine($"The smallest positive is: {minPositive}");

        // sorted list
        numbers.Sort();
        Console.Write("The sorted list is: ");
        foreach (int num in numbers)
        {
          Console.WriteLine($"{num} "); 
        }

    }
}