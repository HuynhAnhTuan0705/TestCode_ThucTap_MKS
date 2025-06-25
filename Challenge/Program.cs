using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyBigNumber bigNum = new MyBigNumber();
			string result = bigNum.sum("1999999999999999999999999999999999999999", "1");
			Console.WriteLine($"Result: {result} ");
		}
	}
}
