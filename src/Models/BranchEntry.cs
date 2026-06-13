public class BranchEntry
{
    public string Type { get; set; }  // "if", "switch", "ternary"
    public int LineNumber { get; set; }
    public string Description { get; set; }
}