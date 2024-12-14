using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckProxy : Form
{
	[CompilerGenerated]
	private sealed class B5935280
	{
		public int E730AAA1;

		public int int_0;

		public fTienIchCheckProxy fTienIchCheckProxy_0;
	}

	[CompilerGenerated]
	private sealed class Class85
	{
		public string A08B2824;

		public B5935280 F282C88F;

		internal void method_0()
		{
			if (F282C88F.fTienIchCheckProxy_0.method_2(A08B2824, F282C88F.E730AAA1))
			{
				F282C88F.fTienIchCheckProxy_0.method_1(F282C88F.fTienIchCheckProxy_0.txtDaTao, A08B2824);
			}
			else
			{
				F282C88F.fTienIchCheckProxy_0.method_1(F282C88F.fTienIchCheckProxy_0.txtChuaTao, A08B2824);
			}
			Interlocked.Decrement(ref F282C88F.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class B79C06AF
	{
		public RichTextBox AD9B8681;

		public string string_0;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox aD9B = AD9B8681;
			aD9B.Text = aD9B.Text + string_0 + "\r\n";
		}
	}

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl B420B836;

	private ToolTip F6863282;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button button2;

	private PictureBox pictureBox1;

	private Button btnMinimize;

	private BunifuCustomLabel lblTitle;

	private Button btnAdd;

	private RichTextBox txtInput;

	private GroupBox grDaTao;

	private RichTextBox txtDaTao;

	private GroupBox DF33E011;

	private GroupBox grChuaTao;

	private RichTextBox txtChuaTao;

	private Label lblStatus;

	private ComboBox cbbTypeProxy;

	private Label CB825D32;

	public fTienIchCheckProxy()
	{
		FC068095();
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(DF33E011);
		F7AB102E.smethod_1(CB825D32);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BC3B9DA8(object sender, EventArgs e)
	{
		try
		{
			int E730AAA1 = cbbTypeProxy.SelectedIndex;
			List<string> list = new List<string>();
			list = txtInput.Lines.ToList();
			int int_0 = 0;
			int num = 50;
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = true;
			});
			int num2 = 0;
			while (num2 < list.Count)
			{
				if (int_0 < num)
				{
					Interlocked.Increment(ref int_0);
					string A08B2824 = list[num2++];
					new Thread((ThreadStart)delegate
					{
						if (method_2(A08B2824, E730AAA1))
						{
							method_1(txtDaTao, A08B2824);
						}
						else
						{
							method_1(txtChuaTao, A08B2824);
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
			lblStatus.Invoke((MethodInvoker)delegate
			{
				lblStatus.Visible = false;
			});
			GClass29.smethod_0("Đã check xong!");
		}
		catch (Exception)
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void method_1(RichTextBox A33B703D, string string_0)
	{
		A33B703D.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = A33B703D;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		});
	}

	private bool method_2(string string_0, int int_0)
	{
		try
		{
			if (GClass8.smethod_59(string_0, int_0) != "")
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private void txtInput_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtInput.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			DF33E011.Text = string.Format(F7AB102E.smethod_0("Nhập Proxy ({0})"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void txtDaTao_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtDaTao.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			grDaTao.Text = "LIVE (" + e03C713E.Count + ")";
		}
		catch
		{
		}
	}

	private void B02D769A(object sender, PaintEventArgs e)
	{
	}

	private void fTienIchCheckProxy_Load(object sender, EventArgs e)
	{
		cbbTypeProxy.SelectedIndex = 0;
	}

	private void txtChuaTao_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtChuaTao.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			grChuaTao.Text = "DIE (" + e03C713E.Count + ")";
		}
		catch
		{
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void FC068095()
	{
		icontainer_0 = new Container();
		bunifuCards1 = new BunifuCards();
		panel1 = new Panel();
		lblStatus = new Label();
		grChuaTao = new GroupBox();
		txtChuaTao = new RichTextBox();
		grDaTao = new GroupBox();
		txtDaTao = new RichTextBox();
		DF33E011 = new GroupBox();
		cbbTypeProxy = new ComboBox();
		CB825D32 = new Label();
		txtInput = new RichTextBox();
		btnAdd = new Button();
		bunifuCards2 = new BunifuCards();
		pnlHeader = new Panel();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		btnMinimize = new Button();
		lblTitle = new BunifuCustomLabel();
		B420B836 = new BunifuDragControl(icontainer_0);
		F6863282 = new ToolTip(icontainer_0);
		panel1.SuspendLayout();
		grChuaTao.SuspendLayout();
		grDaTao.SuspendLayout();
		DF33E011.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
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
		bunifuCards1.Size = new Size(421, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(grChuaTao);
		panel1.Controls.Add(grDaTao);
		panel1.Controls.Add(DF33E011);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Margin = new Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new Size(750, 404);
		panel1.TabIndex = 37;
		panel1.Paint += B02D769A;
		lblStatus.AutoSize = true;
		lblStatus.ForeColor = Color.DarkGreen;
		lblStatus.Location = new Point(435, 59);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(71, 16);
		lblStatus.TabIndex = 52;
		lblStatus.Text = "Checking...";
		lblStatus.Visible = false;
		grChuaTao.Controls.Add(txtChuaTao);
		grChuaTao.ForeColor = Color.DarkRed;
		grChuaTao.Location = new Point(521, 91);
		grChuaTao.Name = "grChuaTao";
		grChuaTao.Size = new Size(221, 307);
		grChuaTao.TabIndex = 51;
		grChuaTao.TabStop = false;
		grChuaTao.Text = "DIE (0)";
		txtChuaTao.Dock = DockStyle.Fill;
		txtChuaTao.Location = new Point(3, 19);
		txtChuaTao.Name = "txtChuaTao";
		txtChuaTao.Size = new Size(215, 285);
		txtChuaTao.TabIndex = 50;
		txtChuaTao.Text = "";
		txtChuaTao.WordWrap = false;
		txtChuaTao.TextChanged += txtChuaTao_TextChanged;
		grDaTao.Controls.Add(txtDaTao);
		grDaTao.ForeColor = Color.DarkGreen;
		grDaTao.Location = new Point(294, 91);
		grDaTao.Name = "grDaTao";
		grDaTao.Size = new Size(221, 307);
		grDaTao.TabIndex = 51;
		grDaTao.TabStop = false;
		grDaTao.Text = "LIVE (0)";
		txtDaTao.Dock = DockStyle.Fill;
		txtDaTao.Location = new Point(3, 19);
		txtDaTao.Name = "txtDaTao";
		txtDaTao.Size = new Size(215, 285);
		txtDaTao.TabIndex = 50;
		txtDaTao.Text = "";
		txtDaTao.WordWrap = false;
		txtDaTao.TextChanged += txtDaTao_TextChanged;
		DF33E011.Controls.Add(cbbTypeProxy);
		DF33E011.Controls.Add(CB825D32);
		DF33E011.Controls.Add(txtInput);
		DF33E011.Location = new Point(6, 40);
		DF33E011.Name = "groupBox1";
		DF33E011.Size = new Size(282, 358);
		DF33E011.TabIndex = 51;
		DF33E011.TabStop = false;
		DF33E011.Text = "Nhập Proxy (0)";
		cbbTypeProxy.Cursor = Cursors.Hand;
		cbbTypeProxy.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbbTypeProxy.FormattingEnabled = true;
		cbbTypeProxy.Items.AddRange(new object[2] { "HTTP/HTTPS", "Sock5" });
		cbbTypeProxy.Location = new Point(83, 324);
		cbbTypeProxy.Name = "cbbTypeProxy";
		cbbTypeProxy.Size = new Size(193, 24);
		cbbTypeProxy.TabIndex = 126;
		CB825D32.AutoSize = true;
		CB825D32.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		CB825D32.Location = new Point(6, 327);
		CB825D32.Name = "label3";
		CB825D32.Size = new Size(71, 16);
		CB825D32.TabIndex = 125;
		CB825D32.Text = "Loa\u0323i Proxy:";
		txtInput.Location = new Point(9, 19);
		txtInput.Name = "txtInput";
		txtInput.Size = new Size(267, 299);
		txtInput.TabIndex = 50;
		txtInput.Text = "";
		txtInput.WordWrap = false;
		txtInput.TextChanged += txtInput_TextChanged;
		btnAdd.BackColor = Color.Green;
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(294, 49);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(135, 36);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Check";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += BC3B9DA8;
		bunifuCards2.BackColor = Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new Size(748, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button2);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(748, 31);
		pnlHeader.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new Point(717, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
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
		lblTitle.BackColor = Color.Transparent;
		lblTitle.Cursor = Cursors.SizeAll;
		lblTitle.Dock = DockStyle.Fill;
		lblTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblTitle.ForeColor = Color.Black;
		lblTitle.Location = new Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new Size(748, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Check Proxy";
		lblTitle.TextAlign = ContentAlignment.MiddleCenter;
		B420B836.Fixed = true;
		B420B836.Horizontal = true;
		B420B836.TargetControl = lblTitle;
		B420B836.Vertical = true;
		F6863282.AutomaticDelay = 0;
		F6863282.AutoPopDelay = 10000;
		F6863282.InitialDelay = 200;
		F6863282.ReshowDelay = 40;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(750, 404);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckProxy";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += fTienIchCheckProxy_Load;
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		grChuaTao.ResumeLayout(performLayout: false);
		grDaTao.ResumeLayout(performLayout: false);
		DF33E011.ResumeLayout(performLayout: false);
		DF33E011.PerformLayout();
		bunifuCards2.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void method_3()
	{
		lblStatus.Visible = true;
	}

	[CompilerGenerated]
	private void CBB00FBE()
	{
		lblStatus.Visible = false;
	}
}
