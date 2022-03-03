using System;

//3.1
/*
 byte choix = 0;

do
    
{Console.WriteLine("faite votre choix de menu [1, 2 ou 3] :");
    byte menu = byte.Parse(Console.ReadLine());
    choix = menu;
    switch (choix)
    {
        case 1:
            Console.WriteLine("ajouter une note");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine("modifier une note");
            Console.ReadLine();
            break;
        case 3:
            Console.WriteLine("supprimer une note");
            Console.ReadLine();
            break;
            
    }
    
    
} while(choix > 3 || choix < 1);
*/




//3.2
/*
 byte variable = 0;
do

{
    Console.WriteLine("entrez un nombre entre 10 et 20 inclusivement");
    byte nombre = byte.Parse(Console.ReadLine());
    variable = nombre;
    if (variable < 10)
    {
        Console.WriteLine("plus grand !");
    }

    else if (variable > 20)
    {
        Console.WriteLine("plus petit !");
    }
    else
    {
        Console.WriteLine("bravo !");
    }
} while (variable < 10 || variable > 20);
*/

//3.3
/*
int x1, x2, result; 
Console.WriteLine("Entrez deux entier :");
x1 = int.Parse( Console.ReadLine() );
x2 = int.Parse( Console.ReadLine() ); 
do
{ 
    result = x1 % x2;
    Console.WriteLine(x1);
    x1 = x2;
    Console.WriteLine(x2);
    x2 = result; 
    Console.WriteLine(result);
} while( result != 0 ); 
 
Console.WriteLine($"Le résultat est { x1 }"); 
*/
/*
 3.3.1 :Quelle est l’instruction qui permet de modifier le résultat du test de sortie de boucle (dans le while ) ? 
 
- tant que le resultat donne pas 0 la boucle continue
 
3.3.2 :Quel sera le résultat en supposant que l’utilisateur entre les valeurs 30 et 42.

- le resultat est 6
 	 
3.3.3 :Quel sera le résultat en supposant que l’utilisateur entre les valeurs 35 et 6. 

 - le resultat est 1
 
3.3.4 	Quel est le calcul réalisé par ce programme, a quoi sert ce programme ? 

la boucle continue tant que mod x2 egale pas 0 et quand il egale 0 on a notre x1 qui s'affiche

*/
/*
 
3.4) 	Écrire un programme C# qui demande un nombre à l'utilisateur et calcule sa factorielle.
 */
/*
Console.WriteLine("entrez un nombre");
int nombre = int.Parse(Console.ReadLine());

{
    int resultat = 1;
    while (nombre != 1)
    {
        resultat = resultat * nombre;
        nombre = nombre - 1;
    }

    
    Console.WriteLine($"la factorielle est de {resultat} ");
}
*/

/*
3.5) Écrivez un programme de type devinette qui tire un chiffre au hasard entre 0 et 9 et demande à l’utilisateur de deviner ce nombre jusqu’à-ce qu’il le trouve. Suivez le étapes suivantes :  
1.	Tirer le nombre au hasard 
2.	Demander un nombre à l’utilisateur 
3.	Tant que le nombre lu est différent du nombre tiré au hasard 	 
A)	Demande un nombre à l’utilisateur 
B)	Compter le nombre de boucles (essaie) effectuées 
 
4.	Afficher un message de réussite ainsi que le nombre d’essaies nécessaires 
5.	N.B. Pour tirer un nombre aléatoire : new Random().Next(0,9) 
 
*/

/*
Random chiffre = new Random();
int chiffrerandom = chiffre.Next(0,9);
int rep = 0;

bool loop = false;
while (loop == false)
{
    Console.WriteLine("entrez un chiffre");
    int choix = int.Parse(Console.ReadLine());
    rep++;
   
    if (choix == chiffrerandom)
    {
        Console.WriteLine($"bravo ! reussi en {rep} fois");
        
        loop = true;
    }
    else
    {
        Console.WriteLine("reessayez");
    }
}

*/

/*
 3.6) 


Random chiffre = new Random();
int chiffrerandom = chiffre.Next(0, 50);
int rep = 0;

bool loop = false;
while (loop == false)
{
    Console.WriteLine("entrez un chiffre");
    int choix = int.Parse(Console.ReadLine());
    rep++;
    if (choix < chiffrerandom)
    {
        Console.WriteLine("monte !");
    }
    else if (choix > chiffrerandom)
    {
        Console.WriteLine("descend !");
    }

    else
    {
        Console.WriteLine($"bravo ! reussi en {rep} fois");

        loop = true;
    }
}

*/

/*
 Les boucles « for » 
 
    3.7)
    
     Écrire un programme C# 
    qui demande un nombre de départ
     qui doit obligatoirement être pair (boucle « do… while »)  sinon on redemande un nombre,
      et qui ensuite affiche les dix nombres suivants par saut de 2 (boucle « for »).
       Par exemple, si l'utilisateur entre le nombre 18, le programme affichera de 18 à 38.  */

/*

int nombre = 1; 

do
{
    Console.Clear();
    Console.WriteLine("entrez un nombre pair");
    
    nombre = int.Parse(Console.ReadLine());
   
} while (nombre % 2 != 0);

for (int i = 0; i < 10; i++)
{
    nombre = nombre + 2;
    Console.Write($" {nombre}");

}


*/

/*
 
 
 3.8) Écrire un programme C# qui demande successivement 5 nombres enter positif à l’utilisateur,
  et qui lui dit ensuite quel était le plus grand parmi ces 5 nombres. */

/*

Console.WriteLine("entrez 5 entier");
int[] liste = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write($"entier {i + 1} :");
    liste[i] = int.Parse(Console.ReadLine());
}

int plusgrand = 0;

for (int i = 0; i < liste.Length; ++i)
{
    int tmp = liste[i];
    if (tmp > plusgrand)
    {
        plusgrand = tmp;
    }
}

Console.WriteLine($"le plus grand est {plusgrand}");

*/


/*
Défis : Les boucle « for » avancées 
 
3.9) 	Écrire un programme C# 
qui demande un nombre x et affiche les x premiers nombre de cette série [1, 1, 2, 3, 5, 8, 13, ...] (suite de Fibonacci). 
*/

/*

int nombre1 = 0;
int nombre2 = 1;
int nombre3;
int nombreentre;

Console.Write("Entrez le nombre d'element de la suite Fibonacci: ");
nombreentre = int.Parse(Console.ReadLine());
Console.Write(nombre1 + " " + nombre2 + " ");   
for (int i = 2; i < nombreentre; ++i)   
{
    nombre3 = nombre1 + nombre2;
    Console.Write($"{nombre3} ");
    nombre1 = nombre2; 
    nombre2 = nombre3;
}


*/

/*
 3.10) Écrire un programme C# qui demande un nombre à l'utilisateur (hauteur) et qui affiche un 
    « carré (rectangle) » de cette hauteur avec des « X » */
  

/*

int hauteur;

Console.Write("Entrez l'hauteur du carre : ");
hauteur = int.Parse(Console.ReadLine());
for (int i = 0; i < hauteur; i++)
{
    Console.WriteLine("XXXXX");
}


*/

/*
3.11) Écrire un programme C# qui demande un nombre à l'utilisateur (hauteur) et qui affiche une 
pyramide de cette hauteur avec des « X »  */



int hauteur;

Console.Clear();
Console.Write("Entre hauteur de la pyramide : ");
hauteur = int.Parse(Console.ReadLine());
for (int i = 0; i <= hauteur; i++) 
{
  
    for (int j = 1; j <= hauteur - i; j++) 
    {
        Console.Write(" ");
    }

   
    for (int k = 1; k <= 2 * i - 1; k++) 
    {
        Console.Write("X");
    }

    Console.WriteLine();

}    


