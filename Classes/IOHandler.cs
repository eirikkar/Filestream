public class IOHandler
{
    public void AppendToFile(string path, string content)
    {
        File.AppendAllText(path, content);
    }

    public void ReadFile(string path)
    {
        string[] lines = File.ReadAllLines(path);
        try
        {
            foreach (string line in lines)
            {
                Console.WriteLine($"{line}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the content of the file {path} {ex}");
        }
    }

    public void WriteToFile(string path, string content)
    {
        File.WriteAllText(path, content);
    }

    public string CreateFile(string path)
    {
        var myFile = File.Create(path);
        myFile.Close();
        return path;
    }
}
