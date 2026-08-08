using System;

class Program{
	static void Main(){
		char choice;
		do{
		Console.Write("enter your choice ");
		choice = Convert.ToChar(Console.ReadLine()?? "");
		int raduis = 0;
		
		switch (choice){
			
			case 'A':
				Console.Write("enter your raduis ");
				raduis = Convert.ToInt32(Console.ReadLine());
				double Area = 3.14 * (raduis * 2);
				Console.WriteLine($"the area is {Area}");
				break;
			case 'P':
				Console.Write("enter your raduis ");
				raduis = Convert.ToInt32(Console.ReadLine());
				double perimeter = 3 * (3.14 * raduis);
				Console.WriteLine($"the perimeter is {perimeter}");
				break;
			case 'E':
				break;
				
			default:
				Console.WriteLine("error");
				break;
			}
		} while (choice != 'E');
		
		
		
		
		
		
		}
	}
