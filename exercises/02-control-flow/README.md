# Module 2: Control flow and algorithm tracing

## Learning objectives

- Express conditions with relational and Boolean operators.
- Select between alternatives and repeat work with loops.
- Trace state changes through an algorithm.
- Check boundary cases rather than testing only typical values.

## Assignment

Turn the starter into a number classifier. For an integer `x`, report whether it is positive, negative, or zero, and whether it is even or odd. Then print the integers from 1 through `x` when `x` is positive; do not print a counting sequence for zero or a negative input.

## Requirements

1. Use an `if`/`else if`/`else` chain for the sign classification.
2. Use the remainder operator to classify even and odd values.
3. Use a loop with an explicit, correct stopping condition.
4. Avoid repeating the same classification logic in multiple places.
5. Include a brief trace showing the loop variable at the start and end of one iteration.

## Test and reflect

Test a negative integer, zero, one, and a positive even and odd integer. Explain how your loop behaves at its boundary and identify a test that would reveal an off-by-one error.

**Submit:** the updated source, test cases with expected and actual results, and the loop trace.
