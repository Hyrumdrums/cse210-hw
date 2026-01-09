using System;

class Program
{
    const int A_GRADE = 90;
    const int B_GRADE = 80;
    const int C_GRADE = 70;
    const int D_GRADE = 60;
    // <60 = F

    const int PLUS_GRADE = 7;
    const int MINUS_GRADE = 3;

    const int passing = 70;

    const string congrats = "Congrats! You survived, you conquered, and you passed. The knowledge stuck, the brain cells cooperated, and victory is yours. Well done, champion.";
    const string encouragement = "Oof. The test won this round. But hey—every great comeback story starts with a dramatic plot twist. Recharge, retry, and show it who’s boss next time.";

    static void Main(string[] args)
    {
        Console.WriteLine("Letter Grade Converter");
        Console.Write("Enter a grade percentage (0-100): ");
        string input = Console.ReadLine();
        float gradePercentage = float.Parse(input);
        string letterGrade = "";
        if (gradePercentage >= A_GRADE)
        {
          letterGrade = "A";
        }
        else if (gradePercentage >= B_GRADE)
        {
          letterGrade = "B";
        }
        else if (gradePercentage >= C_GRADE)
        {
          letterGrade = "C";
        }
        else if (gradePercentage >= D_GRADE)
        {
          letterGrade = "D";
        }
        else
        {
          letterGrade = "F";
        }
        // Determine plus or minus
        int lastDigit = (int)(gradePercentage % 10);
        if (lastDigit >= PLUS_GRADE && letterGrade != "A")
        {
            letterGrade += "+";
        }
        else if (lastDigit < MINUS_GRADE && letterGrade != "F")
        {
            if(gradePercentage < 100) // catch where 100 mod 10 is 0
            {
                  letterGrade += "-";
            }
        }

        Console.WriteLine($"Letter Grade: {letterGrade}");
        if (gradePercentage >= passing)
        {
            Console.WriteLine("Status: Passing");
            Console.WriteLine(congrats);
        }
        else
        {
            Console.WriteLine("Status: Failing");
            Console.WriteLine(encouragement);
        }
    }
}