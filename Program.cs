class Program
{
    static void Main(string[] args)
    {
        IOHandler iOHandler = new IOHandler();
        Utility utility = new Utility();

        Console.WriteLine("Choose which file you want to open:\n");
        string filePath = utility.ParseText(Console.ReadLine());
        Console.WriteLine("Write something to a text file:\n");
        string text = utility.ParseText(Console.ReadLine());
        iOHandler.WriteToFile(iOHandler.CreateFile(filePath), text);
    }
}
