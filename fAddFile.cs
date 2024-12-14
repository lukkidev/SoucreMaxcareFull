using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fAddFile : Form
{
	public static bool C13CD985;

	private IContainer B88CE738 = null;

	private BunifuCards E49CEF16;

	private Panel D53C721B;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button FAB238A9;

	private Button BA8FC82B;

	private Button btnAdd;

	private Label label1;

	private BunifuDragControl bunifuDragControl_0;

	private TextBox txbNameFile;

	private PictureBox pictureBox1;

	public fAddFile()
	{
		InitializeComponent();
		C13CD985 = false;
		F7AB102E.D6B70A35(this);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(BA8FC82B);
	}

	private void B6933C10(object sender, EventArgs e)
	{
		Close();
	}

	private void D1093295(object sender, EventArgs e)
	{
		string text = txbNameFile.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lòng điền tên thư mục!");
			txbNameFile.Focus();
		}
		else if (Class15.smethod_0(text))
		{
			GClass29.smethod_0("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!");
			txbNameFile.Focus();
		}
		else if (Class15.DE31880F(text))
		{
			C13CD985 = true;
			if (GClass29.smethod_1("Thêm thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass29.smethod_0("Thêm thư mục lỗi!");
		}
	}

	private void E3933500(object sender, EventArgs e)
	{
		Close();
	}

	private void txbNameFile_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			D1093295(null, null);
		}
	}

	protected override void Dispose(bool E030C69F)
	{
		if (E030C69F && B88CE738 != null)
		{
			B88CE738.Dispose();
		}
		base.Dispose(E030C69F);
	}

	private void InitializeComponent()
	{
		B88CE738 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddFile));
		E49CEF16 = new Bunifu.Framework.UI.BunifuCards();
		D53C721B = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		FAB238A9 = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		BA8FC82B = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(B88CE738);
		txbNameFile = new System.Windows.Forms.TextBox();
		E49CEF16.SuspendLayout();
		D53C721B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		E49CEF16.BackColor = System.Drawing.Color.White;
		E49CEF16.BorderRadius = 0;
		E49CEF16.BottomSahddow = true;
		E49CEF16.color = System.Drawing.Color.SaddleBrown;
		E49CEF16.Controls.Add(D53C721B);
		E49CEF16.Dock = System.Windows.Forms.DockStyle.Top;
		E49CEF16.LeftSahddow = false;
		E49CEF16.Location = new System.Drawing.Point(0, 0);
		E49CEF16.Name = "bunifuCards1";
		E49CEF16.RightSahddow = true;
		E49CEF16.ShadowDepth = 20;
		E49CEF16.Size = new System.Drawing.Size(396, 38);
		E49CEF16.TabIndex = 0;
		D53C721B.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		D53C721B.BackColor = System.Drawing.Color.White;
		D53C721B.Controls.Add(pictureBox1);
		D53C721B.Controls.Add(FAB238A9);
		D53C721B.Controls.Add(bunifuCustomLabel1);
		D53C721B.Location = new System.Drawing.Point(0, 5);
		D53C721B.Name = "pnlHeader";
		D53C721B.Size = new System.Drawing.Size(396, 32);
		D53C721B.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(4, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 77;
		pictureBox1.TabStop = false;
		FAB238A9.Cursor = System.Windows.Forms.Cursors.Hand;
		FAB238A9.Dock = System.Windows.Forms.DockStyle.Right;
		FAB238A9.FlatAppearance.BorderSize = 0;
		FAB238A9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		FAB238A9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FAB238A9.ForeColor = System.Drawing.Color.White;
		FAB238A9.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		FAB238A9.Location = new System.Drawing.Point(364, 0);
		FAB238A9.Name = "btnMinimize";
		FAB238A9.Size = new System.Drawing.Size(32, 32);
		FAB238A9.TabIndex = 9;
		FAB238A9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		FAB238A9.UseVisualStyleBackColor = true;
		FAB238A9.Click += new System.EventHandler(B6933C10);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(396, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Thêm thư mục";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		BA8FC82B.BackColor = System.Drawing.Color.Maroon;
		BA8FC82B.Cursor = System.Windows.Forms.Cursors.Hand;
		BA8FC82B.FlatAppearance.BorderSize = 0;
		BA8FC82B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		BA8FC82B.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BA8FC82B.ForeColor = System.Drawing.Color.White;
		BA8FC82B.Location = new System.Drawing.Point(204, 105);
		BA8FC82B.Name = "btnCancel";
		BA8FC82B.Size = new System.Drawing.Size(92, 29);
		BA8FC82B.TabIndex = 4;
		BA8FC82B.Text = "Hủy";
		BA8FC82B.UseVisualStyleBackColor = false;
		BA8FC82B.Click += new System.EventHandler(E3933500);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(100, 105);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(D1093295);
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label1.Location = new System.Drawing.Point(33, 69);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(86, 16);
		label1.TabIndex = 20;
		label1.Text = "Tên thư mu\u0323c:";
		label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		txbNameFile.Location = new System.Drawing.Point(125, 66);
		txbNameFile.Name = "txbNameFile";
		txbNameFile.Size = new System.Drawing.Size(234, 23);
		txbNameFile.TabIndex = 2;
		txbNameFile.KeyDown += new System.Windows.Forms.KeyEventHandler(txbNameFile_KeyDown);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(396, 145);
		base.Controls.Add(label1);
		base.Controls.Add(BA8FC82B);
		base.Controls.Add(btnAdd);
		base.Controls.Add(txbNameFile);
		base.Controls.Add(E49CEF16);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fAddFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		E49CEF16.ResumeLayout(false);
		D53C721B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
