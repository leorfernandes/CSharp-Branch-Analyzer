# C# Branch Analyzer

## What it does
A CLI tool that parses C# source files using Roslyn, analyzes branch logic (if/else, switch, ternary), and outputs a structured JSON report mapping every branch path found in the codebase.

## Why it exists
Manually tracking branch complexity across a codebase is time-consuming and error-prone. This tool automates that process and produces a machine-readable JSON report that can be used to guide test coverage, integrate into CI pipelines, or feed into other development tooling.

## User Cases
- As a developer, I want to analyze a C# file for branch complexity so that I can identify areas that need more test coverage.
- As a QA engineer, I want a structured JSON report of all branch paths so that I can derive test cases systematically without reading through source code manually.
- As a developer, I want to integrate the analyzer into my workflow so that I can catch untested branch paths early in the development cycle.

## Features
- Parse C# source files using the Roslyn compiler API
- Detect if/else, switch, and ternary branch structures
- Output a structured JSON report with branch details per file
- Print to terminal or export to file
- Handle errors for invalid or unparseable input files

## Commands
```
dotnet run -- analyze input.cs
dotnet run -- analyze input.cs output/
dotnet run -- help
```

## Example Screenshot
'''

## Testing
Automated tests are written using NUnit, covering core analysis commands and JSON output validation.

See [docs/test-cases.md](./docs/test-cases.md) for the full test case suite.

## Limitations / Out of scope
- No runtime analysis — static analysis only
- No cross-file dependency tracking
- No support for VB.NET or other .NET languages
- No GUI or web interface
- No visualization of branch trees