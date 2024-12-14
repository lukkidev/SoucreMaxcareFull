using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucInputCheckbox : GControl0
{
	private IContainer CA323C24 = null;

	private Panel F8BC9F23;

	private Label lbl;

	private CheckBox ckb;

	public ucInputCheckbox()
	{
		InitializeComponent();
	}

	public override void vmethod_0(string D8220D3E)
	{
		base.vmethod_0(D8220D3E);
		D8220D3E = D8220D3E.TrimEnd(':');
		lbl.Text = (D8220D3E.EndsWith("?") ? D8220D3E : (D8220D3E + ":"));
	}

	public override void E71C8ABA(object F48B03B2)
	{
		base.E71C8ABA(F48B03B2);
		try
		{
			ckb.Checked = Convert.ToBoolean(F48B03B2);
		}
		catch (Exception)
		{
		}
	}

	public override void vmethod_1(object D33B5813)
	{
		try
		{
			ckb.Checked = Convert.ToBoolean(D33B5813);
		}
		catch (Exception)
		{
		}
	}

	public override object vmethod_4()
	{
		return ckb.Checked;
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
		return "checkbox";
	}

	private void ucInputCheckbox_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && CA323C24 != null)
		{
			CA323C24.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void InitializeComponent()
	{
		F8BC9F23 = new System.Windows.Forms.Panel();
		ckb = new System.Windows.Forms.CheckBox();
		lbl = new System.Windows.Forms.Label();
		F8BC9F23.SuspendLayout();
		SuspendLayout();
		F8BC9F23.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		F8BC9F23.Controls.Add(ckb);
		F8BC9F23.Controls.Add(lbl);
		F8BC9F23.Location = new System.Drawing.Point(0, 0);
		F8BC9F23.Margin = new System.Windows.Forms.Padding(4);
		F8BC9F23.Name = "panel3";
		F8BC9F23.Size = new System.Drawing.Size(350, 47);
		F8BC9F23.TabIndex = 31;
		ckb.AutoSize = true;
		ckb.Cursor = System.Windows.Forms.Cursors.Hand;
		ckb.Location = new System.Drawing.Point(4, 24);
		ckb.Name = "ckb";
		ckb.Size = new System.Drawing.Size(15, 14);
		ckb.TabIndex = 1;
		ckb.UseVisualStyleBackColor = true;
		lbl.AutoSize = true;
		lbl.Location = new System.Drawing.Point(1, 4);
		lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		lbl.Name = "lbl";
		lbl.Size = new System.Drawing.Size(41, 16);
		lbl.TabIndex = 0;
		lbl.Text = "Nha\u0303n:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(F8BC9F23);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucInputCheckbox";
		base.Size = new System.Drawing.Size(350, 47);
		base.Load += new System.EventHandler(ucInputCheckbox_Load);
		F8BC9F23.ResumeLayout(false);
		F8BC9F23.PerformLayout();
		ResumeLayout(false);
	}
}
