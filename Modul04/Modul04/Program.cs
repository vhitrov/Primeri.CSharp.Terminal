using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _table = {
				{ "Иван",      "Иванов",      "27" },
				{ "Геоги",     "Георгиев",    "33" },
				{ "Гергана",   "Иванова",     "42" },
				{ "Наталия",   "Руменова",    "32" },
				{ "Цветелина", "Цветомирова", "23" },
				{ "Моника",    "Петкова",     "33" }
			};
//			//Антетка на таблица
//			Console.WriteLine ("Име".PadRight (12) + "Фамилия".PadRight (12) + "Години".PadRight (12));
//			Console.WriteLine ("==============================");
//
//			//Тяло на таблицата
//			for (int i = 0; i < _table.Length / 3; i++) {
//				
//				//Код на цикъла
//
//				for (int j = 0; j < 3; j++) {
//					Console.Write (_table [i, j].PadRight (12));
//
//				}

				int i=0;
			while(i< _table.Length/3){
				Console.WriteLine (
					_table [i, 0].PadRight (12) +
					_table [i, 1].PadRight (12) +
					_table [i, 2].PadRight (12));
				i++;
				}

				Console.WriteLine ();
			}
		}
	}
