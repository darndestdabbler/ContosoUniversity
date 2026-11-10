# Project work plan — sessions

**Written by `dabbler` as a fold of `activity-log.json`.**
Hand edits are overwritten by the next append. The record is the log;
this page is one view of it.

---

## Sessions

The numbered sessions are declared from `session-plan.md`; each one's task is what its own plan step declared.

| # | Session | Releasable | Declared |
| ---: | --- | --- | --- |
| 1 | Author or import the change plan | no | 2026-11-10 |
| 2 | Break the change plan into numbered sessions | no | 2026-11-10 |
| 3 | The calculator page | no | 2026-11-10 |
| 4 | Documentation comments on the calculator | — | not declared |

### Session 1 — Author or import the change plan

**Releasable: no.**

Session 1 writes docs/planning/solution-plan.md from the brief in docs/planning/brief.md and nothing else: one paragraph on ContosoUniversity as found -- an ASP.NET MVC 5 application on .NET Framework 4.8.1 in non-SDK project files with packages.config under src\, the solution at src\ContosoUniversity.sln, feature folders under src\ContosoUniversity\Features, a DBDeployment project for RoundhousE, and Fixie 1 integration tests in src\IntegrationTests run by the Fixie console that dabbler.yaml's dotnet-framework suite already declares -- and one section per change: the calculator page (a Features\Calculator folder with a controller, a view and the arithmetic, reached by the default route and linked from the layout, tested in IntegrationTests and listed in both .csproj files), and the documentation comments on what that change added, with nothing else changed. It says each change is shown to work by the compile control's MSBuild build and the Fixie suite, and that the existing failing CreateTests.Should_create is out of scope.

### Session 2 — Break the change plan into numbered sessions

**Releasable: no.**

Session 2 appends two numbered sessions to docs/sessions/session-plan.md from docs/planning/solution-plan.md and writes nothing else: Session 3, the calculator page -- the Calculator arithmetic, its UiController and Index view in a new Features\Calculator folder listed in ContosoUniversity.csproj, the layout's navigation link, and CalculatorTests in IntegrationTests listed in IntegrationTests.csproj, shown by the compile control's MSBuild build and the Fixie console -- and Session 4, XML documentation comments on what session 3 added and a Razor comment atop its view, with no code, markup or project file changed. Each has a Register step and three or four work steps, and no release session is planned, because the brief names none.

### Session 3 — The calculator page

**Releasable: no.**

Session 3 adds an online calculator page to ContosoUniversity inside its existing shape: src/ContosoUniversity/Features/Calculator/Calculator.cs (a static Calculator with Add and Subtract over decimals), src/ContosoUniversity/Features/Calculator/UiController.cs (a GET Index showing the form and a POST Index showing the sum and difference, found by the existing ControllerFactory as ContosoUniversity.Features.Calculator.UiController) and src/ContosoUniversity/Features/Calculator/Index.cshtml (found by the existing feature view engine), each listed in ContosoUniversity.csproj as a Compile or Content item; a Calculator link in the navigation of src/ContosoUniversity/Features/Shared/_Layout.cshtml; and src/IntegrationTests/Features/Calculator/CalculatorTests.cs, one test of Add and one of Subtract, listed in IntegrationTests.csproj and run by the existing Fixie console. It is shown by the compile control's MSBuild build of src/ContosoUniversity.sln and by the Fixie run passing CalculatorTests.
