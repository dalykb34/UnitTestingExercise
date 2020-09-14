using System;
namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
            // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int one, int two, int three)
        {
            return one + two + three;

        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        public int Sub(int x, int y)
        {
            return x - y;
        }
        // Create a Multiply method that passes 2 integers
        public int Multi( int a, int b)
        {
            return a * b;
        }
        // Create a Divide method that passes 2 integers
        public int Divide(int c, int d)
        {
            return c / d;
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote

        public char GetH(char h)
        {
            return h;
        }

        public int Squared(int d)
        {
            return d * d;
        }
    }
}
