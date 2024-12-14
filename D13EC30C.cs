using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class D13EC30C : Form
{
	private JObject F01FA03F;

	private string D09504A1;

	private string string_0;

	private string C3018D22;

	private int int_0;

	public static bool EE36AF13;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private NumericUpDown A905CFA0;

	private NumericUpDown C69BA0AB;

	private TextBox txtTenHanhDong;

	private Label BB03A311;

	private Label C91AB801;

	private Label F292F406;

	private Label label1;

	private Button btnCancel;

	private Button E1005191;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Label E53F1190;

	private Label lblStatus;

	private NumericUpDown C525FCAE;

	private NumericUpDown nudDelayFrom;

	private Label D0351FB0;

	private Label label6;

	private Label A5313212;

	private RichTextBox E79C810A;

	private CheckBox ckbTuDongXoaUid;

	private ToolTip toolTip_0;

	private Panel plTuongTacComment;

	private TextBox F00DA0BD;

	private Label lblStatusComment;

	private Label label17;

	private RadioButton rbNo;

	private RadioButton D196011F;

	private Label label9;

	public D13EC30C(string E33AE812, int int_1 = 0, string string_1 = "")
	{
		InitializeComponent();
		EE36AF13 = false;
		D09504A1 = E33AE812;
		C3018D22 = string_1;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDKetBanTepUid");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_1);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			E1005191.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		F01FA03F = JObject.Parse(json);
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(F292F406);
		F7AB102E.smethod_1(BB03A311);
		F7AB102E.smethod_1(C91AB801);
		F7AB102E.smethod_1(A5313212);
		F7AB102E.smethod_1(D0351FB0);
		F7AB102E.smethod_1(label6);
		F7AB102E.smethod_1(lblStatus);
		F7AB102E.smethod_1(E53F1190);
		F7AB102E.smethod_1(ckbTuDongXoaUid);
		F7AB102E.smethod_1(lblStatusComment);
		F7AB102E.smethod_1(E1005191);
		F7AB102E.smethod_1(btnCancel);
	}

	private void D13EC30C_Load(object sender, EventArgs e)
	{
		try
		{
			C69BA0AB.Value = Convert.ToInt32(F01FA03F["nudSoLuongFrom"]);
			A905CFA0.Value = Convert.ToInt32(F01FA03F["nudSoLuongTo"]);
			nudDelayFrom.Value = Convert.ToInt32(F01FA03F["nudDelayFrom"]);
			C525FCAE.Value = Convert.ToInt32(F01FA03F["nudDelayTo"]);
			if (Convert.ToInt32(F01FA03F["typeReview"]) == 0)
			{
				rbNo.Checked = true;
			}
			else
			{
				D196011F.Checked = true;
			}
			E79C810A.Text = F01FA03F["txtUid"]!.ToString();
			ckbTuDongXoaUid.Checked = Convert.ToBoolean(F01FA03F["ckbTuDongXoaUid"]);
			F00DA0BD.Text = F01FA03F["txtComment"]!.ToString();
		}
		catch
		{
		}
		AEA968BB();
	}

	private void AEA968BB()
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E1005191_Click(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		List<string> e03C713E = E79C810A.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p danh sách Id page cần đánh giá!", 3);
			return;
		}
		e03C713E = F00DA0BD.Lines.ToList();
		e03C713E = GClass8.smethod_36(e03C713E);
		if (e03C713E.Count == 0)
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p nội dung đánh giá!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("nudSoLuongFrom", C69BA0AB.Value);
		gClass.method_4("nudSoLuongTo", A905CFA0.Value);
		gClass.method_4("nudDelayFrom", nudDelayFrom.Value);
		gClass.method_4("nudDelayTo", C525FCAE.Value);
		int num = 0;
		if (D196011F.Checked)
		{
			num = 1;
		}
		gClass.method_4("type", num);
		gClass.method_4("txtUid", E79C810A.Text.Trim());
		gClass.method_4("txtComment", F00DA0BD.Text.Trim());
		gClass.method_4("ckbTuDongXoaUid", ckbTuDongXoaUid.Checked);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(D09504A1, text, string_0, text2))
				{
					EE36AF13 = true;
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
			if (Class147.smethod_13(C3018D22, text, text2))
			{
				EE36AF13 = true;
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

	private void D88DE9B6(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void AEB71D82(object sender, EventArgs e)
	{
	}

	private void FCA21227(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = E79C810A.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblStatus.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch Id cần đánh giá ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void E70AF880(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = F00DA0BD.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblStatusComment.Text = string.Format(F7AB102E.smethod_0("Nội dung đánh giá ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	private void method_1(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.smethod_33(new E3962B82());
	}

	protected override void Dispose(bool A73B233F)
	{
		if (A73B233F && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A73B233F);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D13EC30C));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		rbNo = new System.Windows.Forms.RadioButton();
		D196011F = new System.Windows.Forms.RadioButton();
		label9 = new System.Windows.Forms.Label();
		plTuongTacComment = new System.Windows.Forms.Panel();
		label17 = new System.Windows.Forms.Label();
		F00DA0BD = new System.Windows.Forms.TextBox();
		lblStatusComment = new System.Windows.Forms.Label();
		E79C810A = new System.Windows.Forms.RichTextBox();
		ckbTuDongXoaUid = new System.Windows.Forms.CheckBox();
		C525FCAE = new System.Windows.Forms.NumericUpDown();
		E53F1190 = new System.Windows.Forms.Label();
		lblStatus = new System.Windows.Forms.Label();
		nudDelayFrom = new System.Windows.Forms.NumericUpDown();
		D0351FB0 = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		A5313212 = new System.Windows.Forms.Label();
		A905CFA0 = new System.Windows.Forms.NumericUpDown();
		C69BA0AB = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		BB03A311 = new System.Windows.Forms.Label();
		C91AB801 = new System.Windows.Forms.Label();
		F292F406 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		E1005191 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		plTuongTacComment.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C525FCAE).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).BeginInit();
		((System.ComponentModel.ISupportInitialize)A905CFA0).BeginInit();
		((System.ComponentModel.ISupportInitialize)C69BA0AB).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(687, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đánh giá page";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = pnlHeader;
		bunifuDragControl_1.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(687, 31);
		pnlHeader.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(656, 1);
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
		panel1.Controls.Add(rbNo);
		panel1.Controls.Add(D196011F);
		panel1.Controls.Add(label9);
		panel1.Controls.Add(plTuongTacComment);
		panel1.Controls.Add(E79C810A);
		panel1.Controls.Add(ckbTuDongXoaUid);
		panel1.Controls.Add(C525FCAE);
		panel1.Controls.Add(E53F1190);
		panel1.Controls.Add(lblStatus);
		panel1.Controls.Add(nudDelayFrom);
		panel1.Controls.Add(D0351FB0);
		panel1.Controls.Add(label6);
		panel1.Controls.Add(A5313212);
		panel1.Controls.Add(A905CFA0);
		panel1.Controls.Add(C69BA0AB);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(BB03A311);
		panel1.Controls.Add(C91AB801);
		panel1.Controls.Add(F292F406);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(E1005191);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(690, 435);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(D88DE9B6);
		rbNo.AutoSize = true;
		rbNo.Location = new System.Drawing.Point(222, 140);
		rbNo.Name = "rbNo";
		rbNo.Size = new System.Drawing.Size(60, 20);
		rbNo.TabIndex = 116;
		rbNo.TabStop = true;
		rbNo.Text = "Không";
		rbNo.UseVisualStyleBackColor = true;
		D196011F.AutoSize = true;
		D196011F.Location = new System.Drawing.Point(125, 140);
		D196011F.Name = "rbYes";
		D196011F.Size = new System.Drawing.Size(40, 20);
		D196011F.TabIndex = 116;
		D196011F.TabStop = true;
		D196011F.Text = "Có";
		D196011F.UseVisualStyleBackColor = true;
		label9.AutoSize = true;
		label9.Location = new System.Drawing.Point(24, 142);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(56, 16);
		label9.TabIndex = 115;
		label9.Text = "Đề xuất:";
		plTuongTacComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plTuongTacComment.Controls.Add(label17);
		plTuongTacComment.Controls.Add(F00DA0BD);
		plTuongTacComment.Controls.Add(lblStatusComment);
		plTuongTacComment.Location = new System.Drawing.Point(345, 49);
		plTuongTacComment.Name = "plTuongTacComment";
		plTuongTacComment.Size = new System.Drawing.Size(332, 297);
		plTuongTacComment.TabIndex = 93;
		label17.AutoSize = true;
		label17.Location = new System.Drawing.Point(196, 277);
		label17.Name = "label17";
		label17.Size = new System.Drawing.Size(131, 16);
		label17.TabIndex = 188;
		label17.Text = "Spin content: {a|b|c}";
		F00DA0BD.Location = new System.Drawing.Point(7, 27);
		F00DA0BD.Multiline = true;
		F00DA0BD.Name = "txtComment";
		F00DA0BD.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		F00DA0BD.Size = new System.Drawing.Size(320, 246);
		F00DA0BD.TabIndex = 1;
		F00DA0BD.WordWrap = false;
		F00DA0BD.TextChanged += new System.EventHandler(E70AF880);
		lblStatusComment.AutoSize = true;
		lblStatusComment.Location = new System.Drawing.Point(3, 5);
		lblStatusComment.Name = "lblStatusComment";
		lblStatusComment.Size = new System.Drawing.Size(136, 16);
		lblStatusComment.TabIndex = 0;
		lblStatusComment.Text = "Nội dung đánh giá (0):";
		E79C810A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		E79C810A.Location = new System.Drawing.Point(24, 194);
		E79C810A.Name = "txtUid";
		E79C810A.Size = new System.Drawing.Size(295, 141);
		E79C810A.TabIndex = 114;
		E79C810A.Text = "";
		E79C810A.WordWrap = false;
		E79C810A.TextChanged += new System.EventHandler(FCA21227);
		ckbTuDongXoaUid.AutoSize = true;
		ckbTuDongXoaUid.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbTuDongXoaUid.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		ckbTuDongXoaUid.Location = new System.Drawing.Point(24, 358);
		ckbTuDongXoaUid.Name = "ckbTuDongXoaUid";
		ckbTuDongXoaUid.Size = new System.Drawing.Size(184, 20);
		ckbTuDongXoaUid.TabIndex = 113;
		ckbTuDongXoaUid.Text = "Tư\u0323 đô\u0323ng xo\u0301a Id đa\u0303 đánh giá";
		ckbTuDongXoaUid.UseVisualStyleBackColor = true;
		C525FCAE.Location = new System.Drawing.Point(222, 111);
		C525FCAE.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C525FCAE.Name = "nudDelayTo";
		C525FCAE.Size = new System.Drawing.Size(56, 23);
		C525FCAE.TabIndex = 4;
		E53F1190.AutoSize = true;
		E53F1190.Location = new System.Drawing.Point(220, 338);
		E53F1190.Name = "label8";
		E53F1190.Size = new System.Drawing.Size(95, 16);
		E53F1190.TabIndex = 0;
		E53F1190.Text = "(Mỗi Id 1 dòng)";
		lblStatus.AutoSize = true;
		lblStatus.Location = new System.Drawing.Point(20, 172);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(184, 16);
		lblStatus.TabIndex = 0;
		lblStatus.Text = "Danh sa\u0301ch Id cần đánh giá (0):";
		nudDelayFrom.Location = new System.Drawing.Point(125, 111);
		nudDelayFrom.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudDelayFrom.Name = "nudDelayFrom";
		nudDelayFrom.Size = new System.Drawing.Size(56, 23);
		nudDelayFrom.TabIndex = 3;
		D0351FB0.Location = new System.Drawing.Point(187, 113);
		D0351FB0.Name = "label7";
		D0351FB0.Size = new System.Drawing.Size(29, 16);
		D0351FB0.TabIndex = 46;
		D0351FB0.Text = "đê\u0301n";
		D0351FB0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label6.AutoSize = true;
		label6.Location = new System.Drawing.Point(280, 113);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(30, 16);
		label6.TabIndex = 45;
		label6.Text = "giây";
		A5313212.AutoSize = true;
		A5313212.Location = new System.Drawing.Point(20, 113);
		A5313212.Name = "label5";
		A5313212.Size = new System.Drawing.Size(89, 16);
		A5313212.TabIndex = 44;
		A5313212.Text = "Thơ\u0300i gian chơ\u0300:";
		A905CFA0.Location = new System.Drawing.Point(222, 80);
		A905CFA0.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		A905CFA0.Name = "nudSoLuongTo";
		A905CFA0.Size = new System.Drawing.Size(56, 23);
		A905CFA0.TabIndex = 2;
		C69BA0AB.Location = new System.Drawing.Point(125, 80);
		C69BA0AB.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C69BA0AB.Name = "nudSoLuongFrom";
		C69BA0AB.Size = new System.Drawing.Size(56, 23);
		C69BA0AB.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(194, 23);
		txtTenHanhDong.TabIndex = 0;
		BB03A311.Location = new System.Drawing.Point(187, 82);
		BB03A311.Name = "label3";
		BB03A311.Size = new System.Drawing.Size(29, 16);
		BB03A311.TabIndex = 37;
		BB03A311.Text = "đê\u0301n";
		BB03A311.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		C91AB801.AutoSize = true;
		C91AB801.Location = new System.Drawing.Point(280, 82);
		C91AB801.Name = "label4";
		C91AB801.Size = new System.Drawing.Size(35, 16);
		C91AB801.TabIndex = 35;
		C91AB801.Text = "page";
		F292F406.AutoSize = true;
		F292F406.Location = new System.Drawing.Point(20, 82);
		F292F406.Name = "label2";
		F292F406.Size = new System.Drawing.Size(95, 16);
		F292F406.TabIndex = 32;
		F292F406.Text = "Sô\u0301 lươ\u0323ng page:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(20, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(349, 393);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		E1005191.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E1005191.Cursor = System.Windows.Forms.Cursors.Hand;
		E1005191.FlatAppearance.BorderSize = 0;
		E1005191.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E1005191.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E1005191.ForeColor = System.Drawing.Color.White;
		E1005191.Location = new System.Drawing.Point(242, 393);
		E1005191.Name = "btnAdd";
		E1005191.Size = new System.Drawing.Size(92, 29);
		E1005191.TabIndex = 6;
		E1005191.Text = "Thêm";
		E1005191.UseVisualStyleBackColor = false;
		E1005191.Click += new System.EventHandler(E1005191_Click);
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
		bunifuCards1.Size = new System.Drawing.Size(687, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(690, 435);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDReviewPage";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(D13EC30C_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		plTuongTacComment.ResumeLayout(false);
		plTuongTacComment.PerformLayout();
		((System.ComponentModel.ISupportInitialize)C525FCAE).EndInit();
		((System.ComponentModel.ISupportInitialize)nudDelayFrom).EndInit();
		((System.ComponentModel.ISupportInitialize)A905CFA0).EndInit();
		((System.ComponentModel.ISupportInitialize)C69BA0AB).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
