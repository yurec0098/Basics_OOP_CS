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
		public override string ToString() => $"[{GetID()}] ({GetAccType()}) {GetBalance()}";

		static decimal LastID = 0;

		decimal _id;
		decimal _balance;
		AccountType _type;

		public decimal GetID()
		{
			if (_id == 0)
				_id = NewID();
			return _id;
		}

		public decimal GetBalance()
		{
			return _balance;
		}
		public void SetBalance(decimal value)
		{
			_balance = value;
		}

		public AccountType GetAccType()
		{
			return _type;
		}
		public void SetAccType(AccountType value)
		{
			_type = value;
		}

		public string Print()
		{
			return $"Account: {GetID()}{Environment.NewLine}Acoount type: {GetAccType()}{Environment.NewLine}Balance: {GetBalance()}";
		}

		private static decimal NewID()
		{
			return ++LastID;
		}
	}
}
