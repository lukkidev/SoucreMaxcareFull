using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fHDMoiBanBeVaoNhom : Form
{
	private GClass11 gclass11_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl E615EE3D;

	private Panel panel1;

	private NumericUpDown C62A03AB;

	private NumericUpDown nudSoLuongFrom;

	private TextBox txtTenHanhDong;

	private Label label3;

	private Label B19BDE17;

	private Label D2AFCD14;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel E0838A23;

	private Label lblUid;

	private RichTextBox txtUid;

	private ToolTip toolTip_0;

	private Label label5;

	private NumericUpDown nudDelayTo;

	private NumericUpDown B40D5C1B;

	private Label BC1F3205;

	private Label label6;

	private ComboBox cbbTuyChonMoi;

	public fHDMoiBanBeVaoNhom(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		bool_0 = false;
		string_0 = string_3;
		string_2 = string_4;
		int_0 = int_1;
		string text = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDMoiBanBeVaoNhom");
			string_1 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
			text = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void ADAABB86(object sender, EventArgs e)
	{
		method_0();
		try
		{
			nudSoLuongFrom.Value = gclass11_0.method_2("nudSoLuongFrom", 1);
			C62A03AB.Value = gclass11_0.method_2("nudSoLuongTo", 1);
			B40D5C1B.Value = gclass11_0.method_2("nudDelayFrom", 3);
			nudDelayTo.Value = gclass11_0.method_2("nudDelayTo", 5);
			cbbTuyChonMoi.SelectedIndex = gclass11_0.method_2("typeInvite");
			txtUid.Text = gclass11_0.C0288288("txtUid");
		}
		catch
		{
		}
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Mời ngẫu nhiên");
		dictionary.Add("1", "Gợi ý của Facebook");
		GClass8.smethod_23(cbbTuyChonMoi, dictionary);
	}

	private void FC8CB31D(object sender, EventArgs e)
	{
		Close();
	}

	private void E7354E12(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = txtUid.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách uid nhóm!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", nudSoLuongFrom.Value);
		gClass.method_4("nudSoLuongTo", C62A03AB.Value);
		gClass.method_4("nudDelayFrom", B40D5C1B.Value);
		gClass.method_4("nudDelayTo", nudDelayTo.Value);
		gClass.method_4("txtUid", txtUid.Text.Trim());
		gClass.method_4("typeInvite", cbbTuyChonMoi.SelectedIndex);
		string text2 = gClass.method_7();
		if (int_0 == 0)
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

	private void FEA02D33(object sender, EventArgs e)
	{
		Close();
	}

	private void B89C1815(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void A19D47AA(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUid, lblUid);
	}

	protected override void Dispose(bool B3BE6425)
	{
		if (B3BE6425 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B3BE6425);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDMoiBanBeVaoNhom));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		E0838A23 = new Bunifu.Framework.UI.BunifuCustomLabel();
		E615EE3D = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		cbbTuyChonMoi = new System.Windows.Forms.ComboBox();
		txtUid = new System.Windows.Forms.RichTextBox();
		label5 = new System.Windows.Forms.Label();
		lblUid = new System.Windows.Forms.Label();
		nudDelayTo = new System.Windows.Forms.NumericUpDown();
		C62A03AB = new System.Windows.Forms.NumericUpDown();
		B40D5C1B = new System.Windows.Forms.NumericUpDown();
		nudSoLuongFrom = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		BC1F3205 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		B19BDE17 = new System.Windows.Forms.Label();
		D2AFCD14 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)C62A03AB).BeginInit();
		((System.ComponentModel.ISupportInitialize)B40D5C1B).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = E0838A23;
		bunifuDragControl_0.Vertical = true;
		E0838A23.BackColor = System.Drawing.Color.Transparent;
		E0838A23.Cursor = System.Windows.Forms.Cursors.SizeAll;
		E0838A23.Dock = System.Windows.Forms.DockStyle.Fill;
		E0838A23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E0838A23.ForeColor = System.Drawing.Color.Black;
		E0838A23.Location = new System.Drawing.Point(0, 0);
		E0838A23.Name = "bunifuCustomLabel1";
		E0838A23.Size = new System.Drawing.Size(314, 31);
		E0838A23.TabIndex = 12;
		E0838A23.Text = "Cấu hình Mời bạn bè vào nhóm";
		E0838A23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		E615EE3D.Fixed = true;
		E615EE3D.Horizontal = true;
		E615EE3D.TargetControl = pnlHeader;
		E615EE3D.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(E0838A23);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(314, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(283, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(FC8CB31D);
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
		panel1.Controls.Add(cbbTuyChonMoi);
		panel1.Controls.Add(txtUid);
		panel1.Controls.Add(label5);
		panel1.Controls.Add(lblUid);
		panel1.Controls.Add(nudDelayTo);
		panel1.Controls.Add(C62A03AB);
		panel1.Controls.Add(B40D5C1B);
		panel1.Controls.Add(nudSoLuongFrom);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(BC1F3205);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(B19BDE17);
		panel1.Controls.Add(D2AFCD14);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(317, 371);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(B89C1815);
		cbbTuyChonMoi.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTuyChonMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTuyChonMoi.FormattingEnabled = true;
		cbbTuyChonMoi.Location = new System.Drawing.Point(132, 135);
		cbbTuyChonMoi.Name = "cbbTuyChonMoi";
		cbbTuyChonMoi.Size = new System.Drawing.Size(153, 24);
		cbbTuyChonMoi.TabIndex = 116;
		txtUid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUid.Location = new System.Drawing.Point(31, 184);
		txtUid.Name = "txtUid";
		txtUid.Size = new System.Drawing.Size(254, 136);
		txtUid.TabIndex = 114;
		txtUid.Text = "";
		txtUid.WordWrap = false;
		txtUid.TextChanged += new System.EventHandler(A19D47AA);
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 138);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(89, 16);
		label5.TabIndex = 0;
		label5.Text = "Tùy chọn mời:";
		lblUid.AutoSize = true;
		lblUid.Location = new System.Drawing.Point(27, 164);
		lblUid.Name = "lblUid";
		lblUid.Size = new System.Drawing.Size(143, 16);
		lblUid.TabIndex = 0;
		lblUid.Text = "Danh sa\u0301ch Id nhóm (0):";
		nudDelayTo.Location = new System.Drawing.Point(229, 107);
		nudDelayTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayTo.Name = "nudDelayTo";
		nudDelayTo.Size = new System.Drawing.Size(56, 23);
		nudDelayTo.TabIndex = 2;
		C62A03AB.Location = new System.Drawing.Point(229, 78);
		C62A03AB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C62A03AB.Name = "nudSoLuongTo";
		C62A03AB.Size = new System.Drawing.Size(56, 23);
		C62A03AB.TabIndex = 2;
		B40D5C1B.Location = new System.Drawing.Point(132, 107);
		B40D5C1B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		B40D5C1B.Name = "nudDelayFrom";
		B40D5C1B.Size = new System.Drawing.Size(56, 23);
		B40D5C1B.TabIndex = 1;
		nudSoLuongFrom.Location = new System.Drawing.Point(132, 78);
		nudSoLuongFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongFrom.Name = "nudSoLuongFrom";
		nudSoLuongFrom.Size = new System.Drawing.Size(56, 23);
		nudSoLuongFrom.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(132, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(153, 23);
		txtTenHanhDong.TabIndex = 0;
		BC1F3205.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BC1F3205.Location = new System.Drawing.Point(194, 109);
		BC1F3205.Name = "label9";
		BC1F3205.Size = new System.Drawing.Size(29, 16);
		BC1F3205.TabIndex = 37;
		BC1F3205.Text = ">";
		BC1F3205.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(194, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(27, 109);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(87, 16);
		label6.TabIndex = 32;
		label6.Text = "Gia\u0303n ca\u0301ch (s):";
		B19BDE17.AutoSize = true;
		B19BDE17.Location = new System.Drawing.Point(27, 80);
		B19BDE17.Name = "label2";
		B19BDE17.Size = new System.Drawing.Size(100, 16);
		B19BDE17.TabIndex = 32;
		B19BDE17.Text = "Sô\u0301 lươ\u0323ng/nho\u0301m:";
		D2AFCD14.AutoSize = true;
		D2AFCD14.Location = new System.Drawing.Point(27, 52);
		D2AFCD14.Name = "label1";
		D2AFCD14.Size = new System.Drawing.Size(98, 16);
		D2AFCD14.TabIndex = 31;
		D2AFCD14.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(168, 331);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(FEA02D33);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(57, 331);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 6;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(E7354E12);
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
		bunifuCards1.Size = new System.Drawing.Size(314, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(317, 371);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDMoiBanBeVaoNhom";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(ADAABB86);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudDelayTo).EndInit();
		((System.ComponentModel.ISupportInitialize)C62A03AB).EndInit();
		((System.ComponentModel.ISupportInitialize)B40D5C1B).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongFrom).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
