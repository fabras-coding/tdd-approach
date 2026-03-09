# tdd-approach

A small .NET TDD practice project with two classic kata-style exercises:

- `FizzBuzz`
- `StringCalculator`

The test suite is written with xUnit and drives the implementation through incremental behavior changes.

## Project Structure

- `FizzBuzz.cs`: FizzBuzz implementation
- `FizzBuzzTests.cs`: FizzBuzz TDD tests
- `StringCalculator.cs`: String Calculator implementation
- `StringCalculatorTests.cs`: String Calculator TDD tests
- `tdd-approach.csproj`: Project file
- `tdd-approach.sln`: Solution file

## TDD Scenarios Covered

### FizzBuzz Tests

The tests verify:

- Returns the input number as a string when it is not divisible by 3 or 5
- Returns `Fizz` when divisible by 3
- Returns `Buzz` when divisible by 5
- Returns `FizzBuzz` when divisible by both 3 and 5

### String Calculator Tests

The tests currently cover:

- Empty string returns `0`
- Single number returns itself
- Comma-separated numbers are summed
- Multiple numbers are summed
- Supports line breaks (`\n`) as separators
- Supports semicolon delimiters
- Supports custom delimiter syntax (for example `//;\n5;5`)
- Throws an exception when negatives are provided
- Includes all negative values in the exception message
- Throws an exception for invalid/letter-containing numeric input

## Run the Tests

From the workspace root:

```bash
dotnet test
```

To build:

```bash
dotnet build
```

## TDD Workflow (Suggested)

1. Write a failing test (`Red`)
2. Implement the minimum code to pass (`Green`)
3. Refactor while keeping tests green (`Refactor`)

This repository is structured to support that Red-Green-Refactor loop.
