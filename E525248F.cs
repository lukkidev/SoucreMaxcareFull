using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class E525248F
{
	public class GClass30
	{
		[Serializable]
		private sealed class Class145
		{
			public static RemoteCertificateValidationCallback F6957227;

			public static readonly Class145 class145_0 = new Class145();

			internal bool method_0(object object_0, X509Certificate BEBA8C22, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}
		}

		private string string_0;

		private string AE26C39E;

		public string FF921E00
		{
			get
			{
				return string_0;
			}
			private set
			{
				string_0 = value;
			}
		}

		public string String_0
		{
			get
			{
				return AE26C39E;
			}
			private set
			{
				AE26C39E = value;
			}
		}

		protected void method_0(string string_1, string A30E5733)
		{
			A5A56E32(string_1, B98671B9: false);
			A5A56E32(A30E5733, B98671B9: true);
		}

		private void A5A56E32(string E5BA0BB8, bool B98671B9)
		{
			if (B98671B9)
			{
				StringBuilder stringBuilder = new StringBuilder(String_0);
				foreach (char c in E5BA0BB8)
				{
					switch (c)
					{
					default:
						stringBuilder.Append(c);
						break;
					case '=':
						stringBuilder.Append("%3D");
						break;
					case '/':
						stringBuilder.Append("%2F");
						break;
					case '+':
						stringBuilder.Append("%2B");
						break;
					}
				}
				String_0 = stringBuilder.ToString();
			}
			else
			{
				String_0 += E5BA0BB8;
			}
		}

		protected void B2307D94()
		{
			String_0 = Convert.ToBase64String(Encoding.UTF8.GetBytes(String_0));
		}

		protected bool method_1(byte[] DF0FAE95)
		{
			int num = BitConverter.ToInt32(DF0FAE95, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(DF0FAE95, 28);
			String_0 = Encoding.UTF8.GetString(DF0FAE95, index, num);
			if (String_0[String_0.Length - 1] != '/')
			{
				String_0 += "/";
			}
			return true;
		}
	}

	public class GClass31 : GClass30
	{
	}

	public class D42B6109 : GClass30
	{
		private string string_1;
	}

	private readonly int int_0;

	private long long_0;

	private int int_1;

	private FB86FF16 fb86FF16_0;

	private byte[] byte_0;

	private readonly object A82AD93E;

	private uint FA1B483C;

	private readonly byte[] F89205A1;

	public E525248F(byte[] byte_1)
	{
		new GClass34().method_46(new object[2] { this, byte_1 }, 53710);
	}

	public E525248F()
	{
		new GClass34().method_46(new object[1] { this }, 40355);
	}
}
