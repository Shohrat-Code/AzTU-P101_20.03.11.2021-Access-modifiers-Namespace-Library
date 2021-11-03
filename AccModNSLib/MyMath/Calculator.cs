using System;

namespace MyMath
{
    public class Calculator
    {
        public int Age { get; set; }
        //internal int _Age { get { return this.Age; } }
        internal int Score { get; set; }
        protected internal string Address { get; set; }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public int Power(int a, byte b)
        {
            int pow = 1;
            for (int i = 0; i < b; i++)
            {
                pow *= a;
            }

            return pow;
        }

        public int AreaOfRectangle(int a, int b)
        {
            return a * b;
        }
    }
}
