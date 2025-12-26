class Program
{
    static int Main(string[] args)
    {
        string? input = null;

        if (args.Length > 0)
        {
            input = args[0];
        }
        else
        {
            input = Console.ReadLine();
        }

        if (input is null) return 1;

        var output = PhonePad.OldPhonePad(input);
        Console.WriteLine(output);

        return 0;
    }
}