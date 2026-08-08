using System;

class Program{
	static void Main()
	{
		Console.Write("enter a num: ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		if ( num > 0 ){
			Console.WriteLine($"the num {num} is positive");
		}
		else if (num < 0){
			Console.WriteLine($"the num {num} is negative");
			
		}
		else
		{
			Console.WriteLine($"the num {num} is zero");
		}
	}
}
