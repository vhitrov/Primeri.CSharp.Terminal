using System;

namespace ClassExplorer
{
	public class person
	{
		private string _userName="";
		private string _userPass="";

		private string _userID="";
		private string _userFName="";
		private string _userLName="";

		public string userName
		{
			get{ return _userName; }
		}

		public string userPass
		{
			get{ return _userPass; }
		}

		public string userID
		{
			get{return _userID; }
			set{_userID = value; }
		}

		public string userFName
		{
			get{return _userFName; }
			set{_userFName = value; }
		}

		public string userLName
		{
			get{return _userLName; }
			set{_userLName = value; }
		}

		public person(string _user, string _pass)
		{
			checkUser (_user, _pass);
		}

		private bool checkUser (string _user, string _pass)
		{
			if (_user == "user" && _pass == "pass") {
			
				//Попълване на пропъртита
				userID="ID: 0000";
				userFName="Vasil";
				userLName="Hitrov";

				return true;
			}
			return false;
		}

	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Потребител: "); string _user = Console.ReadLine ();
			Console.Write ("Парола: "); string _pass = Console.ReadLine ();

			//Дефинира на клас
			person _person=new person(_user, _pass);

			//Достъпване на клас
			_person.userFName="Име";
			Console.WriteLine(_person.userFName+" "+_person.userLName);

		}
	}
}
