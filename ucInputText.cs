using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucInputText : GControl0
{
	private IContainer icontainer_1 = null;

	private Panel panel3;

	private Label lbl;

	private TextBox EA2A6A92;

	public ucInputText()
	{
		E89D121A();
	}

	public override void vmethod_0(string D8220D3E)
	{
		base.vmethod_0(D8220D3E);
		lbl.Text = D8220D3E.TrimEnd(':') + ":";
	}

	public override void E71C8ABA(object F48B03B2)
	{
		base.E71C8ABA(F48B03B2);
		EA2A6A92.Text = Convert.ToString(F48B03B2);
	}

	public override void vmethod_1(object D33B5813)
	{
		EA2A6A92.Text = Convert.ToString(D33B5813);
	}

	public override object vmethod_4()
	{
		return EA2A6A92.Text;
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
		return "string";
	}

	private void ucInputText_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool B803E003)
	{
		if (B803E003 && icontainer_1 != null)
		{
			icontainer_1.Dispose();
		}
		base.Dispose(B803E003);
	}

	private void E89D121A()
	{
		panel3 = new Panel();
		lbl = new Label();
		EA2A6A92 = new TextBox();
		panel3.SuspendLayout();
		SuspendLayout();
		panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel3.Controls.Add(lbl);
		panel3.Controls.Add(EA2A6A92);
		panel3.Location = new Point(0, 0);
		panel3.Margin = new Padding(4);
		panel3.Name = "panel3";
		panel3.Size = new Size(350, 53);
		panel3.TabIndex = 31;
		lbl.AutoSize = true;
		lbl.Location = new Point(1, 4);
		lbl.Margin = new Padding(4, 0, 4, 0);
		lbl.Name = "lbl";
		lbl.Size = new Size(41, 16);
		lbl.TabIndex = 0;
		lbl.Text = "Nha\u0303n:";
		EA2A6A92.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		EA2A6A92.Location = new Point(4, 24);
		EA2A6A92.Margin = new Padding(4);
		EA2A6A92.Name = "txt";
		EA2A6A92.Size = new Size(342, 23);
		EA2A6A92.TabIndex = 2;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(panel3);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Margin = new Padding(4);
		base.Name = "ucInputText";
		base.Size = new Size(350, 53);
		base.Load += ucInputText_Load;
		panel3.ResumeLayout(performLayout: false);
		panel3.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
