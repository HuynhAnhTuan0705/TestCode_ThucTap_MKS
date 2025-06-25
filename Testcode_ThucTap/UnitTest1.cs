using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Challenge;

namespace Testcode_ThucTap
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestCase1()
		{
			MyBigNumber num1 = new MyBigNumber("1234");
			MyBigNumber num2 = new MyBigNumber("897");

			string result = num1.sum(num1.Value, num2.Value);
			Assert.AreEqual("2131", result);
		}

		[TestMethod]
		public void TestCase2()
		{
			MyBigNumber num1 = new MyBigNumber("199999999999999999999999999999999999999999999");
			MyBigNumber num2 = new MyBigNumber("1");

			string result = num1.sum(num1.Value, num2.Value);
			Assert.AreEqual("200000000000000000000000000000000000000000000", result);
		}
		[TestMethod]
		public void TestCase3()
		{
			MyBigNumber num1 = new MyBigNumber("99");
			MyBigNumber num2 = new MyBigNumber("1");

			string result = num1.sum(num1.Value, num2.Value);
			Assert.AreEqual("100", result);
		}
		[TestMethod]
		public void TestCase4()
		{
			MyBigNumber num1 = new MyBigNumber("45");
			MyBigNumber num2 = new MyBigNumber("65");

			string result = num1.sum(num1.Value, num2.Value);
			Assert.AreEqual("110", result);
		}
	}
}
