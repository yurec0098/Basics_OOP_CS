using System;

namespace Lesson_2
{
	class Program
	{
		static void Main(string[] args)
		{
			var bankAccount = new BankAccount($"{Guid.NewGuid()}", AccountType.Current, 250);
			Console.WriteLine(bankAccount.Print());
		}
	}
}
