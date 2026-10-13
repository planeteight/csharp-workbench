# Module 1: Variables, types, and input

## Learning objectives

- Distinguish variables, values, and static types.
- Use numeric, string, and Boolean values in expressions.
- Format output with string interpolation.
- Parse user input safely and explain why unchecked conversion can fail.

## Assignment

Extend `Starter.cs` into a small console report about an item of your choice (for example, a book, a meal, or a trip). Store at least three facts using appropriate types, calculate one derived value, and print a labeled summary.

Then ask the user to enter a whole number. Use `int.TryParse` to handle invalid input without terminating the program. On valid input, use the value in a calculation; on invalid input, print a helpful message.

## Requirements

1. Use at least one `int`, one `string`, and one `bool`.
2. Use meaningful variable names and string interpolation for the report.
3. Do not assume user input is valid; demonstrate both the valid and invalid paths.
4. Keep input, calculation, and output steps easy to identify in the code.

## Test and reflect

Try a valid whole number, text that is not a number, and an empty response. Record the observed result for each. In a short note, explain the difference between a variable's type and its current value, and why `TryParse` is appropriate for user input.

**Submit:** the updated source and your test observations.
