using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class AE162A09 : Form
{
	private GClass11 gclass11_0 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int E8BCDB9B;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl A22906AB;

	private Panel F88D0A8F;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards B113C206;

	private Panel B80D79AF;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button1;

	private TextBox txtPassword;

	private Label label5;

	private RadioButton F3B03408;

	private RadioButton rbPassRandom;

	private Label A2B45233;

	private CheckBox ckbFollow;

	private TextBox txtPathFileSaveAcc;

	private Panel panel3;

	private TextBox A192452C;

	private Label label2;

	private CheckBox ckbUpAvatar;

	private Panel panel2;

	private NumericUpDown nudSoLuongFrom;

	private NumericUpDown BD2F0A2E;

	private Label F78DCD92;

	private Label label3;

	private RichTextBox txtBio;

	private CheckBox ckbBio;

	private Panel panel4;

	private Label label6;

	public AE162A09(string D7BF9994, int EDA3420D = 0, string FDAB20BE = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = D7BF9994;
		string_2 = FDAB20BE;
		E8BCDB9B = EDA3420D;
		if (Class147.smethod_7("", "HDLinkToInstagram").Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('HDLinkToInstagram', 'Liên kết Instagram');");
		}
		string text = "";
		switch (EDA3420D)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDLinkToInstagram");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(FDAB20BE);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void BFBA9EA1()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(A2B45233);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(F78DCD92);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void CF27D30E(object sender, EventArgs e)
	{
		try
		{
			if (gclass11_0.method_2("typePass") == 0)
			{
				rbPassRandom.Checked = true;
			}
			else
			{
				F3B03408.Checked = true;
			}
			txtPassword.Text = gclass11_0.C0288288("txtPassword");
			txtPathFileSaveAcc.Text = GClass28.smethod_0() + "\\accountIG.txt";
			ckbUpAvatar.Checked = gclass11_0.method_3("ckbUpAvatar");
			A192452C.Text = gclass11_0.C0288288("txtPathImage");
			ckbFollow.Checked = gclass11_0.method_3("ckbFollow");
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			BD2F0A2E.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			ckbBio.Checked = gclass11_0.method_3("ckbBio");
			txtBio.Text = gclass11_0.C0288288("txtBio");
		}
		catch
		{
		}
		F3B03408_CheckedChanged(null, null);
		E0899D86(null, null);
		ckbFollow_CheckedChanged(null, null);
		ckbBio_CheckedChanged(null, null);
		E4890D06(null, null);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		int num = 0;
		if (F3B03408.Checked)
		{
			num = 1;
		}
		gClass.method_4("typePass", num);
		gClass.method_4("txtPassword", txtPassword.Text.Trim());
		gClass.method_4("ckbUpAvatar", ckbUpAvatar.Checked);
		gClass.method_4("txtPathImage", A192452C.Text.Trim());
		gClass.method_4("ckbFollow", ckbFollow.Checked);
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", BD2F0A2E.Value);
		gClass.method_4("ckbBio", ckbBio.Checked);
		gClass.method_4("txtBio", txtBio.Text);
		string text2 = gClass.method_7();
		if (E8BCDB9B == 0)
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

	private void C78DCA01(object sender, EventArgs e)
	{
		Close();
	}

	private void F88D0A8F_Paint(object sender, PaintEventArgs e)
	{
		if (F88D0A8F.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F88D0A8F.ClientSize.Width - num, F88D0A8F.ClientSize.Height - num));
		}
	}

	private void F3B03408_CheckedChanged(object sender, EventArgs e)
	{
		txtPassword.Enabled = F3B03408.Checked;
	}

	private void txtPathFileSaveAcc_TextChanged(object sender, EventArgs e)
	{
	}

	private void E0899D86(object sender, EventArgs e)
	{
		panel3.Enabled = ckbUpAvatar.Checked;
	}

	private void ckbFollow_CheckedChanged(object sender, EventArgs e)
	{
		panel2.Enabled = ckbFollow.Checked;
	}

	private void ckbBio_CheckedChanged(object sender, EventArgs e)
	{
		panel4.Enabled = ckbBio.Checked;
	}

	private void E4890D06(object sender, EventArgs e)
	{
		try
		{
			List<string> list = new List<string>();
			list = txtBio.Lines.ToList();
			list = GClass8.smethod_36(list);
			label6.Text = string.Format(F7AB102E.smethod_0("Danh sách Bio ({0}):"), list.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool D5881EB0)
	{
		if (D5881EB0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D5881EB0);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		A22906AB = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		B80D79AF = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		F88D0A8F = new System.Windows.Forms.Panel();
		panel4 = new System.Windows.Forms.Panel();
		label6 = new System.Windows.Forms.Label();
		txtBio = new System.Windows.Forms.RichTextBox();
		ckbBio = new System.Windows.Forms.CheckBox();
		panel3 = new System.Windows.Forms.Panel();
		A192452C = new System.Windows.Forms.TextBox();
		label2 = new System.Windows.Forms.Label();
		ckbUpAvatar = new System.Windows.Forms.CheckBox();
		panel2 = new System.Windows.Forms.Panel();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		BD2F0A2E = new System.Windows.Forms.NumericUpDown();
		F78DCD92 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		ckbFollow = new System.Windows.Forms.CheckBox();
		label5 = new System.Windows.Forms.Label();
		F3B03408 = new System.Windows.Forms.RadioButton();
		rbPassRandom = new System.Windows.Forms.RadioButton();
		txtPassword = new System.Windows.Forms.TextBox();
		A2B45233 = new System.Windows.Forms.Label();
		txtPathFileSaveAcc = new System.Windows.Forms.TextBox();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		B113C206 = new Bunifu.Framework.UI.BunifuCards();
		B80D79AF.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		F88D0A8F.SuspendLayout();
		panel4.SuspendLayout();
		panel3.SuspendLayout();
		panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)BD2F0A2E).BeginInit();
		B113C206.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(407, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Liên kết Instagram";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A22906AB.Fixed = true;
		A22906AB.Horizontal = true;
		A22906AB.TargetControl = B80D79AF;
		A22906AB.Vertical = true;
		B80D79AF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B80D79AF.BackColor = System.Drawing.Color.White;
		B80D79AF.Controls.Add(button1);
		B80D79AF.Controls.Add(pictureBox1);
		B80D79AF.Controls.Add(bunifuCustomLabel1);
		B80D79AF.Cursor = System.Windows.Forms.Cursors.SizeAll;
		B80D79AF.Location = new System.Drawing.Point(0, 3);
		B80D79AF.Name = "pnlHeader";
		B80D79AF.Size = new System.Drawing.Size(407, 31);
		B80D79AF.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = C50FB39E.Bitmap_12;
		button1.Location = new System.Drawing.Point(376, 1);
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
		F88D0A8F.BackColor = System.Drawing.Color.White;
		F88D0A8F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F88D0A8F.Controls.Add(panel4);
		F88D0A8F.Controls.Add(ckbBio);
		F88D0A8F.Controls.Add(panel3);
		F88D0A8F.Controls.Add(ckbUpAvatar);
		F88D0A8F.Controls.Add(panel2);
		F88D0A8F.Controls.Add(ckbFollow);
		F88D0A8F.Controls.Add(label5);
		F88D0A8F.Controls.Add(F3B03408);
		F88D0A8F.Controls.Add(rbPassRandom);
		F88D0A8F.Controls.Add(txtPassword);
		F88D0A8F.Controls.Add(A2B45233);
		F88D0A8F.Controls.Add(txtPathFileSaveAcc);
		F88D0A8F.Controls.Add(txtTenHanhDong);
		F88D0A8F.Controls.Add(label1);
		F88D0A8F.Controls.Add(btnCancel);
		F88D0A8F.Controls.Add(btnAdd);
		F88D0A8F.Controls.Add(B113C206);
		F88D0A8F.Cursor = System.Windows.Forms.Cursors.Arrow;
		F88D0A8F.Dock = System.Windows.Forms.DockStyle.Fill;
		F88D0A8F.Location = new System.Drawing.Point(0, 0);
		F88D0A8F.Name = "panel1";
		F88D0A8F.Size = new System.Drawing.Size(410, 206);
		F88D0A8F.TabIndex = 0;
		F88D0A8F.Paint += new System.Windows.Forms.PaintEventHandler(F88D0A8F_Paint);
		panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel4.Controls.Add(label6);
		panel4.Controls.Add(txtBio);
		panel4.Location = new System.Drawing.Point(145, 393);
		panel4.Name = "panel4";
		panel4.Size = new System.Drawing.Size(231, 145);
		panel4.TabIndex = 50;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(3, 3);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(113, 16);
		label6.TabIndex = 50;
		label6.Text = "Danh sách bio (0):";
		txtBio.Location = new System.Drawing.Point(6, 22);
		txtBio.Name = "txtBio";
		txtBio.Size = new System.Drawing.Size(220, 118);
		txtBio.TabIndex = 49;
		txtBio.Text = "";
		txtBio.WordWrap = false;
		txtBio.TextChanged += new System.EventHandler(E4890D06);
		ckbBio.AutoSize = true;
		ckbBio.Location = new System.Drawing.Point(31, 389);
		ckbBio.Name = "ckbBio";
		ckbBio.Size = new System.Drawing.Size(85, 20);
		ckbBio.TabIndex = 48;
		ckbBio.Text = "Thêm bio:";
		ckbBio.UseVisualStyleBackColor = true;
		ckbBio.CheckedChanged += new System.EventHandler(ckbBio_CheckedChanged);
		panel3.Controls.Add(A192452C);
		panel3.Controls.Add(label2);
		panel3.Location = new System.Drawing.Point(145, 330);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(231, 27);
		panel3.TabIndex = 47;
		A192452C.Location = new System.Drawing.Point(97, 2);
		A192452C.Name = "txtPathImage";
		A192452C.Size = new System.Drawing.Size(131, 23);
		A192452C.TabIndex = 0;
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(3, 5);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(88, 16);
		label2.TabIndex = 41;
		label2.Text = "Thư mục ảnh:";
		ckbUpAvatar.AutoSize = true;
		ckbUpAvatar.Location = new System.Drawing.Point(31, 333);
		ckbUpAvatar.Name = "ckbUpAvatar";
		ckbUpAvatar.Size = new System.Drawing.Size(87, 20);
		ckbUpAvatar.TabIndex = 42;
		ckbUpAvatar.Text = "Up Avatar:";
		ckbUpAvatar.UseVisualStyleBackColor = true;
		ckbUpAvatar.CheckedChanged += new System.EventHandler(E0899D86);
		panel2.Controls.Add(nudSoLuongFrom);
		panel2.Controls.Add(BD2F0A2E);
		panel2.Controls.Add(F78DCD92);
		panel2.Controls.Add(label3);
		panel2.Location = new System.Drawing.Point(145, 360);
		panel2.Name = "panel2";
		panel2.Size = new System.Drawing.Size(200, 27);
		panel2.TabIndex = 47;
		nudSoLuongFrom.Location = new System.Drawing.Point(1, 2);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 43;
		BD2F0A2E.Location = new System.Drawing.Point(97, 2);
		BD2F0A2E.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		BD2F0A2E.Name = "nudSoLuongTo";
		BD2F0A2E.Size = new System.Drawing.Size(56, 23);
		BD2F0A2E.TabIndex = 44;
		F78DCD92.AutoSize = true;
		F78DCD92.Location = new System.Drawing.Point(155, 4);
		F78DCD92.Name = "label4";
		F78DCD92.Size = new System.Drawing.Size(39, 16);
		F78DCD92.TabIndex = 45;
		F78DCD92.Text = "người";
		label3.Location = new System.Drawing.Point(62, 4);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 46;
		label3.Text = "đê\u0301n";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ckbFollow.AutoSize = true;
		ckbFollow.Location = new System.Drawing.Point(31, 363);
		ckbFollow.Name = "ckbFollow";
		ckbFollow.Size = new System.Drawing.Size(99, 20);
		ckbFollow.TabIndex = 42;
		ckbFollow.Text = "Follow gợi ý:";
		ckbFollow.UseVisualStyleBackColor = true;
		ckbFollow.CheckedChanged += new System.EventHandler(ckbFollow_CheckedChanged);
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(28, 131);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(110, 16);
		label5.TabIndex = 41;
		label5.Text = "File lưu tài khoản:";
		F3B03408.AutoSize = true;
		F3B03408.Cursor = System.Windows.Forms.Cursors.Hand;
		F3B03408.Location = new System.Drawing.Point(145, 100);
		F3B03408.Name = "rbPassTuNhap";
		F3B03408.Size = new System.Drawing.Size(78, 20);
		F3B03408.TabIndex = 40;
		F3B03408.Text = "Tự nhập:";
		F3B03408.UseVisualStyleBackColor = true;
		F3B03408.CheckedChanged += new System.EventHandler(F3B03408_CheckedChanged);
		rbPassRandom.AutoSize = true;
		rbPassRandom.Checked = true;
		rbPassRandom.Cursor = System.Windows.Forms.Cursors.Hand;
		rbPassRandom.Location = new System.Drawing.Point(145, 76);
		rbPassRandom.Name = "rbPassRandom";
		rbPassRandom.Size = new System.Drawing.Size(89, 20);
		rbPassRandom.TabIndex = 39;
		rbPassRandom.TabStop = true;
		rbPassRandom.Text = "Ngẫu nhiên";
		rbPassRandom.UseVisualStyleBackColor = true;
		txtPassword.Location = new System.Drawing.Point(230, 99);
		txtPassword.Name = "txtPassword";
		txtPassword.Size = new System.Drawing.Size(146, 23);
		txtPassword.TabIndex = 38;
		A2B45233.AutoSize = true;
		A2B45233.Location = new System.Drawing.Point(28, 76);
		A2B45233.Name = "lblStatus";
		A2B45233.Size = new System.Drawing.Size(64, 16);
		A2B45233.TabIndex = 0;
		A2B45233.Text = "Mật khẩu:";
		txtPathFileSaveAcc.Location = new System.Drawing.Point(145, 128);
		txtPathFileSaveAcc.Name = "txtPathFileSaveAcc";
		txtPathFileSaveAcc.ReadOnly = true;
		txtPathFileSaveAcc.Size = new System.Drawing.Size(231, 23);
		txtPathFileSaveAcc.TabIndex = 0;
		txtPathFileSaveAcc.TextChanged += new System.EventHandler(txtPathFileSaveAcc_TextChanged);
		txtTenHanhDong.Location = new System.Drawing.Point(145, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(231, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
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
		btnCancel.Location = new System.Drawing.Point(217, 165);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(C78DCA01);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(110, 165);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		B113C206.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B113C206.BackColor = System.Drawing.Color.White;
		B113C206.BorderRadius = 0;
		B113C206.BottomSahddow = true;
		B113C206.color = System.Drawing.Color.DarkViolet;
		B113C206.Controls.Add(B80D79AF);
		B113C206.LeftSahddow = false;
		B113C206.Location = new System.Drawing.Point(1, 0);
		B113C206.Name = "bunifuCards1";
		B113C206.RightSahddow = true;
		B113C206.ShadowDepth = 20;
		B113C206.Size = new System.Drawing.Size(407, 37);
		B113C206.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(410, 206);
		base.Controls.Add(F88D0A8F);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDLinkToInstagram";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CF27D30E);
		B80D79AF.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		F88D0A8F.ResumeLayout(false);
		F88D0A8F.PerformLayout();
		panel4.ResumeLayout(false);
		panel4.PerformLayout();
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		panel2.ResumeLayout(false);
		panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)BD2F0A2E).EndInit();
		B113C206.ResumeLayout(false);
		ResumeLayout(false);
	}
}
