using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangStatus : Form
{
	private GClass11 CF3C7814;

	private string F60BA337;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl AA33EB8A;

	private BunifuDragControl bunifuDragControl_0;

	private Panel panel1;

	private TextBox DBB11D03;

	private Label label1;

	private Button btnCancel;

	private Button FD9DC122;

	private BunifuCards B30D0AA9;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel C1283887;

	private CheckBox ckbAnh;

	private CheckBox FD0C49B0;

	private Panel BF21718F;

	private Label D713CD10;

	private Panel plAnh;

	private TextBox B2A6A504;

	private RichTextBox F392383C;

	private CheckBox ckbUseBackground;

	private Panel plTag;

	private RichTextBox FC2E57A0;

	private Label label10;

	private Label F13B8B26;

	private CheckBox B60A0A35;

	private NumericUpDown nudUidTo;

	private NumericUpDown FBBCBAA8;

	private Label E3A1900A;

	private RadioButton rbUidTuNhap;

	private RadioButton EAA1E3AF;

	private Label label12;

	private Panel plUidTuNhap;

	private Label label20;

	private NumericUpDown nudKhoangCachTo;

	private NumericUpDown E8B428AD;

	private Label label17;

	private NumericUpDown B816078C;

	private NumericUpDown nudSoLuongFrom;

	private NumericUpDown nudSoLuongAnhTo;

	private NumericUpDown nudSoLuongAnhFrom;

	private Label label2;

	private Label label16;

	private Label label15;

	private Label label4;

	private Label label5;

	private ComboBox FD0AA70A;

	private Button btnHuongDanNhapNoiDung;

	private Label EC150621;

	private CheckBox A62C5418;

	public fHDDangStatus(string D228A305, int BD2AAD0C = 0, string D083213E = "")
	{
		AF13F601();
		bool_0 = false;
		F60BA337 = D228A305;
		string_1 = D083213E;
		int_0 = BD2AAD0C;
		if (Class147.smethod_7("", "HDDangStatus").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"CauHinh\", \"MoTa\") VALUES ('HDDangStatus', '{  \"ckbVanBan\": \"False\",\"txtNoiDung\": \"\",   \"ckbAnh\": \"False\",\"txtPathAnh\":\"\",\"nudSoLuongAnh\": \"1\",  \"ckbVideo\": \"False\",\"txtPathVideo\":\"\",\"nudSoLuongVideo\": \"1\"}', 'Đăng status');");
		}
		string text = "";
		switch (BD2AAD0C)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDDangStatus");
			text = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			DBB11D03.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(D083213E);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			FD9DC122.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			DBB11D03.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		CF3C7814 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDDangStatus_Load(object sender, EventArgs e)
	{
		method_0();
		try
		{
			nudSoLuongFrom.Value = CF3C7814.method_2("nudSoLuongFrom", 1);
			B816078C.Value = CF3C7814.method_2("nudSoLuongTo", 1);
			E8B428AD.Value = CF3C7814.method_2("nudKhoangCachFrom", 5);
			nudKhoangCachTo.Value = CF3C7814.method_2("nudKhoangCachTo", 10);
			FD0C49B0.Checked = CF3C7814.method_3("ckbVanBan");
			ckbUseBackground.Checked = CF3C7814.method_3("ckbUseBackground");
			F392383C.Text = CF3C7814.C0288288("txtNoiDung");
			ckbAnh.Checked = CF3C7814.method_3("ckbAnh");
			nudSoLuongAnhFrom.Value = CF3C7814.method_2("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = CF3C7814.method_2("nudSoLuongAnhTo", 1);
			B2A6A504.Text = CF3C7814.C0288288("txtPathAnh");
			FD0AA70A.SelectedIndex = CF3C7814.method_2("typeNganCach");
			if (CF3C7814.method_2("typeUidTag") == 0)
			{
				EAA1E3AF.Checked = true;
			}
			else
			{
				rbUidTuNhap.Checked = true;
			}
			B60A0A35.Checked = CF3C7814.method_3("ckbTag");
			FC2E57A0.Text = CF3C7814.C0288288("txtUidTag");
			FBBCBAA8.Value = CF3C7814.method_2("nudUidFrom", 1);
			nudUidTo.Value = CF3C7814.method_2("nudUidTo", 1);
			A62C5418.Checked = CF3C7814.method_3("ckbUuTienMbasic");
		}
		catch (Exception)
		{
		}
		method_1();
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(FD0AA70A, list_);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void ACA25B8E(object sender, EventArgs e)
	{
		string text = DBB11D03.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (ckbAnh.Checked && !Directory.Exists(B2A6A504.Text.Trim()))
		{
			GClass29.smethod_0("Đường dẫn ảnh không tồn tại!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", B816078C.Value);
		gClass.method_4("nudKhoangCachFrom", E8B428AD.Value);
		gClass.method_4("nudKhoangCachTo", nudKhoangCachTo.Value);
		gClass.method_4("ckbVanBan", FD0C49B0.Checked);
		gClass.method_4("ckbUseBackground", ckbUseBackground.Checked);
		gClass.method_4("ckbAnh", ckbAnh.Checked);
		gClass.method_4("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		gClass.method_4("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		gClass.method_4("txtNoiDung", F392383C.Text.Trim());
		gClass.method_4("txtPathAnh", B2A6A504.Text.Trim());
		gClass.method_4("typeNganCach", FD0AA70A.SelectedIndex);
		if (EAA1E3AF.Checked)
		{
			gClass.method_4("typeUidTag", 0);
		}
		else if (rbUidTuNhap.Checked)
		{
			gClass.method_4("typeUidTag", 1);
		}
		gClass.method_4("ckbTag", B60A0A35.Checked);
		gClass.method_4("txtUidTag", FC2E57A0.Text.Trim());
		gClass.method_4("nudUidFrom", FBBCBAA8.Value);
		gClass.method_4("nudUidTo", nudUidTo.Value);
		gClass.method_4("ckbUuTienMbasic", A62C5418.Checked);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(F60BA337, text, string_0, string_))
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
			if (Class147.smethod_13(string_1, text, string_))
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

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void method_1()
	{
		FD0C49B0_CheckedChanged(null, null);
		ckbAnh_CheckedChanged(null, null);
		method_2(null, null);
		B60A0A35_CheckedChanged(null, null);
		D5BE3617(null, null);
	}

	private void FD0C49B0_CheckedChanged(object sender, EventArgs e)
	{
		BF21718F.Enabled = FD0C49B0.Checked;
		if (!FD0C49B0.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
		if (ckbAnh.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void F71C4E2E(object sender, EventArgs e)
	{
		GClass8.smethod_60(F392383C, D713CD10, FD0AA70A.SelectedIndex);
	}

	private void FC978AAE(object sender, EventArgs e)
	{
	}

	private void ckbUseBackground_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void B60A0A35_CheckedChanged(object sender, EventArgs e)
	{
		plTag.Enabled = B60A0A35.Checked;
	}

	private void FC2E57A0_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(FC2E57A0, F13B8B26);
	}

	private void F13B8B26_Click(object sender, EventArgs e)
	{
	}

	private void A23345B6(object sender, EventArgs e)
	{
	}

	private void D5BE3617(object sender, EventArgs e)
	{
		plUidTuNhap.Enabled = rbUidTuNhap.Checked;
	}

	private void B2A6A504_TextChanged(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, EventArgs e)
	{
		string eD = F7AB102E.smethod_0("Có thể dùng:") + Environment.NewLine + F7AB102E.smethod_0("- [full_name] để thay thế họ tên của tài khoản!") + Environment.NewLine + F7AB102E.smethod_0("- [name] để thay thế tên của tài khoản!");
		GClass29.smethod_0(eD);
	}

	private void E29131B5(object sender, EventArgs e)
	{
		GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		F392383C.Focus();
	}

	private void method_4(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHelpNhapComment());
		F392383C.Focus();
	}

	private void method_5(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	private void FD0AA70A_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(F392383C, D713CD10, FD0AA70A.SelectedIndex);
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (FD0AA70A.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		F392383C.Focus();
	}

	private void A62C5418_CheckedChanged(object sender, EventArgs e)
	{
		ckbUseBackground.Enabled = !A62C5418.Checked;
		if (A62C5418.Checked)
		{
			ckbUseBackground.Checked = false;
		}
	}

	protected override void Dispose(bool BC206491)
	{
		if (BC206491 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(BC206491);
	}

	private void AF13F601()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDangStatus));
		AA33EB8A = new BunifuDragControl(icontainer_0);
		C1283887 = new BunifuCustomLabel();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		button1 = new Button();
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		label16 = new Label();
		label15 = new Label();
		label20 = new Label();
		nudKhoangCachTo = new NumericUpDown();
		E8B428AD = new NumericUpDown();
		label17 = new Label();
		B816078C = new NumericUpDown();
		nudSoLuongFrom = new NumericUpDown();
		plTag = new Panel();
		plUidTuNhap = new Panel();
		F13B8B26 = new Label();
		FC2E57A0 = new RichTextBox();
		rbUidTuNhap = new RadioButton();
		EAA1E3AF = new RadioButton();
		nudUidTo = new NumericUpDown();
		FBBCBAA8 = new NumericUpDown();
		label12 = new Label();
		label10 = new Label();
		E3A1900A = new Label();
		BF21718F = new Panel();
		F392383C = new RichTextBox();
		D713CD10 = new Label();
		FD9DC122 = new Button();
		plAnh = new Panel();
		label4 = new Label();
		label5 = new Label();
		nudSoLuongAnhTo = new NumericUpDown();
		nudSoLuongAnhFrom = new NumericUpDown();
		label2 = new Label();
		B2A6A504 = new TextBox();
		B60A0A35 = new CheckBox();
		ckbUseBackground = new CheckBox();
		ckbAnh = new CheckBox();
		FD0C49B0 = new CheckBox();
		DBB11D03 = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		B30D0AA9 = new BunifuCards();
		FD0AA70A = new ComboBox();
		btnHuongDanNhapNoiDung = new Button();
		EC150621 = new Label();
		A62C5418 = new CheckBox();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)nudKhoangCachTo).BeginInit();
		((ISupportInitialize)E8B428AD).BeginInit();
		((ISupportInitialize)B816078C).BeginInit();
		((ISupportInitialize)nudSoLuongFrom).BeginInit();
		plTag.SuspendLayout();
		plUidTuNhap.SuspendLayout();
		((ISupportInitialize)nudUidTo).BeginInit();
		((ISupportInitialize)FBBCBAA8).BeginInit();
		BF21718F.SuspendLayout();
		plAnh.SuspendLayout();
		((ISupportInitialize)nudSoLuongAnhTo).BeginInit();
		((ISupportInitialize)nudSoLuongAnhFrom).BeginInit();
		B30D0AA9.SuspendLayout();
		SuspendLayout();
		AA33EB8A.Fixed = true;
		AA33EB8A.Horizontal = true;
		AA33EB8A.TargetControl = C1283887;
		AA33EB8A.Vertical = true;
		C1283887.BackColor = Color.Transparent;
		C1283887.Cursor = Cursors.SizeAll;
		C1283887.Dock = DockStyle.Fill;
		C1283887.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C1283887.ForeColor = Color.Black;
		C1283887.Location = new Point(0, 0);
		C1283887.Name = "bunifuCustomLabel1";
		C1283887.Size = new Size(654, 31);
		C1283887.TabIndex = 12;
		C1283887.Text = "Cấu hình Đăng status";
		C1283887.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(C1283887);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(654, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		button1.Cursor = Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = FlatStyle.Flat;
		button1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		button1.ForeColor = Color.White;
		button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
		button1.Location = new Point(623, 1);
		button1.Name = "button1";
		button1.Size = new Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += FC978AAE;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(A62C5418);
		panel1.Controls.Add(label16);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(label20);
		panel1.Controls.Add(nudKhoangCachTo);
		panel1.Controls.Add(E8B428AD);
		panel1.Controls.Add(label17);
		panel1.Controls.Add(B816078C);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(plTag);
		panel1.Controls.Add(BF21718F);
		panel1.Controls.Add(FD9DC122);
		panel1.Controls.Add(plAnh);
		panel1.Controls.Add(B60A0A35);
		panel1.Controls.Add(ckbUseBackground);
		panel1.Controls.Add(ckbAnh);
		panel1.Controls.Add(FD0C49B0);
		panel1.Controls.Add(DBB11D03);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(B30D0AA9);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(657, 612);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		label16.AutoSize = true;
		label16.Location = new Point(30, 112);
		label16.Name = "label16";
		label16.Size = new Size(87, 16);
		label16.TabIndex = 45;
		label16.Text = "Gia\u0303n ca\u0301ch (s):";
		label15.AutoSize = true;
		label15.Location = new Point(30, 83);
		label15.Name = "label15";
		label15.Size = new Size(84, 16);
		label15.TabIndex = 44;
		label15.Text = "Số lượng bài:";
		label20.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label20.Location = new Point(205, 109);
		label20.Name = "label20";
		label20.Size = new Size(29, 16);
		label20.TabIndex = 42;
		label20.Text = ">";
		label20.TextAlign = ContentAlignment.MiddleCenter;
		nudKhoangCachTo.Location = new Point(236, 107);
		nudKhoangCachTo.Name = "nudKhoangCachTo";
		nudKhoangCachTo.Size = new Size(51, 23);
		nudKhoangCachTo.TabIndex = 41;
		E8B428AD.Location = new Point(151, 107);
		E8B428AD.Name = "nudKhoangCachFrom";
		E8B428AD.Size = new Size(51, 23);
		E8B428AD.TabIndex = 40;
		label17.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label17.Location = new Point(205, 83);
		label17.Name = "label17";
		label17.Size = new Size(29, 16);
		label17.TabIndex = 38;
		label17.Text = ">";
		label17.TextAlign = ContentAlignment.MiddleCenter;
		B816078C.Location = new Point(236, 78);
		B816078C.Name = "nudSoLuongTo";
		B816078C.Size = new Size(51, 23);
		B816078C.TabIndex = 37;
		nudSoLuongFrom.Location = new Point(151, 78);
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new Size(51, 23);
		nudSoLuongFrom.TabIndex = 36;
		plTag.BorderStyle = BorderStyle.FixedSingle;
		plTag.Controls.Add(plUidTuNhap);
		plTag.Controls.Add(rbUidTuNhap);
		plTag.Controls.Add(EAA1E3AF);
		plTag.Controls.Add(nudUidTo);
		plTag.Controls.Add(FBBCBAA8);
		plTag.Controls.Add(label12);
		plTag.Controls.Add(label10);
		plTag.Controls.Add(E3A1900A);
		plTag.Enabled = false;
		plTag.Location = new Point(370, 269);
		plTag.Name = "plTag";
		plTag.Size = new Size(251, 255);
		plTag.TabIndex = 33;
		plUidTuNhap.BorderStyle = BorderStyle.FixedSingle;
		plUidTuNhap.Controls.Add(F13B8B26);
		plUidTuNhap.Controls.Add(FC2E57A0);
		plUidTuNhap.Location = new Point(17, 97);
		plUidTuNhap.Name = "plUidTuNhap";
		plUidTuNhap.Size = new Size(227, 151);
		plUidTuNhap.TabIndex = 34;
		F13B8B26.AutoSize = true;
		F13B8B26.Location = new Point(3, 3);
		F13B8B26.Name = "lblUidTag";
		F13B8B26.Size = new Size(114, 16);
		F13B8B26.TabIndex = 0;
		F13B8B26.Text = "Danh sa\u0301ch Uid (0):";
		F13B8B26.Click += F13B8B26_Click;
		FC2E57A0.Location = new Point(7, 22);
		FC2E57A0.Name = "txtUidTag";
		FC2E57A0.Size = new Size(215, 124);
		FC2E57A0.TabIndex = 34;
		FC2E57A0.Text = "";
		FC2E57A0.WordWrap = false;
		FC2E57A0.TextChanged += FC2E57A0_TextChanged;
		rbUidTuNhap.AutoSize = true;
		rbUidTuNhap.Cursor = Cursors.Hand;
		rbUidTuNhap.Location = new Point(17, 73);
		rbUidTuNhap.Name = "rbUidTuNhap";
		rbUidTuNhap.Size = new Size(186, 20);
		rbUidTuNhap.TabIndex = 42;
		rbUidTuNhap.Text = "Theo danh sách Uid tự nhập";
		rbUidTuNhap.UseVisualStyleBackColor = true;
		rbUidTuNhap.CheckedChanged += D5BE3617;
		EAA1E3AF.AutoSize = true;
		EAA1E3AF.Checked = true;
		EAA1E3AF.Cursor = Cursors.Hand;
		EAA1E3AF.Location = new Point(17, 50);
		EAA1E3AF.Name = "rbUidBanBe";
		EAA1E3AF.Size = new Size(194, 20);
		EAA1E3AF.TabIndex = 42;
		EAA1E3AF.TabStop = true;
		EAA1E3AF.Text = "Ngẫu nhiên danh sách bạn bè";
		EAA1E3AF.UseVisualStyleBackColor = true;
		nudUidTo.Location = new Point(208, 4);
		nudUidTo.Maximum = new decimal(new int[4] { 50, 0, 0, 0 });
		nudUidTo.Name = "nudUidTo";
		nudUidTo.Size = new Size(36, 23);
		nudUidTo.TabIndex = 39;
		nudUidTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		FBBCBAA8.Location = new Point(137, 4);
		FBBCBAA8.Maximum = new decimal(new int[4] { 50, 0, 0, 0 });
		FBBCBAA8.Name = "nudUidFrom";
		FBBCBAA8.Size = new Size(36, 23);
		FBBCBAA8.TabIndex = 38;
		FBBCBAA8.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label12.AutoSize = true;
		label12.Location = new Point(3, 31);
		label12.Name = "label12";
		label12.Size = new Size(126, 16);
		label12.TabIndex = 0;
		label12.Text = "Tùy chọn Uid để tag:";
		label10.AutoSize = true;
		label10.Location = new Point(3, 6);
		label10.Name = "label10";
		label10.Size = new Size(117, 16);
		label10.TabIndex = 0;
		label10.Text = "Số Uid cần tag/bài:";
		E3A1900A.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		E3A1900A.Location = new Point(176, 6);
		E3A1900A.Name = "label13";
		E3A1900A.Size = new Size(29, 16);
		E3A1900A.TabIndex = 41;
		E3A1900A.Text = ">";
		E3A1900A.TextAlign = ContentAlignment.MiddleCenter;
		BF21718F.BorderStyle = BorderStyle.FixedSingle;
		BF21718F.Controls.Add(FD0AA70A);
		BF21718F.Controls.Add(btnHuongDanNhapNoiDung);
		BF21718F.Controls.Add(EC150621);
		BF21718F.Controls.Add(F392383C);
		BF21718F.Controls.Add(D713CD10);
		BF21718F.Location = new Point(47, 159);
		BF21718F.Name = "plVanBan";
		BF21718F.Size = new Size(278, 391);
		BF21718F.TabIndex = 33;
		F392383C.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		F392383C.Location = new Point(7, 24);
		F392383C.Name = "txtNoiDung";
		F392383C.Size = new Size(263, 330);
		F392383C.TabIndex = 34;
		F392383C.Text = "";
		F392383C.WordWrap = false;
		F392383C.TextChanged += F71C4E2E;
		D713CD10.AutoSize = true;
		D713CD10.Location = new Point(3, 4);
		D713CD10.Name = "lblNoiDung";
		D713CD10.Size = new Size(145, 16);
		D713CD10.TabIndex = 0;
		D713CD10.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		FD9DC122.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		FD9DC122.BackColor = Color.FromArgb(53, 120, 229);
		FD9DC122.Cursor = Cursors.Hand;
		FD9DC122.FlatAppearance.BorderSize = 0;
		FD9DC122.FlatStyle = FlatStyle.Flat;
		FD9DC122.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		FD9DC122.ForeColor = Color.White;
		FD9DC122.Location = new Point(245, 565);
		FD9DC122.Name = "btnAdd";
		FD9DC122.Size = new Size(92, 29);
		FD9DC122.TabIndex = 3;
		FD9DC122.Text = "Thêm";
		FD9DC122.UseVisualStyleBackColor = false;
		FD9DC122.Click += ACA25B8E;
		plAnh.BorderStyle = BorderStyle.FixedSingle;
		plAnh.Controls.Add(label4);
		plAnh.Controls.Add(label5);
		plAnh.Controls.Add(nudSoLuongAnhTo);
		plAnh.Controls.Add(nudSoLuongAnhFrom);
		plAnh.Controls.Add(label2);
		plAnh.Controls.Add(B2A6A504);
		plAnh.Location = new Point(370, 181);
		plAnh.Name = "plAnh";
		plAnh.Size = new Size(251, 60);
		plAnh.TabIndex = 33;
		label4.AutoSize = true;
		label4.Location = new Point(3, 6);
		label4.Name = "label4";
		label4.Size = new Size(73, 16);
		label4.TabIndex = 46;
		label4.Text = "Folder ảnh:";
		label5.AutoSize = true;
		label5.Location = new Point(3, 32);
		label5.Name = "label5";
		label5.Size = new Size(74, 16);
		label5.TabIndex = 47;
		label5.Text = "Sô\u0301 a\u0309nh/bài:";
		nudSoLuongAnhTo.Location = new Point(171, 30);
		nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		nudSoLuongAnhTo.Size = new Size(45, 23);
		nudSoLuongAnhTo.TabIndex = 7;
		nudSoLuongAnhFrom.Location = new Point(82, 30);
		nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		nudSoLuongAnhFrom.Size = new Size(45, 23);
		nudSoLuongAnhFrom.TabIndex = 8;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		label2.Location = new Point(134, 32);
		label2.Name = "label2";
		label2.Size = new Size(29, 16);
		label2.TabIndex = 4;
		label2.Text = ">";
		label2.TextAlign = ContentAlignment.MiddleCenter;
		B2A6A504.Location = new Point(82, 3);
		B2A6A504.Name = "txtPathAnh";
		B2A6A504.Size = new Size(162, 23);
		B2A6A504.TabIndex = 1;
		B2A6A504.TextChanged += B2A6A504_TextChanged;
		B60A0A35.AutoSize = true;
		B60A0A35.Cursor = Cursors.Hand;
		B60A0A35.Location = new Point(356, 245);
		B60A0A35.Name = "ckbTag";
		B60A0A35.Size = new Size(139, 20);
		B60A0A35.TabIndex = 32;
		B60A0A35.Text = "Tag Uid vào bài viết";
		B60A0A35.UseVisualStyleBackColor = true;
		B60A0A35.CheckedChanged += B60A0A35_CheckedChanged;
		ckbUseBackground.AutoSize = true;
		ckbUseBackground.Cursor = Cursors.Hand;
		ckbUseBackground.Location = new Point(356, 135);
		ckbUseBackground.Name = "ckbUseBackground";
		ckbUseBackground.Size = new Size(144, 20);
		ckbUseBackground.TabIndex = 32;
		ckbUseBackground.Text = "Sử dụng Background";
		ckbUseBackground.UseVisualStyleBackColor = true;
		ckbUseBackground.CheckedChanged += ckbUseBackground_CheckedChanged;
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = Cursors.Hand;
		ckbAnh.Location = new Point(356, 159);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new Size(48, 20);
		ckbAnh.TabIndex = 32;
		ckbAnh.Text = "A\u0309nh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += ckbAnh_CheckedChanged;
		FD0C49B0.AutoSize = true;
		FD0C49B0.Cursor = Cursors.Hand;
		FD0C49B0.Location = new Point(33, 135);
		FD0C49B0.Name = "ckbVanBan";
		FD0C49B0.Size = new Size(73, 20);
		FD0C49B0.TabIndex = 32;
		FD0C49B0.Text = "Văn ba\u0309n";
		FD0C49B0.UseVisualStyleBackColor = true;
		FD0C49B0.CheckedChanged += FD0C49B0_CheckedChanged;
		DBB11D03.Location = new Point(151, 49);
		DBB11D03.Name = "txtTenHanhDong";
		DBB11D03.Size = new Size(174, 23);
		DBB11D03.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(30, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(344, 565);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		B30D0AA9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		B30D0AA9.BackColor = Color.White;
		B30D0AA9.BorderRadius = 0;
		B30D0AA9.BottomSahddow = true;
		B30D0AA9.color = Color.DarkViolet;
		B30D0AA9.Controls.Add(pnlHeader);
		B30D0AA9.LeftSahddow = false;
		B30D0AA9.Location = new Point(1, 0);
		B30D0AA9.Name = "bunifuCards1";
		B30D0AA9.RightSahddow = true;
		B30D0AA9.ShadowDepth = 20;
		B30D0AA9.Size = new Size(654, 37);
		B30D0AA9.TabIndex = 28;
		FD0AA70A.Anchor = AnchorStyles.Bottom;
		FD0AA70A.Cursor = Cursors.Hand;
		FD0AA70A.DropDownStyle = ComboBoxStyle.DropDownList;
		FD0AA70A.FormattingEnabled = true;
		FD0AA70A.Location = new Point(66, 359);
		FD0AA70A.Name = "cbbTuyChonNoiDung";
		FD0AA70A.Size = new Size(172, 24);
		FD0AA70A.TabIndex = 200;
		FD0AA70A.SelectedIndexChanged += FD0AA70A_SelectedIndexChanged;
		btnHuongDanNhapNoiDung.Anchor = AnchorStyles.Bottom;
		btnHuongDanNhapNoiDung.Cursor = Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new Point(244, 358);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 199;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += btnHuongDanNhapNoiDung_Click;
		EC150621.Anchor = AnchorStyles.Bottom;
		EC150621.AutoSize = true;
		EC150621.Location = new Point(0, 362);
		EC150621.Name = "label11";
		EC150621.Size = new Size(64, 16);
		EC150621.TabIndex = 198;
		EC150621.Text = "Tùy chọn:";
		A62C5418.AutoSize = true;
		A62C5418.Cursor = Cursors.Hand;
		A62C5418.Location = new Point(356, 530);
		A62C5418.Name = "ckbUuTienMbasic";
		A62C5418.Size = new Size(173, 20);
		A62C5418.TabIndex = 199;
		A62C5418.Text = "Ưu tiên chạy bằng mbasic";
		A62C5418.UseVisualStyleBackColor = true;
		A62C5418.CheckedChanged += A62C5418_CheckedChanged;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(657, 612);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDangStatus";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDDangStatus_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)nudKhoangCachTo).EndInit();
		((ISupportInitialize)E8B428AD).EndInit();
		((ISupportInitialize)B816078C).EndInit();
		((ISupportInitialize)nudSoLuongFrom).EndInit();
		plTag.ResumeLayout(performLayout: false);
		plTag.PerformLayout();
		plUidTuNhap.ResumeLayout(performLayout: false);
		plUidTuNhap.PerformLayout();
		((ISupportInitialize)nudUidTo).EndInit();
		((ISupportInitialize)FBBCBAA8).EndInit();
		BF21718F.ResumeLayout(performLayout: false);
		BF21718F.PerformLayout();
		plAnh.ResumeLayout(performLayout: false);
		plAnh.PerformLayout();
		((ISupportInitialize)nudSoLuongAnhTo).EndInit();
		((ISupportInitialize)nudSoLuongAnhFrom).EndInit();
		B30D0AA9.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
