using System;

class Program{
	static void Main(){
		Console.Write("enter a num: ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		if(num % 2 == 0){
			Console.WriteLine($"The number {num} is even");
		}
		else{
			Console.WriteLine("The number {num} is odd");
		}
		
	}
}
