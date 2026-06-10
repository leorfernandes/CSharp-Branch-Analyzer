# Test Cases — C# Branch Analyzer

## Manual Test Cases

---

### TC-01 — Valid file path accepted
**Linked requirement:** FR-01

**Given** the tool is built and a valid `.cs` file exists  
**When** the user runs `dotnet run -- analyze input.cs`  
**Then** the tool runs without error and produces output

**Expected Result:** JSON report is displayed in the terminal  
**Status:** Not Run

---

### TC-02 — Missing file path argument
**Linked requirement:** FR-01, FR-10

**Given** the tool is built  
**When** the user runs `dotnet run -- analyze` with no file path  
**Then** the tool exits gracefully with a descriptive error message

**Expected Result:** Error message indicates a file path is required  
**Status:** Not Run

---

### TC-03 — Parse valid C# file
**Linked requirement:** FR-02

**Given** a valid, well-formed `.cs` file exists  
**When** the user runs `dotnet run -- analyze input.cs`  
**Then** the tool parses the file successfully and produces a JSON report

**Expected Result:** JSON report contains at least one entry from the file  
**Status:** Not Run

---

### TC-04 — Parse malformed C# file
**Linked requirement:** FR-02, FR-10

**Given** a `.cs` file with invalid syntax exists  
**When** the user runs `dotnet run -- analyze malformed.cs`  
**Then** the tool returns a parse error message without crashing

**Expected Result:** Human-readable error message describing the parse failure  
**Status:** Not Run

---

### TC-05 — Detect if/else branches
**Linked requirement:** FR-03

**Given** a `.cs` file containing if/else blocks exists  
**When** the user runs `dotnet run -- analyze input.cs`  
**Then** all if/else branches appear in the JSON report with correct line numbers

**Expected Result:** JSON report lists each if/else branch with type and line number  
**Status:** Not Run

---

### TC-06 — Detect switch branches
**Linked requirement:** FR-04

**Given** a `.cs` file containing switch statements exists  
**When** the user runs `dotnet run -- analyze input.cs`  
**Then** all switch statements appear in the JSON report with each case listed

**Expected Result:** JSON report lists each switch statement and its cases  
**Status:** Not Run

---

### TC-07 — Detect ternary branches
**Linked requirement:** FR-05

**Given** a `.cs` file containing ternary expressions exists  
**When** the user runs `dotnet run -- analyze input.cs`  
**Then** all ternary expressions appear in the JSON report with correct line numbers

**Expected Result:** JSON report lists each ternary expression with type and line number  
**Status:** Not Run

---

### TC-08 — Print JSON report to terminal
**Linked requirement:** FR-06, FR-07

**Given** a valid `.cs` file exists  
**When** the user runs `dotnet run -- analyze input.cs` without an output path  
**Then** the JSON report is printed to the terminal

**Expected Result:** Valid JSON is printed to the terminal; output is consistently structured  
**Status:** Not Run

---

### TC-09 — Export JSON report to file
**Linked requirement:** FR-08

**Given** a valid `.cs` file exists and an output path is provided  
**When** the user runs `dotnet run -- analyze input.cs output/`  
**Then** a JSON file is created at the specified output path

**Expected Result:** JSON file exists at the output path and contains the branch report  
**Status:** Not Run

---

### TC-10 — Display help message
**Linked requirement:** FR-09

**Given** the tool is built  
**When** the user runs `dotnet run -- help`  
**Then** the tool prints all available commands with usage examples

**Expected Result:** Help message lists analyze and help commands with correct usage syntax  
**Status:** Not Run

---

### TC-11 — Non-existent file path
**Linked requirement:** FR-10

**Given** the tool is built  
**When** the user runs `dotnet run -- analyze nonexistent.cs`  
**Then** the tool returns a descriptive error message without crashing

**Expected Result:** Error message indicates the file was not found  
**Status:** Not Run

---

### TC-12 — Non C# file provided
**Linked requirement:** FR-10

**Given** the tool is built and a non-C# file exists (e.g. `input.json`)  
**When** the user runs `dotnet run -- analyze input.json`  
**Then** the tool returns a descriptive error message without crashing

**Expected Result:** Error message indicates the file type is not supported  
**Status:** Not Run

---

## Automated Test Cases (NUnit — Placeholder)

> Automated tests will mirror the manual test cases above, translating each Given/When/Then into NUnit assertions. This section will be populated as the tool is built.

| TC ID | Title | Status |
|---|---|---|
| TC-01 | Valid file path accepted | Pending |
| TC-02 | Missing file path argument | Pending |
| TC-03 | Parse valid C# file | Pending |
| TC-04 | Parse malformed C# file | Pending |
| TC-05 | Detect if/else branches | Pending |
| TC-06 | Detect switch branches | Pending |
| TC-07 | Detect ternary branches | Pending |
| TC-08 | Print JSON report to terminal | Pending |
| TC-09 | Export JSON report to file | Pending |
| TC-10 | Display help message | Pending |
| TC-11 | Non-existent file path | Pending |
| TC-12 | Non C# file provided | Pending |

---
## Other Files
[Test Plan](test-plan.md)
[Requirements](requirements.md)
