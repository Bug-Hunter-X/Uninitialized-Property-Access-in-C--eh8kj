# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value. This can lead to unexpected behavior, especially if the property is used in calculations or conditional logic.

## The Problem

In the `UninitializedProperty.cs` file, the `MyMethod` function attempts to use the `MyProperty` before it has been given a value.  This can result in the property having its default value (0 for integers, null for references, etc.), leading to incorrect calculations or unexpected program flow.

## The Solution

The `UninitializedPropertySolution.cs` file shows the solution. Initialize the property before using it to prevent unpredictable outcomes.

## How to Reproduce

1. Clone this repository.
2. Open the project in your preferred C# IDE (e.g., Visual Studio).
3. Run the `UninitializedProperty.cs` file; observe the result.
4. Then, run `UninitializedPropertySolution.cs` and compare.

This example illustrates the importance of initializing class properties before using them to ensure the correctness and reliability of your C# code.