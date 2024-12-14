using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fCauHinhDebug : Form
{
	private IContainer C6B2B6A0 = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel C00DC20A;

	private Button btnMinimize;

	private Button EC0C1BBB;

	private Button btnAdd;

	private BunifuDragControl C10D4B18;

	private PictureBox CF073BAE;

	private CheckBox A80E453F;

	private TextBox D22525AC;

	private Panel plFilePath;

	private Label label21;

	private CheckBox ckbModeDev;

	private CheckBox C7329109;

	private CheckBox ckbDebugWelike;

	public fCauHinhDebug()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void AB930B26(object sender, EventArgs e)
	{
		GClass25.smethod_0("configDebug").method_4("ckbModeDev", ckbModeDev.Checked);
		GClass25.smethod_0("configDebug").method_4("ckbUseScriptFile", A80E453F.Checked);
		GClass25.smethod_0("configDebug").method_4("txtFilePath", D22525AC.Text);
		GClass25.smethod_0("configDebug").method_4("ckbLogWelike", C7329109.Checked);
		GClass25.smethod_0("configDebug").method_4("ckbDebugWelike", ckbDebugWelike.Checked);
		GClass25.B3B73732("configDebug");
		if (GClass29.smethod_1("Lưu thành công, ba\u0323n co\u0301 muô\u0301n đo\u0301ng cư\u0309a sô\u0309?") == DialogResult.Yes)
		{
			Close();
		}
	}

	private void E5931DB0(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void D90ADB0E(object sender, EventArgs e)
	{
		ckbModeDev.Checked = GClass25.smethod_0("configDebug").method_3("ckbModeDev");
		A80E453F.Checked = GClass25.smethod_0("configDebug").method_3("ckbUseScriptFile");
		D22525AC.Text = GClass25.smethod_0("configDebug").C0288288("txtFilePath");
		C7329109.Checked = GClass25.smethod_0("configDebug").method_3("ckbLogWelike");
		ckbDebugWelike.Checked = GClass25.smethod_0("configDebug").method_3("ckbDebugWelike");
		A80E453F_CheckedChanged(null, null);
	}

	private void A80E453F_CheckedChanged(object sender, EventArgs e)
	{
		plFilePath.Enabled = A80E453F.Checked;
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && C6B2B6A0 != null)
		{
			C6B2B6A0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		C6B2B6A0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCauHinhDebug));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		CF073BAE = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		C00DC20A = new Bunifu.Framework.UI.BunifuCustomLabel();
		EC0C1BBB = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		C10D4B18 = new Bunifu.Framework.UI.BunifuDragControl(C6B2B6A0);
		A80E453F = new System.Windows.Forms.CheckBox();
		D22525AC = new System.Windows.Forms.TextBox();
		plFilePath = new System.Windows.Forms.Panel();
		label21 = new System.Windows.Forms.Label();
		ckbModeDev = new System.Windows.Forms.CheckBox();
		C7329109 = new System.Windows.Forms.CheckBox();
		ckbDebugWelike = new System.Windows.Forms.CheckBox();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)CF073BAE).BeginInit();
		plFilePath.SuspendLayout();
		SuspendLayout();
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(pnlHeader);
		bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(445, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(CF073BAE);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(C00DC20A);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(445, 32);
		pnlHeader.TabIndex = 9;
		CF073BAE.Cursor = System.Windows.Forms.Cursors.Default;
		CF073BAE.Image = C50FB39E.Bitmap_5;
		CF073BAE.Location = new System.Drawing.Point(3, 2);
		CF073BAE.Name = "pictureBox1";
		CF073BAE.Size = new System.Drawing.Size(34, 27);
		CF073BAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		CF073BAE.TabIndex = 17;
		CF073BAE.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(413, 0);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(32, 32);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		btnMinimize.Click += new System.EventHandler(btnMinimize_Click);
		C00DC20A.BackColor = System.Drawing.Color.Transparent;
		C00DC20A.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C00DC20A.Dock = System.Windows.Forms.DockStyle.Fill;
		C00DC20A.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		C00DC20A.ForeColor = System.Drawing.Color.Black;
		C00DC20A.Location = new System.Drawing.Point(0, 0);
		C00DC20A.Name = "bunifuCustomLabel1";
		C00DC20A.Size = new System.Drawing.Size(445, 32);
		C00DC20A.TabIndex = 1;
		C00DC20A.Text = "Câ\u0301u hi\u0300nh Debug";
		C00DC20A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		EC0C1BBB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		EC0C1BBB.BackColor = System.Drawing.Color.Maroon;
		EC0C1BBB.Cursor = System.Windows.Forms.Cursors.Hand;
		EC0C1BBB.FlatAppearance.BorderSize = 0;
		EC0C1BBB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		EC0C1BBB.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		EC0C1BBB.ForeColor = System.Drawing.Color.White;
		EC0C1BBB.Location = new System.Drawing.Point(230, 171);
		EC0C1BBB.Name = "btnCancel";
		EC0C1BBB.Size = new System.Drawing.Size(92, 29);
		EC0C1BBB.TabIndex = 4;
		EC0C1BBB.Text = "Đo\u0301ng";
		EC0C1BBB.UseVisualStyleBackColor = false;
		EC0C1BBB.Click += new System.EventHandler(E5931DB0);
		btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(126, 171);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(AB930B26);
		C10D4B18.Fixed = true;
		C10D4B18.Horizontal = true;
		C10D4B18.TargetControl = C00DC20A;
		C10D4B18.Vertical = true;
		A80E453F.AutoSize = true;
		A80E453F.Cursor = System.Windows.Forms.Cursors.Hand;
		A80E453F.Location = new System.Drawing.Point(50, 84);
		A80E453F.Name = "ckbUseScriptFile";
		A80E453F.Size = new System.Drawing.Size(130, 20);
		A80E453F.TabIndex = 5;
		A80E453F.Text = "Sử dụng file script";
		A80E453F.UseVisualStyleBackColor = true;
		A80E453F.CheckedChanged += new System.EventHandler(A80E453F_CheckedChanged);
		D22525AC.Location = new System.Drawing.Point(67, 1);
		D22525AC.Name = "txtFilePath";
		D22525AC.Size = new System.Drawing.Size(240, 23);
		D22525AC.TabIndex = 6;
		plFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plFilePath.Controls.Add(label21);
		plFilePath.Controls.Add(D22525AC);
		plFilePath.Location = new System.Drawing.Point(70, 106);
		plFilePath.Name = "plFilePath";
		plFilePath.Size = new System.Drawing.Size(310, 27);
		plFilePath.TabIndex = 8;
		label21.AutoSize = true;
		label21.Location = new System.Drawing.Point(3, 3);
		label21.Name = "label21";
		label21.Size = new System.Drawing.Size(61, 16);
		label21.TabIndex = 49;
		label21.Text = "File path:";
		ckbModeDev.AutoSize = true;
		ckbModeDev.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbModeDev.Location = new System.Drawing.Point(50, 58);
		ckbModeDev.Name = "ckbModeDev";
		ckbModeDev.Size = new System.Drawing.Size(110, 20);
		ckbModeDev.TabIndex = 5;
		ckbModeDev.Text = "Bật chế độ dev";
		ckbModeDev.UseVisualStyleBackColor = true;
		C7329109.AutoSize = true;
		C7329109.Cursor = System.Windows.Forms.Cursors.Hand;
		C7329109.Location = new System.Drawing.Point(50, 139);
		C7329109.Name = "ckbLogWelike";
		C7329109.Size = new System.Drawing.Size(140, 20);
		C7329109.TabIndex = 5;
		C7329109.Text = "Xuất log getjobs fail";
		C7329109.UseVisualStyleBackColor = true;
		ckbDebugWelike.AutoSize = true;
		ckbDebugWelike.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbDebugWelike.Location = new System.Drawing.Point(230, 139);
		ckbDebugWelike.Name = "ckbDebugWelike";
		ckbDebugWelike.Size = new System.Drawing.Size(104, 20);
		ckbDebugWelike.TabIndex = 5;
		ckbDebugWelike.Text = "Debug Welike";
		ckbDebugWelike.UseVisualStyleBackColor = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(445, 213);
		base.Controls.Add(plFilePath);
		base.Controls.Add(ckbDebugWelike);
		base.Controls.Add(C7329109);
		base.Controls.Add(ckbModeDev);
		base.Controls.Add(A80E453F);
		base.Controls.Add(EC0C1BBB);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCauHinhDebug";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(D90ADB0E);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)CF073BAE).EndInit();
		plFilePath.ResumeLayout(false);
		plFilePath.PerformLayout();
		ResumeLayout(false);
		PerformLayout();
	}
}
