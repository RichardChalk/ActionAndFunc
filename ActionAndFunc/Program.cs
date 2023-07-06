using System.Diagnostics;

namespace ActionAndFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ACTION ACTION ACTION ACTION ACTION ACTION ACTION ACTION
            // ACTION ACTION ACTION ACTION ACTION ACTION ACTION ACTION
            // ACTION ACTION ACTION ACTION ACTION ACTION ACTION ACTION
            // ACTION ACTION ACTION ACTION ACTION ACTION ACTION ACTION

            // Action delegates har alla en returtyp av void! 

            // En Action delegate UTAN parmetrar!
            Action myActionDelegateNoArgs = MethodThatRequiresNoArgs;
            myActionDelegateNoArgs();

            // En Action delegate MED parmetrar!
            Action<int, int> myActionDelegate = MethodThatRequiresTwoInts;
            myActionDelegate(3, 4);

            // FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC
            // FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC
            // FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC
            // FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC FUNC

            // En Func delegate som har 2 in parametrar av typen int
            // ... och en returtyp av float
            Func<int, int, float> mathOperation = Add;
            int a = 5;
            int b = 7;
            float result = mathOperation(a, b);
        }

        private static void MethodThatRequiresNoArgs()
        {
            Console.WriteLine("Nothig to see here!");
        }

        private static void MethodThatRequiresTwoInts(int arg1, int arg2)
        {
            Console.WriteLine(arg1+arg2);
        }

        private static float Add(int num1, int num2)
        {
            // Ganska meningslöst att returnera en float...
            // Men det gör det enklare att förstå hur Func<> är uppbyggd
            return (float)(num1 + num2);
        }
    }
}