using System;
namespace Extention__struct__nullable__homework.Helpers.Extentions
{
	public static class Person
	{
		public static int Id { get; set; }
		public static string Name { get; set; } 
		public static string Surname { get; set; }


		public static string GetFullName(this string fullName)
		{
			return fullName;
		}

		
	}

}

