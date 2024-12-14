using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDXoaSdt : Form
{
	private GClass11 A9044A20 = null;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool C13EAFA1;

	private IContainer E615D282 = null;

	private BunifuDragControl D11C8B96;

	private BunifuDragControl DE34D6AC;

	private Panel B484B73A;

	private TextBox F50817B9;

	private Label C8BE010D;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel FFBC4F0B;

	private Button button1;

	private PictureBox B6917D08;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ComboBox cbbFacebookWeb;

	private Label C7394C27;

	public fHDXoaSdt(string F2A27797, int F60B72A2 = 0, string string_3 = "")
	{
		InitializeComponent();
		C13EAFA1 = false;
		string_0 = F2A27797;
		string_2 = string_3;
		int_0 = F60B72A2;
		string text = base.Name.Substring(1);
		string text2 = "Xóa Sđt";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (F60B72A2)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			F50817B9.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			F50817B9.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		A9044A20 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void fHDXoaSdt_Load(object sender, EventArgs e)
	{
		try
		{
			method_0();
			cbbFacebookWeb.SelectedValue = A9044A20.C0288288("cbbFacebookWeb", "3");
		}
		catch (Exception)
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("3", "Sử dụng Accounts Center");
		dictionary.Add("1", "Sử dụng m.fb");
		dictionary.Add("4", "Sử dụng mbasic");
		dictionary.Add("0", "Sử dụng www");
		dictionary.Add("2", "Sử dụng tut không pass");
		GClass8.smethod_23(cbbFacebookWeb, dictionary);
	}

	private void B1248B02(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string text = F50817B9.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		A9044A20.method_4("cbbFacebookWeb", cbbFacebookWeb.SelectedValue);
		string text2 = A9044A20.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, text2))
				{
					C13EAFA1 = true;
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
				C13EAFA1 = true;
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

	private void B484B73A_Paint(object sender, PaintEventArgs e)
	{
		if (B484B73A.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, B484B73A.ClientSize.Width - num, B484B73A.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool DDBBDF1D)
	{
		if (DDBBDF1D && E615D282 != null)
		{
			E615D282.Dispose();
		}
		base.Dispose(DDBBDF1D);
	}

	private void InitializeComponent()
	{
		E615D282 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDXoaSdt));
		D11C8B96 = new Bunifu.Framework.UI.BunifuDragControl(E615D282);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		DE34D6AC = new Bunifu.Framework.UI.BunifuDragControl(E615D282);
		FFBC4F0B = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		B6917D08 = new System.Windows.Forms.PictureBox();
		B484B73A = new System.Windows.Forms.Panel();
		cbbFacebookWeb = new System.Windows.Forms.ComboBox();
		C7394C27 = new System.Windows.Forms.Label();
		F50817B9 = new System.Windows.Forms.TextBox();
		C8BE010D = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		FFBC4F0B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B6917D08).BeginInit();
		B484B73A.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		D11C8B96.Fixed = true;
		D11C8B96.Horizontal = true;
		D11C8B96.TargetControl = bunifuCustomLabel1;
		D11C8B96.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(359, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Xóa Sđt";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DE34D6AC.Fixed = true;
		DE34D6AC.Horizontal = true;
		DE34D6AC.TargetControl = FFBC4F0B;
		DE34D6AC.Vertical = true;
		FFBC4F0B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		FFBC4F0B.BackColor = System.Drawing.Color.White;
		FFBC4F0B.Controls.Add(button1);
		FFBC4F0B.Controls.Add(B6917D08);
		FFBC4F0B.Controls.Add(bunifuCustomLabel1);
		FFBC4F0B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FFBC4F0B.Location = new System.Drawing.Point(0, 3);
		FFBC4F0B.Name = "pnlHeader";
		FFBC4F0B.Size = new System.Drawing.Size(359, 31);
		FFBC4F0B.TabIndex = 9;
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
		button1.Click += new System.EventHandler(B1248B02);
		B6917D08.Cursor = System.Windows.Forms.Cursors.Default;
		B6917D08.Image = C50FB39E.Bitmap_5;
		B6917D08.Location = new System.Drawing.Point(3, 2);
		B6917D08.Name = "pictureBox1";
		B6917D08.Size = new System.Drawing.Size(34, 27);
		B6917D08.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B6917D08.TabIndex = 76;
		B6917D08.TabStop = false;
		B484B73A.BackColor = System.Drawing.Color.White;
		B484B73A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		B484B73A.Controls.Add(cbbFacebookWeb);
		B484B73A.Controls.Add(C7394C27);
		B484B73A.Controls.Add(F50817B9);
		B484B73A.Controls.Add(C8BE010D);
		B484B73A.Controls.Add(btnCancel);
		B484B73A.Controls.Add(btnAdd);
		B484B73A.Controls.Add(bunifuCards1);
		B484B73A.Cursor = System.Windows.Forms.Cursors.Arrow;
		B484B73A.Dock = System.Windows.Forms.DockStyle.Fill;
		B484B73A.Location = new System.Drawing.Point(0, 0);
		B484B73A.Name = "panel1";
		B484B73A.Size = new System.Drawing.Size(362, 165);
		B484B73A.TabIndex = 0;
		B484B73A.Paint += new System.Windows.Forms.PaintEventHandler(B484B73A_Paint);
		cbbFacebookWeb.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbFacebookWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbFacebookWeb.DropDownWidth = 200;
		cbbFacebookWeb.FormattingEnabled = true;
		cbbFacebookWeb.Location = new System.Drawing.Point(132, 78);
		cbbFacebookWeb.Name = "cbbFacebookWeb";
		cbbFacebookWeb.Size = new System.Drawing.Size(194, 24);
		cbbFacebookWeb.TabIndex = 193;
		C7394C27.AutoSize = true;
		C7394C27.Location = new System.Drawing.Point(27, 81);
		C7394C27.Name = "label10";
		C7394C27.Size = new System.Drawing.Size(64, 16);
		C7394C27.TabIndex = 192;
		C7394C27.Text = "Tùy chọn:";
		F50817B9.Location = new System.Drawing.Point(132, 49);
		F50817B9.Name = "txtTenHanhDong";
		F50817B9.Size = new System.Drawing.Size(194, 23);
		F50817B9.TabIndex = 0;
		C8BE010D.AutoSize = true;
		C8BE010D.Location = new System.Drawing.Point(27, 52);
		C8BE010D.Name = "label1";
		C8BE010D.Size = new System.Drawing.Size(98, 16);
		C8BE010D.TabIndex = 31;
		C8BE010D.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(189, 121);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(82, 121);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 9;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(FFBC4F0B);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 165);
		base.Controls.Add(B484B73A);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDXoaSdt";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDXoaSdt_Load);
		FFBC4F0B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B6917D08).EndInit();
		B484B73A.ResumeLayout(false);
		B484B73A.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
