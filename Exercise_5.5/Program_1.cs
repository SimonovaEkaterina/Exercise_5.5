using System;
using static  System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5._5
{
	class Program_1
	{
	/// <summary>
	/// Запрос на ввод предложения
	/// </summary>
		static void Deline()
		{
				WriteLine("Введите предложение:");
		}
	/// <summary>
	/// Разбивание строки на подстроки
	/// </summary>
		static void Separ()
		{
			string s = ReadLine();
			string[] sep = s.Split(' ');

			foreach (var se in sep)
			{
				WriteLine($"{se}");
			}
		
		}

	
		static void Main(string[] args)
		// Задание №_1 "Раздеение строки на слова"
		{
			Deline();
			Separ();
		}
	}
}
