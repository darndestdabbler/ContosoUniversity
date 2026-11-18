namespace ContosoUniversity.IntegrationTests.Features.Percentage
{
    using System;
    using ContosoUniversity.Features.Percentage;
    using Shouldly;

    public class PercentageTests
    {
        public void Of()
        {
            Percentage.Of(1m, 3m).ShouldBe(33.33m);
        }

        public void OfRefusesZeroWhole()
        {
            Should.Throw<ArgumentException>(() => Percentage.Of(1m, 0m));
        }
    }
}
