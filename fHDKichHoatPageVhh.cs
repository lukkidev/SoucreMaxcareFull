using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDKichHoatPageVhh : Form
{
	private GClass11 FF34CCB8 = null;

	private string string_0;

	private string D91FA627;

	private string D1993685;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl D1380924;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button F9963F23;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button DABB6B15;

	private PictureBox A382218D;

	private BunifuCustomLabel FC90D331;

	public fHDKichHoatPageVhh(string string_1, int int_1 = 0, string F9B3CB15 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_1;
		D1993685 = F9B3CB15;
		int_0 = int_1;
		string string_2 = base.Name.Substring(1);
		string string_3 = "Ki\u0301ch hoa\u0323t page vhh";
		Class147.smethod_8(string_2, string_3);
		string string_4 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", string_2);
			string_4 = dataTable2.Rows[0]["CauHinh"].ToString();
			D91FA627 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(F9B3CB15);
			string_4 = dataTable.Rows[0]["CauHinh"].ToString();
			F9963F23.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		FF34CCB8 = new GClass11(string_4, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(FC90D331);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(F9963F23);
		F7AB102E.smethod_1(btnCancel);
	}

	private void FB2F311D(object sender, EventArgs e)
	{
	}

	private void DABB6B15_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F9963F23_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		string text2 = FF34CCB8.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, D91FA627, text2))
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
			if (Class147.smethod_13(D1993685, text, text2))
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

	private void C7A320A1(object sender, EventArgs e)
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

	protected override void Dispose(bool C599C20A)
	{
		if (C599C20A && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C599C20A);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDKichHoatPageVhh));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		FC90D331 = new Bunifu.Framework.UI.BunifuCustomLabel();
		D1380924 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		DABB6B15 = new System.Windows.Forms.Button();
		A382218D = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		F9963F23 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A382218D).BeginInit();
		panel1.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = FC90D331;
		bunifuDragControl_0.Vertical = true;
		FC90D331.BackColor = System.Drawing.Color.Transparent;
		FC90D331.Cursor = System.Windows.Forms.Cursors.SizeAll;
		FC90D331.Dock = System.Windows.Forms.DockStyle.Fill;
		FC90D331.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		FC90D331.ForeColor = System.Drawing.Color.Black;
		FC90D331.Location = new System.Drawing.Point(0, 0);
		FC90D331.Name = "bunifuCustomLabel1";
		FC90D331.Size = new System.Drawing.Size(359, 31);
		FC90D331.TabIndex = 12;
		FC90D331.Text = "Cấu hình Ki\u0301ch hoa\u0323t page vhh";
		FC90D331.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		D1380924.Fixed = true;
		D1380924.Horizontal = true;
		D1380924.TargetControl = pnlHeader;
		D1380924.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(DABB6B15);
		pnlHeader.Controls.Add(A382218D);
		pnlHeader.Controls.Add(FC90D331);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(359, 31);
		pnlHeader.TabIndex = 9;
		DABB6B15.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		DABB6B15.Cursor = System.Windows.Forms.Cursors.Hand;
		DABB6B15.FlatAppearance.BorderSize = 0;
		DABB6B15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DABB6B15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DABB6B15.ForeColor = System.Drawing.Color.White;
		DABB6B15.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		DABB6B15.Location = new System.Drawing.Point(328, 1);
		DABB6B15.Name = "button1";
		DABB6B15.Size = new System.Drawing.Size(30, 30);
		DABB6B15.TabIndex = 77;
		DABB6B15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		DABB6B15.UseVisualStyleBackColor = true;
		DABB6B15.Click += new System.EventHandler(DABB6B15_Click);
		A382218D.Cursor = System.Windows.Forms.Cursors.Default;
		A382218D.Image = C50FB39E.Bitmap_5;
		A382218D.Location = new System.Drawing.Point(3, 2);
		A382218D.Name = "pictureBox1";
		A382218D.Size = new System.Drawing.Size(34, 27);
		A382218D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A382218D.TabIndex = 76;
		A382218D.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(F9963F23);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(362, 132);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
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
		btnCancel.Location = new System.Drawing.Point(189, 88);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(C7A320A1);
		F9963F23.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		F9963F23.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		F9963F23.Cursor = System.Windows.Forms.Cursors.Hand;
		F9963F23.FlatAppearance.BorderSize = 0;
		F9963F23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F9963F23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		F9963F23.ForeColor = System.Drawing.Color.White;
		F9963F23.Location = new System.Drawing.Point(82, 88);
		F9963F23.Name = "btnAdd";
		F9963F23.Size = new System.Drawing.Size(92, 29);
		F9963F23.TabIndex = 9;
		F9963F23.Text = "Thêm";
		F9963F23.UseVisualStyleBackColor = false;
		F9963F23.Click += new System.EventHandler(F9963F23_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(359, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(362, 132);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDKichHoatPageVhh";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(FB2F311D);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A382218D).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
