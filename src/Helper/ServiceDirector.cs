public static class ServiceDirector
{

    public static string[] CheckArguments(string[] args)
    {
        switch (args[0].ToLower())
        {
            case "help":
                displayHelp();
                break;
            case "analyze":
                if (args.Length == 2)
                {
                    var parsedArgs = new string[3] { args[1], "console", null };
                    return parsedArgs;
                }
                else if (args.Length == 3)
                {
                    var parsedArgs = new string[3] { args[1], "json", args[2] };
                    return parsedArgs;
                } else
                {
                    Console.WriteLine("Error: Invalid number of arguments for 'analyze' command.");
                    displayHelp();
                }
                break;
        }
        return null;
    }

    private static void displayHelp()
    {
        Console.WriteLine("Usage:");
        Console.WriteLine("  StaticBranchAnalyzer analyze <file-path> - Analyze the specified C# file for branches.");
        Console.WriteLine("  StaticBranchAnalyzer analyze <file-path> <output-path> - Analyze the specified C# file for branches and output the results in the specified format (json or console) to the specified path.");
        Console.WriteLine("  StaticBranchAnalyzer help - Display this help message.");
    }
}