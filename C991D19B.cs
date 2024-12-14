using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class C991D19B : Form
{
	private List<ComboBox> list_0;

	private List<string> list_1 = new List<string>();

	private IContainer C528C9AB = null;

	private BunifuCards bunifuCards1;

	private Panel pnlHeader;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnMinimize;

	private Button btnCancel;

	private Button D9B57529;

	private Label label1;

	private BunifuDragControl CCAA800E;

	private ComboBox cbbDinhDang1;

	private ComboBox cbbDinhDang2;

	private ComboBox E7812414;

	private ComboBox cbbDinhDang4;

	private Label label14;

	private ComboBox C5157480;

	private Label label13;

	private ComboBox B61A8EA8;

	private Label label12;

	private ComboBox A8BE078F;

	private Label label11;

	private Label B8B4AE08;

	private Label D8B1643C;

	private ComboBox CB8E8D8F;

	private ComboBox EE1133A4;

	private Label BC0BE092;

	private Label label3;

	private Button A19DA137;

	private ComboBox cbbDinhDang10;

	private Label label4;

	public C991D19B(List<string> list_2)
	{
		InitializeComponent();
		list_1 = list_2;
		F7AB102E.D6B70A35(this);
		list_0 = new List<ComboBox> { cbbDinhDang1, cbbDinhDang2, E7812414, cbbDinhDang4, C5157480, B61A8EA8, A8BE078F, EE1133A4, CB8E8D8F, cbbDinhDang10 };
	}

	private void btnMinimize_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void method_0()
	{
		try
		{
			string text = "";
			for (int i = 0; i < list_0.Count; i++)
			{
				text = text + list_0[i].SelectedIndex + "|";
			}
			text = text.TrimEnd('|');
			GClass25.smethod_0("configFormat").method_4("copyFormat", text);
			GClass25.smethod_0("configFormat").method_6();
		}
		catch
		{
		}
	}

	private void method_1()
	{
		try
		{
			string text = GClass25.smethod_0("configFormat").C0288288("copyFormat");
			if (text != "")
			{
				for (int i = 0; i < list_0.Count; i++)
				{
					list_0[i].SelectedIndex = Convert.ToInt32(text.Split('|')[i]);
				}
			}
		}
		catch
		{
		}
	}

	private void method_2()
	{
		try
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				list_0[i].SelectedIndex = -1;
			}
		}
		catch
		{
		}
	}

	private void EF9CCD39(object sender, EventArgs e)
	{
		try
		{
			if (!Class57.smethod_3())
			{
				return;
			}
			List<string> list = new List<string>();
			string text = "";
			int num = 0;
			int num2 = list_0.Count - 1;
			while (num2 >= 0)
			{
				if (list_0[num2].SelectedIndex == -1)
				{
					num2--;
					continue;
				}
				num = num2 + 1;
				break;
			}
			if (num == 0)
			{
				GClass29.smethod_0("vui lo\u0300ng cho\u0323n đi\u0323nh da\u0323ng câ\u0300n copy!", 3);
				return;
			}
			method_0();
			int num3 = 0;
			for (int i = 0; i < list_1.Count; i++)
			{
				text = "";
				string[] array = list_1[i].Split('|');
				for (int j = 0; j < list_0.Count; j++)
				{
					int selectedIndex = list_0[j].SelectedIndex;
					if (selectedIndex > 0 && array.Length >= selectedIndex)
					{
						text += array[selectedIndex - 1];
					}
					text += "|";
				}
				text = text.TrimEnd('|');
				for (num3 = text.Split('|').Count(); num3 < num; num3++)
				{
					text += "|";
				}
				list.Add(text);
			}
			string string_ = string.Join("\r\n", list);
			GClass8.smethod_27(string_);
			GClass29.smethod_0("Copy tha\u0300nh công!");
			Close();
		}
		catch (Exception ex)
		{
			GClass8.smethod_62(null, ex.ToString());
			GClass29.smethod_0("Có lỗi xảy ra, vui lòng thử lại sau!", 2);
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void A19DA137_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void ACAEF898(object sender, EventArgs e)
	{
		foreach (ComboBox item in list_0)
		{
			GClass8.smethod_22(item, new List<string>
			{
				"", "Uid", "Pass", "Token", "Cookie", "Email", "Email full", "Pass Email", "2FA", "Useragent",
				"Proxy", "Tên", "Giới tính", "Theo dõi", "Bạn bè", "Nhóm", "Ngày sinh", "Ngày tạo", "Ghi chú", "Location",
				"Mail khôi phục", "Pass mail khôi phục", "Tương tác cuối", "Dating", "Ads", "BM", "Hometown", "Current City", "Tra\u0323ng tha\u0301i", "Refresh_token",
				"Client_id"
			});
			item.SelectedIndex = -1;
			item.DropDownWidth = 120;
		}
		method_1();
	}

	protected override void Dispose(bool F5396594)
	{
		if (F5396594 && C528C9AB != null)
		{
			C528C9AB.Dispose();
		}
		base.Dispose(F5396594);
	}

	private void InitializeComponent()
	{
		C528C9AB = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C991D19B));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		pnlHeader = new System.Windows.Forms.Panel();
		btnMinimize = new System.Windows.Forms.Button();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		btnCancel = new System.Windows.Forms.Button();
		D9B57529 = new System.Windows.Forms.Button();
		label1 = new System.Windows.Forms.Label();
		CCAA800E = new Bunifu.Framework.UI.BunifuDragControl(C528C9AB);
		cbbDinhDang1 = new System.Windows.Forms.ComboBox();
		cbbDinhDang2 = new System.Windows.Forms.ComboBox();
		E7812414 = new System.Windows.Forms.ComboBox();
		cbbDinhDang4 = new System.Windows.Forms.ComboBox();
		label14 = new System.Windows.Forms.Label();
		C5157480 = new System.Windows.Forms.ComboBox();
		label13 = new System.Windows.Forms.Label();
		B61A8EA8 = new System.Windows.Forms.ComboBox();
		label12 = new System.Windows.Forms.Label();
		A8BE078F = new System.Windows.Forms.ComboBox();
		label11 = new System.Windows.Forms.Label();
		B8B4AE08 = new System.Windows.Forms.Label();
		D8B1643C = new System.Windows.Forms.Label();
		CB8E8D8F = new System.Windows.Forms.ComboBox();
		EE1133A4 = new System.Windows.Forms.ComboBox();
		BC0BE092 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		A19DA137 = new System.Windows.Forms.Button();
		cbbDinhDang10 = new System.Windows.Forms.ComboBox();
		label4 = new System.Windows.Forms.Label();
		bunifuCards1.SuspendLayout();
		pnlHeader.SuspendLayout();
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
		bunifuCards1.Size = new System.Drawing.Size(1122, 38);
		bunifuCards1.TabIndex = 0;
		pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		pnlHeader.BackColor = System.Drawing.Color.White;
		pnlHeader.Controls.Add(btnMinimize);
		pnlHeader.Controls.Add(bunifuCustomLabel1);
		pnlHeader.Location = new System.Drawing.Point(0, 5);
		pnlHeader.Name = "pnlHeader";
		pnlHeader.Size = new System.Drawing.Size(1122, 32);
		pnlHeader.TabIndex = 9;
		btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
		btnMinimize.FlatAppearance.BorderSize = 0;
		btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		btnMinimize.ForeColor = System.Drawing.Color.White;
		btnMinimize.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		btnMinimize.Location = new System.Drawing.Point(1090, 0);
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(1122, 32);
		bunifuCustomLabel1.TabIndex = 1;
		bunifuCustomLabel1.Text = "Tu\u0300y cho\u0323n đi\u0323nh da\u0323ng sao che\u0301p";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(622, 124);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Đo\u0301ng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		D9B57529.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		D9B57529.Cursor = System.Windows.Forms.Cursors.Hand;
		D9B57529.FlatAppearance.BorderSize = 0;
		D9B57529.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D9B57529.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D9B57529.ForeColor = System.Drawing.Color.White;
		D9B57529.Location = new System.Drawing.Point(514, 124);
		D9B57529.Name = "btnAdd";
		D9B57529.Size = new System.Drawing.Size(92, 29);
		D9B57529.TabIndex = 3;
		D9B57529.Text = "Xa\u0301c nhâ\u0323n";
		D9B57529.UseVisualStyleBackColor = false;
		D9B57529.Click += new System.EventHandler(EF9CCD39);
		label1.AutoSize = true;
		label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		label1.Location = new System.Drawing.Point(20, 66);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(131, 16);
		label1.TabIndex = 20;
		label1.Text = "Cho\u0323n đi\u0323nh da\u0323ng copy:";
		CCAA800E.Fixed = true;
		CCAA800E.Horizontal = true;
		CCAA800E.TargetControl = bunifuCustomLabel1;
		CCAA800E.Vertical = true;
		cbbDinhDang1.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang1.FormattingEnabled = true;
		cbbDinhDang1.Location = new System.Drawing.Point(158, 65);
		cbbDinhDang1.Name = "cbbDinhDang1";
		cbbDinhDang1.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang1.TabIndex = 42;
		cbbDinhDang2.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang2.FormattingEnabled = true;
		cbbDinhDang2.Location = new System.Drawing.Point(255, 65);
		cbbDinhDang2.Name = "cbbDinhDang2";
		cbbDinhDang2.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang2.TabIndex = 43;
		E7812414.Cursor = System.Windows.Forms.Cursors.Hand;
		E7812414.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		E7812414.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		E7812414.FormattingEnabled = true;
		E7812414.Location = new System.Drawing.Point(352, 65);
		E7812414.Name = "cbbDinhDang3";
		E7812414.Size = new System.Drawing.Size(78, 24);
		E7812414.TabIndex = 44;
		cbbDinhDang4.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang4.FormattingEnabled = true;
		cbbDinhDang4.Location = new System.Drawing.Point(449, 65);
		cbbDinhDang4.Name = "cbbDinhDang4";
		cbbDinhDang4.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang4.TabIndex = 45;
		label14.AutoSize = true;
		label14.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label14.Location = new System.Drawing.Point(721, 67);
		label14.Name = "label14";
		label14.Size = new System.Drawing.Size(19, 19);
		label14.TabIndex = 49;
		label14.Text = "|";
		C5157480.Cursor = System.Windows.Forms.Cursors.Hand;
		C5157480.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		C5157480.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		C5157480.FormattingEnabled = true;
		C5157480.Location = new System.Drawing.Point(546, 65);
		C5157480.Name = "cbbDinhDang5";
		C5157480.Size = new System.Drawing.Size(78, 24);
		C5157480.TabIndex = 46;
		label13.AutoSize = true;
		label13.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label13.Location = new System.Drawing.Point(624, 67);
		label13.Name = "label13";
		label13.Size = new System.Drawing.Size(19, 19);
		label13.TabIndex = 50;
		label13.Text = "|";
		B61A8EA8.Cursor = System.Windows.Forms.Cursors.Hand;
		B61A8EA8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		B61A8EA8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B61A8EA8.FormattingEnabled = true;
		B61A8EA8.Location = new System.Drawing.Point(643, 65);
		B61A8EA8.Name = "cbbDinhDang6";
		B61A8EA8.Size = new System.Drawing.Size(78, 24);
		B61A8EA8.TabIndex = 47;
		label12.AutoSize = true;
		label12.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label12.Location = new System.Drawing.Point(527, 67);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(19, 19);
		label12.TabIndex = 51;
		label12.Text = "|";
		A8BE078F.Cursor = System.Windows.Forms.Cursors.Hand;
		A8BE078F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		A8BE078F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A8BE078F.FormattingEnabled = true;
		A8BE078F.Location = new System.Drawing.Point(740, 65);
		A8BE078F.Name = "cbbDinhDang7";
		A8BE078F.Size = new System.Drawing.Size(78, 24);
		A8BE078F.TabIndex = 48;
		label11.AutoSize = true;
		label11.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label11.Location = new System.Drawing.Point(430, 67);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(19, 19);
		label11.TabIndex = 52;
		label11.Text = "|";
		B8B4AE08.AutoSize = true;
		B8B4AE08.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B8B4AE08.Location = new System.Drawing.Point(236, 67);
		B8B4AE08.Name = "label9";
		B8B4AE08.Size = new System.Drawing.Size(19, 19);
		B8B4AE08.TabIndex = 53;
		B8B4AE08.Text = "|";
		D8B1643C.AutoSize = true;
		D8B1643C.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D8B1643C.Location = new System.Drawing.Point(333, 67);
		D8B1643C.Name = "label10";
		D8B1643C.Size = new System.Drawing.Size(19, 19);
		D8B1643C.TabIndex = 54;
		D8B1643C.Text = "|";
		CB8E8D8F.Cursor = System.Windows.Forms.Cursors.Hand;
		CB8E8D8F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		CB8E8D8F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		CB8E8D8F.FormattingEnabled = true;
		CB8E8D8F.Location = new System.Drawing.Point(934, 65);
		CB8E8D8F.Name = "cbbDinhDang9";
		CB8E8D8F.Size = new System.Drawing.Size(78, 24);
		CB8E8D8F.TabIndex = 48;
		EE1133A4.Cursor = System.Windows.Forms.Cursors.Hand;
		EE1133A4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		EE1133A4.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		EE1133A4.FormattingEnabled = true;
		EE1133A4.Location = new System.Drawing.Point(837, 65);
		EE1133A4.Name = "cbbDinhDang8";
		EE1133A4.Size = new System.Drawing.Size(78, 24);
		EE1133A4.TabIndex = 47;
		BC0BE092.AutoSize = true;
		BC0BE092.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		BC0BE092.Location = new System.Drawing.Point(818, 67);
		BC0BE092.Name = "label2";
		BC0BE092.Size = new System.Drawing.Size(19, 19);
		BC0BE092.TabIndex = 50;
		BC0BE092.Text = "|";
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label3.Location = new System.Drawing.Point(915, 67);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(19, 19);
		label3.TabIndex = 49;
		label3.Text = "|";
		A19DA137.BackColor = System.Drawing.Color.DarkOrange;
		A19DA137.Cursor = System.Windows.Forms.Cursors.Hand;
		A19DA137.FlatAppearance.BorderSize = 0;
		A19DA137.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A19DA137.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A19DA137.ForeColor = System.Drawing.Color.White;
		A19DA137.Location = new System.Drawing.Point(377, 124);
		A19DA137.Name = "button1";
		A19DA137.Size = new System.Drawing.Size(121, 29);
		A19DA137.TabIndex = 4;
		A19DA137.Text = "Reset định dạng";
		A19DA137.UseVisualStyleBackColor = false;
		A19DA137.Click += new System.EventHandler(A19DA137_Click);
		cbbDinhDang10.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbDinhDang10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbDinhDang10.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		cbbDinhDang10.FormattingEnabled = true;
		cbbDinhDang10.Location = new System.Drawing.Point(1033, 65);
		cbbDinhDang10.Name = "cbbDinhDang10";
		cbbDinhDang10.Size = new System.Drawing.Size(78, 24);
		cbbDinhDang10.TabIndex = 48;
		label4.AutoSize = true;
		label4.Font = new System.Drawing.Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label4.Location = new System.Drawing.Point(1014, 67);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(19, 19);
		label4.TabIndex = 49;
		label4.Text = "|";
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(1122, 165);
		base.Controls.Add(cbbDinhDang1);
		base.Controls.Add(cbbDinhDang2);
		base.Controls.Add(E7812414);
		base.Controls.Add(cbbDinhDang4);
		base.Controls.Add(label4);
		base.Controls.Add(label3);
		base.Controls.Add(label14);
		base.Controls.Add(C5157480);
		base.Controls.Add(BC0BE092);
		base.Controls.Add(EE1133A4);
		base.Controls.Add(label13);
		base.Controls.Add(B61A8EA8);
		base.Controls.Add(cbbDinhDang10);
		base.Controls.Add(CB8E8D8F);
		base.Controls.Add(label12);
		base.Controls.Add(A8BE078F);
		base.Controls.Add(label11);
		base.Controls.Add(B8B4AE08);
		base.Controls.Add(D8B1643C);
		base.Controls.Add(label1);
		base.Controls.Add(A19DA137);
		base.Controls.Add(btnCancel);
		base.Controls.Add(D9B57529);
		base.Controls.Add(bunifuCards1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fCopy";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "fAddFile";
		base.Load += new System.EventHandler(ACAEF898);
		bunifuCards1.ResumeLayout(false);
		pnlHeader.ResumeLayout(false);
		ResumeLayout(false);
		PerformLayout();
	}
}
