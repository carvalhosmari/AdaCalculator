namespace AdaCalculator.Tests
{
    public class CalculatorUnitTest
    {
        [Theory]
        [InlineData(2, -1, 1)]
        [InlineData(3, 2, 5)]
        [InlineData(7.5, 3.5, 11)]
        public void Calculate_SumOfTwoNumbers_ReturnsResultAndOperation(double n1, double n2, double expected)
        {
            CalculatorMachine calcMach = new CalculatorMachine(new Calculator());

            (string operation, double result) op = calcMach.Calculate("sum", n1, n2);

            Assert.Equal(expected, op.result);
            Assert.Equal("sum", op.operation);
        }

        [Theory]
        [InlineData(2, 4, -2)]
        [InlineData(2, 0, 2)]
        [InlineData(5.5, -4.5, 10)]
        public void Calculate_SubtractionOfTwoNumbers_ReturnsResultAndOperation(double n1, double n2, double expected)
        {
            CalculatorMachine calcMach = new CalculatorMachine(new Calculator());

            (string operation, double result) op = calcMach.Calculate("subtract", n1, n2);

            Assert.Equal(expected, op.result);
            Assert.Equal("subtract", op.operation);
        }

        [Theory]
        [InlineData(4, -2, -8)]
        [InlineData(2, 0, 0)]
        [InlineData(1.1, 5, 5.5)]
        public void Calculate_MultiplicationOfTwoNumbers_ReturnsResultAndOperation(double n1, double n2, double expected)
        {
            CalculatorMachine calcMach = new CalculatorMachine(new Calculator());

            (string operation, double result) op = calcMach.Calculate("multiply", n1, n2);

            Assert.Equal(expected, op.result);
            Assert.Equal("multiply", op.operation);
        }

        [Theory]
        [InlineData(2, -4, -0.5)]
        [InlineData(100, 2, 50)]
        [InlineData(10.2, 2, 5.1)]
        public void Calculate_DivisionOfTwoNumbers_ReturnsResultAndOperation(double n1, double n2, double expected)
        {
            CalculatorMachine calcMach = new CalculatorMachine(new Calculator());

            (string operation, double result) op = calcMach.Calculate("divide", n1, n2);

            Assert.Equal(expected, op.result);
            Assert.Equal("divide", op.operation);
        }
    }
}