using System;

namespace Lab_1;

public class Kalkulator
{
	public double? firstNumber { set; get; }
	public double? secondNumber { set; get; }
    public string? operation {  set; get; }

    public Kalkulator()
    {
        firstNumber = null;
        secondNumber = null;
        operation = null;
    }

    public void Erase()
    {
        firstNumber = null;
        secondNumber = null;
        operation = null;
    }

    public string Calculate()
    {
        switch (operation)
        {
            case "+":
                if (secondNumber == null)
                {

                }
                firstNumber += secondNumber;
                secondNumber = null;
                operation = null;
                break;
            case "-":
                firstNumber -= secondNumber;
                secondNumber = null;
                operation = null;
                break;
            case "x":
                firstNumber *= secondNumber;
                secondNumber = null;
                operation = null;
                break;
            case "/":
                firstNumber /= secondNumber;
                secondNumber = null;
                operation = null;
                break;
        }
        return firstNumber.ToString();
    }

    public string SpecjalCalculate(string op)
    {
        if (secondNumber == null)
        {
            switch (op)
            {
                case "sqrt":
                    firstNumber = (double)Math.Sqrt((double)firstNumber);
                    break;
                case "1/x":
                    firstNumber = 1 / firstNumber;
                    break;
                case "x^2":
                    firstNumber = firstNumber * firstNumber;
                    break;
                case "%":
                    firstNumber = firstNumber / 100;
                    break;
            }
            return (string)firstNumber.ToString();
        }
        else
        {
            switch (op)
            {
                case "sqrt":
                    secondNumber = (double)Math.Sqrt((double)secondNumber);
                    break;
                case "1/x":
                    secondNumber = 1 / secondNumber;
                    break;
                case "x^2":
                    secondNumber = secondNumber * secondNumber;
                    break;
                case "%":
                    secondNumber = secondNumber / 100;
                    break;
            }
            return (string)secondNumber.ToString();
        }
    }
}
