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
            Dollar product = five.times(2);
            Assert.Equal(10, product.amount);
            product = five.times(3);
            Assert.Equal(15, product.amount);
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}