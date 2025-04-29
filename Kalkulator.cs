using System;

namespace Lab_1.Kalkulator;

public class Kalkulator
{
	public int firstNumber;
	public int secondNumber;
    public string operation;

    public Kalkulator()
    {
        firstNumber = null;
        secondNumber = null;
        operation = "";
    }

    public void Erase()
    {
        firstNumber = null;
        secondNumber = null;
        operation = "";
    }


}
