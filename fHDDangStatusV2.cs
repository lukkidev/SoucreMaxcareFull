using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangStatusV2 : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string A1880F3D;

	private int int_0;

	public static bool D93A4CA8;

	private IContainer icontainer_0 = null;

	private BunifuDragControl C3256C96;

	private BunifuDragControl bunifuDragControl_0;

	private Panel C68A0FB9;

	private TextBox FB211121;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards A3817A8E;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private CheckBox ckbAnh;

	private CheckBox DC35CF9D;

	private Panel D8B23E9B;

	private Label label8;

	private Label C32CB032;

	private Panel plAnh;

	private TextBox BD1B123B;

	private RichTextBox txtNoiDung;

	private RadioButton rbNganCachKyTu;

	private RadioButton CE95910D;

	private Label B0B54418;

	private Button btnDown;

	private Button btnUp;

	private Panel FFB6F6A8;

	private Label label10;

	private CheckBox ckbTag;

	private NumericUpDown C5A8FA0F;

	private NumericUpDown B3127990;

	private Label label20;

	private NumericUpDown D533DF97;

	private NumericUpDown nudKhoangCachFrom;

	private Label DB8A88AF;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudSoLuongFrom;

	private Label DC20FC27;

	private Label label15;

	private NumericUpDown nudSoLuongAnhTo;

	private NumericUpDown nudSoLuongAnhFrom;

	private Label label2;

	private CheckBox B90A3D37;

	private CheckBox ckbDangAnhTheoThuTu;

	private Label A79F63BB;

	private Label A51C259B;

	private NumericUpDown nudDelayTagTo;

	private NumericUpDown nudDelayTagFrom;

	private Label label5;

	private Label D237D186;

	private Label label11;

	public fHDDangStatusV2(string string_2, int B2868100 = 0, string string_3 = "")
	{
		InitializeComponent();
		D93A4CA8 = false;
		string_0 = string_2;
		A1880F3D = string_3;
		int_0 = B2868100;
		string text = "HDDangStatusV2";
		string text2 = "Đăng status v2";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (B2868100)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			FB211121.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			FB211121.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void B2A96B8D(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			nudSoLuongTo.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			nudKhoangCachFrom.Value = gclass11_0.method_2("nudKhoangCachFrom", 5);
			D533DF97.Value = gclass11_0.method_2("nudKhoangCachTo", 10);
			DC35CF9D.Checked = gclass11_0.method_3("ckbVanBan");
			txtNoiDung.Text = gclass11_0.C0288288("txtNoiDung");
			ckbAnh.Checked = gclass11_0.method_3("ckbAnh");
			ckbDangAnhTheoThuTu.Checked = gclass11_0.method_3("ckbDangAnhTheoThuTu");
			nudSoLuongAnhFrom.Value = gclass11_0.method_2("nudSoLuongAnhFrom", 1);
			nudSoLuongAnhTo.Value = gclass11_0.method_2("nudSoLuongAnhTo", 1);
			BD1B123B.Text = gclass11_0.C0288288("txtPathAnh");
			if (gclass11_0.method_2("typeNganCach") == 1)
			{
				rbNganCachKyTu.Checked = true;
			}
			else
			{
				CE95910D.Checked = true;
			}
			ckbTag.Checked = gclass11_0.method_3("ckbTag");
			B3127990.Value = gclass11_0.method_2("nudUidFrom", 1);
			C5A8FA0F.Value = gclass11_0.method_2("nudUidTo", 1);
			B90A3D37.Checked = gclass11_0.method_3("ckbOnlyTagVNName");
			nudDelayTagFrom.Value = gclass11_0.method_2("nudDelayTagFrom");
			nudDelayTagTo.Value = gclass11_0.method_2("nudDelayTagTo");
		}
		catch (Exception)
		{
		}
		method_0();
	}

	private void EE2EABBE(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = FB211121.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		if (ckbAnh.Checked && !Directory.Exists(BD1B123B.Text.Trim()))
		{
			GClass29.smethod_0("Đường dẫn ảnh không tồn tại!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudKhoangCachFrom", nudKhoangCachFrom.Value);
		gClass.method_4("nudKhoangCachTo", D533DF97.Value);
		gClass.method_4("ckbVanBan", DC35CF9D.Checked);
		gClass.method_4("ckbAnh", ckbAnh.Checked);
		gClass.method_4("ckbDangAnhTheoThuTu", ckbDangAnhTheoThuTu.Checked);
		gClass.method_4("nudSoLuongAnhFrom", nudSoLuongAnhFrom.Value);
		gClass.method_4("nudSoLuongAnhTo", nudSoLuongAnhTo.Value);
		gClass.method_4("txtNoiDung", txtNoiDung.Text.Trim());
		gClass.method_4("txtPathAnh", BD1B123B.Text.Trim());
		int num = 0;
		if (rbNganCachKyTu.Checked)
		{
			num = 1;
		}
		gClass.method_4("typeNganCach", num);
		gClass.method_4("ckbTag", ckbTag.Checked);
		gClass.method_4("nudUidFrom", B3127990.Value);
		gClass.method_4("nudUidTo", C5A8FA0F.Value);
		gClass.method_4("ckbOnlyTagVNName", B90A3D37.Checked);
		gClass.method_4("nudDelayTagFrom", nudDelayTagFrom.Value);
		gClass.method_4("nudDelayTagTo", nudDelayTagTo.Value);
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
				{
					D93A4CA8 = true;
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
			if (Class147.smethod_13(A1880F3D, text, string_))
			{
				D93A4CA8 = true;
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

	private void C68A0FB9_Paint(object sender, PaintEventArgs e)
	{
		if (C68A0FB9.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, C68A0FB9.ClientSize.Width - num, C68A0FB9.ClientSize.Height - num));
		}
	}

	private void method_0()
	{
		E019070B(null, null);
		ckbAnh_CheckedChanged(null, null);
		E6A9D882(null, null);
		method_2(null, null);
	}

	private void E019070B(object sender, EventArgs e)
	{
		D8B23E9B.Enabled = DC35CF9D.Checked;
	}

	private void ckbAnh_CheckedChanged(object sender, EventArgs e)
	{
		plAnh.Enabled = ckbAnh.Checked;
	}

	private void txtNoiDung_TextChanged(object sender, EventArgs e)
	{
		EBB7D29E();
	}

	private void EBB7D29E()
	{
		try
		{
			List<string> list = new List<string>();
			list = ((!CE95910D.Checked) ? txtNoiDung.Text.Split(new string[1] { "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).ToList() : txtNoiDung.Lines.ToList());
			list = GClass8.smethod_36(list);
			C32CB032.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch nô\u0323i dung ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	private void D11D0887(object sender, EventArgs e)
	{
		if ((e as MouseEventArgs).Button == MouseButtons.Right && Control.ModifierKeys == Keys.Control)
		{
			btnUp.Visible = true;
			btnDown.Visible = true;
		}
	}

	private void A2BA1085(object sender, EventArgs e)
	{
		D8B23E9B.Height = 235;
	}

	private void btnUp_Click(object sender, EventArgs e)
	{
		D8B23E9B.Height = 187;
	}

	private void CE95910D_CheckedChanged(object sender, EventArgs e)
	{
		EBB7D29E();
	}

	private void rbNganCachKyTu_CheckedChanged(object sender, EventArgs e)
	{
		EBB7D29E();
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void E6A9D882(object sender, EventArgs e)
	{
		FFB6F6A8.Enabled = ckbTag.Checked;
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void BD1B123B_TextChanged(object sender, EventArgs e)
	{
	}

	private void B0B54418_Click(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDangStatusV2));
		C3256C96 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		C68A0FB9 = new System.Windows.Forms.Panel();
		label20 = new System.Windows.Forms.Label();
		D533DF97 = new System.Windows.Forms.NumericUpDown();
		nudKhoangCachFrom = new System.Windows.Forms.NumericUpDown();
		DB8A88AF = new System.Windows.Forms.Label();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		DC20FC27 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		FFB6F6A8 = new System.Windows.Forms.Panel();
		A51C259B = new System.Windows.Forms.Label();
		A79F63BB = new System.Windows.Forms.Label();
		nudDelayTagTo = new System.Windows.Forms.NumericUpDown();
		C5A8FA0F = new System.Windows.Forms.NumericUpDown();
		nudDelayTagFrom = new System.Windows.Forms.NumericUpDown();
		B3127990 = new System.Windows.Forms.NumericUpDown();
		label5 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		B90A3D37 = new System.Windows.Forms.CheckBox();
		D8B23E9B = new System.Windows.Forms.Panel();
		btnDown = new System.Windows.Forms.Button();
		btnUp = new System.Windows.Forms.Button();
		rbNganCachKyTu = new System.Windows.Forms.RadioButton();
		CE95910D = new System.Windows.Forms.RadioButton();
		B0B54418 = new System.Windows.Forms.Label();
		txtNoiDung = new System.Windows.Forms.RichTextBox();
		label8 = new System.Windows.Forms.Label();
		C32CB032 = new System.Windows.Forms.Label();
		btnAdd = new System.Windows.Forms.Button();
		plAnh = new System.Windows.Forms.Panel();
		D237D186 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		nudSoLuongAnhTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongAnhFrom = new System.Windows.Forms.NumericUpDown();
		label2 = new System.Windows.Forms.Label();
		BD1B123B = new System.Windows.Forms.TextBox();
		ckbDangAnhTheoThuTu = new System.Windows.Forms.CheckBox();
		ckbTag = new System.Windows.Forms.CheckBox();
		ckbAnh = new System.Windows.Forms.CheckBox();
		DC35CF9D = new System.Windows.Forms.CheckBox();
		FB211121 = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		A3817A8E = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		C68A0FB9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D533DF97).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		FFB6F6A8.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTagTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C5A8FA0F).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTagFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)B3127990).BeginInit();
		D8B23E9B.SuspendLayout();
		plAnh.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhFrom).BeginInit();
		A3817A8E.SuspendLayout();
		SuspendLayout();
		C3256C96.Fixed = true;
		C3256C96.Horizontal = true;
		C3256C96.TargetControl = bunifuCustomLabel1;
		C3256C96.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(654, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng status";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = pnlHeader;
		bunifuDragControl_0.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(654, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(623, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 0;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(EE2EABBE);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(D11D0887);
		C68A0FB9.BackColor = System.Drawing.Color.White;
		C68A0FB9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C68A0FB9.Controls.Add(label20);
		C68A0FB9.Controls.Add(D533DF97);
		C68A0FB9.Controls.Add(nudKhoangCachFrom);
		C68A0FB9.Controls.Add(DB8A88AF);
		C68A0FB9.Controls.Add(nudSoLuongTo);
		C68A0FB9.Controls.Add(nudSoLuongFrom);
		C68A0FB9.Controls.Add(DC20FC27);
		C68A0FB9.Controls.Add(label15);
		C68A0FB9.Controls.Add(FFB6F6A8);
		C68A0FB9.Controls.Add(D8B23E9B);
		C68A0FB9.Controls.Add(btnAdd);
		C68A0FB9.Controls.Add(plAnh);
		C68A0FB9.Controls.Add(ckbTag);
		C68A0FB9.Controls.Add(ckbAnh);
		C68A0FB9.Controls.Add(DC35CF9D);
		C68A0FB9.Controls.Add(FB211121);
		C68A0FB9.Controls.Add(label1);
		C68A0FB9.Controls.Add(btnCancel);
		C68A0FB9.Controls.Add(A3817A8E);
		C68A0FB9.Cursor = System.Windows.Forms.Cursors.Arrow;
		C68A0FB9.Dock = System.Windows.Forms.DockStyle.Fill;
		C68A0FB9.Location = new System.Drawing.Point(0, 0);
		C68A0FB9.Name = "panel1";
		C68A0FB9.Size = new System.Drawing.Size(657, 412);
		C68A0FB9.TabIndex = 0;
		C68A0FB9.Paint += new System.Windows.Forms.PaintEventHandler(C68A0FB9_Paint);
		label20.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label20.Location = new System.Drawing.Point(188, 109);
		label20.Name = "label20";
		label20.Size = new System.Drawing.Size(29, 16);
		label20.TabIndex = 42;
		label20.Text = ">";
		label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D533DF97.Location = new System.Drawing.Point(219, 107);
		D533DF97.Name = "nudKhoangCachTo";
		D533DF97.Size = new System.Drawing.Size(51, 23);
		D533DF97.TabIndex = 41;
		nudKhoangCachFrom.Location = new System.Drawing.Point(134, 107);
		nudKhoangCachFrom.Name = "nudKhoangCachFrom";
		nudKhoangCachFrom.Size = new System.Drawing.Size(51, 23);
		nudKhoangCachFrom.TabIndex = 40;
		DB8A88AF.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DB8A88AF.Location = new System.Drawing.Point(188, 83);
		DB8A88AF.Name = "label17";
		DB8A88AF.Size = new System.Drawing.Size(29, 16);
		DB8A88AF.TabIndex = 38;
		DB8A88AF.Text = ">";
		DB8A88AF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudSoLuongTo.Location = new System.Drawing.Point(219, 78);
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(51, 23);
		nudSoLuongTo.TabIndex = 37;
		nudSoLuongFrom.Location = new System.Drawing.Point(134, 78);
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(51, 23);
		nudSoLuongFrom.TabIndex = 36;
		DC20FC27.AutoSize = true;
		DC20FC27.Location = new System.Drawing.Point(30, 109);
		DC20FC27.Name = "label16";
		DC20FC27.Size = new System.Drawing.Size(87, 16);
		DC20FC27.TabIndex = 35;
		DC20FC27.Text = "Gia\u0303n ca\u0301ch (s):";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(30, 80);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(84, 16);
		label15.TabIndex = 34;
		label15.Text = "Số lượng bài:";
		FFB6F6A8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		FFB6F6A8.Controls.Add(A51C259B);
		FFB6F6A8.Controls.Add(A79F63BB);
		FFB6F6A8.Controls.Add(nudDelayTagTo);
		FFB6F6A8.Controls.Add(C5A8FA0F);
		FFB6F6A8.Controls.Add(nudDelayTagFrom);
		FFB6F6A8.Controls.Add(B3127990);
		FFB6F6A8.Controls.Add(label5);
		FFB6F6A8.Controls.Add(label10);
		FFB6F6A8.Controls.Add(B90A3D37);
		FFB6F6A8.Enabled = false;
		FFB6F6A8.Location = new System.Drawing.Point(368, 264);
		FFB6F6A8.Name = "plTag";
		FFB6F6A8.Size = new System.Drawing.Size(256, 82);
		FFB6F6A8.TabIndex = 33;
		A51C259B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A51C259B.Location = new System.Drawing.Point(169, 55);
		A51C259B.Name = "label6";
		A51C259B.Size = new System.Drawing.Size(29, 16);
		A51C259B.TabIndex = 33;
		A51C259B.Text = ">";
		A51C259B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A79F63BB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A79F63BB.Location = new System.Drawing.Point(169, 5);
		A79F63BB.Name = "label4";
		A79F63BB.Size = new System.Drawing.Size(29, 16);
		A79F63BB.TabIndex = 33;
		A79F63BB.Text = ">";
		A79F63BB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		nudDelayTagTo.Location = new System.Drawing.Point(204, 53);
		nudDelayTagTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTagTo.Name = "nudDelayTagTo";
		nudDelayTagTo.Size = new System.Drawing.Size(46, 23);
		nudDelayTagTo.TabIndex = 39;
		nudDelayTagTo.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		C5A8FA0F.Location = new System.Drawing.Point(204, 3);
		C5A8FA0F.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C5A8FA0F.Name = "nudUidTo";
		C5A8FA0F.Size = new System.Drawing.Size(46, 23);
		C5A8FA0F.TabIndex = 39;
		C5A8FA0F.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		nudDelayTagFrom.Location = new System.Drawing.Point(118, 53);
		nudDelayTagFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTagFrom.Name = "nudDelayTagFrom";
		nudDelayTagFrom.Size = new System.Drawing.Size(46, 23);
		nudDelayTagFrom.TabIndex = 38;
		nudDelayTagFrom.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		B3127990.Location = new System.Drawing.Point(118, 3);
		B3127990.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B3127990.Name = "nudUidFrom";
		B3127990.Size = new System.Drawing.Size(46, 23);
		B3127990.TabIndex = 38;
		B3127990.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(3, 55);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 0;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(3, 5);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(109, 16);
		label10.TabIndex = 0;
		label10.Text = "Số người cần tag:";
		B90A3D37.AutoSize = true;
		B90A3D37.Cursor = System.Windows.Forms.Cursors.Hand;
		B90A3D37.Location = new System.Drawing.Point(6, 30);
		B90A3D37.Name = "ckbOnlyTagVNName";
		B90A3D37.Size = new System.Drawing.Size(192, 20);
		B90A3D37.TabIndex = 32;
		B90A3D37.Text = "Chỉ gắn thẻ ngươ\u0300i co\u0301 tên Việt";
		B90A3D37.UseVisualStyleBackColor = true;
		D8B23E9B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D8B23E9B.Controls.Add(btnDown);
		D8B23E9B.Controls.Add(btnUp);
		D8B23E9B.Controls.Add(rbNganCachKyTu);
		D8B23E9B.Controls.Add(CE95910D);
		D8B23E9B.Controls.Add(B0B54418);
		D8B23E9B.Controls.Add(txtNoiDung);
		D8B23E9B.Controls.Add(label8);
		D8B23E9B.Controls.Add(C32CB032);
		D8B23E9B.Location = new System.Drawing.Point(47, 159);
		D8B23E9B.Name = "plVanBan";
		D8B23E9B.Size = new System.Drawing.Size(278, 187);
		D8B23E9B.TabIndex = 33;
		btnDown.BackgroundImage = C50FB39E.Bitmap_89;
		btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDown.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnDown.Location = new System.Drawing.Point(221, -1);
		btnDown.Name = "btnDown";
		btnDown.Size = new System.Drawing.Size(25, 25);
		btnDown.TabIndex = 38;
		btnDown.Click += new System.EventHandler(A2BA1085);
		btnUp.BackgroundImage = C50FB39E.Bitmap_74;
		btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
		btnUp.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnUp.Location = new System.Drawing.Point(252, -1);
		btnUp.Name = "btnUp";
		btnUp.Size = new System.Drawing.Size(25, 25);
		btnUp.TabIndex = 39;
		btnUp.Click += new System.EventHandler(btnUp_Click);
		rbNganCachKyTu.AutoSize = true;
		rbNganCachKyTu.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNganCachKyTu.Location = new System.Drawing.Point(69, 210);
		rbNganCachKyTu.Name = "rbNganCachKyTu";
		rbNganCachKyTu.Size = new System.Drawing.Size(202, 20);
		rbNganCachKyTu.TabIndex = 37;
		rbNganCachKyTu.Text = "Các nội dung ngăn cách bởi \"|\"";
		rbNganCachKyTu.UseVisualStyleBackColor = true;
		rbNganCachKyTu.CheckedChanged += new System.EventHandler(rbNganCachKyTu_CheckedChanged);
		CE95910D.AutoSize = true;
		CE95910D.Checked = true;
		CE95910D.Cursor = System.Windows.Forms.Cursors.Hand;
		CE95910D.Location = new System.Drawing.Point(69, 189);
		CE95910D.Name = "rbNganCachMoiDong";
		CE95910D.Size = new System.Drawing.Size(170, 20);
		CE95910D.TabIndex = 36;
		CE95910D.TabStop = true;
		CE95910D.Text = "Mỗi dòng là một nội dung";
		CE95910D.UseVisualStyleBackColor = true;
		CE95910D.CheckedChanged += new System.EventHandler(CE95910D_CheckedChanged);
		B0B54418.AutoSize = true;
		B0B54418.Location = new System.Drawing.Point(4, 189);
		B0B54418.Name = "label9";
		B0B54418.Size = new System.Drawing.Size(64, 16);
		B0B54418.TabIndex = 35;
		B0B54418.Text = "Tùy chọn:";
		B0B54418.Click += new System.EventHandler(B0B54418_Click);
		txtNoiDung.Location = new System.Drawing.Point(7, 24);
		txtNoiDung.Name = "txtNoiDung";
		txtNoiDung.Size = new System.Drawing.Size(263, 137);
		txtNoiDung.TabIndex = 34;
		txtNoiDung.Text = "";
		txtNoiDung.WordWrap = false;
		txtNoiDung.TextChanged += new System.EventHandler(txtNoiDung_TextChanged);
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(2, 164);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(143, 16);
		label8.TabIndex = 0;
		label8.Text = "(Spin nội dung {a|b|c})";
		C32CB032.AutoSize = true;
		C32CB032.Location = new System.Drawing.Point(3, 5);
		C32CB032.Name = "lblStatus";
		C32CB032.Size = new System.Drawing.Size(145, 16);
		C32CB032.TabIndex = 0;
		C32CB032.Text = "Danh sa\u0301ch nô\u0323i dung (0):";
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(231, 367);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		plAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plAnh.Controls.Add(D237D186);
		plAnh.Controls.Add(label11);
		plAnh.Controls.Add(nudSoLuongAnhTo);
		plAnh.Controls.Add(nudSoLuongAnhFrom);
		plAnh.Controls.Add(label2);
		plAnh.Controls.Add(BD1B123B);
		plAnh.Controls.Add(ckbDangAnhTheoThuTu);
		plAnh.Location = new System.Drawing.Point(368, 157);
		plAnh.Name = "plAnh";
		plAnh.Size = new System.Drawing.Size(256, 82);
		plAnh.TabIndex = 33;
		D237D186.AutoSize = true;
		D237D186.Location = new System.Drawing.Point(3, 6);
		D237D186.Name = "label7";
		D237D186.Size = new System.Drawing.Size(73, 16);
		D237D186.TabIndex = 44;
		D237D186.Text = "Folder ảnh:";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(3, 34);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(74, 16);
		label11.TabIndex = 45;
		label11.Text = "Sô\u0301 a\u0309nh/bài:";
		nudSoLuongAnhTo.Location = new System.Drawing.Point(176, 32);
		nudSoLuongAnhTo.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhTo.Name = "nudSoLuongAnhTo";
		nudSoLuongAnhTo.Size = new System.Drawing.Size(45, 23);
		nudSoLuongAnhTo.TabIndex = 7;
		nudSoLuongAnhFrom.Location = new System.Drawing.Point(82, 32);
		nudSoLuongAnhFrom.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongAnhFrom.Name = "nudSoLuongAnhFrom";
		nudSoLuongAnhFrom.Size = new System.Drawing.Size(45, 23);
		nudSoLuongAnhFrom.TabIndex = 8;
		label2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label2.Location = new System.Drawing.Point(138, 34);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(29, 16);
		label2.TabIndex = 4;
		label2.Text = ">";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BD1B123B.Location = new System.Drawing.Point(82, 3);
		BD1B123B.Name = "txtPathAnh";
		BD1B123B.Size = new System.Drawing.Size(168, 23);
		BD1B123B.TabIndex = 1;
		BD1B123B.TextChanged += new System.EventHandler(BD1B123B_TextChanged);
		ckbDangAnhTheoThuTu.AutoSize = true;
		ckbDangAnhTheoThuTu.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDangAnhTheoThuTu.Location = new System.Drawing.Point(6, 58);
		ckbDangAnhTheoThuTu.Name = "ckbDangAnhTheoThuTu";
		ckbDangAnhTheoThuTu.Size = new System.Drawing.Size(170, 20);
		ckbDangAnhTheoThuTu.TabIndex = 32;
		ckbDangAnhTheoThuTu.Text = "Đăng file a\u0309nh theo thư\u0301 tư\u0323";
		ckbDangAnhTheoThuTu.UseVisualStyleBackColor = true;
		ckbTag.AutoSize = true;
		ckbTag.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTag.Location = new System.Drawing.Point(354, 242);
		ckbTag.Name = "ckbTag";
		ckbTag.Size = new System.Drawing.Size(182, 20);
		ckbTag.TabIndex = 32;
		ckbTag.Text = "Gắn thẻ bạn bè vào bài viết";
		ckbTag.UseVisualStyleBackColor = true;
		ckbTag.CheckedChanged += new System.EventHandler(E6A9D882);
		ckbAnh.AutoSize = true;
		ckbAnh.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbAnh.Location = new System.Drawing.Point(354, 135);
		ckbAnh.Name = "ckbAnh";
		ckbAnh.Size = new System.Drawing.Size(48, 20);
		ckbAnh.TabIndex = 32;
		ckbAnh.Text = "A\u0309nh";
		ckbAnh.UseVisualStyleBackColor = true;
		ckbAnh.CheckedChanged += new System.EventHandler(ckbAnh_CheckedChanged);
		DC35CF9D.AutoSize = true;
		DC35CF9D.Cursor = System.Windows.Forms.Cursors.Hand;
		DC35CF9D.Location = new System.Drawing.Point(33, 137);
		DC35CF9D.Name = "ckbVanBan";
		DC35CF9D.Size = new System.Drawing.Size(73, 20);
		DC35CF9D.TabIndex = 32;
		DC35CF9D.Text = "Văn ba\u0309n";
		DC35CF9D.UseVisualStyleBackColor = true;
		DC35CF9D.CheckedChanged += new System.EventHandler(E019070B);
		FB211121.Location = new System.Drawing.Point(134, 49);
		FB211121.Name = "txtTenHanhDong";
		FB211121.Size = new System.Drawing.Size(191, 23);
		FB211121.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(30, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(330, 367);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		A3817A8E.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A3817A8E.BackColor = System.Drawing.Color.White;
		A3817A8E.BorderRadius = 0;
		A3817A8E.BottomSahddow = true;
		A3817A8E.color = System.Drawing.Color.DarkViolet;
		A3817A8E.Controls.Add(pnlHeader);
		A3817A8E.LeftSahddow = false;
		A3817A8E.Location = new System.Drawing.Point(1, 0);
		A3817A8E.Name = "bunifuCards1";
		A3817A8E.RightSahddow = true;
		A3817A8E.ShadowDepth = 20;
		A3817A8E.Size = new System.Drawing.Size(654, 37);
		A3817A8E.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(657, 412);
		base.Controls.Add(C68A0FB9);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDangStatusV2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(B2A96B8D);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		C68A0FB9.ResumeLayout(false);
		C68A0FB9.PerformLayout();
		((System.ComponentModel.ISupportInitialize)D533DF97).EndInit();
		((System.ComponentModel.ISupportInitialize)nudKhoangCachFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		FFB6F6A8.ResumeLayout(false);
		FFB6F6A8.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTagTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C5A8FA0F).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayTagFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)B3127990).EndInit();
		D8B23E9B.ResumeLayout(false);
		D8B23E9B.PerformLayout();
		plAnh.ResumeLayout(false);
		plAnh.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongAnhFrom).EndInit();
		A3817A8E.ResumeLayout(false);
		ResumeLayout(false);
	}
}
