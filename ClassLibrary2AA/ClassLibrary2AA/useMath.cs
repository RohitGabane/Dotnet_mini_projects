namespace ClassLibrary2AA
{
    /*public class MyMath
    {
        public void sqr(int x) { 
        Console.WriteLine(x*x);
        }
        protected void cube(int x)
        {
            Console.WriteLine(x*x*x);
        }
        
        protected internal void sum(int x)
        {
            Console.WriteLine(x+x);
        }
    }
    public class useMath
    {
        public static void makeobj()
        {
            MyMath obj = new MyMath();
            obj.sum(1);
        }
    }
    public class child : MyMath
    {
        public void usep()
        {
            sum(1);
            cube(2);
        }
    }*/
    // Rethrow an exception. 
    /*using System;
    class Rethrow
    {
        public static void genException()
        {
            // here, numer is longer than denom 
            int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] denom = { 2, 0, 4, 4, 0, 8 };

            for (int i = 0; i < numer.Length; i++)
            {
                try
                {
                    Console.WriteLine(numer[i] + " / " +
                                                  denom[i] + " is " +
                                                  numer[i] / denom[i]);
                }
                catch (DivideByZeroException)
                {
                    // catch the exception 
                    Console.WriteLine("Can't divide by Zero!");
                }
                catch (IndexOutOfRangeException)
                {
                    // catch the exception 
                    Console.WriteLine("No matching element found.");
                    throw; // rethrow the exception 
                }
            }
        }
    }
    class RethrowDemo
    {
        public static void Main()
        {
            try
            {
                Rethrow.genException();
            }
            catch (IndexOutOfRangeException)
            {
                // recatch exception 
                Console.WriteLine("Fatal error -- " +
                                  "program terminated.");
            }
        }
    }*/

}