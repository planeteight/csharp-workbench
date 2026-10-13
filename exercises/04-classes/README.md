# Module 4: Classes and encapsulation

## Learning objectives

- Explain the relationship between a class and an object.
- Initialize object state with a constructor.
- Choose between fields and properties for public access.
- Preserve simple rules about an object's state.

## Assignment

Extend the `Person` model with a meaningful behavior, such as calculating the year of birth from a supplied current year. Add input validation so a `Person` cannot be created with a blank name or a negative age. Keep the existing `ToString` output useful and update `Run` to demonstrate a valid person.

## Requirements

1. Keep the person's name non-null and non-blank.
2. Reject a negative age with an argument-related exception.
3. Use properties to expose state; do not make internal representation public fields.
4. Give the new behavior explicit inputs where assumptions such as the current year matter.
5. In your explanation, identify the class invariant and how the implementation protects it.

## Test and reflect

Demonstrate a valid instance and reason about blank names, negative age, and the youngest valid age. Explain why a constructor is a suitable place to establish the object's initial valid state.

**Submit:** the updated source, test evidence or a reproducible test plan, and the invariant explanation.
