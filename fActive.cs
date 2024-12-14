using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;

public class fActive : Form
{
	[CompilerGenerated]
	private sealed class Class99
	{
		public fActive fActive_0;

		public string DEAAE3B7;

		public string E6856B17;

		public MethodInvoker ED854BAB;

		public MethodInvoker methodInvoker_0;

		public MethodInvoker methodInvoker_1;

		public MethodInvoker methodInvoker_2;

		public MethodInvoker AA06DE3A;

		public MethodInvoker D633373C;

		public MethodInvoker DF98E101;

		internal void EA8B4E1D()
		{
			fActive_0.btnLogin.Invoke((MethodInvoker)delegate
			{
				fActive_0.btnLogin.Enabled = false;
			});
			fActive_0.lblStatus.Invoke((MethodInvoker)delegate
			{
				fActive_0.lblStatus.Text = F7AB102E.smethod_0("Đang kiểm tra đăng nhập...");
			});
			try
			{
				Class100 CS_0024_003C_003E8__locals0 = new Class100
				{
					class99_0 = this,
					F2B7FD28 = GClass8.BA2E8F14(DEAAE3B7, E6856B17)
				};
				if (CS_0024_003C_003E8__locals0.F2B7FD28.StartsWith("0|"))
				{
					fActive_0.lblStatus.Invoke((MethodInvoker)delegate
					{
						CS_0024_003C_003E8__locals0.class99_0.fActive_0.lblStatus.Text = CS_0024_003C_003E8__locals0.F2B7FD28.Substring(2);
					});
					fActive_0.btnLogin.Invoke((MethodInvoker)delegate
					{
						fActive_0.btnLogin.Enabled = true;
					});
					return;
				}
				CS_0024_003C_003E8__locals0.F2B7FD28 = CS_0024_003C_003E8__locals0.F2B7FD28.Substring(2);
				if (CS_0024_003C_003E8__locals0.F2B7FD28.Split('|').Length < 3)
				{
					fActive_0.lblStatus.Invoke((MethodInvoker)delegate
					{
						fActive_0.lblStatus.Text = F7AB102E.smethod_0("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
					});
					fActive_0.btnLogin.Invoke((MethodInvoker)delegate
					{
						fActive_0.btnLogin.Enabled = true;
					});
					return;
				}
				GClass25.smethod_0("settingLogin").method_4("UserName", DEAAE3B7);
				GClass25.smethod_0("settingLogin").method_4("PassWord", E6856B17);
				GClass25.B3B73732("settingLogin");
				fActive_0.lblStatus.Invoke((MethodInvoker)delegate
				{
					fActive_0.lblStatus.Text = F7AB102E.smethod_0("Đăng nhập thành công!");
				});
				GClass8.B4A7A29C();
				return;
			}
			catch (Exception ex)
			{
				GClass29.smethod_0("Active error:\n" + ex.ToString(), 3);
				GClass8.BFBDF687(null, ex, "Active error");
				GClass29.smethod_0("Lỗi không xác định!!!", 2);
			}
			fActive_0.btnLogin.Invoke((MethodInvoker)delegate
			{
				fActive_0.btnLogin.Enabled = true;
			});
		}

		internal void CABBB600()
		{
			fActive_0.btnLogin.Enabled = false;
		}

		internal void method_0()
		{
			fActive_0.lblStatus.Text = F7AB102E.smethod_0("Đang kiểm tra đăng nhập...");
		}

		internal void AFB5B18D()
		{
			fActive_0.btnLogin.Enabled = true;
		}

		internal void method_1()
		{
			fActive_0.lblStatus.Text = F7AB102E.smethod_0("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
		}

		internal void method_2()
		{
			fActive_0.btnLogin.Enabled = true;
		}

		internal void B4995D0D()
		{
			fActive_0.lblStatus.Text = F7AB102E.smethod_0("Đăng nhập thành công!");
		}

		internal void CF33D601()
		{
			fActive_0.btnLogin.Enabled = true;
		}
	}

	[CompilerGenerated]
	private sealed class Class100
	{
		public string F2B7FD28;

		public Class99 class99_0;

		internal void method_0()
		{
			class99_0.fActive_0.lblStatus.Text = F2B7FD28.Substring(2);
		}
	}

	private int int_0 = 0;

	private Bitmap bitmap_0 = C50FB39E.Bitmap_171;

	private Bitmap D7B2698B = C50FB39E.FDA14EBE;

	private IContainer icontainer_0 = null;

	private BunifuCards bunifuCards1;

	private Panel DD2F4707;

	private PictureBox pictureBox1;

	private BunifuCustomLabel bunifuCustomLabel1;

	private BunifuMetroTextbox txbUserName;

	private BunifuCustomLabel bunifuCustomLabel2;

	private BunifuCustomLabel bunifuCustomLabel3;

	private BunifuMetroTextbox A72B2234;

	private Button btnLogin;

	private Label lblStatus;

	private LinkLabel linkLabel1;

	private Label E00C8E1B;

	private Button D18114A5;

	private BunifuDragControl D9B1009F;

	private PictureBox pictureBox2;

	private BunifuCustomLabel A1840A8F;

	private BunifuCustomLabel bunifuCustomLabel6;

	private BunifuCustomLabel bunifuCustomLabel4;

	private BunifuCustomLabel lblKey;

	private BunifuCustomLabel bunifuCustomLabel7;

	private BunifuDragControl bunifuDragControl_0;

	private BunifuCustomLabel bunifuCustomLabel5;

	private BunifuCustomLabel lblServer;

	private ComboBox E2042910;

	private LinkLabel FFB75408;

	private Label label2;

	private PictureBox picLanguage;

	public fActive(int int_1)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		int_0 = int_1;
		lblStatus.Text = method_0(int_1);
		lblKey.Text = GClass8.BB845FB4();
		GClass8.smethod_23(E2042910, Class57.smethod_1());
		picLanguage.Image = ((Class57.smethod_2() != "VN") ? bitmap_0 : D7B2698B);
		bunifuCustomLabel1.Text = bunifuCustomLabel1.Text.Split('-')[0] + "- " + F7AB102E.smethod_0(bunifuCustomLabel1.Text.Split('-')[1].Trim());
	}

	public fActive(string FF3CD9B9)
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
		lblStatus.Text = FF3CD9B9;
		lblKey.Text = GClass8.BB845FB4();
		GClass8.smethod_23(E2042910, Class57.smethod_1());
		picLanguage.Image = ((Class57.smethod_2() != "VN") ? bitmap_0 : D7B2698B);
	}

	private void E52279AD(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private string method_0(int A808AD88 = 0)
	{
		return A808AD88 switch
		{
			0 => "", 
			1 => F7AB102E.smethod_0("Vui lòng đăng nhập để sử dụng phần mềm!!!"), 
			2 => F7AB102E.smethod_0("Thiết bị của bạn chưa được kích hoạt!!!"), 
			3 => F7AB102E.smethod_0("Thiết bị của bạn đã hết hạn sử dụng!!!"), 
			4 => F7AB102E.smethod_0("Tài khoản hoặc mật khẩu bạn nhập không đúng!!!"), 
			5 => F7AB102E.smethod_0("Server Error!!!"), 
			_ => F7AB102E.smethod_0("Lỗi không xác định!!!"), 
		};
	}

	private void btnLogin_Click(object sender, EventArgs e)
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
		string DEAAE3B7 = txbUserName.Text.Trim();
		string E6856B17 = A72B2234.Text.Trim();
		if (!(DEAAE3B7 == "") && !(E6856B17 == ""))
		{
			if (!DEAAE3B7.Contains("@"))
			{
				DEAAE3B7 += "@gmail.com";
			}
			GClass25.smethod_0("settingLogin").method_4("Server", E2042910.SelectedValue);
			GClass25.B3B73732("settingLogin");
			string F2B7FD28;
			new Thread((ThreadStart)delegate
			{
				btnLogin.Invoke((MethodInvoker)delegate
				{
					btnLogin.Enabled = false;
				});
				lblStatus.Invoke((MethodInvoker)delegate
				{
					lblStatus.Text = F7AB102E.smethod_0("Đang kiểm tra đăng nhập...");
				});
				try
				{
					F2B7FD28 = GClass8.BA2E8F14(DEAAE3B7, E6856B17);
					if (F2B7FD28.StartsWith("0|"))
					{
						lblStatus.Invoke((MethodInvoker)delegate
						{
							lblStatus.Text = F2B7FD28.Substring(2);
						});
						btnLogin.Invoke((MethodInvoker)delegate
						{
							btnLogin.Enabled = true;
						});
					}
					else
					{
						F2B7FD28 = F2B7FD28.Substring(2);
						if (F2B7FD28.Split('|').Length < 3)
						{
							lblStatus.Invoke((MethodInvoker)delegate
							{
								lblStatus.Text = F7AB102E.smethod_0("Không thể kích hoạt tài khoản của bạn, vui lòng thử lại!!!");
							});
							btnLogin.Invoke((MethodInvoker)delegate
							{
								btnLogin.Enabled = true;
							});
						}
						else
						{
							GClass25.smethod_0("settingLogin").method_4("UserName", DEAAE3B7);
							GClass25.smethod_0("settingLogin").method_4("PassWord", E6856B17);
							GClass25.B3B73732("settingLogin");
							lblStatus.Invoke((MethodInvoker)delegate
							{
								lblStatus.Text = F7AB102E.smethod_0("Đăng nhập thành công!");
							});
							GClass8.B4A7A29C();
						}
					}
					return;
				}
				catch (Exception ex)
				{
					GClass29.smethod_0("Active error:\n" + ex.ToString(), 3);
					GClass8.BFBDF687(null, ex, "Active error");
					GClass29.smethod_0("Lỗi không xác định!!!", 2);
				}
				btnLogin.Invoke((MethodInvoker)delegate
				{
					btnLogin.Enabled = true;
				});
			}).Start();
		}
		else
		{
			GClass29.smethod_0("Vui lòng điền đầy đủ thông tin!", 3);
		}
	}

	private void fActive_FormClosing(object sender, FormClosingEventArgs e)
	{
		Environment.Exit(0);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		GClass8.FB0F49A9("https://app.minsoftware.vn/signup");
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
		GClass8.smethod_27(lblKey.Text);
		GClass29.smethod_0("Đã copy mã thiết bị!");
	}

	private void A72B2234_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			btnLogin_Click(null, null);
		}
	}

	private void A6263596(object sender, EventArgs e)
	{
		if (!lblServer.Visible)
		{
			lblServer.Visible = true;
			E2042910.Visible = true;
			base.Height = 320;
		}
		else
		{
			lblServer.Visible = false;
			E2042910.Visible = false;
			base.Height = 275;
		}
	}

	private void F9B01C96(object sender, EventArgs e)
	{
		E2042910.SelectedValue = Class57.E0AE7DB2();
	}

	private void FFB75408_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = "https://bit.ly/DieukhoanvaChinhsach";
		try
		{
			Process.Start("chrome.exe", text);
		}
		catch
		{
			Process.Start(text);
		}
	}

	private void picLanguage_Click(object sender, EventArgs e)
	{
		if (picLanguage.Image == bitmap_0)
		{
			picLanguage.Image = D7B2698B;
			Class57.EC2BD382();
			GClass29.smethod_0("Vui lòng mở lại phần mềm để cập nhật ngôn ngữ!");
		}
		else
		{
			picLanguage.Image = bitmap_0;
			Class57.EC2BD382("EN");
		}
		Class57.smethod_2();
		F7AB102E.D6B70A35(this);
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		icontainer_0 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fActive));
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		DD2F4707 = new System.Windows.Forms.Panel();
		picLanguage = new System.Windows.Forms.PictureBox();
		D18114A5 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
		txbUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
		bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
		A72B2234 = new Bunifu.Framework.UI.BunifuMetroTextbox();
		btnLogin = new System.Windows.Forms.Button();
		lblStatus = new System.Windows.Forms.Label();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		E00C8E1B = new System.Windows.Forms.Label();
		D9B1009F = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		pictureBox2 = new System.Windows.Forms.PictureBox();
		A1840A8F = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
		lblKey = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
		bunifuDragControl_0 = new Bunifu.Framework.UI.BunifuDragControl(icontainer_0);
		bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
		lblServer = new Bunifu.Framework.UI.BunifuCustomLabel();
		E2042910 = new System.Windows.Forms.ComboBox();
		FFB75408 = new System.Windows.Forms.LinkLabel();
		label2 = new System.Windows.Forms.Label();
		bunifuCards1.SuspendLayout();
		DD2F4707.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)picLanguage).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
		SuspendLayout();
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.SaddleBrown;
		bunifuCards1.Controls.Add(DD2F4707);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(0, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(395, 38);
		bunifuCards1.TabIndex = 11;
		DD2F4707.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		DD2F4707.BackColor = System.Drawing.Color.White;
		DD2F4707.Controls.Add(picLanguage);
		DD2F4707.Controls.Add(D18114A5);
		DD2F4707.Controls.Add(pictureBox1);
		DD2F4707.Controls.Add(bunifuCustomLabel1);
		DD2F4707.Cursor = System.Windows.Forms.Cursors.SizeAll;
		DD2F4707.Location = new System.Drawing.Point(0, 5);
		DD2F4707.Name = "pnlHeader";
		DD2F4707.Size = new System.Drawing.Size(393, 32);
		DD2F4707.TabIndex = 9;
		picLanguage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		picLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
		picLanguage.Image = C50FB39E.FDA14EBE;
		picLanguage.Location = new System.Drawing.Point(330, 3);
		picLanguage.Name = "picLanguage";
		picLanguage.Size = new System.Drawing.Size(25, 25);
		picLanguage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		picLanguage.TabIndex = 15;
		picLanguage.TabStop = false;
		picLanguage.Click += new System.EventHandler(picLanguage_Click);
		D18114A5.Cursor = System.Windows.Forms.Cursors.Hand;
		D18114A5.Dock = System.Windows.Forms.DockStyle.Right;
		D18114A5.FlatAppearance.BorderSize = 0;
		D18114A5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		D18114A5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D18114A5.ForeColor = System.Drawing.Color.White;
		D18114A5.Image = (System.Drawing.Image)resources.GetObject("btnMinimize.Image");
		D18114A5.Location = new System.Drawing.Point(361, 0);
		D18114A5.Name = "btnMinimize";
		D18114A5.Size = new System.Drawing.Size(32, 32);
		D18114A5.TabIndex = 13;
		D18114A5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		D18114A5.UseVisualStyleBackColor = true;
		D18114A5.Click += new System.EventHandler(E52279AD);
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(6, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 12;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(A6263596);
		bunifuCustomLabel1.AutoSize = true;
		bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
		bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
		bunifuCustomLabel1.Location = new System.Drawing.Point(42, 7);
		bunifuCustomLabel1.Name = "bunifuCustomLabel1";
		bunifuCustomLabel1.Size = new System.Drawing.Size(221, 16);
		bunifuCustomLabel1.TabIndex = 7;
		bunifuCustomLabel1.Text = "MAX CARE - Kích hoạt bản quyền";
		txbUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
		txbUserName.BorderColorFocused = System.Drawing.Color.FromArgb(192, 64, 0);
		txbUserName.BorderColorIdle = System.Drawing.Color.FromArgb(64, 64, 64);
		txbUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(192, 64, 0);
		txbUserName.BorderThickness = 3;
		txbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
		txbUserName.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		txbUserName.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		txbUserName.isPassword = false;
		txbUserName.Location = new System.Drawing.Point(117, 46);
		txbUserName.Margin = new System.Windows.Forms.Padding(4);
		txbUserName.Name = "txbUserName";
		txbUserName.Size = new System.Drawing.Size(228, 29);
		txbUserName.TabIndex = 0;
		txbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		txbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(A72B2234_KeyDown);
		bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
		bunifuCustomLabel2.AutoSize = true;
		bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel2.Location = new System.Drawing.Point(37, 52);
		bunifuCustomLabel2.Name = "bunifuCustomLabel2";
		bunifuCustomLabel2.Size = new System.Drawing.Size(44, 16);
		bunifuCustomLabel2.TabIndex = 13;
		bunifuCustomLabel2.Text = "Email:";
		bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
		bunifuCustomLabel3.AutoSize = true;
		bunifuCustomLabel3.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel3.Location = new System.Drawing.Point(37, 88);
		bunifuCustomLabel3.Name = "bunifuCustomLabel3";
		bunifuCustomLabel3.Size = new System.Drawing.Size(72, 16);
		bunifuCustomLabel3.TabIndex = 15;
		bunifuCustomLabel3.Text = "Mật khẩu:";
		A72B2234.Anchor = System.Windows.Forms.AnchorStyles.Top;
		A72B2234.BorderColorFocused = System.Drawing.Color.FromArgb(192, 64, 0);
		A72B2234.BorderColorIdle = System.Drawing.Color.FromArgb(64, 64, 64);
		A72B2234.BorderColorMouseHover = System.Drawing.Color.FromArgb(192, 64, 0);
		A72B2234.BorderThickness = 3;
		A72B2234.Cursor = System.Windows.Forms.Cursors.IBeam;
		A72B2234.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A72B2234.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
		A72B2234.isPassword = true;
		A72B2234.Location = new System.Drawing.Point(117, 83);
		A72B2234.Margin = new System.Windows.Forms.Padding(4);
		A72B2234.Name = "txbPassword";
		A72B2234.Size = new System.Drawing.Size(228, 29);
		A72B2234.TabIndex = 1;
		A72B2234.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		A72B2234.KeyDown += new System.Windows.Forms.KeyEventHandler(A72B2234_KeyDown);
		btnLogin.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
		btnLogin.FlatAppearance.BorderSize = 0;
		btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnLogin.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnLogin.ForeColor = System.Drawing.Color.White;
		btnLogin.Location = new System.Drawing.Point(149, 178);
		btnLogin.Name = "btnLogin";
		btnLogin.Size = new System.Drawing.Size(115, 29);
		btnLogin.TabIndex = 2;
		btnLogin.Text = "Đăng nhập";
		btnLogin.UseVisualStyleBackColor = false;
		btnLogin.Click += new System.EventHandler(btnLogin_Click);
		lblStatus.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		lblStatus.ForeColor = System.Drawing.Color.Red;
		lblStatus.Location = new System.Drawing.Point(10, 157);
		lblStatus.Name = "lblStatus";
		lblStatus.Size = new System.Drawing.Size(371, 18);
		lblStatus.TabIndex = 28;
		lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		linkLabel1.AutoSize = true;
		linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
		linkLabel1.LinkColor = System.Drawing.Color.FromArgb(53, 120, 229);
		linkLabel1.Location = new System.Drawing.Point(285, 217);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(27, 16);
		linkLabel1.TabIndex = 3;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "đây";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		E00C8E1B.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		E00C8E1B.AutoSize = true;
		E00C8E1B.Location = new System.Drawing.Point(100, 217);
		E00C8E1B.Name = "label1";
		E00C8E1B.Size = new System.Drawing.Size(187, 16);
		E00C8E1B.TabIndex = 30;
		E00C8E1B.Text = "Đăng ký tài khoản mới bấm vào";
		E00C8E1B.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		D9B1009F.Fixed = true;
		D9B1009F.Horizontal = true;
		D9B1009F.TargetControl = DD2F4707;
		D9B1009F.Vertical = true;
		pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
		pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
		pictureBox2.Location = new System.Drawing.Point(357, 281);
		pictureBox2.Name = "pictureBox2";
		pictureBox2.Size = new System.Drawing.Size(20, 20);
		pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox2.TabIndex = 42;
		pictureBox2.TabStop = false;
		pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
		A1840A8F.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A1840A8F.AutoSize = true;
		A1840A8F.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A1840A8F.ForeColor = System.Drawing.Color.Gray;
		A1840A8F.Location = new System.Drawing.Point(94, 240);
		A1840A8F.Name = "bunifuCustomLabel8";
		A1840A8F.Size = new System.Drawing.Size(140, 13);
		A1840A8F.TabIndex = 40;
		A1840A8F.Text = "https://minsoftware.vn";
		bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel6.AutoSize = true;
		bunifuCustomLabel6.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel6.Location = new System.Drawing.Point(22, 240);
		bunifuCustomLabel6.Name = "bunifuCustomLabel6";
		bunifuCustomLabel6.Size = new System.Drawing.Size(56, 13);
		bunifuCustomLabel6.TabIndex = 38;
		bunifuCustomLabel6.Text = "Website:";
		bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel4.AutoSize = true;
		bunifuCustomLabel4.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel4.Location = new System.Drawing.Point(22, 262);
		bunifuCustomLabel4.Name = "bunifuCustomLabel4";
		bunifuCustomLabel4.Size = new System.Drawing.Size(53, 13);
		bunifuCustomLabel4.TabIndex = 39;
		bunifuCustomLabel4.Text = "Hotline: ";
		lblKey.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		lblKey.AutoSize = true;
		lblKey.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblKey.ForeColor = System.Drawing.Color.Gray;
		lblKey.Location = new System.Drawing.Point(94, 284);
		lblKey.Name = "lblKey";
		lblKey.Size = new System.Drawing.Size(231, 13);
		lblKey.TabIndex = 37;
		lblKey.Text = "********************************";
		bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel7.AutoSize = true;
		bunifuCustomLabel7.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel7.Location = new System.Drawing.Point(22, 284);
		bunifuCustomLabel7.Name = "bunifuCustomLabel7";
		bunifuCustomLabel7.Size = new System.Drawing.Size(70, 13);
		bunifuCustomLabel7.TabIndex = 36;
		bunifuCustomLabel7.Text = "Mã thiết bị:";
		bunifuDragControl_0.Fixed = true;
		bunifuDragControl_0.Horizontal = true;
		bunifuDragControl_0.TargetControl = bunifuCustomLabel1;
		bunifuDragControl_0.Vertical = true;
		bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		bunifuCustomLabel5.AutoSize = true;
		bunifuCustomLabel5.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		bunifuCustomLabel5.ForeColor = System.Drawing.Color.Gray;
		bunifuCustomLabel5.Location = new System.Drawing.Point(94, 262);
		bunifuCustomLabel5.Name = "bunifuCustomLabel5";
		bunifuCustomLabel5.Size = new System.Drawing.Size(257, 13);
		bunifuCustomLabel5.TabIndex = 41;
		bunifuCustomLabel5.Text = "0969.078.803 - 0966.260.829 - 0973.363.129";
		lblServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
		lblServer.AutoSize = true;
		lblServer.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		lblServer.Location = new System.Drawing.Point(37, 127);
		lblServer.Name = "lblServer";
		lblServer.Size = new System.Drawing.Size(56, 16);
		lblServer.TabIndex = 43;
		lblServer.Text = "Server:";
		E2042910.Cursor = System.Windows.Forms.Cursors.Hand;
		E2042910.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		E2042910.FormattingEnabled = true;
		E2042910.ItemHeight = 16;
		E2042910.Location = new System.Drawing.Point(119, 122);
		E2042910.Name = "cbbServer";
		E2042910.Size = new System.Drawing.Size(226, 24);
		E2042910.TabIndex = 46;
		FFB75408.Cursor = System.Windows.Forms.Cursors.Hand;
		FFB75408.Location = new System.Drawing.Point(153, 419);
		FFB75408.Name = "linkLabel2";
		FFB75408.Size = new System.Drawing.Size(109, 16);
		FFB75408.TabIndex = 50;
		FFB75408.TabStop = true;
		FFB75408.Text = "(Xem điều khoản)";
		FFB75408.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FFB75408.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(FFB75408_LinkClicked);
		label2.ForeColor = System.Drawing.Color.Red;
		label2.Location = new System.Drawing.Point(0, 400);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(393, 16);
		label2.TabIndex = 49;
		label2.Text = "Khi đăng nhập, bạn đã đồng ý với điều khoản của chúng tôi!";
		label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(393, 311);
		base.Controls.Add(FFB75408);
		base.Controls.Add(label2);
		base.Controls.Add(lblServer);
		base.Controls.Add(pictureBox2);
		base.Controls.Add(A1840A8F);
		base.Controls.Add(bunifuCustomLabel5);
		base.Controls.Add(bunifuCustomLabel6);
		base.Controls.Add(bunifuCustomLabel4);
		base.Controls.Add(lblKey);
		base.Controls.Add(bunifuCustomLabel7);
		base.Controls.Add(linkLabel1);
		base.Controls.Add(E00C8E1B);
		base.Controls.Add(lblStatus);
		base.Controls.Add(btnLogin);
		base.Controls.Add(bunifuCustomLabel3);
		base.Controls.Add(A72B2234);
		base.Controls.Add(bunifuCustomLabel2);
		base.Controls.Add(txbUserName);
		base.Controls.Add(bunifuCards1);
		base.Controls.Add(E2042910);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "fActive";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "MAX CARE";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(fActive_FormClosing);
		base.Load += new System.EventHandler(F9B01C96);
		bunifuCards1.ResumeLayout(false);
		DD2F4707.ResumeLayout(false);
		DD2F4707.PerformLayout();
		((System.ComponentModel.ISupportInitialize)picLanguage).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
