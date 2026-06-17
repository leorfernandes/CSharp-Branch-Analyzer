# Manual Test Report - 2026 06 16

## Information
**Project Version:** V1.0

**Date:** 2026/06/16

**Tester Name:** Leonardo dos Reis Fernandes

**Environment Details:**
- OS: Windows 11 (10.0.26200)
- .NET SDK: 10.0.301
- .NET Runtime: 10.0.9
- Architecture: x64

## Summary
|Total Test Cases|Passed| Failed| Blocked|
|---|---|---|---|
|12|11|1|0|

## Results Table
|TC ID|Title|Status|Actual Result|Evidence|
|---|---|---|---|---|
|TC-01|Valid file path accepted|Passed|Tool ran without error and produced a console output|[Evidence](./screenshots/TC-01.png)|
|TC-02|Missing file path argument|Passed|Tool ran into and error and printed the missing file path in the console|[Evidence](./screenshots/TC-02.png)|
|TC-03|Parse valid C# file|Passed|Tool successfully parsed the file and produced a JSON output|[Evidence](./screenshots/TC-03.png)|
|TC-04|Parse malformed C# file|Failed|The tool parsed the file successfully and didn't show any errors|[Evidence](./screenshots/TC-04.png)|
|TC-05|Detect if/else branches|Passed|The tool successfully identified all the if/else branches|[Evidence](./screenshots/TC-05.png)|
|TC-06|Detect switch branches|Passed|The tool successfully identified all the switch branches|[Evidence](./screenshots/TC-06.png)|
|TC-07|Detect ternary branches|Passed|The tool successfully identified all the ternary branches|[Evidence](./screenshots/TC-07.png)|
|TC-08|Print JSON report to terminal|Passed|The tool successfully printed the JSON report in the terminal|[Evidence](./screenshots/TC-08.png)|
|TC-09|Export JSON report to file|Passed|The tool successfully created the path and the JSON file in the desired path|[Evidence](./screenshots/TC-09.png)|
|TC-10|Display help message|Passed|The tool displayed the help message and guidance on how to use the correct syntax |[Evidence](./screenshots/TC-10.png)|
|TC-11|Non-existent file path|Passed|The tool showed an error message without crashing|[Evidence](./screenshots/TC-11.png)|
|TC-12|Non C# file provided|Passed|The tool showed indicated wrong file extension message without crashing|[Evidence](./screenshots/TC-12.png)|

## OBSERVATIONS
- TC-04 — The tool did not crash on malformed input, satisfying the stability requirement. However, it produced output rather than a parse error message. This behaviour is acceptable given the tool's scope is branch mapping rather than syntax validation. A future enhancement could add explicit syntax diagnostics via the Roslyn diagnostic API.

