# Calculator Application and Unit Testing

## Overview

This project is a simple calculator implemented in C# that provides basic arithmetic operations and utility functions. The project also includes unit tests to ensure the calculator's functionality is reliable and performs as expected.

---

## Calculator Implementation

The calculator logic is implemented in the `calculatorImp` class, which resides in the `calculatorApp` namespace. It provides the following methods:

### Methods:
- **`int Somar(int num1, int num2)`**  
  Adds two integers and returns the result.

- **`int Subtrair(int num1, int num2)`**  
  Subtracts the second integer from the first and returns the result.

- **`int Multiplicar(int num1, int num2)`**  
  Multiplies two integers and returns the result.

- **`int Dividir(int num1, int num2)`**  
  Divides the first integer by the second and returns the result.  
  *(Note: No handling for division by zero in this implementation.)*

- **`bool EhPar(int num1)`**  
  Returns `true` if the provided integer is even; otherwise, returns `false`.

---

## Unit Testing

The tests are implemented using the [xUnit](https://xunit.net/) framework. They ensure that each calculator method behaves as expected. The tests are defined in the `calculatorTests` class within the `calculatorTests` namespace.

### Test Examples:

1. **Single Value Test (Fact)**  
   This test checks if the `Somar` method correctly sums two integers:
   ```csharp
   [Fact]
   public void DeveSomar5Com10ERetornar15()
   {
       int num1 = 5;
       int num2 = 10;
       int resultado = _calc.Somar(num1, num2);
       Assert.Equal(15, resultado);
   }
