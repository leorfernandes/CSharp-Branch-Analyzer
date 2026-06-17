public class BranchEntry
{
    public required string Type { get; set; }  // "if", "switch", "ternary"
    public required int LineNumber { get; set; }
    public string? Description { get; set; }
}