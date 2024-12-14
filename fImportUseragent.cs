using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportUseragent : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards EB24A216;

	private Panel C9BD7F81;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button B22359A0;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox AB0FD917;

	private Label label8;

	private Label lblStatus;

	private RichTextBox txtUseragent;

	private Label label1;

	private NumericUpDown nudTaiKhoanPerUa;

	private CheckBox F4ACD201;

	private Label label2;

	private RadioButton rbNgauNhien;

	private RadioButton rbLanLuot;

	public fImportUseragent()
	{
		E7148B94();
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(lblStatus);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(label8);
		F7AB102E.smethod_1(label2);
		F7AB102E.smethod_1(rbLanLuot);
		F7AB102E.smethod_1(rbNgauNhien);
		F7AB102E.smethod_1(F4ACD201);
		F7AB102E.smethod_1(B22359A0);
		F7AB102E.smethod_1(btnCancel);
	}

	private void D32BA4B6(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtUseragent.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			List<string> list = new List<string>();
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p thêm Useragent!", 3);
				return;
			}
			int num = Convert.ToInt32(nudTaiKhoanPerUa.Value);
			for (int i = 0; i < e03C713E.Count; i++)
			{
				for (int j = 0; j < num; j++)
				{
					list.Add(e03C713E[i]);
				}
			}
			if (rbNgauNhien.Checked)
			{
				list = GClass8.smethod_35(list);
			}
			Queue<string> queue = new Queue<string>(list);
			for (int k = 0; k < fMain.fMain_0.dtgvAcc.Rows.Count; k++)
			{
				if (Convert.ToBoolean(fMain.fMain_0.method_145(k, "cChose")) && (!(fMain.fMain_0.method_145(k, "cUseragent") != "") || !F4ACD201.Checked))
				{
					if (queue.Count == 0)
					{
						break;
					}
					string text = queue.Dequeue().Replace("'", "''");
					if (Class15.EB34450D(fMain.fMain_0.method_145(k, "cId"), "useragent", text))
					{
						fMain.fMain_0.E38D51B3(k, "cUseragent", text);
					}
				}
			}
			if (GClass29.smethod_1("Nhâ\u0323p thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
			{
				Close();
			}
		}
		catch (Exception)
		{
			GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
		}
	}

	private void FA06D612(object sender, EventArgs e)
	{
		Close();
	}

	private void B5A77F16(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			D32BA4B6(null, null);
		}
	}

	private void C51BFBA7(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtUseragent.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			lblStatus.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch Useragent ({0}):"), e03C713E.Count);
		}
		catch
		{
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

	private void E7148B94()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fImportUseragent));
		EB24A216 = new BunifuCards();
		C9BD7F81 = new Panel();
		AB0FD917 = new PictureBox();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		btnCancel = new Button();
		B22359A0 = new Button();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		label8 = new Label();
		lblStatus = new Label();
		txtUseragent = new RichTextBox();
		label1 = new Label();
		nudTaiKhoanPerUa = new NumericUpDown();
		F4ACD201 = new CheckBox();
		label2 = new Label();
		rbNgauNhien = new RadioButton();
		rbLanLuot = new RadioButton();
		EB24A216.SuspendLayout();
		C9BD7F81.SuspendLayout();
		((ISupportInitialize)AB0FD917).BeginInit();
		((ISupportInitialize)nudTaiKhoanPerUa).BeginInit();
		SuspendLayout();
		EB24A216.BackColor = Color.White;
		EB24A216.BorderRadius = 0;
		EB24A216.BottomSahddow = true;
		EB24A216.color = Color.SaddleBrown;
		EB24A216.Controls.Add(C9BD7F81);
		EB24A216.Dock = DockStyle.Top;
		EB24A216.LeftSahddow = false;
		EB24A216.Location = new Point(0, 0);
		EB24A216.Name = "bunifuCards1";
		EB24A216.RightSahddow = true;
		EB24A216.ShadowDepth = 20;
		EB24A216.Size = new Size(477, 38);
		EB24A216.TabIndex = 0;
		C9BD7F81.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		C9BD7F81.BackColor = Color.White;
		C9BD7F81.Controls.Add(AB0FD917);
		C9BD7F81.Controls.Add(btnMinimize);
		C9BD7F81.Controls.Add(bunifuCustomLabel1);
		C9BD7F81.Location = new Point(0, 5);
		C9BD7F81.Name = "pnlHeader";
		C9BD7F81.Size = new Size(477, 32);
		C9BD7F81.TabIndex = 9;
		AB0FD917.Cursor = Cursors.Default;
		AB0FD917.Image = C50FB39E.Bitmap_5;
		AB0FD917.Location = new Point(4, 1);
		AB0FD917.Name = "pictureBox1";
		AB0FD917.Size = new Size(34, 27);
		AB0FD917.SizeMode = PictureBoxSizeMode.Zoom;
		AB0FD917.TabIndex = 77;
		AB0FD917.TabStop = false;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.Dock = DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		btnMinimize.Location = new Point(445, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += btnMinimize_Click;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Cursor = Cursors.SizeAll;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(477, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Nhâ\u0323p Useragent";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(245, 342);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += FA06D612;
		B22359A0.BackColor = Color.FromArgb(53, 120, 229);
		B22359A0.Cursor = Cursors.Hand;
		B22359A0.FlatAppearance.BorderSize = 0;
		B22359A0.FlatStyle = FlatStyle.Flat;
		B22359A0.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B22359A0.ForeColor = Color.White;
		B22359A0.Location = new Point(136, 342);
		B22359A0.Name = "btnAdd";
		B22359A0.Size = new Size(92, 29);
		B22359A0.TabIndex = 3;
		B22359A0.Text = "Xa\u0301c nhâ\u0323n";
		B22359A0.UseVisualStyleBackColor = false;
		B22359A0.Click += D32BA4B6;
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		label8.AutoSize = true;
		label8.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label8.Location = new Point(301, 252);
		label8.Name = "label8";
		label8.Size = new Size(141, 16);
		label8.TabIndex = 5;
		label8.Text = "(Mỗi useragent 1 dòng)";
		lblStatus.AutoSize = true;
		lblStatus.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		lblStatus.Location = new Point(30, 47);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new Size(154, 16);
		lblStatus.TabIndex = 6;
		lblStatus.Text = "Danh sa\u0301ch Useragent (0):";
		txtUseragent.BorderStyle = BorderStyle.FixedSingle;
		txtUseragent.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtUseragent.Location = new Point(34, 66);
		txtUseragent.Name = "txtUseragent";
		txtUseragent.Size = new Size(409, 181);
		txtUseragent.TabIndex = 118;
		txtUseragent.Text = "";
		txtUseragent.WordWrap = false;
		txtUseragent.TextChanged += C51BFBA7;
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(31, 252);
		label1.Name = "label1";
		label1.Size = new Size(146, 16);
		label1.TabIndex = 119;
		label1.Text = "Sô\u0301 ta\u0300i khoa\u0309n/Useragent:";
		nudTaiKhoanPerUa.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		nudTaiKhoanPerUa.Location = new Point(184, 250);
		nudTaiKhoanPerUa.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTaiKhoanPerUa.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudTaiKhoanPerUa.Name = "nudTaiKhoanPerUa";
		nudTaiKhoanPerUa.Size = new Size(69, 23);
		nudTaiKhoanPerUa.TabIndex = 120;
		nudTaiKhoanPerUa.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		F4ACD201.AutoSize = true;
		F4ACD201.Cursor = Cursors.Hand;
		F4ACD201.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		F4ACD201.Location = new Point(33, 303);
		F4ACD201.Name = "ckbKhongNhapTaiKhoanDaCo";
		F4ACD201.Size = new Size(310, 20);
		F4ACD201.TabIndex = 121;
		F4ACD201.Text = "Không nhâ\u0323p va\u0300o như\u0303ng ta\u0300i khoa\u0309n đa\u0303 co\u0301 Useragent";
		F4ACD201.UseVisualStyleBackColor = true;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(30, 279);
		label2.Name = "label2";
		label2.Size = new Size(158, 16);
		label2.TabIndex = 119;
		label2.Text = "Tu\u0300y cho\u0323n nhâ\u0323p Useragent:";
		rbNgauNhien.AutoSize = true;
		rbNgauNhien.Cursor = Cursors.Hand;
		rbNgauNhien.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbNgauNhien.Location = new Point(274, 277);
		rbNgauNhien.Name = "rbNgauNhien";
		rbNgauNhien.Size = new Size(89, 20);
		rbNgauNhien.TabIndex = 122;
		rbNgauNhien.Text = "Ngâ\u0303u nhiên";
		rbNgauNhien.UseVisualStyleBackColor = true;
		rbLanLuot.AutoSize = true;
		rbLanLuot.Checked = true;
		rbLanLuot.Cursor = Cursors.Hand;
		rbLanLuot.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		rbLanLuot.Location = new Point(184, 277);
		rbLanLuot.Name = "rbLanLuot";
		rbLanLuot.Size = new Size(71, 20);
		rbLanLuot.TabIndex = 122;
		rbLanLuot.TabStop = true;
		rbLanLuot.Text = "Lâ\u0300n lươ\u0323t";
		rbLanLuot.UseVisualStyleBackColor = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(477, 388);
		base.Controls.Add(rbLanLuot);
		base.Controls.Add(rbNgauNhien);
		base.Controls.Add(F4ACD201);
		base.Controls.Add(nudTaiKhoanPerUa);
		base.Controls.Add(label2);
		base.Controls.Add(label1);
		base.Controls.Add(txtUseragent);
		base.Controls.Add(label8);
		base.Controls.Add(lblStatus);
		base.Controls.Add(btnCancel);
		base.Controls.Add(B22359A0);
		base.Controls.Add(EB24A216);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fImportUseragent";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fAddFile";
		EB24A216.ResumeLayout(performLayout: false);
		C9BD7F81.ResumeLayout(performLayout: false);
		((ISupportInitialize)AB0FD917).EndInit();
		((ISupportInitialize)nudTaiKhoanPerUa).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
