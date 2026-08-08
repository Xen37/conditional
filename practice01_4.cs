using System;

class Program{
	
	static void Main()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		
		string result = (num >= 50) ? "Passed" : "Failed"; 
		
		Console.WriteLine(result);
	}
	
}
