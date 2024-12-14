using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GClass19
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string string_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string AB0F6D25;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string AD378CA5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string AB913189;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string E619E2B4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal GClass18 gclass18_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	internal string string_4;

	public bool FFBDE098 = false;

	public static object object_0 = new object();

	public static object object_1 = new object();

	private static object F92CEA91 = new object();

	private static object A1BB0F3D = new object();

	public string DE2D8C14
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	[JsonProperty("id")]
	public string B222253E
	{
		[CompilerGenerated]
		get
		{
			return AB0F6D25;
		}
		[CompilerGenerated]
		set
		{
			AB0F6D25 = value;
		}
	}

	[JsonProperty("uid")]
	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return AD378CA5;
		}
		[CompilerGenerated]
		set
		{
			AD378CA5 = value;
		}
	}

	[JsonProperty("object_id")]
	public string A68CE239
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	[JsonProperty("link")]
	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	[JsonProperty("type")]
	public string F63D2D1F
	{
		[CompilerGenerated]
		get
		{
			return AB913189;
		}
		[CompilerGenerated]
		set
		{
			AB913189 = value;
		}
	}

	[JsonProperty("reaction")]
	public string B13EF8A9
	{
		[CompilerGenerated]
		get
		{
			return E619E2B4;
		}
		[CompilerGenerated]
		set
		{
			E619E2B4 = value;
		}
	}

	[JsonProperty("data_comment")]
	public GClass18 GClass18_0
	{
		[CompilerGenerated]
		get
		{
			return gclass18_0;
		}
		[CompilerGenerated]
		set
		{
			gclass18_0 = value;
		}
	}

	public string AEB2CFB2
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetJobs(byte[] byte_0, byte[] AF92562F, byte[] byte_1, byte[] byte_2, byte[] B9883100, byte[] byte_3, byte[] byte_4);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr UpdateJob(byte[] byte_0, byte[] C4A3DC2A, byte[] byte_1, byte[] byte_2, byte[] byte_3, byte[] E99E1291, byte[] byte_4, byte[] A2AE2E8E);

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckJobsv2(byte[] BBAB4483, byte[] byte_0, byte[] C62E7180, byte[] C2AD809E, byte[] byte_1, byte[] E18353B8, byte[] E0A8DA29);

	public static bool D622BE23(string string_5, string CB0E270F, string string_6, string string_7, string string_8, int FBB6B513 = 0)
	{
		try
		{
			string_6 = GClass8.CF09EFB3(string_6);
			string text = "";
			FBB6B513 = 0;
			if (GClass25.smethod_0("configDebug").method_3("ckbDebugWelike"))
			{
				FBB6B513 = 1;
			}
			text = GClass8.smethod_10(CheckJobsv2(GClass8.smethod_11(""), GClass8.smethod_11(string_5), GClass8.smethod_11(CB0E270F), GClass8.smethod_11(string_6), GClass8.smethod_11(string_7), GClass8.smethod_11(string_8), GClass8.smethod_11(FBB6B513.ToString())));
			return JObject.Parse(text)["success"]!.ToString().ToLower() == "true";
		}
		catch (Exception)
		{
		}
		return false;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetJobs2(byte[] FD10813D, byte[] E08C1BBE, byte[] AD8CA698, byte[] byte_0, byte[] F5233C3C, byte[] byte_1, byte[] byte_2);

	public static (List<GClass19> lstJobs, string error) smethod_0(string B620C7A1, string BA3BCD15, string string_5, string string_6, string string_7)
	{
		List<GClass19> list = new List<GClass19>();
		string text = "";
		string_5 = GClass8.CF09EFB3(string_5);
		int num = Class57.int_0;
		if (GClass25.smethod_0("configDebug").method_3("ckbDebugWelike"))
		{
			num = 1;
		}
		string text2 = GClass8.smethod_10(GetJobs2(GClass8.smethod_11(""), GClass8.smethod_11(B620C7A1), GClass8.smethod_11(BA3BCD15), GClass8.smethod_11(string_5), GClass8.smethod_11(string_6), GClass8.smethod_11(string_7), GClass8.smethod_11(num.ToString())));
		try
		{
			JObject jObject = JObject.Parse(text2);
			if (Convert.ToBoolean(jObject["success"]))
			{
				list = JsonConvert.DeserializeObject<List<GClass19>>(JObject.Parse(text2)["data"]!.ToString());
				foreach (GClass19 item in list)
				{
					item.DE2D8C14 = B620C7A1;
					item.String_0 = BA3BCD15;
					try
					{
						item.AEB2CFB2 = item.GClass18_0.String_0;
						item.String_2 = item.GClass18_0.C285DD25;
					}
					catch (Exception)
					{
					}
					if (item.A68CE239.Contains("?"))
					{
						item.A68CE239 = item.A68CE239.Split('?')[0];
					}
					if (Class57.bool_0)
					{
						CB8E523F(item.B222253E + "*" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "");
					}
				}
			}
			else
			{
				text = jObject["message"]!.ToString();
				if (text.Contains("Đã yêu cầu kháng đang chờ"))
				{
					text = "đã yêu cầu kháng, chờ check lại";
				}
				else if (text.Contains("lý do Acc die"))
				{
					text = "acc die, vui lòng gỡ và kháng lại";
				}
				else if (text.Contains("account nằm ở 1 tài khoản khác"))
				{
					text = "acc nằm ở 1 tài khoản khác";
				}
				else if (text.Contains("tên ngoại"))
				{
					text = "tên ngoại";
				}
				else if (!text.Contains("làm quá") && !text.Contains("jobs trong ngày"))
				{
					if (!text.Contains("No Job pending") && !text.Contains("Hiện tại không có job cho uid này"))
					{
						CB8E523F(text, BA3BCD15);
					}
					else
					{
						text = "";
					}
				}
				else
				{
					text = "làm quá jobs trong ngày";
				}
			}
		}
		catch
		{
			if (text2.Contains("Gửi yêu cầu lấy jobs thành công ! thử lại sau vài giây,..."))
			{
				text2 = "Gửi yêu cầu lấy jobs thành công ! thử lại sau vài giây,...";
			}
			else if (text2.Contains("Hệ thống đang xử lý phân jobs, thử lại sau vài giây,..."))
			{
				text2 = "Hệ thống đang xử lý phân jobs, thử lại sau vài giây,...";
			}
			else if (text2.Contains("Server Error"))
			{
				text2 = "Internal Server Error";
			}
			else if (text2.Contains("Vui lòng nhập thông tin để đăng nhập"))
			{
				text = (text2 = "API không đúng!");
			}
			else if (text2.Contains("502 Bad Gateway"))
			{
				text = (text2 = "502 Bad Gateway");
			}
			CB8E523F(text2, BA3BCD15);
		}
		if (list.Count == 0 && text == "")
		{
			if (GClass25.smethod_0("configDebug").method_3("ckbLogWelike"))
			{
				CB8E523F(text2, BA3BCD15);
			}
			if (GClass25.smethod_0("configDebug").method_3("ckbDebugWelike"))
			{
				CB8E523F(text2, BA3BCD15, "golike\\debuggetjob.txt");
			}
		}
		return (list, text);
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr UpdateJob2(byte[] E73A2A89, byte[] B6B2BBBC, byte[] F20B9289, byte[] A699F384, byte[] DAA01E97, byte[] byte_0, byte[] byte_1, byte[] byte_2);

	public void ED286D22(bool bool_0, string F126393A = "", bool bool_1 = false, string string_5 = "")
	{
		FFBDE098 = true;
		if (bool_0)
		{
			F126393A = "";
			bool_1 = false;
		}
		string text = "other";
		if (bool_1)
		{
			text = "job_die";
		}
		string text2 = "0";
		if (!string.IsNullOrEmpty(String_2))
		{
			text2 = String_2;
		}
		string text3 = "";
		for (int i = 0; i < 10; i++)
		{
			text3 = GClass8.smethod_10(UpdateJob2(GClass8.smethod_11(""), GClass8.smethod_11(DE2D8C14), GClass8.smethod_11(B222253E.ToString()), GClass8.smethod_11(String_0), GClass8.smethod_11(bool_0.ToString().ToLower()), GClass8.smethod_11(F126393A + "|" + GClass8.CF09EFB3(string_5)), GClass8.smethod_11(text), GClass8.smethod_11(text2)));
			try
			{
				JObject jObject = JObject.Parse(text3);
				if (Convert.ToBoolean(JObject.Parse(text3)["success"]))
				{
					if (Class57.bool_0)
					{
						C3A35DB7(null, B222253E + "*" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "");
					}
					return;
				}
				if (jObject["message"]!.ToString() != "Vui lòng đăng nhập lại")
				{
					break;
				}
			}
			catch
			{
			}
			GClass8.smethod_53(5 + i);
		}
		if (text3.Contains("Server Error"))
		{
			text3 = "Internal Server Error";
		}
		C3A35DB7(this, text3, String_0);
	}

	public static void CB8E523F(string D108E0B7, string string_5, string string_6 = "")
	{
		if (string_6 == "")
		{
			string_6 = "golike\\getjob.txt";
		}
		lock (object_0)
		{
			try
			{
				if (!D108E0B7.Contains("*"))
				{
					File.AppendAllText(string_6, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				}
				if (string_5 != "")
				{
					File.AppendAllText(string_6, "Uid: " + string_5 + "\r\n");
				}
				File.AppendAllText(string_6, D108E0B7 + "\r\n");
			}
			catch
			{
			}
		}
	}

	public static void C3A35DB7(GClass19 gclass19_0, string string_5, string string_6)
	{
		string path = "golike\\updatejob.txt";
		lock (object_1)
		{
			try
			{
				if (!string_5.Contains("*"))
				{
					File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				}
				if (string_6 != "")
				{
					File.AppendAllText(path, "Uid: " + string_6 + "\r\n");
				}
				if (gclass19_0 != null)
				{
					File.AppendAllText(path, "job_id: " + gclass19_0.B222253E + "\r\n");
					File.AppendAllText(path, "job_type: " + gclass19_0.F63D2D1F + "\r\n");
					File.AppendAllText(path, "object_id: " + gclass19_0.A68CE239 + "\r\n");
				}
				File.AppendAllText(path, string_5 + "\r\n");
			}
			catch (Exception)
			{
			}
		}
	}

	public static void smethod_1(GClass19 A5A0661A, string string_5, string string_6)
	{
		if (string_5 == "" || (string_5.Contains(":") && string_5.Split(':').Last().Trim() == ""))
		{
			return;
		}
		string path = "golike\\failjob.txt";
		lock (F92CEA91)
		{
			try
			{
				File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				if (string_6 != "")
				{
					File.AppendAllText(path, "Uid: " + string_6 + "\r\n");
				}
				if (A5A0661A != null)
				{
					File.AppendAllText(path, "job_id: " + A5A0661A.B222253E + "\r\n");
					File.AppendAllText(path, "job_type: " + A5A0661A.F63D2D1F + "\r\n");
					File.AppendAllText(path, "object_id: " + A5A0661A.A68CE239 + "\r\n");
				}
				File.AppendAllText(path, string_5 + "\r\n");
			}
			catch (Exception)
			{
			}
		}
	}

	public static void smethod_2(string string_5, string string_6)
	{
		if (string_5 == "" || (string_5.Contains(":") && string_5.Split(':').Last().Trim() == ""))
		{
			return;
		}
		string path = "golike\\tokenResponse.txt";
		lock (A1BB0F3D)
		{
			try
			{
				File.AppendAllText(path, "------------------ " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\r\n");
				if (string_6 != "")
				{
					File.AppendAllText(path, "Uid: " + string_6 + "\r\n");
				}
				File.AppendAllText(path, string_5 + "\r\n");
			}
			catch (Exception)
			{
			}
		}
	}
}
