namespace Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    class Foo
    {
        private AutoResetEvent two = new AutoResetEvent(false);
        private AutoResetEvent three = new AutoResetEvent(false);
        public Foo()
        {
            
        }

        public void First(Action printFirst)
        {
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            two.Set();
        }

        public void Second(Action printSecond)
        {
            two.WaitOne();
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            three.Set();
        }

        public void Third(Action printThird)
        {
            three.WaitOne();
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
