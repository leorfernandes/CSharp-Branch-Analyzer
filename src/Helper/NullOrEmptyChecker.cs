public class NullChecker
{
    public static bool IsStringNullOrEmpty(string value)
    {
        return string.IsNullOrEmpty(value);
    }

    public static bool IsBranchReportNullOrEmpty(BranchReport? report)
    {
        return report == null || IsStringNullOrEmpty(report.File) || report.Branches == null || !report.Branches.Any();
    }
}