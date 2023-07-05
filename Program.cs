using Exception;

internal class Program
{
    public static void Main(string[] args)
    {
        //try
        //{
        //    using (StreamReader reader = new StreamReader("demo.txt"))
        //    {
        //        reader.ReadToEnd();
        //    }
        //}
        //catch (FileNotFoundException e)
        //{
        //    Console.WriteLine("File doesn't exists so we created the file");
        //    File.Create(e.FileName);
        //}

        Console.WriteLine((int)Gender.FEMALE);
        Console.WriteLine((int)CarType.VAN);
        string description = getEnumDescription(CarType.BASIC);
        Console.WriteLine(description);

        int ordinalValue = 205;
        CarType type = (Cartype)ordinalValue;
        Console.WriteLine(type.ToString());
    }

    private static string getEnmDescription (Enum enums)
    {
        var field = enums.GetType().GetField(enums.ToString());
        var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
        return attribute !=  null ? attribute.Description : enums.ToString();
    }
}