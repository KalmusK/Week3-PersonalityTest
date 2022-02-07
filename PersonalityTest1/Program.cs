using System;

namespace PersonalityTest1
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajal sisestada tema lemmikvärv
			//kui kasutaja sisestab punane, siis konsool ütleb "oled romantiline"
			//kui kasutaja siestab sinise, siis konsool ülteb "oled töökas"
			//kui roheline "oled looduse sõber"
			//kui midagi muud siis "oled {userColor} ükssarvik


			Console.WriteLine("Sisesta oma lemmikvärv:");
			string userColor = Console.ReadLine();

			if(userColor == "punane")
				{
				Console.WriteLine("Oled romantiline.");
			}
			else if (userColor == "sinine")
			{
				Console.WriteLine("Oled töökas");
			}
			else if (userColor == "roheline")
			{
				Console.WriteLine("Oled looduse sõber");
			}
			else
			{
				Console.WriteLine($"Oled {userColor} ükssarvik.");
			}

			Console.WriteLine("Kena päeva!");
		}
	}
}
