using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Dallin Layton", "Software Development");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();
        MathAssignment mathAssignment = new MathAssignment("Dallin Layton", "Quantum Mechanics", "Chapter 5: Integrals", "Problems 1-10");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();
        WritingAssignment writingAssignment = new WritingAssignment("Dallin Layton", "Fake News", "The Impact of Misinformation");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation()); 
    } 
}