using System;

namespace exo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans, num1, num2, chang;
            Console.WriteLine("Entrez deux chiffres");
            ans = Console.ReadLine();
            num1 = Convert.ToString(ans[0]);
            num2 = Convert.ToString(ans[2]);

            chang = num1;
            num1 = num2;
            num2 = chang;

            Console.WriteLine(num1 + " et " + num2);

        }
    }
}
