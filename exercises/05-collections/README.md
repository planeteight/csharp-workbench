# Module 5: Collections and LINQ

## Learning objectives

- Choose an appropriate collection for a group of related values.
- Traverse and query a collection.
- Use LINQ to express filtering and projection.
- Recognize that a query is a transformation of data, not a replacement for understanding the underlying algorithm.

## Assignment

Extend the starter's list of numbers into a summary program. Keep the input values in a `List<int>`, then report the even values, count of values, minimum, maximum, and average. Add a dictionary that maps a category name to a list of values, or explain why a dictionary is not appropriate for this particular data.

## Requirements

1. Use `List<int>` for the sequence and LINQ for at least one filtering or aggregation operation.
2. Do not assume the list is non-empty when computing minimum, maximum, or average.
3. Label each result clearly and avoid modifying the original list just to produce a query result.
4. Explain the difference between a list, which preserves an ordered sequence, and a dictionary, which associates keys with values.

## Test and reflect

Test a list containing no values, one value, repeated values, and a mix of positive and negative values. State which outputs are defined for an empty list and how your program communicates unavailable statistics.

**Submit:** the updated source, results for each test case, and your collection choice explanation.
