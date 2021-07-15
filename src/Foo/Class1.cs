using System;

namespace Foo
{
    public class Class1
    {
        public string FooString { get; set; }


        public bool Foo1()
        {
            return true && FooString == "foo";
        }

        public bool Foo2()
        {
            return true
                && FooString == "foo";
        }

        public bool Foo3()
        {
            return true &&
                FooString == "foo";
        }

        public bool Foo4()
        {
            return 
                true
                && FooString == "foo";
        }
        public bool Foo5()
        {
            return true
                && FooString == "foo"
                && true;
        }

        public bool Foo6()
        {
            return
                true
                && FooString == "foo"
                && true;
        }        
    }
}
