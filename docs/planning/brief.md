# Brief

Two changes to ContosoUniversity, each its own session, inside the
repository's existing shape: the ASP.NET MVC 5 application on .NET
Framework 4.8.1, its feature folders under src\ContosoUniversity\Features,
its non-SDK project files and `packages.config`, and its Fixie 1 tests in
src\IntegrationTests.

1. **An online calculator page.** A page that takes two numbers and shows
   their sum and their difference (add and subtract). It is a new feature
   folder in the existing style -- a controller, a view, reached by the
   existing default route -- linked from the site's navigation, with tests
   for the arithmetic in the existing test project, run by its existing
   Fixie console. Every new file is listed in its project's `.csproj`.
2. **Documentation comments.** XML documentation comments on the types
   and public members the calculator change added, and a comment at the
   top of its view. Nothing else changes: no code, no markup, no project
   file.

Out of scope: retargeting, reformatting or upgrading any project or
package; the repository's existing failing test (`CreateTests.Should_create`,
a database-state failure that predates this work); a release.
