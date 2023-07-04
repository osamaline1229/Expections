using Exception;

internal class Program
{
    public static void Main(string[] args)
    {
        student[] students =
        {
            new student("salim", "16338", 79),
            new student("Ahmed", "12230", 26),
            new student("osama", "12230", 30)
        };
        Console.WriteLine(student.VlodateStudents(students));
    }
}