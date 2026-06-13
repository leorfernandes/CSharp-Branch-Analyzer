using System.Text.Json;

public class OutputWriter
{
    public static void OutputOrganizer(BranchReport report, string outputFormat, string outputPath)
    {
        try
        {
            string json = SerializeReportToJson(report);

            switch (outputFormat.ToLower())
            {
                case "json":
                    WriteToFile(report, json, outputPath);
                    break;
                case "console":
                    WriteToConsole(json);
                    break;
                default:
                    Console.WriteLine("Error: Unsupported output format.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing output: {ex.Message}");
        }
    }

    public static string SerializeReportToJson(BranchReport report)
    {
        return JsonSerializer.Serialize(report, new JsonSerializerOptions { WriteIndented = true });
    }

    public static void WriteToFile(BranchReport report, string content, string outputPath)
    {
        var fullPath = CheckOutputFormatExistance(report, outputPath);
        CheckOutputPathExistance(Path.GetDirectoryName(fullPath));

        File.WriteAllText(fullPath, content);
    }

    public static void WriteToConsole(string content)
    {
        Console.WriteLine(content);
    }

    public static string CheckOutputFormatExistance(BranchReport report, string outputPath)
    {
        switch (Path.GetExtension(outputPath).ToLower())
        {
            case ".json":
                return $"{outputPath}";  
            default:
                return $"{outputPath}/{report.File}.json";
        };
    }

    public static void CheckOutputPathExistance(string outputPath)
    {
        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }
    }
}