using System;

namespace Creating_Calculator_by_Using_Switch_Cases
{
	class Program
	{
		static void Main(string[] args)
		{
			Char Cal = Convert.ToChar(Console.ReadLine());

			switch (Cal)
			{
				case 'y':
				case 'Y':






					Console.WriteLine("To create your calculator kindly add details below");


					Console.WriteLine("Enter first Number Here:");

					int a = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Enter Second Number Here");

					int b = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Select Any Option A,M,S,D");

					Char cal1 = Convert.ToChar(Console.ReadLine());

					switch (cal1)

					{

						case 'A':

						case 'a':

							{
								Console.WriteLine(a + b);
								break;
							}

						case 'M':

						case 'm':

							{
								Console.WriteLine(a * b);
								break;
							}

						case 'S':

						case 's':

							{
								Console.WriteLine(a - b);
								break;
							}

						case 'D':

						case 'd':

							{
								Console.WriteLine(a / b);
								break;
							}



						default:
							Console.WriteLine("You Have Enter Incorrect Numbers");
							break;

					}

					break;


				case 'n':
				case 'N':
					{
						Console.WriteLine("is not cal");
						break;
					}


				default:
					Console.WriteLine("not cal");
					break;

			}

			Console.ReadKey();

		}

	}
			
}
