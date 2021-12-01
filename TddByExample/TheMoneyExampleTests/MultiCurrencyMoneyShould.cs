using TheMoneyExample;
using Xunit;

namespace TheMoneyExampleTests
{
    public class MultiCurrencyMoneyShould
    {
        [Fact]
        public void TestMultiplication()
        {
            Money five = Money.dollar(5);
            Assert.True(Money.dollar(10).Equals(five.times(2)));
            Assert.True(Money.dollar(15).Equals(five.times(3)));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            var five = Money.franc(5);
            Assert.True(Money.franc(10).Equals(five.times(2)));
            Assert.True(Money.franc(15).Equals(five.times(3)));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.True(Money.franc(5).Equals(Money.franc(5)));
            Assert.False(Money.franc(5).Equals(Money.franc(6)));
            Assert.False(Money.franc(5).Equals(Money.dollar(6)));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.True("USD".Equals(Money.dollar(1).Currency));
            Assert.True("CHF".Equals(Money.franc(1).Currency));
        }
    }
}