using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucInputNumber : GControl0
{
	private IContainer icontainer_1 = null;

	private Panel panel3;

	private Label lbl;

	private NumericUpDown nud;

	public ucInputNumber()
	{
		InitializeComponent();
	}

	public override void vmethod_0(string D8220D3E)
	{
		base.vmethod_0(D8220D3E);
		lbl.Text = D8220D3E.TrimEnd(':') + ":";
	}

	public override void E71C8ABA(object BD15139F)
	{
		base.E71C8ABA(BD15139F);
		try
		{
			nud.Value = Convert.ToInt32(method_2());
		}
		catch (Exception)
		{
		}
	}

	public override void vmethod_1(object D33B5813)
	{
		try
		{
			nud.Value = Convert.ToInt32(D33B5813);
		}
		catch (Exception)
		{
		}
	}

	public override object vmethod_4()
	{
		return Convert.ToInt32(nud.Value);
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
		return "number";
	}

	protected override void Dispose(bool D88C34B7)
	{
		if (D88C34B7 && icontainer_1 != null)
		{
			icontainer_1.Dispose();
		}
		base.Dispose(D88C34B7);
	}

	private void InitializeComponent()
	{
		panel3 = new System.Windows.Forms.Panel();
		nud = new System.Windows.Forms.NumericUpDown();
		lbl = new System.Windows.Forms.Label();
		panel3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)nud).BeginInit();
		SuspendLayout();
		panel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		panel3.Controls.Add(nud);
		panel3.Controls.Add(lbl);
		panel3.Location = new System.Drawing.Point(0, 0);
		panel3.Margin = new System.Windows.Forms.Padding(4);
		panel3.Name = "panel3";
		panel3.Size = new System.Drawing.Size(350, 53);
		panel3.TabIndex = 31;
		nud.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		nud.Location = new System.Drawing.Point(4, 24);
		nud.Maximum = new decimal(new int[4] { 99999, 0, 0, 0 });
		nud.Name = "nud";
		nud.Size = new System.Drawing.Size(342, 23);
		nud.TabIndex = 2;
		lbl.AutoSize = true;
		lbl.Location = new System.Drawing.Point(1, 4);
		lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
		lbl.Name = "lbl";
		lbl.Size = new System.Drawing.Size(41, 16);
		lbl.TabIndex = 0;
		lbl.Text = "Nha\u0303n:";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(panel3);
		Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "ucInputNumber";
		base.Size = new System.Drawing.Size(350, 53);
		panel3.ResumeLayout(false);
		panel3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)nud).EndInit();
		ResumeLayout(false);
	}
}
