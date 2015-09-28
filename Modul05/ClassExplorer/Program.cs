using System;

namespace ClassExplorer
{
	public class person
	{
		private string simpleString = "Тестова променлива от клас";
		private string user="";

		private string hiddenstring="";

		public person(string _ini)
		{
			getUser (_ini);
			setWelcomeText ();
		}

		private void getUser(string _ini)
		{
			if(_ini=="password1") hiddenstring="Потребител 1";
			if(_ini=="password2") hiddenstring="Потребител 2";
			user = hiddenstring;
		}

		private void setWelcomeText()
		{
			if (hiddenstring.Length > 0)
				simpleString = "Добре дошли отново, " + user + "!";
			else
				simpleString = "Вие нямате достъп до тази програма";	
		}
		public string getWelcomeMessage()
		{
			return simpleString;
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Парола: "); string _user = Console.ReadLine ();

			//Дефинира на клас
			person _person=new person(_user);

			//Достъпване на клас
			Console.WriteLine (_person.getWelcomeMessage());
		}
	}
}
