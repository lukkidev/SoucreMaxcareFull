using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDDangStory : Form
{
	private GClass11 gclass11_0;

	private string F9804C2F;

	private string F19CE097;

	private string string_0;

	private int DE867788;

	public static bool EB95E78F;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button CDBEF926;

	private PictureBox AC0E8134;

	private BunifuCustomLabel bunifuCustomLabel1;

	private TextBox DA2EC53D;

	private Label label3;

	public fHDDangStory(string string_1, int int_0 = 0, string string_2 = "")
	{
		DE9CEC3C();
		EB95E78F = false;
		F9804C2F = string_1;
		string_0 = string_2;
		DE867788 = int_0;
		string text = "HDDangStory";
		string text2 = "Đăng story";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "','" + text2 + "');");
		}
		string string_3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_3 = dataTable2.Rows[0]["CauHinh"].ToString();
			F19CE097 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			string_3 = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void fHDDangStory_Load(object sender, EventArgs e)
	{
		try
		{
			DA2EC53D.Text = gclass11_0.C0288288("txtPathAnh");
		}
		catch (Exception)
		{
		}
	}

	private void BF1C6419(object sender, EventArgs e)
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
		gClass.method_4("txtPathAnh", DA2EC53D.Text.Trim());
		string text2 = gClass.method_7();
		if (DE867788 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(F9804C2F, text, F19CE097, text2))
				{
					EB95E78F = true;
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
			if (Class147.smethod_13(string_0, text, text2))
			{
				EB95E78F = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void C095EB3E(object sender, EventArgs e)
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

	protected override void Dispose(bool D71A9C2A)
	{
		if (D71A9C2A && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D71A9C2A);
	}

	private void DE9CEC3C()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fHDDangStory));
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new BunifuCustomLabel();
		bunifuDragControl_1 = new BunifuDragControl(icontainer_0);
		pnlHeader = new Panel();
		CDBEF926 = new Button();
		AC0E8134 = new PictureBox();
		panel1 = new Panel();
		DA2EC53D = new TextBox();
		label3 = new Label();
		btnAdd = new Button();
		txtTenHanhDong = new TextBox();
		label1 = new Label();
		btnCancel = new Button();
		bunifuCards1 = new BunifuCards();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)AC0E8134).BeginInit();
		panel1.SuspendLayout();
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
		bunifuCustomLabel1.Size = new Size(374, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đăng story";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(CDBEF926);
		pnlHeader.Controls.Add(AC0E8134);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = Cursors.SizeAll;
		pnlHeader.Location = new Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(374, 31);
		pnlHeader.TabIndex = 9;
		CDBEF926.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		CDBEF926.Cursor = Cursors.Hand;
		CDBEF926.FlatAppearance.BorderSize = 0;
		CDBEF926.FlatStyle = FlatStyle.Flat;
		CDBEF926.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		CDBEF926.ForeColor = Color.White;
		CDBEF926.Image = (Image)componentResourceManager.GetObject("button1.Image");
		CDBEF926.Location = new Point(343, 1);
		CDBEF926.Name = "button1";
		CDBEF926.Size = new Size(30, 30);
		CDBEF926.TabIndex = 0;
		CDBEF926.TextImageRelation = TextImageRelation.ImageBeforeText;
		CDBEF926.UseVisualStyleBackColor = true;
		CDBEF926.Click += BF1C6419;
		AC0E8134.Cursor = Cursors.Default;
		AC0E8134.Image = C50FB39E.Bitmap_5;
		AC0E8134.Location = new Point(3, 2);
		AC0E8134.Name = "pictureBox1";
		AC0E8134.Size = new Size(34, 27);
		AC0E8134.SizeMode = PictureBoxSizeMode.Zoom;
		AC0E8134.TabIndex = 76;
		AC0E8134.TabStop = false;
		panel1.BackColor = Color.White;
		panel1.BorderStyle = BorderStyle.FixedSingle;
		panel1.Controls.Add(DA2EC53D);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = Cursors.Arrow;
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(377, 161);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		DA2EC53D.Location = new Point(132, 78);
		DA2EC53D.Name = "txtPathAnh";
		DA2EC53D.Size = new Size(205, 23);
		DA2EC53D.TabIndex = 1;
		label3.AutoSize = true;
		label3.Location = new Point(30, 81);
		label3.Name = "label3";
		label3.Size = new Size(73, 16);
		label3.TabIndex = 0;
		label3.Text = "Folder ảnh:";
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(92, 118);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		txtTenHanhDong.Location = new Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new Size(205, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new Point(30, 52);
		label1.Name = "label1";
		label1.Size = new Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(191, 118);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += C095EB3E;
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
		bunifuCards1.Size = new Size(374, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(377, 161);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(3, 4, 3, 4);
		base.Name = "fHDDangStory";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += fHDDangStory_Load;
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)AC0E8134).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}
}
