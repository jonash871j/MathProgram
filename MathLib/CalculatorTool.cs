using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    internal enum Operator : ushort
    {
        Asign = '\0',
        Plus = '+',
        Minus = '-',
        Times = '*',
        Divide = '/',
        Pow = '^',
    }

    internal class CalculatorNumber
    {
        internal double Value { get; set; } = 0.0;
        internal Operator Operator { get; set; } = Operator.Asign;
    }

    public class CalculatorTool
    {
        private string calculation = "";
        private Exception exceptionCalculationError = new Exception("Udregnings fejl"); 
        private Exception exceptionCalculationUndefined = new Exception("Udefineret resultat"); 

        public string Calculation 
        { 
            get 
            { 
                return calculation; 
            }
            set 
            {
                calculation = value;
                BeginCalculating();
            }
        }
        public string Result { get; private set; } = "";

        private void BeginCalculating()
        {
            try
            {
                List<CalculatorNumber> numbersRaw = GetNumbers(calculation);
                List<CalculatorNumber> numbersAfterRAndP = CalculateRootsAndPowers(numbersRaw);
                List<CalculatorNumber> numbersAfterTAndD = CalculateTimesAndDivide(numbersAfterRAndP);
                CalculatorNumber result = CalculatePlusAndMinus(numbersAfterTAndD);
                Result = result.Value.ToString();
            }
            catch(Exception exception)
            {
                throw exception;
            }
        }
        private void CalculateParentheses(string calculation)
        {
      
        }
        private List<CalculatorNumber> CalculateRootsAndPowers(List<CalculatorNumber> numbers)
        {
            Operator[] operators = { Operator.Asign, Operator.Pow };
            return CalculateByOperators(numbers, operators);
        }
        private List<CalculatorNumber> CalculateTimesAndDivide(List<CalculatorNumber> numbers)
        {
            Operator[] operators = { Operator.Asign, Operator.Times, Operator.Divide };
            return CalculateByOperators(numbers, operators);
        }
        private CalculatorNumber CalculatePlusAndMinus(List<CalculatorNumber> numbers)
        {
            Operator[] operators = { Operator.Asign, Operator.Plus, Operator.Minus };
            return CalculateByOperators(numbers, operators)[0];
        }
        private List<CalculatorNumber> CalculateByOperators(List<CalculatorNumber> numbers, Operator[] operators)
        {
            List<CalculatorNumber> results = new List<CalculatorNumber>
            {
                new CalculatorNumber()
            };

            foreach (CalculatorNumber number in numbers)
            {
                CalculatorNumber result = results[results.Count - 1];
                bool isOperatorFound = false;

                foreach (Operator @operator in operators)
                {
                    if (number.Operator == @operator)
                    {
                        result.Value = OperatorCalculate(result.Value, result.Operator, number.Value);
                        result.Operator = number.Operator;
                        isOperatorFound = true;
                    }
                }

                if (!isOperatorFound)
                {
                    result.Value = OperatorCalculate(result.Value, result.Operator, number.Value);
                    result.Operator = number.Operator;
                    results.Add(new CalculatorNumber());
                }
            }

            return results;
        }

        private bool CheckNumber(char character)
        {
            char[] numbers =
            {
                '0','1','2','3','4','5','6','7','8','9',','
            };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (character == numbers[i])
                {
                    return true;
                }
            }

            return false;
        }
        private bool CheckOperator(char character)
        {
            char[] operators =
            {
                '+','-','*','/','^'
            };

            for (int i = 0; i < operators.Length; i++)
            {
                if (character == operators[i])
                {
                    return true;
                }
            }

            return false;
        }

        private double OperatorCalculate(double x1, Operator @operator, double x2)
        {
            switch (@operator)
            {
            case Operator.Asign : return x2;
            case Operator.Plus  : return x1 + x2;
            case Operator.Minus : return x1 - x2;
            case Operator.Times : return x1 * x2;
            case Operator.Divide: if (x2 == 0.0) throw exceptionCalculationUndefined; return x1 / x2;
            case Operator.Pow   : return Math.Pow(x1, x2);
            default : throw exceptionCalculationError;
            }
        }
        private double FunctionCalculate(string function, double[] parameters)
        {
            switch (function)
            {
            case "abs"  : return Math.Abs(parameters[0]);
            case "sqrt" : return Math.Sqrt(parameters[0]);
            case "pow"  : return Math.Pow(parameters[0], parameters[1]);
            case "sign" : return Math.Sign(parameters[0]);
            case "floor": return Math.Floor(parameters[0]);
            case "round": return Math.Round(parameters[0]);
            case "ceil" : return Math.Ceiling(parameters[0]);
            case "sin"  : return Math.Sin(parameters[0]);
            case "asin" : return Math.Asin(parameters[0]);
            case "cos"  : return Math.Cos(parameters[0]);
            case "acos" : return Math.Acos(parameters[0]);
            case "tan"  : return Math.Tan(parameters[0]);
            case "atan" : return Math.Atan(parameters[0]);
            default     : throw exceptionCalculationError;
            }
        }

        private List<CalculatorNumber> GetNumbers(string calculation)
        {
            List<CalculatorNumber> numbers = new List<CalculatorNumber>();
            CalculatorNumber number = new CalculatorNumber();
            string numberText = "";

            try
            {
                for (int i = 0; i < calculation.Length; i++)
                {
                    if (calculation[i] == ' ')
                    {
                        continue;
                    }
                    else if (CheckNumber(calculation[i]))
                    {
                        numberText += calculation[i];
                    }
                    else if (CheckOperator(calculation[i]))
                    {
                        number.Value = double.Parse(numberText);
                        number.Operator = (Operator)calculation[i];
                        numbers.Add(number);

                        number = new CalculatorNumber();
                        numberText = "";
                    }
                }

                if (numberText != "")
                {
                    number.Value = double.Parse(numberText);
                    number.Operator = Operator.Asign;
                    numbers.Add(number);
                }
            }
            catch
            {
                throw exceptionCalculationError;
            }
            
            return numbers;
        }
        private double GetConstant(string constant)
        {
            switch(constant)
            {
            case "π"    : return Math.PI;
            default     : throw exceptionCalculationError;
            }
        }
    }
}
