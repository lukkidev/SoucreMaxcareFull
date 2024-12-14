using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fThemKichBan : Form
{
	private int int_0 = 0;

	private string string_0 = "";

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private BunifuCards bunifuCards1;

	private Panel CC155681;

	private PictureBox A83B512C;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button button1;

	private Label A608EF00;

	private Button btnCancel;

	private Button btnAdd;

	private TextBox C4AA74A0;

	private Panel panel1;

	public fThemKichBan(int int_1, string F134699E = "")
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		int_0 = int_1;
		string_0 = F134699E;
		if (int_1 == 1)
		{
			bunifuCustomLabel1.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t ki\u0323ch ba\u0309n");
			btnAdd.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			C4AA74A0.Text = Class147.smethod_1(F134699E).Rows[0]["TenKichBan"].ToString();
		}
	}

	private void EC899B96()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(A608EF00);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void fThemKichBan_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A720712C(object sender, EventArgs e)
	{
		string text = C4AA74A0.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ki\u0323ch ba\u0309n!", 2);
		}
		else if (int_0 == 0)
		{
			string text2 = "";
			try
			{
				text2 = GClass32.BC97849E.method_1("SELECT STT FROM Kich_Ban ORDER BY STT DESC LIMIT 1").Rows[0]["STT"].ToString();
			}
			catch
			{
			}
			text2 = ((text2 == "") ? "1" : (Convert.ToInt32(text2) + 1).ToString());
			if (Class147.C49AC90F(text, text2))
			{
				Close();
			}
			else
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
		else if (Class147.smethod_4(string_0, text))
		{
			Close();
		}
		else
		{
			GClass29.smethod_0("Co\u0301 lô\u0303i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void AE186FB5(object sender, EventArgs e)
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

	private void BCA9DFA0(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			A720712C(null, null);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemKichBan));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		CC155681 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		A83B512C = new System.Windows.Forms.PictureBox();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		A608EF00 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		C4AA74A0 = new System.Windows.Forms.TextBox();
		panel1 = new System.Windows.Forms.Panel();
		CC155681.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A83B512C).BeginInit();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(324, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Thêm kịch bản";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = CC155681;
		bunifuDragControl_1.Vertical = true;
		CC155681.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		CC155681.BackColor = System.Drawing.Color.White;
		CC155681.Controls.Add(button1);
		CC155681.Controls.Add(A83B512C);
		CC155681.Controls.Add(bunifuCustomLabel1);
		CC155681.Cursor = System.Windows.Forms.Cursors.SizeAll;
		CC155681.Location = new System.Drawing.Point(1, 3);
		CC155681.Name = "pnlHeader";
		CC155681.Size = new System.Drawing.Size(324, 31);
		CC155681.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(293, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(button1_Click);
		A83B512C.Cursor = System.Windows.Forms.Cursors.Default;
		A83B512C.Image = C50FB39E.Bitmap_5;
		A83B512C.Location = new System.Drawing.Point(3, 2);
		A83B512C.Name = "pictureBox1";
		A83B512C.Size = new System.Drawing.Size(34, 27);
		A83B512C.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A83B512C.TabIndex = 76;
		A83B512C.TabStop = false;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(CC155681);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(2, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(327, 37);
		bunifuCards1.TabIndex = 12;
		A608EF00.AutoSize = true;
		A608EF00.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		A608EF00.Location = new System.Drawing.Point(32, 55);
		A608EF00.Name = "label2";
		A608EF00.Size = new System.Drawing.Size(85, 16);
		A608EF00.TabIndex = 24;
		A608EF00.Text = "Tên kịch bản:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(171, 96);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 2;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(AE186FB5);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(67, 96);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 1;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(A720712C);
		C4AA74A0.Location = new System.Drawing.Point(124, 52);
		C4AA74A0.Name = "txtTen";
		C4AA74A0.Size = new System.Drawing.Size(171, 23);
		C4AA74A0.TabIndex = 0;
		C4AA74A0.KeyDown += new System.Windows.Forms.KeyEventHandler(BCA9DFA0);
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(330, 137);
		panel1.TabIndex = 25;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(330, 137);
		base.Controls.Add(A608EF00);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(C4AA74A0);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemKichBan";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(fThemKichBan_Load);
		CC155681.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A83B512C).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}
}
