using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class AAB8AA14 : Form
{
	[CompilerGenerated]
	private sealed class Class90
	{
		public AAB8AA14 AE878191;

		public string string_0;

		public string FCAF6312;

		internal void A9015D20()
		{
			Class91 CS_0024_003C_003E8__locals0 = new Class91
			{
				C127F52C = this
			};
			AE878191.method_0(bool_1: true);
			CS_0024_003C_003E8__locals0.E681CBA2 = "";
			try
			{
				string_0 = string_0.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"")
					.Replace("'", "\\'");
				CS_0024_003C_003E8__locals0.E681CBA2 = GClass8.smethod_88("ChatGPT('" + FCAF6312 + "', '" + string_0 + "')");
			}
			catch
			{
			}
			AE878191.method_0(bool_1: false);
			AE878191.txtResult.Invoke((MethodInvoker)delegate
			{
				CS_0024_003C_003E8__locals0.C127F52C.AE878191.txtResult.Text = CS_0024_003C_003E8__locals0.E681CBA2;
			});
		}
	}

	[CompilerGenerated]
	private sealed class Class91
	{
		public string E681CBA2;

		public Class90 C127F52C;

		internal void method_0()
		{
			C127F52C.AE878191.txtResult.Text = E681CBA2;
		}
	}

	[CompilerGenerated]
	private sealed class Class92
	{
		public AAB8AA14 aab8AA14_0;

		public bool bool_0;

		internal void method_0()
		{
			aab8AA14_0.D983DC9A.Visible = bool_0;
		}
	}

	public static List<string> list_0;

	public static List<string> list_1;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel BE9F4C14;

	private Button btnMinimize;

	private BunifuDragControl ACBA5EA9;

	private PictureBox pictureBox1;

	private RichTextBox txtContent;

	private Label label17;

	private Label label1;

	private Button btnCheck;

	private Label label2;

	private TextBox DA951794;

	private RichTextBox txtResult;

	private ProgressBar D983DC9A;

	private LinkLabel linkLabel1;

	private CheckBox A0AA000D;

	public AAB8AA14()
	{
		InitializeComponent();
		bool_0 = false;
		F7AB102E.D6B70A35(this);
		DA951794.Text = GClass25.smethod_0("configChatGPT").C0288288("apiKey");
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void txtResult_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtContent, label17);
	}

	private void btnCheck_Click(object sender, EventArgs e)
	{
		if (DA951794.Text.Trim() == "")
		{
			GClass29.smethod_0("Vui lòng nhập API Key!", 3);
			DA951794.Focus();
			return;
		}
		GClass25.smethod_0("configChatGPT").method_4("apiKey", DA951794.Text.Trim());
		GClass25.B3B73732("configChatGPT");
		if (txtContent.Text.Trim() == "")
		{
			GClass29.smethod_0("Vui lòng nhập nội dung!", 3);
			txtContent.Focus();
			return;
		}
		string FCAF6312 = DA951794.Text.Trim();
		string string_0 = txtContent.Text.Trim();
		Thread thread = new Thread((ThreadStart)delegate
		{
			method_0(bool_1: true);
			string E681CBA2 = "";
			try
			{
				string_0 = string_0.Replace("\r\n", "\n").Replace("\n", "\\\\n").Replace("\"", "\\\"")
					.Replace("'", "\\'");
				E681CBA2 = GClass8.smethod_88("ChatGPT('" + FCAF6312 + "', '" + string_0 + "')");
			}
			catch
			{
			}
			method_0(bool_1: false);
			txtResult.Invoke((MethodInvoker)delegate
			{
				txtResult.Text = E681CBA2;
			});
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_0(bool bool_1)
	{
		D983DC9A.Invoke((MethodInvoker)delegate
		{
			D983DC9A.Visible = bool_1;
		});
	}

	private void C8817C0A(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.CD18FD80("https://www.youtube.com/watch?v=alxMQWAaS2M");
	}

	private void C3879223(object sender, EventArgs e)
	{
		txtResult.WordWrap = A0AA000D.Checked;
	}

	protected override void Dispose(bool B30FAE29)
	{
		if (B30FAE29 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B30FAE29);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		BE9F4C14 = new Bunifu.Framework.UI.BunifuCustomLabel();
		ACBA5EA9 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		txtContent = new System.Windows.Forms.RichTextBox();
		label17 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCheck = new System.Windows.Forms.Button();
		label2 = new System.Windows.Forms.Label();
		DA951794 = new System.Windows.Forms.TextBox();
		txtResult = new System.Windows.Forms.RichTextBox();
		D983DC9A = new System.Windows.Forms.ProgressBar();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		A0AA000D = new System.Windows.Forms.CheckBox();
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
		bunifuCards1.Size = new System.Drawing.Size(840, 34);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(BE9F4C14);
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(840, 28);
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
		btnMinimize.Location = new System.Drawing.Point(808, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 28);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		BE9F4C14.BackColor = System.Drawing.Color.Transparent;
		BE9F4C14.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BE9F4C14.Dock = System.Windows.Forms.DockStyle.Fill;
		BE9F4C14.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BE9F4C14.ForeColor = System.Drawing.Color.Black;
		BE9F4C14.Location = new System.Drawing.Point(0, 0);
		BE9F4C14.Name = "bunifuCustomLabel1";
		BE9F4C14.Size = new System.Drawing.Size(840, 28);
		BE9F4C14.TabIndex = 1;
		BE9F4C14.Text = "ChatGPT";
		BE9F4C14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ACBA5EA9.Fixed = true;
		ACBA5EA9.Horizontal = true;
		ACBA5EA9.TargetControl = BE9F4C14;
		ACBA5EA9.Vertical = true;
		txtContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtContent.Font = new System.Drawing.Font("Tahoma", 9.75f);
		txtContent.Location = new System.Drawing.Point(13, 92);
		txtContent.Name = "txtContent";
		txtContent.Size = new System.Drawing.Size(813, 121);
		txtContent.TabIndex = 146;
		txtContent.Text = "";
		txtContent.WordWrap = false;
		txtContent.TextChanged += new System.EventHandler(txtResult_TextChanged);
		label17.AutoSize = true;
		label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label17.Location = new System.Drawing.Point(10, 73);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(94, 16);
		label17.TabIndex = 145;
		label17.Text = "Nhập nội dung:";
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label1.Location = new System.Drawing.Point(10, 277);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(55, 16);
		label1.TabIndex = 145;
		label1.Text = "Kết quả:";
		btnCheck.BackColor = System.Drawing.Color.Green;
		btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCheck.FlatAppearance.BorderSize = 0;
		btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCheck.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCheck.ForeColor = System.Drawing.Color.White;
		btnCheck.Location = new System.Drawing.Point(364, 230);
		btnCheck.Name = "btnCheck";
		btnCheck.Size = new System.Drawing.Size(118, 33);
		btnCheck.TabIndex = 147;
		btnCheck.Text = "Start";
		btnCheck.UseVisualStyleBackColor = false;
		btnCheck.Click += new System.EventHandler(btnCheck_Click);
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label2.Location = new System.Drawing.Point(10, 50);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(55, 16);
		label2.TabIndex = 145;
		label2.Text = "API Key:";
		DA951794.Font = new System.Drawing.Font("Tahoma", 9.75f);
		DA951794.Location = new System.Drawing.Point(71, 47);
		DA951794.Name = "txtApiKey";
		DA951794.Size = new System.Drawing.Size(755, 23);
		DA951794.TabIndex = 148;
		txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtResult.Font = new System.Drawing.Font("Tahoma", 9.75f);
		txtResult.Location = new System.Drawing.Point(13, 296);
		txtResult.Name = "txtResult";
		txtResult.Size = new System.Drawing.Size(813, 293);
		txtResult.TabIndex = 146;
		txtResult.Text = "";
		txtResult.WordWrap = false;
		txtResult.TextChanged += new System.EventHandler(txtResult_TextChanged);
		D983DC9A.Location = new System.Drawing.Point(521, 235);
		D983DC9A.Name = "progressBar";
		D983DC9A.Size = new System.Drawing.Size(258, 23);
		D983DC9A.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
		D983DC9A.TabIndex = 149;
		D983DC9A.Visible = false;
		linkLabel1.AutoSize = true;
		linkLabel1.Location = new System.Drawing.Point(12, 238);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(288, 16);
		linkLabel1.TabIndex = 150;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "Hướng dẫn tạo tài khoản ChatGPT và lấy API Key!";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(C8817C0A);
		A0AA000D.AutoSize = true;
		A0AA000D.Cursor = System.Windows.Forms.Cursors.Hand;
		A0AA000D.Location = new System.Drawing.Point(743, 276);
		A0AA000D.Name = "ckbWordWap";
		A0AA000D.Size = new System.Drawing.Size(88, 20);
		A0AA000D.TabIndex = 151;
		A0AA000D.Text = "WordWrap";
		A0AA000D.UseVisualStyleBackColor = true;
		A0AA000D.CheckedChanged += new System.EventHandler(C3879223);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(840, 601);
		base.Controls.Add(A0AA000D);
		base.Controls.Add(linkLabel1);
		base.Controls.Add(D983DC9A);
		base.Controls.Add(DA951794);
		base.Controls.Add(btnCheck);
		base.Controls.Add(txtResult);
		base.Controls.Add(txtContent);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(label17);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fTienIchChatGPT";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
