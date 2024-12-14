using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhBackupGroup : Form
{
	public bool bool_0 = false;

	private IContainer DA97169D = null;

	private BunifuCards bunifuCards1;

	private Panel D00FE7BA;

	private BunifuCustomLabel D6A2711B;

	private Button B882C408;

	private Button CD0A5B1F;

	private Button FFB1E13F;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox D1385C80;

	private CheckBox ckbCheckNhomKiemDuyet;

	private Label label2;

	private TextBox txtFolderPath;

	public fCauHinhBackupGroup()
	{
		CFA3328B();
		F7AB102E.D6B70A35(this);
	}

	private void D32B48AF(object sender, EventArgs e)
	{
		Close();
	}

	private void A216F508(object sender, EventArgs e)
	{
		GClass25.smethod_0("configBackupGroup").method_4("txtFolderPath", txtFolderPath.Text.Trim());
		GClass25.smethod_0("configBackupGroup").method_4("ckbCheckNhomKiemDuyet", ckbCheckNhomKiemDuyet.Checked);
		GClass25.B3B73732("configBackupGroup");
		bool_0 = true;
		Close();
	}

	private void CD0A5B1F_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void E8A0F635(object sender, EventArgs e)
	{
		txtFolderPath.Text = GClass25.smethod_0("configBackupGroup").C0288288("txtFolderPath");
		ckbCheckNhomKiemDuyet.Checked = GClass25.smethod_0("configBackupGroup").method_3("ckbCheckNhomKiemDuyet");
	}

	private void ckbCheckNhomKiemDuyet_Click(object sender, EventArgs e)
	{
		if (ckbCheckNhomKiemDuyet.Checked && GClass29.smethod_1(F7AB102E.smethod_0("Tính năng này có thể khiến tài khoản bị khóa, bạn vẫn muốn sử dụng?")) == DialogResult.No)
		{
			ckbCheckNhomKiemDuyet.Checked = false;
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && DA97169D != null)
		{
			DA97169D.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void CFA3328B()
	{
		DA97169D = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fCauHinhBackupGroup));
		bunifuCards1 = new BunifuCards();
		D00FE7BA = new Panel();
		D1385C80 = new PictureBox();
		B882C408 = new Button();
		D6A2711B = new BunifuCustomLabel();
		CD0A5B1F = new Button();
		FFB1E13F = new Button();
		bunifuDragControl_0 = new BunifuDragControl(DA97169D);
		ckbCheckNhomKiemDuyet = new CheckBox();
		label2 = new Label();
		txtFolderPath = new TextBox();
		bunifuCards1.SuspendLayout();
		D00FE7BA.SuspendLayout();
		((ISupportInitialize)D1385C80).BeginInit();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(D00FE7BA);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(444, 38);
		bunifuCards1.TabIndex = 0;
		D00FE7BA.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		D00FE7BA.BackColor = Color.White;
		D00FE7BA.Controls.Add(D1385C80);
		D00FE7BA.Controls.Add(B882C408);
		D00FE7BA.Controls.Add(D6A2711B);
		D00FE7BA.Location = new Point(0, 5);
		D00FE7BA.Name = "pnlHeader";
		D00FE7BA.Size = new Size(444, 32);
		D00FE7BA.TabIndex = 9;
		D1385C80.Cursor = Cursors.Default;
		D1385C80.Image = (Image)componentResourceManager.GetObject("pictureBox1.Image");
		D1385C80.Location = new Point(3, 2);
		D1385C80.Name = "pictureBox1";
		D1385C80.Size = new Size(34, 27);
		D1385C80.SizeMode = PictureBoxSizeMode.Zoom;
		D1385C80.TabIndex = 17;
		D1385C80.TabStop = false;
		B882C408.Cursor = Cursors.Hand;
		B882C408.Dock = DockStyle.Right;
		B882C408.FlatAppearance.BorderSize = 0;
		B882C408.FlatStyle = FlatStyle.Flat;
		B882C408.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B882C408.ForeColor = Color.White;
		B882C408.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		B882C408.Location = new Point(412, 0);
		B882C408.Name = "btnMinimize";
		B882C408.Size = new Size(32, 32);
		B882C408.TabIndex = 9;
		B882C408.TextImageRelation = TextImageRelation.ImageBeforeText;
		B882C408.UseVisualStyleBackColor = true;
		B882C408.Click += D32B48AF;
		D6A2711B.BackColor = Color.Transparent;
		D6A2711B.Cursor = Cursors.SizeAll;
		D6A2711B.Dock = DockStyle.Fill;
		D6A2711B.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		D6A2711B.ForeColor = Color.Black;
		D6A2711B.Location = new Point(0, 0);
		D6A2711B.Name = "bunifuCustomLabel1";
		D6A2711B.Size = new Size(444, 32);
		D6A2711B.TabIndex = 1;
		D6A2711B.Text = "Câ\u0301u hi\u0300nh Backup Group";
		D6A2711B.TextAlign = ContentAlignment.MiddleCenter;
		CD0A5B1F.Anchor = AnchorStyles.Bottom;
		CD0A5B1F.BackColor = Color.Maroon;
		CD0A5B1F.Cursor = Cursors.Hand;
		CD0A5B1F.FlatAppearance.BorderSize = 0;
		CD0A5B1F.FlatStyle = FlatStyle.Flat;
		CD0A5B1F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		CD0A5B1F.ForeColor = Color.White;
		CD0A5B1F.Location = new Point(230, 117);
		CD0A5B1F.Name = "btnCancel";
		CD0A5B1F.Size = new Size(92, 29);
		CD0A5B1F.TabIndex = 4;
		CD0A5B1F.Text = "Đo\u0301ng";
		CD0A5B1F.UseVisualStyleBackColor = false;
		CD0A5B1F.Click += CD0A5B1F_Click;
		FFB1E13F.Anchor = AnchorStyles.Bottom;
		FFB1E13F.BackColor = Color.FromArgb(53, 120, 229);
		FFB1E13F.Cursor = Cursors.Hand;
		FFB1E13F.FlatAppearance.BorderSize = 0;
		FFB1E13F.FlatStyle = FlatStyle.Flat;
		FFB1E13F.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		FFB1E13F.ForeColor = Color.White;
		FFB1E13F.Location = new Point(126, 117);
		FFB1E13F.Name = "btnAdd";
		FFB1E13F.Size = new Size(92, 29);
		FFB1E13F.TabIndex = 3;
		FFB1E13F.Text = "Lưu";
		FFB1E13F.UseVisualStyleBackColor = false;
		FFB1E13F.Click += A216F508;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = D6A2711B;
		bunifuDragControl_0.Vertical = true;
		ckbCheckNhomKiemDuyet.AutoSize = true;
		ckbCheckNhomKiemDuyet.Cursor = Cursors.Hand;
		ckbCheckNhomKiemDuyet.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ckbCheckNhomKiemDuyet.Location = new Point(30, 82);
		ckbCheckNhomKiemDuyet.Name = "ckbCheckNhomKiemDuyet";
		ckbCheckNhomKiemDuyet.Size = new Size(162, 20);
		ckbCheckNhomKiemDuyet.TabIndex = 22;
		ckbCheckNhomKiemDuyet.Text = "Check nhóm kiểm duyệt";
		ckbCheckNhomKiemDuyet.UseVisualStyleBackColor = true;
		ckbCheckNhomKiemDuyet.Click += ckbCheckNhomKiemDuyet_Click;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(27, 56);
		label2.Name = "label2";
		label2.Size = new Size(140, 16);
		label2.TabIndex = 23;
		label2.Text = "Folder MaxPhoneFarm:";
		txtFolderPath.Location = new Point(173, 53);
		txtFolderPath.Name = "txtFolderPath";
		txtFolderPath.Size = new Size(241, 23);
		txtFolderPath.TabIndex = 24;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(444, 159);
		base.Controls.Add(txtFolderPath);
		base.Controls.Add(label2);
		base.Controls.Add(ckbCheckNhomKiemDuyet);
		base.Controls.Add(CD0A5B1F);
		base.Controls.Add(FFB1E13F);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fCauHinhBackupGroup";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += E8A0F635;
		bunifuCards1.ResumeLayout(performLayout: false);
		D00FE7BA.ResumeLayout(performLayout: false);
		((ISupportInitialize)D1385C80).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
