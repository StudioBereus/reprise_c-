using System;

namespace exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer, calcul;
            double r, resAire, resVolume;

            Console.WriteLine("Veuillez indiquer le rayon de votre sphere");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indiquez maintenant si vous vous souhaitez calculer l'aire, le volume ou les deux");
            calcul = Console.ReadLine();

            if (r > 0){
                if (calcul == "aire"){
                    resAire = 4 * (Math.PI * Math.Pow(r, 2));
                    Console.WriteLine("L'aire de la sphere est de : " + resAire);
                }
                else if (calcul == "volume"){
                    resVolume = (4 / 3 * Math.PI) * Math.Pow(r, 3);
                    Console.WriteLine("Le volume de la sphere est de : " + resVolume);
                }
                else if (calcul == "deux"){
                    resAire = 4 * (Math.PI * Math.Pow(r, 2));
                    resVolume = (4 / 3 * Math.PI) * Math.Pow(r, 3);

                    Console.WriteLine("Aire de la sphere : " + resAire);
                    Console.WriteLine("Volume de la sphere : " + resVolume);
                }
                else{
                    Console.WriteLine("Entree incorrecte");
                }
            }
            else{
                Console.WriteLine("Cette sphère n'existe pas !");
            }


            
        }
    }
}
