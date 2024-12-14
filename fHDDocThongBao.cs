using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDDocThongBao : Form
{
	private JObject F08CF58C;

	private string string_0;

	private string E53A36AF;

	private string B306BA05;

	private int D39D181D;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private RadioButton rbNgauNhien;

	private RadioButton rbLanLuot;

	private NumericUpDown nudDelayTo;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown nudDelayFrom;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label3;

	private Label label5;

	private Label label8;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards DB1DB4A0;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel DE38041D;

	public fHDDocThongBao(string string_1, int int_0 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_1;
		B306BA05 = string_2;
		D39D181D = int_0;
		string json = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDDocThongBao");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			E53A36AF = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F08CF58C = JObject.Parse(json);
		F7AB102E.D6B70A35(this);
	}

	private void fHDDocThongBao_Load(object sender, EventArgs e)
	{
		try
		{
			nudSoLuongFrom.Value = Convert.ToInt32(F08CF58C["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(F08CF58C["nudSoLuongTo"]);
			if (F08CF58C["typeDocThongBao"]!.ToString() == "0")
			{
				rbLanLuot.Checked = true;
			}
			else
			{
				rbNgauNhien.Checked = true;
			}
			nudDelayFrom.Value = Convert.ToInt32(F08CF58C["nudDelayFrom"]);
			nudDelayTo.Value = Convert.ToInt32(F08CF58C["nudDelayTo"]);
		}
		catch
		{
		}
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
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		int num = 0;
		if (rbNgauNhien.Checked)
		{
			num = 1;
		}
		gClass.method_4("typeDocThongBao", num);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		string text2 = gClass.method_7();
		if (D39D181D == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, E53A36AF, text2))
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
			if (Class147.smethod_13(B306BA05, text, text2))
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDDocThongBao));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		DE38041D = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		rbNgauNhien = new System.Windows.Forms.RadioButton();
		rbLanLuot = new System.Windows.Forms.RadioButton();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		DB1DB4A0 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		DB1DB4A0.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = DE38041D;
		bunifuDragControl_0.Vertical = true;
		DE38041D.BackColor = System.Drawing.Color.Transparent;
		DE38041D.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DE38041D.Dock = System.Windows.Forms.DockStyle.Fill;
		DE38041D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DE38041D.ForeColor = System.Drawing.Color.Black;
		DE38041D.Location = new System.Drawing.Point(0, 0);
		DE38041D.Name = "bunifuCustomLabel1";
		DE38041D.Size = new System.Drawing.Size(316, 31);
		DE38041D.TabIndex = 12;
		DE38041D.Text = "Cấu hình Đọc thông báo";
		DE38041D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(DE38041D);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(316, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(285, 1);
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
		panel1.Controls.Add(rbNgauNhien);
		panel1.Controls.Add(rbLanLuot);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(nudSoLuongTo);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label7);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(label8);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(DB1DB4A0);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(319, 189);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		rbNgauNhien.AutoSize = true;
		rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNgauNhien.Location = new System.Drawing.Point(216, 228);
		rbNgauNhien.Name = "rbNgauNhien";
		rbNgauNhien.Size = new System.Drawing.Size(89, 20);
		rbNgauNhien.TabIndex = 4;
		rbNgauNhien.TabStop = true;
		rbNgauNhien.Text = "Ngâ\u0303u nhiên";
		rbNgauNhien.UseVisualStyleBackColor = true;
		rbLanLuot.AutoSize = true;
		rbLanLuot.Cursor = System.Windows.Forms.Cursors.Hand;
		rbLanLuot.Location = new System.Drawing.Point(122, 228);
		rbLanLuot.Name = "rbLanLuot";
		rbLanLuot.Size = new System.Drawing.Size(71, 20);
		rbLanLuot.TabIndex = 3;
		rbLanLuot.TabStop = true;
		rbLanLuot.Text = "Lâ\u0300n lươ\u0323t";
		rbLanLuot.UseVisualStyleBackColor = true;
		nudDelayTo.Location = new System.Drawing.Point(228, 108);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 6;
		nudSoLuongTo.Location = new System.Drawing.Point(228, 79);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		nudDelayFrom.Location = new System.Drawing.Point(134, 108);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 5;
		nudSoLuongFrom.Location = new System.Drawing.Point(134, 79);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(134, 50);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(150, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(194, 110);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(194, 81);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(29, 110);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		label8.AutoSize = true;
		label8.Location = new System.Drawing.Point(17, 230);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(92, 16);
		label8.TabIndex = 33;
		label8.Text = "Tu\u0300y cho\u0323n xem:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(29, 81);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(63, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(29, 53);
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
		btnCancel.Location = new System.Drawing.Point(168, 145);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 8;
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
		btnAdd.Location = new System.Drawing.Point(64, 145);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 7;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		DB1DB4A0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DB1DB4A0.BackColor = System.Drawing.Color.White;
		DB1DB4A0.BorderRadius = 0;
		DB1DB4A0.BottomSahddow = true;
		DB1DB4A0.color = System.Drawing.Color.DarkViolet;
		DB1DB4A0.Controls.Add(pnlHeader);
		DB1DB4A0.LeftSahddow = false;
		DB1DB4A0.Location = new System.Drawing.Point(1, 0);
		DB1DB4A0.Name = "bunifuCards1";
		DB1DB4A0.RightSahddow = true;
		DB1DB4A0.ShadowDepth = 20;
		DB1DB4A0.Size = new System.Drawing.Size(316, 37);
		DB1DB4A0.TabIndex = 9;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(319, 189);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDocThongBao";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDDocThongBao_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		DB1DB4A0.ResumeLayout(false);
		ResumeLayout(false);
	}
}
