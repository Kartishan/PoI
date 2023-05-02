using lab3;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
	public partial class Form1 : Form
	{
		char[] alphabet = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
														'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
														'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
														'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
														'8', '9', '0'};

		public Form1()
		{
			InitializeComponent();
		}
		private BigInteger EulerFunction(BigInteger p, BigInteger q)
		{
			return ((p - 1) * (q - 1));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				BigInteger p = BigInteger.Parse(textBox1.Text);
				BigInteger q = BigInteger.Parse(textBox2.Text);
				if (!MillerRabin.MillerRabinTest(p, 50) || !MillerRabin.MillerRabinTest(q, 50))
				{
					MessageBox.Show("p и q должны быть простыми");
					return;
				}
				BigInteger mod = BigInteger.Multiply(p, q);
				BigInteger n = EulerFunction(p, q);
				BigInteger _e = FindE(n);
				BigInteger d = FindD(_e, n);
				textBox3.Text = n.ToString();
				textBox4.Text = _e.ToString();
				textBox5.Text = d.ToString();
				textBox6.Text = mod.ToString();
				textBox7.Text = mod.ToString();
				string message = textBox8.Text.ToUpper();
				StringBuilder encryptedMessage = RSAEncode(message, _e, mod);
				textBox9.Text = encryptedMessage.ToString();
			}
			catch
			{
				MessageBox.Show("Проверьте правильность данных, возможно вы написали не цифры в p и q");
			}
		}

		public static BigInteger RandomBI(BigInteger min, BigInteger max)
		{
			var rng = new RNGCryptoServiceProvider();
			var data = new byte[max.ToByteArray().Length];
			BigInteger result;

			do
			{
				rng.GetBytes(data);
				result = new BigInteger(data);
			} while (result < min || result >= max);

			return result;
		}

		private BigInteger FindE(BigInteger n)
		{
			BigInteger e = RandomBI(2,n);

			for (BigInteger i = 2; i < n; i++)
			{
				if ((n % i == 0) && (e % i == 0))
				{
					e = RandomBI(2, n);
					i = 1;
				}
			}

			return e;
		}

		private BigInteger FindD(BigInteger e, BigInteger n)
		{
			BigInteger d = invmod(e, n);
			return d;
		}
		static (BigInteger, BigInteger, BigInteger) gcdex(BigInteger a, BigInteger b)
		{
			if (a == 0)
				return (b, 0, 1);
			(BigInteger gcd, BigInteger x, BigInteger y) = gcdex(b % a, a);
			return (gcd, y - (b / a) * x, x);
		}

		static BigInteger invmod(BigInteger a, BigInteger m)
		{
			(BigInteger g, BigInteger x, BigInteger y) = gcdex(a, m);
			return g > 1 ? 0 : (x % m + m) % m;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				BigInteger d, mod;
				if (textBox12.Text.Length == 0 || textBox13.Text.Length == 0)
				{
					d = BigInteger.Parse(textBox5.Text);
					mod = BigInteger.Parse(textBox6.Text);
				}
				else
				{
					d = BigInteger.Parse(textBox12.Text);
					mod = BigInteger.Parse(textBox13.Text);
				}
				StringBuilder encryptedMessage = new StringBuilder();
				encryptedMessage.Append(textBox10.Text);
				string decryptedMessage = RSADecode(encryptedMessage, d, mod);
				textBox11.Text = (decryptedMessage);
			}
			catch
			{
				MessageBox.Show("Проверьте правильность текста для шифрования");
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private StringBuilder RSAEncode(string s, BigInteger e, BigInteger n)
		{
			textBox9.Text = "ТУТ";
			StringBuilder result = new StringBuilder();

			BigInteger bi;

			for (int i = 0; i < s.Length; i++)
			{
				int index = Array.IndexOf(alphabet, s[i]);

				bi = new BigInteger(index);
				bi = BigInteger.Pow(bi, (int)e);

				BigInteger n_ = new BigInteger((int)n);

				bi = bi % n_;

				result.Append(bi.ToString());
				result.Append(" ");
			}

			return result;
		}

		private string RSADecode(StringBuilder input, BigInteger d, BigInteger n)
		{
			StringBuilder result = new StringBuilder();

			string[] values = input.ToString().Split(' ');

			foreach (string item in values)
			{
				BigInteger bi;
				if (BigInteger.TryParse(item, out bi))
				{
					bi = BigInteger.ModPow(bi, d, n);

					int index = (int)bi;

					result.Append(alphabet[index]);
				}
			}

			return result.ToString();
		}

	}
}