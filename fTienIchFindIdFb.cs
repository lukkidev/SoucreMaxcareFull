using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fTienIchFindIdFb : Form
{
	[CompilerGenerated]
	private sealed class D889A49E
	{
		public int int_0;

		public fTienIchFindIdFb fTienIchFindIdFb_0;
	}

	[CompilerGenerated]
	private sealed class BD17789A
	{
		public string string_0;

		public D889A49E D60C0930;

		internal void method_0()
		{
			string text = GClass8.smethod_90(string_0);
			D60C0930.fTienIchFindIdFb_0.D739383E(D60C0930.fTienIchFindIdFb_0.txtOutput1, text);
			D60C0930.fTienIchFindIdFb_0.D739383E(D60C0930.fTienIchFindIdFb_0.txtOutput2, string_0 + "|" + text);
			Interlocked.Decrement(ref D60C0930.int_0);
		}
	}

	[CompilerGenerated]
	private sealed class C4A7F8BF
	{
		public RichTextBox F5073006;

		public string string_0;

		internal void method_0()
		{
			Application.DoEvents();
			RichTextBox f = F5073006;
			f.Text = f.Text + string_0 + "\r\n";
		}
	}

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip BF1F7732;

	private BunifuCards F493B795;

	private Panel E21F0336;

	private Button EF8F1F9B;

	private PictureBox pictureBox1;

	private Button A182A40F;

	private BunifuCustomLabel BC9AE593;

	private Button btnAdd;

	private RichTextBox txtInput;

	private GroupBox grOutput1;

	private RichTextBox txtOutput1;

	private GroupBox grInput;

	private GroupBox FB951D84;

	private RichTextBox txtOutput2;

	private Label lblStatus;

	public fTienIchFindIdFb()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void F69821B4(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			list = txtInput.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			if (list.Count == 0)
			{
				return;
			}
			txtOutput1.Clear();
			txtOutput2.Clear();
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
					string string_0 = list[num2++];
					new Thread((ThreadStart)delegate
					{
						string text = GClass8.smethod_90(string_0);
						D739383E(txtOutput1, text);
						D739383E(txtOutput2, string_0 + "|" + text);
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

	private void D739383E(RichTextBox richTextBox_0, string string_0)
	{
		richTextBox_0.Invoke((MethodInvoker)delegate
		{
			Application.DoEvents();
			RichTextBox richTextBox = richTextBox_0;
			richTextBox.Text = richTextBox.Text + string_0 + "\r\n";
		});
	}

	private void txtInput_TextChanged(object sender, EventArgs e)
	{
		GClass8.E814B702(txtInput, grInput);
	}

	private void txtOutput1_TextChanged(object sender, EventArgs e)
	{
		GClass8.E814B702(txtOutput1, grOutput1);
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void F2B5272E(object sender, EventArgs e)
	{
	}

	private void txtOutput2_TextChanged(object sender, EventArgs e)
	{
		GClass8.E814B702(txtOutput2, FB951D84);
	}

	protected override void Dispose(bool D0164A02)
	{
		if (D0164A02 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D0164A02);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		lblStatus = new System.Windows.Forms.Label();
		FB951D84 = new System.Windows.Forms.GroupBox();
		txtOutput2 = new System.Windows.Forms.RichTextBox();
		grOutput1 = new System.Windows.Forms.GroupBox();
		txtOutput1 = new System.Windows.Forms.RichTextBox();
		grInput = new System.Windows.Forms.GroupBox();
		txtInput = new System.Windows.Forms.RichTextBox();
		btnAdd = new System.Windows.Forms.Button();
		F493B795 = new Bunifu.Framework.UI.BunifuCards();
		E21F0336 = new System.Windows.Forms.Panel();
		EF8F1F9B = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		A182A40F = new System.Windows.Forms.Button();
		BC9AE593 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		BF1F7732 = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		FB951D84.SuspendLayout();
		grOutput1.SuspendLayout();
		grInput.SuspendLayout();
		F493B795.SuspendLayout();
		E21F0336.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
		bunifuCards1.Size = new System.Drawing.Size(421, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(FB951D84);
		panel1.Controls.Add(grOutput1);
		panel1.Controls.Add(grInput);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(F493B795);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(750, 404);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		lblStatus.AutoSize = true;
		lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
		lblStatus.Location = new System.Drawing.Point(435, 59);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(70, 16);
		lblStatus.TabIndex = 52;
		lblStatus.Text = "Checking...";
		lblStatus.Visible = false;
		FB951D84.Controls.Add(txtOutput2);
		FB951D84.ForeColor = System.Drawing.SystemColors.ControlText;
		FB951D84.Location = new System.Drawing.Point(521, 91);
		FB951D84.Name = "grOutput2";
		FB951D84.Size = new System.Drawing.Size(221, 307);
		FB951D84.TabIndex = 51;
		FB951D84.TabStop = false;
		FB951D84.Text = "Link|Id (0)";
		txtOutput2.Dock = System.Windows.Forms.DockStyle.Fill;
		txtOutput2.Location = new System.Drawing.Point(3, 19);
		txtOutput2.Name = "txtOutput2";
		txtOutput2.Size = new System.Drawing.Size(215, 285);
		txtOutput2.TabIndex = 50;
		txtOutput2.Text = "";
		txtOutput2.WordWrap = false;
		txtOutput2.TextChanged += new System.EventHandler(txtOutput2_TextChanged);
		grOutput1.Controls.Add(txtOutput1);
		grOutput1.ForeColor = System.Drawing.SystemColors.ControlText;
		grOutput1.Location = new System.Drawing.Point(294, 91);
		grOutput1.Name = "grOutput1";
		grOutput1.Size = new System.Drawing.Size(221, 307);
		grOutput1.TabIndex = 51;
		grOutput1.TabStop = false;
		grOutput1.Text = "Id (0)";
		txtOutput1.Dock = System.Windows.Forms.DockStyle.Fill;
		txtOutput1.Location = new System.Drawing.Point(3, 19);
		txtOutput1.Name = "txtOutput1";
		txtOutput1.Size = new System.Drawing.Size(215, 285);
		txtOutput1.TabIndex = 50;
		txtOutput1.Text = "";
		txtOutput1.WordWrap = false;
		txtOutput1.TextChanged += new System.EventHandler(txtOutput1_TextChanged);
		grInput.Controls.Add(txtInput);
		grInput.Location = new System.Drawing.Point(6, 40);
		grInput.Name = "grInput";
		grInput.Size = new System.Drawing.Size(282, 358);
		grInput.TabIndex = 51;
		grInput.TabStop = false;
		grInput.Text = "Nhập link Fb (0)";
		txtInput.Location = new System.Drawing.Point(9, 19);
		txtInput.Name = "txtInput";
		txtInput.Size = new System.Drawing.Size(267, 332);
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
		btnAdd.Location = new System.Drawing.Point(294, 49);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(135, 36);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Check";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		F493B795.BackColor = System.Drawing.Color.White;
		F493B795.BorderRadius = 0;
		F493B795.BottomSahddow = true;
		F493B795.color = System.Drawing.Color.SaddleBrown;
		F493B795.Controls.Add(E21F0336);
		F493B795.Dock = System.Windows.Forms.DockStyle.Top;
		F493B795.LeftSahddow = false;
		F493B795.Location = new System.Drawing.Point(0, 0);
		F493B795.Name = "bunifuCards2";
		F493B795.RightSahddow = true;
		F493B795.ShadowDepth = 20;
		F493B795.Size = new System.Drawing.Size(748, 37);
		F493B795.TabIndex = 43;
		E21F0336.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E21F0336.BackColor = System.Drawing.Color.White;
		E21F0336.Controls.Add(EF8F1F9B);
		E21F0336.Controls.Add(pictureBox1);
		E21F0336.Controls.Add(A182A40F);
		E21F0336.Controls.Add(BC9AE593);
		E21F0336.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E21F0336.Location = new System.Drawing.Point(0, 3);
		E21F0336.Name = "pnlHeader";
		E21F0336.Size = new System.Drawing.Size(748, 31);
		E21F0336.TabIndex = 9;
		EF8F1F9B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		EF8F1F9B.Cursor = System.Windows.Forms.Cursors.Hand;
		EF8F1F9B.FlatAppearance.BorderSize = 0;
		EF8F1F9B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EF8F1F9B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EF8F1F9B.ForeColor = System.Drawing.Color.White;
		EF8F1F9B.Image = C50FB39E.Bitmap_12;
		EF8F1F9B.Location = new System.Drawing.Point(717, 1);
		EF8F1F9B.Name = "button2";
		EF8F1F9B.Size = new System.Drawing.Size(30, 30);
		EF8F1F9B.TabIndex = 77;
		EF8F1F9B.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		EF8F1F9B.UseVisualStyleBackColor = true;
		EF8F1F9B.Click += new System.EventHandler(F69821B4);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		A182A40F.Cursor = System.Windows.Forms.Cursors.Hand;
		A182A40F.FlatAppearance.BorderSize = 0;
		A182A40F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A182A40F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A182A40F.ForeColor = System.Drawing.Color.White;
		A182A40F.Location = new System.Drawing.Point(899, 1);
		A182A40F.Name = "btnMinimize";
		A182A40F.Size = new System.Drawing.Size(30, 30);
		A182A40F.TabIndex = 9;
		A182A40F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		A182A40F.UseVisualStyleBackColor = true;
		BC9AE593.BackColor = System.Drawing.Color.Transparent;
		BC9AE593.Cursor = System.Windows.Forms.Cursors.SizeAll;
		BC9AE593.Dock = System.Windows.Forms.DockStyle.Fill;
		BC9AE593.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BC9AE593.ForeColor = System.Drawing.Color.Black;
		BC9AE593.Location = new System.Drawing.Point(0, 0);
		BC9AE593.Name = "lblTitle";
		BC9AE593.Size = new System.Drawing.Size(748, 31);
		BC9AE593.TabIndex = 12;
		BC9AE593.Text = "Find Id Facebook";
		BC9AE593.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = BC9AE593;
		bunifuDragControl_0.Vertical = true;
		BF1F7732.AutomaticDelay = 0;
		BF1F7732.AutoPopDelay = 10000;
		BF1F7732.InitialDelay = 200;
		BF1F7732.ReshowDelay = 40;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(750, 404);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fTienIchFindIdFb";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(F2B5272E);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		FB951D84.ResumeLayout(false);
		grOutput1.ResumeLayout(false);
		grInput.ResumeLayout(false);
		F493B795.ResumeLayout(false);
		E21F0336.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
	}

	[CompilerGenerated]
	private void E9BA1115()
	{
		lblStatus.Visible = true;
	}

	[CompilerGenerated]
	private void EC933496()
	{
		lblStatus.Visible = false;
	}
}
