using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fChonKichBan2 : Form
{
	public string string_0 = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox D6AB4836;

	private ComboBox cbbKichBan;

	private Button btnQuanLyKichBan;

	private Label EE807230;

	private Panel D493CB8B;

	public fChonKichBan2()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Bạn có thực sự muốn chọn kịch bản [{0}] không?"), cbbKichBan.Text)) == DialogResult.Yes)
		{
			string_0 = cbbKichBan.SelectedValue.ToString();
			Close();
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnQuanLyKichBan_Click(object sender, EventArgs e)
	{
		string string_ = "";
		try
		{
			if (cbbKichBan.Items.Count > 0)
			{
				string_ = cbbKichBan.SelectedValue.ToString();
			}
		}
		catch
		{
		}
		GClass8.smethod_33(new fDanhSachKichBan_Old(string_));
		A3235F8A();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void A4B2881D(object sender, EventArgs e)
	{
	}

	private void method_1()
	{
		method_0(null, null);
		A4B2881D(null, null);
		E216C7A0(null, null);
		method_2(null, null);
		method_3(null, null);
		method_4(null, null);
		B316979D(null, null);
	}

	private void fChonKichBan2_Load(object sender, EventArgs e)
	{
		A3235F8A();
		method_1();
	}

	private void A3235F8A()
	{
		int num = -1;
		if (cbbKichBan.SelectedIndex != -1)
		{
			num = cbbKichBan.SelectedIndex;
		}
		DataTable dataSource = Class147.CD078893();
		cbbKichBan.DataSource = dataSource;
		cbbKichBan.ValueMember = "Id_KichBan";
		cbbKichBan.DisplayMember = "Ten";
		if (num != -1 && num != 0 && cbbKichBan.Items.Count >= num + 1)
		{
			cbbKichBan.SelectedIndex = num;
		}
		else if (cbbKichBan.Items.Count > 0)
		{
			cbbKichBan.SelectedIndex = 0;
		}
	}

	private void A9B47980(object sender, PaintEventArgs e)
	{
	}

	private void D6AB4836_Click(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private void E216C7A0(object sender, EventArgs e)
	{
	}

	private void method_3(object sender, EventArgs e)
	{
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void B316979D(object sender, EventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChonKichBan2));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		D6AB4836 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		EE807230 = new System.Windows.Forms.Label();
		btnQuanLyKichBan = new System.Windows.Forms.Button();
		cbbKichBan = new System.Windows.Forms.ComboBox();
		D493CB8B = new System.Windows.Forms.Panel();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)D6AB4836).BeginInit();
		D493CB8B.SuspendLayout();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.FromArgb(24, 119, 242);
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(2, 1);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(434, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(D6AB4836);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(434, 32);
		pnlHeader.TabIndex = 9;
		D6AB4836.Cursor = System.Windows.Forms.Cursors.Default;
		D6AB4836.Image = C50FB39E.Bitmap_5;
		D6AB4836.Location = new System.Drawing.Point(3, 1);
		D6AB4836.Name = "pictureBox1";
		D6AB4836.Size = new System.Drawing.Size(34, 27);
		D6AB4836.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		D6AB4836.TabIndex = 78;
		D6AB4836.TabStop = false;
		D6AB4836.Click += new System.EventHandler(D6AB4836_Click);
		btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(400, -2);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(434, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Chọn kịch bản";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(222, 96);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
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
		btnAdd.Location = new System.Drawing.Point(124, 96);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		EE807230.AutoSize = true;
		EE807230.Location = new System.Drawing.Point(25, 59);
		EE807230.Name = "label1";
		EE807230.Size = new System.Drawing.Size(92, 16);
		EE807230.TabIndex = 0;
		EE807230.Text = "Chọn kịch bản:";
		btnQuanLyKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		btnQuanLyKichBan.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
		btnQuanLyKichBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnQuanLyKichBan.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnQuanLyKichBan.Location = new System.Drawing.Point(294, 56);
		btnQuanLyKichBan.Name = "btnQuanLyKichBan";
		btnQuanLyKichBan.Size = new System.Drawing.Size(112, 24);
		btnQuanLyKichBan.TabIndex = 1;
		btnQuanLyKichBan.Text = "Quản lý kịch bản";
		btnQuanLyKichBan.Click += new System.EventHandler(btnQuanLyKichBan_Click);
		cbbKichBan.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbKichBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbKichBan.DropDownWidth = 300;
		cbbKichBan.FormattingEnabled = true;
		cbbKichBan.Location = new System.Drawing.Point(124, 56);
		cbbKichBan.Name = "cbbKichBan";
		cbbKichBan.Size = new System.Drawing.Size(164, 24);
		cbbKichBan.TabIndex = 1;
		D493CB8B.BackColor = System.Drawing.Color.White;
		D493CB8B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D493CB8B.Controls.Add(btnAdd);
		D493CB8B.Controls.Add(btnCancel);
		D493CB8B.Controls.Add(EE807230);
		D493CB8B.Controls.Add(cbbKichBan);
		D493CB8B.Controls.Add(btnQuanLyKichBan);
		D493CB8B.Dock = System.Windows.Forms.DockStyle.Fill;
		D493CB8B.Location = new System.Drawing.Point(0, 0);
		D493CB8B.Name = "panel1";
		D493CB8B.Size = new System.Drawing.Size(436, 138);
		D493CB8B.TabIndex = 8;
		D493CB8B.Paint += new System.Windows.Forms.PaintEventHandler(A9B47980);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(436, 138);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(D493CB8B);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChonKichBan2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(fChonKichBan2_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)D6AB4836).EndInit();
		D493CB8B.ResumeLayout(false);
		D493CB8B.PerformLayout();
		ResumeLayout(false);
	}
}
