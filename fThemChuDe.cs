using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fThemChuDe : Form
{
	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel panel1;

	private BunifuDragControl bunifuDragControl_0;

	private ToolTip A433318B;

	private BunifuCards bunifuCards2;

	private Panel pnlHeader;

	private Button C18426A7;

	private PictureBox FA32BD88;

	private Button btnMinimize;

	private BunifuCustomLabel A199AF0C;

	private ContextMenuStrip DC37A633;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private Label DFA57036;

	private Button btnCancel;

	private Button btnAdd;

	private TextBox FDA7B418;

	public fThemChuDe()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void C22475AE(object sender, EventArgs e)
	{
		Close();
	}

	private void fThemChuDe_Load(object sender, EventArgs e)
	{
	}

	private void FCAF0A03(object sender, EventArgs e)
	{
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void C18426A7_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		List<string> list = Class15.smethod_20();
		string text = FDA7B418.Text;
		if (text == "")
		{
			GClass29.smethod_0("Vui lòng nhập tên chủ đề mới!", 2);
		}
		else if (!list.Contains(text))
		{
			Class15.E4044697(text);
			if (GClass29.smethod_1("Thêm thành công, bạn có muốn đóng cửa sổ?") == DialogResult.Yes)
			{
				Close();
			}
		}
		else
		{
			GClass29.smethod_0("Tên chủ đề đã tồn tại, vui lòng đổi tên khác!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool F33386A8)
	{
		if (F33386A8 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F33386A8);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		panel1 = new System.Windows.Forms.Panel();
		DFA57036 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		btnAdd = new System.Windows.Forms.Button();
		FDA7B418 = new System.Windows.Forms.TextBox();
		bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		C18426A7 = new System.Windows.Forms.Button();
		FA32BD88 = new System.Windows.Forms.PictureBox();
		btnMinimize = new System.Windows.Forms.Button();
		A199AF0C = new Bunifu.Framework.UI.BunifuCustomLabel();
		DC37A633 = new System.Windows.Forms.ContextMenuStrip(icontainer_0);
		toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A433318B = new System.Windows.Forms.ToolTip(icontainer_0);
		panel1.SuspendLayout();
		bunifuCards2.SuspendLayout();
		pnlHeader.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)FA32BD88).BeginInit();
		DC37A633.SuspendLayout();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 5;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(0, 47);
		bunifuCards1.TabIndex = 12;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(DFA57036);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(btnAdd);
		panel1.Controls.Add(FDA7B418);
		panel1.Controls.Add(bunifuCards2);
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(329, 138);
		panel1.TabIndex = 37;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		DFA57036.AutoSize = true;
		DFA57036.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		DFA57036.Location = new System.Drawing.Point(28, 53);
		DFA57036.Name = "label2";
		DFA57036.Size = new System.Drawing.Size(77, 16);
		DFA57036.TabIndex = 47;
		DFA57036.Text = "Tên chủ đề:";
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(167, 94);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 46;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		btnAdd.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnAdd.ForeColor = System.Drawing.Color.White;
		btnAdd.Location = new System.Drawing.Point(63, 94);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new System.Drawing.Size(92, 29);
		btnAdd.TabIndex = 45;
		btnAdd.Text = "Thêm";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += new System.EventHandler(btnAdd_Click);
		FDA7B418.Lines = new string[0];
		FDA7B418.Location = new System.Drawing.Point(111, 50);
		FDA7B418.MaxLength = 32767;
		FDA7B418.Name = "txtChuDe";
		FDA7B418.PasswordChar = '\0';
		FDA7B418.ScrollBars = System.Windows.Forms.ScrollBars.None;
		FDA7B418.SelectedText = "";
		FDA7B418.SelectionLength = 0;
		FDA7B418.SelectionStart = 0;
		FDA7B418.ShortcutsEnabled = true;
		FDA7B418.Size = new System.Drawing.Size(180, 23);
		FDA7B418.TabIndex = 44;
		bunifuCards2.BackColor = System.Drawing.Color.White;
		bunifuCards2.BorderRadius = 0;
		bunifuCards2.BottomSahddow = true;
		bunifuCards2.color = System.Drawing.Color.SaddleBrown;
		bunifuCards2.Controls.Add(pnlHeader);
		bunifuCards2.Dock = System.Windows.Forms.DockStyle.Top;
		bunifuCards2.LeftSahddow = false;
		bunifuCards2.Location = new System.Drawing.Point(0, 0);
		bunifuCards2.Name = "bunifuCards2";
		bunifuCards2.RightSahddow = true;
		bunifuCards2.ShadowDepth = 20;
		bunifuCards2.Size = new System.Drawing.Size(327, 37);
		bunifuCards2.TabIndex = 43;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(C18426A7);
		pnlHeader.Controls.Add(FA32BD88);
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(A199AF0C);
		pnlHeader.Cursor = System.Windows.Forms.Cursors.SizeAll;
		pnlHeader.Location = new System.Drawing.Point(0, 3);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(327, 31);
		pnlHeader.TabIndex = 9;
		C18426A7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		C18426A7.Cursor = System.Windows.Forms.Cursors.Hand;
		C18426A7.FlatAppearance.BorderSize = 0;
		C18426A7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		C18426A7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C18426A7.ForeColor = System.Drawing.Color.White;
		C18426A7.Image = C50FB39E.Bitmap_12;
		C18426A7.Location = new System.Drawing.Point(296, 1);
		C18426A7.Name = "button2";
		C18426A7.Size = new System.Drawing.Size(30, 30);
		C18426A7.TabIndex = 77;
		C18426A7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		C18426A7.UseVisualStyleBackColor = true;
		C18426A7.Click += new System.EventHandler(C18426A7_Click);
		FA32BD88.Cursor = System.Windows.Forms.Cursors.Default;
		FA32BD88.Image = C50FB39E.Bitmap_5;
		FA32BD88.Location = new System.Drawing.Point(3, 2);
		FA32BD88.Name = "pictureBox1";
		FA32BD88.Size = new System.Drawing.Size(34, 27);
		FA32BD88.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		FA32BD88.TabIndex = 76;
		FA32BD88.TabStop = false;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Location = new System.Drawing.Point(899, 1);
		btnMinimize.Name = "btnMinimize";
		btnMinimize.Size = new System.Drawing.Size(30, 30);
		btnMinimize.TabIndex = 9;
		btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		btnMinimize.UseVisualStyleBackColor = true;
		A199AF0C.BackColor = System.Drawing.Color.Transparent;
		A199AF0C.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A199AF0C.Dock = System.Windows.Forms.DockStyle.Fill;
		A199AF0C.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A199AF0C.ForeColor = System.Drawing.Color.Black;
		A199AF0C.Location = new System.Drawing.Point(0, 0);
		A199AF0C.Name = "bunifuCustomLabel1";
		A199AF0C.Size = new System.Drawing.Size(327, 31);
		A199AF0C.TabIndex = 12;
		A199AF0C.Text = "Thêm chủ đề";
		A199AF0C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		DC37A633.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { toolStripMenuItem_0, toolStripMenuItem_1, toolStripMenuItem_2 });
		DC37A633.Name = "contextMenuStrip1";
		DC37A633.Size = new System.Drawing.Size(153, 70);
		toolStripMenuItem_0.Name = "thêmMớiToolStripMenuItem";
		toolStripMenuItem_0.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_0.Text = "Thêm chủ đề";
		toolStripMenuItem_1.Name = "sửaToolStripMenuItem";
		toolStripMenuItem_1.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_1.Text = "Sửa tên chủ đề";
		toolStripMenuItem_2.Name = "xóaToolStripMenuItem";
		toolStripMenuItem_2.Size = new System.Drawing.Size(152, 22);
		toolStripMenuItem_2.Text = "Xóa chủ đề";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = A199AF0C;
		bunifuDragControl_0.Vertical = true;
		A433318B.AutomaticDelay = 0;
		A433318B.AutoPopDelay = 10000;
		A433318B.InitialDelay = 200;
		A433318B.ReshowDelay = 40;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(329, 138);
		base.Controls.Add(panel1);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fThemChuDe";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình chung";
		base.Load += new System.EventHandler(fThemChuDe_Load);
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		bunifuCards2.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)FA32BD88).EndInit();
		DC37A633.ResumeLayout(false);
		ResumeLayout(false);
	}
}
