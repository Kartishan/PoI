namespace laba1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(89, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Зашифровать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(58, 49);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(144, 23);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(58, 93);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(144, 23);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(58, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Введите ключ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Введите необходимый текст";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(276, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Алфавит";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(63, 283);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(139, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Очистить результаты";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.HorizontalScrollbar = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(276, 49);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(176, 94);
			this.listBox1.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(58, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "Результат";
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.HorizontalScrollbar = true;
			this.listBox2.ItemHeight = 15;
			this.listBox2.Location = new System.Drawing.Point(58, 183);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(144, 94);
			this.listBox2.TabIndex = 11;
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.HorizontalScrollbar = true;
			this.listBox3.ItemHeight = 15;
			this.listBox3.Location = new System.Drawing.Point(276, 183);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(176, 94);
			this.listBox3.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(276, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 15);
			this.label5.TabIndex = 13;
			this.label5.Text = "Буква из алфавита равна ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(54, 452);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(162, 15);
			this.label6.TabIndex = 18;
			this.label6.Text = "Введите необходимый текст";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(54, 408);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 15);
			this.label7.TabIndex = 17;
			this.label7.Text = "Введите ключ";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(54, 426);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(144, 23);
			this.textBox3.TabIndex = 16;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(54, 470);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(144, 23);
			this.textBox4.TabIndex = 15;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(85, 499);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "Дешифровать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(272, 390);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 15);
			this.label8.TabIndex = 20;
			this.label8.Text = "Результат";
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.HorizontalScrollbar = true;
			this.listBox4.ItemHeight = 15;
			this.listBox4.Location = new System.Drawing.Point(272, 408);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(176, 94);
			this.listBox4.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(196, 366);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 15);
			this.label9.TabIndex = 21;
			this.label9.Text = "Дешифратор";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(279, 508);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(139, 23);
			this.button4.TabIndex = 22;
			this.button4.Text = "Очистить результаты";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(142, 312);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(222, 23);
			this.button5.TabIndex = 23;
			this.button5.Text = "Сохранить результаты шифрования";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(131, 551);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(222, 23);
			this.button6.TabIndex = 24;
			this.button6.Text = "Сохранить результаты дешифратора";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(196, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 15);
			this.label10.TabIndex = 25;
			this.label10.Text = "Шифратор";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 606);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Трисемус";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button button2;
		private ListBox listBox1;
		private Label label4;
		private ListBox listBox2;
		private ListBox listBox3;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox textBox3;
		private TextBox textBox4;
		private Button button3;
		private Label label8;
		private ListBox listBox4;
		private Label label9;
		private Button button4;
		private Button button5;
		private Button button6;
		private Label label10;
	}
}