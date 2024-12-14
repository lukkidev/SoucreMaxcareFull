using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDChocBanBe : Form
{
	private JObject AB29E48A;

	private string BE970718;

	private string string_0;

	private string C92BCEAF;

	private int int_0;

	public static bool DD8091A7;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl A1B43432;

	private Panel F402F73F;

	private NumericUpDown F82C7D13;

	private NumericUpDown nudSoLuongTo;

	private NumericUpDown D89F8F92;

	private NumericUpDown C613B730;

	private TextBox txtTenHanhDong;

	private Label label7;

	private Label label3;

	private Label label5;

	private Label label2;

	private Label label1;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private Button button1;

	private PictureBox C59E320B;

	private BunifuCustomLabel bunifuCustomLabel1;

	public fHDChocBanBe(string E13A8BA7, int int_1 = 0, string A3BA37B5 = "")
	{
		InitializeComponent();
		DD8091A7 = false;
		BE970718 = E13A8BA7;
		C92BCEAF = A3BA37B5;
		int_0 = int_1;
		string json = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", "HDChocBanBe");
			json = dataTable2.Rows[0]["CauHinh"].ToString();
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(A3BA37B5);
			json = dataTable.Rows[0]["CauHinh"].ToString();
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		AB29E48A = JObject.Parse(json);
		F7AB102E.D6B70A35(this);
	}

	private void fHDChocBanBe_Load(object sender, EventArgs e)
	{
		try
		{
			C613B730.Value = Convert.ToInt32(AB29E48A["nudSoLuongFrom"]);
			nudSoLuongTo.Value = Convert.ToInt32(AB29E48A["nudSoLuongTo"]);
			D89F8F92.Value = Convert.ToInt32(AB29E48A["nudDelayFrom"]);
			F82C7D13.Value = Convert.ToInt32(AB29E48A["nudDelayTo"]);
		}
		catch
		{
		}
	}

	private void F2143627(object sender, EventArgs e)
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
		gClass.method_4("nudSoLuongFrom", C613B730.Value);
		gClass.method_4("nudSoLuongTo", nudSoLuongTo.Value);
		gClass.method_4("nudDelayFrom", D89F8F92.Value);
		gClass.method_4("nudDelayTo", F82C7D13.Value);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(BE970718, text, string_0, text2))
				{
					DD8091A7 = true;
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
			if (Class147.smethod_13(C92BCEAF, text, text2))
			{
				DD8091A7 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void BEBF6B35(object sender, EventArgs e)
	{
		Close();
	}

	private void F402F73F_Paint(object sender, PaintEventArgs e)
	{
		if (F402F73F.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, F402F73F.ClientSize.Width - num, F402F73F.ClientSize.Height - num));
		}
	}

	protected override void Dispose(bool D98B2829)
	{
		if (D98B2829 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(D98B2829);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDChocBanBe));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		A1B43432 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pnlHeader = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		C59E320B = new System.Windows.Forms.PictureBox();
		F402F73F = new System.Windows.Forms.Panel();
		F82C7D13 = new System.Windows.Forms.NumericUpDown();
		nudSoLuongTo = new System.Windows.Forms.NumericUpDown();
		D89F8F92 = new System.Windows.Forms.NumericUpDown();
		C613B730 = new System.Windows.Forms.NumericUpDown();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label7 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)C59E320B).BeginInit();
		F402F73F.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)F82C7D13).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).BeginInit();
		((System.ComponentModel.ISupportInitialize)D89F8F92).BeginInit();
		((System.ComponentModel.ISupportInitialize)C613B730).BeginInit();
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
		bunifuCustomLabel1.Text = "Cấu hình Cho\u0323c ba\u0323n be\u0300";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A1B43432.Fixed = true;
		A1B43432.Horizontal = true;
		A1B43432.TargetControl = pnlHeader;
		A1B43432.Vertical = true;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(button1);
		pnlHeader.Controls.Add(C59E320B);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(318, 31);
		pnlHeader.TabIndex = 9;
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
		button1.Click += new System.EventHandler(F2143627);
		C59E320B.Cursor = System.Windows.Forms.Cursors.Default;
		C59E320B.Image = C50FB39E.Bitmap_5;
		C59E320B.Location = new System.Drawing.Point(3, 2);
		C59E320B.Name = "pictureBox1";
		C59E320B.Size = new System.Drawing.Size(34, 27);
		C59E320B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		C59E320B.TabIndex = 76;
		C59E320B.TabStop = false;
		F402F73F.BackColor = System.Drawing.Color.White;
		F402F73F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F402F73F.Controls.Add(F82C7D13);
		F402F73F.Controls.Add(nudSoLuongTo);
		F402F73F.Controls.Add(D89F8F92);
		F402F73F.Controls.Add(C613B730);
		F402F73F.Controls.Add(txtTenHanhDong);
		F402F73F.Controls.Add(label7);
		F402F73F.Controls.Add(label3);
		F402F73F.Controls.Add(label5);
		F402F73F.Controls.Add(label2);
		F402F73F.Controls.Add(label1);
		F402F73F.Controls.Add(btnCancel);
		F402F73F.Controls.Add(btnAdd);
		F402F73F.Controls.Add(bunifuCards1);
		F402F73F.Cursor = System.Windows.Forms.Cursors.Arrow;
		F402F73F.Dock = System.Windows.Forms.DockStyle.Fill;
		F402F73F.Location = new System.Drawing.Point(0, 0);
		F402F73F.Name = "panel1";
		F402F73F.Size = new System.Drawing.Size(321, 189);
		F402F73F.TabIndex = 0;
		F402F73F.Paint += new System.Windows.Forms.PaintEventHandler(F402F73F_Paint);
		F82C7D13.Location = new System.Drawing.Point(229, 107);
		F82C7D13.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		F82C7D13.Name = "nudDelayTo";
		F82C7D13.Size = new System.Drawing.Size(56, 23);
		F82C7D13.TabIndex = 4;
		nudSoLuongTo.Location = new System.Drawing.Point(229, 78);
		nudSoLuongTo.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudSoLuongTo.Name = "nudSoLuongTo";
		nudSoLuongTo.Size = new System.Drawing.Size(56, 23);
		nudSoLuongTo.TabIndex = 2;
		D89F8F92.Location = new System.Drawing.Point(125, 107);
		D89F8F92.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D89F8F92.Name = "nudDelayFrom";
		D89F8F92.Size = new System.Drawing.Size(56, 23);
		D89F8F92.TabIndex = 3;
		C613B730.Location = new System.Drawing.Point(125, 78);
		C613B730.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		C613B730.Name = "nudSoLuongFrom";
		C613B730.Size = new System.Drawing.Size(56, 23);
		C613B730.TabIndex = 1;
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(160, 23);
		txtTenHanhDong.TabIndex = 0;
		label7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label7.Location = new System.Drawing.Point(191, 109);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(29, 16);
		label7.TabIndex = 38;
		label7.Text = ">";
		label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(191, 80);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(29, 16);
		label3.TabIndex = 37;
		label3.Text = ">";
		label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(27, 109);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(87, 16);
		label5.TabIndex = 34;
		label5.Text = "Gia\u0303n ca\u0301ch (s):";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 80);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(88, 16);
		label2.TabIndex = 32;
		label2.Text = "Sô\u0301 lươ\u0323ng bạn:";
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
		btnCancel.Location = new System.Drawing.Point(177, 147);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(BEBF6B35);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(70, 147);
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
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(318, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(321, 189);
		base.Controls.Add(F402F73F);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDChocBanBe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fHDChocBanBe_Load);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)C59E320B).EndInit();
		F402F73F.ResumeLayout(false);
		F402F73F.PerformLayout();
		((System.ComponentModel.ISupportInitialize)F82C7D13).EndInit();
		((System.ComponentModel.ISupportInitialize)nudSoLuongTo).EndInit();
		((System.ComponentModel.ISupportInitialize)D89F8F92).EndInit();
		((System.ComponentModel.ISupportInitialize)C613B730).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
