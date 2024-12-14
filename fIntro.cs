using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using maxcare.Properties;

public class fIntro : Form
{
	private IContainer B49F3ABA;

	private ProgressBar F928AA08;

	private Timer D6877633;

	private Timer timer_0;

	private Label label7;

	private ucContact ucContact1;

	private ucContact2 D69E8504;

	[DllImport("kernel32.dll")]
	private static extern long GetVolumeInformation(string BC35BF24, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint CE29E096, ref uint D2BC8CBF, StringBuilder stringBuilder_1, uint uint_2);

	public fIntro()
	{
		AB9E1299();
		F7AB102E.D6B70A35(this);
	}

	private void FC3B0DBA(object sender, EventArgs e)
	{
		D6877633.Tick += C71A4413;
		D6877633.Start();
	}

	private void C71A4413(object sender, EventArgs e)
	{
		if (base.Opacity >= 1.0)
		{
			D6877633.Stop();
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\drivers\\etc\\hosts";
				if (File.Exists(path))
				{
					try
					{
						List<string> list = new List<string> { "minsoftware" };
						using StreamReader streamReader = new StreamReader(path);
						string empty = string.Empty;
						while ((empty = streamReader.ReadLine()) != null)
						{
							foreach (string item in list)
							{
								if (empty.ToLower().Contains(item))
								{
									GClass29.smethod_0("Vui lòng cấu hình lại file hosts nếu muốn mở phần mềm!", 2);
									Environment.Exit(0);
								}
							}
						}
					}
					catch
					{
					}
				}
				string text = GClass25.smethod_0("settingLogin").C0288288("UserName");
				string text2 = GClass25.smethod_0("settingLogin").C0288288("PassWord");
				if (text == "" || text2 == "")
				{
					text = Settings.Default.UserName;
					text2 = Settings.Default.PassWord;
					if (text != "" || text2 != "")
					{
						GClass25.smethod_0("settingLogin").method_4("UserName", text);
						GClass25.smethod_0("settingLogin").method_4("PassWord", text2);
						GClass25.B3B73732("settingLogin");
					}
				}
				if (!(text == "") && !(text2 == "") && GClass8.smethod_47(text))
				{
					string text3 = GClass8.BA2E8F14(text, text2);
					if (text3.StartsWith("0|"))
					{
						Hide();
						new fActive(text3.Substring(2)).ShowDialog();
						return;
					}
					text3 = text3.Substring(2);
					Hide();
					try
					{
						new fMain(text3).ShowDialog();
					}
					catch (Exception ex)
					{
						GClass29.smethod_0(ex.ToString(), 2);
						new fActive("").ShowDialog();
					}
					try
					{
						Environment.Exit(0);
					}
					catch (Exception)
					{
						Application.Exit();
					}
				}
				else
				{
					Hide();
					new fActive(1).ShowDialog();
				}
			}
			catch (Exception f4295AA)
			{
				GClass29.smethod_0("Co\u0301 lô\u0303i xa\u0309y ra, vui lo\u0300ng liên hê\u0323 Admin đê\u0309 đươ\u0323c hô\u0303 trơ\u0323!", 2);
				GClass8.BFBDF687(null, f4295AA, "Run Program");
				Close();
			}
		}
		else
		{
			base.Opacity += 0.05;
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		if (base.Opacity <= 0.0)
		{
			D6877633.Stop();
			Close();
		}
		else
		{
			base.Opacity -= 0.05;
		}
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (F928AA08.Value < 90)
		{
			F928AA08.Value += 10;
		}
		else
		{
			timer_0.Stop();
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && B49F3ABA != null)
		{
			B49F3ABA.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void AB9E1299()
	{
		B49F3ABA = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(fIntro));
		F928AA08 = new ProgressBar();
		D6877633 = new Timer(B49F3ABA);
		timer_0 = new Timer(B49F3ABA);
		label7 = new Label();
		ucContact1 = new ucContact();
		D69E8504 = new ucContact2();
		SuspendLayout();
		F928AA08.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		F928AA08.Location = new Point(38, 508);
		F928AA08.Name = "progressBar";
		F928AA08.Size = new Size(668, 23);
		F928AA08.Step = 50;
		F928AA08.TabIndex = 7;
		D6877633.Interval = 30;
		timer_0.Enabled = true;
		timer_0.Tick += timer_0_Tick;
		label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		label7.AutoSize = true;
		label7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label7.ForeColor = Color.DarkViolet;
		label7.Location = new Point(556, 488);
		label7.Name = "label7";
		label7.Size = new Size(154, 16);
		label7.TabIndex = 9;
		label7.Text = "Đang kiểm tra thông tin...";
		ucContact1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		ucContact1.Location = new Point(13, 13);
		ucContact1.Margin = new Padding(4);
		ucContact1.Name = "ucContact1";
		ucContact1.Size = new Size(714, 470);
		ucContact1.TabIndex = 10;
		D69E8504.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		D69E8504.Location = new Point(13, 13);
		D69E8504.Margin = new Padding(4);
		D69E8504.Name = "ucContact21";
		D69E8504.Size = new Size(714, 470);
		D69E8504.TabIndex = 11;
		base.AutoScaleMode = AutoScaleMode.None;
		BackColor = Color.WhiteSmoke;
		base.ClientSize = new Size(746, 543);
		base.Controls.Add(label7);
		base.Controls.Add(F928AA08);
		base.Controls.Add(ucContact1);
		base.Controls.Add(D69E8504);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "fIntro";
		base.Opacity = 0.0;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "Kiểm tra thông tin";
		base.Load += FC3B0DBA;
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // fIntro
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "fIntro";
            this.Load += new System.EventHandler(this.fIntro_Load);
            this.ResumeLayout(false);

    }

    private void fIntro_Load(object sender, EventArgs e)
    {

    }
}
