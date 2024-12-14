using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucTuongTacReel : UserControl
{
	private GClass11 gclass11_0;

	private IContainer FF97D416 = null;

	private Button btnSave;

	private Button B0197634;

	private Panel plComment;

	private RichTextBox txtComment;

	private Label DD15A21D;

	private CheckBox ckbComment;

	private CheckBox ckbShareWall;

	private CheckBox B7092C04;

	private NumericUpDown D3AE7C99;

	private NumericUpDown EB84502B;

	private Label D31A1DB1;

	private Label B4AFCA02;

	private Label label21;

	private Label C2A30CB9;

	private Label F896B51C;

	private ComboBox cbbTuyChonNoiDung;

	private Button btnHuongDanNhapNoiDung;

	public ucTuongTacReel(GClass11 gclass11_1)
	{
		CF396193();
		F7AB102E.D6B70A35(this);
		gclass11_0 = gclass11_1;
	}

	private void B0197634_Click(object sender, EventArgs e)
	{
		Hide();
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		method_1();
		Hide();
	}

	private void method_0()
	{
		List<string> list_ = new List<string> { "Nội dung chỉ có 1 dòng", "Nội dung có nhiều dòng" };
		GClass8.smethod_22(cbbTuyChonNoiDung, list_);
	}

	private void DE2048B9()
	{
		try
		{
			method_0();
			EB84502B.Value = gclass11_0.method_2("nudTimeFrom", 15);
			D3AE7C99.Value = gclass11_0.method_2("nudTimeTo", 30);
			B7092C04.Checked = gclass11_0.method_3("ckbInteract");
			ckbComment.Checked = gclass11_0.method_3("ckbComment");
			ckbShareWall.Checked = gclass11_0.method_3("ckbShareWall");
			txtComment.Text = gclass11_0.C0288288("txtComment");
			cbbTuyChonNoiDung.SelectedIndex = gclass11_0.method_2("typeNganCachCommentReel");
			ckbComment_CheckedChanged(null, null);
		}
		catch
		{
		}
	}

	private void method_1()
	{
		gclass11_0.method_4("nudTimeFrom", EB84502B.Value);
		gclass11_0.method_4("nudTimeTo", D3AE7C99.Value);
		gclass11_0.method_4("ckbInteract", B7092C04.Checked);
		gclass11_0.method_4("ckbShareWall", ckbShareWall.Checked);
		gclass11_0.method_4("ckbComment", ckbComment.Checked);
		gclass11_0.method_4("txtComment", txtComment.Text.Trim());
		gclass11_0.method_4("typeNganCachCommentReel", cbbTuyChonNoiDung.SelectedIndex);
	}

	private void C3A71206(object sender, EventArgs e)
	{
		DE2048B9();
	}

	private void FF3EBD28(object sender, EventArgs e)
	{
		if (base.Visible)
		{
			DE2048B9();
		}
	}

	private void ckbComment_CheckedChanged(object sender, EventArgs e)
	{
		plComment.Enabled = ckbComment.Checked;
	}

	private void txtComment_TextChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, DD15A21D, cbbTuyChonNoiDung.SelectedIndex);
	}

	private void method_2(object sender, EventArgs e)
	{
		GClass29.smethod_0(F7AB102E.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!"));
		txtComment.Focus();
	}

	private void A83A952A(object sender, EventArgs e)
	{
		GClass8.smethod_33(new fHelpNhapComment());
		txtComment.Focus();
	}

	private void btnHuongDanNhapNoiDung_Click(object sender, EventArgs e)
	{
		if (cbbTuyChonNoiDung.SelectedIndex == 0)
		{
			GClass29.smethod_0("Vui lòng nhập mỗi dòng là 1 nội dung!");
		}
		else
		{
			GClass8.smethod_33(new fHelpNhapComment());
		}
		txtComment.Focus();
	}

	private void cbbTuyChonNoiDung_SelectedIndexChanged(object sender, EventArgs e)
	{
		GClass8.smethod_60(txtComment, DD15A21D, cbbTuyChonNoiDung.SelectedIndex);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && FF97D416 != null)
		{
			FF97D416.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void CF396193()
	{
		btnSave = new Button();
		B0197634 = new Button();
		plComment = new Panel();
		C2A30CB9 = new Label();
		F896B51C = new Label();
		txtComment = new RichTextBox();
		DD15A21D = new Label();
		ckbComment = new CheckBox();
		ckbShareWall = new CheckBox();
		B7092C04 = new CheckBox();
		D3AE7C99 = new NumericUpDown();
		EB84502B = new NumericUpDown();
		D31A1DB1 = new Label();
		B4AFCA02 = new Label();
		label21 = new Label();
		cbbTuyChonNoiDung = new ComboBox();
		btnHuongDanNhapNoiDung = new Button();
		plComment.SuspendLayout();
		((ISupportInitialize)D3AE7C99).BeginInit();
		((ISupportInitialize)EB84502B).BeginInit();
		SuspendLayout();
		btnSave.Anchor = AnchorStyles.Bottom;
		btnSave.BackColor = Color.FromArgb(53, 120, 229);
		btnSave.Cursor = Cursors.Hand;
		btnSave.FlatAppearance.BorderSize = 0;
		btnSave.FlatStyle = FlatStyle.Flat;
		btnSave.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnSave.ForeColor = Color.White;
		btnSave.Location = new Point(71, 383);
		btnSave.Name = "btnSave";
		btnSave.Size = new Size(92, 29);
		btnSave.TabIndex = 180;
		btnSave.Text = "Lưu";
		btnSave.UseVisualStyleBackColor = false;
		btnSave.Click += btnSave_Click;
		B0197634.Anchor = AnchorStyles.Bottom;
		B0197634.BackColor = Color.Maroon;
		B0197634.Cursor = Cursors.Hand;
		B0197634.FlatAppearance.BorderSize = 0;
		B0197634.FlatStyle = FlatStyle.Flat;
		B0197634.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B0197634.ForeColor = Color.White;
		B0197634.Location = new Point(181, 383);
		B0197634.Name = "btnCancel";
		B0197634.Size = new Size(92, 29);
		B0197634.TabIndex = 181;
		B0197634.Text = "Đóng";
		B0197634.UseVisualStyleBackColor = false;
		B0197634.Click += B0197634_Click;
		plComment.BorderStyle = BorderStyle.FixedSingle;
		plComment.Controls.Add(cbbTuyChonNoiDung);
		plComment.Controls.Add(btnHuongDanNhapNoiDung);
		plComment.Controls.Add(C2A30CB9);
		plComment.Controls.Add(F896B51C);
		plComment.Controls.Add(txtComment);
		plComment.Controls.Add(DD15A21D);
		plComment.Location = new Point(37, 98);
		plComment.Name = "plComment";
		plComment.Size = new Size(278, 268);
		plComment.TabIndex = 187;
		C2A30CB9.AutoSize = true;
		C2A30CB9.Location = new Point(2, 240);
		C2A30CB9.Name = "label3";
		C2A30CB9.Size = new Size(64, 16);
		C2A30CB9.TabIndex = 181;
		C2A30CB9.Text = "Tùy chọn:";
		F896B51C.AutoSize = true;
		F896B51C.Location = new Point(3, 218);
		F896B51C.Name = "label11";
		F896B51C.Size = new Size(133, 16);
		F896B51C.TabIndex = 180;
		F896B51C.Text = "Spin nội dung {a|b|c}";
		txtComment.Location = new Point(6, 24);
		txtComment.Name = "txtComment";
		txtComment.Size = new Size(264, 191);
		txtComment.TabIndex = 45;
		txtComment.Text = "";
		txtComment.WordWrap = false;
		txtComment.TextChanged += txtComment_TextChanged;
		DD15A21D.AutoSize = true;
		DD15A21D.Location = new Point(3, 5);
		DD15A21D.Name = "lblComment";
		DD15A21D.Size = new Size(139, 16);
		DD15A21D.TabIndex = 0;
		DD15A21D.Text = "Nội dung bình luận (0):";
		ckbComment.AutoSize = true;
		ckbComment.Cursor = Cursors.Hand;
		ckbComment.Location = new Point(19, 72);
		ckbComment.Name = "ckbComment";
		ckbComment.Size = new Size(81, 20);
		ckbComment.TabIndex = 186;
		ckbComment.Text = "Comment";
		ckbComment.UseVisualStyleBackColor = true;
		ckbComment.CheckedChanged += ckbComment_CheckedChanged;
		ckbShareWall.AutoSize = true;
		ckbShareWall.Cursor = Cursors.Hand;
		ckbShareWall.Location = new Point(121, 46);
		ckbShareWall.Name = "ckbShareWall";
		ckbShareWall.Size = new Size(89, 20);
		ckbShareWall.TabIndex = 185;
		ckbShareWall.Text = "Share Wall";
		ckbShareWall.UseVisualStyleBackColor = true;
		B7092C04.AutoSize = true;
		B7092C04.Cursor = Cursors.Hand;
		B7092C04.Location = new Point(19, 46);
		B7092C04.Name = "ckbInteract";
		B7092C04.Size = new Size(48, 20);
		B7092C04.TabIndex = 184;
		B7092C04.Text = "Like";
		B7092C04.UseVisualStyleBackColor = true;
		D3AE7C99.Location = new Point(218, 17);
		D3AE7C99.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		D3AE7C99.Name = "nudTimeTo";
		D3AE7C99.Size = new Size(56, 23);
		D3AE7C99.TabIndex = 183;
		EB84502B.Location = new Point(121, 17);
		EB84502B.Maximum = new decimal(new int[4] { 999999, 0, 0, 0 });
		EB84502B.Name = "nudTimeFrom";
		EB84502B.Size = new Size(56, 23);
		EB84502B.TabIndex = 182;
		D31A1DB1.Location = new Point(183, 19);
		D31A1DB1.Name = "label13";
		D31A1DB1.Size = new Size(29, 16);
		D31A1DB1.TabIndex = 190;
		D31A1DB1.Text = "đê\u0301n";
		D31A1DB1.TextAlign = ContentAlignment.MiddleCenter;
		B4AFCA02.AutoSize = true;
		B4AFCA02.Location = new Point(279, 19);
		B4AFCA02.Name = "label14";
		B4AFCA02.Size = new Size(30, 16);
		B4AFCA02.TabIndex = 189;
		B4AFCA02.Text = "giây";
		label21.AutoSize = true;
		label21.Location = new Point(16, 19);
		label21.Name = "label21";
		label21.Size = new Size(93, 16);
		label21.TabIndex = 188;
		label21.Text = "Thơ\u0300i gian xem:";
		cbbTuyChonNoiDung.Cursor = Cursors.Hand;
		cbbTuyChonNoiDung.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTuyChonNoiDung.FormattingEnabled = true;
		cbbTuyChonNoiDung.Location = new Point(68, 237);
		cbbTuyChonNoiDung.Name = "cbbTuyChonNoiDung";
		cbbTuyChonNoiDung.Size = new Size(170, 24);
		cbbTuyChonNoiDung.TabIndex = 184;
		cbbTuyChonNoiDung.SelectedIndexChanged += cbbTuyChonNoiDung_SelectedIndexChanged;
		btnHuongDanNhapNoiDung.Cursor = Cursors.Hand;
		btnHuongDanNhapNoiDung.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnHuongDanNhapNoiDung.Location = new Point(244, 236);
		btnHuongDanNhapNoiDung.Name = "btnHuongDanNhapNoiDung";
		btnHuongDanNhapNoiDung.Size = new Size(26, 26);
		btnHuongDanNhapNoiDung.TabIndex = 183;
		btnHuongDanNhapNoiDung.Text = "?";
		btnHuongDanNhapNoiDung.UseVisualStyleBackColor = true;
		btnHuongDanNhapNoiDung.Click += btnHuongDanNhapNoiDung_Click;
		base.AutoScaleMode = AutoScaleMode.None;
		BackColor = Color.White;
		base.BorderStyle = BorderStyle.FixedSingle;
		base.Controls.Add(plComment);
		base.Controls.Add(ckbComment);
		base.Controls.Add(ckbShareWall);
		base.Controls.Add(B7092C04);
		base.Controls.Add(D3AE7C99);
		base.Controls.Add(EB84502B);
		base.Controls.Add(D31A1DB1);
		base.Controls.Add(B4AFCA02);
		base.Controls.Add(label21);
		base.Controls.Add(btnSave);
		base.Controls.Add(B0197634);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Name = "ucTuongTacReel";
		base.Size = new Size(340, 425);
		base.Load += C3A71206;
		base.VisibleChanged += FF3EBD28;
		plComment.ResumeLayout(performLayout: false);
		plComment.PerformLayout();
		((ISupportInitialize)D3AE7C99).EndInit();
		((ISupportInitialize)EB84502B).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
