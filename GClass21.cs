using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;
using MimeKit;

public class GClass21
{
	[Serializable]
	[CompilerGenerated]
	private sealed class BE23B0A2
	{
		public static readonly BE23B0A2 _003C_003E9 = new BE23B0A2();

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__6_0;

		internal string method_0(KeyValuePair<string, string> keyValuePair_0)
		{
			return WebUtility.UrlEncode(keyValuePair_0.Key) + "=" + WebUtility.UrlEncode(keyValuePair_0.Value);
		}
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr CheckConnectImap(byte[] DA9620A0, byte[] byte_0);

	public static bool A3BD3C81(string F416CCAC, string string_0, string F215712E)
	{
		if (F215712E != "")
		{
			string text = EB3814A6(F215712E, "", 0);
			if (text != "")
			{
				try
				{
					using ImapClient imapClient = new ImapClient();
					imapClient.Connect("outlook.office365.com", 993, SecureSocketOptions.SslOnConnect);
					imapClient.Authenticate(new SaslMechanismOAuth2(F416CCAC, text));
					imapClient.Inbox.Open(FolderAccess.ReadWrite);
					_ = imapClient.Inbox.Count;
					imapClient.Disconnect(quit: true);
					return true;
				}
				catch (Exception)
				{
				}
			}
		}
		string value = GClass8.smethod_10(CheckConnectImap(GClass8.smethod_11(F416CCAC), GClass8.smethod_11(string_0)));
		bool result = false;
		bool.TryParse(value, out result);
		return result;
	}

	public static string smethod_0(int int_0, string string_0, string string_1, int int_1, string string_2, string string_3)
	{
		string text = "";
		try
		{
			if (int_0 == 5)
			{
				int_0 = 4;
			}
			int tickCount = Environment.TickCount;
			do
			{
				text = smethod_3(int_0, string_0, string_1, string_2, string_3);
				if (!text.Contains("error"))
				{
					if (!(text != ""))
					{
						GClass8.smethod_53(1.0);
						continue;
					}
					break;
				}
				text = "fail";
				break;
			}
			while (Environment.TickCount - tickCount < int_1 * 1000);
		}
		catch
		{
		}
		if (text == "fail")
		{
			string text2 = CE9B89B6(string_0, string_1);
			if (text2 != "")
			{
				text = C08B2839(int_0, string_0, text2, int_1, string_2, string_3);
			}
		}
		return text;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetOtpHotmailByCookie(byte[] byte_0, byte[] byte_1, byte[] B104B70B, byte[] byte_2, byte[] byte_3, byte[] byte_4);

	public static string C08B2839(int int_0, string string_0, string A103AF02, int int_1 = 60, string E5142EAB = "", string string_1 = "")
	{
		return GClass8.smethod_10(GetOtpHotmailByCookie(GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(string_0), GClass8.smethod_11(A103AF02), GClass8.smethod_11(int_1.ToString()), GClass8.smethod_11(E5142EAB), GClass8.smethod_11(string_1)));
	}

	public static string CE9B89B6(string E0A134BE, string E507C88A, string string_0 = "", int int_0 = 0)
	{
		string text = "";
		int num = 3;
		do
		{
			num--;
			if (num >= 0)
			{
				F3958F9B f3958F9B = new F3958F9B("", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36", string_0, int_0);
				try
				{
					string input = f3958F9B.method_0("https://outlook.live.com/owa/?nlp=1");
					string value = Regex.Match(input, "name=\"PPFT\" id=\"i0327\" value=\"(.*?)\"").Groups[1].Value;
					string value2 = Regex.Match(input, "urlPostMsa:'(.*?)'").Groups[1].Value;
					string string_ = value2;
					List<KeyValuePair<string, string>> b9141FBB = new List<KeyValuePair<string, string>>
					{
						new KeyValuePair<string, string>("ps", "2"),
						new KeyValuePair<string, string>("psRNGCDefaultType", ""),
						new KeyValuePair<string, string>("psRNGCEntropy", ""),
						new KeyValuePair<string, string>("psRNGCSLK", ""),
						new KeyValuePair<string, string>("canary", ""),
						new KeyValuePair<string, string>("ctx", ""),
						new KeyValuePair<string, string>("hpgrequestid", ""),
						new KeyValuePair<string, string>("PPFT", value),
						new KeyValuePair<string, string>("PPSX", "Passp"),
						new KeyValuePair<string, string>("NewUser", "1"),
						new KeyValuePair<string, string>("FoundMSAs", ""),
						new KeyValuePair<string, string>("fspost", "0"),
						new KeyValuePair<string, string>("i21", "0"),
						new KeyValuePair<string, string>("CookieDisclosure", "0"),
						new KeyValuePair<string, string>("IsFidoSupported", "1"),
						new KeyValuePair<string, string>("isSignupPost", "0"),
						new KeyValuePair<string, string>("isRecoveryAttemptPost", "0"),
						new KeyValuePair<string, string>("i13", "0"),
						new KeyValuePair<string, string>("login", E0A134BE),
						new KeyValuePair<string, string>("loginfmt", E0A134BE),
						new KeyValuePair<string, string>("type", "11"),
						new KeyValuePair<string, string>("LoginOptions", "3"),
						new KeyValuePair<string, string>("lrt", ""),
						new KeyValuePair<string, string>("lrtPartition", ""),
						new KeyValuePair<string, string>("hisRegion", ""),
						new KeyValuePair<string, string>("hisScaleUnit", ""),
						new KeyValuePair<string, string>("passwd", E507C88A)
					};
					string bFA79D3C = smethod_1(b9141FBB);
					input = f3958F9B.A6321D97(string_, bFA79D3C);
					value = Regex.Match(input, "sFT:'(.*?)'").Groups[1].Value;
					string value3 = Regex.Match(input, "urlPost:'(.*?route.*?)'").Groups[1].Value;
					value2 = value3;
					string string_2 = value2;
					List<KeyValuePair<string, string>> b9141FBB2 = new List<KeyValuePair<string, string>>
					{
						new KeyValuePair<string, string>("LoginOptions", "1"),
						new KeyValuePair<string, string>("type", "28"),
						new KeyValuePair<string, string>("ctx", ""),
						new KeyValuePair<string, string>("hpgrequestid", ""),
						new KeyValuePair<string, string>("PPFT", value),
						new KeyValuePair<string, string>("canary", "")
					};
					string bFA79D3C2 = smethod_1(b9141FBB2);
					input = f3958F9B.A6321D97(string_2, bFA79D3C2);
					text = f3958F9B.method_3();
					string value4 = Regex.Match(text, "MSPCID=(.*?);").Groups[1].Value;
					string value5 = Regex.Match(input, "id=\"NAP\" value=\"(.*?)\"").Groups[1].Value;
					string value6 = Regex.Match(input, "id=\"ANON\" value=\"(.*?)\"").Groups[1].Value;
					string value7 = Regex.Match(input, "id=\"ANONExp\" value=\"(.*?)\"").Groups[1].Value;
					string value8 = Regex.Match(input, "id=\"t\" value=\"(.*?)\"").Groups[1].Value;
					string value9 = Regex.Match(input, "id=\"NAPExp\" value=\"(.*?)\"").Groups[1].Value;
					string value10 = Regex.Match(input, "action=\"(.*?)\"").Groups[1].Value;
					string string_3 = value10;
					List<KeyValuePair<string, string>> b9141FBB3 = new List<KeyValuePair<string, string>>
					{
						new KeyValuePair<string, string>("NAPExp", value9),
						new KeyValuePair<string, string>("wbids", "0"),
						new KeyValuePair<string, string>("pprid", value4),
						new KeyValuePair<string, string>("wbid", "MSFT"),
						new KeyValuePair<string, string>("NAP", value5),
						new KeyValuePair<string, string>("ANON", value6),
						new KeyValuePair<string, string>("ANONExp", value7),
						new KeyValuePair<string, string>("t", value8)
					};
					string bFA79D3C3 = smethod_1(b9141FBB3);
					input = f3958F9B.A6321D97(string_3, bFA79D3C3);
				}
				catch (Exception)
				{
					return "";
				}
				text = f3958F9B.method_3();
				continue;
			}
			return "";
		}
		while (!text.Contains("X-OWA-CANARY"));
		return text;
	}

	public static string smethod_1(List<KeyValuePair<string, string>> B9141FBB)
	{
		return string.Join("&", B9141FBB.Select((KeyValuePair<string, string> keyValuePair_0) => WebUtility.UrlEncode(keyValuePair_0.Key) + "=" + WebUtility.UrlEncode(keyValuePair_0.Value)));
	}

	public static string CF2750A3(string string_0, string A0865C3A = "", int int_0 = 0)
	{
		try
		{
			F3958F9B f3958F9B = new F3958F9B(string_0, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/125.0.0.0 Safari/537.36", A0865C3A, int_0);
			try
			{
				string text = "9e5f94bc-e8a4-4e73-b8be-63364c29d753";
				string text2 = "https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=" + text + "&response_type=code&redirect_uri=https%3A%2F%2Flocalhost%2F&response_mode=query&scope=offline_access https://outlook.office.com/IMAP.AccessAsUser.All https://outlook.office.com/POP.AccessAsUser.All https://outlook.office.com/EWS.AccessAsUser.All https://outlook.office.com/SMTP.Send&state=PvCYEqIiGX";
				string text3 = f3958F9B.method_0(text2);
				if (!text3.Contains("urlGitHubFed"))
				{
					text3 = f3958F9B.method_0(text2 + "&sso_reload=true");
				}
				text2 = Regex.Unescape(Regex.Match(text3, "\"urlGitHubFed\":\"(.*?)\"").Groups[1].Value).Replace("&jshs=0&idp_hint=github.com", "&jshs=-1&jsh=&jshp=");
				if (text2 == "")
				{
					return "";
				}
				string text4 = "";
				string text5 = "";
				List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
				try
				{
					text3 = f3958F9B.method_0(text2);
					if (text3.Contains("form name=\"fmHF\""))
					{
						text2 = Regex.Match(text3, "action=\"(.*?)\"").Groups[1].Value;
						list = new List<KeyValuePair<string, string>>
						{
							new KeyValuePair<string, string>("rd", Regex.Match(text3, "name=\"rd\" id=\"rd\" value=\"(.*?)\"").Groups[1].Value),
							new KeyValuePair<string, string>("avp", Regex.Match(text3, "name=\"avp\" id=\"avp\" value=\"(.*?)\"").Groups[1].Value),
							new KeyValuePair<string, string>("pprid", Regex.Match(text3, "name=\"pprid\" id=\"pprid\" value=\"(.*?)\"").Groups[1].Value),
							new KeyValuePair<string, string>("ipt", Regex.Match(text3, "name=\"ipt\" id=\"ipt\" value=\"(.*?)\"").Groups[1].Value),
							new KeyValuePair<string, string>("uaid", Regex.Match(text3, "name=\"uaid\" id=\"uaid\" value=\"(.*?)\"").Groups[1].Value),
							new KeyValuePair<string, string>("client_id", Regex.Match(text3, "name=\"client_id\" id=\"client_id\" value=\"(.*?)\"").Groups[1].Value),
							new KeyValuePair<string, string>("scope", Regex.Match(text3, "name=\"scope\" id=\"scope\" value=\"(.*?)\"").Groups[1].Value)
						};
						text5 = smethod_1(list);
						text3 = f3958F9B.A6321D97(text2, text5);
						list = new List<KeyValuePair<string, string>>
						{
							new KeyValuePair<string, string>("canary", Regex.Match(text3, "name=\"canary\" value=\"(.*?)\"").Groups[1].Value),
							new KeyValuePair<string, string>("client_id", Regex.Match(text3, "name=\"client_id\" value=\"(.*?)\"").Groups[1].Value),
							new KeyValuePair<string, string>("scope", Regex.Match(text3, "name=\"scope\" value=\"(.*?)\"").Groups[1].Value.Replace("&#32;", " ")),
							new KeyValuePair<string, string>("cscope", ""),
							new KeyValuePair<string, string>("ucaction", "Yes")
						};
						text5 = smethod_1(list);
						text3 = f3958F9B.A6321D97(text2, text5);
					}
					if (f3958F9B.method_4().Contains("localhost/?code="))
					{
						text4 = GClass8.smethod_96(f3958F9B.method_4(), "code=(.*?)&");
					}
					if (text4 == "")
					{
						text3 = f3958F9B.method_0(f3958F9B.method_4());
					}
				}
				catch (Exception)
				{
					if (f3958F9B.method_4().Contains("localhost/?code="))
					{
						text4 = GClass8.smethod_96(f3958F9B.method_4(), "code=(.*?)&");
					}
				}
				if (text4 == "")
				{
					return "";
				}
				text2 = "https://login.microsoftonline.com/common/oauth2/v2.0/token";
				list = new List<KeyValuePair<string, string>>
				{
					new KeyValuePair<string, string>("client_id", text),
					new KeyValuePair<string, string>("code", text4),
					new KeyValuePair<string, string>("redirect_uri", "https://localhost/"),
					new KeyValuePair<string, string>("grant_type", "authorization_code")
				};
				text5 = smethod_1(list);
				text3 = f3958F9B.A6321D97(text2, text5);
				string value = Regex.Match(text3, "\"refresh_token\":\"(.*?)\"").Groups[1].Value;
				return value + "|" + text;
			}
			catch (Exception)
			{
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr GetAccessTokenHotmail(byte[] byte_0, byte[] byte_1, byte[] byte_2);

	public static string EB3814A6(string string_0, string string_1, int int_0)
	{
		return GClass8.smethod_10(GetAccessTokenHotmail(GClass8.smethod_11(string_0), GClass8.smethod_11(string_1), GClass8.smethod_11(int_0.ToString())));
	}

	public static string smethod_2(int int_0, string string_0, string string_1, int int_1 = 60, string string_2 = "", string string_3 = "")
	{
		string text = EB3814A6(string_1, "", 0);
		if (text == "")
		{
			return "";
		}
		string text2 = "";
		try
		{
			using ImapClient imapClient = new ImapClient();
			imapClient.Connect("outlook.office365.com", 993, SecureSocketOptions.SslOnConnect);
			imapClient.Authenticate(new SaslMechanismOAuth2(string_0, text));
			int tickCount = Environment.TickCount;
			while (true)
			{
				IL_0241:
				imapClient.Inbox.Open(FolderAccess.ReadWrite);
				int count = imapClient.Inbox.Count;
				IList<IMessageSummary> list = imapClient.Inbox.Fetch(0, count - 1, MessageSummaryItems.Envelope | MessageSummaryItems.Flags);
				int num = list.Count - 1;
				while (true)
				{
					if (num >= 0)
					{
						IMessageSummary messageSummary = list[num];
						if (!messageSummary.Flags.HasValue || !messageSummary.Flags.Value.HasFlag(MessageFlags.Seen))
						{
							imapClient.Inbox.AddFlags(messageSummary.Index, MessageFlags.Seen, silent: true);
							DateTime localDateTime = messageSummary.Envelope.Date.Value.LocalDateTime;
							int hours = DateTime.Now.Subtract(localDateTime).Hours;
							if (hours <= 1)
							{
								string text3 = messageSummary.Envelope.From.ToString();
								string value = "facebook";
								switch (int_0)
								{
								case 1:
								case 2:
									value = "security@facebookmail.com";
									break;
								case 7:
									value = "noreply@account.tiktok.com";
									break;
								case 8:
									value = "account-security-noreply@accountprotection.microsoft.com";
									break;
								case 9:
									value = "noreply@telegram.org";
									break;
								case 10:
									value = "noreply@walletbot.net";
									break;
								}
								if (text3.Contains(value))
								{
									MimeMessage message = imapClient.Inbox.GetMessage(messageSummary.Index);
									string bF1BE = message.HtmlBody ?? message.TextBody ?? "";
									text2 = Class98.smethod_1(bF1BE, int_0, string_2);
									if (!(text2 == ""))
									{
										if (text2 != string_3)
										{
											break;
										}
										text2 = "";
									}
								}
								num--;
								continue;
							}
						}
					}
					if (Environment.TickCount - tickCount <= int_1 * 1000)
					{
						GClass8.smethod_53(3.0);
						goto IL_0241;
					}
					imapClient.Disconnect(quit: true);
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			if (text2 == "")
			{
				text2 = "fail";
			}
		}
		return text2;
	}

	[DllImport("main", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
	private static extern IntPtr ConnectImap(byte[] byte_0, byte[] byte_1, byte[] byte_2, byte[] F22A7695, byte[] F22D3E90);

	public static string smethod_3(int int_0, string AB397AB1, string string_0, string string_1, string C937A090)
	{
		return GClass8.smethod_10(ConnectImap(GClass8.smethod_11(AB397AB1), GClass8.smethod_11(string_0), GClass8.smethod_11(int_0.ToString()), GClass8.smethod_11(string_1), GClass8.smethod_11(C937A090)));
	}
}
