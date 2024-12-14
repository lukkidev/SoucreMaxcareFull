using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Newtonsoft.Json.Linq;

public class fHDScriptGemLogin : Form
{
	private GClass11 B938C229;

	private string E59DEB02;

	private string string_0;

	private string string_1;

	private int int_0;

	public static bool C9899115;

	private Dictionary<string, JObject> dictionary_0 = new Dictionary<string, JObject>();

	private string string_2 = "";

	private IContainer D926E933 = null;

	private BunifuDragControl ECBA5013;

	private BunifuDragControl F5018924;

	private Panel panel1;

	private TextBox BD94279B;

	private Label label1;

	private Button btnCancel;

	private Button A30F82A7;

	private BunifuCards bunifuCards1;

	private Panel EB2B6FB9;

	private Button F63FF582;

	private PictureBox pictureBox1;

	private BunifuCustomLabel D385DB0F;

	private ComboBox B31CAC27;

	private Label label4;

	private Button A9BA8427;

	private FlowLayoutPanel flowLayoutPanel;

	private NumericUpDown nudScriptTimeout;

	private Label label2;

	private Label label3;

	public fHDScriptGemLogin(string string_3, int int_1 = 0, string string_4 = "")
	{
		InitializeComponent();
		C9899115 = false;
		E59DEB02 = string_3;
		string_1 = string_4;
		int_0 = int_1;
		string text = base.Name.Substring(1);
		string text2 = "Script GemLogin";
		Class147.smethod_8(text, text2);
		string text3 = "";
		switch (int_1)
		{
		case 0:
		{
			DataTable dataTable2 = Class147.smethod_7("", text);
			string_0 = dataTable2.Rows[0]["Id_TuongTac"].ToString();
			BD94279B.Text = F7AB102E.smethod_0(dataTable2.Rows[0]["MoTa"].ToString());
			break;
		}
		case 1:
		{
			DataTable dataTable = Class147.F3057616(string_4);
			text3 = dataTable.Rows[0]["CauHinh"].ToString();
			A30F82A7.Text = F7AB102E.smethod_0("Câ\u0323p nhâ\u0323t");
			BD94279B.Text = dataTable.Rows[0]["TenHanhDong"].ToString();
			break;
		}
		}
		B938C229 = new GClass11(text3, bool_0: true);
		F7AB102E.D6B70A35(this);
	}

	private void A28D0000(object sender, EventArgs e)
	{
		try
		{
			nudScriptTimeout.Value = B938C229.method_2("nudScriptTimeout", 600);
			B31CAC27.Enabled = int_0 == 0;
			A9BA8427.Enabled = int_0 == 0;
			method_0();
			if (B31CAC27.Items.Count == 0)
			{
				return;
			}
			string text = B938C229.C0288288("cbbScripts");
			if (!dictionary_0.ContainsKey(text))
			{
				text = dictionary_0.First().Key;
			}
			B31CAC27.SelectedValue = text;
			if (int_0 == 0)
			{
				BD94279B.Text = B31CAC27.Text;
				return;
			}
			foreach (Panel control in flowLayoutPanel.Controls)
			{
				GControl0 gControl = control.Controls[0] as GControl0;
				gControl.vmethod_1(B938C229.C0288288(gControl.BB3F4406()));
			}
		}
		catch
		{
		}
	}

	private void F63FF582_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void DC9FA5A7(object sender, EventArgs e)
	{
		string text = BD94279B.Text.Trim();
		if (text == "")
		{
			GClass29.smethod_0("Vui lo\u0300ng nhâ\u0323p tên ha\u0300nh đô\u0323ng!", 3);
			return;
		}
		JObject jObject = new JObject();
		jObject["nudScriptTimeout"] = (JToken)Convert.ToInt32(nudScriptTimeout.Value);
		jObject["cbbScripts"] = (JToken)B31CAC27.SelectedValue.ToString();
		foreach (Panel control in flowLayoutPanel.Controls)
		{
			GControl0 gControl = control.Controls[0] as GControl0;
			if (gControl.BB3F4406() != "")
			{
				jObject[gControl.BB3F4406()] = JToken.FromObject(gControl.vmethod_4());
			}
		}
		string text2 = jObject.ToString();
		if (int_0 == 0)
		{
			if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n thêm ha\u0300nh đô\u0323ng mơ\u0301i?") == DialogResult.Yes)
			{
				if (Class147.smethod_12(E59DEB02, text, string_0, text2))
				{
					C9899115 = true;
					Close();
				}
				else
				{
					GClass29.smethod_0("Thêm thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
				}
			}
		}
		else if (GClass29.smethod_1("Ba\u0323n co\u0301 muô\u0301n câ\u0323p nhâ\u0323t ha\u0300nh đô\u0323ng?") == DialogResult.Yes)
		{
			if (Class147.smethod_13(string_1, text, text2))
			{
				C9899115 = true;
				Close();
			}
			else
			{
				GClass29.smethod_0("Câ\u0323p nhâ\u0323t thâ\u0301t ba\u0323i, vui lo\u0300ng thư\u0309 la\u0323i sau!", 2);
			}
		}
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
		if (panel1.BorderStyle == BorderStyle.FixedSingle)
		{
			int num = 1;
			int num2 = 0;
			using Pen pen = new Pen(Color.DarkViolet, 1f);
			e.Graphics.DrawRectangle(pen, new Rectangle(num2, num2, panel1.ClientSize.Width - num, panel1.ClientSize.Height - num));
		}
	}

	private void C4B0A081(object sender, EventArgs e)
	{
	}

	private void A9BA8427_Click(object sender, EventArgs e)
	{
		method_0();
	}

	private void method_0()
	{
		try
		{
			string text = (B31CAC27.SelectedValue ?? "").ToString();
			B31CAC27.SelectedValueChanged -= B31CAC27_SelectedValueChanged;
			dictionary_0.Clear();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string text2 = new GClass0().method_1("http://localhost:1010/api/scripts");
			if (text2 == "")
			{
				GClass29.smethod_0("Không thể kết nối đến GemLogin", 2);
				return;
			}
			JObject jObject = JObject.Parse(text2);
			foreach (JToken item in (IEnumerable<JToken>)(jObject["data"]!))
			{
				string key = item["id"]!.ToString();
				string value = item["name"]!.ToString();
				dictionary.Add(key, value);
				dictionary_0.Add(key, (JObject)item);
			}
			GClass8.smethod_23(B31CAC27, dictionary);
			if (dictionary_0.ContainsKey(text))
			{
				B31CAC27.SelectedValue = text;
			}
			else
			{
				B31CAC27.SelectedIndex = -1;
			}
			B31CAC27.SelectedValueChanged += B31CAC27_SelectedValueChanged;
		}
		catch (Exception)
		{
		}
	}

	private void B31CAC27_SelectedValueChanged(object sender, EventArgs e)
	{
		if (B31CAC27.SelectedValue == null || B31CAC27.SelectedValue.ToString() == string_2)
		{
			return;
		}
		string_2 = B31CAC27.SelectedValue.ToString();
		try
		{
			if (int_0 == 0)
			{
				BD94279B.Text = B31CAC27.Text;
			}
			JArray jArray = dictionary_0[B31CAC27.SelectedValue.ToString()]["parameters"] as JArray;
			flowLayoutPanel.Controls.Clear();
			foreach (JObject item in jArray)
			{
				method_1(item);
			}
		}
		catch (Exception)
		{
		}
	}

	private void method_1(JObject B61F6605)
	{
		try
		{
			string text = B61F6605["type"]!.ToString();
			string text2 = B61F6605["name"]!.ToString();
			string e61EF5BE = B61F6605["label"]!.ToString();
			string d08A2AB = B61F6605["defaultValue"]!.ToString();
			string text3 = B61F6605["description"]!.ToString();
			Convert.ToBoolean(B61F6605["required"]);
			int num = -1;
			GControl0 gControl = null;
			switch (text)
			{
			case "checkbox":
				gControl = new ucInputCheckbox();
				break;
			case "filepath":
				gControl = new ucInputFilePath();
				break;
			case "number":
				gControl = new ucInputNumber();
				break;
			case "json":
				gControl = new ucInputJson();
				break;
			case "string":
				gControl = new ucInputText();
				break;
			}
			gControl.E80DAA2A(text2);
			gControl.vmethod_0(e61EF5BE);
			gControl.E71C8ABA(d08A2AB);
			gControl.method_0(text3);
			Point pt = new Point(gControl.Size.Width + 2, gControl.Size.Height);
			Panel panel = new Panel();
			panel.Controls.Add(gControl);
			panel.BorderStyle = BorderStyle.FixedSingle;
			panel.Size = new Size(pt);
			flowLayoutPanel.Controls.Add(panel);
			if (num > -1)
			{
				flowLayoutPanel.Controls.SetChildIndex(panel, num);
			}
		}
		catch (Exception)
		{
		}
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && D926E933 != null)
		{
			D926E933.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		D926E933 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHDScriptGemLogin));
		ECBA5013 = new Bunifu.Framework.UI.BunifuDragControl(D926E933);
		D385DB0F = new Bunifu.Framework.UI.BunifuCustomLabel();
		F5018924 = new Bunifu.Framework.UI.BunifuDragControl(D926E933);
		EB2B6FB9 = new System.Windows.Forms.Panel();
		F63FF582 = new System.Windows.Forms.Button();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		panel1 = new System.Windows.Forms.Panel();
		flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
		nudScriptTimeout = new System.Windows.Forms.NumericUpDown();
		A9BA8427 = new System.Windows.Forms.Button();
		B31CAC27 = new System.Windows.Forms.ComboBox();
		BD94279B = new System.Windows.Forms.TextBox();
		label3 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label4 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		btnCancel = new System.Windows.Forms.Button();
		A30F82A7 = new System.Windows.Forms.Button();
		bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
		EB2B6FB9.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nudScriptTimeout).BeginInit();
		bunifuCards1.SuspendLayout();
		SuspendLayout();
		ECBA5013.Fixed = true;
		ECBA5013.Horizontal = true;
		ECBA5013.TargetControl = D385DB0F;
		ECBA5013.Vertical = true;
		D385DB0F.BackColor = System.Drawing.Color.Transparent;
		D385DB0F.Cursor = System.Windows.Forms.Cursors.SizeAll;
		D385DB0F.Dock = System.Windows.Forms.DockStyle.Fill;
		D385DB0F.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		D385DB0F.ForeColor = System.Drawing.Color.Black;
		D385DB0F.Location = new System.Drawing.Point(0, 0);
		D385DB0F.Name = "bunifuCustomLabel1";
		D385DB0F.Size = new System.Drawing.Size(523, 31);
		D385DB0F.TabIndex = 12;
		D385DB0F.Text = "Cấu hình Script GemLogin";
		D385DB0F.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		F5018924.Fixed = true;
		F5018924.Horizontal = true;
		F5018924.TargetControl = EB2B6FB9;
		F5018924.Vertical = true;
		EB2B6FB9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		EB2B6FB9.BackColor = System.Drawing.Color.White;
		EB2B6FB9.Controls.Add(F63FF582);
		EB2B6FB9.Controls.Add(pictureBox1);
		EB2B6FB9.Controls.Add(D385DB0F);
		EB2B6FB9.Cursor = System.Windows.Forms.Cursors.SizeAll;
		EB2B6FB9.Location = new System.Drawing.Point(0, 3);
		EB2B6FB9.Name = "pnlHeader";
		EB2B6FB9.Size = new System.Drawing.Size(523, 31);
		EB2B6FB9.TabIndex = 9;
		F63FF582.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		F63FF582.Cursor = System.Windows.Forms.Cursors.Hand;
		F63FF582.FlatAppearance.BorderSize = 0;
		F63FF582.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		F63FF582.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F63FF582.ForeColor = System.Drawing.Color.White;
		F63FF582.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
		F63FF582.Location = new System.Drawing.Point(492, 1);
		F63FF582.Name = "button1";
		F63FF582.Size = new System.Drawing.Size(30, 30);
		F63FF582.TabIndex = 77;
		F63FF582.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		F63FF582.UseVisualStyleBackColor = true;
		F63FF582.Click += new System.EventHandler(F63FF582_Click);
		pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
		pictureBox1.Image = C50FB39E.Bitmap_5;
		pictureBox1.Location = new System.Drawing.Point(3, 2);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(34, 27);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox1.TabIndex = 76;
		pictureBox1.TabStop = false;
		pictureBox1.Click += new System.EventHandler(C4B0A081);
		panel1.BackColor = System.Drawing.Color.White;
		panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		panel1.Controls.Add(flowLayoutPanel);
		panel1.Controls.Add(nudScriptTimeout);
		panel1.Controls.Add(A9BA8427);
		panel1.Controls.Add(B31CAC27);
		panel1.Controls.Add(BD94279B);
		panel1.Controls.Add(label3);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(label4);
		panel1.Controls.Add(label1);
		panel1.Controls.Add(btnCancel);
		panel1.Controls.Add(A30F82A7);
		panel1.Controls.Add(bunifuCards1);
		panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
		panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		panel1.Location = new System.Drawing.Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new System.Drawing.Size(526, 561);
		panel1.TabIndex = 0;
		panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		flowLayoutPanel.AutoScroll = true;
		flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
		flowLayoutPanel.Location = new System.Drawing.Point(128, 137);
		flowLayoutPanel.Name = "flowLayoutPanel";
		flowLayoutPanel.Size = new System.Drawing.Size(375, 363);
		flowLayoutPanel.TabIndex = 26;
		flowLayoutPanel.WrapContents = false;
		nudScriptTimeout.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		nudScriptTimeout.Location = new System.Drawing.Point(131, 108);
		nudScriptTimeout.Maximum = new decimal(new int[4] { 99999999, 0, 0, 0 });
		nudScriptTimeout.Minimum = new decimal(new int[4] { 60, 0, 0, 0 });
		nudScriptTimeout.Name = "nudScriptTimeout";
		nudScriptTimeout.Size = new System.Drawing.Size(352, 23);
		nudScriptTimeout.TabIndex = 35;
		nudScriptTimeout.Value = new decimal(new int[4] { 60, 0, 0, 0 });
		A9BA8427.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		A9BA8427.Cursor = System.Windows.Forms.Cursors.Hand;
		A9BA8427.Location = new System.Drawing.Point(424, 77);
		A9BA8427.Name = "btnReload";
		A9BA8427.Size = new System.Drawing.Size(60, 26);
		A9BA8427.TabIndex = 33;
		A9BA8427.Text = "Reload";
		A9BA8427.UseVisualStyleBackColor = true;
		A9BA8427.Click += new System.EventHandler(A9BA8427_Click);
		B31CAC27.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		B31CAC27.Cursor = System.Windows.Forms.Cursors.Hand;
		B31CAC27.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		B31CAC27.DropDownWidth = 350;
		B31CAC27.FormattingEnabled = true;
		B31CAC27.Location = new System.Drawing.Point(131, 78);
		B31CAC27.Name = "cbbScripts";
		B31CAC27.Size = new System.Drawing.Size(287, 24);
		B31CAC27.TabIndex = 1;
		BD94279B.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		BD94279B.Location = new System.Drawing.Point(131, 49);
		BD94279B.Name = "txtTenHanhDong";
		BD94279B.Size = new System.Drawing.Size(352, 23);
		BD94279B.TabIndex = 0;
		label3.AutoSize = true;
		label3.Location = new System.Drawing.Point(27, 137);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(92, 16);
		label3.TabIndex = 32;
		label3.Text = "Câ\u0301u hi\u0300nh cha\u0323y:";
		label2.AutoSize = true;
		label2.Location = new System.Drawing.Point(27, 110);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(79, 16);
		label2.TabIndex = 32;
		label2.Text = "Timeout (s):";
		label4.AutoSize = true;
		label4.Location = new System.Drawing.Point(27, 81);
		label4.Name = "label4";
		label4.Size = new System.Drawing.Size(76, 16);
		label4.TabIndex = 32;
		label4.Text = "Cho\u0323n script:";
		label1.AutoSize = true;
		label1.Location = new System.Drawing.Point(27, 52);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(98, 16);
		label1.TabIndex = 31;
		label1.Text = "Tên ha\u0300nh đô\u0323ng:";
		btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		btnCancel.BackColor = System.Drawing.Color.Maroon;
		btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		btnCancel.FlatAppearance.BorderSize = 0;
		btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		btnCancel.ForeColor = System.Drawing.Color.White;
		btnCancel.Location = new System.Drawing.Point(271, 518);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new System.Drawing.Size(92, 29);
		btnCancel.TabIndex = 10;
		btnCancel.Text = "Đóng";
		btnCancel.UseVisualStyleBackColor = false;
		btnCancel.Click += new System.EventHandler(btnCancel_Click);
		A30F82A7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
		A30F82A7.BackColor = System.Drawing.Color.FromArgb(53, 120, 229);
		A30F82A7.Cursor = System.Windows.Forms.Cursors.Hand;
		A30F82A7.FlatAppearance.BorderSize = 0;
		A30F82A7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		A30F82A7.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		A30F82A7.ForeColor = System.Drawing.Color.White;
		A30F82A7.Location = new System.Drawing.Point(164, 518);
		A30F82A7.Name = "btnAdd";
		A30F82A7.Size = new System.Drawing.Size(92, 29);
		A30F82A7.TabIndex = 9;
		A30F82A7.Text = "Thêm";
		A30F82A7.UseVisualStyleBackColor = false;
		A30F82A7.Click += new System.EventHandler(DC9FA5A7);
		bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		bunifuCards1.BackColor = System.Drawing.Color.White;
		bunifuCards1.BorderRadius = 0;
		bunifuCards1.BottomSahddow = true;
		bunifuCards1.color = System.Drawing.Color.DarkViolet;
		bunifuCards1.Controls.Add(EB2B6FB9);
		bunifuCards1.LeftSahddow = false;
		bunifuCards1.Location = new System.Drawing.Point(1, 0);
		bunifuCards1.Name = "bunifuCards1";
		bunifuCards1.RightSahddow = true;
		bunifuCards1.ShadowDepth = 20;
		bunifuCards1.Size = new System.Drawing.Size(523, 37);
		bunifuCards1.TabIndex = 28;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.ClientSize = new System.Drawing.Size(526, 561);
		base.Controls.Add(panel1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fHDScriptGemLogin";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
		Text = "Cấu hình tương tác";
		base.Load += new System.EventHandler(A28D0000);
		EB2B6FB9.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		panel1.ResumeLayout(false);
		panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nudScriptTimeout).EndInit();
		bunifuCards1.ResumeLayout(false);
		ResumeLayout(false);
	}
}
