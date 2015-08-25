using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//bool _b = true; //True or False
			//bool _test=5>10;

			int[] _i = new int[] { 4, 3, 2 };
			int _ui = Convert.ToInt32 (Console.ReadLine ());
//			bool _check01 = _ui <= _i.Length;
//			bool _check02 = _ui > 0;

//			bool _exp1 = _check01 && _check02; //Логическо "И"(&&)
//			bool _exp2 = _check01 || _check02; //Логическо "ИЛИ"(||)
//			bool _exp3 = !_check01; //Отрицание (!)
//
//
//			Console.WriteLine ("Логическо И: " + _exp1.ToString());
//			Console.WriteLine ("Логическо ИЛИ: " + _exp2.ToString());
//			Console.WriteLine ("Отрицанието на " + _check01.ToString () + " е: " + _exp3);

			if (_ui > 0 && _ui <= _i.Length) {
				Console.WriteLine (_i [_ui - 1]);
			} else {
				if (_ui > _i.Length) 
				{
					Console.WriteLine ("Индекса е прекалено голям \n\n\n");
				}
				if (_ui <=  0) 
				{
					Console.WriteLine ("Индекса е прекалено малък \n\n\n");
				}
			}
		}

			//Console.WriteLine (_i[_ui-1]);


		}
	}