using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;

namespace lab3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				BigInteger number = BigInteger.Parse(textBox1.Text);
				int k = Convert.ToInt32(textBox2.Text);
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				if (MillerRabin.MillerRabinTest(number, k) is true)
				{
					label3.Text = "Ответ: Число является простым";
					label3.ForeColor = Color.Green;
				}
				else
				{
					label3.Text = "Ответ: Число не является простым";
					label3.ForeColor = Color.Red;
				}
				stopwatch.Stop();
				label4.Text = "Время работы: " + stopwatch.ElapsedMilliseconds.ToString() + " мс";
				stopwatch = new Stopwatch();
				stopwatch.Start();
				if (Solovay.SolovayStrassenTest(number, k) is true)
				{
					label6.Text = "Ответ: Число является простым";
					label6.ForeColor = Color.Green;
				}
				else
				{
					label6.Text = "Ответ: Число не является простым";
					label6.ForeColor = Color.Red;
				}
				stopwatch.Stop();
				label5.Text = "Время работы: " + stopwatch.ElapsedMilliseconds.ToString() + " мс";
			}
			catch
			{
				MessageBox.Show("Проверьте введенные данные, допустимы только цифры");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			
		}
	}
}