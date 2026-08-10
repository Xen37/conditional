using System;

class Program{
	static void Main(){
		Console.Write("enter the raduis of the circle: ");
		int radius = Convert.ToInt32(Console.ReadLine());
		double pi = 3.14;
		
		
		double area = pi * radius * radius;
		Console.WriteLine($"area is {area}");
		}
	}
