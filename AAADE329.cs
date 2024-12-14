using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class AAADE329 : Form
{
	private List<ComboBox> list_0;

	public string string_0 = "";

	private IContainer A181D41B = null;

	private BunifuCards E5BC3439;

	private Panel pnlHeader;

	private BunifuCustomLabel F5A7EB3D;

	private Button btnMinimize;

	private Button btnCancel;

	private Button B02CC510;

	private BunifuDragControl C338C9B8;

	private PictureBox pictureBox1;

	private Panel panel1;

	private Panel DC09698B;

	private ComboBox F934339E;

	private ComboBox C6BABE1C;

	private ComboBox cbbDinhDang3;

	private ComboBox F1859427;

	private Label F63673BB;

	private Label BF82CE88;

	private Label D025B527;

	private ComboBox cbbDinhDang5;

	private Label AB094F3A;

	private ComboBox E413191B;

	private Label label17;

	private ComboBox cbbDinhDang8;

	private Label DABA4522;

	private ComboBox cbbDinhDang11;

	private ComboBox EF8066BF;

	private ComboBox A33A0D1F;

	private Label label12;

	private ComboBox B68E0523;

	private Label label11;

	private Label label9;

	private Label label10;

	public AAADE329()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		method_0();
	}

	private void method_0()
	{
		list_0 = new List<ComboBox>
		{
			F934339E, C6BABE1C, cbbDinhDang3, F1859427, cbbDinhDang5, EF8066BF, B68E0523, cbbDinhDang8, A33A0D1F, E413191B,
			cbbDinhDang11
		};
		foreach (ComboBox item in list_0)
		{
			GClass8.smethod_22(item, new List<string>
			{
				"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
				"Bạn bè", "Ngày tạo", "Mail khôi phục"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 100;
		}
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B02CC510_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < list_0.Count; i++)
		{
			string_0 = string_0 + list_0[i].Text + "|";
		}
		string_0 = string_0.TrimEnd('|');
		if (string_0 == "")
		{
			GClass29.smethod_0("Vui lòng chọn định dạng tài khoản!", 3);
		}
		else
		{
			Close();
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && A181D41B != null)
		{
			A181D41B.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		A181D41B = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AAADE329));
		E5BC3439 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		F5A7EB3D = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		B02CC510 = new System.Windows.Forms.Button();
		C338C9B8 = new Bunifu.Framework.UI.BunifuDragControl(A181D41B);
		panel1 = new System.Windows.Forms.Panel();
		DC09698B = new System.Windows.Forms.Panel();
		F934339E = new System.Windows.Forms.ComboBox();
		C6BABE1C = new System.Windows.Forms.ComboBox();
		cbbDinhDang3 = new System.Windows.Forms.ComboBox();
		F1859427 = new System.Windows.Forms.ComboBox();
		F63673BB = new System.Windows.Forms.Label();
		BF82CE88 = new System.Windows.Forms.Label();
		D025B527 = new System.Windows.Forms.Label();
		cbbDinhDang5 = new System.Windows.Forms.ComboBox();
		AB094F3A = new System.Windows.Forms.Label();
		E413191B = new System.Windows.Forms.ComboBox();
		label17 = new System.Windows.Forms.Label();
		cbbDinhDang8 = new System.Windows.Forms.ComboBox();
		DABA4522 = new System.Windows.Forms.Label();
		cbbDinhDang11 = new System.Windows.Forms.ComboBox();
		EF8066BF = new System.Windows.Forms.ComboBox();
		A33A0D1F = new System.Windows.Forms.ComboBox();
		label12 = new System.Windows.Forms.Label();
		B68E0523 = new System.Windows.Forms.ComboBox();
		label11 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		E5BC3439.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		DC09698B.SuspendLayout();
		SuspendLayout();
		E5BC3439.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E5BC3439.BackColor = System.Drawing.Color.White;
		E5BC3439.BorderRadius = 0;
		E5BC3439.BottomSahddow = true;
		E5BC3439.color = System.Drawing.Color.SaddleBrown;
		E5BC3439.Controls.Add(pnlHeader);
		E5BC3439.LeftSahddow = false;
		E5BC3439.Location = new System.Drawing.Point(1, 0);
		E5BC3439.Name = "bunifuCards1";
		E5BC3439.RightSahddow = true;
		E5BC3439.ShadowDepth = 20;
		E5BC3439.Size = new System.Drawing.Size(1044, 38);
		E5BC3439.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(F5A7EB3D);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1043, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 77;
		pictureBox1.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(1011, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		F5A7EB3D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F5A7EB3D.BackColor = System.Drawing.Color.Transparent;
		F5A7EB3D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F5A7EB3D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F5A7EB3D.ForeColor = System.Drawing.Color.Black;
		F5A7EB3D.Location = new System.Drawing.Point(0, 0);
		F5A7EB3D.Name = "bunifuCustomLabel1";
		F5A7EB3D.Size = new System.Drawing.Size(1043, 32);
		F5A7EB3D.TabIndex = 1;
		F5A7EB3D.Text = "Thêm Định dạng nhập tài khoản";
		F5A7EB3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(528, 106);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Hủy";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		B02CC510.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B02CC510.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		B02CC510.Cursor = System.Windows.Forms.Cursors.Hand;
		B02CC510.FlatAppearance.BorderSize = 0;
		B02CC510.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B02CC510.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B02CC510.ForeColor = System.Drawing.Color.White;
		B02CC510.Location = new System.Drawing.Point(424, 106);
		B02CC510.Name = "btnAdd";
		B02CC510.Size = new System.Drawing.Size(92, 29);
		B02CC510.TabIndex = 3;
		B02CC510.Text = "Thêm";
		B02CC510.UseVisualStyleBackColor = false;
		B02CC510.Click += new System.EventHandler(B02CC510_Click);
		C338C9B8.Fixed = true;
		C338C9B8.Horizontal = true;
		C338C9B8.TargetControl = F5A7EB3D;
		C338C9B8.Vertical = true;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(DC09698B);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(1045, 146);
		panel1.TabIndex = 48;
		DC09698B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		DC09698B.Controls.Add(F934339E);
		DC09698B.Controls.Add(C6BABE1C);
		DC09698B.Controls.Add(cbbDinhDang3);
		DC09698B.Controls.Add(F1859427);
		DC09698B.Controls.Add(F63673BB);
		DC09698B.Controls.Add(BF82CE88);
		DC09698B.Controls.Add(D025B527);
		DC09698B.Controls.Add(cbbDinhDang5);
		DC09698B.Controls.Add(AB094F3A);
		DC09698B.Controls.Add(E413191B);
		DC09698B.Controls.Add(label17);
		DC09698B.Controls.Add(cbbDinhDang8);
		DC09698B.Controls.Add(DABA4522);
		DC09698B.Controls.Add(cbbDinhDang11);
		DC09698B.Controls.Add(EF8066BF);
		DC09698B.Controls.Add(A33A0D1F);
		DC09698B.Controls.Add(label12);
		DC09698B.Controls.Add(B68E0523);
		DC09698B.Controls.Add(label11);
		DC09698B.Controls.Add(label9);
		DC09698B.Controls.Add(label10);
		DC09698B.Location = new System.Drawing.Point(11, 52);
		DC09698B.Name = "plDinhDangNhap";
		DC09698B.Size = new System.Drawing.Size(1019, 36);
		DC09698B.TabIndex = 47;
		F934339E.Cursor = System.Windows.Forms.Cursors.Hand;
		F934339E.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		F934339E.DropDownWidth = 100;
		F934339E.FormattingEnabled = true;
		F934339E.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		F934339E.Location = new System.Drawing.Point(4, 5);
		F934339E.Name = "cbbDinhDang1";
		F934339E.Size = new System.Drawing.Size(78, 24);
		F934339E.TabIndex = 40;
		C6BABE1C.Cursor = System.Windows.Forms.Cursors.Hand;
		C6BABE1C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		C6BABE1C.DropDownWidth = 100;
		C6BABE1C.FormattingEnabled = true;
		C6BABE1C.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		C6BABE1C.Location = new System.Drawing.Point(97, 5);
		C6BABE1C.Name = "cbbDinhDang2";
		C6BABE1C.Size = new System.Drawing.Size(78, 24);
		C6BABE1C.TabIndex = 40;
		cbbDinhDang3.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang3.DropDownWidth = 100;
		cbbDinhDang3.FormattingEnabled = true;
		cbbDinhDang3.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang3.Location = new System.Drawing.Point(190, 5);
		cbbDinhDang3.Name = "cbbDinhDang3";
		cbbDinhDang3.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang3.TabIndex = 40;
		F1859427.Cursor = System.Windows.Forms.Cursors.Hand;
		F1859427.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		F1859427.DropDownWidth = 100;
		F1859427.FormattingEnabled = true;
		F1859427.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		F1859427.Location = new System.Drawing.Point(283, 5);
		F1859427.Name = "cbbDinhDang4";
		F1859427.Size = new System.Drawing.Size(78, 24);
		F1859427.TabIndex = 40;
		F63673BB.AutoSize = true;
		F63673BB.Font = new System.Drawing.Font("Tahoma", 12f);
		F63673BB.Location = new System.Drawing.Point(920, 5);
		F63673BB.Name = "label19";
		F63673BB.Size = new System.Drawing.Size(15, 19);
		F63673BB.TabIndex = 41;
		F63673BB.Text = "|";
		BF82CE88.AutoSize = true;
		BF82CE88.Font = new System.Drawing.Font("Tahoma", 12f);
		BF82CE88.Location = new System.Drawing.Point(733, 5);
		BF82CE88.Name = "label18";
		BF82CE88.Size = new System.Drawing.Size(15, 19);
		BF82CE88.TabIndex = 41;
		BF82CE88.Text = "|";
		D025B527.AutoSize = true;
		D025B527.Font = new System.Drawing.Font("Tahoma", 12f);
		D025B527.Location = new System.Drawing.Point(547, 5);
		D025B527.Name = "label14";
		D025B527.Size = new System.Drawing.Size(15, 19);
		D025B527.TabIndex = 41;
		D025B527.Text = "|";
		cbbDinhDang5.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang5.DropDownWidth = 100;
		cbbDinhDang5.FormattingEnabled = true;
		cbbDinhDang5.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang5.Location = new System.Drawing.Point(376, 5);
		cbbDinhDang5.Name = "cbbDinhDang5";
		cbbDinhDang5.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang5.TabIndex = 40;
		AB094F3A.AutoSize = true;
		AB094F3A.Font = new System.Drawing.Font("Tahoma", 12f);
		AB094F3A.Location = new System.Drawing.Point(827, 7);
		AB094F3A.Name = "label1";
		AB094F3A.Size = new System.Drawing.Size(15, 19);
		AB094F3A.TabIndex = 41;
		AB094F3A.Text = "|";
		E413191B.Cursor = System.Windows.Forms.Cursors.Hand;
		E413191B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		E413191B.DropDownWidth = 100;
		E413191B.FormattingEnabled = true;
		E413191B.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		E413191B.Location = new System.Drawing.Point(842, 5);
		E413191B.Name = "cbbDinhDang10";
		E413191B.Size = new System.Drawing.Size(78, 24);
		E413191B.TabIndex = 40;
		label17.AutoSize = true;
		label17.Font = new System.Drawing.Font("Tahoma", 12f);
		label17.Location = new System.Drawing.Point(640, 5);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(15, 19);
		label17.TabIndex = 41;
		label17.Text = "|";
		cbbDinhDang8.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang8.DropDownWidth = 100;
		cbbDinhDang8.FormattingEnabled = true;
		cbbDinhDang8.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang8.Location = new System.Drawing.Point(655, 5);
		cbbDinhDang8.Name = "cbbDinhDang8";
		cbbDinhDang8.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang8.TabIndex = 40;
		DABA4522.AutoSize = true;
		DABA4522.Font = new System.Drawing.Font("Tahoma", 12f);
		DABA4522.Location = new System.Drawing.Point(454, 5);
		DABA4522.Name = "label13";
		DABA4522.Size = new System.Drawing.Size(15, 19);
		DABA4522.TabIndex = 41;
		DABA4522.Text = "|";
		cbbDinhDang11.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang11.DropDownWidth = 100;
		cbbDinhDang11.FormattingEnabled = true;
		cbbDinhDang11.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		cbbDinhDang11.Location = new System.Drawing.Point(935, 5);
		cbbDinhDang11.Name = "cbbDinhDang11";
		cbbDinhDang11.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang11.TabIndex = 40;
		EF8066BF.Cursor = System.Windows.Forms.Cursors.Hand;
		EF8066BF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		EF8066BF.DropDownWidth = 100;
		EF8066BF.FormattingEnabled = true;
		EF8066BF.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		EF8066BF.Location = new System.Drawing.Point(469, 5);
		EF8066BF.Name = "cbbDinhDang6";
		EF8066BF.Size = new System.Drawing.Size(78, 24);
		EF8066BF.TabIndex = 40;
		A33A0D1F.Cursor = System.Windows.Forms.Cursors.Hand;
		A33A0D1F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A33A0D1F.DropDownWidth = 100;
		A33A0D1F.FormattingEnabled = true;
		A33A0D1F.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		A33A0D1F.Location = new System.Drawing.Point(748, 5);
		A33A0D1F.Name = "cbbDinhDang9";
		A33A0D1F.Size = new System.Drawing.Size(78, 24);
		A33A0D1F.TabIndex = 40;
		label12.AutoSize = true;
		label12.Font = new System.Drawing.Font("Tahoma", 12f);
		label12.Location = new System.Drawing.Point(361, 5);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(15, 19);
		label12.TabIndex = 41;
		label12.Text = "|";
		B68E0523.Cursor = System.Windows.Forms.Cursors.Hand;
		B68E0523.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		B68E0523.DropDownWidth = 100;
		B68E0523.FormattingEnabled = true;
		B68E0523.Items.AddRange(new object[13]
		{
			"Uid", "Pass", "Token", "Cookie", "Email", "Pass Email", "2FA", "Useragent", "Proxy", "Birthday",
			"Bạn bè", "Ngày tạo", "Mail khôi phục"
		});
		B68E0523.Location = new System.Drawing.Point(562, 5);
		B68E0523.Name = "cbbDinhDang7";
		B68E0523.Size = new System.Drawing.Size(78, 24);
		B68E0523.TabIndex = 40;
		label11.AutoSize = true;
		label11.Font = new System.Drawing.Font("Tahoma", 12f);
		label11.Location = new System.Drawing.Point(268, 5);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(15, 19);
		label11.TabIndex = 41;
		label11.Text = "|";
		label9.AutoSize = true;
		label9.Font = new System.Drawing.Font("Tahoma", 12f);
		label9.Location = new System.Drawing.Point(82, 5);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(15, 19);
		label9.TabIndex = 41;
		label9.Text = "|";
		label10.AutoSize = true;
		label10.Font = new System.Drawing.Font("Tahoma", 12f);
		label10.Location = new System.Drawing.Point(175, 5);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(15, 19);
		label10.TabIndex = 41;
		label10.Text = "|";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1045, 146);
		base.Controls.Add(btnCancel);
		base.Controls.Add(B02CC510);
		base.Controls.Add(E5BC3439);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportAccountFormatInput";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		E5BC3439.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		DC09698B.ResumeLayout(false);
		DC09698B.PerformLayout();
		ResumeLayout(false);
	}
}
