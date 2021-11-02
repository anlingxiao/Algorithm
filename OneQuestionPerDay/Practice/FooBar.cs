namespace Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    class FooBar
    {
        private int n;
        private AutoResetEvent FooresetEvent = new AutoResetEvent(true);
        private AutoResetEvent BarresetEvent = new AutoResetEvent(false);
        public FooBar(int n)
        {
            this.n = n;
        }

        public void Foo(Action printFoo)
        {

            for (int i = 0; i < n; i++)
            {
                FooresetEvent.WaitOne();
                // printFoo() outputs "foo". Do not change or remove this line.
                printFoo();
                FooresetEvent.Reset();
                BarresetEvent.Set();
            }
        }

        public void Bar(Action printBar)
        {

            for (int i = 0; i < n; i++)
            {
                BarresetEvent.WaitOne();
                // printBar() outputs "bar". Do not change or remove this line.
                printBar();
                BarresetEvent.Reset();
                FooresetEvent.Set();
            }
        }
    }
}
