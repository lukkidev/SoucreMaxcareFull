using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class BF16B7AA : Form
{
	[CompilerGenerated]
	private sealed class E1881602
	{
		public BF16B7AA AB300ABD;

		public Uri uri_0;

		public string string_0;

		internal void method_0()
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += AB300ABD.method_3;
			webClient.DownloadFileCompleted += AB300ABD.B314823A;
			webClient.DownloadFileAsync(uri_0, string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class62
	{
		public DownloadProgressChangedEventArgs C19AAD2D;

		public BF16B7AA bf16B7AA_0;

		internal void method_0()
		{
			double num = double.Parse(C19AAD2D.BytesReceived.ToString());
			double num2 = double.Parse(C19AAD2D.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			bf16B7AA_0.lblproccess.Text = $"Downloading ({int.Parse(Math.Truncate(d).ToString())}%)...";
			bf16B7AA_0.progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
		}
	}

	private string string_0 = "";

	private string string_1 = "";

	private IContainer icontainer_0 = null;

	private Label lblproccess;

	private ProgressBar progressBar1;

	public BF16B7AA(string string_2)
	{
		InitializeComponent();
		method_0();
		string_0 = string_2;
		string_1 = Path.GetFileName(string_0);
	}

	private void method_0()
	{
		F7AB102E.smethod_1(lblproccess);
	}

	private void AF03CAB4(object sender, EventArgs e)
	{
		try
		{
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			if (Class63.smethod_0())
			{
				Uri uri_ = new Uri(string_0);
				GClass8.smethod_67("download");
				GClass8.smethod_32("download");
				D69B2584(uri_, "download\\" + string_1);
			}
			else
			{
				GClass29.smethod_0(F7AB102E.smethod_0("Không co\u0301 kê\u0301t nô\u0301i Internet, vui lo\u0300ng kiê\u0309m tra la\u0323i!"));
				Close();
			}
		}
		catch (Exception ex)
		{
			GClass29.smethod_0("Error: " + ex.Message, 2);
			Close();
		}
	}

	public void method_1(string E7086C2C, string string_2)
	{
		DirectoryInfo directoryInfo_ = new DirectoryInfo(E7086C2C);
		DirectoryInfo directoryInfo_2 = new DirectoryInfo(string_2);
		method_2(directoryInfo_, directoryInfo_2);
	}

	public void method_2(DirectoryInfo directoryInfo_0, DirectoryInfo directoryInfo_1)
	{
		Directory.CreateDirectory(directoryInfo_1.FullName);
		int num = 1;
		FileInfo[] files = directoryInfo_0.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			Application.DoEvents();
			fileInfo.CopyTo(Path.Combine(directoryInfo_1.FullName, fileInfo.Name), overwrite: true);
			num++;
		}
		DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			DirectoryInfo directoryInfo_2 = directoryInfo_1.CreateSubdirectory(directoryInfo.Name);
			method_2(directoryInfo, directoryInfo_2);
		}
	}

	private void D69B2584(Uri uri_0, string string_2)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += method_3;
			webClient.DownloadFileCompleted += B314823A;
			webClient.DownloadFileAsync(uri_0, string_2);
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void method_3(object sender, DownloadProgressChangedEventArgs e)
	{
		BeginInvoke((MethodInvoker)delegate
		{
			double num = double.Parse(e.BytesReceived.ToString());
			double num2 = double.Parse(e.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			lblproccess.Text = $"Downloading ({int.Parse(Math.Truncate(d).ToString())}%)...";
			progressBar1.Value = int.Parse(Math.Truncate(d).ToString());
		});
	}

	private void B314823A(object sender, AsyncCompletedEventArgs e)
	{
		BeginInvoke((MethodInvoker)delegate
		{
			lblproccess.Text = F7AB102E.smethod_0("Unzip file...");
		});
		try
		{
			ZipFile.ExtractToDirectory("./download/" + string_1, "./download/");
			GClass8.smethod_71("./download/" + string_1);
			if (File.Exists("download\\driver\\win32\\chromedriver.exe"))
			{
				method_1("download\\driver\\win32", "./");
			}
			else
			{
				method_1("download", "./");
			}
			GClass8.smethod_67("download");
			BeginInvoke((MethodInvoker)delegate
			{
				Close();
			});
		}
		catch (Exception ex)
		{
			GClass29.smethod_0("Error: " + ex.Message, 2);
			BeginInvoke((MethodInvoker)delegate
			{
				Close();
			});
		}
	}

	protected override void Dispose(bool F0333B19)
	{
		if (F0333B19 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(F0333B19);
	}

	private void InitializeComponent()
	{
		lblproccess = new System.Windows.Forms.Label();
		progressBar1 = new System.Windows.Forms.ProgressBar();
		SuspendLayout();
		lblproccess.AutoSize = true;
		lblproccess.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblproccess.Location = new System.Drawing.Point(34, 22);
		lblproccess.Name = "lblproccess";
		lblproccess.Size = new System.Drawing.Size(125, 16);
		lblproccess.TabIndex = 1;
		lblproccess.Text = "Downloading (0%)...";
		progressBar1.Location = new System.Drawing.Point(37, 52);
		progressBar1.Name = "progressBar1";
		progressBar1.Size = new System.Drawing.Size(219, 23);
		progressBar1.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.ClientSize = new System.Drawing.Size(294, 104);
		base.Controls.Add(progressBar1);
		base.Controls.Add(lblproccess);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fDownloadFile";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "frm_progress";
		base.Load += new System.EventHandler(AF03CAB4);
		ResumeLayout(false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_4()
	{
		lblproccess.Text = F7AB102E.smethod_0("Unzip file...");
	}

	[CompilerGenerated]
	private void method_5()
	{
		Close();
	}

	[CompilerGenerated]
	private void method_6()
	{
		Close();
	}
}
