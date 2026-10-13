# Module 3: Methods and decomposition

## Learning objectives

- Define methods with meaningful parameter and return types.
- Distinguish a method's inputs, work, and result.
- Use local variables without depending on unrelated global state.
- Design small methods that can be reasoned about and tested independently.

## Assignment

Build a small unit-conversion utility around the starter's `Add` method. Implement methods to convert Celsius to Fahrenheit, calculate the average of two numbers, and determine whether an integer is within an inclusive range.

Call each method from `Run` and print labeled results. Keep calculations in methods and presentation in `Run`.

## Requirements

1. Each calculation method must return a value and accept its inputs as parameters.
2. Use descriptive method and parameter names.
3. State the formula used for Celsius-to-Fahrenheit conversion in your explanation.
4. Ensure the range check treats both endpoints as inside the range.
5. Do not copy the formula or comparison logic into the output statements.

## Test and reflect

Check temperature values at and below zero, a known conversion such as 0°C, both endpoints of the range, and a value just outside each endpoint. Explain which method is easiest to test and why.

**Submit:** the updated source, expected and actual results, and your explanation of the conversion formula.
