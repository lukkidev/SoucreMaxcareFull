using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GClass1
{
	private struct Struct0
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool EEAB09A1;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string string_0;

		public bool D82256AB
		{
			[CompilerGenerated]
			get
			{
				return EEAB09A1;
			}
			[CompilerGenerated]
			set
			{
				EEAB09A1 = value;
			}
		}

		public string String_0
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
	}

	private static class Class3
	{
		private const string D5B6ADA2 = "Folders|\n";

		private const BindingFlags bindingFlags_0 = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

		private static readonly Assembly DA3D673A = typeof(FileDialog).Assembly;

		private static readonly Type type_0 = DA3D673A.GetType("System.Windows.Forms.FileDialogNative+IFileDialog");

		private static readonly MethodInfo F1AA118E = typeof(OpenFileDialog).GetMethod("CreateVistaDialog", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly MethodInfo E50C8CBE = typeof(OpenFileDialog).GetMethod("OnBeforeVistaDialog", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly MethodInfo AA36D610 = typeof(FileDialog).GetMethod("GetOptions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly MethodInfo B5926F02 = type_0.GetMethod("SetOptions", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		private static readonly uint uint_0 = (uint)DA3D673A.GetType("System.Windows.Forms.FileDialogNative+FOS").GetField("FOS_PICKFOLDERS").GetValue(null);

		private static readonly ConstructorInfo constructorInfo_0 = DA3D673A.GetType("System.Windows.Forms.FileDialog+VistaDialogEvents").GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[1] { typeof(FileDialog) }, null);

		private static readonly MethodInfo methodInfo_0 = type_0.GetMethod("Advise");

		private static readonly MethodInfo methodInfo_1 = type_0.GetMethod("Unadvise");

		private static readonly MethodInfo methodInfo_2 = type_0.GetMethod("Show");

		public static Struct0 B88A0103(IntPtr B0924915, string string_0, string string_1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				AddExtension = false,
				CheckFileExists = false,
				DereferenceLinks = true,
				Filter = "Folders|\n",
				InitialDirectory = string_0,
				Multiselect = false,
				Title = string_1
			};
			object obj = F1AA118E.Invoke(openFileDialog, new object[0]);
			E50C8CBE.Invoke(openFileDialog, new object[1] { obj });
			B5926F02.Invoke(obj, new object[1] { (uint)AA36D610.Invoke(openFileDialog, new object[0]) | uint_0 });
			object[] array = new object[2]
			{
				constructorInfo_0.Invoke(new object[1] { openFileDialog }),
				0u
			};
			methodInfo_0.Invoke(obj, array);
			try
			{
				int num = (int)methodInfo_2.Invoke(obj, new object[1] { B0924915 });
				Struct0 result = default(Struct0);
				result.D82256AB = num == 0;
				result.String_0 = openFileDialog.FileName;
				return result;
			}
			finally
			{
				methodInfo_1.Invoke(obj, new object[1] { array[1] });
			}
		}
	}

	private class A6912A1B : IWin32Window
	{
		private readonly IntPtr D816BC02;

		public IntPtr Handle => D816BC02;

		public A6912A1B(IntPtr intptr_0)
		{
			D816BC02 = intptr_0;
		}
	}

	private string string_0;

	private string C19E99B8;

	private string string_1 = "";

	public string D316343E
	{
		get
		{
			return string.IsNullOrEmpty(string_0) ? Environment.CurrentDirectory : string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public string B3274D19
	{
		get
		{
			return C19E99B8 ?? "Select a folder";
		}
		set
		{
			C19E99B8 = value;
		}
	}

	public string BE267DBD => string_1;

	public bool method_0()
	{
		return B8091A03(IntPtr.Zero);
	}

	public bool B8091A03(IntPtr intptr_0)
	{
		Struct0 @struct = ((Environment.OSVersion.Version.Major >= 6) ? Class3.B88A0103(intptr_0, D316343E, B3274D19) : smethod_0(intptr_0, D316343E, B3274D19));
		string_1 = @struct.String_0;
		return @struct.D82256AB;
	}

	private static Struct0 smethod_0(IntPtr CE210437, string AC01EE03, string string_2)
	{
		FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
		{
			Description = string_2,
			SelectedPath = AC01EE03,
			ShowNewFolderButton = false
		};
		Struct0 result = default(Struct0);
		if (folderBrowserDialog.ShowDialog(new A6912A1B(CE210437)) == DialogResult.OK)
		{
			result.D82256AB = true;
			result.String_0 = folderBrowserDialog.SelectedPath;
		}
		return result;
	}
}
