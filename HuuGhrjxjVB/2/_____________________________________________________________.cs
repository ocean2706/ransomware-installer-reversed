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

	[AccessedThroughProperty("l")]
	private Label __;

	[AccessedThroughProperty("b")]
	private Button ___;

	internal virtual Label _
	{
		get
		{
			return this.__;
		}
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
		set
		{
			_____________________________________________________________ _______________________________ = this;
			EventHandler eventHandler = new EventHandler(_______________________________.______);
			if (this.___ != null)
			{
				this.___.Click -= eventHandler;
			}
			this.___ = value;
			if (this.___ != null)
			{
				this.___.Click += eventHandler;
			}
		}
	}

	public _____________________________________________________________()
	{
		this._();
	}

	private void _()
	{
		System.Drawing.Size size;
		int length = 0;
		Point point;
		System.Windows.Forms.Padding padding;
		int ________ = 0;
	Label0:
		this._ = new Label();
		this.__ = new Button();
		this.SuspendLayout();
		object obj = Type.EmptyTypes.Length + 4;
		while (true)
		{
			switch (obj)
			{
				case 0:
				{
					Button button = this.__;
					point = new Point(18, 38);
					button.Location = point;
					length = (int)(sizeof(float) + -6962);
					goto case 3;
				}
				case 1:
				{
					Label label = this._;
					padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
					label.Margin = padding;
					length = Type.EmptyTypes.Length + 21781;
					obj = Type.EmptyTypes.Length + 7;
					continue;
				}
				case 2:
				{
					break;
				}
				case 3:
				{
					Button button1 = this.__;
					padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
					button1.Margin = padding;
					if (length == -22110)
					{
						if (-(<Module>.__________ * 1879048192) != -812169384)
						{
							goto case 1;
						}
					}
					this.__.Name = <Module>.____<string>(-416515907);
					Button button2 = this.__;
					size = new System.Drawing.Size(390, 98);
					button2.Size = size;
					length = Type.EmptyTypes.Length + 21981;
					obj = sizeof(float) + 1;
					continue;
				}
				case 4:
				{
					this._.AutoSize = true;
					Label label1 = this._;
					point = new Point(120, 12);
					label1.Location = point;
					obj = sizeof(byte) + 0;
					continue;
				}
				case 5:
				{
					this.__.TabIndex = 1;
					this.__.Text = <Module>.___<string>(-1536650074);
					int num = length;
					length = -15706;
					if (num != 2848)
					{
						this.__.UseVisualStyleBackColor = true;
						this.AutoScaleDimensions = new SizeF(9f, 20f);
						if (length == -6710)
						{
							if (16726 != ________ * 10 + 5433 + ________ * 6)
							{
								goto Label0;
							}
						}
					}
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					size = new System.Drawing.Size(426, 148);
					this.ClientSize = size;
					goto case 6;
				}
				case 6:
				{
					this.Controls.Add(this.__);
					this.Controls.Add(this._);
					obj = sizeof(int) + -2;
					continue;
				}
				case 7:
				{
					this._.Name = <Module>.____<string>(-1727467692);
					Label label2 = this._;
					size = new System.Drawing.Size(192, 20);
					label2.Size = size;
					________ = <Module>._______________;
					if ((-536870912 & ________ % 443397530) == 0)
					{
						if (length == -22051)
						{
							goto case 1;
						}
					}
					this._.TabIndex = 0;
					this._.Text = <Module>.____<string>(1419836613);
					obj = Type.EmptyTypes.Length + 0;
					continue;
				}
				default:
				{
					goto case 4;
				}
			}
		}
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
		padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
		this.Margin = padding;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = <Module>.___<string>(1346864658);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void ______(object sender, EventArgs e)
	{
		_____________________________________________________________________________.____________();
	}

	protected override void System.Windows.Forms.Form.Dispose(bool disposing)
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
}