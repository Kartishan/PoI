using System.Diagnostics;
using System.Numerics;
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
		private long EulerFunction(long p, long q)
		{
			return ((p - 1) * (q - 1));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				long p = Convert.ToInt64(textBox1.Text);
				long q = Convert.ToInt64(textBox2.Text);
				if (IsPrimary(p) == false || IsPrimary(q) == false)
				{
					MessageBox.Show("p и q должны быть простыми");
					return;
				}
				long mod = p * q;
				long n = EulerFunction(p, q);
				long _e = FindE(n);
				long d = FindD(_e, n);
				textBox3.Text = n.ToString();
				textBox4.Text = _e.ToString();
				textBox5.Text = d.ToString();
				textBox6.Text = mod.ToString();
				textBox7.Text = mod.ToString();
				string message = textBox8.Text.ToUpper();
				StringBuilder encryptedMessage = RSA_Encode(message, _e, mod);
				textBox9.Text = (encryptedMessage.ToString());
			}
			catch
			{
				MessageBox.Show("Проверьте правильность данных, возможно вы написали не цифры в p и q");
			}
		}

		private bool IsPrimary(long n)
		{
			if (n < 2)
				return false;
			for (long i = 2; i <= Math.Sqrt(n); i++)
				if (n % i == 0)
					return false;
			return true;
		}
		private long FindE(long n)
		{
			Random random = new Random();
			long e = random.Next(2, Convert.ToInt32(n));

			for (long i = 2; i < n; i++)
			{
				if ((n % i == 0) && (e % i == 0))
				{
					e = random.Next(2, Convert.ToInt32(n));
					i = 1;
				}
			}

			return e;
		}

		private long FindD(long e, long n)
		{
			long d = invmod(e, n);
			return d;
		}
		static (long, long, long) gcdex(long a, long b)
		{
			if (a == 0)
				return (b, 0, 1);
			(long gcd, long x, long y) = gcdex(b % a, a);
			return (gcd, y - (b / a) * x, x);
		}

		static long invmod(long a, long m)
		{
			(long g, long x, long y) = gcdex(a, m);
			return g > 1 ? 0 : (x % m + m) % m;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			long d, mod;
			if (textBox12.Text.Length == 0 || textBox13.Text.Length == 0)
			{
				 d = Convert.ToInt64(textBox5.Text);
				 mod = Convert.ToInt64(textBox6.Text);
			}
			else
			{
				 d = Convert.ToInt64(textBox12.Text);
				 mod = Convert.ToInt64(textBox13.Text);
			}
			StringBuilder encryptedMessage = new StringBuilder();
			encryptedMessage.Append(textBox10.Text);
			string decryptedMessage = RSA_Decode(encryptedMessage, d, mod);
			textBox11.Text = (decryptedMessage);
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private StringBuilder RSA_Encode(string s, long e, long n)
		{
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

		private string RSA_Decode(StringBuilder input, long d, long n)
		{
			StringBuilder result = new StringBuilder();

			string[] values = input.ToString().Split(' ');

			BigInteger bi;

			foreach (string item in values)
			{
				double value;
				if (double.TryParse(item, out value))
				{
					bi = new BigInteger(value);
					bi = BigInteger.Pow(bi, (int)d);

					BigInteger n_ = new BigInteger((int)n);

					bi = bi % n_;

					int index = Convert.ToInt32(bi.ToString());

					result.Append(alphabet[index]);
				}
			}

			return result.ToString();
		}

	}
}