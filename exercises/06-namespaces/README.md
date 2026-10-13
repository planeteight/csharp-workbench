# Module 6: Namespaces and using directives

## Learning objectives

- Declare and recognize namespaces.
- Use a `using` directive to refer to types by their short names.
- Explain the difference between a source file, namespace, assembly, and project.
- Recognize that C# `using` directives do not install dependencies.

## Assignment

The starter calls `ReportFormatter`, a type declared in a separate file and namespace within the same project. Extend the formatter with a method that formats a student's name and score, then call it from `Starter.Run`.

## Requirements

1. Keep formatting logic in the formatter type, not in `Starter.Run`.
2. Use a descriptive method name and parameters.
3. Add the appropriate `using` directive, or fully qualify the formatter type and compare the readability.
4. Explain why adding another `.cs` file to the same project does not require a project reference.

## Test and reflect

Try a normal student name, a name containing spaces, and scores at the minimum and maximum allowed by your method's documented assumptions. Explain what a namespace does and what it does not do.

**Submit:** the updated source, test cases, and the explanation of namespaces versus projects.
