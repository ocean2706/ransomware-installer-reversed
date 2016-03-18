using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public class _____________________________________________________________ : Form
{
	private IContainer _;

	[System.Runtime.CompilerServices.AccessedThroughProperty("l")]
	private Label __;

	[System.Runtime.CompilerServices.AccessedThroughProperty("b")]
	private Button ___;

	internal virtual Label _
	{
		get
		{
			return this.__;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		set
		{
			this.__ = value;
		}
	}

	internal virtual Button __
	{
		get
		{
			return this.___;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		set
		{
			System.EventHandler value2 = new System.EventHandler(this.______);
			if (this.___ != null)
			{
				this.___.Click -= value2;
			}
			this.___ = value;
			if (this.___ != null)
			{
				this.___.Click += value2;
			}
		}
	}

	public _____________________________________________________________()
	{
		this._();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this._ != null)
			{
				this._.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	private void _()
	{
		Padding margin;
		while (true)
		{
			IL_293:
			this._ = new Label();
			this.__ = new Button();
			this.SuspendLayout();
			int arg_269_0 = System.Type.EmptyTypes.Length + 4;
			while (true)
			{
				Point location;
				int num;
				Size size;
				switch (arg_269_0)
				{
				case 0:
				{
					Control arg_251_0 = this.__;
					location = new Point(18, 38);
					arg_251_0.Location = location;
					num = sizeof(float) + -6962;
					goto IL_1BA;
				}
				case 1:
					break;
				case 2:
					goto IL_2B9;
				case 3:
					goto IL_1BA;
				case 4:
					goto IL_189;
				case 5:
				{
					this.__.TabIndex = 1;
					this.__.Text = <Module>.___<string>(2758317222u);
					int num2 = num;
					num = -15706;
					if (num2 != 2848)
					{
						this.__.UseVisualStyleBackColor = true;
						SizeF autoScaleDimensions = new SizeF(9f, 20f);
						this.AutoScaleDimensions = autoScaleDimensions;
						if (num == -6710)
						{
							int ______________;
							if (16726 != ______________ * 10 + 5433 + ______________ * 6)
							{
								goto IL_293;
							}
						}
					}
					this.AutoScaleMode = AutoScaleMode.Font;
					size = new Size(426, 148);
					this.ClientSize = size;
					goto IL_B9;
				}
				case 6:
					goto IL_B9;
				case 7:
				{
					this._.Name = <Module>.____<string>(2567499604u);
					Control arg_30_0 = this._;
					size = new Size(192, 20);
					arg_30_0.Size = size;
					int arg_49_0 = -536870912;
					int ______________ = <Module>._______________;
					if ((arg_49_0 & ______________ % 443397530) == 0)
					{
						if (num == -22051)
						{
							break;
						}
					}
					this._.TabIndex = 0;
					this._.Text = <Module>.____<string>(1419836613u);
					arg_269_0 = System.Type.EmptyTypes.Length + 0;
					continue;
				}
				default:
					goto IL_189;
				}
				IL_86:
				Control arg_99_0 = this._;
				margin = new Padding(4, 0, 4, 0);
				arg_99_0.Margin = margin;
				num = System.Type.EmptyTypes.Length + 21781;
				arg_269_0 = System.Type.EmptyTypes.Length + 7;
				continue;
				IL_1BA:
				Control arg_1CD_0 = this.__;
				margin = new Padding(4, 5, 4, 5);
				arg_1CD_0.Margin = margin;
				if (num == -22110)
				{
					int _________ = <Module>.__________;
					if (-(_________ * 1879048192) != -812169384)
					{
						goto IL_86;
					}
				}
				this.__.Name = <Module>.____<string>(3878451389u);
				Control arg_221_0 = this.__;
				size = new Size(390, 98);
				arg_221_0.Size = size;
				num = System.Type.EmptyTypes.Length + 21981;
				arg_269_0 = sizeof(float) + 1;
				continue;
				IL_B9:
				this.Controls.Add(this.__);
				this.Controls.Add(this._);
				arg_269_0 = sizeof(int) + -2;
				continue;
				IL_189:
				this._.AutoSize = true;
				Control arg_1A8_0 = this._;
				location = new Point(120, 12);
				arg_1A8_0.Location = location;
				arg_269_0 = sizeof(byte) + 0;
			}
		}
		IL_2B9:
		this.FormBorderStyle = FormBorderStyle.FixedDialog;
		margin = new Padding(4, 5, 4, 5);
		this.Margin = margin;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = <Module>.___<string>(1346864658u);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void ______(object sender, System.EventArgs e)
	{
		_____________________________________________________________________________.____________();
	}
}
