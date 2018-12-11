using System;

namespace Delegate
{
    delegate double BinaryNumericOperation(double n1,double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double A = 10;
            double B = 12;

            BinaryNumericOperation op = CalculationServices.Sum(A,B); 
            double result=op(A,B);
            Console.WriteLine(result);

            BinaryNumericOperation op1 = CalculationServices.Max; 
            double result1=op1(A,B);
            Console.WriteLine(result1);
        }
    }
}
