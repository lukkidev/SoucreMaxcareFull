using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fUpdateData : Form
{
	private fMain fMain_0;

	private IContainer icontainer_0 = null;

	private BunifuCards C30DA090;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button B03093B1;

	private ComboBox cbbTypeUpdate;

	private Label A404F18A;

	private TextBox txbData;

	private Label label2;

	private Button B93B940B;

	private Button btnAdd;

	private PictureBox B62D9792;

	private Label label3;

	private ComboBox cbbTypeProxy;

	private ComboBox F1B01C82;

	private CheckBox ckbFbBlock;

	public fUpdateData(fMain B2AC4731, string string_0)
	{
		AD2A9E31();
		fMain_0 = B2AC4731;
		cbbTypeUpdate.Text = string_0;
		cbbTypeProxy.SelectedIndex = 0;
		F7AB102E.D6B70A35(this);
	}

	private void B03093B1_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void B93B940B_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		try
		{
			bool flag = false;
			if (cbbTypeUpdate.Text != "Tình trạng" && cbbTypeUpdate.Text != "Fb Block" && (txbData.Text.Equals("") || txbData.Text.Equals(" |")))
			{
				if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Ba\u0323n co\u0301 chă\u0301c muô\u0301n xo\u0301a dư\u0303 liê\u0323u của {0} tài khoản?"), fMain_0.method_136())) == DialogResult.Yes)
				{
					flag = true;
				}
			}
			else if (GClass29.smethod_1(string.Format(F7AB102E.smethod_0("Ba\u0323n co\u0301 chă\u0301c muô\u0301n câ\u0323p nhâ\u0323t dư\u0303 liê\u0323u của {0} tài khoản?"), fMain_0.method_136())) == DialogResult.Yes)
			{
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			List<string> list = new List<string>();
			string text = txbData.Text;
			for (int i = 0; i < fMain_0.dtgvAcc.Rows.Count; i++)
			{
				if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[i].Cells["cChose"].Value))
				{
					list.Add(fMain_0.method_145(i, "cId"));
				}
			}
			string text2 = cbbTypeUpdate.Text;
			string text3 = text2;
			switch (C43AF739.smethod_0(text3))
			{
			case 267393898u:
			{
				if (!(text3 == "Notes") || !Class15.DB0FC1AC(list, "ghiChu", text))
				{
					break;
				}
				for (int l = 0; l < fMain_0.dtgvAcc.Rows.Count; l++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[l].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(l, "cGhiChu", text);
					}
				}
				break;
			}
			case 96026087u:
			{
				if (!(text3 == "Mail|pass"))
				{
					break;
				}
				if (text.Split('|').Length != 2)
				{
					GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p la\u0323i đi\u0323nh da\u0323ng Mail|Pass Mail!", 3);
					return;
				}
				if (!Class15.A49A61BA(list, "email|passmail", text))
				{
					break;
				}
				for (int num11 = 0; num11 < fMain_0.dtgvAcc.Rows.Count; num11++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num11].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num11, "cEmail", text.Split('|')[0]);
						fMain_0.E38D51B3(num11, "cPassMail", text.Split('|')[1]);
					}
				}
				break;
			}
			case 976575442u:
			{
				if (!(text3 == "Token") || !Class15.DB0FC1AC(list, "token", text))
				{
					break;
				}
				for (int num10 = 0; num10 < fMain_0.dtgvAcc.Rows.Count; num10++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num10].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num10, "cToken", text);
					}
				}
				break;
			}
			case 750979128u:
			{
				if (!(text3 == "Password") || !Class15.DB0FC1AC(list, "pass", text))
				{
					break;
				}
				for (int num6 = 0; num6 < fMain_0.dtgvAcc.Rows.Count; num6++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num6].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num6, "cPassword", text);
					}
				}
				break;
			}
			case 1335761915u:
			{
				if (!(text3 == "Proxy"))
				{
					break;
				}
				int selectedIndex = cbbTypeProxy.SelectedIndex;
				string text5 = ((text == "") ? "" : (text + "*" + selectedIndex));
				if (!Class15.DB0FC1AC(list, "proxy", text5))
				{
					break;
				}
				for (int num13 = 0; num13 < fMain_0.dtgvAcc.Rows.Count; num13++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num13].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num13, "cProxy", text5);
					}
				}
				break;
			}
			case 1227920463u:
			{
				if (!(text3 == "Phone") || !Class15.A49A61BA(list, "phone", text))
				{
					break;
				}
				for (int num2 = 0; num2 < fMain_0.dtgvAcc.Rows.Count; num2++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num2].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num2, "cPhone", text.Split('|')[0]);
					}
				}
				break;
			}
			case 1802569846u:
			{
				if (!(text3 == "Mail khôi phục") || !Class15.A49A61BA(list, "mailrecovery", text))
				{
					break;
				}
				for (int num7 = 0; num7 < fMain_0.dtgvAcc.Rows.Count; num7++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num7].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num7, "cMailRecovery", text.Split('|')[0]);
					}
				}
				break;
			}
			case 1687876407u:
			{
				if (!(text3 == "Status 282") || !Class15.A49A61BA(list, "status282", text))
				{
					break;
				}
				for (int num = 0; num < fMain_0.dtgvAcc.Rows.Count; num++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num, "cStatus282", text);
					}
				}
				break;
			}
			case 1669390511u:
			{
				if (!(text3 == "PassMail") || !Class15.A49A61BA(list, "PassMail", text))
				{
					break;
				}
				for (int num9 = 0; num9 < fMain_0.dtgvAcc.Rows.Count; num9++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num9].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num9, "cPassMail", text);
					}
				}
				break;
			}
			case 2249983736u:
			{
				if (!(text3 == "2FA") || !Class15.DB0FC1AC(list, "fa2", text))
				{
					break;
				}
				for (int num3 = 0; num3 < fMain_0.dtgvAcc.Rows.Count; num3++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num3].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num3, "cFa2", text);
					}
				}
				break;
			}
			case 2152741479u:
			{
				if (!(text3 == "Pass mail khôi phục") || !Class15.A49A61BA(list, "passmailrecovery", text))
				{
					break;
				}
				for (int k = 0; k < fMain_0.dtgvAcc.Rows.Count; k++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[k].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(k, "cPassMailRecovery", text.Split('|')[0]);
					}
				}
				break;
			}
			case 2776932076u:
			{
				if (!(text3 == "Fb Block"))
				{
					break;
				}
				text = (ckbFbBlock.Checked ? "Yes" : "");
				if (!Class15.A49A61BA(list, "fbBlock", text))
				{
					break;
				}
				for (int num5 = 0; num5 < fMain_0.dtgvAcc.Rows.Count; num5++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num5].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num5, "cFbBlock", text);
					}
				}
				break;
			}
			case 2422763473u:
			{
				if (!(text3 == "Tình trạng"))
				{
					break;
				}
				string text4 = F1B01C82.Text;
				if (!Class15.DB0FC1AC(list, "info", text4))
				{
					break;
				}
				for (int m = 0; m < fMain_0.dtgvAcc.Rows.Count; m++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[m].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(m, "cInfo", text4);
					}
				}
				break;
			}
			case 3183131359u:
			{
				if (!(text3 == "Cookie") || !Class15.DB0FC1AC(list, "cookie1", text))
				{
					break;
				}
				for (int num12 = 0; num12 < fMain_0.dtgvAcc.Rows.Count; num12++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num12].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num12, "cCookies", text);
					}
				}
				break;
			}
			case 3083160018u:
			{
				if (!(text3 == "OAuth2") || !Class15.A49A61BA(list, "backup", text))
				{
					break;
				}
				for (int num8 = 0; num8 < fMain_0.dtgvAcc.Rows.Count; num8++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num8].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num8, "cOAuth2", text.Split('|')[0]);
					}
				}
				break;
			}
			case 4192210162u:
			{
				if (!(text3 == "Email|Mail khôi phục") || !Class15.A49A61BA(list, "email|mailrecovery", text))
				{
					break;
				}
				for (int num4 = 0; num4 < fMain_0.dtgvAcc.Rows.Count; num4++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[num4].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(num4, "cEmail", text.Split('|')[0]);
						fMain_0.E38D51B3(num4, "cMailRecovery", text.Split('|')[1]);
					}
				}
				break;
			}
			case 3646757383u:
			{
				if (!(text3 == "Useragent") || !Class15.DB0FC1AC(list, "useragent", text))
				{
					break;
				}
				for (int n = 0; n < fMain_0.dtgvAcc.Rows.Count; n++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[n].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(n, "cUseragent", text);
					}
				}
				break;
			}
			case 3243292492u:
			{
				if (!(text3 == "Birthday") || !Class15.DB0FC1AC(list, "birthday", text))
				{
					break;
				}
				for (int j = 0; j < fMain_0.dtgvAcc.Rows.Count; j++)
				{
					if (Convert.ToBoolean(fMain_0.dtgvAcc.Rows[j].Cells["cChose"].Value))
					{
						fMain_0.E38D51B3(j, "cBirthday", text);
					}
				}
				break;
			}
			}
			Close();
		}
		catch
		{
			GClass29.smethod_0("Vui lòng thử lại sau!", 2);
		}
	}

	private void DA05C69D(object sender, EventArgs e)
	{
		label3.Visible = cbbTypeUpdate.Text == "Proxy";
		cbbTypeProxy.Visible = cbbTypeUpdate.Text == "Proxy";
		F1B01C82.Visible = cbbTypeUpdate.Text == "Tình trạng";
		F1B01C82.SelectedIndex = 0;
		ckbFbBlock.Visible = cbbTypeUpdate.Text == "Fb Block";
		txbData.Visible = cbbTypeUpdate.Text != "Tình trạng" && cbbTypeUpdate.Text != "Fb Block";
	}

	protected override void Dispose(bool E5BCDF29)
	{
		if (E5BCDF29 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(E5BCDF29);
	}

	private void AD2A9E31()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fUpdateData));
		C30DA090 = new BunifuCards();
		pnlHeader = new Panel();
		B03093B1 = new Button();
		B62D9792 = new PictureBox();
		bunifuCustomLabel1 = new BunifuCustomLabel();
		cbbTypeUpdate = new ComboBox();
		A404F18A = new Label();
		txbData = new TextBox();
		label2 = new Label();
		B93B940B = new Button();
		btnAdd = new Button();
		label3 = new Label();
		cbbTypeProxy = new ComboBox();
		F1B01C82 = new ComboBox();
		ckbFbBlock = new CheckBox();
		C30DA090.SuspendLayout();
		pnlHeader.SuspendLayout();
		((ISupportInitialize)B62D9792).BeginInit();
		SuspendLayout();
		C30DA090.BackColor = Color.White;
		C30DA090.BorderRadius = 5;
		C30DA090.BottomSahddow = true;
		C30DA090.color = Color.SaddleBrown;
		C30DA090.Controls.Add(pnlHeader);
		C30DA090.Dock = DockStyle.Top;
		C30DA090.LeftSahddow = false;
		C30DA090.Location = new Point(0, 0);
		C30DA090.Name = "bunifuCards1";
		C30DA090.RightSahddow = true;
		C30DA090.ShadowDepth = 20;
		C30DA090.Size = new Size(416, 38);
		C30DA090.TabIndex = 12;
		pnlHeader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
		pnlHeader.BackColor = Color.White;
		pnlHeader.Controls.Add(B03093B1);
		pnlHeader.Controls.Add(B62D9792);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new Size(416, 32);
		pnlHeader.TabIndex = 9;
		B03093B1.Cursor = Cursors.Hand;
		B03093B1.FlatAppearance.BorderSize = 0;
		B03093B1.FlatStyle = FlatStyle.Flat;
		B03093B1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B03093B1.ForeColor = Color.White;
		B03093B1.Image = (Image)componentResourceManager.GetObject("btnMinimize.Image");
		B03093B1.Location = new Point(382, -1);
		B03093B1.Name = "btnMinimize";
		B03093B1.Size = new Size(32, 32);
		B03093B1.TabIndex = 9;
		B03093B1.TextImageRelation = TextImageRelation.ImageBeforeText;
		B03093B1.UseVisualStyleBackColor = true;
		B03093B1.Click += B03093B1_Click;
		B62D9792.Cursor = Cursors.Default;
		B62D9792.Image = C50FB39E.Bitmap_5;
		B62D9792.Location = new Point(3, 1);
		B62D9792.Name = "pictureBox1";
		B62D9792.Size = new Size(34, 27);
		B62D9792.SizeMode = PictureBoxSizeMode.Zoom;
		B62D9792.TabIndex = 79;
		B62D9792.TabStop = false;
		bunifuCustomLabel1.BackColor = Color.Transparent;
		bunifuCustomLabel1.Dock = DockStyle.Fill;
		bunifuCustomLabel1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = Color.Black;
		bunifuCustomLabel1.Location = new Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new Size(416, 32);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cập nhật dữ liệu";
		bunifuCustomLabel1.TextAlign = ContentAlignment.MiddleCenter;
		cbbTypeUpdate.Cursor = Cursors.Hand;
		cbbTypeUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeUpdate.FormattingEnabled = true;
		cbbTypeUpdate.ItemHeight = 16;
		cbbTypeUpdate.Items.AddRange(new object[18]
		{
			"Token", "Cookie", "Password", "Mail|pass", "PassMail", "2FA", "Birthday", "Useragent", "Proxy", "Notes",
			"Email|Mail khôi phục", "Pass mail khôi phục", "Mail khôi phục", "Phone", "Fb Block", "Tình trạng", "Status 282", "OAuth2"
		});
		cbbTypeUpdate.Location = new Point(146, 45);
		cbbTypeUpdate.Name = "cbbTypeUpdate";
		cbbTypeUpdate.Size = new Size(238, 24);
		cbbTypeUpdate.TabIndex = 13;
		cbbTypeUpdate.SelectedIndexChanged += DA05C69D;
		A404F18A.AutoSize = true;
		A404F18A.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		A404F18A.Location = new Point(34, 48);
		A404F18A.Name = "label1";
		A404F18A.Size = new Size(105, 16);
		A404F18A.TabIndex = 14;
		A404F18A.Text = "Dữ liệu cập nhật:";
		txbData.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		txbData.Location = new Point(146, 75);
		txbData.Name = "txbData";
		txbData.Size = new Size(238, 23);
		txbData.TabIndex = 15;
		txbData.Visible = false;
		label2.AutoSize = true;
		label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label2.Location = new Point(34, 78);
		label2.Name = "label2";
		label2.Size = new Size(84, 16);
		label2.TabIndex = 16;
		label2.Text = "Nhập dữ liệu:";
		B93B940B.BackColor = Color.Maroon;
		B93B940B.Cursor = Cursors.Hand;
		B93B940B.FlatAppearance.BorderSize = 0;
		B93B940B.FlatStyle = FlatStyle.Flat;
		B93B940B.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		B93B940B.ForeColor = Color.White;
		B93B940B.Location = new Point(209, 141);
		B93B940B.Name = "btnCancel";
		B93B940B.Size = new Size(92, 29);
		B93B940B.TabIndex = 18;
		B93B940B.Text = "Đóng";
		B93B940B.UseVisualStyleBackColor = false;
		B93B940B.Click += B93B940B_Click;
		btnAdd.BackColor = Color.FromArgb(53, 120, 229);
		btnAdd.Cursor = Cursors.Hand;
		btnAdd.FlatAppearance.BorderSize = 0;
		btnAdd.FlatStyle = FlatStyle.Flat;
		btnAdd.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnAdd.ForeColor = Color.White;
		btnAdd.Location = new Point(111, 141);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(92, 29);
		btnAdd.TabIndex = 17;
		btnAdd.Text = "Lưu";
		btnAdd.UseVisualStyleBackColor = false;
		btnAdd.Click += btnAdd_Click;
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(34, 107);
		label3.Name = "label3";
		label3.Size = new Size(70, 16);
		label3.TabIndex = 16;
		label3.Text = "Loại proxy:";
		cbbTypeProxy.Cursor = Cursors.Hand;
		cbbTypeProxy.DropDownStyle = ComboBoxStyle.DropDownList;
		cbbTypeProxy.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		cbbTypeProxy.FormattingEnabled = true;
		cbbTypeProxy.Items.AddRange(new object[2] { "HTTP", "Sock5" });
		cbbTypeProxy.Location = new Point(146, 104);
		cbbTypeProxy.Name = "cbbTypeProxy";
		cbbTypeProxy.Size = new Size(130, 24);
		cbbTypeProxy.TabIndex = 124;
		F1B01C82.Cursor = Cursors.Hand;
		F1B01C82.DropDownStyle = ComboBoxStyle.DropDownList;
		F1B01C82.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		F1B01C82.FormattingEnabled = true;
		F1B01C82.Items.AddRange(new object[4] { "Live", "Die", "Checkpoint", "Changed pass" });
		F1B01C82.Location = new Point(146, 75);
		F1B01C82.Name = "cbbTinhTrang";
		F1B01C82.Size = new Size(238, 24);
		F1B01C82.TabIndex = 127;
		F1B01C82.Visible = false;
		ckbFbBlock.AutoSize = true;
		ckbFbBlock.Cursor = Cursors.Hand;
		ckbFbBlock.Location = new Point(146, 78);
		ckbFbBlock.Name = "ckbFbBlock";
		ckbFbBlock.Size = new Size(73, 20);
		ckbFbBlock.TabIndex = 128;
		ckbFbBlock.Text = "Fb Block";
		ckbFbBlock.UseVisualStyleBackColor = true;
		ckbFbBlock.Visible = false;
		base.AutoScaleMode = AutoScaleMode.None;
		base.ClientSize = new Size(416, 180);
		base.Controls.Add(ckbFbBlock);
		base.Controls.Add(F1B01C82);
		base.Controls.Add(cbbTypeProxy);
		base.Controls.Add(B93B940B);
		base.Controls.Add(btnAdd);
		base.Controls.Add(label3);
		base.Controls.Add(label2);
		base.Controls.Add(txbData);
		base.Controls.Add(A404F18A);
		base.Controls.Add(cbbTypeUpdate);
		base.Controls.Add(C30DA090);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fUpdateData";
		base.StartPosition = FormStartPosition.CenterParent;
		Text = "fUpdateData";
		C30DA090.ResumeLayout(performLayout: false);
		pnlHeader.ResumeLayout(performLayout: false);
		((ISupportInitialize)B62D9792).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
