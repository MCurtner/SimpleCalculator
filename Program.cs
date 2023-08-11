﻿using SimpleCalculator;

try
{
    InputConverter inputConverter = new InputConverter();
    CalculatorEngine calculatorEngine = new CalculatorEngine();

    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
    string operation = Console.ReadLine();

    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

    Console.WriteLine(result);
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

