using System;

namespace Lesson_3
{
	class Program
	{
		static void Main(string[] args)
		{
			var bankAcc1 = new BankAccount(AccountType.Current, 500);
			var bankAcc2 = new BankAccount(AccountType.Current, 230);

			if (bankAcc1.MoneyTransfer(bankAcc2, 25))
				Console.WriteLine("Успешный перевод денег");
			else
				Console.WriteLine("Перевод денег не удался");
		}
	}
}
