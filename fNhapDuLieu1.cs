using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fNhapDuLieu1 : Form
{
	private string AC133C87 = "";

	private string EA18DC3C = "";

	public List<string> C6009CA1 = new List<string>();

	private IContainer CA25FFBC = null;

	private BunifuCards BD9E3E37;

	private Panel DD03A400;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip toolTip_0;

	private BunifuCards F18DED35;

	private Panel FF378516;

	private Button button2;

	private PictureBox DC95ACB2;

	private Button B93D38A5;

	private BunifuCustomLabel BE2D6FAA;

	private Label lblStatus;

	private Button btnCancel;

	private Button B498AB9D;

	private Label lblFooter;

	private RichTextBox BDB26321;

	public fNhapDuLieu1(string string_0, string string_1 = "Nhập danh sách Uid cần clone", string DE9ED536 = "Danh sách Uid", string AF220EB6 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})", List<string> list_0 = null)
	{
		C8B0A112();
		GClass8.smethod_31(string_0);
		AC133C87 = string_0;
		EA18DC3C = DE9ED536;
		BE2D6FAA.Text = string_1;
		lblStatus.Text = DE9ED536 + " (0):";
		lblFooter.Text = AF220EB6;
		if (list_0 != null)
		{
			File.WriteAllLines(string_0, list_0);
			BDB26321.Lines = list_0.ToArray();
		}
		else
		{
			BDB26321.Lines = File.ReadAllLines(string_0);
		}
		BDB26321_TextChanged(null, null);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(BE2D6FAA);
		F7AB102E.smethod_1(lblStatus);
		F7AB102E.smethod_1(lblFooter);
		F7AB102E.smethod_1(B498AB9D);
		F7AB102E.smethod_1(btnCancel);
	}

	public fNhapDuLieu1(List<string> list_0, string string_0 = "Nhập danh sách Uid cần clone", string string_1 = "Danh sách Uid", string string_2 = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})")
	{
		C8B0A112();
		C6009CA1 = list_0;
		EA18DC3C = string_1;
		BE2D6FAA.Text = string_0;
		lblStatus.Text = string_1 + " (0):";
		lblFooter.Text = string_2;
		F7AB102E.D6B70A35(this);
	}

	private void E90A5E38(object sender, EventArgs e)
	{
		if (AC133C87 != "")
		{
			BDB26321.Lines = File.ReadAllLines(AC133C87);
		}
		else
		{
			BDB26321.Lines = C6009CA1.ToArray();
		}
	}

	private void DD03A400_Paint(object sender, PaintEventArgs e)
	{
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B498AB9D_Click(object sender, EventArgs e)
	{
		try
		{
			if (AC133C87 != "")
			{
				File.WriteAllText(AC133C87, BDB26321.Text.Trim());
			}
			else
			{
				C6009CA1 = BDB26321.Text.Split(new string[1] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
			}
			Close();
		}
		catch
		{
			GClass29.smethod_0("Đã có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void FE2A501B(object sender, EventArgs e)
	{
		Close();
	}

	private void BDB26321_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = BDB26321.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblStatus.Text = EA18DC3C + " (" + e03C713E.Count + "):";
		}
		catch
		{
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && CA25FFBC != null)
		{
			CA25FFBC.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void C8B0A112()
	{
		CA25FFBC = new Container();
		BD9E3E37 = new BunifuCards();
		DD03A400 = new Panel();
		lblFooter = new Label();
		lblStatus = new Label();
		btnCancel = new Button();
		B498AB9D = new Button();
		F18DED35 = new BunifuCards();
		FF378516 = new Panel();
		button2 = new Button();
		DC95ACB2 = new PictureBox();
		B93D38A5 = new Button();
		BE2D6FAA = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(CA25FFBC);
		toolTip_0 = new ToolTip(CA25FFBC);
		BDB26321 = new RichTextBox();
		DD03A400.SuspendLayout();
		F18DED35.SuspendLayout();
		FF378516.SuspendLayout();
		((ISupportInitialize)DC95ACB2).BeginInit();
		SuspendLayout();
		BD9E3E37.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		BD9E3E37.BackColor = Color.White;
		BD9E3E37.BorderRadius = 5;
		BD9E3E37.BottomSahddow = true;
		BD9E3E37.color = Color.SaddleBrown;
		BD9E3E37.LeftSahddow = false;
		BD9E3E37.Location = new Point(0, 0);
		BD9E3E37.Margin = new Padding(3, 4, 3, 4);
		BD9E3E37.Name = "bunifuCards1";
		BD9E3E37.RightSahddow = true;
		BD9E3E37.ShadowDepth = 20;
		BD9E3E37.Size = new Size(234, 47);
		BD9E3E37.TabIndex = 12;
		DD03A400.BackColor = Color.White;
		DD03A400.BorderStyle = BorderStyle.FixedSingle;
		DD03A400.Controls.Add(BDB26321);
		DD03A400.Controls.Add(lblFooter);
		DD03A400.Controls.Add(lblStatus);
		DD03A400.Controls.Add(btnCancel);
		DD03A400.Controls.Add(B498AB9D);
		DD03A400.Controls.Add(F18DED35);
		DD03A400.Dock = DockStyle.Fill;
		DD03A400.Location = new Point(0, 0);
		DD03A400.Margin = new Padding(3, 4, 3, 4);
		DD03A400.Name = "panel1";
		DD03A400.Size = new Size(563, 364);
		DD03A400.TabIndex = 37;
		DD03A400.Paint += DD03A400_Paint;
		lblFooter.AutoSize = true;
		lblFooter.Location = new Point(13, 299);
		lblFooter.Name = "lblFooter";
		lblFooter.Size = new Size(266, 16);
		lblFooter.TabIndex = 49;
		lblFooter.Text = "(Mỗi nội dung 1 dòng, spin nội dung {a|b|c})";
		lblStatus.AutoSize = true;
		lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		lblStatus.Location = new Point(13, 45);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(140, 16);
		lblStatus.TabIndex = 47;
		lblStatus.Text = "Nội dung bình luận (0):";
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(286, 321);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 46;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += FE2A501B;
		B498AB9D.BackColor = Color.FromArgb(53, 120, 229);
		B498AB9D.Cursor = Cursors.Hand;
		B498AB9D.FlatAppearance.BorderSize = 0;
		B498AB9D.FlatStyle = FlatStyle.Flat;
		B498AB9D.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B498AB9D.ForeColor = Color.White;
		B498AB9D.Location = new Point(182, 321);
		B498AB9D.Name = "btnAdd";
		B498AB9D.Size = new Size(92, 29);
		B498AB9D.TabIndex = 45;
		B498AB9D.Text = "Lưu";
		B498AB9D.UseVisualStyleBackColor = false;
		B498AB9D.Click += B498AB9D_Click;
		F18DED35.BackColor = Color.White;
		F18DED35.BorderRadius = 0;
		F18DED35.BottomSahddow = true;
		F18DED35.color = Color.SaddleBrown;
		F18DED35.Controls.Add(FF378516);
		F18DED35.Dock = DockStyle.Top;
		F18DED35.LeftSahddow = false;
		F18DED35.Location = new Point(0, 0);
		F18DED35.Name = "bunifuCards2";
		F18DED35.RightSahddow = true;
		F18DED35.ShadowDepth = 20;
		F18DED35.Size = new Size(561, 37);
		F18DED35.TabIndex = 43;
		FF378516.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		FF378516.BackColor = Color.White;
		FF378516.Controls.Add(button2);
		FF378516.Controls.Add(DC95ACB2);
		FF378516.Controls.Add(B93D38A5);
		FF378516.Controls.Add(BE2D6FAA);
		FF378516.Cursor = Cursors.SizeAll;
		FF378516.Location = new Point(0, 3);
		FF378516.Name = "pnlHeader";
		FF378516.Size = new Size(561, 31);
		FF378516.TabIndex = 9;
		button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button2.Cursor = Cursors.Hand;
		button2.FlatAppearance.BorderSize = 0;
		button2.FlatStyle = FlatStyle.Flat;
		button2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button2.ForeColor = Color.White;
		button2.Image = C50FB39E.Bitmap_12;
		button2.Location = new Point(530, 1);
		button2.Name = "button2";
		button2.Size = new Size(30, 30);
		button2.TabIndex = 77;
		button2.TextImageRelation = TextImageRelation.ImageBeforeText;
		button2.UseVisualStyleBackColor = true;
		button2.Click += button2_Click;
		DC95ACB2.Cursor = Cursors.Default;
		DC95ACB2.Image = C50FB39E.Bitmap_5;
		DC95ACB2.Location = new Point(3, 2);
		DC95ACB2.Name = "pictureBox1";
		DC95ACB2.Size = new Size(34, 27);
		DC95ACB2.SizeMode = PictureBoxSizeMode.Zoom;
		DC95ACB2.TabIndex = 76;
		DC95ACB2.TabStop = false;
		B93D38A5.Cursor = Cursors.Hand;
		B93D38A5.FlatAppearance.BorderSize = 0;
		B93D38A5.FlatStyle = FlatStyle.Flat;
		B93D38A5.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B93D38A5.ForeColor = Color.White;
		B93D38A5.Location = new Point(899, 1);
		B93D38A5.Name = "btnMinimize";
		B93D38A5.Size = new Size(30, 30);
		B93D38A5.TabIndex = 9;
		B93D38A5.TextImageRelation = TextImageRelation.ImageBeforeText;
		B93D38A5.UseVisualStyleBackColor = true;
		BE2D6FAA.BackColor = Color.Transparent;
		BE2D6FAA.Cursor = Cursors.SizeAll;
		BE2D6FAA.Dock = DockStyle.Fill;
		BE2D6FAA.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BE2D6FAA.ForeColor = Color.Black;
		BE2D6FAA.Location = new Point(0, 0);
		BE2D6FAA.Name = "lblTitle";
		BE2D6FAA.Size = new Size(561, 31);
		BE2D6FAA.TabIndex = 12;
		BE2D6FAA.Text = "Nhập nội dung comment";
		BE2D6FAA.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = BE2D6FAA;
		bunifuDragControl_0.Vertical = true;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 10000;
		toolTip_0.InitialDelay = 200;
		toolTip_0.ReshowDelay = 40;
		BDB26321.Location = new Point(16, 64);
		BDB26321.Name = "txtComment";
		BDB26321.Size = new Size(528, 231);
		BDB26321.TabIndex = 50;
		BDB26321.Text = "";
		BDB26321.WordWrap = false;
		BDB26321.TextChanged += BDB26321_TextChanged;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(563, 364);
		base.Controls.Add(DD03A400);
		base.Controls.Add(BD9E3E37);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fNhapDuLieu1";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += E90A5E38;
		DD03A400.ResumeLayout(performLayout: false);
		DD03A400.PerformLayout();
		F18DED35.ResumeLayout(performLayout: false);
		FF378516.ResumeLayout(performLayout: false);
		((ISupportInitialize)DC95ACB2).EndInit();
		ResumeLayout(performLayout: false);
	}
}
