using System;

namespace BoolExplore02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] { 4, 3, 2 };
			int _ui = 0; 
			string _input = "0";
			Console.Write ("Моля въведете индекс: ");
			_input = Console.ReadLine ();
			bool _check01 = int.TryParse(_input, out _ui);
			try
			{
				Console.Write("Елемент "+_ui.ToString()+" от масива е: ");
				Console.WriteLine(_i[_ui-1]);
			}
			catch {
				Console.WriteLine ("<Недефиниран елемент!!!>");
			}


//			_ui = (_ui<=_i.Length) ? _ui:3;
//			_ui = (_ui > 0) ? _ui : 1;

//			if(_check01) {
//				Console.WriteLine (_i [_ui - 1]);
//						}

//			switch(_ui){
//			case 1:
//				{
//					Console.Write ("Първи елемент от масива: ");
//					Console.WriteLine(_i[_ui-1]);
//					break;
//				}
//			case 2:
//				{
//					Console.Write ("Втори елемент от масива: ");
//					Console.WriteLine(_i[_ui-1]);
//					break;
//				}
//			case 3:
//				{
//					Console.Write ("Трети елемент от масива: ");
//					Console.WriteLine(_i[_ui-1]);
//					break;
//				}
//			default:
//				{
//					Console.Write ("В масива няма стойност за този индекс!\nОпитайте с индекс м/у 1 и 3.\n\n ");
//					break;
//				}
			}
		}
	}
