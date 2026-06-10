# Test Plan — C# Branch Analyzer

## Summary

| Field | Detail |
|---|---|
| Project | C# Branch Analyzer |
| Version | 1.0 |
| Test Types | Manual, Automated (Selenium — in progress) |

### Entry Criteria
- `schema` and `seed` equivalent: tool builds successfully with `dotnet build`
- At least one valid `.cs` sample file is available for testing
- All functional requirements (FR-01 to FR-10) are implemented

### Exit Criteria
- All manual test cases have a Pass or documented Fail status
- All critical path test cases (TC-01, TC-06, TC-07, TC-10) are passing
- All failures have a linked bug report or noted limitation

---
## Other Files
[Requirements](requirements.md)
[Test Cases](test-cases.md)
