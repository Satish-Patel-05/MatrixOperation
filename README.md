# Matrix Operations with Visitor Pattern

## Introduction
This C# Console Application demonstrates the usage of the Visitor design pattern to calculate the determinant and transpose of a 3x3 matrix. The project follows Microsoft coding conventions, and separates classes into different files for better code organization.

### Visitor Pattern
The Visitor design pattern allows you to add new operations to an object structure without modifying the objects themselves. In this project, we use the Visitor pattern to perform matrix operations (determinant and transpose) on a 3x3 matrix without altering the matrix class.

## Summary
The project consists of the following components:

1. `Matrix.cs`: Defines the `Matrix` class, which represents a 3x3 matrix and accepts visitors for determinant and transpose calculations.

2. `IDeterminantVisitor.cs`: Contains the `IDeterminantVisitor` interfaces used for the visitor pattern.

3. `ITransposeVisitor.cs`: Contains the `ITransposeVisitor` interfaces used for the visitor pattern.

4. `DeterminantVisitor.cs`: Implements the `DeterminantVisitor` class, which calculates the determinant of a matrix.

5. `TransposeVisitor.cs`: Implements the `TransposeVisitor` class, which transposes a matrix.

6. `Program.cs`: The main entry point of the application, where the user can input a 3x3 matrix, and the determinant and transposed matrix are calculated and displayed.

## Usage
1. Clone or download the project.

2. Open the project in your preferred C# development environment (e.g., Visual Studio).

3. Build and run the application.

4. Follow the on-screen instructions to input the 3x3 matrix elements.

5. The program will calculate and display the determinant and transposed matrix.

## Example
Suppose you input the following matrix:\
1 2 3\
4 5 6\
7 8 9

The program will output:

Determinant of the matrix: 0\
Transposed matrix:\
1 4 7\
2 5 8\
3 6 9
