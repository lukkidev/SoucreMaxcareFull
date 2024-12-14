using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class CAB700BC : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class B28EAF38
	{
		public static readonly B28EAF38 _003C_003E9 = new B28EAF38();

		public static Func<string, string> _003C_003E9__25_0;

		public static Func<string, string> _003C_003E9__25_1;

		internal string method_0(string string_0)
		{
			return string_0.Split('|')[0];
		}

		internal string method_1(string F030FEA4)
		{
			return F030FEA4.Split('|')[0];
		}
	}

	private GClass11 gclass11_0;

	private string string_0;

	private string A70B5908;

	private string string_1;

	private int B6BD47AA;

	public static bool E78D2A04;

	private string string_2 = "";

	private int AA28B092 = 0;

	private List<string> D82E3190 = new List<string>();

	private List<string> list_0 = new List<string>();

	private List<string> C7036926 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private List<string> list_3 = new List<string>();

	private List<string> list_4 = new List<string>();

	private List<string> list_5 = new List<string>();

	private List<string> list_6 = new List<string>();

	private List<string> E83B09B7 = new List<string>
	{
		"1|Single", "2|In a relationship", "5|Engaged", "4|Married", "10|In a civil union", "11|In a domestic partnership", "3|In an open relationship", "6|It's complicated", "8|Separated", "9|Divorced",
		"7|Widowed"
	};

	private List<string> list_7 = new List<string> { "1|Female", "2|Male" };

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl bunifuDragControl_1;

	private Panel panel1;

	private TextBox txtTenHanhDong;

	private Label label1;

	private Button btnCancel;

	private Button E00AD383;

	private BunifuCards bunifuCards1;

	private Panel C121063B;

	private Button B936B73D;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private Button btnNhapBio;

	private CheckBox ckbRelationship;

	private CheckBox ckbCurrentCity;

	private CheckBox ckbCollege;

	private CheckBox ckbHighSchool;

	private CheckBox EB8607A6;

	private Button btnNhapCurrentCity;

	private Button btnNhapCollege;

	private Button btnNhapWork;

	private CheckBox ckbBio;

	private ComboBox cbbRelationship;

	private CheckBox ckbHometown;

	private Button btnNhapHometown;

	private ComboBox cbbGender;

	private CheckBox B33CB017;

	private CheckBox EB2C33BE;

	private Button CDB39216;

	private Button btnMonth;

	private Button btnDay;

	private CheckBox EF02ED8E;

	private Button btnNickname;

	private Panel EB281C82;

	private ComboBox cbbIfHaveWork;

	private Label label3;

	private Label ED35CF00;

	private Panel F9226037;

	private ComboBox FC225036;

	private Label A09E9DB4;

	private Label label7;

	private Panel plHighSchool;

	private ComboBox cbbIfHaveHighSchool;

	private Label label4;

	private Label label5;

	private Button btnNhapHighSchool;

	public CAB700BC(string string_3, int int_0 = 0, string EDA67028 = "")
	{
		InitializeComponent();
		E78D2A04 = false;
		string_0 = string_3;
		string_1 = EDA67028;
		B6BD47AA = int_0;
		string text = base.Name.Substring(1);
		string text2 = "Cập nhật thông tin";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string text3 = "";
		switch (int_0)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			text3 = dataTable2.Rows[0]["CauHinh"].ToString();
			A70B5908 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			txtTenHanhDong.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(EDA67028);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			E00AD383.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			txtTenHanhDong.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void CAB700BC_Load(object sender, EventArgs e)
	{
		method_1();
		method_0();
		BD17FB3C(cbbIfHaveWork);
		BD17FB3C(cbbIfHaveHighSchool);
		BD17FB3C(FC225036);
		try
		{
			ckbBio.Checked = gclass11_0.method_3("ckbBio");
			EB8607A6.Checked = gclass11_0.method_3("ckbWork");
			cbbIfHaveWork.SelectedIndex = gclass11_0.method_2("cbbIfHaveWork");
			ckbHighSchool.Checked = gclass11_0.method_3("ckbHighSchool");
			cbbIfHaveHighSchool.SelectedIndex = gclass11_0.method_2("cbbIfHaveHighSchool");
			ckbCollege.Checked = gclass11_0.method_3("ckbCollege");
			FC225036.SelectedIndex = gclass11_0.method_2("cbbIfHaveCollege");
			ckbCurrentCity.Checked = gclass11_0.method_3("ckbCurrentCity");
			ckbHometown.Checked = gclass11_0.method_3("ckbHometown");
			ckbRelationship.Checked = gclass11_0.method_3("ckbRelationship");
			B33CB017.Checked = gclass11_0.method_3("ckbGender");
			EB2C33BE.Checked = gclass11_0.method_3("ckbBirthday");
			EF02ED8E.Checked = gclass11_0.method_3("ckbNickname");
			string_2 = gclass11_0.C0288288("txtBio");
			AA28B092 = gclass11_0.method_2("typeSplitBio");
			D82E3190 = gclass11_0.C5A69DA0("lstWork");
			list_0 = gclass11_0.C5A69DA0("lstHighSchool");
			C7036926 = gclass11_0.C5A69DA0("lstCollege");
			list_1 = gclass11_0.C5A69DA0("lstCurrentCity");
			list_2 = gclass11_0.C5A69DA0("lstHometown");
			cbbRelationship.SelectedValue = ((gclass11_0.C0288288("cbbRelationship", "-1").Split('|').Length == 1) ? gclass11_0.C0288288("cbbRelationship", "-1") : "-1");
			cbbGender.SelectedValue = ((gclass11_0.C0288288("cbbGender", "-1").Split('|').Length == 1) ? gclass11_0.C0288288("cbbGender", "-1") : "-1");
			list_3 = gclass11_0.C5A69DA0("lstDay");
			list_4 = gclass11_0.C5A69DA0("lstMonth");
			list_5 = gclass11_0.C5A69DA0("lstYear");
			list_6 = gclass11_0.C5A69DA0("lstNickname");
			FC2B8CA7(null, null);
			DBA1FEB1(null, null);
			B1850E2D(null, null);
			ckbCollege_CheckedChanged(null, null);
			ckbCurrentCity_CheckedChanged(null, null);
			ckbHometown_CheckedChanged(null, null);
			FD83F438(null, null);
			B33CB017_CheckedChanged(null, null);
			EB2C33BE_CheckedChanged(null, null);
			EF02ED8E_CheckedChanged(null, null);
			GClass8.smethod_61(btnNhapCurrentCity, list_1.Count);
			GClass8.smethod_61(btnNhapHometown, list_2.Count);
			GClass8.smethod_61(btnNhapCollege, C7036926.Count);
			GClass8.smethod_61(btnNhapHighSchool, list_0.Count);
			GClass8.smethod_61(btnNhapWork, D82E3190.Count);
			GClass8.smethod_61(btnNhapBio, string_2.Split(new string[1] { (AA28B092 == 0) ? "\n" : "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).Length);
			GClass8.smethod_61(btnNickname, list_6.Count);
		}
		catch
		{
		}
	}

	private void BD17FB3C(ComboBox comboBox_0)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("0", "Tiê\u0301p tu\u0323c thêm thông tin");
		dictionary.Add("1", "Không thêm thông tin nư\u0303a");
		dictionary.Add("2", "Xo\u0301a thông tin cu\u0303");
		GClass8.smethod_23(comboBox_0, dictionary);
	}

	private void method_0()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < list_7.Count; i++)
		{
			dictionary.Add(list_7[i].Split('|')[0], list_7[i].Split('|')[1]);
		}
		dictionary.Add("-1", "Random");
		cbbGender.DataSource = new BindingSource(dictionary, null);
		cbbGender.DisplayMember = "Value";
		cbbGender.ValueMember = "Key";
	}

	private void method_1()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		for (int i = 0; i < E83B09B7.Count; i++)
		{
			dictionary.Add(E83B09B7[i].Split('|')[0], E83B09B7[i].Split('|')[1]);
		}
		dictionary.Add("-1", "Random");
		cbbRelationship.DataSource = new BindingSource(dictionary, null);
		cbbRelationship.DisplayMember = "Value";
		cbbRelationship.ValueMember = "Key";
	}

	private void B936B73D_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BA35B69E(object sender, EventArgs e)
	{
		string text = txtTenHanhDong.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0(F7AB102E.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!"), 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("ckbBio", ckbBio.Checked);
		gClass.method_4("ckbWork", EB8607A6.Checked);
		gClass.method_4("cbbIfHaveWork", cbbIfHaveWork.SelectedIndex);
		gClass.method_4("ckbHighSchool", ckbHighSchool.Checked);
		gClass.method_4("cbbIfHaveHighSchool", cbbIfHaveHighSchool.SelectedIndex);
		gClass.method_4("ckbCollege", ckbCollege.Checked);
		gClass.method_4("cbbIfHaveCollege", FC225036.SelectedIndex);
		gClass.method_4("ckbCurrentCity", ckbCurrentCity.Checked);
		gClass.method_4("ckbHometown", ckbHometown.Checked);
		gClass.method_4("ckbRelationship", ckbRelationship.Checked);
		gClass.method_4("ckbGender", B33CB017.Checked);
		gClass.method_4("ckbBirthday", EB2C33BE.Checked);
		gClass.method_4("ckbNickname", EF02ED8E.Checked);
		gClass.method_4("txtBio", string_2);
		gClass.method_4("typeSplitBio", AA28B092);
		gClass.method_5("lstWork", D82E3190);
		gClass.method_5("lstHighSchool", list_0);
		gClass.method_5("lstCollege", C7036926);
		gClass.method_5("lstCurrentCity", list_1);
		gClass.method_5("lstHometown", list_2);
		string text2 = cbbRelationship.SelectedValue.ToString();
		text2 = ((text2 == "-1") ? string.Join("|", E83B09B7.Select((string string_0) => string_0.Split('|')[0])) : text2);
		gClass.method_4("cbbRelationship", text2);
		string text3 = cbbGender.SelectedValue.ToString();
		text3 = ((text3 == "-1") ? string.Join("|", list_7.Select((string F030FEA4) => F030FEA4.Split('|')[0])) : text3);
		gClass.method_4("cbbGender", text3);
		gClass.method_5("lstDay", list_3);
		gClass.method_5("lstMonth", list_4);
		gClass.method_5("lstYear", list_5);
		gClass.method_5("lstNickname", list_6);
		string text4 = gClass.method_7();
		if (B6BD47AA == 0)
		{
			if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?")) == DialogResult.Yes)
			{
				if (Class147.smethod_12(string_0, text, A70B5908, text4))
				{
					E78D2A04 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0(F7AB102E.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
				}
			}
		}
		else if (GClass29.smethod_1(F7AB102E.smethod_0("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?")) == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_1, text, text4))
			{
				E78D2A04 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!"), 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void FC2B8CA7(object sender, EventArgs e)
	{
		btnNhapBio.Enabled = ckbBio.Checked;
	}

	private void DBA1FEB1(object sender, EventArgs e)
	{
		EB281C82.Enabled = EB8607A6.Checked;
	}

	private void B1850E2D(object sender, EventArgs e)
	{
		plHighSchool.Enabled = ckbHighSchool.Checked;
	}

	private void ckbCollege_CheckedChanged(object sender, EventArgs e)
	{
		F9226037.Enabled = ckbCollege.Checked;
	}

	private void ckbCurrentCity_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapCurrentCity.Enabled = ckbCurrentCity.Checked;
	}

	private void FD83F438(object sender, EventArgs e)
	{
		cbbRelationship.Enabled = ckbRelationship.Checked;
	}

	private void E58ADCA3(object sender, EventArgs e)
	{
		fNhapDuLieu3 fNhapDuLieu4 = new fNhapDuLieu3(string_2, AA28B092, F7AB102E.smethod_0("Nhâ\u0323p danh sa\u0301ch Bio"), F7AB102E.smethod_0("Danh sa\u0301ch Bio"));
		GClass8.smethod_33(fNhapDuLieu4);
		string_2 = fNhapDuLieu4.string_2;
		AA28B092 = fNhapDuLieu4.int_0;
		GClass8.smethod_61(btnNhapBio, string_2.Split(new string[1] { (AA28B092 == 0) ? "\n" : "\n|\n" }, StringSplitOptions.RemoveEmptyEntries).Length);
	}

	private void btnNhapWork_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(D82E3190, "Nhâ\u0323p danh sa\u0301ch Work", "Danh sa\u0301ch Work", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		D82E3190 = fNhapDuLieu4.C6009CA1;
		GClass8.smethod_61(btnNhapWork, D82E3190.Count);
	}

	private void AF939593(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_0, "Nhâ\u0323p danh sa\u0301ch High School", "Danh sa\u0301ch High School", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_0 = fNhapDuLieu4.C6009CA1;
		GClass8.smethod_61(btnNhapHighSchool, list_0.Count);
	}

	private void btnNhapCollege_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(C7036926, "Nhâ\u0323p danh sa\u0301ch College", "Danh sa\u0301ch College", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		C7036926 = fNhapDuLieu4.C6009CA1;
		GClass8.smethod_61(btnNhapCollege, C7036926.Count);
	}

	private void F99F3E9D(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_1, "Nhâ\u0323p danh sa\u0301ch Current City", "Danh sa\u0301ch Current City", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_1 = fNhapDuLieu4.C6009CA1;
		GClass8.smethod_61(btnNhapCurrentCity, list_1.Count);
	}

	private void ckbHometown_CheckedChanged(object sender, EventArgs e)
	{
		btnNhapHometown.Enabled = ckbHometown.Checked;
	}

	private void btnNhapHometown_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_2, "Nhâ\u0323p danh sa\u0301ch Hometown", "Danh sa\u0301ch Hometown", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_2 = fNhapDuLieu4.C6009CA1;
		GClass8.smethod_61(btnNhapHometown, list_2.Count);
	}

	private void btnDay_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_3, "Nhâ\u0323p danh sa\u0301ch ngày", "Danh sa\u0301ch ngày", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_3 = fNhapDuLieu4.C6009CA1;
	}

	private void btnMonth_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_4, "Nhâ\u0323p danh sa\u0301ch tháng", "Danh sa\u0301ch tháng", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_4 = fNhapDuLieu4.C6009CA1;
	}

	private void E005B6AA(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_5, "Nhâ\u0323p danh sa\u0301ch năm", "Danh sa\u0301ch năm", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_5 = fNhapDuLieu4.C6009CA1;
	}

	private void B33CB017_CheckedChanged(object sender, EventArgs e)
	{
		cbbGender.Enabled = B33CB017.Checked;
	}

	private void EB2C33BE_CheckedChanged(object sender, EventArgs e)
	{
		btnDay.Enabled = EB2C33BE.Checked;
		btnMonth.Enabled = EB2C33BE.Checked;
		CDB39216.Enabled = EB2C33BE.Checked;
	}

	private void btnNickname_Click(object sender, EventArgs e)
	{
		fNhapDuLieu1 fNhapDuLieu4 = new fNhapDuLieu1(list_6, "Nhâ\u0323p danh sa\u0301ch Nickname", "Danh sa\u0301ch Nickname", "(Mô\u0303i nội dung 1 do\u0300ng)");
		GClass8.smethod_33(fNhapDuLieu4);
		list_6 = fNhapDuLieu4.C6009CA1;
		GClass8.smethod_61(btnNickname, list_6.Count);
	}

	private void EF02ED8E_CheckedChanged(object sender, EventArgs e)
	{
		btnNickname.Enabled = EF02ED8E.Checked;
	}

	protected override void Dispose(bool B3B9C221)
	{
		if (B3B9C221 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B3B9C221);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAB700BC));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_1 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		C121063B = new System.Windows.Forms.Panel();
		B936B73D = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		F9226037 = new System.Windows.Forms.Panel();
		FC225036 = new System.Windows.Forms.ComboBox();
		A09E9DB4 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		btnNhapCollege = new System.Windows.Forms.Button();
		plHighSchool = new System.Windows.Forms.Panel();
		cbbIfHaveHighSchool = new System.Windows.Forms.ComboBox();
		label4 = new System.Windows.Forms.Label();
		label5 = new System.Windows.Forms.Label();
		btnNhapHighSchool = new System.Windows.Forms.Button();
		EB281C82 = new System.Windows.Forms.Panel();
		cbbIfHaveWork = new System.Windows.Forms.ComboBox();
		btnNhapWork = new System.Windows.Forms.Button();
		label3 = new System.Windows.Forms.Label();
		ED35CF00 = new System.Windows.Forms.Label();
		CDB39216 = new System.Windows.Forms.Button();
		btnMonth = new System.Windows.Forms.Button();
		btnDay = new System.Windows.Forms.Button();
		cbbGender = new System.Windows.Forms.ComboBox();
		EF02ED8E = new System.Windows.Forms.CheckBox();
		EB2C33BE = new System.Windows.Forms.CheckBox();
		cbbRelationship = new System.Windows.Forms.ComboBox();
		B33CB017 = new System.Windows.Forms.CheckBox();
		ckbRelationship = new System.Windows.Forms.CheckBox();
		ckbHometown = new System.Windows.Forms.CheckBox();
		ckbCurrentCity = new System.Windows.Forms.CheckBox();
		ckbCollege = new System.Windows.Forms.CheckBox();
		ckbHighSchool = new System.Windows.Forms.CheckBox();
		EB8607A6 = new System.Windows.Forms.CheckBox();
		btnNhapHometown = new System.Windows.Forms.Button();
		btnNhapCurrentCity = new System.Windows.Forms.Button();
		ckbBio = new System.Windows.Forms.CheckBox();
		btnNickname = new System.Windows.Forms.Button();
		btnNhapBio = new System.Windows.Forms.Button();
		txtTenHanhDong = new System.Windows.Forms.TextBox();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		E00AD383 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		C121063B.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		F9226037.SuspendLayout();
		plHighSchool.SuspendLayout();
		EB281C82.SuspendLayout();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
		bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(837, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Cập nhật thông tin";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		bunifuDragControl_1.Fixed = true;
		bunifuDragControl_1.Horizontal = true;
		bunifuDragControl_1.TargetControl = C121063B;
		bunifuDragControl_1.Vertical = true;
		C121063B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		C121063B.BackColor = System.Drawing.Color.White;
		C121063B.Controls.Add(B936B73D);
		C121063B.Controls.Add(pictureBox1);
		C121063B.Controls.Add(bunifuCustomLabel1);
		C121063B.Cursor = System.Windows.Forms.Cursors.SizeAll;
		C121063B.Location = new System.Drawing.Point(0, 3);
		C121063B.Name = "pnlHeader";
		C121063B.Size = new System.Drawing.Size(837, 31);
		C121063B.TabIndex = 9;
		B936B73D.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		B936B73D.Cursor = System.Windows.Forms.Cursors.Hand;
		B936B73D.FlatAppearance.BorderSize = 0;
		B936B73D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B936B73D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B936B73D.ForeColor = System.Drawing.Color.White;
		B936B73D.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		B936B73D.Location = new System.Drawing.Point(806, 1);
		B936B73D.Name = "button1";
		B936B73D.Size = new System.Drawing.Size(30, 30);
		B936B73D.TabIndex = 77;
		B936B73D.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		B936B73D.UseVisualStyleBackColor = true;
		B936B73D.Click += new System.EventHandler(B936B73D_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(F9226037);
		panel1.Controls.Add(plHighSchool);
		panel1.Controls.Add(EB281C82);
		panel1.Controls.Add(CDB39216);
		panel1.Controls.Add(btnMonth);
		panel1.Controls.Add(btnDay);
		panel1.Controls.Add(cbbGender);
		panel1.Controls.Add(EF02ED8E);
		panel1.Controls.Add(EB2C33BE);
		panel1.Controls.Add(cbbRelationship);
		panel1.Controls.Add(B33CB017);
		panel1.Controls.Add(ckbRelationship);
		panel1.Controls.Add(ckbHometown);
		panel1.Controls.Add(ckbCurrentCity);
		panel1.Controls.Add(ckbCollege);
		panel1.Controls.Add(ckbHighSchool);
		panel1.Controls.Add(EB8607A6);
		panel1.Controls.Add(btnNhapHometown);
		panel1.Controls.Add(btnNhapCurrentCity);
		panel1.Controls.Add(ckbBio);
		panel1.Controls.Add(btnNickname);
		panel1.Controls.Add(btnNhapBio);
		panel1.Controls.Add(txtTenHanhDong);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(E00AD383);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(840, 425);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		F9226037.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F9226037.Controls.Add(FC225036);
		F9226037.Controls.Add(A09E9DB4);
		F9226037.Controls.Add(label7);
		F9226037.Controls.Add(btnNhapCollege);
		F9226037.Location = new System.Drawing.Point(29, 299);
		F9226037.Name = "plCollege";
		F9226037.Size = new System.Drawing.Size(322, 66);
		F9226037.TabIndex = 129;
		FC225036.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		FC225036.FormattingEnabled = true;
		FC225036.Location = new System.Drawing.Point(130, 36);
		FC225036.Name = "cbbIfHaveCollege";
		FC225036.Size = new System.Drawing.Size(185, 24);
		FC225036.TabIndex = 125;
		A09E9DB4.AutoSize = true;
		A09E9DB4.Location = new System.Drawing.Point(3, 39);
		A09E9DB4.Name = "label6";
		A09E9DB4.Size = new System.Drawing.Size(123, 16);
		A09E9DB4.TabIndex = 31;
		A09E9DB4.Text = "Nê\u0301u đa\u0303 co\u0301 thông tin:";
		label7.AutoSize = true;
		label7.Location = new System.Drawing.Point(3, 9);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(84, 16);
		label7.TabIndex = 31;
		label7.Text = "Nhâ\u0323p dư\u0303 liê\u0323u:";
		btnNhapCollege.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapCollege.Location = new System.Drawing.Point(129, 4);
		btnNhapCollege.Name = "btnNhapCollege";
		btnNhapCollege.Size = new System.Drawing.Size(187, 27);
		btnNhapCollege.TabIndex = 124;
		btnNhapCollege.Text = "Nhập (0)";
		btnNhapCollege.UseVisualStyleBackColor = true;
		btnNhapCollege.Click += new System.EventHandler(btnNhapCollege_Click);
		plHighSchool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		plHighSchool.Controls.Add(cbbIfHaveHighSchool);
		plHighSchool.Controls.Add(label4);
		plHighSchool.Controls.Add(label5);
		plHighSchool.Controls.Add(btnNhapHighSchool);
		plHighSchool.Location = new System.Drawing.Point(29, 205);
		plHighSchool.Name = "plHighSchool";
		plHighSchool.Size = new System.Drawing.Size(322, 66);
		plHighSchool.TabIndex = 129;
		cbbIfHaveHighSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbIfHaveHighSchool.FormattingEnabled = true;
		cbbIfHaveHighSchool.Location = new System.Drawing.Point(130, 36);
		cbbIfHaveHighSchool.Name = "cbbIfHaveHighSchool";
		cbbIfHaveHighSchool.Size = new System.Drawing.Size(185, 24);
		cbbIfHaveHighSchool.TabIndex = 125;
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(3, 39);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(123, 16);
		label4.TabIndex = 31;
		label4.Text = "Nê\u0301u đa\u0303 co\u0301 thông tin:";
		label5.AutoSize = true;
		label5.Location = new System.Drawing.Point(3, 9);
		label5.Name = "label5";
		label5.Size = new System.Drawing.Size(84, 16);
		label5.TabIndex = 31;
		label5.Text = "Nhâ\u0323p dư\u0303 liê\u0323u:";
		btnNhapHighSchool.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapHighSchool.Location = new System.Drawing.Point(129, 4);
		btnNhapHighSchool.Name = "btnNhapHighSchool";
		btnNhapHighSchool.Size = new System.Drawing.Size(187, 27);
		btnNhapHighSchool.TabIndex = 124;
		btnNhapHighSchool.Text = "Nhập (0)";
		btnNhapHighSchool.UseVisualStyleBackColor = true;
		btnNhapHighSchool.Click += new System.EventHandler(AF939593);
		EB281C82.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		EB281C82.Controls.Add(cbbIfHaveWork);
		EB281C82.Controls.Add(btnNhapWork);
		EB281C82.Controls.Add(label3);
		EB281C82.Controls.Add(ED35CF00);
		EB281C82.Location = new System.Drawing.Point(29, 110);
		EB281C82.Name = "plWork";
		EB281C82.Size = new System.Drawing.Size(322, 67);
		EB281C82.TabIndex = 129;
		cbbIfHaveWork.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbIfHaveWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbIfHaveWork.FormattingEnabled = true;
		cbbIfHaveWork.Location = new System.Drawing.Point(130, 36);
		cbbIfHaveWork.Name = "cbbIfHaveWork";
		cbbIfHaveWork.Size = new System.Drawing.Size(185, 24);
		cbbIfHaveWork.TabIndex = 125;
		btnNhapWork.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapWork.Location = new System.Drawing.Point(129, 4);
		btnNhapWork.Name = "btnNhapWork";
		btnNhapWork.Size = new System.Drawing.Size(187, 27);
		btnNhapWork.TabIndex = 124;
		btnNhapWork.Text = "Nhập (0)";
		btnNhapWork.UseVisualStyleBackColor = true;
		btnNhapWork.Click += new System.EventHandler(btnNhapWork_Click);
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(3, 39);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(123, 16);
		label3.TabIndex = 31;
		label3.Text = "Nê\u0301u đa\u0303 co\u0301 thông tin:";
		ED35CF00.AutoSize = true;
		ED35CF00.Location = new System.Drawing.Point(3, 9);
		ED35CF00.Name = "label2";
		ED35CF00.Size = new System.Drawing.Size(84, 16);
		ED35CF00.TabIndex = 31;
		ED35CF00.Text = "Nhâ\u0323p dư\u0303 liê\u0323u:";
		CDB39216.Cursor = System.Windows.Forms.Cursors.Hand;
		CDB39216.Location = new System.Drawing.Point(744, 244);
		CDB39216.Name = "btnYear";
		CDB39216.Size = new System.Drawing.Size(61, 25);
		CDB39216.TabIndex = 128;
		CDB39216.Text = "Năm";
		CDB39216.UseVisualStyleBackColor = true;
		CDB39216.Click += new System.EventHandler(E005B6AA);
		btnMonth.Cursor = System.Windows.Forms.Cursors.Hand;
		btnMonth.Location = new System.Drawing.Point(676, 244);
		btnMonth.Name = "btnMonth";
		btnMonth.Size = new System.Drawing.Size(61, 25);
		btnMonth.TabIndex = 128;
		btnMonth.Text = "Tháng";
		btnMonth.UseVisualStyleBackColor = true;
		btnMonth.Click += new System.EventHandler(btnMonth_Click);
		btnDay.Cursor = System.Windows.Forms.Cursors.Hand;
		btnDay.Location = new System.Drawing.Point(609, 244);
		btnDay.Name = "btnDay";
		btnDay.Size = new System.Drawing.Size(61, 25);
		btnDay.TabIndex = 128;
		btnDay.Text = "Ngày";
		btnDay.UseVisualStyleBackColor = true;
		btnDay.Click += new System.EventHandler(btnDay_Click);
		cbbGender.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbGender.FormattingEnabled = true;
		cbbGender.Location = new System.Drawing.Point(609, 215);
		cbbGender.Name = "cbbGender";
		cbbGender.Size = new System.Drawing.Size(195, 24);
		cbbGender.TabIndex = 126;
		EF02ED8E.AutoSize = true;
		EF02ED8E.Cursor = System.Windows.Forms.Cursors.Hand;
		EF02ED8E.Location = new System.Drawing.Point(388, 279);
		EF02ED8E.Name = "ckbNickname";
		EF02ED8E.Size = new System.Drawing.Size(81, 20);
		EF02ED8E.TabIndex = 125;
		EF02ED8E.Text = "Nickname";
		EF02ED8E.UseVisualStyleBackColor = true;
		EF02ED8E.CheckedChanged += new System.EventHandler(EF02ED8E_CheckedChanged);
		EB2C33BE.AutoSize = true;
		EB2C33BE.Cursor = System.Windows.Forms.Cursors.Hand;
		EB2C33BE.Location = new System.Drawing.Point(388, 247);
		EB2C33BE.Name = "ckbBirthday";
		EB2C33BE.Size = new System.Drawing.Size(141, 20);
		EB2C33BE.TabIndex = 125;
		EB2C33BE.Text = "Ngày sinh (Birthday)";
		EB2C33BE.UseVisualStyleBackColor = true;
		EB2C33BE.CheckedChanged += new System.EventHandler(EB2C33BE_CheckedChanged);
		cbbRelationship.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		cbbRelationship.FormattingEnabled = true;
		cbbRelationship.Location = new System.Drawing.Point(609, 185);
		cbbRelationship.Name = "cbbRelationship";
		cbbRelationship.Size = new System.Drawing.Size(195, 24);
		cbbRelationship.TabIndex = 126;
		B33CB017.AutoSize = true;
		B33CB017.Cursor = System.Windows.Forms.Cursors.Hand;
		B33CB017.Location = new System.Drawing.Point(388, 217);
		B33CB017.Name = "ckbGender";
		B33CB017.Size = new System.Drawing.Size(127, 20);
		B33CB017.TabIndex = 125;
		B33CB017.Text = "Giới tính (Gender)";
		B33CB017.UseVisualStyleBackColor = true;
		B33CB017.CheckedChanged += new System.EventHandler(B33CB017_CheckedChanged);
		ckbRelationship.AutoSize = true;
		ckbRelationship.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbRelationship.Location = new System.Drawing.Point(388, 187);
		ckbRelationship.Name = "ckbRelationship";
		ckbRelationship.Size = new System.Drawing.Size(218, 20);
		ckbRelationship.TabIndex = 125;
		ckbRelationship.Text = "Tình trạng quan hệ (Relationship)";
		ckbRelationship.UseVisualStyleBackColor = true;
		ckbRelationship.CheckedChanged += new System.EventHandler(FD83F438);
		ckbHometown.AutoSize = true;
		ckbHometown.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHometown.Location = new System.Drawing.Point(388, 154);
		ckbHometown.Name = "ckbHometown";
		ckbHometown.Size = new System.Drawing.Size(156, 20);
		ckbHometown.TabIndex = 125;
		ckbHometown.Text = "Quê quán (Hometown)";
		ckbHometown.UseVisualStyleBackColor = true;
		ckbHometown.CheckedChanged += new System.EventHandler(ckbHometown_CheckedChanged);
		ckbCurrentCity.AutoSize = true;
		ckbCurrentCity.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCurrentCity.Location = new System.Drawing.Point(388, 121);
		ckbCurrentCity.Name = "ckbCurrentCity";
		ckbCurrentCity.Size = new System.Drawing.Size(215, 20);
		ckbCurrentCity.TabIndex = 125;
		ckbCurrentCity.Text = "Thành phố hiện tại (Current City)";
		ckbCurrentCity.UseVisualStyleBackColor = true;
		ckbCurrentCity.CheckedChanged += new System.EventHandler(ckbCurrentCity_CheckedChanged);
		ckbCollege.AutoSize = true;
		ckbCollege.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbCollege.Location = new System.Drawing.Point(29, 277);
		ckbCollege.Name = "ckbCollege";
		ckbCollege.Size = new System.Drawing.Size(169, 20);
		ckbCollege.TabIndex = 125;
		ckbCollege.Text = "Trường đại học (College)";
		ckbCollege.UseVisualStyleBackColor = true;
		ckbCollege.CheckedChanged += new System.EventHandler(ckbCollege_CheckedChanged);
		ckbHighSchool.AutoSize = true;
		ckbHighSchool.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbHighSchool.Location = new System.Drawing.Point(29, 183);
		ckbHighSchool.Name = "ckbHighSchool";
		ckbHighSchool.Size = new System.Drawing.Size(207, 20);
		ckbHighSchool.TabIndex = 125;
		ckbHighSchool.Text = "Trường trung học (High School)";
		ckbHighSchool.UseVisualStyleBackColor = true;
		ckbHighSchool.CheckedChanged += new System.EventHandler(B1850E2D);
		EB8607A6.AutoSize = true;
		EB8607A6.Cursor = System.Windows.Forms.Cursors.Hand;
		EB8607A6.Location = new System.Drawing.Point(29, 88);
		EB8607A6.Name = "ckbWork";
		EB8607A6.Size = new System.Drawing.Size(125, 20);
		EB8607A6.TabIndex = 125;
		EB8607A6.Text = "Công việc (Work)";
		EB8607A6.UseVisualStyleBackColor = true;
		EB8607A6.CheckedChanged += new System.EventHandler(DBA1FEB1);
		btnNhapHometown.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapHometown.Location = new System.Drawing.Point(609, 150);
		btnNhapHometown.Name = "btnNhapHometown";
		btnNhapHometown.Size = new System.Drawing.Size(195, 27);
		btnNhapHometown.TabIndex = 124;
		btnNhapHometown.Text = "Nhập (0)";
		btnNhapHometown.UseVisualStyleBackColor = true;
		btnNhapHometown.Click += new System.EventHandler(btnNhapHometown_Click);
		btnNhapCurrentCity.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapCurrentCity.Location = new System.Drawing.Point(609, 117);
		btnNhapCurrentCity.Name = "btnNhapCurrentCity";
		btnNhapCurrentCity.Size = new System.Drawing.Size(195, 27);
		btnNhapCurrentCity.TabIndex = 124;
		btnNhapCurrentCity.Text = "Nhập (0)";
		btnNhapCurrentCity.UseVisualStyleBackColor = true;
		btnNhapCurrentCity.Click += new System.EventHandler(F99F3E9D);
		ckbBio.AutoSize = true;
		ckbBio.Cursor = System.Windows.Forms.Cursors.Hand;
		ckbBio.Location = new System.Drawing.Point(388, 88);
		ckbBio.Name = "ckbBio";
		ckbBio.Size = new System.Drawing.Size(191, 20);
		ckbBio.TabIndex = 125;
		ckbBio.Text = "Tiểu sử mô tả bản thân (Bio)";
		ckbBio.UseVisualStyleBackColor = true;
		ckbBio.CheckedChanged += new System.EventHandler(FC2B8CA7);
		btnNickname.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNickname.Location = new System.Drawing.Point(609, 275);
		btnNickname.Name = "btnNickname";
		btnNickname.Size = new System.Drawing.Size(195, 27);
		btnNickname.TabIndex = 124;
		btnNickname.Text = "Nhập (0)";
		btnNickname.UseVisualStyleBackColor = true;
		btnNickname.Click += new System.EventHandler(btnNickname_Click);
		btnNhapBio.Cursor = System.Windows.Forms.Cursors.Hand;
		btnNhapBio.Location = new System.Drawing.Point(609, 84);
		btnNhapBio.Name = "btnNhapBio";
		btnNhapBio.Size = new System.Drawing.Size(101, 27);
		btnNhapBio.TabIndex = 124;
		btnNhapBio.Text = "Nhập (0)";
		btnNhapBio.UseVisualStyleBackColor = true;
		btnNhapBio.Click += new System.EventHandler(E58ADCA3);
		txtTenHanhDong.Location = new System.Drawing.Point(125, 49);
		txtTenHanhDong.Name = "txtTenHanhDong";
		txtTenHanhDong.Size = new System.Drawing.Size(226, 23);
		txtTenHanhDong.TabIndex = 0;
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(26, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(427, 380);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 7;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		E00AD383.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E00AD383.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		E00AD383.Cursor = System.Windows.Forms.Cursors.Hand;
		E00AD383.FlatAppearance.BorderSize = 0;
		E00AD383.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		E00AD383.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		E00AD383.ForeColor = System.Drawing.Color.White;
		E00AD383.Location = new System.Drawing.Point(320, 380);
		E00AD383.Name = "btnAdd";
		E00AD383.Size = new System.Drawing.Size(92, 29);
		E00AD383.TabIndex = 6;
		E00AD383.Text = "Thêm";
		E00AD383.UseVisualStyleBackColor = false;
		E00AD383.Click += new System.EventHandler(BA35B69E);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(C121063B);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(837, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(840, 425);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDCapNhatThongTin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(CAB700BC_Load);
		C121063B.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		F9226037.ResumeLayout(false);
		F9226037.PerformLayout();
		plHighSchool.ResumeLayout(false);
		plHighSchool.PerformLayout();
		EB281C82.ResumeLayout(false);
		EB281C82.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
