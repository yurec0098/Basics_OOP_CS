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
	Предусмотреть методы для доступа к данным – заполнения и чтения.
	Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.*/
	public class BankAccount
	{
		public override string ToString() => $"[{GetID()}] ({GetType()}) {GetBalance()}";

		decimal _id;
		decimal _balance;
		AccountType _type;

		public decimal GetID()
		{
			return _id;
		}
		public void SetID(decimal value)
		{
			_id = value;
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
	}
}
