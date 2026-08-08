using System;

class Program{
	static void Main(){
		Console.Write("enter your age: ");
		int age = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("enter your income: ");
		int income = Convert.ToInt32(Console.ReadLine());	
		
		if ( age >= 25 && age <= 35 && income > 50000 ){
			Console.WriteLine($"Young Professional");
		}
		else if (age >= 36 && age <=55 && income > 70000){
			Console.WriteLine($"Middle aged Professional");
			
		}
		else if (age >= 56 && income > 30000)
		{
			Console.WriteLine($"Senior Citizen");
		}
		else
		{
			Console.WriteLine("idk");
		}
	}

}
