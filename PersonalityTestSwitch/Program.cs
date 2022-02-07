using System;

namespace PersonalityTestSwitch
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
			string userColor = Console.ReadLine().ToLower();

			switch (userColor)
			{
				case "punane":
					Console.WriteLine("Oled romantiline");
					break;

				case "sinine":
					Console.WriteLine("Oled töökas");
					break;

				case "roheline":
					Console.WriteLine("Oled looduse sõber");
					break;

				default:
					Console.WriteLine($"Oled {userColor} ükssarvik");
					break;
			}

			Console.WriteLine("Kena päeva!");

		}
	}
}
