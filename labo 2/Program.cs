using System;
using System.ComponentModel.Design;

/*Console.WriteLine("entrer un nombre");
int nombre = int.Parse(Console.ReadLine());
if ((nombre % 5) == 0 && (nombre % 7) != 0)
{
    Console.WriteLine($"le nombre {nombre} est valide");
}
else Console.WriteLine($"le nombre {nombre} est invalide");*/
/*Console.WriteLine("entrer l'annee");
decimal annee = decimal.Parse(Console.ReadLine());
decimal yo = annee / 4;
decimal yo2 = annee / 100;
decimal yo3 = annee / 400;


if (yo % 1 == 0 && yo2 % 1 != 0 || yo3 % 1 == 0)

    Console.Write(annee + " est une annee bissextile");

else

    Console.Write(annee + " est pas une annee bissextile");*/
Console.WriteLine("entrer le jour");
byte jour = byte.Parse(Console.ReadLine());

switch (jour)
{
    case 1:
        Console.Write(" bon dimanche!");
        break;

    case 2:
        Console.WriteLine(" bon lundi!");
        break;

    case 3:
        Console.Write(" bon mardi!");
        break;
    case 4:
        Console.Write(" bon mercredi!");
        break;
    case 5:
        Console.Write(" bon jeudi!");
        break;
    case 6:
        Console.Write("bon vendredi!");
        break;
    case 7:
        Console.Write("bon samedi!");
        break;

    default:
        Console.WriteLine("tu est perdu dans lespace !");
        break;
}