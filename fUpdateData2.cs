using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fUpdateData2 : Form
{
	private fQuanLyTinNhan C39ABCB8;

	private IContainer C41E6F12 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private ComboBox cbbTypeUpdate;

	private Label CC04AC1E;

	private TextBox txbData;

	private Label AEA011A5;

	private Button A2A841AD;

	private Button AF8029A2;

	private PictureBox A986840B;

	private Label label3;

	private ComboBox cbbTypeProxy;

	public fUpdateData2(fQuanLyTinNhan B93DF610, string string_0)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		C39ABCB8 = B93DF610;
		cbbTypeUpdate.Text = string_0;
		cbbTypeProxy.SelectedIndex = 0;
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(CC04AC1E);
		F7AB102E.smethod_1(AEA011A5);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(AF8029A2);
		F7AB102E.smethod_1(A2A841AD);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A2A841AD_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void F92E09A3(object sender, EventArgs e)
	{
		try
		{
			bool flag = false;
			if (!txbData.Text.Equals("") && !txbData.Text.Equals("|"))
			{
				if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Ba\u0323n co\u0301 chă\u0301c muô\u0301n câ\u0323p nhâ\u0323t dư\u0303 liê\u0323u của {0} tài khoản?"), C39ABCB8.method_0())) == DialogResult.Yes)
				{
					flag = true;
				}
			}
			else if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Ba\u0323n co\u0301 chă\u0301c muô\u0301n xo\u0301a dư\u0303 liê\u0323u của {0} tài khoản?"), C39ABCB8.method_0())) == DialogResult.Yes)
			{
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			List<string> list = new List<string>();
			string text = txbData.Text;
			for (int i = 0; i < C39ABCB8.dgvTaiKhoan.SelectedRows.Count; i++)
			{
				list.Add(C39ABCB8.C4346112(C39ABCB8.dgvTaiKhoan.SelectedRows[i].Index, "cId"));
			}
			string text2 = cbbTypeUpdate.Text;
			string text3 = text2;
			if (text3 == "Notes" && Class15.DB0FC1AC(list, "ghiChu", text))
			{
				for (int j = 0; j < C39ABCB8.dgvTaiKhoan.SelectedRows.Count; j++)
				{
					C39ABCB8.C907A8BF(C39ABCB8.dgvTaiKhoan.SelectedRows[j].Index, "cGhiChu", text);
				}
			}
			Close();
		}
		catch
		{
			GClass29.smethod_0("Vui lòng thử lại sau!", 2);
		}
	}

	private void cbbTypeUpdate_SelectedIndexChanged(object sender, EventArgs e)
	{
		bool visible = cbbTypeUpdate.Text == "Proxy";
		label3.Visible = visible;
		cbbTypeProxy.Visible = visible;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && C41E6F12 != null)
		{
			C41E6F12.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUpdateData2));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		btnMinimize = new System.Windows.Forms.Button();
		A986840B = new System.Windows.Forms.PictureBox();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		cbbTypeUpdate = new System.Windows.Forms.ComboBox();
		CC04AC1E = new System.Windows.Forms.Label();
		txbData = new System.Windows.Forms.TextBox();
		AEA011A5 = new System.Windows.Forms.Label();
		A2A841AD = new System.Windows.Forms.Button();
		AF8029A2 = new System.Windows.Forms.Button();
		label3 = new System.Windows.Forms.Label();
		cbbTypeProxy = new System.Windows.Forms.ComboBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)A986840B).BeginInit();
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
		pnlHeader.Controls.Add(A986840B);
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
		A986840B.Cursor = System.Windows.Forms.Cursors.Default;
		A986840B.Image = C50FB39E.Bitmap_5;
		A986840B.Location = new System.Drawing.Point(3, 1);
		A986840B.Name = "pictureBox1";
		A986840B.Size = new System.Drawing.Size(34, 27);
		A986840B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		A986840B.TabIndex = 79;
		A986840B.TabStop = false;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(416, 32);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		cbbTypeUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeUpdate.FormattingEnabled = true;
		cbbTypeUpdate.ItemHeight = 16;
		cbbTypeUpdate.Items.AddRange(new object[10] { "Token", "Cookie", "Password", "Mail|pass", "PassMail", "2FA", "Birthday", "Useragent", "Proxy", "Notes" });
		cbbTypeUpdate.Location = new System.Drawing.Point(146, 43);
		cbbTypeUpdate.Name = "cbbTypeUpdate";
		cbbTypeUpdate.Size = new System.Drawing.Size(238, 24);
		cbbTypeUpdate.TabIndex = 13;
		cbbTypeUpdate.SelectedIndexChanged += new System.EventHandler(cbbTypeUpdate_SelectedIndexChanged);
		CC04AC1E.AutoSize = true;
		CC04AC1E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CC04AC1E.Location = new System.Drawing.Point(34, 46);
		CC04AC1E.Name = "label1";
		CC04AC1E.Size = new System.Drawing.Size(105, 16);
		CC04AC1E.TabIndex = 14;
		CC04AC1E.Text = "Dữ liệu cập nhật:";
		txbData.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txbData.Location = new System.Drawing.Point(146, 73);
		txbData.Name = "txbData";
		txbData.Size = new System.Drawing.Size(238, 23);
		txbData.TabIndex = 15;
		AEA011A5.AutoSize = true;
		AEA011A5.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		AEA011A5.Location = new System.Drawing.Point(34, 76);
		AEA011A5.Name = "label2";
		AEA011A5.Size = new System.Drawing.Size(84, 16);
		AEA011A5.TabIndex = 16;
		AEA011A5.Text = "Nhập dữ liệu:";
		A2A841AD.BackColor = System.Drawing.Color.Maroon;
		A2A841AD.Cursor = System.Windows.Forms.Cursors.Hand;
		A2A841AD.FlatAppearance.BorderSize = 0;
		A2A841AD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A2A841AD.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A2A841AD.ForeColor = System.Drawing.Color.White;
		A2A841AD.Location = new System.Drawing.Point(209, 139);
		A2A841AD.Name = "btnCancel";
		A2A841AD.Size = new System.Drawing.Size(92, 29);
		A2A841AD.TabIndex = 18;
		A2A841AD.Text = "Đóng";
		A2A841AD.UseVisualStyleBackColor = false;
		A2A841AD.Click += new System.EventHandler(A2A841AD_Click);
		AF8029A2.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		AF8029A2.Cursor = System.Windows.Forms.Cursors.Hand;
		AF8029A2.FlatAppearance.BorderSize = 0;
		AF8029A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AF8029A2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AF8029A2.ForeColor = System.Drawing.Color.White;
		AF8029A2.Location = new System.Drawing.Point(111, 139);
		AF8029A2.Name = "btnAdd";
		AF8029A2.Size = new System.Drawing.Size(92, 29);
		AF8029A2.TabIndex = 17;
		AF8029A2.Text = "Lưu";
		AF8029A2.UseVisualStyleBackColor = false;
		AF8029A2.Click += new System.EventHandler(F92E09A3);
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(34, 105);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(70, 16);
		label3.TabIndex = 16;
		label3.Text = "Loại proxy:";
		cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbTypeProxy.FormattingEnabled = true;
		cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		cbbTypeProxy.Location = new System.Drawing.Point(146, 102);
		cbbTypeProxy.Name = "cbbTypeProxy";
		cbbTypeProxy.Size = new System.Drawing.Size(130, 24);
		cbbTypeProxy.TabIndex = 124;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(416, 181);
		base.Controls.Add(cbbTypeProxy);
		base.Controls.Add(A2A841AD);
		base.Controls.Add(AF8029A2);
		base.Controls.Add(label3);
		base.Controls.Add(AEA011A5);
		base.Controls.Add(txbData);
		base.Controls.Add(CC04AC1E);
		base.Controls.Add(cbbTypeUpdate);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fUpdateData2";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fUpdateData";
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)A986840B).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
