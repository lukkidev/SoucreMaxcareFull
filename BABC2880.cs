using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class BABC2880 : Form
{
	private GClass11 gclass11_0;

	private string F62CEE8A;

	private string A5380A95;

	private string string_0;

	private int int_0;

	public static bool bool_0;

	private IContainer icontainer_0 = null;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuDragControl AD03401D;

	private Panel D836980E;

	private TextBox B5AA4A23;

	private Label CC8B2814;

	private Button B1A6A1B8;

	private Button AE904D12;

	private BunifuCards bunifuCards1;

	private Panel A09B2A17;

	private Button button1;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private ToolTip toolTip_0;

	private ComboBox cbbLanguage;

	private Label E820F8A6;

	public BABC2880(string string_1, int int_1 = 0, string string_2 = "")
	{
		InitializeComponent();
		bool_0 = false;
		F62CEE8A = string_1;
		string_0 = string_2;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Đổi ngôn ngữ";
		if (Class147.smethod_7("", text).Rows.Count == 0)
		{
			GClass32.BC97849E.D61A7A94("INSERT INTO \"main\".\"Tuong_Tac\" (\"TenTuongTac\", \"MoTa\") VALUES ('" + text + "', '" + text2 + "');");
		}
		string string_3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_3 = dataTable2.Rows[0]["CauHinh"].ToString();
			A5380A95 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			B5AA4A23.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_2);
			string_3 = dataTable.Rows[0]["CauHinh"].ToString();
			AE904D12.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			B5AA4A23.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		gclass11_0 = new GClass11(string_3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void BABC2880_Load(object sender, EventArgs e)
	{
		try
		{
			cbbLanguage.Text = gclass11_0.C0288288("cbbLanguage");
		}
		catch
		{
		}
	}

	private void EF0F8F89(object sender, EventArgs e)
	{
		Close();
	}

	private void AE904D12_Click(object sender, EventArgs e)
	{
		string text = B5AA4A23.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		GClass11 gClass = new GClass11();
		gClass.method_4("cbbLanguage", cbbLanguage.Text);
		string text2 = gClass.method_7();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(F62CEE8A, text, A5380A95, text2))
				{
					bool_0 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_0, text, text2))
			{
				bool_0 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void B1A6A1B8_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void BC301A81(object sender, PaintEventArgs e)
	{
		if (D836980E.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, D836980E.ClientSize.Width - num, D836980E.ClientSize.Height - num));
		}
	}

	private void method_0(object sender, EventArgs e)
	{
	}

	private void B1220535(object sender, EventArgs e)
	{
		string eD = "Có thể sử dụng ký tự * để random 1 ký tự ngẫu nhiên!\r\nVí dụ: MIN****** => MINdfghta";
		GClass29.smethod_0(eD);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BABC2880));
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		AD03401D = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		A09B2A17 = new System.Windows.Forms.Panel();
		button1 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		D836980E = new System.Windows.Forms.Panel();
		cbbLanguage = new System.Windows.Forms.ComboBox();
		E820F8A6 = new System.Windows.Forms.Label();
		B5AA4A23 = new System.Windows.Forms.TextBox();
		CC8B2814 = new System.Windows.Forms.Label();
		B1A6A1B8 = new System.Windows.Forms.Button();
		AE904D12 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		toolTip_0 = new System.Windows.Forms.ToolTip(icontainer_0);
		A09B2A17.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		D836980E.SuspendLayout();
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
		bunifuCustomLabel1.Size = new System.Drawing.Size(345, 31);
		bunifuCustomLabel1.TabIndex = 12;
		bunifuCustomLabel1.Text = "Cấu hình Đổi ngôn ngữ";
		bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		AD03401D.Fixed = true;
		AD03401D.Horizontal = true;
		AD03401D.TargetControl = A09B2A17;
		AD03401D.Vertical = true;
		A09B2A17.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		A09B2A17.BackColor = System.Drawing.Color.White;
		A09B2A17.Controls.Add(button1);
		A09B2A17.Controls.Add(pictureBox1);
		A09B2A17.Controls.Add(bunifuCustomLabel1);
		A09B2A17.Cursor = System.Windows.Forms.Cursors.SizeAll;
		A09B2A17.Location = new System.Drawing.Point(0, 3);
		A09B2A17.Name = "pnlHeader";
		A09B2A17.Size = new System.Drawing.Size(345, 31);
		A09B2A17.TabIndex = 9;
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		button1.Cursor = System.Windows.Forms.Cursors.Hand;
		button1.FlatAppearance.BorderSize = 0;
		button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		button1.ForeColor = System.Drawing.Color.White;
		button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		button1.Location = new System.Drawing.Point(314, 1);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(30, 30);
		button1.TabIndex = 77;
		button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		button1.UseVisualStyleBackColor = true;
		button1.Click += new System.EventHandler(EF0F8F89);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		D836980E.BackColor = System.Drawing.Color.White;
		D836980E.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D836980E.Controls.Add(cbbLanguage);
		D836980E.Controls.Add(E820F8A6);
		D836980E.Controls.Add(B5AA4A23);
		D836980E.Controls.Add(CC8B2814);
		D836980E.Controls.Add(B1A6A1B8);
		D836980E.Controls.Add(AE904D12);
		D836980E.Controls.Add(bunifuCards1);
		D836980E.Cursor = System.Windows.Forms.Cursors.Arrow;
		D836980E.Dock = System.Windows.Forms.DockStyle.Fill;
		D836980E.Location = new System.Drawing.Point(0, 0);
		D836980E.Name = "panel1";
		D836980E.Size = new System.Drawing.Size(348, 162);
		D836980E.TabIndex = 0;
		D836980E.Paint += new System.Windows.Forms.PaintEventHandler(BC301A81);
		cbbLanguage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
		cbbLanguage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
		cbbLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
		cbbLanguage.FormattingEnabled = true;
		cbbLanguage.Items.AddRange(new object[112]
		{
			"so_SO|Tiếng Somali", "af_ZA|Tiếng Afrikaans", "az_AZ|Tiếng Azerbaijan", "id_ID|Tiếng Indo", "ms_MY|Tiếng Mã Lai", "jv_ID|Tiếng Java", "cx_PH|Tiếng Cebuano", "bs_BA|Tiếng Bosnia", "br_FR|Tiếng Breton", "ca_ES|Tiếng Ca-ta-lăng",
			"co_FR|Tiếng Corse", "cy_GB|Tiếng Wales", "da_DK|Tiếng Đan Mạch", "de_DE|Tiếng Đức", "et_EE|Tiếng Estonia", "en_GB|Tiếng Anh (Anh)", "en_US|Tiếng Anh (Mỹ)", "es_LA|Tiếng Tây Ban Nha", "es_ES|Tiếng Tây Ban Nha (Tây Ban Nha)", "eo_EO|Tiếng Esperanto",
			"eu_ES|Tiếng Basque", "tl_PH|Tiếng Philippines", "fr_CA|Tiếng Pháp (Canada)", "fr_FR|Tiếng Pháp (Pháp)", "fy_NL|Tiếng Frisia", "ff_NG|Tiếng Fula", "fo_FO|Tiếng Faroe", "ga_IE|Tiếng Ai-len", "gl_ES|Tiếng Galic", "gn_PY|Tiếng Guarani",
			"ha_NG|Tiếng Hausa", "hr_HR|Tiếng Croatia", "rw_RW|Tiếng Kinyarwanda", "iu_CA|Tiếng Inuktitut", "it_IT|Tiếng Ý", "ik_US|Tiếng Inupiaq", "sw_KE|Tiếng Swahili", "ht_HT|Tiếng Haitian Creole", "ku_TR|Tiếng Kurdish (Kurmanji)", "lv_LV|Tiếng Latvia",
			"lt_LT|Tiếng Lithuania", "hu_HU|Tiếng Hungary", "mg_MG|Tiếng Malagasy", "mt_MT|Tiếng Malta", "nl_NL|Tiếng Hà Lan", "nb_NO|Tiếng Na Uy (bokmal)", "nn_NO|Tiếng Na-uy (nynorsk)", "uz_UZ|Tiếng Uzbek", "pl_PL|Tiếng Ba Lan", "pt_BR|Tiếng Bồ Đào Nha (Brazil)",
			"pt_PT|Tiếng Bồ Đào Nha (Bồ Đào Nha)", "ro_RO|Tiếng Rumani", "sc_IT|Tiếng Sardinia", "sn_ZW|Tiếng Shona", "sq_AL|Tiếng Albani", "sk_SK|Tiếng Slovakia", "sl_SI|Tiếng Sloven", "fi_FI|Tiếng Phần Lan", "sv_SE|Tiếng Thụy Điển", "vi_VN|Tiếng Việt",
			"tr_TR|Tiếng Thổ Nhĩ Kỳ", "nl_BE|Tiếng Hà Lan-Bỉ", "zz_TR|Tiếng Zaza", "is_IS|Tiếng Iceland", "cs_CZ|Tiếng Séc", "sz_PL|Tiếng Silesia", "el_GR|Tiếng Hy Lạp", "be_BY|Tiếng Belarus", "bg_BG|Tiếng Bungari", "mk_MK|Tiếng Macedoni",
			"mn_MN|Tiếng Mông Cổ", "ru_RU|Tiếng Nga", "sr_RS|Tiếng Serbia", "tt_RU|Tiê\u0301ng Tatar", "tg_TJ|Tiếng Tajik", "uk_UA|Tiếng U-krai-na", "ky_KG|Tiếng Kyrgyz", "kk_KZ|Tiếng Kazakh", "hy_AM|Tiếng Armenia", "he_IL|Tiếng Do Thái",
			"ur_PK|Tiếng Urdu", "ar_AR|Tiếng Ả Rập", "fa_IR|Tiếng Ba Tư", "ps_AF|Tiếng Pashto", "cb_IQ|Tiếng Kurd Sorani", "sy_SY|Tiếng Syria", "ne_NP|Tiếng Nepan", "mr_IN|Tiếng Marathi", "hi_IN|Tiếng Hin-di (Ấn Độ)", "as_IN|Tiếng Assam",
			"bn_IN|Tiếng Bengali", "pa_IN|Tiếng Punjabi", "gu_IN|Tiếng Gujarati", "or_IN|Tiếng Oriya", "ta_IN|Tiếng Tamil", "te_IN|Tiếng Telugu", "kn_IN|Tiếng Kannada", "ml_IN|Tiếng Malayalam", "si_LK|Tiếng Sinhala", "th_TH|Tiếng Thái",
			"lo_LA|Tiếng Lào", "my_MM|Tiếng Miến Điện", "ka_GE|Tiếng Georgia", "am_ET|Tiếng Amhara", "km_KH|Tiếng Khơ-me", "tz_MA|Tiếng Tamazight", "zh_TW|Tiếng Trung phồn thể (Đài Loan)", "zh_CN|Tiếng Trung giản thể (Trung Quốc)", "zh_HK|Tiếng Trung phồn thể (Hồng Kông)", "ja_JP|Tiếng Nhật",
			"ja_KS|Tiếng Nhật (Kansai)", "ko_KR|Tiếng Hàn"
		});
		cbbLanguage.Location = new System.Drawing.Point(125, 78);
		cbbLanguage.Name = "cbbLanguage";
		cbbLanguage.Size = new System.Drawing.Size(194, 24);
		cbbLanguage.TabIndex = 153;
		E820F8A6.AutoSize = true;
		E820F8A6.Location = new System.Drawing.Point(20, 81);
		E820F8A6.Name = "label3";
		E820F8A6.Size = new System.Drawing.Size(64, 16);
		E820F8A6.TabIndex = 31;
		E820F8A6.Text = "Tùy chọn:";
		B5AA4A23.Location = new System.Drawing.Point(125, 49);
		B5AA4A23.Name = "txtTenHanhDong";
		B5AA4A23.Size = new System.Drawing.Size(194, 23);
		B5AA4A23.TabIndex = 0;
		CC8B2814.AutoSize = true;
		CC8B2814.Location = new System.Drawing.Point(20, 52);
		CC8B2814.Name = "label1";
		CC8B2814.Size = new System.Drawing.Size(98, 16);
		CC8B2814.TabIndex = 31;
		CC8B2814.Text = "Tên ha\u0300nh đô\u0323ng:";
		B1A6A1B8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		B1A6A1B8.BackColor = System.Drawing.Color.Maroon;
		B1A6A1B8.Cursor = System.Windows.Forms.Cursors.Hand;
		B1A6A1B8.FlatAppearance.BorderSize = 0;
		B1A6A1B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		B1A6A1B8.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		B1A6A1B8.ForeColor = System.Drawing.Color.White;
		B1A6A1B8.Location = new System.Drawing.Point(184, 119);
		B1A6A1B8.Name = "btnCancel";
		B1A6A1B8.Size = new System.Drawing.Size(92, 29);
		B1A6A1B8.TabIndex = 7;
		B1A6A1B8.Text = "Đóng";
		B1A6A1B8.UseVisualStyleBackColor = false;
		B1A6A1B8.Click += new System.EventHandler(B1A6A1B8_Click);
		AE904D12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		AE904D12.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		AE904D12.Cursor = System.Windows.Forms.Cursors.Hand;
		AE904D12.FlatAppearance.BorderSize = 0;
		AE904D12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		AE904D12.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		AE904D12.ForeColor = System.Drawing.Color.White;
		AE904D12.Location = new System.Drawing.Point(77, 119);
		AE904D12.Name = "btnAdd";
		AE904D12.Size = new System.Drawing.Size(92, 29);
		AE904D12.TabIndex = 6;
		AE904D12.Text = "Thêm";
		AE904D12.UseVisualStyleBackColor = false;
		AE904D12.Click += new System.EventHandler(AE904D12_Click);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(A09B2A17);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(345, 37);
		bunifuCards1.TabIndex = 28;
		toolTip_0.AutomaticDelay = 0;
		toolTip_0.AutoPopDelay = 0;
		toolTip_0.InitialDelay = 0;
		toolTip_0.ReshowDelay = 0;
		toolTip_0.ShowAlways = true;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(348, 162);
		base.Controls.Add(D836980E);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDDoiNgonNgu";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(BABC2880_Load);
		A09B2A17.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		D836980E.ResumeLayout(false);
		D836980E.PerformLayout();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
