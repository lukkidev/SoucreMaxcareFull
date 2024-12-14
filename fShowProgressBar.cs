using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class fShowProgressBar : Form
{
	[CompilerGenerated]
	private sealed class BC00688F
	{
		public int A8989F25;

		public int int_0;

		public fShowProgressBar EB130218;

		internal void method_0()
		{
			EB130218.lblproccess.Text = string.Format(F7AB102E.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), A8989F25, int_0);
		}
	}

	[CompilerGenerated]
	private sealed class DA3FF13F
	{
		public double double_0;

		public BC00688F bc00688F_0;

		internal void method_0()
		{
			bc00688F_0.EB130218.lblproccess.Text = string.Format(F7AB102E.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), bc00688F_0.A8989F25, bc00688F_0.int_0);
			bc00688F_0.EB130218.FBB6E711.Value = int.Parse(Math.Truncate(double_0).ToString());
		}
	}

	private List<string> list_0 = new List<string>();

	private IContainer icontainer_0 = null;

	private Label lblproccess;

	private ProgressBar FBB6E711;

	public fShowProgressBar(List<string> list_1)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		list_0 = list_1;
	}

	private void A62E6384(object sender, EventArgs e)
	{
		try
		{
			new Thread((ThreadStart)delegate
			{
				string text = "";
				string text2 = "";
				int A8989F25 = 0;
				int int_0 = list_0.Count;
				BeginInvoke((MethodInvoker)delegate
				{
					lblproccess.Text = string.Format(F7AB102E.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), A8989F25, int_0);
				});
				for (int i = 0; i < list_0.Count; i++)
				{
					text = list_0[i].Split('|')[0];
					text2 = list_0[i].Split('|')[1];
					if (GClass28.F5950616(text, text2, E83A520A: true))
					{
						int num = A8989F25;
						A8989F25 = num + 1;
					}
					double double_0 = (double)A8989F25 * 1.0 / (double)int_0 * 100.0;
					BeginInvoke((MethodInvoker)delegate
					{
						lblproccess.Text = string.Format(F7AB102E.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), A8989F25, int_0);
						FBB6E711.Value = int.Parse(Math.Truncate(double_0).ToString());
					});
				}
				BeginInvoke((MethodInvoker)delegate
				{
					Close();
				});
			}).Start();
		}
		catch (Exception ex)
		{
			GClass29.smethod_0("Error: " + ex.Message, 2);
			Close();
		}
	}

	protected override void Dispose(bool B58400A4)
	{
		if (B58400A4 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B58400A4);
	}

	private void InitializeComponent()
	{
		lblproccess = new System.Windows.Forms.Label();
		FBB6E711 = new System.Windows.Forms.ProgressBar();
		SuspendLayout();
		lblproccess.AutoSize = true;
		lblproccess.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblproccess.Location = new System.Drawing.Point(34, 22);
		lblproccess.Name = "lblproccess";
		lblproccess.Size = new System.Drawing.Size(189, 16);
		lblproccess.TabIndex = 1;
		lblproccess.Text = "Đang copy, vui lo\u0300ng chơ\u0300 (0/0)...";
		FBB6E711.Location = new System.Drawing.Point(37, 52);
		FBB6E711.Name = "progressBar1";
		FBB6E711.Size = new System.Drawing.Size(219, 23);
		FBB6E711.TabIndex = 2;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
		base.ClientSize = new System.Drawing.Size(294, 104);
		base.Controls.Add(FBB6E711);
		base.Controls.Add(lblproccess);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fShowProgressBar";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "frm_progress";
		base.Load += new System.EventHandler(A62E6384);
		ResumeLayout(false);
		PerformLayout();
	}

	[CompilerGenerated]
	private void method_0()
	{
		string text = "";
		string text2 = "";
		int A8989F25 = 0;
		int int_0 = list_0.Count;
		BeginInvoke((MethodInvoker)delegate
		{
			lblproccess.Text = string.Format(F7AB102E.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), A8989F25, int_0);
		});
		for (int i = 0; i < list_0.Count; i++)
		{
			text = list_0[i].Split('|')[0];
			text2 = list_0[i].Split('|')[1];
			if (GClass28.F5950616(text, text2, E83A520A: true))
			{
				int num = A8989F25;
				A8989F25 = num + 1;
			}
			double double_0 = (double)A8989F25 * 1.0 / (double)int_0 * 100.0;
			BeginInvoke((MethodInvoker)delegate
			{
				lblproccess.Text = string.Format(F7AB102E.smethod_0("Đang copy, vui lo\u0300ng chơ\u0300 ({0}/{1})..."), A8989F25, int_0);
				FBB6E711.Value = int.Parse(Math.Truncate(double_0).ToString());
			});
		}
		BeginInvoke((MethodInvoker)delegate
		{
			Close();
		});
	}

	[CompilerGenerated]
	private void method_1()
	{
		Close();
	}
}
