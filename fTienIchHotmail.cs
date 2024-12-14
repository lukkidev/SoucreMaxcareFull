using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchHotmail : Form
{
	[CompilerGenerated]
	private sealed class Class82
	{
		public string D73137A0;

		public int int_0;

		public fTienIchHotmail CF306F37;
	}

	[CompilerGenerated]
	private sealed class Class83
	{
		public string string_0;

		public Class82 D72A71B6;

		internal void method_0()
		{
			try
			{
				switch (D72A71B6.D73137A0)
				{
				case "5":
				{
					string text5 = GClass21.smethod_2(1, string_0.Split('|')[0], string_0.Split('|')[2] + "|" + string_0.Split('|')[3], 0);
					if (!text5.Contains("fail") && !(text5 == ""))
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtDaTao, string_0 + "|" + text5);
					}
					else
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtChuaTao, string_0 + "|" + text5);
					}
					break;
				}
				case "4":
				{
					string text2 = GClass21.smethod_2(0, string_0.Split('|')[0], string_0.Split('|')[2] + "|" + string_0.Split('|')[3], 0);
					if (!text2.Contains("fail") && !(text2 == ""))
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtDaTao, string_0 + "|" + text2);
					}
					else
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtChuaTao, string_0 + "|" + text2);
					}
					break;
				}
				case "3":
				{
					string text6 = GClass21.CE9B89B6(string_0.Split('|')[0], string_0.Split('|')[1]);
					if (text6 == "")
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtChuaTao, string_0 + "|");
						break;
					}
					string text7 = GClass21.CF2750A3(text6);
					if (text7 == "")
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtChuaTao, string_0 + "|" + text7);
					}
					else
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtDaTao, string_0 + "|" + text7);
					}
					break;
				}
				case "2":
				{
					string text3 = GClass21.smethod_0(1, string_0.Split('|')[0], string_0.Split('|')[1], 0, "", "");
					if (!text3.Contains("fail") && !(text3 == ""))
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtDaTao, string_0 + "|" + text3);
					}
					else
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtChuaTao, string_0 + "|" + text3);
					}
					break;
				}
				case "1":
				{
					string text4 = GClass21.smethod_0(0, string_0.Split('|')[0], string_0.Split('|')[1], 0, "", "");
					if (!text4.Contains("fail") && !(text4 == ""))
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtDaTao, string_0 + "|" + text4);
					}
					else
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtChuaTao, string_0 + "|" + text4);
					}
					break;
				}
				case "0":
				{
					string text = GClass21.CE9B89B6(string_0.Split('|')[0], string_0.Split('|')[1]);
					if (text == "")
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtChuaTao, string_0 + "|");
					}
					else
					{
						D72A71B6.CF306F37.method_1(D72A71B6.CF306F37.txtDaTao, string_0 + "|" + text);
					}
					break;
				}
				}
			}
			catch (Exception eD)
			{
				GClass29.smethod_0(eD, 2);
			}
			Interlocked.Decrement(ref D72A71B6.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class AE2D0782
	{
		public RichTextBox richTextBox_0;

		public string ABABD722;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + ABABD722 + "\r\n";
		}
	}

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel B9107900;

	private BunifuDragControl F598FE81;

	private ToolTip B78B30B6;

	private BunifuCards bunifuCards2;

	private Panel CB18433F;

	private Button button2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel C28F7F2B;

	private Button C8B80CBA;

	private RichTextBox txtInput;

	private GroupBox grDaTao;

	private RichTextBox txtDaTao;

	private GroupBox groupBox1;

	private ComboBox cbbFunctions;

	private Label label1;

	private GroupBox grChuaTao;

	private RichTextBox txtChuaTao;

	public fTienIchHotmail()
	{
		F7A7E001();
		F7AB102E.D6B70A35(this);
		method_0();
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Login hotmail");
		dictionary.Add("1", "Get otp Add mail");
		dictionary.Add("2", "Get otp Checkpoint");
		dictionary.Add("3", "Get OAuth2");
		dictionary.Add("4", "Get otp Add mail OAuth2");
		dictionary.Add("5", "Get otp Checkpoint OAuth2");
		GClass8.smethod_23(cbbFunctions, dictionary);
	}

	private void FD97CC28(object sender, EventArgs e)
	{
		Close();
	}

	private void BB34E981(object sender, EventArgs e)
	{
		A51C3E31();
	}

	private void A51C3E31()
	{
		try
		{
			List<string> list = txtInput.smethod_6();
			string D73137A0 = cbbFunctions.SelectedValue.ToString();
			int int_0 = 0;
			int num = 50;
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (int_0 < num)
				{
					Interlocked.Increment(ref int_0);
					string string_0 = list[num2++];
					new Thread((ThreadStart)delegate
					{
						try
						{
							switch (D73137A0)
							{
							case "5":
							{
								string text5 = GClass21.smethod_2(1, string_0.Split('|')[0], string_0.Split('|')[2] + "|" + string_0.Split('|')[3], 0);
								if (!text5.Contains("fail") && !(text5 == ""))
								{
									method_1(txtDaTao, string_0 + "|" + text5);
								}
								else
								{
									method_1(txtChuaTao, string_0 + "|" + text5);
								}
								break;
							}
							case "4":
							{
								string text2 = GClass21.smethod_2(0, string_0.Split('|')[0], string_0.Split('|')[2] + "|" + string_0.Split('|')[3], 0);
								if (!text2.Contains("fail") && !(text2 == ""))
								{
									method_1(txtDaTao, string_0 + "|" + text2);
								}
								else
								{
									method_1(txtChuaTao, string_0 + "|" + text2);
								}
								break;
							}
							case "3":
							{
								string text6 = GClass21.CE9B89B6(string_0.Split('|')[0], string_0.Split('|')[1]);
								if (text6 == "")
								{
									method_1(txtChuaTao, string_0 + "|");
								}
								else
								{
									string text7 = GClass21.CF2750A3(text6);
									if (text7 == "")
									{
										method_1(txtChuaTao, string_0 + "|" + text7);
									}
									else
									{
										method_1(txtDaTao, string_0 + "|" + text7);
									}
								}
								break;
							}
							case "2":
							{
								string text3 = GClass21.smethod_0(1, string_0.Split('|')[0], string_0.Split('|')[1], 0, "", "");
								if (!text3.Contains("fail") && !(text3 == ""))
								{
									method_1(txtDaTao, string_0 + "|" + text3);
								}
								else
								{
									method_1(txtChuaTao, string_0 + "|" + text3);
								}
								break;
							}
							case "1":
							{
								string text4 = GClass21.smethod_0(0, string_0.Split('|')[0], string_0.Split('|')[1], 0, "", "");
								if (!text4.Contains("fail") && !(text4 == ""))
								{
									method_1(txtDaTao, string_0 + "|" + text4);
								}
								else
								{
									method_1(txtChuaTao, string_0 + "|" + text4);
								}
								break;
							}
							case "0":
							{
								string text = GClass21.CE9B89B6(string_0.Split('|')[0], string_0.Split('|')[1]);
								if (text == "")
								{
									method_1(txtChuaTao, string_0 + "|");
								}
								else
								{
									method_1(txtDaTao, string_0 + "|" + text);
								}
								break;
							}
							}
						}
						catch (Exception eD)
						{
							GClass29.smethod_0(eD, 2);
						}
						Interlocked.Decrement(ref int_0);
					}).Start();
				}
				else
				{
					Application.DoEvents();
					GClass8.smethod_53(1.0);
				}
			}
			while (int_0 > 0)
			{
				GClass8.smethod_53(1.0);
			}
			GClass29.smethod_0("Đã check xong!");
		}
		catch (Exception)
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void method_1(RichTextBox richTextBox_0, string string_0)
	{
		richTextBox_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		});
	}

	private void txtDaTao_TextChanged(object sender, EventArgs e)
	{
		GClass8.E814B702(txtDaTao, grDaTao);
	}

	private void B9107900_Paint(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchHotmail_Load(object sender, EventArgs e)
	{
	}

	private void txtChuaTao_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtChuaTao.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			grChuaTao.Text = string.Format(F7AB102E.smethod_0("Die ({0})"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void F7A7E001()
	{
		icontainer_0 = new Container();
		bunifuCards1 = new BunifuCards();
		B9107900 = new Panel();
		cbbFunctions = new ComboBox();
		label1 = new Label();
		grChuaTao = new GroupBox();
		txtChuaTao = new RichTextBox();
		grDaTao = new GroupBox();
		txtDaTao = new RichTextBox();
		groupBox1 = new GroupBox();
		txtInput = new RichTextBox();
		C8B80CBA = new Button();
		bunifuCards2 = new BunifuCards();
		CB18433F = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		C28F7F2B = new BunifuCustomLabel();
		F598FE81 = new BunifuDragControl(icontainer_0);
		B78B30B6 = new ToolTip(icontainer_0);
		B9107900.SuspendLayout();
		grChuaTao.SuspendLayout();
		grDaTao.SuspendLayout();
		groupBox1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		CB18433F.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Margin = new Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(469, 47);
		bunifuCards1.TabIndex = 12;
		B9107900.BackColor = Color.White;
		B9107900.BorderStyle = BorderStyle.FixedSingle;
		B9107900.Controls.Add(cbbFunctions);
		B9107900.Controls.Add(label1);
		B9107900.Controls.Add(grChuaTao);
		B9107900.Controls.Add(grDaTao);
		B9107900.Controls.Add(groupBox1);
		B9107900.Controls.Add(C8B80CBA);
		B9107900.Controls.Add(bunifuCards2);
		B9107900.Dock = DockStyle.Fill;
		B9107900.Location = new Point(0, 0);
		B9107900.Margin = new Padding(3, 4, 3, 4);
		B9107900.Name = "panel1";
		B9107900.Size = new Size(798, 405);
		B9107900.TabIndex = 37;
		B9107900.Paint += B9107900_Paint;
		cbbFunctions.Cursor = Cursors.Hand;
		cbbFunctions.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbFunctions.FormattingEnabled = true;
		cbbFunctions.Location = new Point(405, 50);
		cbbFunctions.Name = "cbbFunctions";
		cbbFunctions.Size = new Size(265, 24);
		cbbFunctions.TabIndex = 54;
		label1.AutoSize = true;
		label1.Location = new Point(339, 53);
		label1.Name = "label1";
		label1.Size = new Size(60, 16);
		label1.TabIndex = 53;
		label1.Text = "Function:";
		grChuaTao.Controls.Add(txtChuaTao);
		grChuaTao.ForeColor = Color.DarkRed;
		grChuaTao.Location = new Point(339, 251);
		grChuaTao.Name = "grChuaTao";
		grChuaTao.Size = new Size(448, 147);
		grChuaTao.TabIndex = 51;
		grChuaTao.TabStop = false;
		grChuaTao.Text = "Fail (0)";
		txtChuaTao.Dock = DockStyle.Fill;
		txtChuaTao.Location = new Point(3, 19);
		txtChuaTao.Name = "txtChuaTao";
		txtChuaTao.Size = new Size(442, 125);
		txtChuaTao.TabIndex = 50;
		txtChuaTao.Text = "";
		txtChuaTao.WordWrap = false;
		txtChuaTao.TextChanged += txtChuaTao_TextChanged;
		grDaTao.Controls.Add(txtDaTao);
		grDaTao.ForeColor = Color.DarkGreen;
		grDaTao.Location = new Point(339, 91);
		grDaTao.Name = "grDaTao";
		grDaTao.Size = new Size(448, 154);
		grDaTao.TabIndex = 51;
		grDaTao.TabStop = false;
		grDaTao.Text = "Success (0)";
		txtDaTao.Dock = DockStyle.Fill;
		txtDaTao.Location = new Point(3, 19);
		txtDaTao.Name = "txtDaTao";
		txtDaTao.Size = new Size(442, 132);
		txtDaTao.TabIndex = 50;
		txtDaTao.Text = "";
		txtDaTao.WordWrap = false;
		txtDaTao.TextChanged += txtDaTao_TextChanged;
		groupBox1.Controls.Add(txtInput);
		groupBox1.Location = new Point(6, 40);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(316, 358);
		groupBox1.TabIndex = 51;
		groupBox1.TabStop = false;
		groupBox1.Text = "Input: Email|Pass mail";
		txtInput.Location = new Point(8, 22);
		txtInput.Name = "txtInput";
		txtInput.Size = new Size(301, 330);
		txtInput.TabIndex = 50;
		txtInput.Text = "";
		txtInput.WordWrap = false;
		C8B80CBA.BackColor = Color.Green;
		C8B80CBA.Cursor = Cursors.Hand;
		C8B80CBA.FlatAppearance.BorderSize = 0;
		C8B80CBA.FlatStyle = FlatStyle.Flat;
		C8B80CBA.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C8B80CBA.ForeColor = Color.White;
		C8B80CBA.Location = new Point(676, 44);
		C8B80CBA.Name = "btnAdd";
		C8B80CBA.Size = new Size(111, 36);
		C8B80CBA.TabIndex = 45;
		C8B80CBA.Text = "Check";
		C8B80CBA.UseVisualStyleBackColor = false;
		C8B80CBA.Click += BB34E981;
		bunifuCards2.BackColor = Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = Color.SaddleBrown;
		bunifuCards2.Controls.Add(CB18433F);
		bunifuCards2.Dock = DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new Size(796, 37);
		bunifuCards2.TabIndex = 43;
		CB18433F.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		CB18433F.BackColor = Color.White;
		CB18433F.Controls.Add(button2);
		CB18433F.Controls.Add(pictureBox1);
		CB18433F.Controls.Add(btnMinimize);
		CB18433F.Controls.Add(C28F7F2B);
		CB18433F.Cursor = Cursors.SizeAll;
		CB18433F.Location = new Point(0, 3);
		CB18433F.Name = "pnlHeader";
		CB18433F.Size = new Size(796, 31);
		CB18433F.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new Point(765, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += FD97CC28;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += pictureBox1_Click;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Location = new Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		C28F7F2B.BackColor = Color.Transparent;
		C28F7F2B.Cursor = Cursors.SizeAll;
		C28F7F2B.Dock = DockStyle.Fill;
		C28F7F2B.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C28F7F2B.ForeColor = Color.Black;
		C28F7F2B.Location = new Point(0, 0);
		C28F7F2B.Name = "lblTitle";
		C28F7F2B.Size = new Size(796, 31);
		C28F7F2B.TabIndex = 12;
		C28F7F2B.Text = "Hotmail";
		C28F7F2B.TextAlign = ContentAlignment.MiddleCenter;
		F598FE81.Fixed = true;
		F598FE81.Horizontal = true;
		F598FE81.TargetControl = C28F7F2B;
		F598FE81.Vertical = true;
		B78B30B6.AutomaticDelay = 0;
		B78B30B6.AutoPopDelay = 10000;
		B78B30B6.InitialDelay = 200;
		B78B30B6.ReshowDelay = 40;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(798, 405);
		base.Controls.Add(B9107900);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fTienIchHotmail";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += fTienIchHotmail_Load;
		B9107900.ResumeLayout(performLayout: false);
		B9107900.PerformLayout();
		grChuaTao.ResumeLayout(performLayout: false);
		grDaTao.ResumeLayout(performLayout: false);
		groupBox1.ResumeLayout(performLayout: false);
		bunifuCards2.ResumeLayout(performLayout: false);
		CB18433F.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
