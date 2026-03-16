// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, user! What is your name?");
var name = Console.ReadLine();
if (string.IsNullOrEmpty(name)) name = "anon";
Console.WriteLine($"Nice to meet you, {name}!");