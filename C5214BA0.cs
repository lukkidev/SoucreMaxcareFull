using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class C5214BA0 : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string string_1;

	private string FB9EAD26;

	private int C10C4BAB;

	public static bool AF20E8A1;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl A40FAC25;

	private Panel C72F7028;

	private TextBox FAAB0B21;

	private Label DE8A2FB7;

	private Label C6B3E028;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private TextBox txtPathFolder;

	private CheckBox B1053901;

	private CheckBox ckbSkipIfHave;

	private CheckBox ckbThemKhungAvatar;

	private CheckBox ckbUuTienMbasic;

	public C5214BA0(string D1BFEF05, int int_0 = 0, string string_2 = "")
	{
		E4395D0A();
		AF20E8A1 = false;
		string_0 = D1BFEF05;
		FB9EAD26 = string_2;
		C10C4BAB = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Up Avatar";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			FAAB0B21.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			FAAB0B21.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void C5214BA0_Load(object sender, EventArgs e)
	{
		try
		{
			txtPathFolder.Text = gclass11_0.C0288288("txtPathFolder");
			B1053901.Checked = gclass11_0.method_3("ckbXoaAnhDaDung");
			ckbThemKhungAvatar.Checked = gclass11_0.method_3("ckbThemKhungAvatar");
			ckbSkipIfHave.Checked = gclass11_0.method_3("ckbSkipIfHave");
			ckbUuTienMbasic.Checked = gclass11_0.method_3("ckbUuTienMbasic", bool_0: true);
			F31D2995(null, null);
		}
		catch
		{
		}
	}

	private void B63A0390(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = FAAB0B21.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		_ = txtPathFolder.Text;
		GClass11 gClass = new GClass11();
		gClass.method_4("txtPathFolder", txtPathFolder.Text);
		gClass.method_4("ckbXoaAnhDaDung", B1053901.Checked);
		gClass.method_4("ckbThemKhungAvatar", ckbThemKhungAvatar.Checked);
		gClass.method_4("ckbSkipIfHave", ckbSkipIfHave.Checked);
		gClass.method_4("ckbUuTienMbasic", ckbUuTienMbasic.Checked);
		string string_ = gClass.method_7();
		if (C10C4BAB == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
				{
					AF20E8A1 = true;
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
			if (Class147.smethod_13(FB9EAD26, text, string_))
			{
				AF20E8A1 = true;
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

	private void C72F7028_Paint(object sender, PaintEventArgs e)
	{
		if (C72F7028.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C72F7028.ClientSize.Width - num, C72F7028.ClientSize.Height - num));
		}
	}

	private void A00F0810(object sender, EventArgs e)
	{
	}

	private void F31D2995(object sender, EventArgs e)
	{
		if (ckbUuTienMbasic.Checked)
		{
			ckbThemKhungAvatar.Checked = false;
			ckbThemKhungAvatar.Enabled = false;
		}
		else
		{
			ckbThemKhungAvatar.Enabled = true;
		}
	}

	protected override void Dispose(bool AD1A4918)
	{
		if (AD1A4918 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(AD1A4918);
	}

	private void E4395D0A()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(C5214BA0));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		A40FAC25 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		C72F7028 = new Panel();
		ckbSkipIfHave = new CheckBox();
		txtPathFolder = new TextBox();
		FAAB0B21 = new TextBox();
		DE8A2FB7 = new Label();
		C6B3E028 = new Label();
		btnCancel = new Button();
		btnAdd = new Button();
		bunifuCards1 = new BunifuCards();
		ckbThemKhungAvatar = new CheckBox();
		B1053901 = new CheckBox();
		ckbUuTienMbasic = new CheckBox();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		C72F7028.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Up Avatar";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		A40FAC25.Fixed = true;
		A40FAC25.Horizontal = true;
		A40FAC25.TargetControl = pnlHeader;
		A40FAC25.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(359, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(328, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += B63A0390;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += A00F0810;
		C72F7028.BackColor = Color.White;
		C72F7028.BorderStyle = BorderStyle.FixedSingle;
		C72F7028.Controls.Add(ckbUuTienMbasic);
		C72F7028.Controls.Add(ckbSkipIfHave);
		C72F7028.Controls.Add(txtPathFolder);
		C72F7028.Controls.Add(FAAB0B21);
		C72F7028.Controls.Add(DE8A2FB7);
		C72F7028.Controls.Add(C6B3E028);
		C72F7028.Controls.Add(btnCancel);
		C72F7028.Controls.Add(btnAdd);
		C72F7028.Controls.Add(bunifuCards1);
		C72F7028.Controls.Add(ckbThemKhungAvatar);
		C72F7028.Controls.Add(B1053901);
		C72F7028.Cursor = Cursors.Arrow;
		C72F7028.Dock = DockStyle.Fill;
		C72F7028.Location = new Point(0, 0);
		C72F7028.Name = "panel1";
		C72F7028.Size = new Size(362, 271);
		C72F7028.TabIndex = 0;
		C72F7028.Paint += C72F7028_Paint;
		ckbSkipIfHave.AutoSize = true;
		ckbSkipIfHave.Cursor = Cursors.Hand;
		ckbSkipIfHave.Location = new Point(132, 159);
		ckbSkipIfHave.Name = "ckbSkipIfHave";
		ckbSkipIfHave.Size = new Size(165, 20);
		ckbSkipIfHave.TabIndex = 35;
		ckbSkipIfHave.Text = "Bỏ qua nếu đã có avatar";
		ckbSkipIfHave.UseVisualStyleBackColor = true;
		txtPathFolder.Location = new Point(132, 79);
		txtPathFolder.Name = "txtPathFolder";
		txtPathFolder.Size = new Size(194, 23);
		txtPathFolder.TabIndex = 0;
		FAAB0B21.Location = new Point(132, 49);
		FAAB0B21.Name = "txtTenHanhDong";
		FAAB0B21.Size = new Size(194, 23);
		FAAB0B21.TabIndex = 0;
		DE8A2FB7.AutoSize = true;
		DE8A2FB7.Location = new Point(27, 82);
		DE8A2FB7.Name = "label5";
		DE8A2FB7.Size = new Size(73, 16);
		DE8A2FB7.TabIndex = 34;
		DE8A2FB7.Text = "Folder ảnh:";
		C6B3E028.AutoSize = true;
		C6B3E028.Location = new Point(27, 52);
		C6B3E028.Name = "label1";
		C6B3E028.Size = new Size(98, 16);
		C6B3E028.TabIndex = 31;
		C6B3E028.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(189, 226);
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
		btnAdd.Location = new Point(82, 226);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
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
		bunifuCards1.Size = new Size(359, 37);
		bunifuCards1.TabIndex = 28;
		ckbThemKhungAvatar.AutoSize = true;
		ckbThemKhungAvatar.Cursor = Cursors.Hand;
		ckbThemKhungAvatar.Location = new Point(132, 133);
		ckbThemKhungAvatar.Name = "ckbThemKhungAvatar";
		ckbThemKhungAvatar.Size = new Size(137, 20);
		ckbThemKhungAvatar.TabIndex = 35;
		ckbThemKhungAvatar.Text = "Thêm khung avatar";
		ckbThemKhungAvatar.UseVisualStyleBackColor = true;
		B1053901.AutoSize = true;
		B1053901.Cursor = Cursors.Hand;
		B1053901.Location = new Point(132, 108);
		B1053901.Name = "ckbXoaAnhDaDung";
		B1053901.Size = new Size(173, 20);
		B1053901.TabIndex = 35;
		B1053901.Text = "Tự động xóa ảnh đã dùng";
		B1053901.UseVisualStyleBackColor = true;
		ckbUuTienMbasic.AutoSize = true;
		ckbUuTienMbasic.Cursor = Cursors.Hand;
		ckbUuTienMbasic.Location = new Point(132, 185);
		ckbUuTienMbasic.Name = "ckbUuTienMbasic";
		ckbUuTienMbasic.Size = new Size(173, 20);
		ckbUuTienMbasic.TabIndex = 198;
		ckbUuTienMbasic.Text = "Ưu tiên chạy bằng mbasic";
		ckbUuTienMbasic.UseVisualStyleBackColor = true;
		ckbUuTienMbasic.CheckedChanged += F31D2995;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(362, 271);
		base.Controls.Add(C72F7028);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDUpAvatar";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += C5214BA0_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		C72F7028.ResumeLayout(performLayout: false);
		C72F7028.PerformLayout();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
