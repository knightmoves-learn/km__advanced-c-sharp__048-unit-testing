# 048 Unit Testing
## Lecture

[![# Unit Testing (Part 2)](https://img.youtube.com/vi/aRCXJ38q06o/0.jpg)](https://www.youtube.com/watch?v=LEhGPRaf7Xk)
[![# Unit Testing (Part 1)](https://img.youtube.com/vi/aRCXJ38q06o/0.jpg)](https://www.youtube.com/watch?v=LEhGPRaf7Xk)

## Instructions

In this lesson you will be testing the method contained in `HomeEnergyApi/Services/MathService.cs`. You will need to change the file at `HomeEnergyApi.Tests/Lesson48Tests/Math.Tests.cs`. You should NOT change any test files inside of the `HomeEnergyApi.Tests/GradingTests`, these are used to grade your assignment.

- In `HomeEnergyApi.Tests/Lesson48Tests/Math.Tests.cs`
    - Create a new method `ShouldReturnCorrectRomanNumeralFor1()` with the `[Fact]` test attribute
        - Should create a new `MathService`
        - Should create a variable `result` storing the value of calling `ConvertToRomanNumeral()` on the `MathService` with the argument `1`
        - Should assert the value of `result` is `"I"` using `Assert.Equal("I", result)`
    - Create a new method `ShouldReturnCorrectRomanNumeralFor483()` with the `[Fact]` test attribute
        - Should create a new `MathService`
        - Should create a variable `result` storing the value of calling `ConvertToRomanNumeral()` on the `MathService` with the argument `483`
        - Should assert the value of `result` is `"CDLXXXIII"` using `Assert.Equal("CDLXXXIII", result)`
    - Create a new method `ShouldReturnCorrectRomanNumeralFor1()` with the `[Fact]` test attribute
        - Should create a new `MathService`
        - Should create a variable `result` storing the value of calling `ConvertToRomanNumeral()` on the `MathService` with the argument `-1`
        - Should assert the value of `result` is `""` using `Assert.Equal("", result)`

## Additional Information

- Some files may have changed for this lesson from the last, as always all code in the lesson repository is available to view
- Along with `using` statements being added, any packages needed for the assignment have been pre-installed for you, however in the future you may need to add these yourself

## Building toward CSTA Standards:

## Resources
- https://en.wikipedia.org/wiki/Unit_testing
- https://martinfowler.com/bliki/TestPyramid.html
- https://xunit.net/

Copyright &copy; 2025 Knight Moves. All Rights Reserved.
