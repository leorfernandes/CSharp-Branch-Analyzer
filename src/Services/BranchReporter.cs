using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

public static class BranchReporter
{
    public static BranchReport? BranchReport(string fileContent)
    {
        try {
            var branchReport = new BranchReport
            {
                File = $"BranchReport{DateTime.Now:yyyyMMddHHmmss}.cs",
                Branches = new List<BranchEntry>()
            };

            var tree = GetTree(fileContent);
            var root = GetRootNode(tree);

            branchReport.Branches = GetBranchEntries(root);
            return branchReport;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generating branch report: {ex.Message}");
            return null; // Return null to indicate failure
        }
    }

    public static SyntaxTree GetTree(string fileContent)
    {
            var tree = CSharpSyntaxTree.ParseText(fileContent);
            return tree;

    }

    public static SyntaxNode GetRootNode(SyntaxTree tree)
    {
            var root = tree.GetRoot();
            return root;
    }

    public static List<BranchEntry> GetBranchEntries(SyntaxNode root)
    {
            var BranchEntries = new List<BranchEntry>();

            var ifStatements = GetIfStatements(root);
            var switchStatements = GetSwitchStatements(root);
            var ternaryStatements = GetTernaryStatements(root);

            BranchEntries.AddRange(ifStatements.SelectMany(ProcessBranch));
            BranchEntries.AddRange(switchStatements.SelectMany(ProcessBranch));
            BranchEntries.AddRange(ternaryStatements.SelectMany(ProcessBranch));
            return BranchEntries;
    }

    public static IEnumerable<IfStatementSyntax> GetIfStatements(SyntaxNode root)
    {
            var ifStatements = root.DescendantNodes().OfType<IfStatementSyntax>();
            return ifStatements;

    }

    public static IEnumerable<SwitchStatementSyntax> GetSwitchStatements(SyntaxNode root)
    {
            var switchStatements = root.DescendantNodes().OfType<SwitchStatementSyntax>();
            return switchStatements;
    }

    public static IEnumerable<ConditionalExpressionSyntax> GetTernaryStatements(SyntaxNode root)
    {
            var ternaryStatements = root.DescendantNodes().OfType<ConditionalExpressionSyntax>();
            return ternaryStatements;
        
    }

    public static List<BranchEntry> ProcessBranch(SyntaxNode branchNode)
    {
            var BranchEntries = new List<BranchEntry>();

            foreach (var descendant in branchNode.DescendantNodesAndSelf())
            {
                if (descendant is IfStatementSyntax ifNode)
                {
                    var branch = new BranchEntry
                    {
                        Type = "if",
                        LineNumber = ifNode.GetLocation().GetLineSpan().StartLinePosition.Line + 1,
                        Description = ifNode.Condition.ToString()
                    };
                    BranchEntries.Add(branch);
                }
                else if (descendant is SwitchStatementSyntax switchNode)
                {
                    var branch = new BranchEntry
                    {
                        Type = "switch",
                        LineNumber = switchNode.GetLocation().GetLineSpan().StartLinePosition.Line + 1,
                        Description = switchNode.Expression.ToString()
                    };
                    BranchEntries.Add(branch);
                }
                else if (descendant is ConditionalExpressionSyntax ternaryNode)
                {
                    var branch = new BranchEntry
                    {
                        Type = "ternary",
                        LineNumber = ternaryNode.GetLocation().GetLineSpan().StartLinePosition.Line + 1,
                        Description = ternaryNode.Condition.ToString()
                    };
                    BranchEntries.Add(branch);
                }
            }
            return BranchEntries;
        }
}