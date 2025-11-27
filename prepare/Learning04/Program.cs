using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment sampleGenericAssignment = new Assignment("Andriarimalala, Tiana", "Programming with Classes: Inheritance");
        Console.WriteLine(sampleGenericAssignment.GetSummary());
        Console.WriteLine();  

        MathAssignment sampleMathAssignment = new MathAssignment("Takahashi, Aria", "Calculus: Integrals", "Section 3.2", "3, 7-22, 32");
        Console.WriteLine(sampleMathAssignment.GetSummary());
        Console.WriteLine(sampleMathAssignment.GetHomeworkList());   
        Console.WriteLine();  

        WritingAssignment sampleWritingAssignment = new WritingAssignment("Gutierrez, Berny", "Advanced Writing", "Provident Living");
        Console.WriteLine(sampleWritingAssignment.GetSummary());
        Console.WriteLine(sampleWritingAssignment.GetWritingInformation());  
    }
}