using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string usercomand="";

			//Потрбителски команди
			do 
			{
				Console.Write ("$ "); usercomand=Console.ReadLine ();
				if(usercomand.Contains("cmd01")) cmd01 (usercomand);
				if(usercomand.Contains("cmd02")) Console.WriteLine(cmd02(usercomand));

			} while(usercomand !="exit");

		}
		public static void cmd01 (string _input) //cmd01 5-->5^2=25
		{
			try
			{
				double _temp=0;
				if(double.TryParse(_input.Split(' ')[1], out _temp)) {
					Console.WriteLine("\nРезултат от"+_temp.ToString()+"^2"+(_temp*_temp).ToString());
				}
					
			} catch{
			}
		}

		public static int cmd02 (string _input)
		{
			int _temp = 0;
			if (int.TryParse (_input.Split (' ') [1], out _temp)) {
				_temp = _temp * _temp * _temp;
			}
			return _temp;
		}
	}
}
