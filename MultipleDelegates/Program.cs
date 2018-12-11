using System;

namespace MultipleDelegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1,double n2);
        static void Main(string[] args)
        {
            double a=10;
            double b=12;

            BinaryNumericOperation operation=CalculationService.ShowSum;
            operation+=CalculationService.ShowMax;

            operation.Invoke(a,b);
            //ou operation(a,b);
        }
    }
}
