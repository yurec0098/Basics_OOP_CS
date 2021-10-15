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
	Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.

	3. В классе банковский счет удалить методы заполнения полей.
	Вместо этих методов создать конструкторы.
	Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс,
	конструктор для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа банковского счета.
	Каждый конструктор должен вызывать метод, генерирующий номер счета.

	4. В классе все методы для заполнения и получения значений полей заменить на свойства.
	Написать тестовый пример.
	
	5. Добавить в класс счет в банке два метода: снять со счета и положить на счет.
	Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.
	*/
	public class BankAccount
	{
		public override string ToString() => $"[{GetID()}] ({GetAccType()}) {GetBalance()}";

		static decimal LastID = 0;

		decimal _id;
		decimal _balance;
		AccountType _type;

		public decimal GetID()
		{
			return _id;
		}
		public decimal GetBalance()
		{
			return _balance;
		}
		public AccountType GetAccType()
		{
			return _type;
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
			return $"Account: {GetID()}{Environment.NewLine}Acoount type: {GetAccType()}{Environment.NewLine}Balance: {GetBalance()}";
		}

		private decimal NewID()
		{
			return ++LastID;
		}
	}
}
