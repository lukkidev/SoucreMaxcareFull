using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucContact : UserControl
{
	private IContainer icontainer_0 = null;

	private Label label12;

	private Label FFA4BC20;

	private Panel C6B3498A;

	private LinkLabel linkLabel1;

	private LinkLabel B119E513;

	private Label A736A238;

	private Label B93E8583;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label9;

	private Label DD2C8F9B;

	private Label label8;

	private Label label2;

	private PictureBox pictureBox3;

	public ucContact()
	{
		InitializeComponent();
		F7AB102E.D6B70A35(this);
	}

	private void B119E513_Click(object sender, EventArgs e)
	{
		string c7B2ADAC = (sender as LinkLabel).Text;
		GClass8.CD18FD80(c7B2ADAC);
	}

	private void B119E513_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void FE0522B7(object sender, LinkLabelLinkClickedEventArgs e)
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucContact));
		label12 = new System.Windows.Forms.Label();
		FFA4BC20 = new System.Windows.Forms.Label();
		C6B3498A = new System.Windows.Forms.Panel();
		linkLabel1 = new System.Windows.Forms.LinkLabel();
		B119E513 = new System.Windows.Forms.LinkLabel();
		label9 = new System.Windows.Forms.Label();
		DD2C8F9B = new System.Windows.Forms.Label();
		A736A238 = new System.Windows.Forms.Label();
		label8 = new System.Windows.Forms.Label();
		label2 = new System.Windows.Forms.Label();
		B93E8583 = new System.Windows.Forms.Label();
		label1 = new System.Windows.Forms.Label();
		pictureBox3 = new System.Windows.Forms.PictureBox();
		pictureBox2 = new System.Windows.Forms.PictureBox();
		pictureBox1 = new System.Windows.Forms.PictureBox();
		C6B3498A.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
		SuspendLayout();
		label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		label12.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label12.ForeColor = System.Drawing.Color.Red;
		label12.Location = new System.Drawing.Point(214, 355);
		label12.Name = "label12";
		label12.Size = new System.Drawing.Size(489, 110);
		label12.TabIndex = 28;
		label12.Text = "Chú ý: Nghiêm cấm sử dụng phần mềm vào các mục đích xấu, vi phạm pháp luật. Nếu cố tình sẽ bị xóa khỏi hệ thống vĩnh viễn, và phải chịu hoàn toàn trách nhiệm trước pháp luật.";
		label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		FFA4BC20.AutoSize = true;
		FFA4BC20.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		FFA4BC20.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		FFA4BC20.Location = new System.Drawing.Point(209, 172);
		FFA4BC20.Name = "label3";
		FFA4BC20.Size = new System.Drawing.Size(164, 25);
		FFA4BC20.TabIndex = 27;
		FFA4BC20.Text = "Hỗ trợ phần mềm:";
		C6B3498A.BackColor = System.Drawing.Color.WhiteSmoke;
		C6B3498A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		C6B3498A.Controls.Add(pictureBox3);
		C6B3498A.Controls.Add(linkLabel1);
		C6B3498A.Controls.Add(B119E513);
		C6B3498A.Controls.Add(label9);
		C6B3498A.Controls.Add(DD2C8F9B);
		C6B3498A.Controls.Add(A736A238);
		C6B3498A.Controls.Add(label8);
		C6B3498A.Controls.Add(label2);
		C6B3498A.Controls.Add(B93E8583);
		C6B3498A.Location = new System.Drawing.Point(214, 198);
		C6B3498A.Name = "panel2";
		C6B3498A.Size = new System.Drawing.Size(489, 147);
		C6B3498A.TabIndex = 25;
		linkLabel1.AutoSize = true;
		linkLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		linkLabel1.Location = new System.Drawing.Point(3, 7);
		linkLabel1.Name = "linkLabel1";
		linkLabel1.Size = new System.Drawing.Size(207, 25);
		linkLabel1.TabIndex = 9;
		linkLabel1.TabStop = true;
		linkLabel1.Text = "https://minsoftware.vn/";
		linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(FE0522B7);
		linkLabel1.Click += new System.EventHandler(B119E513_Click);
		B119E513.AutoSize = true;
		B119E513.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B119E513.Location = new System.Drawing.Point(3, 36);
		B119E513.Name = "linkLabel2";
		B119E513.Size = new System.Drawing.Size(310, 25);
		B119E513.TabIndex = 9;
		B119E513.TabStop = true;
		B119E513.Text = "https://fb.com/MINSoftwareofficial/";
		B119E513.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(B119E513_LinkClicked);
		B119E513.Click += new System.EventHandler(B119E513_Click);
		label9.AutoSize = true;
		label9.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label9.ForeColor = System.Drawing.Color.Black;
		label9.Location = new System.Drawing.Point(3, 118);
		label9.Name = "label9";
		label9.Size = new System.Drawing.Size(95, 25);
		label9.TabIndex = 2;
		label9.Text = "Khiếu nại:";
		DD2C8F9B.AutoSize = true;
		DD2C8F9B.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		DD2C8F9B.ForeColor = System.Drawing.Color.Black;
		DD2C8F9B.Location = new System.Drawing.Point(3, 91);
		DD2C8F9B.Name = "label7";
		DD2C8F9B.Size = new System.Drawing.Size(62, 25);
		DD2C8F9B.TabIndex = 2;
		DD2C8F9B.Text = "CSKH:";
		A736A238.AutoSize = true;
		A736A238.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		A736A238.ForeColor = System.Drawing.Color.Black;
		A736A238.Location = new System.Drawing.Point(3, 64);
		A736A238.Name = "label5";
		A736A238.Size = new System.Drawing.Size(77, 25);
		A736A238.TabIndex = 2;
		A736A238.Text = "Hotline:";
		label8.AutoSize = true;
		label8.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label8.ForeColor = System.Drawing.Color.Black;
		label8.Location = new System.Drawing.Point(94, 118);
		label8.Name = "label8";
		label8.Size = new System.Drawing.Size(120, 25);
		label8.TabIndex = 2;
		label8.Text = "0353.686.355";
		label2.AutoSize = true;
		label2.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		label2.ForeColor = System.Drawing.Color.Black;
		label2.Location = new System.Drawing.Point(94, 91);
		label2.Name = "label2";
		label2.Size = new System.Drawing.Size(120, 25);
		label2.TabIndex = 2;
		label2.Text = "0966.260.829";
		B93E8583.AutoSize = true;
		B93E8583.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		B93E8583.ForeColor = System.Drawing.Color.Black;
		B93E8583.Location = new System.Drawing.Point(94, 64);
		B93E8583.Name = "label11";
		B93E8583.Size = new System.Drawing.Size(120, 25);
		B93E8583.TabIndex = 2;
		B93E8583.Text = "0969.078.803";
		label1.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		label1.Location = new System.Drawing.Point(33, 143);
		label1.Name = "label1";
		label1.Size = new System.Drawing.Size(653, 21);
		label1.TabIndex = 21;
		label1.Text = "PHẦN MỀM HỖ TRỢ KINH DOANH ONLINE - TỰ ĐỘNG HÓA MỌI THAO TÁC CỦA BẠN";
		label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		pictureBox3.Image = C50FB39E.F632BE07;
		pictureBox3.Location = new System.Drawing.Point(340, -3);
		pictureBox3.Name = "pictureBox3";
		pictureBox3.Size = new System.Drawing.Size(150, 150);
		pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		pictureBox3.TabIndex = 11;
		pictureBox3.TabStop = false;
		pictureBox2.Image = C50FB39E.Bitmap_2;
		pictureBox2.Location = new System.Drawing.Point(-17, 172);
		pictureBox2.Name = "pictureBox2";
		pictureBox2.Size = new System.Drawing.Size(229, 293);
		pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		pictureBox2.TabIndex = 23;
		pictureBox2.TabStop = false;
		pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		pictureBox1.Location = new System.Drawing.Point(66, 3);
		pictureBox1.Name = "pictureBox1";
		pictureBox1.Size = new System.Drawing.Size(620, 130);
		pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		pictureBox1.TabIndex = 22;
		pictureBox1.TabStop = false;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
		base.Controls.Add(label12);
		base.Controls.Add(FFA4BC20);
		base.Controls.Add(C6B3498A);
		base.Controls.Add(pictureBox2);
		base.Controls.Add(pictureBox1);
		base.Controls.Add(label1);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucContact";
		base.Size = new System.Drawing.Size(714, 470);
		C6B3498A.ResumeLayout(false);
		C6B3498A.PerformLayout();
		((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}
}
