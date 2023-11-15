using org.mariuszgromada.math.mxparser;

namespace SimpleConsoleCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            License.iConfirmCommercialUse("Onyeka Nwizu");
            var message = License.getUseTypeConfirmationMessage();
            var terms = License.geTermsOfAgreement();
            Console.WriteLine(message);
            Console.WriteLine("\n" + terms);
            while (true)
            {
                Console.WriteLine("Expression:👇");
                var userExp = Console.ReadLine() ?? "0";

                if (userExp == "exit")
                {
                    break;
                }
                else
                {
                    EvaluateExpression(userExp);
                }
            }
        }

        private static void EvaluateExpression(string exp)
        {
            Expression expression = new Expression(exp);
            mXparser.consolePrintln($"Result: {expression.getExpressionString()} = {expression.calculate()}");
        }
    }
}