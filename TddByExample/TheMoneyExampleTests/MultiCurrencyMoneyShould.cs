using TheMoneyExample;
using Xunit;

namespace TheMoneyExampleTests
{
    public class MultiCurrencyMoneyShould
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            five.times(2);
            Assert.Equal(10, five.amount);
        }
    }
}