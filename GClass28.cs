using System;
using System.IO;
using System.Windows.Forms;

public class GClass28
{
	public static string smethod_0()
	{
		return Path.GetDirectoryName(Application.ExecutablePath);
	}

	public static string F0354920()
	{
		string result = "";
		try
		{
			using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
			{
				result = folderBrowserDialog.SelectedPath;
			}
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_1(string F4BE7C08 = "Chọn File txt", string C80F0FA2 = "C:\\", string EF11B891 = "txt Files (*.txt)|*.txt|All files (*.*)|*.*")
	{
		string result = "";
		try
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = EF11B891;
			openFileDialog.InitialDirectory = C80F0FA2;
			openFileDialog.Title = F4BE7C08;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				result = openFileDialog.FileName;
			}
		}
		catch
		{
		}
		return result;
	}

	public static bool F5950616(string E1A82E06, string E8342EA6, bool E83A520A)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(E1A82E06);
			if (!directoryInfo.Exists)
			{
				return false;
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			Directory.CreateDirectory(E8342EA6);
			FileInfo[] files = directoryInfo.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				string destFileName = Path.Combine(E8342EA6, fileInfo.Name);
				fileInfo.CopyTo(destFileName, overwrite: true);
			}
			if (E83A520A)
			{
				DirectoryInfo[] array2 = directories;
				foreach (DirectoryInfo directoryInfo2 in array2)
				{
					string e8342EA = Path.Combine(E8342EA6, directoryInfo2.Name);
					F5950616(directoryInfo2.FullName, e8342EA, E83A520A);
				}
			}
			return true;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static void smethod_2(string string_0)
	{
		try
		{
			File.AppendAllText(string_0, "");
		}
		catch
		{
		}
	}

	public static void F50D3020(string string_0)
	{
		try
		{
			Directory.CreateDirectory(string_0);
		}
		catch
		{
		}
	}
}
