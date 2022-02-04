using System;

Console.Write("entrez le diametre de la sphere: ");
double sphereVolume;
double diametre = double.Parse(Console.ReadLine());
sphereVolume = Math.PI * Math.Pow(diametre, 3) / 3 / 2;
sphereVolume = Math.Round(sphereVolume, 1);
Console.WriteLine("le volume d'une sphere de diametre " + diametre + " est de " + sphereVolume + "cm3");