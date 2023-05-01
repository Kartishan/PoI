using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace laba1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//абвгдеёжзийклмнопрстуфхцчшщъыьэюя123456789 ,.!?; тут 6 строк по 8 символов
			try
			{
				if (string.IsNullOrEmpty(textBox1?.Text))
				{
					MessageBox.Show("Вы забыли ввести ключ");
					return;
				}
				if (string.IsNullOrEmpty(textBox2?.Text))
				{
					MessageBox.Show("Вы забыли ввести фразу для шифрования");
					return;
				}
				listBox1.Items.Clear();
				listBox3.Items.Clear();
				string key = new string(textBox1.Text.ToUpper().Distinct().ToArray());
				string alphabet = string.Concat("абвгдежзийклмнопрстуфхцчшщъыьэюя".ToUpper().Except(key));
				string newAlphabet = key + alphabet;
				char[,] AlphaChar = ConvertTo2DCharArray(newAlphabet);
				string message = textBox2.Text.ToUpper();
				alphaListBoxFill(listBox1, AlphaChar);
				alphaAndNewAlpha(listBox3, AlphaChar);
				string newMessage = Trisemus(message, AlphaChar);
				string separation = new string('-', message.Length);
				listBox2.Items.Add(newMessage);
				listBox2.Items.Add(separation);
			}
			catch { MessageBox.Show("Ошибка, проверьте введеные данные"); }
		}
		public static void alphaListBoxFill(ListBox listBox1, char[,] AlphaChar)
		{
			for (int i = 0; i < AlphaChar.GetLength(0); i++)
			{
				string reslt = "";
				for (int j = 0; j < AlphaChar.GetLength(1); j++)
				{
					reslt += (AlphaChar[i, j]) + " | ";
				}
				listBox1.Items.Add(reslt + "\n");
			}
		}
		public static void alphaAndNewAlpha(ListBox listBox1, char[,] AlphaChar)
		{
			const int lineLength = 32;
			const int substringLength = 29;
			const string alphabetString = "абвгдежзийклмнопрстуфхцчшщъыьэюя";

			string separation = new string('-', lineLength);
			string str = alphabetString.ToUpper();
			string newAlphabet = Trisemus(str, AlphaChar);
			string alphabet = string.Join(" | ", str.ToCharArray());
			newAlphabet = String.Join(" | ", newAlphabet.ToCharArray());

			for (int i = 0; i < 4; i++)
			{
				int startIndex = i * lineLength;
				string currentAlphabet = alphabet.Substring(startIndex, substringLength);
				string currentNewAlphabet = newAlphabet.Substring(startIndex, substringLength);

				listBox1.Items.Add(currentAlphabet);
				listBox1.Items.Add(currentNewAlphabet);
				listBox1.Items.Add(separation);
			}

		}

		public static string TrisemusDecrypt(string message, char[,] AlphaChar)
		{
			string newMessage = "";
			for (int i = 0; i < message.Length; i++)
			{
				for (int j = 0; j < AlphaChar.GetLength(0); j++)
				{
					for (int k = 0; k < AlphaChar.GetLength(1); k++)
					{
						if (AlphaChar[j, k] == message[i] || Char.ToUpper(AlphaChar[j, k]) == message[i])
						{
							int x = j - 1;
							int y = k;
							if (x == -1)
							{
								x = 3;
							}
							newMessage += AlphaChar[x, y];
							break;
						}
					}
				}
			}
			return newMessage;
		}

		public static char[,] ConvertTo2DCharArray(string str)
		{
			const int RowsCount = 4;//6
			const int ColumnsCount = 8;

			char[,] arr = new char[RowsCount, ColumnsCount];


			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					arr[i, j] = str.ToCharArray()[i * 8 + j];
				}
			}
			return arr;
		}
		public static string Trisemus(string message, char[,] AlphaChar)
		{
			string newMessage = "";
			for (int i = 0; i < message.Length; i++)
			{
				for (int j = 0; j < AlphaChar.GetLength(0); j++)
					for (int k = 0; k < AlphaChar.GetLength(1); k++)
						if (AlphaChar[j, k] == message[i] || Char.ToUpper(AlphaChar[j, k]) == message[i])
						{
							int x = j + 1;
							int y = k;
							if (x == 4)//6
							{
								x = 0;
							}
							newMessage += AlphaChar[x, y];
							break;
						}
			}
			return newMessage;
		}



		private void button2_Click(object sender, EventArgs e)
		{
			listBox2.Items.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(textBox3?.Text))
				{
					MessageBox.Show("Вы забыли ввести ключ");
					return;
				}
				if (string.IsNullOrEmpty(textBox4?.Text))
				{
					MessageBox.Show("Вы забыли ввести фразу для дешифровки");
					return;
				}
				string key = new string(textBox3.Text.ToUpper().Distinct().ToArray());
				string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя".ToUpper();
				alphabet = new string(alphabet.Except(key).ToArray());
				string newAlphabet = key + alphabet;
				char[,] AlphaChar = ConvertTo2DCharArray(newAlphabet);
				string message = textBox4.Text.ToUpper();
				string decryptedMessage = TrisemusDecrypt(message, AlphaChar);
				listBox4.Items.Add(decryptedMessage);
				string separation = new string('-', decryptedMessage.Length);
				listBox4.Items.Add(separation);
			}
			catch { MessageBox.Show("Ошибка, проверьте введеные данные"); }
		}

		private void button4_Click(object sender, EventArgs e)
		{
			listBox4.Items.Clear();
		}

		public static void saveListBoxToFile(ListBox listBox1, bool shifr)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
			if (shifr is true)
			{
				saveFileDialog1.FileName = "результат шифрования.txt";
			}
			else
			{
				saveFileDialog1.FileName = "результат дешифровки.txt";
			}
			saveFileDialog1.Title = "Save text File";
			saveFileDialog1.ShowDialog();
			if (saveFileDialog1.FileName != "")
			{
				using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
				{
					foreach (var item in listBox1.Items)
					{
						sw.WriteLine(item.ToString());
					}
				}
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			saveListBoxToFile(listBox2, true);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			saveListBoxToFile(listBox4, false);
		}
	}
}