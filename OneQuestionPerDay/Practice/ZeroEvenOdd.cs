namespace Practice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading;

    class ZeroEvenOdd
    {
        private int n;
        private AutoResetEvent z = new AutoResetEvent(true);
        private AutoResetEvent e = new AutoResetEvent(false);
        private AutoResetEvent o = new AutoResetEvent(false);
        public ZeroEvenOdd(int n)
        {
            this.n = n;
        }

        // printNumber(x) outputs "x", where x is an integer.
        public void Zero(Action<int> printNumber)
        {
            for (int i = 0; i < n; i++)
            {
                z.WaitOne();
                printNumber(0);
                if (i % 2 == 0)
                {
                    o.Set();
                }
                else
                {
                    e.Set();
                }
            }
        }

        public void Even(Action<int> printNumber)
        {
            for (int i = 2; i <= n; i += 2)
            {
                e.WaitOne();
                if (i % 2 == 0)
                {
                    printNumber(i);
                }
                z.Set();
            }
        }

        public void Odd(Action<int> printNumber)
        {
            for (int i = 1; i <= n; i += 2)
            {
                o.WaitOne();
                if (i % 2 == 1)
                {
                    printNumber(i);
                }
                z.Set();
            }
        }
    }
}
