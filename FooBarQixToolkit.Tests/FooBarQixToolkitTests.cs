using NUnit.Framework;

namespace FooBarQixToolkit.Tests
{
    [TestFixture]
    public class FooBarQixToolkitTests
    {
        [TestCase("1", "1")]
        [TestCase("2", "2")]
        [TestCase("8", "8")]
        public void should_return_number_when_input_is_regular_number(string number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixOperations()).Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("9", "Foo")]
        [TestCase("96", "Foo")]
        [TestCase("24", "Foo")]
        public void should_return_Foo_when_input_is_divisible_by_3(string number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixOperations()).Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("13", "Foo")]
        [TestCase("32", "Foo")]
        public void should_return_Foo_when_input_contains_3(string number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixOperations()).Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("3", "FooFoo")]
        [TestCase("33", "FooFooFoo")]

        public void should_return_multiple_Foo_when_input_contains_3_and_is_divisisble_by_3(string number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixOperations()).Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("5", "BarBar")]
        [TestCase("25", "BarBar")]
        public void should_return_multiple_Bar_when_input_is_divisible_by_5_and_contains_5(string number, string expected)
        {
            var computed = new FooBarQix(new FooBarQixOperations()).Compute(number);
            Assert.That(computed, Is.EqualTo(expected));
        }

        [TestCase("52", "Bar")]
        [TestCase("7", "QixQix")]
        [TestCase("77", "QixQixQix")]
        [TestCase("28", "Qix")]
        [TestCase("17", "Qix")]
        [TestCase("47", "Qix")]
        [TestCase("53", "BarFoo")]
        [TestCase("101", "1*1")]
        [TestCase("202", "2*2")]
        [TestCase("802", "8*2")]
        [TestCase("21", "FooQix")]
        [TestCase("51", "FooBar")]
        [TestCase("15", "FooBarBar")]
        [TestCase("10", "Bar*")]
        [TestCase("303", "FooFoo*Foo")]
        [TestCase("1050", "FooBarQix*Bar*")]
        [TestCase("10101", "FooQix**")]
        public void should_return_evaluated_String(string number, string expected)
        {
            var computed = string.Empty;
            Assert.That(computed, Is.EqualTo(expected));
        }
    }
}