using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class D282E117 : Form
{
	private GClass11 FFAA4227 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int F23A2388;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl FA9D9F0B;

	private BunifuDragControl bunifuDragControl_0;

	private Panel DE340D3F;

	private TextBox C1924A14;

	private Label C72E2135;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label DC86BF92;

	private NumericUpDown E235DF1A;

	private NumericUpDown C3B5740D;

	private Label label13;

	private Label label9;

	private NumericUpDown nudDelayTo;

	private Label B8857B2D;

	private Label label4;

	private NumericUpDown nudDelayFrom;

	private Button button1;

	private TextBox txtIdPage;

	public D282E117(string string_3, int int_0 = 0, string string_4 = "")
	{
		AA3B7698();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		F23A2388 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Mời like Page";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C1924A14.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			C1924A14.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		FFAA4227 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void D282E117_Load(object sender, EventArgs e)
	{
		try
		{
			txtIdPage.Text = FFAA4227.C0288288("txtIdPage");
			C3B5740D.Value = FFAA4227.method_2("nudSoLuongFrom", 10);
			E235DF1A.Value = FFAA4227.method_2("nudSoLuongTo", 10);
			nudDelayFrom.Value = FFAA4227.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = FFAA4227.method_2("nudDelayTo", 5);
		}
		catch
		{
		}
	}

	private void BB99B895(object sender, EventArgs e)
	{
		Close();
	}

	private void CB3C0495(object sender, EventArgs e)
	{
		string text = C1924A14.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("txtIdPage", txtIdPage.Text.Trim());
		gClass.method_4("nudSoLuongFrom", C3B5740D.Value);
		gClass.method_4("nudSoLuongTo", E235DF1A.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		string text2 = gClass.method_7();
		if (F23A2388 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_2, text, text2))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DE340D3F_Paint(object sender, PaintEventArgs e)
	{
		if (DE340D3F.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, DE340D3F.ClientSize.Width - num, DE340D3F.ClientSize.Height - num));
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

	private void AA3B7698()
	{
		icontainer_0 = new Container();
		FA9D9F0B = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		DE340D3F = new Panel();
		txtIdPage = new TextBox();
		nudDelayTo = new NumericUpDown();
		B8857B2D = new Label();
		label4 = new Label();
		nudDelayFrom = new NumericUpDown();
		DC86BF92 = new Label();
		E235DF1A = new NumericUpDown();
		C3B5740D = new NumericUpDown();
		C1924A14 = new TextBox();
		label13 = new Label();
		label9 = new Label();
		C72E2135 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		DE340D3F.SuspendLayout();
		((ISupportInitialize)nudDelayTo).BeginInit();
		((ISupportInitialize)nudDelayFrom).BeginInit();
		((ISupportInitialize)E235DF1A).BeginInit();
		((ISupportInitialize)C3B5740D).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		FA9D9F0B.Fixed = true;
		FA9D9F0B.Horizontal = true;
		FA9D9F0B.TargetControl = bunifuCustomLabel1;
		FA9D9F0B.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(326, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Mời like Page";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(326, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = C50FB39E.Bitmap_12;
		button1.Location = new Point(295, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += BB99B895;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		DE340D3F.BackColor = Color.White;
		DE340D3F.BorderStyle = BorderStyle.FixedSingle;
		DE340D3F.Controls.Add(txtIdPage);
		DE340D3F.Controls.Add(nudDelayTo);
		DE340D3F.Controls.Add(B8857B2D);
		DE340D3F.Controls.Add(label4);
		DE340D3F.Controls.Add(nudDelayFrom);
		DE340D3F.Controls.Add(DC86BF92);
		DE340D3F.Controls.Add(E235DF1A);
		DE340D3F.Controls.Add(C3B5740D);
		DE340D3F.Controls.Add(C1924A14);
		DE340D3F.Controls.Add(label13);
		DE340D3F.Controls.Add(label9);
		DE340D3F.Controls.Add(C72E2135);
		DE340D3F.Controls.Add(btnCancel);
		DE340D3F.Controls.Add(btnAdd);
		DE340D3F.Controls.Add(bunifuCards1);
		DE340D3F.Cursor = Cursors.Arrow;
		DE340D3F.Dock = DockStyle.Fill;
		DE340D3F.Location = new Point(0, 0);
		DE340D3F.Name = "panel1";
		DE340D3F.Size = new Size(329, 222);
		DE340D3F.TabIndex = 0;
		DE340D3F.Paint += DE340D3F_Paint;
		txtIdPage.Location = new Point(134, 78);
		txtIdPage.Name = "txtIdPage";
		txtIdPage.Size = new Size(158, 23);
		txtIdPage.TabIndex = 38;
		nudDelayTo.Location = new Point(232, 136);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new Size(60, 23);
		nudDelayTo.TabIndex = 2;
		B8857B2D.AutoSize = true;
		B8857B2D.Location = new Point(27, 138);
		B8857B2D.Name = "label2";
		B8857B2D.Size = new Size(87, 16);
		B8857B2D.TabIndex = 32;
		B8857B2D.Text = "Gia\u0303n ca\u0301ch (s):";
		label4.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label4.Location = new Point(200, 138);
		label4.Name = "label4";
		label4.Size = new Size(29, 16);
		label4.TabIndex = 37;
		label4.Text = ">";
		label4.TextAlign = ContentAlignment.MiddleCenter;
		nudDelayFrom.Location = new Point(134, 136);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new Size(60, 23);
		nudDelayFrom.TabIndex = 1;
		DC86BF92.AutoSize = true;
		DC86BF92.Location = new Point(27, 78);
		DC86BF92.Name = "lblStatus";
		DC86BF92.Size = new Size(89, 16);
		DC86BF92.TabIndex = 0;
		DC86BF92.Text = "Nhập ID Page:";
		E235DF1A.Location = new Point(232, 107);
		E235DF1A.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		E235DF1A.Name = "nudSoLuongTo";
		E235DF1A.Size = new Size(60, 23);
		E235DF1A.TabIndex = 2;
		C3B5740D.Location = new Point(134, 107);
		C3B5740D.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C3B5740D.Name = "nudSoLuongFrom";
		C3B5740D.Size = new Size(60, 23);
		C3B5740D.TabIndex = 1;
		C1924A14.Location = new Point(134, 49);
		C1924A14.Name = "txtTenHanhDong";
		C1924A14.Size = new Size(158, 23);
		C1924A14.TabIndex = 0;
		label13.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label13.Location = new Point(200, 109);
		label13.Name = "label13";
		label13.Size = new Size(29, 16);
		label13.TabIndex = 37;
		label13.Text = ">";
		label13.TextAlign = ContentAlignment.MiddleCenter;
		label9.AutoSize = true;
		label9.Location = new Point(27, 109);
		label9.Name = "label9";
		label9.Size = new Size(63, 16);
		label9.TabIndex = 32;
		label9.Text = "Sô\u0301 lươ\u0323ng:";
		C72E2135.AutoSize = true;
		C72E2135.Location = new Point(27, 52);
		C72E2135.Name = "label1";
		C72E2135.Size = new Size(98, 16);
		C72E2135.TabIndex = 31;
		C72E2135.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(176, 181);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(69, 181);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += CB3C0495;
		bunifuCards1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(326, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(329, 222);
		base.Controls.Add(DE340D3F);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDMoiLikePage";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += D282E117_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		DE340D3F.ResumeLayout(performLayout: false);
		DE340D3F.PerformLayout();
		((ISupportInitialize)nudDelayTo).EndInit();
		((ISupportInitialize)nudDelayFrom).EndInit();
		((ISupportInitialize)E235DF1A).EndInit();
		((ISupportInitialize)C3B5740D).EndInit();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
