// See https://aka.ms/new-console-template for more information

//1) demander le nom de l'utilisateur et l'accueillir
//ex: bienvenue ( ) à l'application monOUTIL



Console.WriteLine("Quel est votre nom?:");

String LINE = Console.ReadLine();

Console.WriteLine($"Bienvenue" + LINE + "à l'application");

//demander température en celsius
Console.WriteLine($"Entrez une température en degré celsius!");
double températureenCelsius= Convert.ToDouble(Console.ReadLine());
double températureenFareneit = températureenCelsius * 9 / 5 + 32;


Console.WriteLine($"Votre température en fareneit est");


