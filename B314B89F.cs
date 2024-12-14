using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class B314B89F : Form
{
	private IContainer C0B4AD83 = null;

	private BunifuCards bunifuCards1;

	private Panel BC39F215;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip F2BE9402;

	private BunifuCards CA122226;

	private Panel pnlHeader;

	private Button D80FD538;

	private PictureBox pictureBox1;

	private Button F709FF3F;

	private BunifuCustomLabel lblTitle;

	private Button btnAdd;

	private RichTextBox txtInput;

	private GroupBox groupBox2;

	private RichTextBox txtOutput;

	private GroupBox F7BD232C;

	private Button btnNhapTuFile;

	private TextBox B8867A93;

	private RadioButton rbTuNhap;

	private RadioButton ADA3F532;

	public B314B89F()
	{
		A9311FB1();
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(lblTitle);
		F7AB102E.smethod_1(ADA3F532);
		F7AB102E.smethod_1(btnNhapTuFile);
		F7AB102E.smethod_1(rbTuNhap);
	}

	private void D80FD538_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void D635A521(object sender, EventArgs e)
	{
		try
		{
			List<string> source = new List<string>();
			string text = B8867A93.Text.Trim();
			if (ADA3F532.Checked)
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
			if (ADA3F532.Checked)
			{
				source = File.ReadAllLines(text).ToList();
			}
			else if (rbTuNhap.Checked)
			{
				source = txtInput.Lines.ToList();
			}
			List<string> list = source.Distinct().ToList();
			txtOutput.Lines = list.ToArray();
			GClass29.smethod_0("Đã lọc xong!");
		}
		catch (Exception)
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void txtInput_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtInput.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			rbTuNhap.Text = string.Format(F7AB102E.smethod_0("Tự nhập ({0})"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void ADA3F532_CheckedChanged(object sender, EventArgs e)
	{
		B8867A93.Enabled = ADA3F532.Checked;
		btnNhapTuFile.Enabled = ADA3F532.Checked;
	}

	private void B8029D1B(object sender, EventArgs e)
	{
		txtInput.Enabled = rbTuNhap.Checked;
	}

	private void AF030E24(object sender, EventArgs e)
	{
		B8867A93.Text = GClass8.AD2D2BA4();
	}

	private void txtOutput_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtOutput.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			groupBox2.Text = $"Output ({e03C713E.Count.ToString()})";
		}
		catch
		{
		}
	}

	private void BC39F215_Paint(object sender, PaintEventArgs e)
	{
	}

	private void B314B89F_Load(object sender, EventArgs e)
	{
		ADA3F532_CheckedChanged(null, null);
		B8029D1B(null, null);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && C0B4AD83 != null)
		{
			C0B4AD83.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void A9311FB1()
	{
		C0B4AD83 = new Container();
		bunifuCards1 = new BunifuCards();
		BC39F215 = new Panel();
		groupBox2 = new GroupBox();
		txtOutput = new RichTextBox();
		F7BD232C = new GroupBox();
		btnNhapTuFile = new Button();
		txtInput = new RichTextBox();
		B8867A93 = new TextBox();
		rbTuNhap = new RadioButton();
		ADA3F532 = new RadioButton();
		btnAdd = new Button();
		CA122226 = new BunifuCards();
		pnlHeader = new Panel();
		D80FD538 = new Button();
		pictureBox1 = new PictureBox();
		F709FF3F = new Button();
		lblTitle = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(C0B4AD83);
		F2BE9402 = new ToolTip(C0B4AD83);
		BC39F215.SuspendLayout();
		groupBox2.SuspendLayout();
		F7BD232C.SuspendLayout();
		CA122226.SuspendLayout();
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
		bunifuCards1.Size = new Size(509, 47);
		bunifuCards1.TabIndex = 12;
		BC39F215.BackColor = Color.White;
		BC39F215.BorderStyle = BorderStyle.FixedSingle;
		BC39F215.Controls.Add(groupBox2);
		BC39F215.Controls.Add(F7BD232C);
		BC39F215.Controls.Add(btnAdd);
		BC39F215.Controls.Add(CA122226);
		BC39F215.Dock = DockStyle.Fill;
		BC39F215.Location = new Point(0, 0);
		BC39F215.Margin = new Padding(3, 4, 3, 4);
		BC39F215.Name = "panel1";
		BC39F215.Size = new Size(838, 270);
		BC39F215.TabIndex = 37;
		BC39F215.Paint += BC39F215_Paint;
		groupBox2.Controls.Add(txtOutput);
		groupBox2.Location = new Point(469, 40);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(361, 223);
		groupBox2.TabIndex = 51;
		groupBox2.TabStop = false;
		groupBox2.Text = "Output (0)";
		txtOutput.Location = new Point(6, 22);
		txtOutput.Name = "txtOutput";
		txtOutput.Size = new Size(349, 194);
		txtOutput.TabIndex = 50;
		txtOutput.Text = "";
		txtOutput.WordWrap = false;
		txtOutput.TextChanged += txtOutput_TextChanged;
		F7BD232C.Controls.Add(btnNhapTuFile);
		F7BD232C.Controls.Add(txtInput);
		F7BD232C.Controls.Add(B8867A93);
		F7BD232C.Controls.Add(rbTuNhap);
		F7BD232C.Controls.Add(ADA3F532);
		F7BD232C.Location = new Point(6, 40);
		F7BD232C.Name = "groupBox1";
		F7BD232C.Size = new Size(361, 223);
		F7BD232C.TabIndex = 51;
		F7BD232C.TabStop = false;
		F7BD232C.Text = "Input";
		btnNhapTuFile.Cursor = Cursors.Hand;
		btnNhapTuFile.Location = new Point(287, 22);
		btnNhapTuFile.Name = "btnNhapTuFile";
		btnNhapTuFile.Size = new Size(65, 24);
		btnNhapTuFile.TabIndex = 2;
		btnNhapTuFile.Text = "Chọn";
		btnNhapTuFile.Click += AF030E24;
		txtInput.Location = new Point(30, 75);
		txtInput.Name = "txtInput";
		txtInput.Size = new Size(322, 141);
		txtInput.TabIndex = 50;
		txtInput.Text = "";
		txtInput.WordWrap = false;
		txtInput.TextChanged += txtInput_TextChanged;
		B8867A93.Location = new Point(110, 22);
		B8867A93.Name = "txtNhapTuFile";
		B8867A93.Size = new Size(171, 23);
		B8867A93.TabIndex = 1;
		rbTuNhap.AutoSize = true;
		rbTuNhap.Cursor = Cursors.Hand;
		rbTuNhap.Location = new Point(9, 49);
		rbTuNhap.Name = "rbTuNhap";
		rbTuNhap.Size = new Size(95, 20);
		rbTuNhap.TabIndex = 0;
		rbTuNhap.Text = "Tự nhập (0)";
		rbTuNhap.UseVisualStyleBackColor = true;
		rbTuNhap.CheckedChanged += B8029D1B;
		ADA3F532.AutoSize = true;
		ADA3F532.Checked = true;
		ADA3F532.Cursor = Cursors.Hand;
		ADA3F532.Location = new Point(9, 23);
		ADA3F532.Name = "rbNhapTuFile";
		ADA3F532.Size = new Size(95, 20);
		ADA3F532.TabIndex = 0;
		ADA3F532.TabStop = true;
		ADA3F532.Text = "Nhập từ File";
		ADA3F532.UseVisualStyleBackColor = true;
		ADA3F532.CheckedChanged += ADA3F532_CheckedChanged;
		btnAdd.BackColor = Color.Green;
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(379, 138);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(78, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Start";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += D635A521;
		CA122226.BackColor = Color.White;
		CA122226.BorderRadius = 0;
		CA122226.BottomSahddow = true;
		CA122226.color = Color.SaddleBrown;
		CA122226.Controls.Add(pnlHeader);
		CA122226.Dock = DockStyle.Top;
		CA122226.LeftSahddow = false;
		CA122226.Location = new Point(0, 0);
		CA122226.Name = "bunifuCards2";
		CA122226.RightSahddow = true;
		CA122226.ShadowDepth = 20;
		CA122226.Size = new Size(836, 37);
		CA122226.TabIndex = 43;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(D80FD538);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(F709FF3F);
		pnlHeader.Controls.Add(lblTitle);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(836, 31);
		pnlHeader.TabIndex = 9;
		D80FD538.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		D80FD538.Cursor = Cursors.Hand;
		D80FD538.FlatAppearance.BorderSize = 0;
		D80FD538.FlatStyle = FlatStyle.Flat;
		D80FD538.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D80FD538.ForeColor = Color.White;
		D80FD538.Image = C50FB39E.Bitmap_12;
		D80FD538.Location = new Point(805, 1);
		D80FD538.Name = "button2";
		D80FD538.Size = new Size(30, 30);
		D80FD538.TabIndex = 77;
		D80FD538.TextImageRelation = TextImageRelation.ImageBeforeText;
		D80FD538.UseVisualStyleBackColor = true;
		D80FD538.Click += D80FD538_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		F709FF3F.Cursor = Cursors.Hand;
		F709FF3F.FlatAppearance.BorderSize = 0;
		F709FF3F.FlatStyle = FlatStyle.Flat;
		F709FF3F.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		F709FF3F.ForeColor = Color.White;
		F709FF3F.Location = new Point(899, 1);
		F709FF3F.Name = "btnMinimize";
		F709FF3F.Size = new Size(30, 30);
		F709FF3F.TabIndex = 9;
		F709FF3F.TextImageRelation = TextImageRelation.ImageBeforeText;
		F709FF3F.UseVisualStyleBackColor = true;
		lblTitle.BackColor = Color.Transparent;
		lblTitle.Cursor = Cursors.SizeAll;
		lblTitle.Dock = DockStyle.Fill;
		lblTitle.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		lblTitle.ForeColor = Color.Black;
		lblTitle.Location = new Point(0, 0);
		lblTitle.Name = "lblTitle";
		lblTitle.Size = new Size(836, 31);
		lblTitle.TabIndex = 12;
		lblTitle.Text = "Lọc trùng dữ liệu";
		lblTitle.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = lblTitle;
		bunifuDragControl_0.Vertical = true;
		F2BE9402.AutomaticDelay = 0;
		F2BE9402.AutoPopDelay = 10000;
		F2BE9402.InitialDelay = 200;
		F2BE9402.ReshowDelay = 40;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(838, 270);
		base.Controls.Add(BC39F215);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fTienIchLocTrung";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += B314B89F_Load;
		BC39F215.ResumeLayout(performLayout: false);
		groupBox2.ResumeLayout(performLayout: false);
		F7BD232C.ResumeLayout(performLayout: false);
		F7BD232C.PerformLayout();
		CA122226.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
	}
}
