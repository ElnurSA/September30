using System;
namespace Practice
{
	public class Factorial : CommonCalc
	{
		public int GetFactorial(int a)
		{
			int result = 1;
			for (int i = 1; i <= a; i++)
			{
				result *= i;
			}
			return result;
		}
	}
}

