using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle, rayon, res;
            string ans, rep1, rep2;

            Console.WriteLine("Veuillez indiquer le rayon, puis l'angle de la surface");
            ans = Convert.ToString(Console.ReadLine());

            rep1 = Convert.ToString(ans[0]);
            rep2 = Convert.ToString(ans[1]);

            rayon = Convert.ToDouble(rep1);
            angle = Convert.ToDouble(rep2);

            res = ((Math.PI * angle) * (Math.Pow(rayon, 2))) / 360;
            Console.WriteLine("La surface est de : " + res);
        }
    }
}
