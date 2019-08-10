using NUnit.Framework;

namespace Structural.Adapter.str
{
    [TestFixture]
    class StrTests
    {
        string text = "testing!";
    
        [Test]
        public void CreationTest()
        {
            var constructed = new str(text);
            Assert.That(constructed.ToString(), Is.EqualTo(text));

            str assigned = text;
            Assert.That(assigned.ToString(), Is.EqualTo(text));
        }

        [Test]
        public void ComparisonTest()
        {
            str first = text;
            str second = text;
      
            // Equals
            Assert.That(first, Is.EqualTo(second));
            // op ==
            Assert.That(first == second);
            // op == with a C# string
            Assert.That(first == text);
            Assert.That(second, Is.EqualTo(text));
        }

        [Test]
        public void ConcatenationTest()
        {
            str foo = "foo";
            str bar = "bar";
      
            Assert.That(foo+bar, Is.EqualTo("foobar"));
            Assert.That("foo"+bar, Is.EqualTo("foobar"));
            Assert.That(foo+"bar", Is.EqualTo("foobar"));

            foo += bar;
            Assert.That(foo, Is.EqualTo("foobar"));
        }
    }
}