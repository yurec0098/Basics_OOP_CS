using System;

namespace Lesson_2
{
	public enum AccountType
	{
		Current,
		Credit,
		Deposit,
		Payments
	};

	/*1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
	 * Предусмотреть методы для доступа к данным – заполнения и чтения.
	 * Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.*/
	public class BankAccount
	{
		public override string ToString() => $"[{ID}] ({Type}) {Balance}";

		string _id;
		decimal _balance;
		AccountType _type;

		public string ID => _id;    //	Номер счёта не должен меняться
		public decimal Balance
		{
			get => _balance;
			set => _balance = value;
		}
		public AccountType Type
		{
			get => _type;
			set => _type = value;
		}

		public BankAccount(AccountType type)
		{
			_id = $"{Guid.NewGuid()}";
			Type = type;
		}
		public BankAccount(AccountType type, decimal balance) : this(type)
		{
			Balance = balance;
		}

		public string Print()
		{
			return $"Account: {ID}{Environment.NewLine}Acoount type: {Type}{Environment.NewLine}Balance: {Balance}";
		}
	}
}
