public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var input = ServiceDirector.CheckArguments(args);
            Console.WriteLine($"Arguments received: {string.Join(", ", input)}");
            if (input == null)
            {
                return; // Exit if arguments are invalid or help was displayed
            }

            var fileContent = FileParser.ParseFile(input[0]);
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