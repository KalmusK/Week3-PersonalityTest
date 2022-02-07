using System;

namespace GradingIF
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
			
			//kasutame IF

			Console.WriteLine("Sisesta oma tulemus:");
			//char - character

			char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

			if (userResult == 'A')
			{
				Console.WriteLine("Suurepärane");
			}

			else if (userResult == 'C')
			{
				Console.WriteLine("Hea");
			}

			else if (userResult == 'D')
			{
				Console.WriteLine("Rahuldav");
			}

			else if (userResult == 'E')
			{
				Console.WriteLine("Kasin");
			}

			else if (userResult == 'F')
			{
				Console.WriteLine("Puudulik");
			}

			else
			{
				Console.WriteLine("Vale väärtus");
			}

			Console.WriteLine("Kena päeva");
		}
	}
}
