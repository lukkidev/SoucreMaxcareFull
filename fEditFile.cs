using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fEditFile : Form
{
	private string string_0;

	private string BC2FDD06;

	public bool A0A227BD = false;

	private IContainer AC987CBC = null;

	private BunifuCards bunifuCards1;

	private Panel A61FF695;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button D592E892;

	private Button btnCancel;

	private Button C937FBB9;

	private Label E4AF4989;

	private BunifuDragControl bunifuDragControl_0;

	private TextBox txtNameFileOld;

	private PictureBox pictureBox1;

	private TextBox txtNameFileNew;

	private Label label2;

	public fEditFile(string string_1, string string_2)
	{
		B3322602();
		F7AB102E.D6B70A35(this);
		string_0 = string_1;
		BC2FDD06 = string_2;
		A0A227BD = false;
	}

	private void D592E892_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F685FC15()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(E4AF4989);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(C937FBB9);
		F7AB102E.smethod_1(btnCancel);
	}

	private void EE12A098(object sender, EventArgs e)
	{
		string text = txtNameFileNew.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lòng điền tên thư mục mới!", 3);
			txtNameFileNew.Focus();
		}
		else if (Class15.smethod_0(text))
		{
			GClass29.smethod_0("Tên thư mục này đã tồn tại, vui lòng nhập tên khác!", 3);
			txtNameFileNew.Focus();
		}
		else if (text.Equals(txtNameFileOld.Text.Trim()))
		{
			GClass29.smethod_0("Tên thư mục mới phải khác thư mục cũ!", 3);
			txtNameFileNew.Focus();
		}
		else if (Class15.smethod_2(string_0, text))
		{
			A0A227BD = true;
			if (GClass29.smethod_1("Cập nhật thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass29.smethod_0("Cập nhật tên thư mục lỗi!");
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void C68845B5(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			EE12A098(null, null);
		}
	}

	private void E4221D34(object sender, EventArgs e)
	{
		txtNameFileOld.Text = BC2FDD06;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && AC987CBC != null)
		{
			AC987CBC.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void B3322602()
	{
		AC987CBC = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fEditFile));
		bunifuCards1 = new BunifuCards();
		A61FF695 = new Panel();
		pictureBox1 = new PictureBox();
		D592E892 = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		btnCancel = new Button();
		C937FBB9 = new Button();
		E4AF4989 = new Label();
		bunifuDragControl_0 = new BunifuDragControl(AC987CBC);
		txtNameFileOld = new TextBox();
		txtNameFileNew = new TextBox();
		label2 = new Label();
		bunifuCards1.SuspendLayout();
		A61FF695.SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(A61FF695);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(396, 38);
		bunifuCards1.TabIndex = 0;
		A61FF695.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		A61FF695.BackColor = Color.White;
		A61FF695.Controls.Add(pictureBox1);
		A61FF695.Controls.Add(D592E892);
		A61FF695.Controls.Add(bunifuCustomLabel1);
		A61FF695.Location = new Point(0, 5);
		A61FF695.Name = "pnlHeader";
		A61FF695.Size = new Size(396, 32);
		A61FF695.TabIndex = 9;
		pictureBox1.Cursor = Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new Point(4, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new Size(34, 27);
		pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 77;
		pictureBox1.TabStop = false;
		D592E892.Cursor = Cursors.Hand;
		D592E892.FlatAppearance.BorderSize = 0;
		D592E892.FlatStyle = FlatStyle.Flat;
		D592E892.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D592E892.ForeColor = Color.White;
		D592E892.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		D592E892.Location = new Point(362, -2);
		D592E892.Name = "btnMinimize";
		D592E892.Size = new Size(32, 32);
		D592E892.TabIndex = 9;
		D592E892.TextImageRelation = TextImageRelation.ImageBeforeText;
		D592E892.UseVisualStyleBackColor = true;
		D592E892.Click += D592E892_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(396, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Cập nhật Tên thư mục";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(204, 138);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Hủy";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += btnCancel_Click;
		C937FBB9.BackColor = Color.FromArgb(53, 120, 229);
		C937FBB9.Cursor = Cursors.Hand;
		C937FBB9.FlatAppearance.BorderSize = 0;
		C937FBB9.FlatStyle = FlatStyle.Flat;
		C937FBB9.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C937FBB9.ForeColor = Color.White;
		C937FBB9.Location = new Point(100, 138);
		C937FBB9.Name = "btnAdd";
		C937FBB9.Size = new Size(92, 29);
		C937FBB9.TabIndex = 3;
		C937FBB9.Text = "Cập nhật";
		C937FBB9.UseVisualStyleBackColor = false;
		C937FBB9.Click += EE12A098;
		E4AF4989.AutoSize = true;
		E4AF4989.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		E4AF4989.Location = new Point(33, 69);
		E4AF4989.Name = "label1";
		E4AF4989.Size = new Size(102, 16);
		E4AF4989.TabIndex = 20;
		E4AF4989.Text = "Tên thư mu\u0323c cũ:";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		txtNameFileOld.ForeColor = SystemColors.ControlDarkDark;
		txtNameFileOld.Location = new Point(150, 66);
		txtNameFileOld.Name = "txtNameFileOld";
		txtNameFileOld.ReadOnly = true;
		txtNameFileOld.Size = new Size(209, 23);
		txtNameFileOld.TabIndex = 2;
		txtNameFileOld.KeyDown += C68845B5;
		txtNameFileNew.Location = new Point(150, 95);
		txtNameFileNew.Name = "txtNameFileNew";
		txtNameFileNew.Size = new Size(209, 23);
		txtNameFileNew.TabIndex = 2;
		txtNameFileNew.KeyDown += C68845B5;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		label2.Location = new Point(33, 98);
		label2.Name = "label2";
		label2.Size = new Size(110, 16);
		label2.TabIndex = 20;
		label2.Text = "Tên thư mu\u0323c mới:";
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(396, 182);
		base.Controls.Add(label2);
		base.Controls.Add(E4AF4989);
		base.Controls.Add(btnCancel);
		base.Controls.Add(C937FBB9);
		base.Controls.Add(txtNameFileNew);
		base.Controls.Add(txtNameFileOld);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fEditFile";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += E4221D34;
		bunifuCards1.ResumeLayout(performLayout: false);
		A61FF695.ResumeLayout(performLayout: false);
		((ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
