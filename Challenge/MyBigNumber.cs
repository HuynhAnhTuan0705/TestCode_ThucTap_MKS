using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
	public class MyBigNumber
	{
		private string value;
		public string Value { get => value; set => this.value = value; }
		public MyBigNumber()
		{
			Value = "0";
		}
		public MyBigNumber(string valueinput)
		{
			Value = valueinput;
		}
		public string sum(string stn1, string stn2)
		{
			int len = 0, remember = 0, index_num1 = stn1.Length - 1, index_num2 = stn2.Length - 1;

			if (stn1.Length >= stn2.Length)
			{
				len = stn1.Length;
			}
			else
			{
				len = stn2.Length;
			}

			string result = "";
			int digit_num1 = 0, digit_num2 = 0;

			for (int i = 0; i <= len - 1; i++)
			{
				if (index_num1 >= 0)
				{
					digit_num1 = int.Parse(stn1[index_num1].ToString());
				}
				else
				{
					digit_num1 = 0;
				}
				index_num1--;

				if (index_num2 >= 0)
				{
					digit_num2 = int.Parse(stn2[index_num2].ToString());
				}
				else
				{ 
					digit_num2 = 0;
				}
				index_num2--;

				Trace.WriteLine($"[Step {i + 1}]");
				int sum = digit_num1 + digit_num2 + remember;
				Trace.WriteLine($"{digit_num1} + {digit_num2} + nhớ {remember} = {sum}");
				result = (sum % 10).ToString() + result;
				remember = sum / 10;
			}
			if (remember > 0)
			{
				Trace.WriteLine($"[Step {len + 1}]");
				Trace.WriteLine($"{remember} nối {result} = {remember.ToString() + result}");
				result = remember.ToString() + result;
			}

			Trace.WriteLine($"{stn1} + {stn2} = {result}");
			Trace.WriteLine("==================================================");
			Trace.Flush();

			return result;
		}
	}
}
