using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhKhoiPhucTaiKhoan : Form
{
	public static bool bool_0 = false;

	public static int int_0 = 0;

	public static string string_0 = "";

	private int int_1 = 0;

	private IContainer D581D617 = null;

	private BunifuCards F9AB3B38;

	private Panel AABFAAA4;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button D000542C;

	private Button BC212D05;

	private Button btnAdd;

	private BunifuDragControl C79678BE;

	private PictureBox pictureBox1;

	private RadioButton rbThuMucCu;

	private RadioButton rbThuMucKhac;

	private Button E58C5C0E;

	private ComboBox EFA196A4;

	private Panel plThuMucKhac;

	public fCauHinhKhoiPhucTaiKhoan()
	{
		DB972713();
		F7AB102E.D6B70A35(this);
		method_1();
		bool_0 = false;
		int_0 = 0;
		string_0 = "";
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(rbThuMucCu);
		F7AB102E.smethod_1(rbThuMucKhac);
		F7AB102E.smethod_1(E58C5C0E);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(BC212D05);
	}

	private void D000542C_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B918698F(object sender, EventArgs e)
	{
		if (rbThuMucKhac.Checked)
		{
			if (EFA196A4.SelectedIndex == -1)
			{
				GClass29.smethod_0("Vui lòng thêm thư mục để lưu tài khoản!", 3);
				return;
			}
			int_0 = 1;
			string_0 = EFA196A4.SelectedValue.ToString();
		}
		bool_0 = true;
		Close();
	}

	private void BC212D05_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void fCauHinhKhoiPhucTaiKhoan_Load(object sender, EventArgs e)
	{
		FD07BF99(null, null);
	}

	private void E58C5C0E_Click(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		GClass8.smethod_33(form_);
		if (fAddFile.C13CD985)
		{
			method_1();
			EFA196A4.SelectedIndex = EFA196A4.Items.Count - 1;
		}
	}

	private void method_1()
	{
		int_1 = EFA196A4.SelectedIndex;
		DataTable dataTable = Class15.smethod_1();
		if (dataTable.Rows.Count > 0)
		{
			EFA196A4.DataSource = dataTable;
			EFA196A4.ValueMember = "id";
			EFA196A4.DisplayMember = "name";
			if (int_1 == -1)
			{
				int_1 = 0;
			}
			EFA196A4.SelectedIndex = int_1;
		}
	}

	private void FD07BF99(object sender, EventArgs e)
	{
		plThuMucKhac.Enabled = rbThuMucKhac.Checked;
	}

	protected override void Dispose(bool C9036C3B)
	{
		if (C9036C3B && D581D617 != null)
		{
			D581D617.Dispose();
		}
		base.Dispose(C9036C3B);
	}

	private void DB972713()
	{
		D581D617 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fCauHinhKhoiPhucTaiKhoan));
		F9AB3B38 = new BunifuCards();
		AABFAAA4 = new Panel();
		pictureBox1 = new PictureBox();
		D000542C = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		BC212D05 = new Button();
		btnAdd = new Button();
		C79678BE = new BunifuDragControl(D581D617);
		rbThuMucCu = new RadioButton();
		rbThuMucKhac = new RadioButton();
		E58C5C0E = new Button();
		EFA196A4 = new ComboBox();
		plThuMucKhac = new Panel();
		F9AB3B38.SuspendLayout();
		AABFAAA4.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		plThuMucKhac.SuspendLayout();
		SuspendLayout();
		F9AB3B38.BackColor = Color.White;
		F9AB3B38.BorderRadius = 0;
		F9AB3B38.BottomSahddow = true;
		F9AB3B38.color = Color.SaddleBrown;
		F9AB3B38.Controls.Add(AABFAAA4);
		F9AB3B38.Dock = DockStyle.Top;
		F9AB3B38.LeftSahddow = false;
		F9AB3B38.Location = new Point(0, 0);
		F9AB3B38.Name = "bunifuCards1";
		F9AB3B38.RightSahddow = true;
		F9AB3B38.ShadowDepth = 20;
		F9AB3B38.Size = new Size(365, 34);
		F9AB3B38.TabIndex = 0;
		AABFAAA4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		AABFAAA4.BackColor = Color.White;
		AABFAAA4.Controls.Add(pictureBox1);
		AABFAAA4.Controls.Add(D000542C);
		AABFAAA4.Controls.Add(bunifuCustomLabel1);
		AABFAAA4.Location = new Point(0, 3);
		AABFAAA4.Name = "pnlHeader";
		AABFAAA4.Size = new Size(365, 28);
		AABFAAA4.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 17;
		pictureBox1.TabStop = false;
		D000542C.Cursor = Cursors.Hand;
		D000542C.Dock = DockStyle.Right;
		D000542C.FlatAppearance.BorderSize = 0;
		D000542C.FlatStyle = FlatStyle.Flat;
		D000542C.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D000542C.ForeColor = Color.White;
		D000542C.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		D000542C.Location = new Point(333, 0);
		D000542C.Name = "btnMinimize";
		D000542C.Size = new Size(32, 28);
		D000542C.TabIndex = 9;
		D000542C.TextImageRelation = TextImageRelation.ImageBeforeText;
		D000542C.UseVisualStyleBackColor = true;
		D000542C.Click += D000542C_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(365, 28);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Câ\u0301u hi\u0300nh Khôi phu\u0323c ta\u0300i khoa\u0309n";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		BC212D05.BackColor = Color.Maroon;
		BC212D05.Cursor = Cursors.Hand;
		BC212D05.FlatAppearance.BorderSize = 0;
		BC212D05.FlatStyle = FlatStyle.Flat;
		BC212D05.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		BC212D05.ForeColor = Color.White;
		BC212D05.Location = new Point(188, 162);
		BC212D05.Name = "btnCancel";
		BC212D05.Size = new Size(92, 29);
		BC212D05.TabIndex = 4;
		BC212D05.Text = "Đo\u0301ng";
		BC212D05.UseVisualStyleBackColor = false;
		BC212D05.Click += BC212D05_Click;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(84, 162);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += B918698F;
		C79678BE.Fixed = true;
		C79678BE.Horizontal = true;
		C79678BE.TargetControl = bunifuCustomLabel1;
		C79678BE.Vertical = true;
		rbThuMucCu.AutoSize = true;
		rbThuMucCu.Checked = true;
		rbThuMucCu.Cursor = Cursors.Hand;
		rbThuMucCu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbThuMucCu.Location = new Point(36, 56);
		rbThuMucCu.Name = "rbThuMucCu";
		rbThuMucCu.Size = new Size(165, 20);
		rbThuMucCu.TabIndex = 5;
		rbThuMucCu.TabStop = true;
		rbThuMucCu.Text = "Khôi phu\u0323c vê\u0300 thư mu\u0323c cu\u0303";
		rbThuMucCu.UseVisualStyleBackColor = true;
		rbThuMucKhac.AutoSize = true;
		rbThuMucKhac.Cursor = Cursors.Hand;
		rbThuMucKhac.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbThuMucKhac.Location = new Point(36, 82);
		rbThuMucKhac.Name = "rbThuMucKhac";
		rbThuMucKhac.Size = new Size(179, 20);
		rbThuMucKhac.TabIndex = 5;
		rbThuMucKhac.Text = "Chuyê\u0309n sang thư mu\u0323c kha\u0301c";
		rbThuMucKhac.UseVisualStyleBackColor = true;
		rbThuMucKhac.CheckedChanged += FD07BF99;
		E58C5C0E.Cursor = Cursors.Hand;
		E58C5C0E.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		E58C5C0E.Location = new Point(210, 2);
		E58C5C0E.Name = "button1";
		E58C5C0E.Size = new Size(62, 27);
		E58C5C0E.TabIndex = 48;
		E58C5C0E.Text = "Thêm";
		E58C5C0E.UseVisualStyleBackColor = true;
		E58C5C0E.Click += E58C5C0E_Click;
		EFA196A4.Cursor = Cursors.Hand;
		EFA196A4.DropDownStyle = ComboBoxStyle.DropDownList;
		EFA196A4.DropDownWidth = 269;
		EFA196A4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		EFA196A4.FormattingEnabled = true;
		EFA196A4.Location = new Point(3, 3);
		EFA196A4.Name = "cbbThuMuc";
		EFA196A4.Size = new Size(201, 24);
		EFA196A4.TabIndex = 47;
		plThuMucKhac.BorderStyle = BorderStyle.FixedSingle;
		plThuMucKhac.Controls.Add(EFA196A4);
		plThuMucKhac.Controls.Add(E58C5C0E);
		plThuMucKhac.Location = new Point(55, 108);
		plThuMucKhac.Name = "plThuMucKhac";
		plThuMucKhac.Size = new Size(278, 33);
		plThuMucKhac.TabIndex = 49;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(365, 205);
		base.Controls.Add(plThuMucKhac);
		base.Controls.Add(rbThuMucKhac);
		base.Controls.Add(rbThuMucCu);
		base.Controls.Add(BC212D05);
		base.Controls.Add(btnAdd);
		base.Controls.Add(F9AB3B38);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCauHinhKhoiPhucTaiKhoan";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += fCauHinhKhoiPhucTaiKhoan_Load;
		F9AB3B38.ResumeLayout(performLayout: false);
		AABFAAA4.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		plThuMucKhac.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
