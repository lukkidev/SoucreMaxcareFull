using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckImapHotmail : Form
{
	private enum Enum1
	{
		[Description("Check Connect Hotmail")]
		const_0,
		[Description("Get Code")]
		const_1
	}

	[CompilerGenerated]
	private sealed class F594693F
	{
		public fTienIchCheckImapHotmail FB2CC086;

		public Enum1 FA3D7D14;

		internal void F0931839()
		{
			FB2CC086.FF848C8A.Visible = true;
		}

		internal void method_0()
		{
			FB2CC086.FF848C8A.Visible = false;
		}
	}

	[CompilerGenerated]
	private sealed class E630B396
	{
		public string string_0;

		public int int_0;

		public F594693F f594693F_0;
	}

	[CompilerGenerated]
	private sealed class B1A34128
	{
		public string D438A9AE;

		public E630B396 e630B396_0;

		internal void C3B1540E()
		{
			try
			{
				if (e630B396_0.f594693F_0.FA3D7D14 == Enum1.const_0)
				{
					if (e630B396_0.f594693F_0.FB2CC086.method_2(D438A9AE))
					{
						e630B396_0.f594693F_0.FB2CC086.AE97E22B(e630B396_0.f594693F_0.FB2CC086.txtDaTao, D438A9AE);
					}
					else
					{
						e630B396_0.f594693F_0.FB2CC086.AE97E22B(e630B396_0.f594693F_0.FB2CC086.D71D5A30, D438A9AE);
					}
				}
				else if (e630B396_0.f594693F_0.FA3D7D14 == Enum1.const_1)
				{
					string text = e630B396_0.f594693F_0.FB2CC086.method_3(D438A9AE, e630B396_0.string_0);
					if (text.StartsWith("0|"))
					{
						e630B396_0.f594693F_0.FB2CC086.AE97E22B(e630B396_0.f594693F_0.FB2CC086.D71D5A30, D438A9AE);
					}
					else
					{
						e630B396_0.f594693F_0.FB2CC086.AE97E22B(e630B396_0.f594693F_0.FB2CC086.txtDaTao, D438A9AE + "|" + text.Split('|')[1]);
					}
				}
			}
			catch (Exception eD)
			{
				GClass29.smethod_0(eD, 2);
			}
			Interlocked.Decrement(ref e630B396_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class86
	{
		public RichTextBox richTextBox_0;

		public string string_0;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		}
	}

	private IContainer icontainer_0 = null;

	private BunifuCards AF9264A3;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel AF34400B;

	private Button btnAdd;

	private RichTextBox B8AD140F;

	private GroupBox grDaTao;

	private RichTextBox txtDaTao;

	private GroupBox groupBox1;

	private Button btnNhapTuFile;

	private TextBox FDB6421C;

	private RadioButton rbTuNhap;

	private RadioButton rbNhapTuFile;

	private GroupBox DF178AA5;

	private RichTextBox D71D5A30;

	private Label FF848C8A;

	private TextBox txtTypeGet;

	private Button A9B69603;

	public fTienIchCheckImapHotmail()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(rbNhapTuFile);
		F7AB102E.smethod_1(btnNhapTuFile);
		F7AB102E.smethod_1(rbTuNhap);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		method_1(Enum1.const_0);
	}

	private void method_1(Enum1 enum1_0)
	{
		try
		{
			List<string> list = new List<string>();
			string text = FDB6421C.Text.Trim();
			if (rbNhapTuFile.Checked)
			{
				if (text.EndsWith(".txt"))
				{
					if (!File.Exists(text))
					{
						GClass29.smethod_0("File dữ liệu nhập không tồn tại!", 2);
					}
				}
				else
				{
					GClass29.smethod_0("File nhập vào chỉ hỗ trợ đối với File (.txt)!", 2);
				}
			}
			if (rbNhapTuFile.Checked)
			{
				list = File.ReadAllLines(text).ToList();
			}
			else if (rbTuNhap.Checked)
			{
				list = B8AD140F.Lines.ToList();
			}
			string string_0 = txtTypeGet.Text.Trim();
			int int_0 = 0;
			int num = 50;
			FF848C8A.Invoke((MethodInvoker)delegate
			{
				FF848C8A.Visible = true;
			});
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (int_0 < num)
				{
					Interlocked.Increment(ref int_0);
					string D438A9AE = list[num2++];
					new Thread((ThreadStart)delegate
					{
						try
						{
							if (enum1_0 == Enum1.const_0)
							{
								if (method_2(D438A9AE))
								{
									AE97E22B(txtDaTao, D438A9AE);
								}
								else
								{
									AE97E22B(D71D5A30, D438A9AE);
								}
							}
							else if (enum1_0 == Enum1.const_1)
							{
								string text2 = method_3(D438A9AE, string_0);
								if (text2.StartsWith("0|"))
								{
									AE97E22B(D71D5A30, D438A9AE);
								}
								else
								{
									AE97E22B(txtDaTao, D438A9AE + "|" + text2.Split('|')[1]);
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
			FF848C8A.Invoke((MethodInvoker)delegate
			{
				FF848C8A.Visible = false;
			});
			GClass29.smethod_0("Đã check xong!");
		}
		catch (Exception)
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void AE97E22B(RichTextBox richTextBox_0, string string_0)
	{
		richTextBox_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		});
	}

	private bool method_2(string B108A50D)
	{
		try
		{
			string[] array = B108A50D.Split('|');
			string text = array[0];
			string text2 = array[1];
			if (!(text == "") && !(text2 == ""))
			{
				string f215712E = "";
				if (array.Length > 3)
				{
					f215712E = array[2] + "|" + array[3];
				}
				return GClass21.A3BD3C81(text, text2, f215712E);
			}
			return false;
		}
		catch
		{
		}
		return false;
	}

	private string method_3(string string_0, string string_1)
	{
		try
		{
			string[] array = string_0.Split('|');
			string text = array[0];
			string text2 = array[1];
			if (!(text == "") && !(text2 == ""))
			{
				string text3 = GClass21.smethod_0(Convert.ToInt32(string_1), text, text2, 0, "", "");
				if (text3 == "fail")
				{
					return "0|";
				}
				return "1|" + text3;
			}
			return "0|";
		}
		catch
		{
		}
		return "";
	}

	private void B8AD140F_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = B8AD140F.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			rbTuNhap.Text = string.Format(F7AB102E.smethod_0("Tự nhập ({0})"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void rbNhapTuFile_CheckedChanged(object sender, EventArgs e)
	{
		FDB6421C.Enabled = rbNhapTuFile.Checked;
		btnNhapTuFile.Enabled = rbNhapTuFile.Checked;
	}

	private void AABE1A8B(object sender, EventArgs e)
	{
		B8AD140F.Enabled = rbTuNhap.Checked;
	}

	private void btnNhapTuFile_Click(object sender, EventArgs e)
	{
		FDB6421C.Text = GClass8.AD2D2BA4();
	}

	private void txtDaTao_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtDaTao.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			grDaTao.Text = string.Format(F7AB102E.smethod_0("Live ({0})"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void F91B749F(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchCheckImapHotmail_Load(object sender, EventArgs e)
	{
		rbNhapTuFile_CheckedChanged(null, null);
		AABE1A8B(null, null);
	}

	private void CB93AAA4(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = D71D5A30.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			DF178AA5.Text = string.Format(F7AB102E.smethod_0("Die ({0})"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void E439503A(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
		{
			A9B69603.Visible = true;
			txtTypeGet.Visible = true;
		}
	}

	private void A9B69603_Click(object sender, EventArgs e)
	{
		method_1(Enum1.const_1);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		AF9264A3 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		FF848C8A = new System.Windows.Forms.Label();
		DF178AA5 = new System.Windows.Forms.GroupBox();
		D71D5A30 = new System.Windows.Forms.RichTextBox();
		txtTypeGet = new System.Windows.Forms.TextBox();
		grDaTao = new System.Windows.Forms.GroupBox();
		txtDaTao = new System.Windows.Forms.RichTextBox();
		groupBox1 = new System.Windows.Forms.GroupBox();
		btnNhapTuFile = new System.Windows.Forms.Button();
		B8AD140F = new System.Windows.Forms.RichTextBox();
		FDB6421C = new System.Windows.Forms.TextBox();
		rbTuNhap = new System.Windows.Forms.RadioButton();
		rbNhapTuFile = new System.Windows.Forms.RadioButton();
		A9B69603 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		button2 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		AF34400B = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		DF178AA5.SuspendLayout();
		grDaTao.SuspendLayout();
		groupBox1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		AF9264A3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		AF9264A3.BackColor = System.Drawing.Color.White;
		AF9264A3.BorderRadius = 5;
		AF9264A3.BottomSahddow = true;
		AF9264A3.color = System.Drawing.Color.SaddleBrown;
		AF9264A3.LeftSahddow = false;
		AF9264A3.Location = new System.Drawing.Point(0, 0);
		AF9264A3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		AF9264A3.Name = "bunifuCards1";
		AF9264A3.RightSahddow = true;
		AF9264A3.ShadowDepth = 20;
		AF9264A3.Size = new System.Drawing.Size(466, 47);
		AF9264A3.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(FF848C8A);
		panel1.Controls.Add(DF178AA5);
		panel1.Controls.Add(txtTypeGet);
		panel1.Controls.Add(grDaTao);
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(A9B69603);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(795, 404);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(F91B749F);
		FF848C8A.AutoSize = true;
		FF848C8A.ForeColor = System.Drawing.Color.DarkGreen;
		FF848C8A.Location = new System.Drawing.Point(480, 59);
		FF848C8A.Name = "lblStatus";
		FF848C8A.Size = new System.Drawing.Size(70, 16);
		FF848C8A.TabIndex = 52;
		FF848C8A.Text = "Checking...";
		FF848C8A.Visible = false;
		DF178AA5.Controls.Add(D71D5A30);
		DF178AA5.ForeColor = System.Drawing.Color.DarkRed;
		DF178AA5.Location = new System.Drawing.Point(566, 91);
		DF178AA5.Name = "grChuaTao";
		DF178AA5.Size = new System.Drawing.Size(221, 307);
		DF178AA5.TabIndex = 51;
		DF178AA5.TabStop = false;
		DF178AA5.Text = "Die (0)";
		D71D5A30.Dock = System.Windows.Forms.DockStyle.Fill;
		D71D5A30.Location = new System.Drawing.Point(3, 19);
		D71D5A30.Name = "txtChuaTao";
		D71D5A30.Size = new System.Drawing.Size(215, 285);
		D71D5A30.TabIndex = 50;
		D71D5A30.Text = "";
		D71D5A30.WordWrap = false;
		D71D5A30.TextChanged += new System.EventHandler(CB93AAA4);
		txtTypeGet.Location = new System.Drawing.Point(675, 56);
		txtTypeGet.Name = "txtTypeGet";
		txtTypeGet.Size = new System.Drawing.Size(28, 23);
		txtTypeGet.TabIndex = 1;
		txtTypeGet.Text = "1";
		txtTypeGet.Visible = false;
		grDaTao.Controls.Add(txtDaTao);
		grDaTao.ForeColor = System.Drawing.Color.DarkGreen;
		grDaTao.Location = new System.Drawing.Point(339, 91);
		grDaTao.Name = "grDaTao";
		grDaTao.Size = new System.Drawing.Size(221, 307);
		grDaTao.TabIndex = 51;
		grDaTao.TabStop = false;
		grDaTao.Text = "Live (0)";
		txtDaTao.Dock = System.Windows.Forms.DockStyle.Fill;
		txtDaTao.Location = new System.Drawing.Point(3, 19);
		txtDaTao.Name = "txtDaTao";
		txtDaTao.Size = new System.Drawing.Size(215, 285);
		txtDaTao.TabIndex = 50;
		txtDaTao.Text = "";
		txtDaTao.WordWrap = false;
		txtDaTao.TextChanged += new System.EventHandler(txtDaTao_TextChanged);
		groupBox1.Controls.Add(btnNhapTuFile);
		groupBox1.Controls.Add(B8AD140F);
		groupBox1.Controls.Add(FDB6421C);
		groupBox1.Controls.Add(rbTuNhap);
		groupBox1.Controls.Add(rbNhapTuFile);
		groupBox1.Location = new System.Drawing.Point(6, 40);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(316, 358);
		groupBox1.TabIndex = 51;
		groupBox1.TabStop = false;
		groupBox1.Text = "Input: Email|Pass mail";
		btnNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapTuFile.Location = new System.Drawing.Point(243, 21);
		btnNhapTuFile.Name = "btnNhapTuFile";
		btnNhapTuFile.Size = new System.Drawing.Size(64, 26);
		btnNhapTuFile.TabIndex = 2;
		btnNhapTuFile.Text = "Chọn";
		btnNhapTuFile.Click += new System.EventHandler(btnNhapTuFile_Click);
		B8AD140F.Location = new System.Drawing.Point(30, 75);
		B8AD140F.Name = "txtInput";
		B8AD140F.Size = new System.Drawing.Size(277, 277);
		B8AD140F.TabIndex = 50;
		B8AD140F.Text = "";
		B8AD140F.WordWrap = false;
		B8AD140F.TextChanged += new System.EventHandler(B8AD140F_TextChanged);
		FDB6421C.Location = new System.Drawing.Point(110, 22);
		FDB6421C.Name = "txtNhapTuFile";
		FDB6421C.Size = new System.Drawing.Size(127, 23);
		FDB6421C.TabIndex = 1;
		rbTuNhap.AutoSize = true;
		rbTuNhap.Checked = true;
		rbTuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
		rbTuNhap.Location = new System.Drawing.Point(9, 49);
		rbTuNhap.Name = "rbTuNhap";
		rbTuNhap.Size = new System.Drawing.Size(94, 20);
		rbTuNhap.TabIndex = 0;
		rbTuNhap.TabStop = true;
		rbTuNhap.Text = "Tự nhập (0)";
		rbTuNhap.UseVisualStyleBackColor = true;
		rbTuNhap.CheckedChanged += new System.EventHandler(AABE1A8B);
		rbNhapTuFile.AutoSize = true;
		rbNhapTuFile.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNhapTuFile.Location = new System.Drawing.Point(9, 23);
		rbNhapTuFile.Name = "rbNhapTuFile";
		rbNhapTuFile.Size = new System.Drawing.Size(94, 20);
		rbNhapTuFile.TabIndex = 0;
		rbNhapTuFile.Text = "Nhập từ File";
		rbNhapTuFile.UseVisualStyleBackColor = true;
		rbNhapTuFile.CheckedChanged += new System.EventHandler(rbNhapTuFile_CheckedChanged);
		A9B69603.BackColor = System.Drawing.Color.Green;
		A9B69603.Cursor = System.Windows.Forms.Cursors.Hand;
		A9B69603.FlatAppearance.BorderSize = 0;
		A9B69603.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A9B69603.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A9B69603.ForeColor = System.Drawing.Color.White;
		A9B69603.Location = new System.Drawing.Point(709, 50);
		A9B69603.Name = "btnGetCode";
		A9B69603.Size = new System.Drawing.Size(75, 36);
		A9B69603.TabIndex = 45;
		A9B69603.Text = "Get Code";
		A9B69603.UseVisualStyleBackColor = false;
		A9B69603.Visible = false;
		A9B69603.Click += new System.EventHandler(A9B69603_Click);
		btnAdd.BackColor = System.Drawing.Color.Green;
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(339, 49);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(135, 36);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Check";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(793, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(AF34400B);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(793, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button2.ForeColor = System.Drawing.Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new System.Drawing.Point(762, 1);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(E439503A);
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Location = new System.Drawing.Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		AF34400B.BackColor = System.Drawing.Color.Transparent;
		AF34400B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		AF34400B.Dock = System.Windows.Forms.DockStyle.Fill;
		AF34400B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AF34400B.ForeColor = System.Drawing.Color.Black;
		AF34400B.Location = new System.Drawing.Point(0, 0);
		AF34400B.Name = "lblTitle";
		AF34400B.Size = new System.Drawing.Size(793, 31);
		AF34400B.TabIndex = 12;
		AF34400B.Text = "Check có thể kết nối Email bằng Imap không?";
		AF34400B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = AF34400B;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(795, 404);
		base.Controls.Add(panel1);
		base.Controls.Add(AF9264A3);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckImapHotmail";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fTienIchCheckImapHotmail_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		DF178AA5.ResumeLayout(false);
		grDaTao.ResumeLayout(false);
		groupBox1.ResumeLayout(false);
		groupBox1.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}
}
