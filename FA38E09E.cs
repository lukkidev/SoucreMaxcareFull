using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

[CompilerGenerated]
internal static class FA38E09E
{
	private static object DDA1EF26 = new object();

	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	private static string string_0;

	private static Dictionary<string, string> A1A9CC82 = new Dictionary<string, string>();

	private static Dictionary<string, string> D8016936 = new Dictionary<string, string>();

	private static List<string> list_0 = new List<string>();

	private static List<string> DA0C2633 = new List<string>();

	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	private static int EBBA632E;

	private static string smethod_0(CultureInfo A932850C)
	{
		if (A932850C == null)
		{
			return "";
		}
		return A932850C.Name;
	}

	private static Assembly smethod_1(AssemblyName assemblyName_0)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array.Length)
			{
				assembly = array[num];
				AssemblyName name = assembly.GetName();
				if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(smethod_0(name.CultureInfo), smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly;
	}

	private static Assembly smethod_2(string CFAA8CBC, AssemblyName A81C170F)
	{
		string text = A81C170F.Name.ToLowerInvariant();
		if (A81C170F.CultureInfo != null && !string.IsNullOrEmpty(A81C170F.CultureInfo.Name))
		{
			text = A81C170F.CultureInfo.Name + "." + text;
		}
		string path = ((IntPtr.Size == 8) ? "64" : "32");
		string path2 = Path.Combine(CFAA8CBC, text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.Combine(Path.Combine(CFAA8CBC, path), text + ".dll");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		path2 = Path.ChangeExtension(path2, "exe");
		if (File.Exists(path2))
		{
			return Assembly.LoadFile(path2);
		}
		return null;
	}

	private static void smethod_3(Stream stream_0, Stream stream_1)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = stream_0.Read(array, 0, array.Length)) != 0)
		{
			stream_1.Write(array, 0, count);
		}
	}

	private static Stream smethod_4(string string_1)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (string_1.EndsWith(".compressed"))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(string_1))
			{
				using DeflateStream stream_ = new DeflateStream(stream, CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				smethod_3(stream_, memoryStream);
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}
		return executingAssembly.GetManifestResourceStream(string_1);
	}

	private static Stream C68A071B(Dictionary<string, string> dictionary_2, string string_1)
	{
		if (dictionary_2.TryGetValue(string_1, out var value))
		{
			return smethod_4(value);
		}
		return null;
	}

	private static byte[] smethod_5(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly smethod_6(Dictionary<string, string> dictionary_2, Dictionary<string, string> dictionary_3, AssemblyName C50E3283)
	{
		string text = C50E3283.Name.ToLowerInvariant();
		if (C50E3283.CultureInfo != null && !string.IsNullOrEmpty(C50E3283.CultureInfo.Name))
		{
			text = C50E3283.CultureInfo.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = C68A071B(dictionary_2, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = smethod_5(stream);
		}
		using (Stream stream2 = C68A071B(dictionary_3, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = smethod_5(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly smethod_7(object E12E22AE, ResolveEventArgs resolveEventArgs_0)
	{
		lock (DDA1EF26)
		{
			if (dictionary_0.ContainsKey(resolveEventArgs_0.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
		Assembly assembly = smethod_1(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_2(string_0, assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = smethod_6(A1A9CC82, D8016936, assemblyName);
		if ((object)assembly == null)
		{
			lock (DDA1EF26)
			{
				dictionary_0[resolveEventArgs_0.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	static FA38E09E()
	{
		dictionary_1.Add("costura32.main.dll", "D85CE5FB7BF157880C5CD993739E0A0FE3E14D16");
		dictionary_1.Add("costura64.main.dll", "D85CE5FB7BF157880C5CD993739E0A0FE3E14D16");
		A1A9CC82.Add("bouncycastle.cryptography", "costura.bouncycastle.cryptography.dll.compressed");
		A1A9CC82.Add("bunifu_ui_v1.52", "costura.bunifu_ui_v1.52.dll.compressed");
		A1A9CC82.Add("costura", "costura.costura.dll.compressed");
		D8016936.Add("costura", "costura.costura.pdb.compressed");
		A1A9CC82.Add("entityframework", "costura.entityframework.dll.compressed");
		A1A9CC82.Add("entityframework.sqlserver", "costura.entityframework.sqlserver.dll.compressed");
		A1A9CC82.Add("google.protobuf", "costura.google.protobuf.dll.compressed");
		D8016936.Add("google.protobuf", "costura.google.protobuf.pdb.compressed");
		A1A9CC82.Add("http", "costura.http.dll.compressed");
		A1A9CC82.Add("k4os.compression.lz4", "costura.k4os.compression.lz4.dll.compressed");
		A1A9CC82.Add("k4os.compression.lz4.streams", "costura.k4os.compression.lz4.streams.dll.compressed");
		A1A9CC82.Add("k4os.hash.xxhash", "costura.k4os.hash.xxhash.dll.compressed");
		A1A9CC82.Add("mailkit", "costura.mailkit.dll.compressed");
		A1A9CC82.Add("managedwinapi", "costura.managedwinapi.dll.compressed");
		A1A9CC82.Add("microsoft.bcl.asyncinterfaces", "costura.microsoft.bcl.asyncinterfaces.dll.compressed");
		A1A9CC82.Add("mimekit", "costura.mimekit.dll.compressed");
		A1A9CC82.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		D8016936.Add("newtonsoft.json", "costura.newtonsoft.json.pdb.compressed");
		A1A9CC82.Add("system.buffers", "costura.system.buffers.dll.compressed");
		A1A9CC82.Add("system.configuration.configurationmanager", "costura.system.configuration.configurationmanager.dll.compressed");
		A1A9CC82.Add("system.data.sqlite", "costura.system.data.sqlite.dll.compressed");
		A1A9CC82.Add("system.data.sqlite.ef6", "costura.system.data.sqlite.ef6.dll.compressed");
		A1A9CC82.Add("system.data.sqlite.linq", "costura.system.data.sqlite.linq.dll.compressed");
		A1A9CC82.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		A1A9CC82.Add("system.formats.asn1", "costura.system.formats.asn1.dll.compressed");
		A1A9CC82.Add("system.io.pipelines", "costura.system.io.pipelines.dll.compressed");
		A1A9CC82.Add("system.memory", "costura.system.memory.dll.compressed");
		A1A9CC82.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
		A1A9CC82.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
		A1A9CC82.Add("system.threading.tasks.extensions", "costura.system.threading.tasks.extensions.dll.compressed");
		A1A9CC82.Add("system.valuetuple", "costura.system.valuetuple.dll.compressed");
		A1A9CC82.Add("webdriver", "costura.webdriver.dll.compressed");
		A1A9CC82.Add("webdriver.support", "costura.webdriver.support.dll.compressed");
		A1A9CC82.Add("webdrivermanager", "costura.webdrivermanager.dll.compressed");
		A1A9CC82.Add("xnet", "costura.xnet.dll.compressed");
		A1A9CC82.Add("zstdsharp", "costura.zstdsharp.dll.compressed");
		list_0.Add("costura32.main.dll");
		DA0C2633.Add("costura64.main.dll");
	}

	private static void smethod_8(string string_1)
	{
		if (!Directory.Exists(string_1))
		{
			Directory.CreateDirectory(string_1);
		}
	}

	private static string E3A7970D(string string_1)
	{
		string text = ((IntPtr.Size == 8) ? "64" : "32");
		string text2 = string_1;
		if (string_1.StartsWith("costura" + text + "."))
		{
			text2 = Path.Combine(text, string_1.Substring(10));
		}
		else if (string_1.StartsWith("costura."))
		{
			text2 = string_1.Substring(8);
		}
		if (text2.EndsWith(".compressed"))
		{
			text2 = text2.Substring(0, text2.Length - 11);
		}
		return text2;
	}

	private static string smethod_9(string string_1)
	{
		using FileStream stream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete);
		using BufferedStream inputStream = new BufferedStream(stream);
		using SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] array = sHA1CryptoServiceProvider.ComputeHash(inputStream);
		StringBuilder stringBuilder = new StringBuilder(2 * array.Length);
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.AppendFormat("{0:X2}", b);
		}
		return stringBuilder.ToString();
	}

	[DllImport("kernel32.dll")]
	private static extern uint SetErrorMode(uint uint_0);

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern IntPtr LoadLibraryEx(string string_1, IntPtr intptr_0, uint F8B55801);

	private static void D59BBAA0(string string_1, IList<string> ilist_0, Dictionary<string, string> dictionary_2)
	{
		foreach (string item in ilist_0)
		{
			string path = E3A7970D(item);
			string text = Path.Combine(string_1, path);
			if (File.Exists(text))
			{
				string text2 = smethod_9(text);
				if (text2 != dictionary_2[item])
				{
					File.Delete(text);
				}
			}
			if (File.Exists(text))
			{
				continue;
			}
			using Stream stream_ = smethod_4(item);
			using FileStream stream_2 = File.OpenWrite(text);
			smethod_3(stream_, stream_2);
		}
		uint errorMode = SetErrorMode(32771u);
		foreach (string item2 in ilist_0)
		{
			string path = E3A7970D(item2);
			if (path.EndsWith(".dll"))
			{
				string string_2 = Path.Combine(string_1, path);
				LoadLibraryEx(string_2, IntPtr.Zero, 8u);
			}
		}
		SetErrorMode(errorMode);
	}

	private static void smethod_10(string string_1, string string_2, List<string> list_1, Dictionary<string, string> C80193B0)
	{
		string name = "Costura" + string_1;
		using Mutex mutex = new Mutex(initiallyOwned: false, name);
		bool flag = false;
		try
		{
			try
			{
				if (!(flag = mutex.WaitOne(60000, exitContext: false)))
				{
					throw new TimeoutException("Timeout waiting for exclusive access");
				}
			}
			catch (AbandonedMutexException)
			{
				flag = true;
			}
			string path = ((IntPtr.Size == 8) ? "64" : "32");
			smethod_8(Path.Combine(string_2, path));
			D59BBAA0(string_2, list_1, C80193B0);
		}
		finally
		{
			if (flag)
			{
				mutex.ReleaseMutex();
			}
		}
	}

	public static void smethod_11()
	{
		if (Interlocked.Exchange(ref EBBA632E, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		object obj = currentDomain.GetType()?.GetProperty("SetupInformation")?.GetValue(currentDomain);
		PropertyInfo propertyInfo = obj?.GetType()?.GetProperty("TargetFrameworkName");
		if ((object)propertyInfo != null && propertyInfo.GetValue(obj) == null)
		{
			string text = ((TargetFrameworkAttribute)(Assembly.GetCallingAssembly()?.GetCustomAttribute(typeof(TargetFrameworkAttribute))))?.FrameworkName;
			if (text != null)
			{
				currentDomain.SetData("TargetFrameworkName", text);
			}
		}
		string text2 = "76F360C1B0011B3A27F1493FC8C6C958";
		string path = Path.Combine(Path.GetTempPath(), "Costura");
		string_0 = Path.Combine(path, text2);
		List<string> list_ = ((IntPtr.Size == 8) ? DA0C2633 : list_0);
		smethod_10(text2, string_0, list_, dictionary_1);
		currentDomain.AssemblyResolve += delegate(object E12E22AE, ResolveEventArgs resolveEventArgs_0)
		{
			lock (DDA1EF26)
			{
				if (dictionary_0.ContainsKey(resolveEventArgs_0.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
			Assembly assembly = smethod_1(assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = smethod_2(string_0, assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = smethod_6(A1A9CC82, D8016936, assemblyName);
			if ((object)assembly == null)
			{
				lock (DDA1EF26)
				{
					dictionary_0[resolveEventArgs_0.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		};
	}
}
