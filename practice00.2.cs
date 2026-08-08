using System;

class Program{
	static void Main()
	{
	Console.Write("Enter principal amount: ");
	int amount = Convert.ToInt32(Console.ReadLine());
	
	Console.Write("Enter rate: ");
	int rate = Convert.ToInt32(Console.ReadLine());
	
	Console.Write("Enter Time(in years): ");
	int time = Convert.ToInt32(Console.ReadLine());
	
	double interest = (amount * rate * time)/100;
	
	Console.WriteLine($"simple Interest: {interest}");
	
	}
}
