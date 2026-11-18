namespace ContosoUniversity.IntegrationTests.Features.Calculator
{
    using ContosoUniversity.Features.Calculator;
    using Shouldly;

    public class CalculatorTests
    {
        public void Add()
        {
            Calculator.Add(2.5m, 4m).ShouldBe(6.5m);
        }

        public void Subtract()
        {
            Calculator.Subtract(2.5m, 4m).ShouldBe(-1.5m);
        }
    }
}
