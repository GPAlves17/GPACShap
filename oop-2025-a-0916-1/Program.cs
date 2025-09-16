// See https://aka.ms/new-console-template for more information
//string Greeting = "Hello";

//string MyName = "Giuli";

//int MyAge = 37;

//Console.WriteLine($"{Greeting} {MyName}. You are {MyAge} years old");

using oop_2025_a_0916_1.Models;

string SuperHero1Name = "tony Stark";
string SuperHero1Alias = "iron man";

string SuperHero2Name = "peter parker";
string SuperHero2Alias = "spiderman";


//Console.WriteLine($"{SuperHero1Name} is {SuperHero1Alias}");
//Console.WriteLine($"{SuperHero2Name} is {SuperHero2Alias}");

SuperHero SuperHero1 = new SuperHero();
SuperHero1.Alias = "Iron Man";
SuperHero1.Name = "Tony Stark";

SuperHero SuperHero2 = new SuperHero();
SuperHero2.Alias = "Superman";
SuperHero2.Name = "Peter Parker";

SuperHero SuperHero3 = new SuperHero()
{
    Name = "Bruce Banner",
    Alias = "The Hulk"
};

Console.WriteLine($"{SuperHero1.Name} is {SuperHero1.Alias}");
Console.WriteLine($"{SuperHero2.Name} is {SuperHero2.Alias}");
Console.WriteLine($"{SuperHero3.Name} is {SuperHero3.Alias}");

Console.WriteLine(SuperHero1.ToString());
Console.WriteLine(SuperHero2.ToString());
Console.WriteLine(SuperHero3.ToString());

