using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucInputJson : GControl0
{
	private IContainer FC0BEB8F = null;

	private Panel E402C1A8;

	private Label B1291BA6;

	private RichTextBox F590F52F;

	public ucInputJson()
	{
		InitializeComponent();
	}

	public override void vmethod_0(string D8220D3E)
	{
		base.vmethod_0(D8220D3E);
		B1291BA6.Text = D8220D3E.TrimEnd(':') + ":";
	}

	public override void E71C8ABA(object F48B03B2)
	{
		base.E71C8ABA(F48B03B2);
		F590F52F.Text = Convert.ToString(F48B03B2);
	}

	public override void vmethod_1(object D33B5813)
	{
		F590F52F.Text = Convert.ToString(D33B5813);
	}

	public override object vmethod_4()
	{
		return F590F52F.Text;
	}

	public override string vmethod_3()
	{
		GClass11 gClass = new GClass11();
		gClass.method_4("type", vmethod_5());
		gClass.method_4("name", BB3F4406());
		gClass.method_4("label", method_1());
		gClass.method_4("defaultValue", method_2());
		gClass.method_4("value", vmethod_4());
		gClass.method_4("description", vmethod_2());
		return gClass.method_7();
	}

	public override string vmethod_5()
	{
		return "json";
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && FC0BEB8F != null)
		{
			FC0BEB8F.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		E402C1A8 = new System.Windows.Forms.Panel();
		F590F52F = new System.Windows.Forms.RichTextBox();
		B1291BA6 = new System.Windows.Forms.Label();
		E402C1A8.SuspendLayout();
		SuspendLayout();
		E402C1A8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		E402C1A8.Controls.Add(F590F52F);
		E402C1A8.Controls.Add(B1291BA6);
		E402C1A8.Location = new System.Drawing.Point(0, 0);
		E402C1A8.Margin = new System.Windows.Forms.Padding(4);
		E402C1A8.Name = "panel3";
		E402C1A8.Size = new System.Drawing.Size(350, 163);
		E402C1A8.TabIndex = 31;
		F590F52F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F590F52F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		F590F52F.Location = new System.Drawing.Point(4, 23);
		F590F52F.Name = "txt";
		F590F52F.Size = new System.Drawing.Size(343, 137);
		F590F52F.TabIndex = 32;
		F590F52F.Text = "";
		B1291BA6.AutoSize = true;
		B1291BA6.Location = new System.Drawing.Point(1, 4);
		B1291BA6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		B1291BA6.Name = "lbl";
		B1291BA6.Size = new System.Drawing.Size(41, 16);
		B1291BA6.TabIndex = 0;
		B1291BA6.Text = "Nha\u0303n:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(E402C1A8);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucInputJson";
		base.Size = new System.Drawing.Size(350, 163);
		E402C1A8.ResumeLayout(false);
		E402C1A8.PerformLayout();
		ResumeLayout(false);
	}
}
