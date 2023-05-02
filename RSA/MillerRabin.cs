using RSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab3

{
	internal class MillerRabin
	{
		public static bool MillerRabinTest(BigInteger numberToTest, int numberOfTests)
		{
			if (numberToTest == 2) return true;
			if (numberToTest < 2 || numberToTest % 2 == 0)
			{
				return false;
			}

			if (numberToTest == 2 || numberToTest == 3)
			{
				return true;
			}

			BigInteger t = numberToTest - 1;
			int s = 0;

			while (t % 2 == 0)
			{
				t /= 2;
				s++;
			}

			for (int i = 0; i < numberOfTests; i++)
			{
				BigInteger randomNumber = Form1.RandomBI(2, numberToTest-2);

				BigInteger x = BigInteger.ModPow(randomNumber, t, numberToTest);

				if (x == 1 || x == numberToTest - 1)
				{
					continue;
				}

				for (int r = 1; r < s; r++)
				{
					x = BigInteger.ModPow(x, 2, numberToTest);

					if (x == 1)
					{
						return false;
					}

					if (x == numberToTest - 1)
					{
						break;
					}
				}

				if (x != numberToTest - 1)
				{
					return false;
				}
			}

			return true;
		}
	}
}
