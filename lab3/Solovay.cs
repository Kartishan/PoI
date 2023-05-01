using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	internal class Solovay
	{
		public static bool SolovayStrassenTest(BigInteger numberToTest, int numberOfTests)
		{
			if (numberToTest < 2 || numberToTest % 2 == 0)
			{
				return false;
			}

			if (numberToTest == 2 || numberToTest == 3)
			{
				return true;
			}

			for (int i = 0; i < numberOfTests; i++)
			{
				BigInteger randomNumber = RandomBigInteger.RandomBI(2, numberToTest - 2);
				BigInteger d = Gcd(randomNumber, numberToTest);
				if (d > 1)
					return false;
				BigInteger x = BigInteger.ModPow(randomNumber, (numberToTest - 1) / 2, numberToTest);

				if (x == 0 || x == 1)
				{
					continue;
				}
				BigInteger jacobianSymbol = ComputeJacobianSymbol(randomNumber, numberToTest);
				BigInteger mod = BigInteger.ModPow(x - jacobianSymbol, numberToTest - 1, numberToTest);

				if (mod != 0)
				{
					return false;
				}
			}

			return true;
		}
		public static BigInteger Gcd(BigInteger a, BigInteger b)
		{
			while (b != 0)
			{
				BigInteger t = b;
				b = a % b;
				a = t;
			}
			return a;
		}


		private static BigInteger ComputeJacobianSymbol(BigInteger a, BigInteger n)
		{
			if (a == 0)
			{
				return 0;
			}

			BigInteger result = 1;

			if (a < 0)
			{
				a = BigInteger.Negate(a);

				if (n % 4 == 3)
				{
					result = BigInteger.Negate(result);
				}
			}

			if (a == 1)
			{
				return result;
			}

			while (a != 0)
			{
				if (a < 0)
				{
					a = BigInteger.Negate(a);

					if (n % 4 == 3)
					{
						result = BigInteger.Negate(result);
					}
				}

				while (a % 2 == 0)
				{
					a /= 2;

					if (n % 8 == 3 || n % 8 == 5)
					{
						result = BigInteger.Negate(result);
					}
				}

				BigInteger temp = a;
				a = n;
				n = temp;

				if (a % 4 == 3 && n % 4 == 3)
				{
					result = BigInteger.Negate(result);
				}

				a %= n;
			}

			if (n == 1)
			{
				return result;
			}
			return 0;
		}

	}
}
