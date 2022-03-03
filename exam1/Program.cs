using System;
/*exercice 1*/
 
/*
Console.Write("entrez un chiffre: "); //je demande avec un write pour avoir mon chiffre rentre sur la meme ligne
int chiffre = int.Parse(Console.ReadLine()); //je declare ma variable qui est rentre par lutilisateur
Console.WriteLine($"{chiffre}{chiffre}{chiffre}");
Console.WriteLine($"{chiffre} {chiffre}"); // jai fait un espace entre mes deux chiffre pour avoir un espace entre les deux
Console.WriteLine($"{chiffre} {chiffre}");
Console.WriteLine($"{chiffre} {chiffre}");
Console.WriteLine($"{chiffre}{chiffre}{chiffre}"); // ma serie de writeline pour avoir une colonne

*/

/*exercice 2 */
/*
 

Console.WriteLine("entrez un nombre de 0 a 20"); 
int nombre = int.Parse(Console.ReadLine()); // je declare ma variable
if ((nombre >= 0) && (nombre <= 20)) // condition 
{
    Console.WriteLine("le carre de "+ nombre + " est de " + nombre * nombre); //calcul + reponse
}
else // si ce est pas u nombre entre 0 et 20
{
    Console.WriteLine("pas un nombre valide"); 
}

*/

/*

Console.WriteLine("entrez un nombre de 21 a 100"); 
int nombre = int.Parse(Console.ReadLine()); // declaration de ma variable
if ((nombre > 20) && (nombre <= 100))
{
    Console.WriteLine("la racine carre de " + nombre + " est de " + Math.Sqrt(nombre));
   
}
else if (nombre <=20) // jai mis un else if car plusieurs condititon
{
    Console.WriteLine("le nombre est plus petit que 21");
}
else
{
    Console.WriteLine("le nombre depasse 100");
}

*/

/*exercice3*/

int input = 0;
do
{
    Console.WriteLine("| [1] - Calcul de la somme de deux nombres entiers. |");
    Console.WriteLine("| [2] - Calcul de la factorielle de N (N !).  |");
    Console.WriteLine("| [3] - Vérifier si un nombre entier A divise un nombre entier B. |");
    Console.WriteLine("| [4] - Calcul du quotient et du reste de la division entière de deux nombres entiers A et B. |");
    Console.WriteLine("| [5] - Vérifier si un caractère donné est une voyelle (voyelles : 'a', 'e', 'i', 'o', 'u', 'y'). |");
    Console.WriteLine("| [6] - Permet de permuter (d’échanger) le contenu de deux variables réelles. |");
    Console.WriteLine("| [7] - Étant donné un entier A, calcule sa valeur absolue. |");
    Console.WriteLine("| [8] - quitter le programme. |");

    do
    {
        Console.Write("entrez votre choix [1..7]: ");
        input = int.Parse(Console.ReadLine());
    } while (input < 1 || input > 8);

    if (input == 1)
    {
       int nombre1 = 0;
       int nombre2 = 0;
       int somme = 0;
        
      Console.WriteLine("entrez 2 nombre entier");
      nombre1 = int.Parse(Console.ReadLine());
      nombre2 = int.Parse(Console.ReadLine());
      somme = nombre1 + nombre2;
      Console.WriteLine("la somme est de " + somme );


    }else if (input == 2)
    {
        int nombre = 0;
        Console.WriteLine("entrez un nombre pour calculer la factorielle");
        nombre = int.Parse(Console.ReadLine());
        Console.WriteLine("la factorielle de " + nombre + " est de " + nombre!);

    }
    else if (input == 3)
    {
        int nombre1 = 0;
        int nombre2 = 0;
        Console.WriteLine("entrez deux nombre entier");
        nombre1 = int.Parse(Console.ReadLine());
        nombre2 = int.Parse(Console.ReadLine());
        if ((nombre2 % nombre1) == 0)
        {
            Console.WriteLine("le nombre b et divisible par le nombre a");
        }
        else
        {
            Console.WriteLine("le nombre b est pas divisible par le nombre a");
        }

    }else if (input == 4)
    {
        Console.WriteLine("entrez eux nombre entier");
    }else if (input == 5)
    {
        string lettre = "";
        Console.WriteLine("entrez ue lettre");
        lettre = Console.ReadLine();
       
        if (lettre == "ae" || lettre == "o" + "u" + "y")
        {
           Console.WriteLine("vous avex retre ue voyelle"); 
        }
        else
        {
            Console.WriteLine("ce est pas ue voyelle");
        }
    }

    if (input == 6)
    {
        
    }

    if (input == 7)
    {
        
       Console.WriteLine("entrez un nombre entiter");
      
       Console.WriteLine();
    }

}while(input != 8);
