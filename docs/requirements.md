# Requirements — C# Branch Analyzer

## Functional Requirements

| ID | Requirement |
|---|---|
| FR-01 | The tool shall accept a C# source file path as a CLI argument |
| FR-02 | The tool shall parse the provided C# file using the Roslyn compiler API |
| FR-03 | The tool shall detect and report `if/else` branch structures |
| FR-04 | The tool shall detect and report `switch` branch structures |
| FR-05 | The tool shall detect and report ternary (`? :`) branch structures |
| FR-06 | The tool shall output a structured JSON report containing all detected branches |
| FR-07 | The tool shall print the JSON report to the terminal by default |
| FR-08 | The tool shall export the JSON report to a specified output path when provided |
| FR-09 | The tool shall display a help message listing all available commands and usage |
| FR-10 | The tool shall handle invalid or unparseable input files gracefully with a clear error message |

---

## Non-Functional Requirements

| ID | Requirement |
|---|---|
| NFR-01 | Error messages shall be human-readable and indicate the cause of failure clearly |
| NFR-02 | The JSON output structure shall be consistent across all runs and file inputs |
| NFR-03 | The tool shall complete analysis of a single file under 5 seconds on standard hardware |
| NFR-04 | The tool shall follow the existing command-registry pattern used across the CLI portfolio |
| NFR-05 | The codebase shall be documented with XML comments on public methods |

---

## Acceptance Criteria

| ID | Requirement | Acceptance Criteria |
|---|---|---|
| FR-01 | Accept a C# file path as CLI argument | Tool runs without error when a valid file path is provided; exits with a clear message when no argument is given |
| FR-02 | Parse C# file using Roslyn | Tool successfully parses a valid C# file and produces output; returns a parse error message for malformed files |
| FR-03 | Detect if/else branches | All if/else blocks in the input file appear in the JSON report with correct line numbers |
| FR-04 | Detect switch branches | All switch statements in the input file appear in the JSON report with each case listed |
| FR-05 | Detect ternary branches | All ternary expressions in the input file appear in the JSON report with correct line numbers |
| FR-06 | Output structured JSON report | Output is valid JSON; contains file name, branch type, and line number for each detected branch |
| FR-07 | Print to terminal by default | Running the analyze command without an output path prints the JSON report to the terminal |
| FR-08 | Export to file when path provided | Running the analyze command with an output path creates a JSON file at the specified location |
| FR-09 | Display help message | Running the help command prints all available commands with usage examples |
| FR-10 | Handle invalid input gracefully | Providing a non-existent or non-C# file returns a descriptive error message without crashing |

---
## Other Files
[Test Plan](test-plan.md)
[Test Cases](test-cases.md)