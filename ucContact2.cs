using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class ucContact2 : UserControl
{
	private IContainer icontainer_0 = null;

	private Label D43074A5;

	private Label label3;

	private Panel C01EBF27;

	private LinkLabel linkLabel1;

	private LinkLabel linkLabel2;

	private Label FDB27036;

	private Label F71811BB;

	private Label label6;

	private Label label11;

	private PictureBox B9073994;

	private PictureBox FFBED70A;

	private Label CE9FF889;

	private Label label7;

	private Label label2;

	public ucContact2()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void linkLabel2_Click(object sender, EventArgs e)
	{
		string text = (sender as LinkLabel).Text;
		try
		{
			Process.Start("chrome.exe", text);
		}
		catch
		{
			Process.Start(text);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	protected override void Dispose(bool CCA1EE8C)
	{
		if (CCA1EE8C && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(CCA1EE8C);
	}

	private void InitializeComponent()
	{
		D43074A5 = new System.Windows.Forms.Label();
		label3 = new System.Windows.Forms.Label();
		C01EBF27 = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		linkLabel2 = new System.Windows.Forms.LinkLabel();
		FDB27036 = new System.Windows.Forms.Label();
		label7 = new System.Windows.Forms.Label();
		F71811BB = new System.Windows.Forms.Label();
		label6 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		label11 = new System.Windows.Forms.Label();
		CE9FF889 = new System.Windows.Forms.Label();
		B9073994 = new System.Windows.Forms.PictureBox();
		FFBED70A = new System.Windows.Forms.PictureBox();
		C01EBF27.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)B9073994).BeginInit();
		((System.ComponentModel.ISupportInitialize)FFBED70A).BeginInit();
		SuspendLayout();
		D43074A5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		D43074A5.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		D43074A5.ForeColor = System.Drawing.Color.Red;
		D43074A5.Location = new System.Drawing.Point(214, 355);
		D43074A5.Name = "label12";
		D43074A5.Size = new System.Drawing.Size(489, 110);
		D43074A5.TabIndex = 28;
		D43074A5.Text = "Chú ý: Nghiêm cấm sử dụng phần mềm vào các mục đích xấu, vi phạm pháp luật. Nếu cố tình sẽ bị xóa khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trước pháp luật.";
		D43074A5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		label3.AutoSize = true;
		label3.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label3.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		label3.Location = new System.Drawing.Point(209, 172);
		label3.Name = "label3";
		label3.Size = new System.Drawing.Size(164, 25);
		label3.TabIndex = 27;
		label3.Text = "Hỗ trợ phần mềm:";
		C01EBF27.BackColor = System.Drawing.Color.WhiteSmoke;
		C01EBF27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C01EBF27.Controls.Add(linkLabel1);
		C01EBF27.Controls.Add(linkLabel2);
		C01EBF27.Controls.Add(FDB27036);
		C01EBF27.Controls.Add(label7);
		C01EBF27.Controls.Add(F71811BB);
		C01EBF27.Controls.Add(label6);
		C01EBF27.Controls.Add(label2);
		C01EBF27.Controls.Add(label11);
		C01EBF27.Location = new System.Drawing.Point(214, 200);
		C01EBF27.Name = "panel2";
		C01EBF27.Size = new System.Drawing.Size(489, 121);
		C01EBF27.TabIndex = 25;
		linkLabel1.AutoSize = true;
		linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		linkLabel1.Location = new System.Drawing.Point(94, 4);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(190, 25);
		linkLabel1.TabIndex = 9;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "https://bit.ly/43sB9Zq";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		linkLabel1.Click += new System.EventHandler(linkLabel2_Click);
		linkLabel2.AutoSize = true;
		linkLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		linkLabel2.Location = new System.Drawing.Point(94, 33);
		linkLabel2.Name = "linkLabel2";
		linkLabel2.Size = new System.Drawing.Size(190, 25);
		linkLabel2.TabIndex = 9;
		linkLabel2.TabStop = true;
		linkLabel2.Text = "https://bit.ly/43sB9Zq";
		linkLabel2.Click += new System.EventHandler(linkLabel2_Click);
		FDB27036.AutoSize = true;
		FDB27036.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FDB27036.ForeColor = System.Drawing.Color.Black;
		FDB27036.Location = new System.Drawing.Point(3, 4);
		FDB27036.Name = "label4";
		FDB27036.Size = new System.Drawing.Size(83, 25);
		FDB27036.TabIndex = 2;
		FDB27036.Text = "Website:";
		label7.AutoSize = true;
		label7.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label7.ForeColor = System.Drawing.Color.Black;
		label7.Location = new System.Drawing.Point(3, 91);
		label7.Name = "label7";
		label7.Size = new System.Drawing.Size(62, 25);
		label7.TabIndex = 2;
		label7.Text = "CSKH:";
		F71811BB.AutoSize = true;
		F71811BB.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		F71811BB.ForeColor = System.Drawing.Color.Black;
		F71811BB.Location = new System.Drawing.Point(3, 64);
		F71811BB.Name = "label5";
		F71811BB.Size = new System.Drawing.Size(77, 25);
		F71811BB.TabIndex = 2;
		F71811BB.Text = "Hotline:";
		label6.AutoSize = true;
		label6.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label6.ForeColor = System.Drawing.Color.Black;
		label6.Location = new System.Drawing.Point(3, 33);
		label6.Name = "label6";
		label6.Size = new System.Drawing.Size(87, 25);
		label6.TabIndex = 2;
		label6.Text = "Fanpage:";
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.ForeColor = System.Drawing.Color.Black;
		label2.Location = new System.Drawing.Point(94, 91);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(128, 25);
		label2.TabIndex = 2;
		label2.Text = "087-777-8777";
		label11.AutoSize = true;
		label11.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label11.ForeColor = System.Drawing.Color.Black;
		label11.Location = new System.Drawing.Point(94, 64);
		label11.Name = "label11";
		label11.Size = new System.Drawing.Size(128, 25);
		label11.TabIndex = 2;
		label11.Text = "089-999-8999";
		CE9FF889.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		CE9FF889.Location = new System.Drawing.Point(33, 143);
		CE9FF889.Name = "label1";
		CE9FF889.Size = new System.Drawing.Size(653, 21);
		CE9FF889.TabIndex = 21;
		CE9FF889.Text = "PHẦN MỀM HỖ TRỢ KINH DOANH ONLINE - TỰ ĐỘNG HÓA MỌI THAO TÁC CỦA BẠN";
		CE9FF889.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		B9073994.Image = C50FB39E.Bitmap_10;
		B9073994.Location = new System.Drawing.Point(-17, 172);
		B9073994.Name = "pictureBox2";
		B9073994.Size = new System.Drawing.Size(229, 293);
		B9073994.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		B9073994.TabIndex = 23;
		B9073994.TabStop = false;
		FFBED70A.Image = C50FB39E.A782BD1B;
		FFBED70A.Location = new System.Drawing.Point(66, 3);
		FFBED70A.Name = "pictureBox1";
		FFBED70A.Size = new System.Drawing.Size(620, 130);
		FFBED70A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		FFBED70A.TabIndex = 22;
		FFBED70A.TabStop = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.Controls.Add(D43074A5);
		base.Controls.Add(label3);
		base.Controls.Add(C01EBF27);
		base.Controls.Add(B9073994);
		base.Controls.Add(FFBED70A);
		base.Controls.Add(CE9FF889);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucContact2";
		base.Size = new System.Drawing.Size(714, 470);
		C01EBF27.ResumeLayout(false);
		C01EBF27.PerformLayout();
		((System.ComponentModel.ISupportInitialize)B9073994).EndInit();
		((System.ComponentModel.ISupportInitialize)FFBED70A).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
