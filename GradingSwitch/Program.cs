using System;

namespace GradingSwitch
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib, mis hinde kasutaja sai
			//kui kasutaja sai A siis konsool ütleb "suurepärane"
			// kui B siis "väga hea"
			// kui C siis "hea"
			// kui D siis "rahuldav"
			// kui E siis "kasin"
			// kui F siis "puudulik"
			// kui midagi muud siis "vale väärtus"

			//kasutame Switch


			Console.WriteLine("Sisesta oma tulemus:");

			char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

			switch (userResult)
			{

				case 'A':
					Console.WriteLine("Suurepärane");
					break;

				case 'B':
					Console.WriteLine("Väga hea");
					break;

				case 'C':
					Console.WriteLine("Hea");
					break;

				case 'D':
					Console.WriteLine("Rahuldav");
					break;

				case 'E':
					Console.WriteLine("Kasin");
					break;

				case 'F':
					Console.WriteLine("Puudulik");
					break;

				default:
					Console.WriteLine($"Vale väärtus");
					break;

			}

			Console.WriteLine("Kena päeva");

		}
	}

}
