foreach (var arg in args)
{
    StreamReader sr = new(arg);
    string? line;
    while ((line = sr.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}
