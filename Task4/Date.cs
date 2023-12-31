﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	internal class Date
	{
		private int day;

		public int Day
		{
			get { return day; }
			set 
			{
				if (value > 0 && value <= 31)
					day = value;
			}
		}

		private int month;

		public int Month
		{
			get { return month; }
			set 
			{
				if(value > 0 &&  value <= 12)
					month = value;
			}
		}

		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}
		public Date()
		{

		}
		public Date(int day, int month, int year)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public static Date operator +(Date a, int days)
		{
			a.day += days;
			return a;
		}

		public static int operator -(Date a, Date b) => a.day > b.day ? a.day - b.day : b.day - a.day;

		public override string ToString()
		{
			return $"Day: {Day}, Month: {Month}, Year: {Year}";
		}

	}

}
