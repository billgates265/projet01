using System;

namespace labo6
{
    class Program
    {
        static void Main()
        {
            int input = 0;
            do
            {
                Console.WriteLine("| [1] - E01 |");
                Console.WriteLine("| [2] - E02 |");
                Console.WriteLine("| [3] - E03 |");
                Console.WriteLine("| [4] - E04 |");
                Console.WriteLine("| [5] - E05 |");
                Console.WriteLine("| [6] - E06 |");
                Console.WriteLine("| [7] -  |");
                Console.WriteLine("| [8] -  |");

                do
                {
                    Console.Write("entrez votre choix [1..7]: ");
                    input = int.Parse(Console.ReadLine());
                } while (input < 1 || input > 8);

                if (input == 1)
                {
                    /*6.1) Écrivez une fonction Accumulator() qui renvoie la somme de cinq nombres entrés par vous
                     et passés en paramètres individuellement dans la fonction (ne PAS utiliser de tableaux pour ce numéro).
                    N.B. Votre fonction accumulator() peut être appelée dans une fonction nommée E01()*/

                    Console.WriteLine("entrez 5 nombres pour avoir la somme");
                    int total = 0;
                    int nombre1 = int.Parse(Console.ReadLine());
                    int nombre2 = int.Parse(Console.ReadLine());
                    int nombre3 = int.Parse(Console.ReadLine());
                    int nombre4 = int.Parse(Console.ReadLine());
                    int nombre5 = int.Parse(Console.ReadLine());

                    total = Accumulator(nombre1, nombre2, nombre3, nombre4, nombre5);
                    Console.WriteLine($"la somme des 5 nombres est de {total}");
                    Console.WriteLine();
                    
                }
                else if (input == 2)
                {
                    /*6.2) Écrire une fonction Sum() ayant comme paramètres un tableau de nombre et qui retourne la 
                    somme de tous les éléments du tableau. Le tableau contiendra 5 nombres.
                    N.B. Votre fonction peut être appelée dans une fonction nommée E02()*/

                    decimal[] tableau = new decimal[5];
                    decimal total = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"entrez le nombre # {i + 1} : ");
                        tableau[i] = decimal.Parse(Console.ReadLine());
                    }

                    total = Sum(tableau);
                    Console.WriteLine($"la somme des 5 nombres est de {total}");

                    static decimal Sum(decimal[] tableau)
                    {
                        decimal total = 0;
                        foreach (var VARIABLE in tableau)
                        {
                            total = total + VARIABLE;
                        }

                        return total;
                    }
                }
                else if (input == 3)
                {
                    /*6.3) Écrire une fonction Distance() ayant comme paramètres 4 nombres x1, y1 et x2, y2 qui 
                    représentent les coordonnées de deux points 1 et 2 et qui renvoie la distance entre les points.
                    N.B. Votre fonction peut être appelée dans une fonction nommée E03()*/

                    double distance = 0;
                    Console.WriteLine($"entrez deux coordonnees x , y");
                    double x1 = double.Parse(Console.ReadLine());
                    double y1 = double.Parse(Console.ReadLine());
                    double x2 = double.Parse(Console.ReadLine());
                    double y2 = double.Parse(Console.ReadLine());

                    distance = Distance(x1, y1, x2, y2);
                    Console.WriteLine($"la distance entre les deux est de {distance}");

                    static double Distance(double x1, double y1, double x2, double y2)
                    {
                        double distance = 0;
                        distance = Math.Round(Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)), 2);
                        return distance;
                    }
                }
                else if (input == 4)
                {
                    /*6.4) Écrire une fonction RandomNumbers() ayant en paramètre une quantité de nombre à entrer et 
                    qui retourne un tableau remplis de nombre aléatoires en 0 et 100 qui sera ensuite affichés à l’écran à 
                    partir de la fonction E04();. Il faut que l’algorithme ne génère l’objet Random() qu’une seule fois en mémoire .
                    Défi : Permettre à l’utilisateur de remplacer le nombre aléatoire maximum par le nombre de son choix. Cela doit également fonctionner 
                    s’il n’entre absolument rien. Indice : Lire sur les try…catch !
                    N.B. Votre fonction peut être appelée dans une fonction nommée E04()*/

                    string choix = "";


                    Console.Write("pour choisir votre nombre de nombre tapez 'yes' ou faites 'Enter'");
                    choix = (Console.ReadLine());


                    if (choix == "yes")
                    {
                        Console.WriteLine("entrez votre nombre de nombre");
                        int nombrechoisis = int.Parse(Console.ReadLine());
                        Randomnumbers(nombrechoisis);
                        Console.WriteLine();
                    }
                    else
                    {
                        Randomnumbers(10);
                        Console.WriteLine();
                    }

                    static int[] Randomnumbers(int nombre)
                    {
                        int[] tableau1 = new int[nombre];
                        Random random = new Random();

                        for (int i = 0; i < tableau1.Length; i++)
                        {
                            tableau1[i] = random.Next(0, 100);
                            Console.Write($"{tableau1[i]} ");
                            if ((i + 1) != tableau1.Length)
                            {
                                Console.Write(", ");
                            }
                        }

                        return tableau1;
                    }
                }
                else if (input == 5)
                {
                    /*6.5) Écrivez une fonction Power() permettant de calculer la puissance de n’importe quel nombre. 
                    Exemple 2 à la 4, 10 à la 5. Vous devez bien sur tout coder vous-même, pas le droit d’utiliser de 
                    fonctions C#. L’algorithme se termine quand l’utilisateur ne veut plus faire de calcul ( N ).
                     N.B. Votre fonction peut être appelée dans une fonction nommée E05()*/

                    string stop;
                    do
                    {
                        int nombre = 0;
                        int puissance = 0;

                        Console.WriteLine("entrez un nombre");
                        nombre = int.Parse(Console.ReadLine());

                        Console.WriteLine("entrez la puissance");
                        puissance = int.Parse(Console.ReadLine());

                        Console.WriteLine(Power(nombre, puissance));

                        Console.WriteLine("voulez vous arreter ? y/n");
                        stop = Console.ReadLine();
                    } while (stop == "n");

                    Console.WriteLine("fin de la fonction");


                    static int Power(int nombre, int puissance)
                    {
                        int reponse = 1;

                        while (puissance > 0)
                        {
                            reponse *= nombre;
                            puissance--;
                        }

                        return reponse;
                    }
                }
                else if (input == 6)
                {
                    /*6.6) Reprenez l’exercice précédent et, si ce n’est pas déjà le cas, transformer la demande de faire 
                    d’autres calculs en fonction AnotherPower() Qui retourne une valeur booléenne (0 ou 1).*/


                    string stop;
                    do
                    {
                        int nombre = 0;
                        int puissance = 0;

                        Console.WriteLine("entrez un nombre");
                        nombre = int.Parse(Console.ReadLine());

                        Console.WriteLine("entrez la puissance");
                        puissance = int.Parse(Console.ReadLine());

                        Console.WriteLine(Power(nombre, puissance));

                        Console.WriteLine("voulez vous arreter ? y/n");
                        stop = Console.ReadLine();
                    } while (Anotherpower(stop));

                    Console.WriteLine("fin de la fonction");


                    public static int Power(int nombre, int puissance)
                    {
                        int reponse = 1;

                        while (puissance > 0)
                        {
                            reponse *= nombre;
                            puissance--;
                        }

                        return reponse;
                    }

                    static bool Anotherpower(String stop)
                    {
                        return stop == "n";
                    }
                }
            } while (input != 8);
        }
        public static int Accumulator(int nombre1, int nombre2, int nombre3, int nombre4, int nombre5)
        {
            int resultat = 0;

            return nombre1 + nombre2 + nombre3 + nombre4 + nombre5;
        }
    }
}