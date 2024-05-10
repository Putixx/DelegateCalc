namespace DelegateCalc
{
    public class Calculator
    {
        public delegate double Operation(double x, double y);

        public double Calculate(string[] input)
        {
            if(input.Length != 3)
            {
                throw new ArgumentException("Incorrect input, you need to provide 'type,a,b'!");
            }

            if (!double.TryParse(input[1], out double aValueResult))
            {
                throw new ArgumentException("Incorrect input, both provided values need to be numbers!");
            }

            if (!double.TryParse(input[2], out double bValueResult))
            {
                throw new ArgumentException("Incorrect input, both provided values need to be numbers!");
            }

            DetermineOperationType(input[0], out Operation operation);

            return operation(aValueResult, bValueResult);
        }

        private static Operation DetermineOperationType(string type, out Operation operation)
        {
            switch (type)
            {
                case "add": 
                    {
                        operation = new Operation(Calculation.Addition);
                        break;
                    }
                case "sub":
                    {
                        operation = new Operation(Calculation.Subtraction);
                        break;
                    }
                case "mul":
                    {
                        operation = new Operation(Calculation.Multiplication);
                        break;
                    }
                case "pow":
                    {
                        operation = new Operation(Calculation.Power);
                        break;
                    }
                case "root":
                    {
                        operation = new Operation(Calculation.Root);
                        break;
                    }
                case "div":
                    {
                        operation = new Operation(Calculation.Division);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException("Calculation type not implemented yet.");
                    }
            }
            return operation;
        }
    }
}
