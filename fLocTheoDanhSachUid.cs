using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fLocTheoDanhSachUid : Form
{
	public List<string> list_0 = new List<string>();

	private IContainer F78FF0A5 = null;

	private BunifuCards E90932B0;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private BunifuDragControl A8BA849F;

	private PictureBox A695872E;

	private Label lblStatus;

	private RichTextBox txtUseragent;

	public fLocTheoDanhSachUid()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		list_0 = new List<string>();
	}

	private void CE04949E(object sender, EventArgs e)
	{
		Close();
	}

	private void EC03189B(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtUseragent.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p thêm UID!", 3);
				return;
			}
			list_0 = GClass8.smethod_28(e03C713E);
			Close();
		}
		catch (Exception)
		{
			GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void A6848F04(object sender, EventArgs e)
	{
		Close();
	}

	private void txtUseragent_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtUseragent, lblStatus);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && F78FF0A5 != null)
		{
			F78FF0A5.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		F78FF0A5 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLocTheoDanhSachUid));
		E90932B0 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		A695872E = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		A8BA849F = new Bunifu.Framework.UI.BunifuDragControl(F78FF0A5);
		lblStatus = new System.Windows.Forms.Label();
		txtUseragent = new System.Windows.Forms.RichTextBox();
		E90932B0.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A695872E).BeginInit();
		SuspendLayout();
		E90932B0.BackColor = System.Drawing.Color.White;
		E90932B0.BorderRadius = 0;
		E90932B0.BottomSahddow = true;
		E90932B0.color = System.Drawing.Color.SaddleBrown;
		E90932B0.Controls.Add(pnlHeader);
		E90932B0.Dock = System.Windows.Forms.DockStyle.Top;
		E90932B0.LeftSahddow = false;
		E90932B0.Location = new System.Drawing.Point(0, 0);
		E90932B0.Name = "bunifuCards1";
		E90932B0.RightSahddow = true;
		E90932B0.ShadowDepth = 20;
		E90932B0.Size = new System.Drawing.Size(477, 38);
		E90932B0.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(A695872E);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(477, 32);
		pnlHeader.TabIndex = 9;
		A695872E.Cursor = System.Windows.Forms.Cursors.Default;
		A695872E.Image = C50FB39E.Bitmap_5;
		A695872E.Location = new System.Drawing.Point(4, 1);
		A695872E.Name = "pictureBox1";
		A695872E.Size = new System.Drawing.Size(34, 27);
		A695872E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A695872E.TabIndex = 77;
		A695872E.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(445, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(CE04949E);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(477, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Nhâ\u0323p Danh sách UID/Email cần lọc";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(245, 280);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(A6848F04);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(136, 280);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(EC03189B);
		A8BA849F.Fixed = true;
		A8BA849F.Horizontal = true;
		A8BA849F.TargetControl = bunifuCustomLabel1;
		A8BA849F.Vertical = true;
		lblStatus.AutoSize = true;
		lblStatus.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.Location = new System.Drawing.Point(30, 47);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(152, 16);
		lblStatus.TabIndex = 6;
		lblStatus.Text = "Danh sa\u0301ch UID/Email (0):";
		txtUseragent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtUseragent.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtUseragent.Location = new System.Drawing.Point(34, 66);
		txtUseragent.Name = "txtUseragent";
		txtUseragent.Size = new System.Drawing.Size(409, 181);
		txtUseragent.TabIndex = 118;
		txtUseragent.Text = "";
		txtUseragent.WordWrap = false;
		txtUseragent.TextChanged += new System.EventHandler(txtUseragent_TextChanged);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(477, 323);
		base.Controls.Add(txtUseragent);
		base.Controls.Add(lblStatus);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(E90932B0);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fLocTheoDanhSachUid";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		E90932B0.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A695872E).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
