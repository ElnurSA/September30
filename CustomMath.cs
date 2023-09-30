//using System;
//namespace Practice
//{
//	public class CustomMath
//	{
//		public int SumOfOddNumbers(int[] array)
//		{
//			//int sum = 0;

//			//foreach(var item in array)
//			//{
//			//	if(item%2 != 0)
//			//	{
//			//		sum += item;

//			//	}

//			//}
//			//return sum;

//			return array.Where(m => m % 2 != 0).Sum(m => m);
//		}

//		public string CheckNumOddOrEven(int number)
//		{
//			//if (number % 2 == 0)
//			//	return "Even";

//			//return "Odd";


//			return number % 2 == 0 ? "Even" : "Odd";
//		}

//		public double FindPowOfEvenNumber(int[] numbers, int pow) => Math.Pow(numbers.Where(m => m % 2 == 0).Sum(m => m), pow);

//		public int GetFactorial(int num)
//		{

//			int result = 1;

//			for (int i = 1; i <= num; i++)
//			{
//				result *= i;
//			}

//			return result;
//		}


//	}
//}

