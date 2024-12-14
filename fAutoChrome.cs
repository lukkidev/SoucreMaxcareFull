using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

public class fAutoChrome : Form
{
	[CompilerGenerated]
	private sealed class Class56
	{
		public fAutoChrome fAutoChrome_0;

		public string A02F00AD;

		internal void method_0()
		{
			try
			{
				fAutoChrome_0.btnRun.C22B543F(bool_0: false);
				fAutoChrome_0.AE300E97.C22B543F();
				fAutoChrome_0.EB21FA14.smethod_0("Running...");
				string text = new GClass3
				{
					Int32_2 = fAutoChrome_0.int_0,
					A294ABA3 = fAutoChrome_0.string_0,
					EA39AD33 = false
				}.method_62(A02F00AD);
				fAutoChrome_0.EB21FA14.smethod_0(string.IsNullOrEmpty(text) ? "Empty" : text);
				fAutoChrome_0.btnRun.C22B543F();
			}
			catch (Exception)
			{
			}
		}
	}

	private int int_0;

	private string string_0;

	private IContainer icontainer_0 = null;

	private RichTextBox B9084E90;

	private Button btnRun;

	private RichTextBox EB21FA14;

	private PictureBox E22359AA;

	private Button C2A20400;

	private Button AE300E97;

	public fAutoChrome(int int_1, string string_1)
	{
		F431FCB5();
		int_0 = int_1;
		string_0 = string_1;
	}

	private void btnRun_Click(object sender, EventArgs e)
	{
		GClass25.smethod_0("configGeneral").method_4("txtCode", B9084E90.Text);
		GClass25.smethod_0("configGeneral").method_6();
		string A02F00AD = B9084E90.SelectedText.Trim();
		if (A02F00AD == "")
		{
			A02F00AD = B9084E90.Text.Trim();
		}
		if (File.Exists(A02F00AD))
		{
			A02F00AD = File.ReadAllText(A02F00AD).Trim();
			if (A02F00AD.Contains("#region"))
			{
				A02F00AD = Regex.Match(A02F00AD, "\\/\\/\\#region(.*?)\\/\\/\\#endregion", RegexOptions.Singleline).Groups[1].Value.Trim();
			}
		}
		if (string.IsNullOrEmpty(A02F00AD))
		{
			return;
		}
		new Thread((ThreadStart)delegate
		{
			try
			{
				btnRun.C22B543F(bool_0: false);
				AE300E97.C22B543F();
				EB21FA14.smethod_0("Running...");
				string text = new GClass3
				{
					Int32_2 = int_0,
					A294ABA3 = string_0,
					EA39AD33 = false
				}.method_62(A02F00AD);
				EB21FA14.smethod_0(string.IsNullOrEmpty(text) ? "Empty" : text);
				btnRun.C22B543F();
			}
			catch (Exception)
			{
			}
		}).Start();
	}

	private void F5A2C0A8(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.F5)
		{
			btnRun_Click(null, null);
		}
	}

	private void D422AEBE(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.F5)
		{
			btnRun_Click(null, null);
		}
	}

	private void B0A369AB(object sender, EventArgs e)
	{
		B9084E90.Text = GClass25.smethod_0("configGeneral").C0288288("txtCode");
	}

	private void C2A20400_Click(object sender, EventArgs e)
	{
		new Thread((ThreadStart)delegate
		{
			string text = new GClass3
			{
				Int32_2 = int_0,
				A294ABA3 = string_0
			}.E9B89BB8("ScreenshotToBase64");
			if (!(text == ""))
			{
				byte[] buffer = Convert.FromBase64String(text);
				using MemoryStream stream = new MemoryStream(buffer);
				E22359AA.Image = Image.FromStream(stream);
			}
		}).Start();
	}

	private void AE300E97_Click(object sender, EventArgs e)
	{
		new Thread((ThreadStart)delegate
		{
			try
			{
				AE300E97.C22B543F(bool_0: false);
				GClass3 gClass = new GClass3();
				gClass.Int32_2 = int_0;
				gClass.A294ABA3 = string_0;
				gClass.EA39AD33 = false;
				gClass.DFACBCA6();
			}
			catch (Exception)
			{
			}
		}).Start();
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void F431FCB5()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fAutoChrome));
		B9084E90 = new RichTextBox();
		btnRun = new Button();
		EB21FA14 = new RichTextBox();
		E22359AA = new PictureBox();
		C2A20400 = new Button();
		AE300E97 = new Button();
		((ISupportInitialize)E22359AA).BeginInit();
		SuspendLayout();
		B9084E90.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		B9084E90.Location = new Point(13, 13);
		B9084E90.Name = "txtCode";
		B9084E90.Size = new Size(614, 28);
		B9084E90.TabIndex = 0;
		B9084E90.Text = "";
		B9084E90.WordWrap = false;
		B9084E90.KeyDown += F5A2C0A8;
		btnRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		btnRun.Location = new Point(263, 47);
		btnRun.Name = "btnRun";
		btnRun.Size = new Size(261, 35);
		btnRun.TabIndex = 1;
		btnRun.Text = "Run (F5)";
		btnRun.UseVisualStyleBackColor = true;
		btnRun.Click += btnRun_Click;
		EB21FA14.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		EB21FA14.Location = new Point(263, 88);
		EB21FA14.Name = "txtResult";
		EB21FA14.Size = new Size(364, 260);
		EB21FA14.TabIndex = 0;
		EB21FA14.Text = "";
		EB21FA14.WordWrap = false;
		E22359AA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		E22359AA.BorderStyle = BorderStyle.FixedSingle;
		E22359AA.Location = new Point(13, 47);
		E22359AA.Name = "pictureBox1";
		E22359AA.Size = new Size(244, 260);
		E22359AA.SizeMode = PictureBoxSizeMode.Zoom;
		E22359AA.TabIndex = 2;
		E22359AA.TabStop = false;
		C2A20400.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		C2A20400.Location = new Point(12, 313);
		C2A20400.Name = "button1";
		C2A20400.Size = new Size(245, 35);
		C2A20400.TabIndex = 1;
		C2A20400.Text = "Capture";
		C2A20400.UseVisualStyleBackColor = true;
		C2A20400.Click += C2A20400_Click;
		AE300E97.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		AE300E97.Location = new Point(530, 47);
		AE300E97.Name = "btnStop";
		AE300E97.Size = new Size(97, 35);
		AE300E97.TabIndex = 1;
		AE300E97.Text = "Stop";
		AE300E97.UseVisualStyleBackColor = true;
		AE300E97.Click += AE300E97_Click;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.White;
		base.ClientSize = new Size(640, 358);
		base.Controls.Add(E22359AA);
		base.Controls.Add(C2A20400);
		base.Controls.Add(AE300E97);
		base.Controls.Add(btnRun);
		base.Controls.Add(EB21FA14);
		base.Controls.Add(B9084E90);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Margin = new Padding(4);
		base.Name = "fAutoChrome";
		base.SizeGripStyle = SizeGripStyle.Hide;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Auto Chrome";
		base.Load += B0A369AB;
		base.KeyDown += D422AEBE;
		((ISupportInitialize)E22359AA).EndInit();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void method_0()
	{
		string text = new GClass3
		{
			Int32_2 = int_0,
			A294ABA3 = string_0
		}.E9B89BB8("ScreenshotToBase64");
		if (!(text == ""))
		{
			byte[] buffer = Convert.FromBase64String(text);
			using MemoryStream stream = new MemoryStream(buffer);
			E22359AA.Image = Image.FromStream(stream);
		}
	}

	[CompilerGenerated]
	private void method_1()
	{
		try
		{
			AE300E97.C22B543F(bool_0: false);
			GClass3 gClass = new GClass3();
			gClass.Int32_2 = int_0;
			gClass.A294ABA3 = string_0;
			gClass.EA39AD33 = false;
			gClass.DFACBCA6();
		}
		catch (Exception)
		{
		}
	}
}
