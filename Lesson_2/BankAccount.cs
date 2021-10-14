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

	/*
	1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
	Предусмотреть методы для доступа к данным – заполнения и чтения.
	Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.
	 
	2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
	Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.*/
	public class BankAccount
	{
		public override string ToString() => $"[{ID}] ({Type}) {Balance}";

		static decimal LastID = 0;

		decimal _id;
		decimal _balance;
		AccountType _type;

		public decimal ID => _id;    //	Номер счёта не должен меняться
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
			_id = NewID();
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

		private decimal NewID()
		{
			return ++LastID;
		}
	}
}
