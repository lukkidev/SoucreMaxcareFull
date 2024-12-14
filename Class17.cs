using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

internal class Class17
{
	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetUseragentIphone();

	public static string smethod_0()
	{
		return GClass8.smethod_10(GetUseragentIphone());
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetUseragentIpad();

	public static string smethod_1()
	{
		return GClass8.smethod_10(GetUseragentIpad());
	}

	public static List<string> smethod_2()
	{
		return new List<string>
		{
			"0|Random", "1|Ha Noi", "2|Phu Tho", "3|Ho Chi Minh", "4|Dak Lak", "5|Hai Duong", "6|Binh Dinh", "7|Nghe An", "8|Nam Dinh", "10|Thai Binh",
			"11|Ha Tinh"
		};
	}

	public static List<string> smethod_3()
	{
		return new List<string>
		{
			"so_SO|Af-Soomaali", "af_ZA|Afrikaans", "az_AZ|Azərbaycan dili", "id_ID|Bahasa Indonesia", "ms_MY|Bahasa Melayu", "jv_ID|Basa Jawa", "cx_PH|Bisaya", "bs_BA|Bosanski", "br_FR|Brezhoneg", "ca_ES|Català",
			"co_FR|Corsu", "cy_GB|Cymraeg", "da_DK|Dansk", "de_DE|Deutsch", "et_EE|Eesti", "en_GB|English (UK)", "en_US|English (US)", "en_UD|English (uʍop əpısdՈ)", "es_LA|Español", "es_ES|Español (España)",
			"eo_EO|Esperanto", "eu_ES|Euskara", "tl_PH|Filipino", "fr_CA|Français (Canada)", "fr_FR|Français (France)", "fy_NL|Frysk", "ff_NG|Fula", "fo_FO|Føroyskt", "ga_IE|Gaeilge", "gl_ES|Galego",
			"gn_PY|Guarani", "ha_NG|Hausa", "hr_HR|Hrvatski", "rw_RW|Ikinyarwanda", "it_IT|Italiano", "sw_KE|Kiswahili", "ht_HT|Kreyòl Ayisyen", "ku_TR|Kurdî (Kurmancî)", "lv_LV|Latviešu", "lt_LT|Lietuvių",
			"hu_HU|Magyar", "mg_MG|Malagasy", "mt_MT|Malti", "nl_NL|Nederlands", "nl_BE|Nederlands (België)", "nb_NO|Norsk (bokmål)", "nn_NO|Norsk (nynorsk)", "uz_UZ|O'zbek", "pl_PL|Polski", "pt_BR|Português (Brasil)",
			"pt_PT|Português (Portugal)", "ro_RO|Română", "sc_IT|Sardu", "sn_ZW|Shona", "sq_AL|Shqip", "sk_SK|Slovenčina", "sl_SI|Slovenščina", "fi_FI|Suomi", "sv_SE|Svenska", "vi_VN|Tiếng Việt",
			"tr_TR|Türkçe", "zz_TR|Zaza", "is_IS|Íslenska", "cs_CZ|Čeština", "sz_PL|ślōnskŏ gŏdka", "el_GR|Ελληνικά", "be_BY|Беларуская", "bg_BG|Български", "mk_MK|Македонски", "mn_MN|Монгол",
			"ru_RU|Русский", "sr_RS|Српски", "tt_RU|Татарча", "tg_TJ|Тоҷикӣ", "uk_UA|Українська", "ky_KG|кыргызча", "kk_KZ|Қазақша", "hy_AM|Հայերեն", "he_IL|עברית", "ur_PK|اردو",
			"ar_AR|العربية", "fa_IR|فارسی", "ps_AF|پښتو", "cb_IQ|کوردیی ناوەندی", "sy_SY|ܣܘܪܝܝܐ", "ne_NP|न\u0947प\u093eल\u0940", "mr_IN|मर\u093eठ\u0940", "hi_IN|ह\u093fन\u094dद\u0940", "as_IN|অসম\u09c0য\u09bc\u09be", "bn_IN|ব\u09be\u0982ল\u09be",
			"pa_IN|ਪ\u0a70ਜ\u0a3eਬ\u0a40", "gu_IN|ગ\u0ac1જર\u0abeત\u0ac0", "or_IN|ଓଡ\u0b3c\u0b3fଆ", "ta_IN|தம\u0bbfழ\u0bcd", "te_IN|త\u0c46ల\u0c41గ\u0c41", "kn_IN|ಕನ\u0ccdನಡ", "ml_IN|മലയ\u0d3eള\u0d02", "si_LK|ස\u0dd2\u0d82හල", "th_TH|ภาษาไทย", "lo_LA|ພາສາລາວ",
			"my_MM|မ\u103cန\u103aမ\u102cဘ\u102cသ\u102c", "ka_GE|ქართული", "am_ET|አማርኛ", "km_KH|ភ\u17b6ស\u17b6ខ\u17d2ម\u17c2រ", "tz_MA|ⵜⴰⵎⴰⵣⵉⵖⵜ", "zh_TW|中文(台灣)", "zh_CN|中文(简体)", "zh_HK|中文(香港)", "ja_JP|日本語", "ja_KS|日本語(関西)",
			"ko_KR|한국어"
		};
	}

	public static List<string> smethod_4()
	{
		string text = "Nguyễn|Trần|Lê|Phạm|Hoàng|Phan|Vũ|Đặng|Bùi|Đỗ|Hồ|Ngô|Dương|Lý|Huỳnh|Võ";
		return text.Split('|').ToList();
	}

	public static List<string> smethod_5()
	{
		return new List<string>
		{
			"Diệu", "Quỳnh", "Trâm", "Nguyệt", "Trân", "Quế", "Trúc", "Xuyến", "Thiên", "Ngọc",
			"Nghi", "Linh", "Thục", "Thu", "Thiên", "Hiếu", "Thái", "Dạ", "Quỳnh", "Thiên",
			"Ái", "Kim", "Vân", "Hồng", "Minh", "Diễm", "Chi", "Bạch", "Ngọc", "Mộc",
			"Ha", "Thương", "Dại", "Thu", "Uyển", "Yến", "Thục", "Hạnh", "Thanh", "Tú",
			"Song", "Cát", "Lâm", "Hương", "Dạ", "Anh", "Đoan", "Phượng", "Tịnh", "Hải",
			"Thiên", "Gia", "Thành", "Trung", "Thái", "Hải", "Thành", "Thông", "Phúc", "Tài",
			"Mạnh", "Chấn", "Bảo", "Khang", "Đăng", "Tuấn", "Thanh", "Hiền", "Thiện", "Thụ",
			"Minh", "Nhân", "Trọng", "Trung", "Khôi", "Hạo", "Phương", "Thanh", "Hữu", "Minh",
			"Đông", "Sơn", "Tùng", "Ái", "Thái", "Trường", "Thiện", "Thạch", "An", "Anh",
			"Thanh", "Chiến", "Toàn", "Minh", "Đình", "Kiến", "Nhân", "Khôi", "Quang", "Uy",
			"Hoài", "Huyền", "Thùy", "Trung", "Tú", "Vàng", "Hạ", "Lệ", "Tuyết", "Yên",
			"Ngọc", "Bảo", "Khải", "Sơn", "Nguyệt", "Bảo", "Ly", "Minh", "Hương", "Lan",
			"Lien", "Linh", "Mai", "Quỳnh", "Hiền", "Hạc", "Nhật", "Quỳnh", "Huyền", "Kỳ",
			"Vinh", "Thụy", "Van", "Hạnh", "Kiều", "Từ", "Thien", "Hải", "Hướng", "Thuy",
			"Kim", "Minh", "Yen", "Truc", "Hồng", "Hạ", "Hồng", "Hương", "Khánh"
		};
	}

	public static List<string> smethod_6()
	{
		return new List<string>
		{
			"Anh", "Cát", "Châu", "Chi", "Di", "Diệp", "Dung", "Đan", "Đoan", "Giang",
			"Hà", "Hạnh", "Hòa", "Hương", "Khanh", "Khánh", "Khuê", "Khue", "Kiều", "Lan",
			"Lien", "Mien", "Mi", "Nga", "Ngọc", "Nguyệt", "Nhã", "Oanh", "Quyên", "San",
			"Tâm", "Thư", "Tường", "Tuyền", "Thảo", "Thi", "Trang", "Vũ", "Yên", "Yến",
			"Ân", "Bảo", "Công", "Dũng", "Dương", "Đăng", "Đạt", "Điền", "Đức", "Hùng",
			"Hưng", "Kiện", "Khoa", "Kiệt", "Liêm", "Minh", "Ngôn", "Nhân", "Nhật", "Nghĩa",
			"Nguyên", "Nhiên", "Phi", "Phong", "Phước", "Quân", "Quốc", "Sơn", "Tùng", "Thái",
			"Thế", "Thắng", "Triết", "Trung", "Văn", "Vĩ", "Vinh", "An", "Băng", "Bằng",
			"Bích", "Bình", "Ca", "Chau", "Chung", "Cuc", "Dạ", "Dao", "Diệu", "Du",
			"Duyen", "Dan", "Dang"
		};
	}

	public static List<string> smethod_7()
	{
		return new List<string>
		{
			"Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor",
			"Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson",
			"Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King",
			"Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter",
			"Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins",
			"Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey",
			"Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez",
			"James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross",
			"Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington",
			"Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander"
		};
	}

	public static List<string> EE98A8B8()
	{
		return new List<string>
		{
			"James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles",
			"Christopher", "Daniel", "Matthew", "Anthony", "Donald", "Mark", "Paul", "Steven", "Andrew", "Kenneth",
			"Joshua", "George", "Kevin", "Brian", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan",
			"Jacob", "Gary", "Nicholas", "Eric", "Stephen", "Jonathan", "Larry", "Justin", "Scott", "Brandon",
			"Frank", "Benjamin", "Gregory", "Samuel", "Raymond", "Patrick", "Alexander", "Jack", "Dennis", "Jerry",
			"Tyler", "Aaron", "Jose", "Henry", "Douglas", "Adam", "Peter", "Nathan", "Zachary", "Walter",
			"Kyle", "Harold", "Carl", "Jeremy", "Keith", "Roger", "Gerald", "Ethan", "Arthur", "Terry",
			"Christian", "Sean", "Lawrence", "Austin", "Joe", "Noah", "Jesse", "Albert", "Bryan", "Billy",
			"Bruce", "Willie", "Jordan", "Dylan", "Alan", "Ralph", "Gabriel", "Roy", "Juan", "Wayne",
			"Eugene", "Logan", "Randy", "Louis", "Russell", "Vincent", "Philip", "Bobby", "Johnny", "Bradley"
		};
	}

	public static void E1825E02()
	{
		if (!GClass25.D311242C())
		{
			smethod_8();
			Class81.bool_0 = GClass25.smethod_0("configGeneral").method_3("ckbLuuTrangThai");
			Class81.smethod_1();
		}
	}

	private static void smethod_8()
	{
		Class15.smethod_17("accounts", "fa2", 1);
		Class15.smethod_17("accounts", "useragent", 1);
		Class15.smethod_17("accounts", "proxy", 1);
		Class15.smethod_17("accounts", "dateCreateAcc", 1);
		Class15.smethod_17("accounts", "avatar", 1);
		Class15.smethod_17("accounts", "profile", 1);
		Class15.smethod_17("accounts", "ghiChu", 1);
		Class15.smethod_17("accounts", "follow", 1);
		Class15.smethod_17("accounts", "interactEnd", 1);
		Class15.smethod_17("accounts", "dateImport", 1);
		Class15.smethod_17("accounts", "pass_old", 1);
		Class15.smethod_17("accounts", "status", 1);
		Class15.smethod_17("accounts", "location", 1);
		Class15.smethod_17("accounts", "hometown", 1);
		Class15.smethod_17("accounts", "currentCity", 1);
		Class15.smethod_17("accounts", "pages", 1);
		Class15.smethod_17("accounts", "dating", 1);
		Class15.smethod_17("accounts", "ads", 1);
		Class15.smethod_17("accounts", "bm", 1);
		Class15.smethod_17("accounts", "pagePro5", 1);
		Class15.smethod_17("accounts", "wallPosts", 1);
		Class15.smethod_17("accounts", "fbBlock", 1);
		Class15.smethod_17("accounts", "job", 1);
		Class15.smethod_17("accounts", "status282", 1);
		Class15.smethod_17("accounts", "email2", 1);
		Class15.smethod_17("accounts", "email_old", 1);
		Class15.smethod_17("accounts", "kichban", 1);
		Class15.smethod_17("accounts", "infoDevice", 1);
		Class15.smethod_17("accounts", "created_at", 1);
		Class15.smethod_17("accounts", "updated_at", 1);
		Class15.smethod_17("accounts", "passmailrecovery", 1);
		if (!Class15.ADBBA9AA("accounts", "cookie1"))
		{
			Class15.smethod_17("accounts", "cookie1", 1);
			Class53.smethod_1("UPDATE accounts SET cookie1=cookie");
		}
		if (!Class15.ADBBA9AA("accounts", "active"))
		{
			Class15.smethod_17("accounts", "active", 0);
			Class53.smethod_1("UPDATE accounts SET active=1");
		}
		if (!Class15.ADBBA9AA("accounts", "dateDelete"))
		{
			Class15.smethod_17("accounts", "dateDelete", 1);
		}
		if (!Class15.ADBBA9AA("files", "STT"))
		{
			Class15.smethod_17("files", "STT", 0);
			Class53.smethod_1("UPDATE files SET STT=id");
		}
		Class53.smethod_1("UPDATE files SET STT = id WHERE stt IS NULL");
		if (!Class15.ADBBA9AA("files", "active"))
		{
			Class15.smethod_17("files", "active", 0);
			Class53.smethod_1("UPDATE files SET active=1");
		}
		Class53.smethod_1("UPDATE accounts SET active = 1 WHERE active = 2");
		Class147.DF112787("Kich_Ban", "CauHinh", 1);
		if (!Class147.smethod_0("Kich_Ban", "STT"))
		{
			Class147.DF112787("Kich_Ban", "STT", 0);
			GClass32.BC97849E.D61A7A94("UPDATE Kich_Ban SET STT=Id_KichBan");
		}
	}

	public static void smethod_9()
	{
		GClass8.smethod_32("backup");
		GClass8.smethod_32("settings");
		GClass8.smethod_32("profiles");
		GClass8.smethod_32("update");
		GClass8.smethod_32("photos");
		GClass8.smethod_32("Image282");
		GClass8.smethod_32("posts");
		GClass8.smethod_32("settings\\setting");
		GClass8.smethod_32("golike");
		GClass8.smethod_32("backupgroup");
		GClass8.smethod_32("output");
		GClass8.smethod_32("gologin");
	}
}
