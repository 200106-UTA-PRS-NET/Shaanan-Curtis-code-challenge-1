using System;
using Xunit;
using Library;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Class1 obj = new Class1();
            bool passedAll = true;

            if (obj.Method1("nurses run"))
                Console.WriteLine("Palindrome");
            else
            {
                passedAll = false;
                Console.WriteLine("Not a Palindrome");
            }

            if (obj.Method1("racecaR"))
                Console.WriteLine("Palindrome");
            else
            {
                passedAll = false;
                Console.WriteLine("Not a Palindrome");
            }

            if (obj.Method1("1221"))
                Console.WriteLine("Palindrome");
            else
            {
                passedAll = false;
                Console.WriteLine("Not a Palindrome");
            }

            if (obj.Method1("never odd, or even."))
                Console.WriteLine("Palindrome");
            else
            {
                passedAll = false;
                Console.WriteLine("Not a Palindrome");
            }
        }

        [Fact]
        public void FailingTest()
        {
            Class1 obj = new Class1();
            bool failedAll = true;

            if (obj.Method1("one two one"))
                Console.WriteLine("Not a Palindrome");
            else
            {
                failedAll = false;
                Console.WriteLine("Palindrome");
            }

            if (obj.Method1("123abccba123"))
                Console.WriteLine("Not a Palindrome");
            else
            {
                failedAll = false;
                Console.WriteLine("Palindrome");
            }

            if (obj.Method1("woieajglkn ajweoj.aljwlo"))
                Console.WriteLine("Not a Palindrome");
            else
            {
                failedAll = false;
                Console.WriteLine("Palindrome");
            }
        }
    }
}
