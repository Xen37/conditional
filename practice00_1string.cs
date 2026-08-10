using System;

class Program{
	static void Main(string[] args){
		Console.Write("enter firstname: ");
		string name = Console.ReadLine()?? "";
		Console.Write("enter lastname: ");
		string name2 = Console.ReadLine()?? "";
		
		Console.WriteLine($"{name + " " + name2} ");
		}
}
