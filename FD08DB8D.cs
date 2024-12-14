using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class FD08DB8D : Form
{
	[CompilerGenerated]
	private sealed class F1BDEE9C
	{
		public string string_0;

		public string A6066D10;

		public string string_1;

		public FD08DB8D BF0564B6;

		internal void E7A15CAB()
		{
			EB8CD8A9 CS_0024_003C_003E8__locals0 = new EB8CD8A9
			{
				A298D439 = this,
				FEB5613A = ""
			};
			try
			{
				string b881C = Class14.smethod_5(string_0);
				b881C = GClass8.CF09EFB3(b881C);
				CS_0024_003C_003E8__locals0.FEB5613A = GClass8.smethod_10(GetJobs2(GClass8.smethod_11(""), GClass8.smethod_11(A6066D10), GClass8.smethod_11(string_0), GClass8.smethod_11(b881C), GClass8.smethod_11(""), GClass8.smethod_11(string_1), GClass8.smethod_11("2")));
				JObject jObject = JObject.Parse(CS_0024_003C_003E8__locals0.FEB5613A);
				if (!Convert.ToBoolean(jObject["success"]))
				{
					CS_0024_003C_003E8__locals0.FEB5613A = jObject["message"]!.ToString();
				}
			}
			catch
			{
			}
			BF0564B6.txtKetQua.Invoke((MethodInvoker)delegate
			{
				CS_0024_003C_003E8__locals0.A298D439.BF0564B6.txtKetQua.Text = CS_0024_003C_003E8__locals0.FEB5613A;
			});
		}
	}

	[CompilerGenerated]
	private sealed class EB8CD8A9
	{
		public string FEB5613A;

		public F1BDEE9C A298D439;

		internal void F20E568B()
		{
			A298D439.BF0564B6.txtKetQua.Text = FEB5613A;
		}
	}

	[CompilerGenerated]
	private sealed class Class146
	{
		public string string_0;

		public FD08DB8D fd08DB8D_0;

		internal void method_0()
		{
			try
			{
				D58BE3AA CS_0024_003C_003E8__locals0 = new D58BE3AA
				{
					E592F121 = this,
					EAA100A9 = D32B691F.CBAB1D17(string_0)
				};
				fd08DB8D_0.txtKetQua.Invoke((MethodInvoker)delegate
				{
					CS_0024_003C_003E8__locals0.E592F121.fd08DB8D_0.txtKetQua.Text = CS_0024_003C_003E8__locals0.EAA100A9;
				});
			}
			catch
			{
			}
		}
	}

	[CompilerGenerated]
	private sealed class D58BE3AA
	{
		public string EAA100A9;

		public Class146 E592F121;

		internal void method_0()
		{
			E592F121.fd08DB8D_0.txtKetQua.Text = EAA100A9;
		}
	}

	public static List<string> DAB031B0;

	public static List<string> list_0;

	private IContainer A5353926 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private BunifuDragControl D791C51E;

	private PictureBox pictureBox1;

	private RichTextBox txtKetQua;

	private Label F3149D1F;

	private Button btnCheck;

	private Label label2;

	private TextBox AC24CFB3;

	private Label D0195D39;

	private TextBox txtUid;

	private Button button1;

	public FD08DB8D()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetJobs2(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] A502BE3E, byte[] byte_4, byte[] byte_5);

	private void btnCheck_Click(object sender, EventArgs e)
	{
		if (AC24CFB3.Text.Trim() == "")
		{
			GClass29.smethod_0("Vui lòng nhập API Key!", 3);
			AC24CFB3.Focus();
			return;
		}
		if (txtUid.Text.Trim() == "")
		{
			GClass29.smethod_0("Vui lòng nhập Uid!", 3);
			txtUid.Focus();
			return;
		}
		string A6066D10 = AC24CFB3.Text.Trim();
		string string_0 = txtUid.Text.Trim();
		string string_1 = "";
		if (string_0.Split('|').Length > 1)
		{
			string_1 = string_0.Split('|')[1];
			string_0 = string_0.Split('|')[0];
		}
		else
		{
			string_1 = "like,love,care,haha,wow,sad,angry,like_all,like_page,follow,join_group";
		}
		List<string> e03C713E = txtKetQua.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		txtKetQua.Text = "Checking...";
		Thread thread = new Thread((ThreadStart)delegate
		{
			string FEB5613A = "";
			try
			{
				string b881C = Class14.smethod_5(string_0);
				b881C = GClass8.CF09EFB3(b881C);
				FEB5613A = GClass8.smethod_10(GetJobs2(GClass8.smethod_11(""), GClass8.smethod_11(A6066D10), GClass8.smethod_11(string_0), GClass8.smethod_11(b881C), GClass8.smethod_11(""), GClass8.smethod_11(string_1), GClass8.smethod_11("2")));
				JObject jObject = JObject.Parse(FEB5613A);
				if (!Convert.ToBoolean(jObject["success"]))
				{
					FEB5613A = jObject["message"]!.ToString();
				}
			}
			catch
			{
			}
			txtKetQua.Invoke((MethodInvoker)delegate
			{
				txtKetQua.Text = FEB5613A;
			});
		});
		thread.IsBackground = true;
		thread.Start();
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetInfo(byte[] AE16769A);

	private void F43BB091(object sender, EventArgs e)
	{
		string string_0 = AC24CFB3.Text.Trim();
		if (string_0 == "")
		{
			GClass29.smethod_0("Vui lòng nhập API Key!", 3);
			AC24CFB3.Focus();
			return;
		}
		txtKetQua.Text = "Checking...";
		string EAA100A9;
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				EAA100A9 = D32B691F.CBAB1D17(string_0);
				txtKetQua.Invoke((MethodInvoker)delegate
				{
					txtKetQua.Text = EAA100A9;
				});
			}
			catch
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && A5353926 != null)
		{
			A5353926.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		A5353926 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D791C51E = new Bunifu.Framework.UI.BunifuDragControl(A5353926);
		txtKetQua = new System.Windows.Forms.RichTextBox();
		F3149D1F = new System.Windows.Forms.Label();
		btnCheck = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		AC24CFB3 = new System.Windows.Forms.TextBox();
		D0195D39 = new System.Windows.Forms.Label();
		txtUid = new System.Windows.Forms.TextBox();
		button1 = new System.Windows.Forms.Button();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(500, 34);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(500, 28);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = C50FB39E.Bitmap_12;
		btnMinimize.Location = new System.Drawing.Point(468, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 28);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(500, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Test Welike";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D791C51E.Fixed = true;
		D791C51E.Horizontal = true;
		D791C51E.TargetControl = bunifuCustomLabel1;
		D791C51E.Vertical = true;
		txtKetQua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtKetQua.Font = new System.Drawing.Font("Tahoma", 9.75f);
		txtKetQua.Location = new System.Drawing.Point(36, 186);
		txtKetQua.Name = "txtKetQua";
		txtKetQua.Size = new System.Drawing.Size(432, 136);
		txtKetQua.TabIndex = 146;
		txtKetQua.Text = "";
		F3149D1F.AutoSize = true;
		F3149D1F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		F3149D1F.Location = new System.Drawing.Point(33, 167);
		F3149D1F.Name = "label1";
		F3149D1F.Size = new System.Drawing.Size(55, 16);
		F3149D1F.TabIndex = 145;
		F3149D1F.Text = "Kết quả:";
		btnCheck.BackColor = System.Drawing.Color.Green;
		btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCheck.FlatAppearance.BorderSize = 0;
		btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCheck.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCheck.ForeColor = System.Drawing.Color.White;
		btnCheck.Location = new System.Drawing.Point(224, 120);
		btnCheck.Name = "btnCheck";
		btnCheck.Size = new System.Drawing.Size(82, 33);
		btnCheck.TabIndex = 147;
		btnCheck.Text = "Get Job";
		btnCheck.UseVisualStyleBackColor = false;
		btnCheck.Click += new System.EventHandler(btnCheck_Click);
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label2.Location = new System.Drawing.Point(33, 55);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(55, 16);
		label2.TabIndex = 145;
		label2.Text = "API Key:";
		AC24CFB3.Font = new System.Drawing.Font("Tahoma", 9.75f);
		AC24CFB3.Location = new System.Drawing.Point(90, 52);
		AC24CFB3.Name = "txtApiKey";
		AC24CFB3.Size = new System.Drawing.Size(309, 23);
		AC24CFB3.TabIndex = 148;
		D0195D39.AutoSize = true;
		D0195D39.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		D0195D39.Location = new System.Drawing.Point(33, 84);
		D0195D39.Name = "label3";
		D0195D39.Size = new System.Drawing.Size(30, 16);
		D0195D39.TabIndex = 145;
		D0195D39.Text = "Uid:";
		txtUid.Font = new System.Drawing.Font("Tahoma", 9.75f);
		txtUid.Location = new System.Drawing.Point(90, 81);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(378, 23);
		txtUid.TabIndex = 148;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.Location = new System.Drawing.Point(405, 51);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(63, 25);
		button1.TabIndex = 149;
		button1.Text = "Check";
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(F43BB091);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(500, 343);
		base.Controls.Add(button1);
		base.Controls.Add(txtUid);
		base.Controls.Add(AC24CFB3);
		base.Controls.Add(btnCheck);
		base.Controls.Add(D0195D39);
		base.Controls.Add(txtKetQua);
		base.Controls.Add(label2);
		base.Controls.Add(F3149D1F);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fTienIchWelike";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
