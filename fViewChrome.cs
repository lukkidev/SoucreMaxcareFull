using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public class fViewChrome : Form
{
	[CompilerGenerated]
	private sealed class Class76
	{
		public IntPtr DE193B30;

		public fViewChrome D8884B97;

		public int E2B52A30;

		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		internal void method_0()
		{
			C13DF1B3.SetParent(DE193B30, (from Control control_0 in D8884B97.panelListDevice.Controls
				where control_0.Tag.Equals(E2B52A30)
				select control_0).FirstOrDefault().Handle);
			C13DF1B3.MoveWindow(DE193B30, int_0, int_1, int_2, int_3, A9365B38: true);
		}

		internal bool method_1(Control control_0)
		{
			return control_0.Tag.Equals(E2B52A30);
		}
	}

	[CompilerGenerated]
	private sealed class Class77
	{
		public fViewChrome B13726AB;

		public Control control_0;

		internal void method_0()
		{
			B13726AB.panelListDevice.Controls.Remove(control_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class78
	{
		public fViewChrome fViewChrome_0;

		public Panel panel_0;

		internal void AC8A2812()
		{
			fViewChrome_0.panelListDevice.Controls.Add(panel_0);
		}
	}

	[CompilerGenerated]
	private sealed class D00B71B3
	{
		public fViewChrome fViewChrome_0;

		public int int_0;

		internal void B5A78E04()
		{
			fViewChrome_0.Text = fViewChrome_0.Text.Replace(Regex.Match(fViewChrome_0.Text, "\\((.*?)\\)").Value, "(" + int_0 + ")");
		}
	}

	private fMain fMain_0 = null;

	public static fViewChrome fViewChrome_0;

	private IContainer icontainer_0 = null;

	private FlowLayoutPanel panelListDevice;

	public fViewChrome()
	{
		InitializeComponent();
		fViewChrome_0 = this;
		F7AB102E.D6B70A35(this);
	}

	public fViewChrome(fMain CE0B68B2)
	{
		InitializeComponent();
		fViewChrome_0 = this;
		fMain_0 = CE0B68B2;
		F7AB102E.D6B70A35(this);
	}

	public void method_0(IntPtr intptr_0, int int_0, int int_1, int B1369082, int A93CD705 = -10, int C9ACE09B = -30)
	{
		Invoke((MethodInvoker)delegate
		{
			C13DF1B3.SetParent(intptr_0, (from Control control_0 in panelListDevice.Controls
				where control_0.Tag.Equals(int_0)
				select control_0).FirstOrDefault().Handle);
			C13DF1B3.MoveWindow(intptr_0, A93CD705, C9ACE09B, int_1, B1369082, A9365B38: true);
		});
		EEA44CA4();
	}

	public void E0AACC8E(int EA04971F)
	{
		Control control_0 = panelListDevice.Controls["dv" + EA04971F];
		panelListDevice.Invoke((MethodInvoker)delegate
		{
			panelListDevice.Controls.Remove(control_0);
		});
		EEA44CA4();
	}

	public void method_1(int int_0, int B51C7CB4, int CC8002A2)
	{
		Panel panel_0 = new Panel();
		panel_0.Name = "dv" + int_0;
		panel_0.Tag = int_0;
		panel_0.Size = new Size(B51C7CB4, CC8002A2);
		panel_0.BackColor = Color.White;
		panel_0.BorderStyle = BorderStyle.FixedSingle;
		Invoke((MethodInvoker)delegate
		{
			panelListDevice.Controls.Add(panel_0);
		});
		for (int i = 0; i < 10; i++)
		{
			if (panelListDevice.Controls["dv" + int_0] != null)
			{
				break;
			}
			Thread.Sleep(1000);
		}
	}

	private void D5AFB40B(object sender, EventArgs e)
	{
		E0AACC8E(Convert.ToInt32((sender as PictureBox).Name.Replace("pic", "")));
	}

	public void EEA44CA4()
	{
		int int_0 = panelListDevice.Controls.Count;
		Invoke((MethodInvoker)delegate
		{
			Text = Text.Replace(Regex.Match(Text, "\\((.*?)\\)").Value, "(" + int_0 + ")");
		});
		if (fMain_0 != null)
		{
			fMain_0.method_160(int_0);
		}
	}

	protected override void Dispose(bool DB91479F)
	{
		if (DB91479F && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(DB91479F);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fViewChrome));
		panelListDevice = new System.Windows.Forms.FlowLayoutPanel();
		SuspendLayout();
		panelListDevice.AutoScroll = true;
		panelListDevice.BackColor = System.Drawing.Color.White;
		panelListDevice.Dock = System.Windows.Forms.DockStyle.Fill;
		panelListDevice.Location = new System.Drawing.Point(0, 0);
		panelListDevice.Name = "panelListDevice";
		panelListDevice.Padding = new System.Windows.Forms.Padding(10);
		panelListDevice.Size = new System.Drawing.Size(933, 554);
		panelListDevice.TabIndex = 1;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(933, 554);
		base.Controls.Add(panelListDevice);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fViewChrome";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "MaxCare - Form View Chrome (0)";
		ResumeLayout(false);
	}
}
