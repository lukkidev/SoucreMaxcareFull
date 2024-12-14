using System;
using System.Linq;
using System.Net;
using System.Text;
using HttpRequest;

public class GClass12
{
	public RequestHTTP requestHTTP_0;

	private string F737448E;

	private string string_0;

	public GClass12(string string_1 = "", string A28CF7B3 = "", string string_2 = "", int FAA3D735 = 0)
	{
		if (A28CF7B3 == "")
		{
			F737448E = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
		}
		else
		{
			F737448E = A28CF7B3;
		}
		requestHTTP_0 = new RequestHTTP();
		requestHTTP_0.SetSSL(SecurityProtocolType.Tls12);
		requestHTTP_0.SetKeepAlive(k: true);
		requestHTTP_0.SetDefaultHeaders(new string[2]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
			"user-agent: " + F737448E
		});
		if (string_1 != "")
		{
			D92C7781(string_1);
		}
		string_0 = string_2;
	}

	public string method_0(string string_1)
	{
		if (string_0 != "")
		{
			if (string_0.Contains(":"))
			{
				return requestHTTP_0.Request("GET", string_1, null, null, autoredrirect: true, new WebProxy(string_0.Split(':')[0], Convert.ToInt32(string_0.Split(':')[1]))).ToString();
			}
			return requestHTTP_0.Request("GET", string_1, null, null, autoredrirect: true, new WebProxy("127.0.0.1", Convert.ToInt32(string_0))).ToString();
		}
		return requestHTTP_0.Request("GET", string_1).ToString();
	}

	public string A9AEE5A7(string BA996637, string A33A1F19 = "")
	{
		if (string_0 != "")
		{
			if (string_0.Contains(":"))
			{
				return requestHTTP_0.Request("POST", BA996637, null, Encoding.ASCII.GetBytes(A33A1F19), autoredrirect: true, new WebProxy(string_0.Split(':')[0], Convert.ToInt32(string_0.Split(':')[1]))).ToString();
			}
			return requestHTTP_0.Request("POST", BA996637, null, Encoding.ASCII.GetBytes(A33A1F19), autoredrirect: true, new WebProxy("127.0.0.1", Convert.ToInt32(string_0))).ToString();
		}
		return requestHTTP_0.Request("POST", BA996637, null, Encoding.ASCII.GetBytes(A33A1F19)).ToString();
	}

	public void D92C7781(string string_1)
	{
		string[] array = string_1.Split(';');
		string text = "";
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			string[] array3 = text2.Split('=');
			if (array3.Count() > 1)
			{
				try
				{
					text = text + array3[0] + "=" + array3[1] + ";";
				}
				catch
				{
				}
			}
		}
		requestHTTP_0.SetDefaultHeaders(new string[3]
		{
			"content-type: text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8;charset=UTF-8",
			"user-agent: " + F737448E,
			"cookie: " + text
		});
	}

	public string method_1()
	{
		return requestHTTP_0.GetCookiesString();
	}
}
