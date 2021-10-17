using System;

namespace Lesson_3
{
	public enum AccountType
	{
		Current,
		Credit,
		Deposit,
		Payments
	};

	public class BankAccount
	{
		public override string ToString() => $"[{ID}] ({AccType}) {Balance}";

		static decimal LastID = 0;

		decimal _id;
		decimal _balance;
		AccountType _type;

		public decimal ID => _id;
		public decimal Balance
		{
			get => _balance;
			set => _balance = value;
		}
		public AccountType AccType
		{
			get => _type;
			set => _type = value;
		}

		public BankAccount()
		{
			_id = NewID();
		}
		public BankAccount(decimal balance)
		{
			_id = NewID();
			_balance = balance;
		}
		public BankAccount(AccountType type)
		{
			_id = NewID();
			_type = type;
		}
		public BankAccount(AccountType type, decimal balance)
		{
			_id = NewID();
			_type = type;
			_balance = balance;
		}

		public string Print()
		{
			return $"Account: {ID}{Environment.NewLine}Acoount type: {AccType}{Environment.NewLine}Balance: {Balance}";
		}

		private decimal NewID()
		{
			return ++LastID;
		}

		public void AddBalance(decimal money)
		{
			Balance += money;
		}
		public bool PullBalance(decimal money)
		{
			if (Balance >= money)
			{
				Balance -= money;
				return true;
			}
			return false;
		}
	}
}
