namespace Calculator
{
    public class Addition
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Sum(int[] a)
        {
            int c = 0;
            foreach (int b in a)
            {
                c = Sum(c, b);
            }
            return c;
        }
    }
}