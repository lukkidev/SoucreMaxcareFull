using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class AF9E4E34 : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string BE3E5789;

	private string string_1;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl C10282BD;

	private Panel panel1;

	private TextBox C7085516;

	private Label label2;

	private Label C79B7C3D;

	private Button btnCancel;

	private Button F99E3C30;

	private BunifuCards bunifuCards1;

	private Panel EC093EBD;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label lblStatus;

	private RichTextBox txtTuKhoa;

	private NumericUpDown nudCountTimeScrollTo;

	private NumericUpDown D2B05A21;

	private NumericUpDown nudCountPageTo;

	private NumericUpDown nudCountTuKhoaTo;

	private NumericUpDown nudCountTimeScrollFrom;

	private NumericUpDown nudCountLinkClickFrom;

	private NumericUpDown nudCountPageFrom;

	private NumericUpDown AC0A8E30;

	private Label B70F5EA9;

	private Label label17;

	private Label C6ABC881;

	private Label label3;

	private Label label13;

	private Label label16;

	private Label label12;

	private Label label11;

	private Label label15;

	private Label label10;

	private Label label9;

	public AF9E4E34(string string_2, int C5B05594 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		string_1 = string_3;
		int_0 = C5B05594;
		if (Class147.smethod_7("", "HDTimKiemGoogle").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDTimKiemGoogle', 'Ti\u0300m kiê\u0301m Google');");
		}
		string text = "";
		switch (C5B05594)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDTimKiemGoogle");
			BE3E5789 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			C7085516.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			F99E3C30.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			C7085516.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(C79B7C3D);
		F7AB102E.smethod_1(lblStatus);
		F7AB102E.smethod_1(label9);
		F7AB102E.smethod_1(label13);
		F7AB102E.smethod_1(label11);
		F7AB102E.smethod_1(label10);
		F7AB102E.smethod_1(C6ABC881);
		F7AB102E.smethod_1(label12);
		F7AB102E.smethod_1(label15);
		F7AB102E.smethod_1(label17);
		F7AB102E.smethod_1(label16);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(B70F5EA9);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(F99E3C30);
		F7AB102E.smethod_1(btnCancel);
	}

	private void AF9E4E34_Load(object sender, EventArgs e)
	{
		try
		{
			AC0A8E30.Value = gclass11_0.method_2("nudCountTuKhoaFrom", 1);
			nudCountTuKhoaTo.Value = gclass11_0.method_2("nudCountTuKhoaTo", 1);
			nudCountPageFrom.Value = gclass11_0.method_2("nudCountPageFrom", 3);
			nudCountPageTo.Value = gclass11_0.method_2("nudCountPageTo", 3);
			nudCountLinkClickFrom.Value = gclass11_0.method_2("nudCountLinkClickFrom", 3);
			D2B05A21.Value = gclass11_0.method_2("nudCountLinkClickTo", 5);
			nudCountTimeScrollFrom.Value = gclass11_0.method_2("nudCountTimeScrollFrom", 30);
			nudCountTimeScrollTo.Value = gclass11_0.method_2("nudCountTimeScrollTo", 30);
			txtTuKhoa.Text = gclass11_0.C0288288("txtTuKhoa");
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F99E3C30_Click(object sender, EventArgs e)
	{
		string text = C7085516.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudCountTuKhoaFrom", AC0A8E30.Value);
		gClass.method_4("nudCountTuKhoaTo", nudCountTuKhoaTo.Value);
		gClass.method_4("nudCountPageFrom", nudCountPageFrom.Value);
		gClass.method_4("nudCountPageTo", nudCountPageTo.Value);
		gClass.method_4("nudCountLinkClickFrom", nudCountLinkClickFrom.Value);
		gClass.method_4("nudCountLinkClickTo", D2B05A21.Value);
		gClass.method_4("nudCountTimeScrollFrom", nudCountTimeScrollFrom.Value);
		gClass.method_4("nudCountTimeScrollTo", nudCountTimeScrollTo.Value);
		gClass.method_4("txtTuKhoa", txtTuKhoa.Text.Trim());
		string string_ = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, BE3E5789, string_))
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

	private void D0BDCABF(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void txtTuKhoa_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtTuKhoa.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblStatus.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch Tư\u0300 kho\u0301a|Link Web ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool EB85E291)
	{
		if (EB85E291 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(EB85E291);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AF9E4E34));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		C10282BD = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		EC093EBD = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		nudCountTimeScrollFrom = new System.Windows.Forms.NumericUpDown();
		nudCountLinkClickFrom = new System.Windows.Forms.NumericUpDown();
		nudCountPageFrom = new System.Windows.Forms.NumericUpDown();
		AC0A8E30 = new System.Windows.Forms.NumericUpDown();
		txtTuKhoa = new System.Windows.Forms.RichTextBox();
		lblStatus = new System.Windows.Forms.Label();
		nudCountTimeScrollTo = new System.Windows.Forms.NumericUpDown();
		D2B05A21 = new System.Windows.Forms.NumericUpDown();
		nudCountPageTo = new System.Windows.Forms.NumericUpDown();
		nudCountTuKhoaTo = new System.Windows.Forms.NumericUpDown();
		B70F5EA9 = new System.Windows.Forms.Label();
		C7085516 = new System.Windows.Forms.TextBox();
		label17 = new System.Windows.Forms.Label();
		C6ABC881 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label13 = new System.Windows.Forms.Label();
		label16 = new System.Windows.Forms.Label();
		label12 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		label15 = new System.Windows.Forms.Label();
		label10 = new System.Windows.Forms.Label();
		label9 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		C79B7C3D = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		F99E3C30 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		EC093EBD.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudCountTimeScrollFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkClickFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountPageFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)AC0A8E30).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountTimeScrollTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)D2B05A21).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountPageTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudCountTuKhoaTo).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Ti\u0300m kiê\u0301m Google";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C10282BD.Fixed = true;
		C10282BD.Horizontal = true;
		C10282BD.TargetControl = EC093EBD;
		C10282BD.Vertical = true;
		EC093EBD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EC093EBD.BackColor = System.Drawing.Color.White;
		EC093EBD.Controls.Add(button1);
		EC093EBD.Controls.Add(pictureBox1);
		EC093EBD.Controls.Add(bunifuCustomLabel1);
		EC093EBD.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EC093EBD.Location = new System.Drawing.Point(0, 3);
		EC093EBD.Name = "pnlHeader";
		EC093EBD.Size = new System.Drawing.Size(359, 31);
		EC093EBD.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(328, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(nudCountTimeScrollFrom);
		panel1.Controls.Add(nudCountLinkClickFrom);
		panel1.Controls.Add(nudCountPageFrom);
		panel1.Controls.Add(AC0A8E30);
		panel1.Controls.Add(txtTuKhoa);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(nudCountTimeScrollTo);
		panel1.Controls.Add(D2B05A21);
		panel1.Controls.Add(nudCountPageTo);
		panel1.Controls.Add(nudCountTuKhoaTo);
		panel1.Controls.Add(B70F5EA9);
		panel1.Controls.Add(C7085516);
		panel1.Controls.Add(label17);
		panel1.Controls.Add(C6ABC881);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label13);
		panel1.Controls.Add(label16);
		panel1.Controls.Add(label12);
		panel1.Controls.Add(label11);
		panel1.Controls.Add(label15);
		panel1.Controls.Add(label10);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(C79B7C3D);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(F99E3C30);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 413);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(D0BDCABF);
		nudCountTimeScrollFrom.Location = new System.Drawing.Point(192, 330);
		nudCountTimeScrollFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountTimeScrollFrom.Name = "nudCountTimeScrollFrom";
		nudCountTimeScrollFrom.Size = new System.Drawing.Size(36, 23);
		nudCountTimeScrollFrom.TabIndex = 1;
		nudCountLinkClickFrom.Location = new System.Drawing.Point(192, 302);
		nudCountLinkClickFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountLinkClickFrom.Name = "nudCountLinkClickFrom";
		nudCountLinkClickFrom.Size = new System.Drawing.Size(36, 23);
		nudCountLinkClickFrom.TabIndex = 1;
		nudCountPageFrom.Location = new System.Drawing.Point(192, 274);
		nudCountPageFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountPageFrom.Name = "nudCountPageFrom";
		nudCountPageFrom.Size = new System.Drawing.Size(36, 23);
		nudCountPageFrom.TabIndex = 1;
		AC0A8E30.Location = new System.Drawing.Point(192, 246);
		AC0A8E30.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		AC0A8E30.Name = "nudCountTuKhoaFrom";
		AC0A8E30.Size = new System.Drawing.Size(36, 23);
		AC0A8E30.TabIndex = 1;
		txtTuKhoa.Location = new System.Drawing.Point(30, 96);
		txtTuKhoa.Name = "txtTuKhoa";
		txtTuKhoa.Size = new System.Drawing.Size(298, 142);
		txtTuKhoa.TabIndex = 42;
		txtTuKhoa.Text = "";
		txtTuKhoa.WordWrap = false;
		txtTuKhoa.TextChanged += new System.EventHandler(txtTuKhoa_TextChanged);
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(27, 77);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(201, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Tư\u0300 kho\u0301a|Link Web (0):";
		nudCountTimeScrollTo.Location = new System.Drawing.Point(248, 330);
		nudCountTimeScrollTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountTimeScrollTo.Name = "nudCountTimeScrollTo";
		nudCountTimeScrollTo.Size = new System.Drawing.Size(36, 23);
		nudCountTimeScrollTo.TabIndex = 2;
		D2B05A21.Location = new System.Drawing.Point(248, 302);
		D2B05A21.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D2B05A21.Name = "nudCountLinkClickTo";
		D2B05A21.Size = new System.Drawing.Size(36, 23);
		D2B05A21.TabIndex = 2;
		nudCountPageTo.Location = new System.Drawing.Point(248, 274);
		nudCountPageTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountPageTo.Name = "nudCountPageTo";
		nudCountPageTo.Size = new System.Drawing.Size(36, 23);
		nudCountPageTo.TabIndex = 2;
		nudCountTuKhoaTo.Location = new System.Drawing.Point(248, 246);
		nudCountTuKhoaTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudCountTuKhoaTo.Name = "nudCountTuKhoaTo";
		nudCountTuKhoaTo.Size = new System.Drawing.Size(36, 23);
		nudCountTuKhoaTo.TabIndex = 2;
		B70F5EA9.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B70F5EA9.Location = new System.Drawing.Point(226, 332);
		B70F5EA9.Name = "label4";
		B70F5EA9.Size = new System.Drawing.Size(26, 16);
		B70F5EA9.TabIndex = 37;
		B70F5EA9.Text = ">";
		B70F5EA9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C7085516.Location = new System.Drawing.Point(134, 49);
		C7085516.Name = "txtTenHanhDong";
		C7085516.Size = new System.Drawing.Size(194, 23);
		C7085516.TabIndex = 0;
		label17.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label17.Location = new System.Drawing.Point(226, 304);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(26, 16);
		label17.TabIndex = 37;
		label17.Text = ">";
		label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C6ABC881.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C6ABC881.Location = new System.Drawing.Point(226, 276);
		C6ABC881.Name = "label14";
		C6ABC881.Size = new System.Drawing.Size(26, 16);
		C6ABC881.TabIndex = 37;
		C6ABC881.Text = ">";
		C6ABC881.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(284, 332);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(30, 16);
		label3.TabIndex = 35;
		label3.Text = "giây";
		label13.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label13.Location = new System.Drawing.Point(226, 248);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(26, 16);
		label13.TabIndex = 37;
		label13.Text = ">";
		label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label16.AutoSize = true;
		label16.Location = new System.Drawing.Point(284, 304);
		label16.Name = "label16";
		label16.Size = new System.Drawing.Size(26, 16);
		label16.TabIndex = 35;
		label16.Text = "link";
		label12.AutoSize = true;
		label12.Location = new System.Drawing.Point(284, 276);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(37, 16);
		label12.TabIndex = 35;
		label12.Text = "trang";
		label11.AutoSize = true;
		label11.Location = new System.Drawing.Point(284, 248);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(50, 16);
		label11.TabIndex = 35;
		label11.Text = "tư\u0300 khóa";
		label15.AutoSize = true;
		label15.Location = new System.Drawing.Point(28, 304);
		label15.Name = "label15";
		label15.Size = new System.Drawing.Size(164, 16);
		label15.TabIndex = 34;
		label15.Text = "Click random link trên web:";
		label10.AutoSize = true;
		label10.Location = new System.Drawing.Point(27, 276);
		label10.Name = "label10";
		label10.Size = new System.Drawing.Size(150, 16);
		label10.TabIndex = 34;
		label10.Text = "Sô\u0301 trang ti\u0300m kiê\u0301m tô\u0301i đa:";
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(27, 248);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(120, 16);
		label9.TabIndex = 32;
		label9.Text = "Sô\u0301 tư\u0300 kho\u0301a câ\u0300n ti\u0300m:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 332);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(146, 16);
		label2.TabIndex = 32;
		label2.Text = "Thơ\u0300i gian lươ\u0301t trên web:";
		C79B7C3D.AutoSize = true;
		C79B7C3D.Location = new System.Drawing.Point(27, 52);
		C79B7C3D.Name = "label1";
		C79B7C3D.Size = new System.Drawing.Size(98, 16);
		C79B7C3D.TabIndex = 31;
		C79B7C3D.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 369);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		F99E3C30.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F99E3C30.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		F99E3C30.Cursor = System.Windows.Forms.Cursors.Hand;
		F99E3C30.FlatAppearance.BorderSize = 0;
		F99E3C30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F99E3C30.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F99E3C30.ForeColor = System.Drawing.Color.White;
		F99E3C30.Location = new System.Drawing.Point(82, 369);
		F99E3C30.Name = "btnAdd";
		F99E3C30.Size = new System.Drawing.Size(92, 29);
		F99E3C30.TabIndex = 9;
		F99E3C30.Text = "Thêm";
		F99E3C30.UseVisualStyleBackColor = false;
		F99E3C30.Click += new System.EventHandler(F99E3C30_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(EC093EBD);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 413);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDTimKiemGoogle";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(AF9E4E34_Load);
		EC093EBD.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudCountTimeScrollFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountLinkClickFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountPageFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)AC0A8E30).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountTimeScrollTo).EndInit();
		((System.ComponentModel.ISupportInitialize)D2B05A21).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountPageTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudCountTuKhoaTo).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
