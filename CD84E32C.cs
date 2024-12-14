using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class CD84E32C : Form
{
	public string string_0 = "";

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel EB898D10;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button btnAdd;

	private Label CE81160E;

	private BunifuDragControl bunifuDragControl_0;

	private TextBox txtPassword;

	public CD84E32C()
	{
		ECA8B091();
		FBA64D0A();
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void FBA64D0A()
	{
		F7AB102E.smethod_1(bunifuCustomLabel1);
		F7AB102E.smethod_1(CE81160E);
		F7AB102E.smethod_1(btnAdd);
		F7AB102E.smethod_1(btnCancel);
	}

	private void E51AD78E(object sender, EventArgs e)
	{
		string_0 = txtPassword.Text.Trim();
		if (string_0 == "")
		{
			GClass29.smethod_0("Mật khẩu không được để trống!", 3);
		}
		else
		{
			Close();
		}
	}

	private void EE0FD03D(object sender, EventArgs e)
	{
		Close();
	}

	protected override void Dispose(bool C721142B)
	{
		if (C721142B && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(C721142B);
	}

	private void ECA8B091()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CD84E32C));
		bunifuCards1 = new BunifuCards();
		EB898D10 = new Panel();
		btnMinimize = new Button();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		btnCancel = new Button();
		btnAdd = new Button();
		CE81160E = new Label();
		bunifuDragControl_0 = new BunifuDragControl(icontainer_0);
		txtPassword = new TextBox();
		bunifuCards1.SuspendLayout();
		EB898D10.SuspendLayout();
		SuspendLayout();
		bunifuCards1.BackColor = Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = Color.SaddleBrown;
		bunifuCards1.Controls.Add(EB898D10);
		bunifuCards1.Dock = DockStyle.Top;
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new Size(353, 38);
		bunifuCards1.TabIndex = 0;
		EB898D10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		EB898D10.BackColor = Color.White;
		EB898D10.Controls.Add(btnMinimize);
		EB898D10.Controls.Add(bunifuCustomLabel1);
		EB898D10.Location = new Point(0, 5);
		EB898D10.Name = "pnlHeader";
		EB898D10.Size = new Size(353, 32);
		EB898D10.TabIndex = 9;
		btnMinimize.Cursor = Cursors.Hand;
		btnMinimize.Dock = DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = FlatStyle.Flat;
		btnMinimize.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = Color.White;
		btnMinimize.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		btnMinimize.Location = new Point(321, 0);
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
		bunifuCustomLabel1.Size = new Size(353, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Vui lòng nhập mật khẩu!";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		btnCancel.Anchor = AnchorStyles.Bottom;
		btnCancel.BackColor = Color.Maroon;
		btnCancel.Cursor = Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = FlatStyle.Flat;
		btnCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnCancel.ForeColor = Color.White;
		btnCancel.Location = new Point(183, 104);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += EE0FD03D;
		btnAdd.Anchor = AnchorStyles.Bottom;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(75, 104);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 3;
		btnAdd.Text = "Xa\u0301c nhâ\u0323n";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += E51AD78E;
		CE81160E.AutoSize = true;
		CE81160E.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 163);
		CE81160E.Location = new Point(20, 66);
		CE81160E.Name = "label1";
		CE81160E.Size = new Size(98, 16);
		CE81160E.TabIndex = 20;
		CE81160E.Text = "Nhập mật khẩu:";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		txtPassword.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txtPassword.Location = new Point(120, 63);
		txtPassword.Name = "txtPassword";
		txtPassword.Size = new Size(208, 23);
		txtPassword.TabIndex = 21;
		txtPassword.UseSystemPasswordChar = true;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(353, 145);
		base.Controls.Add(txtPassword);
		base.Controls.Add(CE81160E);
		base.Controls.Add(btnCancel);
		base.Controls.Add(btnAdd);
		base.Controls.Add(bunifuCards1);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fConfirmPassword";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "`";
		bunifuCards1.ResumeLayout(performLayout: false);
		EB898D10.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
