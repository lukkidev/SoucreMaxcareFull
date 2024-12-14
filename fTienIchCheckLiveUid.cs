using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchCheckLiveUid : Form
{
	[CompilerGenerated]
	private sealed class Class84
	{
		public int int_0;

		public fTienIchCheckLiveUid AC279324;
	}

	[CompilerGenerated]
	private sealed class A71C7919
	{
		public string string_0;

		public Class84 class84_0;

		internal void method_0()
		{
			string text = Class14.EABAA59C(string_0);
			if (text.StartsWith("0|"))
			{
				class84_0.AC279324.D9A890B6(class84_0.AC279324.txtDie, string_0);
			}
			else if (text.StartsWith("1|"))
			{
				class84_0.AC279324.D9A890B6(class84_0.AC279324.txtLive, string_0);
			}
			else
			{
				class84_0.AC279324.D9A890B6(class84_0.AC279324.txtKhongCheckDuoc, string_0);
			}
			Interlocked.Decrement(ref class84_0.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class BB973B2C
	{
		public RichTextBox richTextBox_0;

		public string A438789B;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + A438789B + "\r\n";
		}
	}

	private IContainer DE008126 = null;

	private BunifuCards bunifuCards1;

	private Panel E739F217;

	private BunifuDragControl FF0494A7;

	private ToolTip toolTip_0;

	private BunifuCards A681BA39;

	private Panel F0A50022;

	private Button A01D2196;

	private PictureBox DD85A80A;

	private BunifuCustomLabel F2B5CA90;

	private Button btnAdd;

	private RichTextBox txtInput;

	private GroupBox EA1A91B3;

	private RichTextBox txtLive;

	private GroupBox groupBox1;

	private GroupBox grChuaTao;

	private RichTextBox txtDie;

	private Label lblStatus;

	private GroupBox grKhongCheckDuoc;

	private RichTextBox txtKhongCheckDuoc;

	private NumericUpDown FB1D872F;

	private Label label2;

	public fTienIchCheckLiveUid()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(groupBox1);
	}

	private void A01D2196_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B18F04A5(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			list = txtInput.Lines.ToList();
			int int_0 = 0;
			int num = Convert.ToInt32(FB1D872F.Value);
			if (num == 0)
			{
				GClass29.smethod_0("Số luồng phải >0, vui lòng nhập lại!", 3);
				return;
			}
			if (list.Count < num)
			{
				num = list.Count;
			}
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
					string string_0 = list[num2++];
					new Thread((ThreadStart)delegate
					{
						string text = Class14.EABAA59C(string_0);
						if (text.StartsWith("0|"))
						{
							D9A890B6(txtDie, string_0);
						}
						else if (text.StartsWith("1|"))
						{
							D9A890B6(txtLive, string_0);
						}
						else
						{
							D9A890B6(txtKhongCheckDuoc, string_0);
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

	private void D9A890B6(RichTextBox richTextBox_0, string E487ADA8)
	{
		richTextBox_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + E487ADA8 + "\r\n";
		});
	}

	private void txtInput_TextChanged(object sender, EventArgs e)
	{
		GClass8.E814B702(txtInput, groupBox1);
	}

	private void B383A432(object sender, EventArgs e)
	{
		GClass8.E814B702(txtLive, EA1A91B3);
	}

	private void E739F217_Paint(object sender, PaintEventArgs e)
	{
	}

	private void D89D2DAF(object sender, EventArgs e)
	{
	}

	private void txtDie_TextChanged(object sender, EventArgs e)
	{
		GClass8.E814B702(txtDie, grChuaTao);
	}

	private void B71C8C36(object sender, EventArgs e)
	{
		GClass8.E814B702(txtKhongCheckDuoc, grKhongCheckDuoc);
	}

	protected override void Dispose(bool C69A0334)
	{
		if (C69A0334 && DE008126 != null)
		{
			DE008126.Dispose();
		}
		base.Dispose(C69A0334);
	}

	private void InitializeComponent()
	{
		DE008126 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		E739F217 = new System.Windows.Forms.Panel();
		FB1D872F = new System.Windows.Forms.NumericUpDown();
		label2 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		grKhongCheckDuoc = new System.Windows.Forms.GroupBox();
		txtKhongCheckDuoc = new System.Windows.Forms.RichTextBox();
		grChuaTao = new System.Windows.Forms.GroupBox();
		txtDie = new System.Windows.Forms.RichTextBox();
		EA1A91B3 = new System.Windows.Forms.GroupBox();
		txtLive = new System.Windows.Forms.RichTextBox();
		groupBox1 = new System.Windows.Forms.GroupBox();
		txtInput = new System.Windows.Forms.RichTextBox();
		btnAdd = new System.Windows.Forms.Button();
		A681BA39 = new Bunifu.Framework.UI.BunifuCards();
		F0A50022 = new System.Windows.Forms.Panel();
		A01D2196 = new System.Windows.Forms.Button();
		DD85A80A = new System.Windows.Forms.PictureBox();
		F2B5CA90 = new Bunifu.Framework.UI.BunifuCustomLabel();
		FF0494A7 = new Bunifu.Framework.UI.BunifuDragControl(DE008126);
		toolTip_0 = new System.Windows.Forms.ToolTip(DE008126);
		E739F217.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FB1D872F).BeginInit();
		grKhongCheckDuoc.SuspendLayout();
		grChuaTao.SuspendLayout();
		EA1A91B3.SuspendLayout();
		groupBox1.SuspendLayout();
		A681BA39.SuspendLayout();
		F0A50022.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DD85A80A).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(649, 47);
		bunifuCards1.TabIndex = 12;
		E739F217.BackColor = System.Drawing.Color.White;
		E739F217.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E739F217.Controls.Add(FB1D872F);
		E739F217.Controls.Add(label2);
		E739F217.Controls.Add(lblStatus);
		E739F217.Controls.Add(grKhongCheckDuoc);
		E739F217.Controls.Add(grChuaTao);
		E739F217.Controls.Add(EA1A91B3);
		E739F217.Controls.Add(groupBox1);
		E739F217.Controls.Add(btnAdd);
		E739F217.Controls.Add(A681BA39);
		E739F217.Dock = System.Windows.Forms.DockStyle.Fill;
		E739F217.Location = new System.Drawing.Point(0, 0);
		E739F217.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		E739F217.Name = "panel1";
		E739F217.Size = new System.Drawing.Size(978, 407);
		E739F217.TabIndex = 37;
		E739F217.Paint += new System.Windows.Forms.PaintEventHandler(E739F217_Paint);
		FB1D872F.Location = new System.Drawing.Point(360, 60);
		FB1D872F.Maximum = new decimal(new int[4] { 999999999, 0, 0, 0 });
		FB1D872F.Name = "nudThread";
		FB1D872F.Size = new System.Drawing.Size(69, 23);
		FB1D872F.TabIndex = 54;
		FB1D872F.Value = new decimal(new int[4] { 100, 0, 0, 0 });
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(294, 62);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(59, 16);
		label2.TabIndex = 53;
		label2.Text = "Threads:";
		lblStatus.AutoSize = true;
		lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		lblStatus.Location = new System.Drawing.Point(617, 62);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(70, 16);
		lblStatus.TabIndex = 52;
		lblStatus.Text = "Checking...";
		lblStatus.Visible = false;
		grKhongCheckDuoc.Controls.Add(txtKhongCheckDuoc);
		grKhongCheckDuoc.ForeColor = System.Drawing.Color.Red;
		grKhongCheckDuoc.Location = new System.Drawing.Point(748, 91);
		grKhongCheckDuoc.Name = "grKhongCheckDuoc";
		grKhongCheckDuoc.Size = new System.Drawing.Size(221, 307);
		grKhongCheckDuoc.TabIndex = 51;
		grKhongCheckDuoc.TabStop = false;
		grKhongCheckDuoc.Text = "Can't check (0)";
		txtKhongCheckDuoc.Dock = System.Windows.Forms.DockStyle.Fill;
		txtKhongCheckDuoc.Location = new System.Drawing.Point(3, 19);
		txtKhongCheckDuoc.Name = "txtKhongCheckDuoc";
		txtKhongCheckDuoc.Size = new System.Drawing.Size(215, 285);
		txtKhongCheckDuoc.TabIndex = 50;
		txtKhongCheckDuoc.Text = "";
		txtKhongCheckDuoc.WordWrap = false;
		txtKhongCheckDuoc.TextChanged += new System.EventHandler(B71C8C36);
		grChuaTao.Controls.Add(txtDie);
		grChuaTao.ForeColor = System.Drawing.Color.DarkRed;
		grChuaTao.Location = new System.Drawing.Point(521, 91);
		grChuaTao.Name = "grChuaTao";
		grChuaTao.Size = new System.Drawing.Size(221, 307);
		grChuaTao.TabIndex = 51;
		grChuaTao.TabStop = false;
		grChuaTao.Text = "DIE (0)";
		txtDie.Dock = System.Windows.Forms.DockStyle.Fill;
		txtDie.Location = new System.Drawing.Point(3, 19);
		txtDie.Name = "txtDie";
		txtDie.Size = new System.Drawing.Size(215, 285);
		txtDie.TabIndex = 50;
		txtDie.Text = "";
		txtDie.WordWrap = false;
		txtDie.TextChanged += new System.EventHandler(txtDie_TextChanged);
		EA1A91B3.Controls.Add(txtLive);
		EA1A91B3.ForeColor = System.Drawing.Color.DarkGreen;
		EA1A91B3.Location = new System.Drawing.Point(294, 91);
		EA1A91B3.Name = "grDaTao";
		EA1A91B3.Size = new System.Drawing.Size(221, 307);
		EA1A91B3.TabIndex = 51;
		EA1A91B3.TabStop = false;
		EA1A91B3.Text = "LIVE (0)";
		txtLive.Dock = System.Windows.Forms.DockStyle.Fill;
		txtLive.Location = new System.Drawing.Point(3, 19);
		txtLive.Name = "txtLive";
		txtLive.Size = new System.Drawing.Size(215, 285);
		txtLive.TabIndex = 50;
		txtLive.Text = "";
		txtLive.WordWrap = false;
		txtLive.TextChanged += new System.EventHandler(B383A432);
		groupBox1.Controls.Add(txtInput);
		groupBox1.Location = new System.Drawing.Point(6, 40);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new System.Drawing.Size(282, 358);
		groupBox1.TabIndex = 51;
		groupBox1.TabStop = false;
		groupBox1.Text = "Nhập Uid (0)";
		txtInput.Location = new System.Drawing.Point(9, 19);
		txtInput.Name = "txtInput";
		txtInput.Size = new System.Drawing.Size(267, 336);
		txtInput.TabIndex = 50;
		txtInput.Text = "";
		txtInput.WordWrap = false;
		txtInput.TextChanged += new System.EventHandler(txtInput_TextChanged);
		btnAdd.BackColor = System.Drawing.Color.Green;
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(476, 52);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(135, 36);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Check";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(B18F04A5);
		A681BA39.BackColor = System.Drawing.Color.White;
		A681BA39.BorderRadius = 0;
		A681BA39.BottomSahddow = true;
		A681BA39.color = System.Drawing.Color.SaddleBrown;
		A681BA39.Controls.Add(F0A50022);
		A681BA39.Dock = System.Windows.Forms.DockStyle.Top;
		A681BA39.LeftSahddow = false;
		A681BA39.Location = new System.Drawing.Point(0, 0);
		A681BA39.Name = "bunifuCards2";
		A681BA39.RightSahddow = true;
		A681BA39.ShadowDepth = 20;
		A681BA39.Size = new System.Drawing.Size(976, 37);
		A681BA39.TabIndex = 43;
		F0A50022.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F0A50022.BackColor = System.Drawing.Color.White;
		F0A50022.Controls.Add(A01D2196);
		F0A50022.Controls.Add(DD85A80A);
		F0A50022.Controls.Add(F2B5CA90);
		F0A50022.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F0A50022.Location = new System.Drawing.Point(0, 3);
		F0A50022.Name = "pnlHeader";
		F0A50022.Size = new System.Drawing.Size(976, 31);
		F0A50022.TabIndex = 9;
		A01D2196.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		A01D2196.Cursor = System.Windows.Forms.Cursors.Hand;
		A01D2196.FlatAppearance.BorderSize = 0;
		A01D2196.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A01D2196.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A01D2196.ForeColor = System.Drawing.Color.White;
		A01D2196.Image = C50FB39E.Bitmap_12;
		A01D2196.Location = new System.Drawing.Point(945, 1);
		A01D2196.Name = "button2";
		A01D2196.Size = new System.Drawing.Size(30, 30);
		A01D2196.TabIndex = 77;
		A01D2196.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A01D2196.UseVisualStyleBackColor = true;
		A01D2196.Click += new System.EventHandler(A01D2196_Click);
		DD85A80A.Cursor = System.Windows.Forms.Cursors.Default;
		DD85A80A.Image = C50FB39E.Bitmap_5;
		DD85A80A.Location = new System.Drawing.Point(3, 2);
		DD85A80A.Name = "pictureBox1";
		DD85A80A.Size = new System.Drawing.Size(34, 27);
		DD85A80A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		DD85A80A.TabIndex = 76;
		DD85A80A.TabStop = false;
		F2B5CA90.BackColor = System.Drawing.Color.Transparent;
		F2B5CA90.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F2B5CA90.Dock = System.Windows.Forms.DockStyle.Fill;
		F2B5CA90.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F2B5CA90.ForeColor = System.Drawing.Color.Black;
		F2B5CA90.Location = new System.Drawing.Point(0, 0);
		F2B5CA90.Name = "lblTitle";
		F2B5CA90.Size = new System.Drawing.Size(976, 31);
		F2B5CA90.TabIndex = 12;
		F2B5CA90.Text = "Check Live Uid";
		F2B5CA90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FF0494A7.Fixed = true;
		FF0494A7.Horizontal = true;
		FF0494A7.TargetControl = F2B5CA90;
		FF0494A7.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(978, 407);
		base.Controls.Add(E739F217);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchCheckLiveUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(D89D2DAF);
		E739F217.ResumeLayout(false);
		E739F217.PerformLayout();
		((System.ComponentModel.ISupportInitialize)FB1D872F).EndInit();
		grKhongCheckDuoc.ResumeLayout(false);
		grChuaTao.ResumeLayout(false);
		EA1A91B3.ResumeLayout(false);
		groupBox1.ResumeLayout(false);
		A681BA39.ResumeLayout(false);
		F0A50022.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DD85A80A).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void method_1()
	{
		lblStatus.Visible = true;
	}

	[CompilerGenerated]
	private void A297CE8A()
	{
		lblStatus.Visible = false;
	}
}
