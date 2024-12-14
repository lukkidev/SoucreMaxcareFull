using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhTaoPage : Form
{
	public bool bool_0 = false;

	private List<string> list_0 = new List<string>();

	private List<string> FF37CBAB = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private List<string> list_3 = new List<string>();

	private List<string> list_4 = new List<string>();

	private List<string> CBB53295 = new List<string>();

	private List<string> list_5 = new List<string>();

	private List<string> list_6 = new List<string>();

	private IContainer D2200E34 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel EDAEC03D;

	private Button C0249033;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl BE837B01;

	private PictureBox F2AD590D;

	private CheckBox FC1E21A2;

	private Panel plTaoPage;

	private NumericUpDown nudSoLuongPage;

	private Label label1;

	private CheckBox C0B4C313;

	private Panel E8382813;

	private TextBox txtId;

	private Label B38E919C;

	private CheckBox BCAB1F9E;

	private Panel D52B3BA3;

	private Button F003803C;

	private Button button3;

	private Button button7;

	private Button button6;

	private Button DE0269AB;

	private Button button2;

	private Button button1;

	private CheckBox D60B64B4;

	private Button button8;

	private Label label3;

	private CheckBox ckbLikePage;

	private Panel plLikePage;

	private TextBox txtPageId;

	private Label label4;

	private CheckBox ckbJoinGroup;

	private Panel C6BE3593;

	private TextBox txtGroupId;

	private Label BE215391;

	private CheckBox ckbRandomTen;

	private Button button9;

	private Label label6;

	public fCauHinhTaoPage()
	{
		InitializeComponent();
		bool_0 = false;
		F7AB102E.D6B70A35(this);
	}

	private void C0249033_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		GClass25.smethod_0("configTaoPage").method_4("ckbGetToken", BCAB1F9E.Checked);
		GClass25.smethod_0("configTaoPage").method_4("ckbTaoPage", FC1E21A2.Checked);
		GClass25.smethod_0("configTaoPage").method_4("nudSoLuongPage", nudSoLuongPage.Value);
		GClass25.smethod_0("configTaoPage").method_4("ckbCapNhatThongTin", D60B64B4.Checked);
		GClass25.smethod_0("configTaoPage").method_4("ckbRandomTen", ckbRandomTen.Checked);
		GClass25.smethod_0("configTaoPage").method_5("lstTenPage", list_0);
		GClass25.smethod_0("configTaoPage").method_5("lstDanhMuc", FF37CBAB);
		GClass25.smethod_0("configTaoPage").method_5("lstBio", list_1);
		GClass25.smethod_0("configTaoPage").method_5("lstZip", list_2);
		GClass25.smethod_0("configTaoPage").method_5("lstWebsite", list_3);
		GClass25.smethod_0("configTaoPage").method_5("lstStreet", list_4);
		GClass25.smethod_0("configTaoPage").method_5("lstPhone", CBB53295);
		GClass25.smethod_0("configTaoPage").method_5("lstEmail", list_5);
		GClass25.smethod_0("configTaoPage").method_5("lstCity", list_6);
		GClass25.smethod_0("configTaoPage").method_4("ckbFollow", C0B4C313.Checked);
		GClass25.smethod_0("configTaoPage").method_4("txtId", txtId.Text.Trim());
		GClass25.smethod_0("configTaoPage").method_4("ckbLikePage", ckbLikePage.Checked);
		GClass25.smethod_0("configTaoPage").method_4("txtPageId", txtPageId.Text.Trim());
		GClass25.smethod_0("configTaoPage").method_4("ckbJoinGroup", ckbJoinGroup.Checked);
		GClass25.smethod_0("configTaoPage").method_4("txtGroupId", txtGroupId.Text.Trim());
		GClass25.B3B73732("configTaoPage");
		bool_0 = true;
		Close();
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhTaoPage_Load(object sender, EventArgs e)
	{
		BCAB1F9E.Checked = GClass25.smethod_0("configTaoPage").method_3("ckbGetToken");
		FC1E21A2.Checked = GClass25.smethod_0("configTaoPage").method_3("ckbTaoPage");
		nudSoLuongPage.Value = GClass25.smethod_0("configTaoPage").method_2("nudSoLuongPage", 5);
		D60B64B4.Checked = GClass25.smethod_0("configTaoPage").method_3("ckbCapNhatThongTin");
		ckbRandomTen.Checked = GClass25.smethod_0("configTaoPage").method_3("ckbRandomTen", bool_0: true);
		list_0 = GClass25.smethod_0("configTaoPage").C5A69DA0("lstTenPage");
		FF37CBAB = GClass25.smethod_0("configTaoPage").C5A69DA0("lstDanhMuc");
		list_1 = GClass25.smethod_0("configTaoPage").C5A69DA0("lstBio");
		list_2 = GClass25.smethod_0("configTaoPage").C5A69DA0("lstZip");
		list_3 = GClass25.smethod_0("configTaoPage").C5A69DA0("lstWebsite");
		list_4 = GClass25.smethod_0("configTaoPage").C5A69DA0("lstStreet");
		CBB53295 = GClass25.smethod_0("configTaoPage").C5A69DA0("lstPhone");
		list_5 = GClass25.smethod_0("configTaoPage").C5A69DA0("lstEmail");
		list_6 = GClass25.smethod_0("configTaoPage").C5A69DA0("lstCity");
		C0B4C313.Checked = GClass25.smethod_0("configTaoPage").method_3("ckbFollow");
		txtId.Text = GClass25.smethod_0("configTaoPage").C0288288("txtId");
		ckbLikePage.Checked = GClass25.smethod_0("configTaoPage").method_3("ckbLikePage");
		txtPageId.Text = GClass25.smethod_0("configTaoPage").C0288288("txtPageId");
		ckbJoinGroup.Checked = GClass25.smethod_0("configTaoPage").method_3("ckbJoinGroup");
		txtGroupId.Text = GClass25.smethod_0("configTaoPage").C0288288("txtGroupId");
		if (list_0.Count == 0)
		{
			list_0.Add("MaxPhoneFarm *****");
		}
		if (FF37CBAB.Count == 0)
		{
			FF37CBAB.Add("2347428775505624");
		}
		if (list_1.Count == 0)
		{
			list_1.Add("Phần mềm nuôi Facebook tự động - Hotline/zalo: 0975 337 854 - 085.226.1234");
		}
		if (list_2.Count == 0)
		{
			list_2.Add("100000");
		}
		if (list_3.Count == 0)
		{
			list_3.Add("maxphonefarm.com");
		}
		if (list_4.Count == 0)
		{
			list_4.Add("58 Trương Công Giai, Dịch Vọng, Cầu Giấy");
		}
		if (CBB53295.Count == 0)
		{
			CBB53295.Add("097 533 78 54");
		}
		if (list_5.Count == 0)
		{
			list_5.Add("hotro@maxphonefarm.com");
		}
		if (list_6.Count == 0)
		{
			list_6.Add("106388046062960");
		}
		DD37C71E(null, null);
		C0B4C313_CheckedChanged(null, null);
		D60B64B4_CheckedChanged(null, null);
		E40DD839(null, null);
		ckbJoinGroup_CheckedChanged(null, null);
		D91557B7(null, null);
	}

	private void DD37C71E(object sender, EventArgs e)
	{
		plTaoPage.Enabled = FC1E21A2.Checked;
	}

	private void C0B4C313_CheckedChanged(object sender, EventArgs e)
	{
		E8382813.Enabled = C0B4C313.Checked;
	}

	private void D60B64B4_CheckedChanged(object sender, EventArgs e)
	{
		D52B3BA3.Enabled = D60B64B4.Checked;
	}

	private void method_0(string C309B902)
	{
		switch (C43AF739.smethod_0(C309B902))
		{
		case 898528047u:
			if (C309B902 == "tenPage")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch tên page", "Danh sa\u0301ch tên page", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_0 = fNhapDuLieu4.C6009CA1;
			}
			break;
		case 230981954u:
			if (C309B902 == "city")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_6, "Nhâ\u0323p danh sa\u0301ch id thành phố", "Danh sa\u0301ch id thành phố", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_6 = fNhapDuLieu4.C6009CA1;
			}
			break;
		case 1986331710u:
			if (C309B902 == "street")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_4, "Nhâ\u0323p danh sa\u0301ch street", "Danh sa\u0301ch street", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_4 = fNhapDuLieu4.C6009CA1;
			}
			break;
		case 1540020817u:
			if (C309B902 == "bio")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch bio", "Danh sa\u0301ch bio", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_1 = fNhapDuLieu4.C6009CA1;
			}
			break;
		case 2324124615u:
			if (C309B902 == "email")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_5, "Nhâ\u0323p danh sa\u0301ch email", "Danh sa\u0301ch email", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_5 = fNhapDuLieu4.C6009CA1;
			}
			break;
		case 2000032175u:
			if (C309B902 == "phone")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(CBB53295, "Nhâ\u0323p danh sa\u0301ch phone", "Danh sa\u0301ch phone", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				CBB53295 = fNhapDuLieu4.C6009CA1;
			}
			break;
		case 4243573962u:
			if (C309B902 == "website")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_3, "Nhâ\u0323p danh sa\u0301ch website", "Danh sa\u0301ch website", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_3 = fNhapDuLieu4.C6009CA1;
			}
			break;
		case 3255466783u:
			if (C309B902 == "danhMuc")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(FF37CBAB, "Nhâ\u0323p danh sa\u0301ch id danh mục", "Danh sa\u0301ch id danh mục", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				FF37CBAB = fNhapDuLieu4.C6009CA1;
			}
			break;
		case 2877453236u:
			if (C309B902 == "zip")
			{
				fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_2, "Nhâ\u0323p danh sa\u0301ch zip", "Danh sa\u0301ch zip", "(Mô\u0303i nội dung 1 do\u0300ng)");
				GClass8.smethod_33(fNhapDuLieu4);
				list_2 = fNhapDuLieu4.C6009CA1;
			}
			break;
		}
	}

	private void AB24F034(object sender, EventArgs e)
	{
		method_0("bio");
	}

	private void button8_Click(object sender, EventArgs e)
	{
		method_0("danhMuc");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		method_0("website");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		method_0("street");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		method_0("zip");
	}

	private void DE0269AB_Click(object sender, EventArgs e)
	{
		method_0("phone");
	}

	private void button6_Click(object sender, EventArgs e)
	{
		method_0("city");
	}

	private void CD80A1A2(object sender, EventArgs e)
	{
		method_0("email");
	}

	private void E40DD839(object sender, EventArgs e)
	{
		plLikePage.Enabled = ckbLikePage.Checked;
	}

	private void ckbJoinGroup_CheckedChanged(object sender, EventArgs e)
	{
		C6BE3593.Enabled = ckbJoinGroup.Checked;
	}

	private void button9_Click(object sender, EventArgs e)
	{
		method_0("tenPage");
	}

	private void D91557B7(object sender, EventArgs e)
	{
		button9.Enabled = !ckbRandomTen.Checked;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && D2200E34 != null)
		{
			D2200E34.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		D2200E34 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhTaoPage));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		F2AD590D = new System.Windows.Forms.PictureBox();
		C0249033 = new System.Windows.Forms.Button();
		EDAEC03D = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		BE837B01 = new Bunifu.Framework.UI.BunifuDragControl(D2200E34);
		FC1E21A2 = new System.Windows.Forms.CheckBox();
		plTaoPage = new System.Windows.Forms.Panel();
		ckbRandomTen = new System.Windows.Forms.CheckBox();
		button9 = new System.Windows.Forms.Button();
		button8 = new System.Windows.Forms.Button();
		D52B3BA3 = new System.Windows.Forms.Panel();
		F003803C = new System.Windows.Forms.Button();
		button3 = new System.Windows.Forms.Button();
		button7 = new System.Windows.Forms.Button();
		button6 = new System.Windows.Forms.Button();
		DE0269AB = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		D60B64B4 = new System.Windows.Forms.CheckBox();
		label6 = new System.Windows.Forms.Label();
		nudSoLuongPage = new System.Windows.Forms.NumericUpDown();
		label3 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		C0B4C313 = new System.Windows.Forms.CheckBox();
		E8382813 = new System.Windows.Forms.Panel();
		txtId = new System.Windows.Forms.TextBox();
		B38E919C = new System.Windows.Forms.Label();
		BCAB1F9E = new System.Windows.Forms.CheckBox();
		ckbLikePage = new System.Windows.Forms.CheckBox();
		plLikePage = new System.Windows.Forms.Panel();
		txtPageId = new System.Windows.Forms.TextBox();
		label4 = new System.Windows.Forms.Label();
		ckbJoinGroup = new System.Windows.Forms.CheckBox();
		C6BE3593 = new System.Windows.Forms.Panel();
		txtGroupId = new System.Windows.Forms.TextBox();
		BE215391 = new System.Windows.Forms.Label();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F2AD590D).BeginInit();
		plTaoPage.SuspendLayout();
		D52B3BA3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongPage).BeginInit();
		E8382813.SuspendLayout();
		plLikePage.SuspendLayout();
		C6BE3593.SuspendLayout();
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
		bunifuCards1.Size = new System.Drawing.Size(714, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(F2AD590D);
		pnlHeader.Controls.Add(C0249033);
		pnlHeader.Controls.Add(EDAEC03D);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(714, 32);
		pnlHeader.TabIndex = 9;
		F2AD590D.Cursor = System.Windows.Forms.Cursors.Default;
		F2AD590D.Image = C50FB39E.Bitmap_5;
		F2AD590D.Location = new System.Drawing.Point(3, 2);
		F2AD590D.Name = "pictureBox1";
		F2AD590D.Size = new System.Drawing.Size(34, 27);
		F2AD590D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		F2AD590D.TabIndex = 17;
		F2AD590D.TabStop = false;
		C0249033.Cursor = System.Windows.Forms.Cursors.Hand;
		C0249033.Dock = System.Windows.Forms.DockStyle.Right;
		C0249033.FlatAppearance.BorderSize = 0;
		C0249033.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C0249033.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C0249033.ForeColor = System.Drawing.Color.White;
		C0249033.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		C0249033.Location = new System.Drawing.Point(682, 0);
		C0249033.Name = "btnMinimize";
		C0249033.Size = new System.Drawing.Size(32, 32);
		C0249033.TabIndex = 9;
		C0249033.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C0249033.UseVisualStyleBackColor = true;
		C0249033.Click += new System.EventHandler(C0249033_Click);
		EDAEC03D.BackColor = System.Drawing.Color.Transparent;
		EDAEC03D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EDAEC03D.Dock = System.Windows.Forms.DockStyle.Fill;
		EDAEC03D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EDAEC03D.ForeColor = System.Drawing.Color.Black;
		EDAEC03D.Location = new System.Drawing.Point(0, 0);
		EDAEC03D.Name = "bunifuCustomLabel1";
		EDAEC03D.Size = new System.Drawing.Size(714, 32);
		EDAEC03D.TabIndex = 1;
		EDAEC03D.Text = "Câ\u0301u hi\u0300nh Ta\u0323o page";
		EDAEC03D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(365, 237);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(261, 237);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		BE837B01.Fixed = true;
		BE837B01.Horizontal = true;
		BE837B01.TargetControl = EDAEC03D;
		BE837B01.Vertical = true;
		FC1E21A2.AutoSize = true;
		FC1E21A2.Cursor = System.Windows.Forms.Cursors.Hand;
		FC1E21A2.Location = new System.Drawing.Point(30, 87);
		FC1E21A2.Name = "ckbTaoPage";
		FC1E21A2.Size = new System.Drawing.Size(80, 20);
		FC1E21A2.TabIndex = 5;
		FC1E21A2.Text = "Ta\u0323o page";
		FC1E21A2.UseVisualStyleBackColor = true;
		FC1E21A2.CheckedChanged += new System.EventHandler(DD37C71E);
		plTaoPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTaoPage.Controls.Add(ckbRandomTen);
		plTaoPage.Controls.Add(button9);
		plTaoPage.Controls.Add(button8);
		plTaoPage.Controls.Add(D52B3BA3);
		plTaoPage.Controls.Add(D60B64B4);
		plTaoPage.Controls.Add(label6);
		plTaoPage.Controls.Add(nudSoLuongPage);
		plTaoPage.Controls.Add(label3);
		plTaoPage.Controls.Add(label1);
		plTaoPage.Location = new System.Drawing.Point(30, 108);
		plTaoPage.Name = "plTaoPage";
		plTaoPage.Size = new System.Drawing.Size(351, 95);
		plTaoPage.TabIndex = 6;
		ckbRandomTen.AutoSize = true;
		ckbRandomTen.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRandomTen.Location = new System.Drawing.Point(73, 37);
		ckbRandomTen.Name = "ckbRandomTen";
		ckbRandomTen.Size = new System.Drawing.Size(73, 20);
		ckbRandomTen.TabIndex = 4;
		ckbRandomTen.Text = "Random";
		ckbRandomTen.UseVisualStyleBackColor = true;
		ckbRandomTen.CheckedChanged += new System.EventHandler(D91557B7);
		button9.Cursor = System.Windows.Forms.Cursors.Hand;
		button9.Location = new System.Drawing.Point(152, 34);
		button9.Name = "button9";
		button9.Size = new System.Drawing.Size(192, 25);
		button9.TabIndex = 0;
		button9.Text = "Nhập";
		button9.UseVisualStyleBackColor = true;
		button9.Click += new System.EventHandler(button9_Click);
		button8.Cursor = System.Windows.Forms.Cursors.Hand;
		button8.Location = new System.Drawing.Point(72, 63);
		button8.Name = "button8";
		button8.Size = new System.Drawing.Size(272, 25);
		button8.TabIndex = 0;
		button8.Text = "Nhập";
		button8.UseVisualStyleBackColor = true;
		button8.Click += new System.EventHandler(button8_Click);
		D52B3BA3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D52B3BA3.Controls.Add(F003803C);
		D52B3BA3.Controls.Add(button3);
		D52B3BA3.Controls.Add(button7);
		D52B3BA3.Controls.Add(button6);
		D52B3BA3.Controls.Add(DE0269AB);
		D52B3BA3.Controls.Add(button2);
		D52B3BA3.Controls.Add(button1);
		D52B3BA3.Location = new System.Drawing.Point(6, 114);
		D52B3BA3.Name = "plCapNhatThongTin";
		D52B3BA3.Size = new System.Drawing.Size(338, 97);
		D52B3BA3.TabIndex = 3;
		F003803C.Cursor = System.Windows.Forms.Cursors.Hand;
		F003803C.Location = new System.Drawing.Point(4, 5);
		F003803C.Name = "button5";
		F003803C.Size = new System.Drawing.Size(118, 25);
		F003803C.TabIndex = 0;
		F003803C.Text = "Giới thiệu (Bio)";
		F003803C.UseVisualStyleBackColor = true;
		F003803C.Click += new System.EventHandler(AB24F034);
		button3.Cursor = System.Windows.Forms.Cursors.Hand;
		button3.Location = new System.Drawing.Point(232, 5);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(98, 25);
		button3.TabIndex = 0;
		button3.Text = "Địa chỉ";
		button3.UseVisualStyleBackColor = true;
		button3.Click += new System.EventHandler(button3_Click);
		button7.Cursor = System.Windows.Forms.Cursors.Hand;
		button7.Location = new System.Drawing.Point(128, 67);
		button7.Name = "button7";
		button7.Size = new System.Drawing.Size(98, 25);
		button7.TabIndex = 0;
		button7.Text = "Email";
		button7.UseVisualStyleBackColor = true;
		button7.Click += new System.EventHandler(CD80A1A2);
		button6.Cursor = System.Windows.Forms.Cursors.Hand;
		button6.Location = new System.Drawing.Point(232, 36);
		button6.Name = "button6";
		button6.Size = new System.Drawing.Size(98, 25);
		button6.TabIndex = 0;
		button6.Text = "Thành phố";
		button6.UseVisualStyleBackColor = true;
		button6.Click += new System.EventHandler(button6_Click);
		DE0269AB.Cursor = System.Windows.Forms.Cursors.Hand;
		DE0269AB.Location = new System.Drawing.Point(128, 36);
		DE0269AB.Name = "button4";
		DE0269AB.Size = new System.Drawing.Size(98, 25);
		DE0269AB.TabIndex = 0;
		DE0269AB.Text = "Số điện thoại";
		DE0269AB.UseVisualStyleBackColor = true;
		DE0269AB.Click += new System.EventHandler(DE0269AB_Click);
		button2.Cursor = System.Windows.Forms.Cursors.Hand;
		button2.Location = new System.Drawing.Point(128, 5);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(98, 25);
		button2.TabIndex = 0;
		button2.Text = "Website";
		button2.UseVisualStyleBackColor = true;
		button2.Click += new System.EventHandler(button2_Click);
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.Location = new System.Drawing.Point(4, 36);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(118, 25);
		button1.TabIndex = 0;
		button1.Text = "Mã Zip";
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		D60B64B4.AutoSize = true;
		D60B64B4.Cursor = System.Windows.Forms.Cursors.Hand;
		D60B64B4.Location = new System.Drawing.Point(6, 92);
		D60B64B4.Name = "ckbCapNhatThongTin";
		D60B64B4.Size = new System.Drawing.Size(131, 20);
		D60B64B4.TabIndex = 2;
		D60B64B4.Text = "Cập nhật thông tin";
		D60B64B4.UseVisualStyleBackColor = true;
		D60B64B4.CheckedChanged += new System.EventHandler(D60B64B4_CheckedChanged);
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(3, 38);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(66, 16);
		label6.TabIndex = 0;
		label6.Text = "Tên page:";
		nudSoLuongPage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		nudSoLuongPage.Location = new System.Drawing.Point(72, 5);
		nudSoLuongPage.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nudSoLuongPage.Name = "nudSoLuongPage";
		nudSoLuongPage.Size = new System.Drawing.Size(272, 23);
		nudSoLuongPage.TabIndex = 1;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(3, 67);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(69, 16);
		label3.TabIndex = 0;
		label3.Text = "Danh mục:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(3, 7);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(63, 16);
		label1.TabIndex = 0;
		label1.Text = "Sô\u0301 lươ\u0323ng:";
		C0B4C313.AutoSize = true;
		C0B4C313.Cursor = System.Windows.Forms.Cursors.Hand;
		C0B4C313.Location = new System.Drawing.Point(413, 64);
		C0B4C313.Name = "ckbFollow";
		C0B4C313.Size = new System.Drawing.Size(63, 20);
		C0B4C313.TabIndex = 5;
		C0B4C313.Text = "Follow";
		C0B4C313.UseVisualStyleBackColor = true;
		C0B4C313.CheckedChanged += new System.EventHandler(C0B4C313_CheckedChanged);
		E8382813.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E8382813.Controls.Add(txtId);
		E8382813.Controls.Add(B38E919C);
		E8382813.Location = new System.Drawing.Point(413, 85);
		E8382813.Name = "plFollow";
		E8382813.Size = new System.Drawing.Size(274, 31);
		E8382813.TabIndex = 6;
		txtId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtId.Location = new System.Drawing.Point(58, 3);
		txtId.Name = "txtId";
		txtId.Size = new System.Drawing.Size(211, 23);
		txtId.TabIndex = 1;
		B38E919C.AutoSize = true;
		B38E919C.Location = new System.Drawing.Point(5, 6);
		B38E919C.Name = "label2";
		B38E919C.Size = new System.Drawing.Size(56, 16);
		B38E919C.TabIndex = 0;
		B38E919C.Text = "Nhâ\u0323p Id:";
		BCAB1F9E.AutoSize = true;
		BCAB1F9E.Cursor = System.Windows.Forms.Cursors.Hand;
		BCAB1F9E.Location = new System.Drawing.Point(30, 64);
		BCAB1F9E.Name = "ckbGetToken";
		BCAB1F9E.Size = new System.Drawing.Size(131, 20);
		BCAB1F9E.TabIndex = 5;
		BCAB1F9E.Text = "Get token EAAAAU";
		BCAB1F9E.UseVisualStyleBackColor = true;
		BCAB1F9E.CheckedChanged += new System.EventHandler(DD37C71E);
		ckbLikePage.AutoSize = true;
		ckbLikePage.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbLikePage.Location = new System.Drawing.Point(412, 118);
		ckbLikePage.Name = "ckbLikePage";
		ckbLikePage.Size = new System.Drawing.Size(80, 20);
		ckbLikePage.TabIndex = 5;
		ckbLikePage.Text = "Like page";
		ckbLikePage.UseVisualStyleBackColor = true;
		ckbLikePage.CheckedChanged += new System.EventHandler(E40DD839);
		plLikePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plLikePage.Controls.Add(txtPageId);
		plLikePage.Controls.Add(label4);
		plLikePage.Location = new System.Drawing.Point(412, 139);
		plLikePage.Name = "plLikePage";
		plLikePage.Size = new System.Drawing.Size(274, 31);
		plLikePage.TabIndex = 6;
		txtPageId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtPageId.Location = new System.Drawing.Point(58, 3);
		txtPageId.Name = "txtPageId";
		txtPageId.Size = new System.Drawing.Size(211, 23);
		txtPageId.TabIndex = 1;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(5, 6);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(56, 16);
		label4.TabIndex = 0;
		label4.Text = "Nhâ\u0323p Id:";
		ckbJoinGroup.AutoSize = true;
		ckbJoinGroup.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbJoinGroup.Location = new System.Drawing.Point(411, 172);
		ckbJoinGroup.Name = "ckbJoinGroup";
		ckbJoinGroup.Size = new System.Drawing.Size(85, 20);
		ckbJoinGroup.TabIndex = 5;
		ckbJoinGroup.Text = "Join group";
		ckbJoinGroup.UseVisualStyleBackColor = true;
		ckbJoinGroup.CheckedChanged += new System.EventHandler(ckbJoinGroup_CheckedChanged);
		C6BE3593.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C6BE3593.Controls.Add(txtGroupId);
		C6BE3593.Controls.Add(BE215391);
		C6BE3593.Location = new System.Drawing.Point(411, 193);
		C6BE3593.Name = "plJoinGroup";
		C6BE3593.Size = new System.Drawing.Size(274, 31);
		C6BE3593.TabIndex = 6;
		txtGroupId.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		txtGroupId.Location = new System.Drawing.Point(58, 3);
		txtGroupId.Name = "txtGroupId";
		txtGroupId.Size = new System.Drawing.Size(211, 23);
		txtGroupId.TabIndex = 1;
		BE215391.AutoSize = true;
		BE215391.Location = new System.Drawing.Point(5, 6);
		BE215391.Name = "label5";
		BE215391.Size = new System.Drawing.Size(56, 16);
		BE215391.TabIndex = 0;
		BE215391.Text = "Nhâ\u0323p Id:";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(714, 279);
		base.Controls.Add(C6BE3593);
		base.Controls.Add(plLikePage);
		base.Controls.Add(E8382813);
		base.Controls.Add(plTaoPage);
		base.Controls.Add(ckbJoinGroup);
		base.Controls.Add(ckbLikePage);
		base.Controls.Add(C0B4C313);
		base.Controls.Add(BCAB1F9E);
		base.Controls.Add(FC1E21A2);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhTaoPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fCauHinhTaoPage_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)F2AD590D).EndInit();
		plTaoPage.ResumeLayout(false);
		plTaoPage.PerformLayout();
		D52B3BA3.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)nudSoLuongPage).EndInit();
		E8382813.ResumeLayout(false);
		E8382813.PerformLayout();
		plLikePage.ResumeLayout(false);
		plLikePage.PerformLayout();
		C6BE3593.ResumeLayout(false);
		C6BE3593.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}
}
