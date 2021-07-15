using NUnit.Framework;

namespace Foo.Tests
{
    public class Tests
    {       
        [Test]
        public void Test1()
        {
            var c = new Class1() { FooString = "bar" };

            Assert.False(c.Foo1());
            Assert.False(c.Foo2());
            Assert.False(c.Foo3());
            Assert.False(c.Foo4());
            Assert.False(c.Foo5());
            Assert.False(c.Foo6());
        }
    }
}