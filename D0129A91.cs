using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class D0129A91 : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string BE20F793;

	private int F98AAB03;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl ADBA45BC;

	private Panel panel1;

	private NumericUpDown nudDelayTo;

	private NumericUpDown D81F3419;

	private TextBox txtTenHanhDong;

	private Label E89EB019;

	private Label C49DCF2E;

	private Label B60DDF22;

	private Button btnCancel;

	private Button F00234AE;

	private BunifuCards bunifuCards1;

	private Panel F49DBD85;

	private Button button1;

	private PictureBox DCB1751C;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label A5B933AA;

	private RichTextBox C518638F;

	public D0129A91(string string_2, int int_0 = 0, string string_3 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_2;
		BE20F793 = string_3;
		F98AAB03 = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Follow";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_3);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			F00234AE.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void D4BE898E(object sender, EventArgs e)
	{
		try
		{
			D81F3419.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			C518638F.Text = gclass11_0.C0288288("txtUid");
		}
		catch
		{
		}
	}

	private void BE2D6431(object sender, EventArgs e)
	{
		Close();
	}

	private void A1B98CA4(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudDelayFrom", D81F3419.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtUid", C518638F.Text.Trim());
		string string_ = gClass.method_7();
		if (F98AAB03 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, string_1, string_))
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
			if (Class147.smethod_13(BE20F793, text, string_))
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

	private void DBB89B86(object sender, EventArgs e)
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

	private void C518638F_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(C518638F, A5B933AA);
	}

	protected override void Dispose(bool FBA3ECAA)
	{
		if (FBA3ECAA && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(FBA3ECAA);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D0129A91));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		ADBA45BC = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		F49DBD85 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		DCB1751C = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		C518638F = new System.Windows.Forms.RichTextBox();
		A5B933AA = new System.Windows.Forms.Label();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		D81F3419 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		E89EB019 = new System.Windows.Forms.Label();
		C49DCF2E = new System.Windows.Forms.Label();
		B60DDF22 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		F00234AE = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		F49DBD85.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)DCB1751C).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)D81F3419).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(318, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Follow";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		ADBA45BC.Fixed = true;
		ADBA45BC.Horizontal = true;
		ADBA45BC.TargetControl = F49DBD85;
		ADBA45BC.Vertical = true;
		F49DBD85.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F49DBD85.BackColor = System.Drawing.Color.White;
		F49DBD85.Controls.Add(button1);
		F49DBD85.Controls.Add(DCB1751C);
		F49DBD85.Controls.Add(bunifuCustomLabel1);
		F49DBD85.Cursor = System.Windows.Forms.Cursors.SizeAll;
		F49DBD85.Location = new System.Drawing.Point(0, 3);
		F49DBD85.Name = "pnlHeader";
		F49DBD85.Size = new System.Drawing.Size(318, 31);
		F49DBD85.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(287, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(BE2D6431);
		DCB1751C.Cursor = System.Windows.Forms.Cursors.Default;
		DCB1751C.Image = C50FB39E.Bitmap_5;
		DCB1751C.Location = new System.Drawing.Point(3, 2);
		DCB1751C.Name = "pictureBox1";
		DCB1751C.Size = new System.Drawing.Size(34, 27);
		DCB1751C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		DCB1751C.TabIndex = 76;
		DCB1751C.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(C518638F);
		panel1.Controls.Add(A5B933AA);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(D81F3419);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(E89EB019);
		panel1.Controls.Add(C49DCF2E);
		panel1.Controls.Add(B60DDF22);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(F00234AE);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(321, 342);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		C518638F.Location = new System.Drawing.Point(30, 125);
		C518638F.Name = "txtUid";
		C518638F.Size = new System.Drawing.Size(257, 159);
		C518638F.TabIndex = 41;
		C518638F.Text = "";
		C518638F.WordWrap = false;
		C518638F.TextChanged += new System.EventHandler(C518638F_TextChanged);
		A5B933AA.AutoSize = true;
		A5B933AA.Location = new System.Drawing.Point(27, 105);
		A5B933AA.Name = "lblUid";
		A5B933AA.Size = new System.Drawing.Size(140, 16);
		A5B933AA.TabIndex = 40;
		A5B933AA.Text = "Nhập danh sách ID (0):";
		nudDelayTo.Location = new System.Drawing.Point(231, 78);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 4;
		D81F3419.Location = new System.Drawing.Point(134, 78);
		D81F3419.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D81F3419.Name = "nudDelayFrom";
		D81F3419.Size = new System.Drawing.Size(56, 23);
		D81F3419.TabIndex = 3;
		txtTenHanhDong.Location = new System.Drawing.Point(134, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		E89EB019.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E89EB019.Location = new System.Drawing.Point(196, 80);
		E89EB019.Name = "label7";
		E89EB019.Size = new System.Drawing.Size(29, 16);
		E89EB019.TabIndex = 38;
		E89EB019.Text = ">";
		E89EB019.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C49DCF2E.AutoSize = true;
		C49DCF2E.Location = new System.Drawing.Point(27, 80);
		C49DCF2E.Name = "label5";
		C49DCF2E.Size = new System.Drawing.Size(87, 16);
		C49DCF2E.TabIndex = 34;
		C49DCF2E.Text = "Gia\u0303n ca\u0301ch (s):";
		B60DDF22.AutoSize = true;
		B60DDF22.Location = new System.Drawing.Point(27, 52);
		B60DDF22.Name = "label1";
		B60DDF22.Size = new System.Drawing.Size(98, 16);
		B60DDF22.TabIndex = 31;
		B60DDF22.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(167, 298);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(DBB89B86);
		F00234AE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F00234AE.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		F00234AE.Cursor = System.Windows.Forms.Cursors.Hand;
		F00234AE.FlatAppearance.BorderSize = 0;
		F00234AE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F00234AE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F00234AE.ForeColor = System.Drawing.Color.White;
		F00234AE.Location = new System.Drawing.Point(60, 298);
		F00234AE.Name = "btnAdd";
		F00234AE.Size = new System.Drawing.Size(92, 29);
		F00234AE.TabIndex = 9;
		F00234AE.Text = "Thêm";
		F00234AE.UseVisualStyleBackColor = false;
		F00234AE.Click += new System.EventHandler(A1B98CA4);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(F49DBD85);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(318, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(321, 342);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDBuffFollowCaNhan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D4BE898E);
		F49DBD85.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)DCB1751C).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)D81F3419).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
