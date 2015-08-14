using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime = 0, familia, grupa};

		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2,3];

			//Въвеждане на първи ред
			table[0,(int) ti.ime]= "Васил"; table[0,(int) ti.familia]="Хитров"; table[0,(int) ti.grupa]="3-та";

			//Въвеждане на втори ред
			table[1,(int) ti.ime]= "Марин"; table[1,(int) ti.familia]="Хитров"; table[1,(int) ti.grupa]="4-та";

			//Печат
			Console.Write("Кой ред искате да видите? ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1;

			Console.WriteLine ((table [_index, (int) ti.ime] [0] + ". " + 
								table [_index, (int) ti.familia] + ", " + 
								table [_index, (int) ti.grupa]   + " гр."));

//			Console.WriteLine ((table [0, 0] [0] + ". " + table [0, 1] + ", " + table [0, 2] + " гр."));
//			Console.WriteLine ((table [1, 0] [0] + ". " + table [1, 1] + ", " + table [1, 2] + " гр."));
		}
	}
}


//			string[] row = new string[3];
//			row[0] = "Ред 1";
//			row[1] = "Ред 2"; 
//			row[2] = "Ред 3";
//			Console.WriteLine ("Масив Row: " + row [0] + ", " + row [1] + ", " + row [2] + ", " + "\n");
//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//			Console.WriteLine ("Броят на цифрите в масива: \n" + "1,2,3,4,5,6,7,8,9\n\ne: " + parse.Length);
//
//			string list1 = string.Join (";" , parse);
//			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n\n");

