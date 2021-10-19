using System;
using System.Text;

namespace Lesson_3
{
	class Program
	{
		static void Main(string[] args)
		{
			//var bankAcc1 = new BankAccount(AccountType.Current, 500);
			//var bankAcc2 = new BankAccount(AccountType.Current, 230);

			//if (bankAcc1.MoneyTransfer(bankAcc2, 25))
			//	Console.WriteLine("Успешный перевод денег");
			//else
			//	Console.WriteLine("Перевод денег не удался");

			var str1 = "abc123";
			var str2 = "321cba";
			if (ReverseString(str1).Equals(str2))
				Console.WriteLine("Построение строки в обратном порядке прошло успешно");
			else
				Console.WriteLine("Результат построения строки в обратном порядке не прошёл проверку");
		}

		static string ReverseString(string text)
		{
			var sb = new StringBuilder();
			for (int i = text.Length - 1; i >= 0; i--)
				sb.Append(text[i]);

			return sb.ToString();
		}
	}
}
