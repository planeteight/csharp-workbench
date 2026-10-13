# Module 7: Class libraries and project references

## Learning objectives

- Create a class library that builds independently of a console application.
- Add and use a project reference.
- Use a namespace from a referenced assembly.
- Explain when a dependency belongs in the same project versus a separate project.

## Assignment

The `Gradebook` class library is referenced by the exercise runner. Inspect both project files and run module `07`. Extend the library with a method that returns the highest score, then call it from the starter. Define and test what the method returns when there are no scores.

## Requirements

1. Keep gradebook behavior in the class library and console output in the exercise project.
2. Do not copy the `Gradebook` implementation into the console project.
3. Preserve score validation and decide deliberately whether returned collections can be modified by callers.
4. Build both projects through the exercise project and explain how the project reference makes the library available.

## Test and reflect

Test an empty gradebook, a single score, repeated scores, and the valid score boundaries. Explain why a `using` directive alone would not make a type from an unreferenced project available.

**Submit:** the updated library and caller, test evidence or a reproducible test plan, and a brief dependency explanation.
