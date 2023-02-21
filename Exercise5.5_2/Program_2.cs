using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._5_2
{
	internal class Program_2
	{
		static void Main(string[] args)
		// Перестоновка слов в предложении
		{
			WriteLine("Введите предложение:");
			string text = ReadLine();
			string[] sep = Revers(text);

			for(int i = 0; i < sep.Length; i++)
			{
				Write($"{sep[i]} ");
			}
			ReadLine();
		}

		/// <summary>
		/// Разбивание строки на подстроки
		/// </summary>
		 static string[] Separ(string text)
		{
			string[] sep = text.Split(' ', ',', '.');

			//foreach (var se in sep)
			//{
			//	WriteLine($"{se}");

			//}
			return sep;
		}

		/// <summary>
		/// Меняем слова местами
		/// </summary>
		 static string[] Revers(string text)
		{
			string[] sep = Separ(text);
			Array.Reverse(sep);
			return sep;
		}
	}
}
