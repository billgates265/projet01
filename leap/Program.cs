using System;


Console.WriteLine("entrer l'annee");
decimal annee = decimal.Parse(Console.ReadLine());
Console.WriteLine("entrer le mois");
String mois = Console.ReadLine();

if (mois.Equals("2"))
{
    decimal yo = annee / 4;
    decimal yo2 = annee / 100;
    decimal yo3 = annee / 400;

    {
        if (yo % 1 == 0 && yo2 % 1 != 0 || yo3 % 1 == 0)
        {
            Console.Write("fevrier de " + "l'annee " + annee + " a 29 jours");
        }
        else
        {
            Console.Write("fevrier de " + "l'annee " + annee + " a 28 jours");
        }
    }
}

if (mois.Equals("1"))
    Console.Write("janvier de " + "l'annee " + annee + " a 31 jours");

if (mois.Equals("3"))
    Console.Write("mars de " + "l'annee " + annee + " a 31 jours");

if (mois.Equals("4"))
    Console.Write("avril de " + "l'annee " + annee + " a 30 jours");

if (mois.Equals("5"))
    Console.Write("mai de " + "l'annee " + annee + " a 31 jours");

if (mois.Equals("6"))
    Console.Write("juin de " + "l'annee " + annee + " a 30 jours");

if (mois.Equals("7"))
    Console.Write("juillet de " + "l'annee " + annee + " a 31 jours");

if (mois.Equals("8"))
    Console.Write("aout de " + "l'annee " + annee + " a 31 jours");

if (mois.Equals("9"))
    Console.Write("septembre de " + "l'annee " + annee + " a 30 jours");

if (mois.Equals("10"))
    Console.Write("octobre de " + "l'annee " + annee + " a 31 jours");

if (mois.Equals("11"))
    Console.Write("novembre de " + "l'annee " + annee + " a 30 jours");

if (mois.Equals("12"))
    Console.Write("decembre de " + "l'annee " + annee + " a 31 jours");







    