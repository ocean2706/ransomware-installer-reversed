using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;
using System.Threading;

[StandardModule]
internal sealed class _________________________
{
	public struct ___________________________
	{
		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)]
		public int _;

		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.U4)]
		public int __;
	}

	public delegate void __________________________();

	public enum ____________________________
	{
		_ = -2147483648,
		__ = 2,
		___ = 1,
		____ = 64
	}

	public static _________________________.___________________________ _ = default(_________________________.___________________________);

	private static bool __ = false;

	[System.Runtime.InteropServices.DllImport("user32.dll")]
	public static extern bool GetLastInputInfo(ref _________________________.___________________________ ____________________________0);

	[System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
	private static extern System.IntPtr CreateWaitableTimer(System.IntPtr intptr_0, bool bool_0, string string_0);

	[System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetWaitableTimer(System.IntPtr intptr_0, [System.Runtime.InteropServices.In] ref long long_0, int int_0, _________________________.__________________________ ___________________________0, System.IntPtr intptr_1, bool bool_0);

	[System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CancelWaitableTimer(System.IntPtr intptr_0);

	public static void _____()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_07:
			int num2 = 2;
			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(_________________________.______));
			IL_1B:
			num2 = 3;
			thread.Start();
			IL_23:
			goto IL_82;
			IL_25:
			int arg_2A_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_2A_0);
			IL_43:
			goto IL_77;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_55:
			goto IL_77;
		}
		object arg_57_0;
		endfilter(arg_57_0 is System.Exception & num != 0 & num3 == 0);
		IL_77:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_82:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ______()
	{
		while (true)
		{
			_________________________.SetThreadExecutionState(-2147483645L);
			_________________________._._ = System.Runtime.InteropServices.Marshal.SizeOf(_________________________._);
			_________________________._.__ = 0;
			_________________________.GetLastInputInfo(ref _________________________._);
			if ((int)System.Math.Round((double)(System.Environment.TickCount - _________________________._.__) / 1000.0) > 600)
			{
				if (!_________________________.__)
				{
					_________________________.________();
					_________________________.__ = true;
				}
			}
			else
			{
				_________________________.__ = false;
			}
			System.Threading.Thread.Sleep(30000);
		}
	}

	[System.Runtime.InteropServices.DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long SetThreadExecutionState(long long_0);

	public static void ________()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_07:
			int num2 = 2;
			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(_________________________._________));
			IL_1B:
			num2 = 3;
			thread.Start();
			IL_23:
			goto IL_82;
			IL_25:
			int arg_2A_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_2A_0);
			IL_43:
			goto IL_77;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_55:
			goto IL_77;
		}
		object arg_57_0;
		endfilter(arg_57_0 is System.Exception & num != 0 & num3 == 0);
		IL_77:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_82:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void _________()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_07:
			int num2 = 2;
			_________________________.SendMessage(-1, 274u, 61808u, 2);
			IL_1A:
			goto IL_75;
			IL_1C:
			int arg_21_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_21_0);
			IL_36:
			goto IL_6A;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_48:
			goto IL_6A;
		}
		object arg_4A_0;
		endfilter(arg_4A_0 is System.Exception & num != 0 & num3 == 0);
		IL_6A:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_75:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void __________()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_07:
			int num2 = 2;
			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(_________________________.___________));
			IL_1B:
			num2 = 3;
			thread.Start();
			IL_23:
			goto IL_82;
			IL_25:
			int arg_2A_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_2A_0);
			IL_43:
			goto IL_77;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_55:
			goto IL_77;
		}
		object arg_57_0;
		endfilter(arg_57_0 is System.Exception & num != 0 & num3 == 0);
		IL_77:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_82:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_07:
			int num2 = 2;
			_________________________.SendMessage(-1, 274u, 61808u, -1);
			IL_1A:
			goto IL_75;
			IL_1C:
			int arg_21_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_21_0);
			IL_36:
			goto IL_6A;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_48:
			goto IL_6A;
		}
		object arg_4A_0;
		endfilter(arg_4A_0 is System.Exception & num != 0 & num3 == 0);
		IL_6A:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_75:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern void SendMessage(int int_0, uint uint_0, uint uint_1, int int_1);
}
