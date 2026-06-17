public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var input = ServiceDirector.CheckArguments(args);
            if (input == null)
            {
                return; // Exit if arguments are invalid or help was displayed
            }
            Console.WriteLine($"Arguments received: {string.Join(", ", input)}");

            var fileContent = FileParser.ParseFile(input[0]);
            if (fileContent == null)
            {
                Console.WriteLine("Error: Could not read file content.");
                return;
            }
            var branchReport = BranchReporter.BranchReport(fileContent);
            if (NullChecker.IsBranchReportNullOrEmpty(branchReport))
            {
                Console.WriteLine("No branches found or report is invalid.");
                return; // Exit if branch report is null or empty
            }
            OutputWriter.OutputOrganizer(branchReport, input[1], input[2]);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}