# Solution plan

## The repository as found

ContosoUniversity is an ASP.NET MVC 5 application on .NET Framework 4.8.1,
in non-SDK project files that restore from `packages.config`. The solution
is src\ContosoUniversity.sln with three projects: ContosoUniversity (the web
application, organised as feature folders under Features\, one `UiController`
and its views per feature, found by the existing feature view engine and
reached by the default `{controller}/{action}/{id}` route), DBDeployment
(RoundhousE scripts), and IntegrationTests (Fixie 1.0.1 tests, any class
whose name ends in `Tests`). It builds with MSBuild, which the compile
control in `dabbler.yaml` runs, and its tests run under the Fixie console,
which the `dotnet-framework` suite there runs whole. All of this is kept as
it is: no target, format, package or folder changes.

## Change 1: an online calculator page

**What changes.** A new feature folder, Features\Calculator, in the
ContosoUniversity project: `Calculator.cs` holding the arithmetic (add and
subtract two decimals), `UiController.cs` with an `Index` action that shows
the form and accepts the two numbers, and `Index.cshtml` showing the sum and
the difference. The layout's navigation gains a Calculator link. The three
files are listed in ContosoUniversity.csproj (`Compile` for the two `.cs`
files, `Content` for the view). IntegrationTests gains
Features\Calculator\CalculatorTests.cs, listed in IntegrationTests.csproj,
testing add and subtract.

**How it is shown to work.** The compile control's MSBuild build of the
solution, and the new `CalculatorTests` passing under the Fixie console.

## Change 2: documentation comments

**What changes.** XML documentation comments on the types and public
members change 1 added (`Calculator`, its methods, the calculator
`UiController` and its actions), and a Razor comment at the top of
`Index.cshtml` saying what the page is. No code, markup or project file
changes.

**How it is shown to work.** The same MSBuild build and the Fixie suite,
with `CalculatorTests` still passing, and a diff that contains only comment
lines.

## Out of scope

The existing failing test `CreateTests.Should_create`, which fails on a
database-state problem that predates this work; any retargeting or upgrade;
a release.
