using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fImportProxy : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards F537D68B;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button DDA4BC1E;

	private BunifuDragControl bunifuDragControl_0;

	private PictureBox pictureBox1;

	private Label label8;

	private Label E4147F29;

	private RichTextBox txtProxy;

	private Label label1;

	private NumericUpDown nudTaiKhoanPerUa;

	private CheckBox ckbKhongNhapTaiKhoanDaCo;

	private Label CF2FF71D;

	private RadioButton rbNgauNhien;

	private RadioButton rbLanLuot;

	private Label label3;

	private ComboBox cbbTypeProxy;

	public fImportProxy()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		cbbTypeProxy.SelectedIndex = 0;
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(E4147F29);
		F7AB102E.smethod_1(label8);
		F7AB102E.smethod_1(label3);
		F7AB102E.smethod_1(label1);
		F7AB102E.smethod_1(CF2FF71D);
		F7AB102E.smethod_1(rbLanLuot);
		F7AB102E.smethod_1(rbNgauNhien);
		F7AB102E.smethod_1(ckbKhongNhapTaiKhoanDaCo);
		F7AB102E.smethod_1(DDA4BC1E);
		F7AB102E.smethod_1(btnCancel);
	}

	private void DDA4BC1E_Click(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtProxy.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			List<string> list = new List<string>();
			if (e03C713E.Count == 0)
			{
				GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p thêm Proxy!", 3);
				return;
			}
			int num = Convert.ToInt32(nudTaiKhoanPerUa.Value);
			for (int i = 0; i < num; i++)
			{
				list.AddRange(e03C713E);
			}
			if (rbNgauNhien.Checked)
			{
				list = GClass8.smethod_35(list);
			}
			Queue<string> queue = new Queue<string>(list);
			int selectedIndex = cbbTypeProxy.SelectedIndex;
			List<string> list2 = new List<string>();
			for (int j = 0; j < fMain.fMain_0.dtgvAcc.Rows.Count; j++)
			{
				if (Convert.ToBoolean(fMain.fMain_0.method_145(j, "cChose")) && (!(fMain.fMain_0.method_145(j, "cProxy") != "") || !ckbKhongNhapTaiKhoanDaCo.Checked))
				{
					if (queue.Count == 0)
					{
						break;
					}
					string text = (queue.Dequeue() + "*" + selectedIndex).Replace("'", "''");
					list2.Add(fMain.fMain_0.method_145(j, "cId") + "|" + text);
				}
			}
			if (Class15.smethod_4("proxy", list2))
			{
				queue = new Queue<string>(list);
				for (int k = 0; k < fMain.fMain_0.dtgvAcc.Rows.Count; k++)
				{
					if (Convert.ToBoolean(fMain.fMain_0.method_145(k, "cChose")) && (!(fMain.fMain_0.method_145(k, "cProxy") != "") || !ckbKhongNhapTaiKhoanDaCo.Checked))
					{
						if (queue.Count == 0)
						{
							break;
						}
						string c = (queue.Dequeue() + "*" + selectedIndex).Replace("'", "''");
						fMain.fMain_0.E38D51B3(k, "cProxy", c);
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

	private void C230C115(object sender, EventArgs e)
	{
		Close();
	}

	private void method_1(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			DDA4BC1E_Click(null, null);
		}
	}

	private void txtProxy_TextChanged(object sender, EventArgs e)
	{
		try
		{
			List<string> e03C713E = txtProxy.Lines.ToList();
			e03C713E = GClass8.smethod_36(e03C713E);
			E4147F29.Text = string.Format(F7AB102E.smethod_0("Danh sa\u0301ch Proxy ({0}):"), e03C713E.Count.ToString());
		}
		catch
		{
		}
	}

	protected override void Dispose(bool DEA09B9E)
	{
		if (DEA09B9E && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(DEA09B9E);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImportProxy));
		F537D68B = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		DDA4BC1E = new System.Windows.Forms.Button();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		label8 = new System.Windows.Forms.Label();
		E4147F29 = new System.Windows.Forms.Label();
		txtProxy = new System.Windows.Forms.RichTextBox();
		label1 = new System.Windows.Forms.Label();
		nudTaiKhoanPerUa = new System.Windows.Forms.NumericUpDown();
		ckbKhongNhapTaiKhoanDaCo = new System.Windows.Forms.CheckBox();
		CF2FF71D = new System.Windows.Forms.Label();
		rbNgauNhien = new System.Windows.Forms.RadioButton();
		rbLanLuot = new System.Windows.Forms.RadioButton();
		label3 = new System.Windows.Forms.Label();
		cbbTypeProxy = new System.Windows.Forms.ComboBox();
		F537D68B.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)nudTaiKhoanPerUa).BeginInit();
		SuspendLayout();
		F537D68B.BackColor = System.Drawing.Color.White;
		F537D68B.BorderRadius = 0;
		F537D68B.BottomSahddow = true;
		F537D68B.color = System.Drawing.Color.SaddleBrown;
		F537D68B.Controls.Add(pnlHeader);
		F537D68B.Dock = System.Windows.Forms.DockStyle.Top;
		F537D68B.LeftSahddow = false;
		F537D68B.Location = new System.Drawing.Point(0, 0);
		F537D68B.Name = "bunifuCards1";
		F537D68B.RightSahddow = true;
		F537D68B.ShadowDepth = 20;
		F537D68B.Size = new System.Drawing.Size(477, 38);
		F537D68B.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(pictureBox1);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(477, 32);
		pnlHeader.TabIndex = 9;
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(4, 1);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 77;
		pictureBox1.TabStop = false;
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
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(477, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Nhâ\u0323p Proxy";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(244, 386);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(C230C115);
		DDA4BC1E.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		DDA4BC1E.Cursor = System.Windows.Forms.Cursors.Hand;
		DDA4BC1E.FlatAppearance.BorderSize = 0;
		DDA4BC1E.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		DDA4BC1E.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		DDA4BC1E.ForeColor = System.Drawing.Color.White;
		DDA4BC1E.Location = new System.Drawing.Point(135, 386);
		DDA4BC1E.Name = "btnAdd";
		DDA4BC1E.Size = new System.Drawing.Size(92, 29);
		DDA4BC1E.TabIndex = 3;
		DDA4BC1E.Text = "Xa\u0301c nhâ\u0323n";
		DDA4BC1E.UseVisualStyleBackColor = false;
		DDA4BC1E.Click += new System.EventHandler(DDA4BC1E_Click);
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		label8.AutoSize = true;
		label8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label8.Location = new System.Drawing.Point(331, 252);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(115, 16);
		label8.TabIndex = 5;
		label8.Text = "(Mỗi proxy 1 dòng)";
		E4147F29.AutoSize = true;
		E4147F29.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E4147F29.Location = new System.Drawing.Point(30, 47);
		E4147F29.Name = "lblStatus";
		E4147F29.Size = new System.Drawing.Size(127, 16);
		E4147F29.TabIndex = 6;
		E4147F29.Text = "Danh sa\u0301ch Proxy (0):";
		txtProxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		txtProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txtProxy.Location = new System.Drawing.Point(34, 66);
		txtProxy.Name = "txtProxy";
		txtProxy.Size = new System.Drawing.Size(409, 181);
		txtProxy.TabIndex = 118;
		txtProxy.Text = "";
		txtProxy.WordWrap = false;
		txtProxy.TextChanged += new System.EventHandler(txtProxy_TextChanged);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(31, 298);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(119, 16);
		label1.TabIndex = 119;
		label1.Text = "Sô\u0301 ta\u0300i khoa\u0309n/proxy:";
		nudTaiKhoanPerUa.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		nudTaiKhoanPerUa.Location = new System.Drawing.Point(157, 296);
		nudTaiKhoanPerUa.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		nudTaiKhoanPerUa.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		nudTaiKhoanPerUa.Name = "nudTaiKhoanPerUa";
		nudTaiKhoanPerUa.Size = new System.Drawing.Size(69, 23);
		nudTaiKhoanPerUa.TabIndex = 120;
		nudTaiKhoanPerUa.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		ckbKhongNhapTaiKhoanDaCo.AutoSize = true;
		ckbKhongNhapTaiKhoanDaCo.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbKhongNhapTaiKhoanDaCo.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		ckbKhongNhapTaiKhoanDaCo.Location = new System.Drawing.Point(33, 349);
		ckbKhongNhapTaiKhoanDaCo.Name = "ckbKhongNhapTaiKhoanDaCo";
		ckbKhongNhapTaiKhoanDaCo.Size = new System.Drawing.Size(283, 20);
		ckbKhongNhapTaiKhoanDaCo.TabIndex = 121;
		ckbKhongNhapTaiKhoanDaCo.Text = "Không nhâ\u0323p va\u0300o như\u0303ng ta\u0300i khoa\u0309n đa\u0303 co\u0301 Proxy";
		ckbKhongNhapTaiKhoanDaCo.UseVisualStyleBackColor = true;
		CF2FF71D.AutoSize = true;
		CF2FF71D.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CF2FF71D.Location = new System.Drawing.Point(30, 325);
		CF2FF71D.Name = "label2";
		CF2FF71D.Size = new System.Drawing.Size(131, 16);
		CF2FF71D.TabIndex = 119;
		CF2FF71D.Text = "Tu\u0300y cho\u0323n nhâ\u0323p Proxy:";
		rbNgauNhien.AutoSize = true;
		rbNgauNhien.Cursor = System.Windows.Forms.Cursors.Hand;
		rbNgauNhien.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		rbNgauNhien.Location = new System.Drawing.Point(246, 323);
		rbNgauNhien.Name = "rbNgauNhien";
		rbNgauNhien.Size = new System.Drawing.Size(89, 20);
		rbNgauNhien.TabIndex = 122;
		rbNgauNhien.Text = "Ngâ\u0303u nhiên";
		rbNgauNhien.UseVisualStyleBackColor = true;
		rbLanLuot.AutoSize = true;
		rbLanLuot.Checked = true;
		rbLanLuot.Cursor = System.Windows.Forms.Cursors.Hand;
		rbLanLuot.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		rbLanLuot.Location = new System.Drawing.Point(157, 323);
		rbLanLuot.Name = "rbLanLuot";
		rbLanLuot.Size = new System.Drawing.Size(71, 20);
		rbLanLuot.TabIndex = 122;
		rbLanLuot.TabStop = true;
		rbLanLuot.Text = "Lâ\u0300n lươ\u0323t";
		rbLanLuot.UseVisualStyleBackColor = true;
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(31, 267);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(70, 16);
		label3.TabIndex = 119;
		label3.Text = "Loa\u0323i Proxy:";
		cbbTypeProxy.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbTypeProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbTypeProxy.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbTypeProxy.FormattingEnabled = true;
		cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		cbbTypeProxy.Location = new System.Drawing.Point(157, 264);
		cbbTypeProxy.Name = "cbbTypeProxy";
		cbbTypeProxy.Size = new System.Drawing.Size(140, 24);
		cbbTypeProxy.TabIndex = 123;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(477, 432);
		base.Controls.Add(cbbTypeProxy);
		base.Controls.Add(rbLanLuot);
		base.Controls.Add(rbNgauNhien);
		base.Controls.Add(ckbKhongNhapTaiKhoanDaCo);
		base.Controls.Add(nudTaiKhoanPerUa);
		base.Controls.Add(CF2FF71D);
		base.Controls.Add(label3);
		base.Controls.Add(label1);
		base.Controls.Add(txtProxy);
		base.Controls.Add(label8);
		base.Controls.Add(E4147F29);
		base.Controls.Add(btnCancel);
		base.Controls.Add(DDA4BC1E);
		base.Controls.Add(F537D68B);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fImportProxy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		F537D68B.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)nudTaiKhoanPerUa).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
