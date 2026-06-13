public static class FileParser
{
    public static string ParseFile(string filePath)
    {
        try
        {
            var path = filePath;
            if (!CheckFilePath(path))
            {
                return null; // Exit if file path is invalid
            }
            var fileContent = File.ReadAllText(path);
            return fileContent;    
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error parsing file: {ex.Message}");
            return null; // Return null to indicate failure
        }
    }

    private static bool CheckFilePath(string filePath)
    {
        if (!CheckExistence(filePath))
        {
            return false; // Exit if file does not exist
        }
        if (!CheckExtension(filePath))
        {
            return false; // Exit if file extension is invalid
        }
        if (!CheckReadability(filePath))
        {
            return false; // Exit if file is not readable
        }
        return true;
    }
    private static bool CheckExistence(string filePath)
    {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File not found: {filePath}");
            }
            return true;
    }

    private static bool CheckExtension(string filePath)
    {
            if (Path.GetExtension(filePath).ToLower() != ".cs")
            {
                throw new InvalidDataException($"Invalid file type: {filePath}. Only .cs files are supported.");
            }
            return true;
    }

    private static bool CheckReadability(string filePath)
    {
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // If we can open the file for reading, it's readable
            }
            return true;
    }

}