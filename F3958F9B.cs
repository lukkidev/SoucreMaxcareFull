using System;
using System.IO;
using System.Linq;
using System.Net;
using xNet;

public class F3958F9B
{
	public xNet.HttpRequest httpRequest_0;

	public F3958F9B(string string_0 = "", string E016A31D = "", string string_1 = "", int int_0 = 0)
	{
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		if (E016A31D == "")
		{
			E016A31D = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36";
		}
		httpRequest_0 = new xNet.HttpRequest
		{
			KeepAlive = true,
			AllowAutoRedirect = true,
			Cookies = new CookieDictionary(),
			UserAgent = E016A31D
		};
		httpRequest_0.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
		httpRequest_0.AddHeader("Accept-Language", "en-US,en;q=0.9");
		httpRequest_0.AddHeader("sec-fetch-site", "same-origin");
		if (string_0 != "")
		{
			method_2(string_0);
		}
		if (!(string_1 != ""))
		{
			return;
		}
		switch (string_1.Split(':').Count())
		{
		case 1:
			if (int_0 == 0)
			{
				httpRequest_0.Proxy = HttpProxyClient.Parse("127.0.0.1:" + string_1);
			}
			else
			{
				httpRequest_0.Proxy = Socks5ProxyClient.Parse("127.0.0.1:" + string_1);
			}
			break;
		case 2:
			if (int_0 == 0)
			{
				httpRequest_0.Proxy = HttpProxyClient.Parse(string_1);
			}
			else
			{
				httpRequest_0.Proxy = Socks5ProxyClient.Parse(string_1);
			}
			break;
		case 4:
			if (int_0 == 0)
			{
				httpRequest_0.Proxy = new HttpProxyClient(string_1.Split(':')[0], Convert.ToInt32(string_1.Split(':')[1]), string_1.Split(':')[2], string_1.Split(':')[3]);
			}
			else
			{
				httpRequest_0.Proxy = new Socks5ProxyClient(string_1.Split(':')[0], Convert.ToInt32(string_1.Split(':')[1]), string_1.Split(':')[2], string_1.Split(':')[3]);
			}
			break;
		case 3:
			break;
		}
	}

	public string method_0(string string_0)
	{
		for (int i = 0; i < 5 && !Class57.smethod_5(); i++)
		{
			try
			{
				httpRequest_0.AddHeader("sec-fetch-site", "same-origin");
				return httpRequest_0.Get(string_0).ToString();
			}
			catch (Exception ex)
			{
				string text = ex.ToString();
				try
				{
					if (!string.IsNullOrEmpty(httpRequest_0.Response.ToString()))
					{
						text = httpRequest_0.Response.ToString();
					}
				}
				catch
				{
				}
				if (text.Contains("A connection attempt failed because the connected party did not properly respond after a period of time"))
				{
					continue;
				}
			}
			break;
		}
		return "";
	}

	public byte[] F204C69A(string string_0)
	{
		try
		{
			return httpRequest_0.Get(string_0).ToBytes();
		}
		catch (Exception)
		{
			return httpRequest_0.Response.ToBytes();
		}
	}

	public string A6321D97(string string_0, string BFA79D3C = "", string string_1 = "application/x-www-form-urlencoded")
	{
		for (int i = 0; i < 5 && !Class57.smethod_5(); i++)
		{
			try
			{
				httpRequest_0.AddHeader("sec-fetch-site", "same-origin");
				if (!(BFA79D3C == "") && !(string_1 == ""))
				{
					return httpRequest_0.Post(string_0, BFA79D3C, string_1).ToString();
				}
				return httpRequest_0.Post(string_0).ToString();
			}
			catch (Exception ex)
			{
				string text = ex.ToString();
				try
				{
					if (!string.IsNullOrEmpty(httpRequest_0.Response.ToString()))
					{
						text = httpRequest_0.Response.ToString();
					}
				}
				catch
				{
				}
				if (text.Contains("A connection attempt failed because the connected party did not properly respond after a period of time"))
				{
					continue;
				}
			}
			break;
		}
		return "";
	}

	public string B51DA5A0(string AE8A169D, string D510F3A8, string BA38961D, string[] D681520C)
	{
		foreach (string text in D681520C)
		{
			string[] array = text.Split(':');
			if (array.Count() > 1)
			{
				httpRequest_0.AddHeader(array[0], array[1].Trim());
			}
		}
		return A6321D97(AE8A169D, D510F3A8, BA38961D);
	}

	public string method_1(string AA195B90, string B6B5DF1F)
	{
		for (int i = 0; i < 5 && !Class57.smethod_5(); i++)
		{
			try
			{
				httpRequest_0.AddHeader("offset", "0");
				httpRequest_0.AddHeader("x-entity-length", new FileInfo(B6B5DF1F).Length.ToString());
				httpRequest_0.AddHeader("x-entity-name", Path.GetFileName(B6B5DF1F));
				httpRequest_0.AddHeader("x-entity-type", "image/jpeg");
				return httpRequest_0.Post(AA195B90, new FileContent(B6B5DF1F)).ToString();
			}
			catch (Exception ex)
			{
				string text = ex.ToString();
				try
				{
					if (!string.IsNullOrEmpty(httpRequest_0.Response.ToString()))
					{
						text = httpRequest_0.Response.ToString();
					}
				}
				catch
				{
				}
				if (text.Contains("A connection attempt failed because the connected party did not properly respond after a period of time"))
				{
					continue;
				}
			}
			break;
		}
		return "";
	}

	public void method_2(string E50547BC)
	{
		string[] array = E50547BC.Split(';');
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split('=');
			if (array3.Count() > 1)
			{
				try
				{
					httpRequest_0.Cookies.Add(array3[0], array3[1]);
				}
				catch
				{
				}
			}
		}
	}

	public string method_3()
	{
		return httpRequest_0.Cookies.ToString();
	}

	public string method_4()
	{
		return httpRequest_0.Address.AbsoluteUri;
	}

	internal void method_5(string string_0, string D8AC0DB6)
	{
		httpRequest_0.AddHeader(string_0, D8AC0DB6);
	}
}
