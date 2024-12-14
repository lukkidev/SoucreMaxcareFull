using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

internal class F43795AB
{
	[CompilerGenerated]
	private sealed class CC2C8A22
	{
		public string BC824882;
	}

	[CompilerGenerated]
	private sealed class D204B22A
	{
		public HttpContent httpContent_0;

		public CC2C8A22 cc2C8A22_0;

		internal Task<string> method_0()
		{
			return DB38FC96(new Uri(cc2C8A22_0.BC824882), httpContent_0);
		}
	}

	private object C517639F = new object();

	private object object_0 = new object();

	public int int_0;

	private string string_0;

	public string string_1;

	public string B8814994 = "";

	public int int_1 = 0;

	public int int_2 = 0;

	public int int_3 = 3;

	public F43795AB(string string_2, string string_3, int int_4, int FB83D6A1)
	{
		string_0 = string_2;
		string_1 = string_3;
		int_3 = FB83D6A1;
		B8814994 = "";
		int_0 = int_4;
	}

	public bool FBB85912()
	{
		bool result = false;
		try
		{
			string string_ = "https://apiv2-public.vitechcheap.com/v1/public/rotate";
			string b30C5E = "{\"proxy\": \"" + string_1 + "\"}";
			smethod_0(string_, string_0, b30C5E);
			return result;
		}
		catch
		{
			return false;
		}
	}

	private static string smethod_0(string string_2, string A71B9318, string B30C5E81)
	{
		string text = "";
		try
		{
			HttpClient httpClient = new HttpClient();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", A71B9318);
			HttpContent httpContent_0 = new StringContent(B30C5E81, Encoding.UTF8, "application/json");
			Task<string> task = Task.Run(() => DB38FC96(new Uri(string_2), httpContent_0));
			task.Wait();
			return task.Result;
		}
		catch (Exception f4295AA)
		{
			GClass8.BFBDF687(null, f4295AA, "Request Post");
			return "";
		}
	}

	private static Task<string> DB38FC96(Uri uri_0, HttpContent httpContent_0)
	{
        return null;
    }


	private static Task<string> smethod_1(Uri uri_0)
	{
        return null;
    }

	public void method_0()
	{
		lock (C517639F)
		{
			int_1--;
			if (int_1 == 0 && int_2 == int_3)
			{
				int_2 = 0;
			}
		}
	}

	public bool E92F441A()
	{
		bool result = false;
		try
		{
			return result;
		}
		catch
		{
			return result;
		}
	}
}
