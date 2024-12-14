using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ucInputFilePath : GControl0
{
	private IContainer icontainer_1 = null;

	private Panel DD0ACC9E;

	private Label D226D330;

	private TextBox txt;

	private Button button1;

	public ucInputFilePath()
	{
		F92733B5();
	}

	public override void vmethod_0(string D8220D3E)
	{
		base.vmethod_0(D8220D3E);
		D226D330.Text = D8220D3E.TrimEnd(':') + ":";
	}

	public override void E71C8ABA(object F48B03B2)
	{
		base.E71C8ABA(F48B03B2);
		txt.Text = Convert.ToString(F48B03B2);
	}

	public override void vmethod_1(object A68A0A0F)
	{
		txt.Text = Convert.ToString(A68A0A0F);
	}

	public override object vmethod_4()
	{
		return txt.Text;
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
		return "filepath";
	}

	private void B0287208(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		string value = GClass8.AD2D2BA4("Select file", "Custom Files (*.txt,*.xlsx)|*.txt;*.xlsx|");
		if (!string.IsNullOrEmpty(value))
		{
			txt.Text = value;
		}
	}

	protected override void Dispose(bool E99A6AA0)
	{
		if (E99A6AA0 && icontainer_1 != null)
		{
			icontainer_1.Dispose();
		}
		base.Dispose(E99A6AA0);
	}

	private void F92733B5()
	{
		DD0ACC9E = new Panel();
		D226D330 = new Label();
		txt = new TextBox();
		button1 = new Button();
		DD0ACC9E.SuspendLayout();
		SuspendLayout();
		DD0ACC9E.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		DD0ACC9E.Controls.Add(button1);
		DD0ACC9E.Controls.Add(D226D330);
		DD0ACC9E.Controls.Add(txt);
		DD0ACC9E.Location = new Point(0, 0);
		DD0ACC9E.Margin = new Padding(4);
		DD0ACC9E.Name = "panel3";
		DD0ACC9E.Size = new Size(350, 53);
		DD0ACC9E.TabIndex = 31;
		D226D330.AutoSize = true;
		D226D330.Location = new Point(1, 4);
		D226D330.Margin = new Padding(4, 0, 4, 0);
		D226D330.Name = "lbl";
		D226D330.Size = new Size(41, 16);
		D226D330.TabIndex = 0;
		D226D330.Text = "Nha\u0303n:";
		txt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		txt.Location = new Point(4, 24);
		txt.Margin = new Padding(4);
		txt.Name = "txt";
		txt.Size = new Size(305, 23);
		txt.TabIndex = 2;
		button1.Cursor = Cursors.Hand;
		button1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		button1.Location = new Point(316, 23);
		button1.Name = "button1";
		button1.Size = new Size(29, 25);
		button1.TabIndex = 3;
		button1.Text = "...";
		button1.UseVisualStyleBackColor = true;
		button1.Click += button1_Click;
		base.AutoScaleDimensions = new SizeF(7f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(DD0ACC9E);
		Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.Margin = new Padding(4);
		base.Name = "ucInputFilePath";
		base.Size = new Size(350, 53);
		base.Load += B0287208;
		DD0ACC9E.ResumeLayout(performLayout: false);
		DD0ACC9E.PerformLayout();
		ResumeLayout(performLayout: false);
	}
}
