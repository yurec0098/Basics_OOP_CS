using System;

namespace Lesson_2
{
	class Program
	{
		static void Main(string[] args)
		{
			var bankAccount = new BankAccount();
			bankAccount.SetAccType(AccountType.Current);
			bankAccount.SetBalance(250);

			Console.WriteLine(bankAccount.Print());
		}
	}
}
