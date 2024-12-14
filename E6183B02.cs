using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class E6183B02 : Form
{
	public string string_0 = "";

	public string C5A7AC9D = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private ComboBox A5BAA73C;

	private Label label1;

	private Button CA80AD07;

	private Button btnAdd;

	private PictureBox B9960784;

	private Button button1;

	private BunifuDragControl B8994B8D;

	private BunifuDragControl bunifuDragControl_0;

	public E6183B02()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		string_0 = "";
		C5A7AC9D = "";
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void CA80AD07_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		string_0 = A5BAA73C.SelectedValue.ToString();
		C5A7AC9D = A5BAA73C.Text.ToString();
		Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		fAddFile form_ = new fAddFile();
		GClass8.smethod_33(form_);
		if (fAddFile.C13CD985)
		{
			B8ABC42D();
			A5BAA73C.SelectedIndex = A5BAA73C.Items.Count - 1;
		}
	}

	private void B8ABC42D()
	{
		DataTable dataTable = Class15.E888F681();
		if (dataTable.Rows.Count > 0)
		{
			A5BAA73C.DataSource = dataTable;
			A5BAA73C.ValueMember = "id";
			A5BAA73C.DisplayMember = "Ten";
		}
	}

	private void E6183B02_Load(object sender, EventArgs e)
	{
		B8ABC42D();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E6183B02));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		btnMinimize = new System.Windows.Forms.Button();
		B9960784 = new System.Windows.Forms.PictureBox();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		A5BAA73C = new System.Windows.Forms.ComboBox();
		label1 = new System.Windows.Forms.Label();
		CA80AD07 = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		button1 = new System.Windows.Forms.Button();
		B8994B8D = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B9960784).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(416, 38);
		bunifuCards1.TabIndex = 12;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(B9960784);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(416, 32);
		pnlHeader.TabIndex = 9;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(382, -1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		B9960784.Cursor = System.Windows.Forms.Cursors.Default;
		B9960784.Image = C50FB39E.Bitmap_5;
		B9960784.Location = new System.Drawing.Point(3, 1);
		B9960784.Name = "pictureBox1";
		B9960784.Size = new System.Drawing.Size(34, 27);
		B9960784.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B9960784.TabIndex = 79;
		B9960784.TabStop = false;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(416, 32);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Chọn thư mục";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		A5BAA73C.Cursor = System.Windows.Forms.Cursors.Hand;
		A5BAA73C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A5BAA73C.DropDownWidth = 350;
		A5BAA73C.FormattingEnabled = true;
		A5BAA73C.ItemHeight = 16;
		A5BAA73C.Items.AddRange(new object[10] { "Token", "Cookie", "Password", "Mail|pass", "PassMail", "2FA", "Birthday", "Useragent", "Proxy", "Notes" });
		A5BAA73C.Location = new System.Drawing.Point(111, 66);
		A5BAA73C.Name = "cbbThuMuc";
		A5BAA73C.Size = new System.Drawing.Size(190, 24);
		A5BAA73C.TabIndex = 13;
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(42, 69);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(63, 16);
		label1.TabIndex = 14;
		label1.Text = "Thư mục:";
		CA80AD07.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		CA80AD07.BackColor = System.Drawing.Color.Maroon;
		CA80AD07.Cursor = System.Windows.Forms.Cursors.Hand;
		CA80AD07.FlatAppearance.BorderSize = 0;
		CA80AD07.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		CA80AD07.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CA80AD07.ForeColor = System.Drawing.Color.White;
		CA80AD07.Location = new System.Drawing.Point(209, 108);
		CA80AD07.Name = "btnCancel";
		CA80AD07.Size = new System.Drawing.Size(92, 29);
		CA80AD07.TabIndex = 18;
		CA80AD07.Text = "Đóng";
		CA80AD07.UseVisualStyleBackColor = false;
		CA80AD07.Click += new System.EventHandler(CA80AD07_Click);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(111, 108);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 17;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.Location = new System.Drawing.Point(307, 65);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(58, 26);
		button1.TabIndex = 19;
		button1.Text = "Thêm";
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		B8994B8D.Fixed = true;
		B8994B8D.Horizontal = true;
		B8994B8D.TargetControl = pnlHeader;
		B8994B8D.Vertical = true;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(416, 150);
		base.Controls.Add(button1);
		base.Controls.Add(CA80AD07);
		base.Controls.Add(btnAdd);
		base.Controls.Add(label1);
		base.Controls.Add(A5BAA73C);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fChuyenThuMuc";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fUpdateData";
		base.Load += new System.EventHandler(E6183B02_Load);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)B9960784).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
