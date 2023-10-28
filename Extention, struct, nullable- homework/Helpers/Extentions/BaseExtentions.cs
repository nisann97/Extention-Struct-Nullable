using System;
using System.Text.RegularExpressions;
namespace Extention__struct__nullable__homework.Helpers.Extentions
{
	public static class BaseExtentions
	{

		//	public static bool CheckEmail(this string email)
		//	{
		//		return Regex.IsMatch(email,"@");
		//	}


		//	public static void CheckTrim(this string email)
		//	{
		//		return Regex.IsMatch(email, )
		//	}


		public static int GetFactorial(this int[] num)
		{
			int factorial = 1;
			foreach(var item in num)
			{
				factorial *= item;
			}

			return factorial;
		}
	}


	
}

