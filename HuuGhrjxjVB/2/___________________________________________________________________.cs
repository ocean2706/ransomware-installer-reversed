using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

[StandardModule]
internal sealed class ___________________________________________________________________
{
	public static string _(string string_0, string string_1 = "")
	{
		string str = null;
		byte[] numArray = null;
		int length;
		int num;
		int length1;
		string __________ = ______________________________________________________________.__________________;
		string string1 = string_1;
		int _______ = <Module>.B;
		if ((8388608 & (_______ * 8388608 + -8858 ^ ~_______ << 23)) == 0)
		{
			length = Type.EmptyTypes.Length + 3099;
		}
		else
		{
			length = (_______ % 1708 == 1721556701 ? Type.EmptyTypes.Length + 1673567021 : (int)(sizeof(Guid) + 1290060372));
		}
		if (Operators.CompareString(string1, <Module>.__________(length, Type.EmptyTypes.Length + 2760, Type.EmptyTypes.Length + 110), false) != 0)
		{
			__________ = string_1;
		}
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		int num1 = Type.EmptyTypes.Length + 3207;
		num = ((_______ << 24) + -301989888 == _______ << 24 ? 1798868283 : checked((int)2879));
		if ((_______ >> 9 & 8388608) != (_______ - (_______ - 3954) << 23 & 8388608))
		{
			length1 = Type.EmptyTypes.Length + -2125133704;
		}
		else if ((-47 | 128 * _______ - 6455) != -39)
		{
			length1 = -1678629619;
		}
		else if ((18544 * _______ & 3) == 0)
		{
			length1 = (~(_______ - (_______ + -3741 | _______)) == _______ - -41 ? -2077553378 : checked((int)219));
		}
		else
		{
			length1 = 1891066686;
		}
		string str1 = <Module>.__________(num1, num, length1);
		try
		{
			int _______1 = <Module>.C;
			if ((-1713953234 ^ (_______1 << 20 & _______1) + 7089) != 1965)
			{
				numArray = new byte[32];
				byte[] numArray1 = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(__________));
				object obj = Type.EmptyTypes.Length + 1;
				while (true)
				{
					switch (obj)
					{
						case 0:
						{
							break;
						}
						case 1:
						{
							Array.Copy(numArray1, 0, numArray, 0, 16);
							Array.Copy(numArray1, 0, numArray, 15, 16);
							obj = sizeof(uint) + -4;
							continue;
						}
						default:
						{
							goto case 1;
						}
					}
				}
			}
			rijndaelManaged.Key = numArray;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			<Module>.___ = null;
			byte[] numArray2 = Convert.FromBase64String(string_0);
			str1 = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(numArray2, 0, checked((int)numArray2.Length)));
			<Module>._______ = 1818084011;
			str = str1;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return str;
	}

	public static string __(string string_0)
	{
		string str = null;
		int num = 0;
		int num1 = 0;
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string base64String = <Module>.__________((int)(sizeof(byte) + 66008), (int)(sizeof(uint) + 66740), Type.EmptyTypes.Length + 251);
		try
		{
			(1 & ~num1 >> 3) == (6127 + num1 / 8 & 1);
			byte[] numArray = new byte[32];
			byte[] numArray1 = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
			object length = sizeof(short) + -2;
			while (true)
			{
				switch (length)
				{
					case 0:
					{
						while (true)
						{
							Array.Copy(numArray1, 0, numArray, 0, 16);
							Array.Copy(numArray1, 0, numArray, 15, 16);
							if (-1249902593 != <Module>._________________ / 29)
							{
								break;
							}
							((6 * num + num * 2 ^ -893582246 | num - 8794) & 2) != 2;
						}
						length = Type.EmptyTypes.Length + 1;
						continue;
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
			rijndaelManaged.Key = numArray;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			base64String = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, checked((int)bytes.Length)));
			str = base64String;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return str;
	}

	public static string ___(string string_0)
	{
		string str = null;
		int num = 0;
		byte[] numArray = null;
		object length;
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string str1 = <Module>.__________(Type.EmptyTypes.Length + 50374, 49600, (int)(sizeof(ushort) + 244));
		try
		{
			if (((-(47 * num + 17 * num) + num ^ num & 4965) & 32) == 0)
			{
				numArray = new byte[32];
				byte[] numArray1 = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
				if ((75 * num + num * 53 | -61) != -61)
				{
					length = Type.EmptyTypes.Length + 1814130466;
				}
				else
				{
					length = sizeof(long) + -7;
				}
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
							Array.Copy(numArray1, 0, numArray, 0, 16);
							Array.Copy(numArray1, 0, numArray, 15, 16);
							length = sizeof(byte) + -1;
							continue;
						}
						default:
						{
							goto case 1;
						}
					}
				}
			}
			rijndaelManaged.Key = numArray;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] numArray2 = Convert.FromBase64String(string_0);
			<Module>._________ = null;
			str1 = Encoding.Unicode.GetString(cryptoTransform.TransformFinalBlock(numArray2, 0, checked((int)numArray2.Length)));
			str = str1;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return str;
	}

	public static string ____(string string_0)
	{
		string str = null;
		byte[] numArray;
		byte[] numArray1;
		int num = 0;
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string base64String = <Module>.__________(Type.EmptyTypes.Length + 28746, 30513, Type.EmptyTypes.Length + 162);
		try
		{
			do
			{
				numArray1 = new byte[32];
				numArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
			}
			while ((945 ^ <Module>._________________ / 17698076) + 1543503872 == 32 * (num % 2));
			Array.Copy(numArray, 0, numArray1, 0, 16);
			Array.Copy(numArray, 0, numArray1, 15, 16);
			switch (Type.EmptyTypes.Length)
			{
				default:
				{
					rijndaelManaged.Key = numArray1;
					rijndaelManaged.Mode = CipherMode.ECB;
					ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
					byte[] bytes = Encoding.ASCII.GetBytes(string_0);
					base64String = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, checked((int)bytes.Length)));
					str = base64String;
					break;
				}
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return str;
	}

	public static string _____(byte[] byte_0)
	{
		unsafe
		{
			int num = 0;
			int num1 = 0;
			string str = null;
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			string base64String = <Module>.__________(checked((int)55054), Type.EmptyTypes.Length + 57362, (int)(sizeof(double) + 3));
			try
			{
				byte[] numArray = new byte[32];
				byte[] numArray1 = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
				object length = sizeof(ulong) + -8;
				while (true)
				{
					switch (length)
					{
						case 0:
						{
							Array.Copy(numArray1, 0, numArray, 0, 16);
							Array.Copy(numArray1, 0, numArray, 15, 16);
							if ((7679 | num1 / 1024 / 64281073) == 7679)
							{
								length = Type.EmptyTypes.Length + 1;
								continue;
							}
							else if (num / 452375622 + 3605 != -1817526503)
							{
								length = Type.EmptyTypes.Length + 107451157;
								continue;
							}
							else
							{
								length = Type.EmptyTypes.Length + 1161485371;
								continue;
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
				rijndaelManaged.Key = numArray;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				byte[] byte0 = byte_0;
				base64String = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(byte0, 0, checked((int)byte0.Length)));
				str = base64String;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			return str;
		}
	}

	public static bool ______()
	{
		unsafe
		{
			string str = null;
			bool isAttached = false;
			int num = 0;
			ManagementObjectCollection.ManagementObjectEnumerator enumerator = null;
			int _______ = 0;
			int length;
			try
			{
				if (!File.Exists(string.Concat(Path.GetTempPath(), <Module>._______<string>(-1835808738))))
				{
					ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(<Module>.____<string>(795934529), <Module>.______<string>(-425241335));
					using (string empty = string.Empty)
					{
						enumerator = managementObjectSearcher.Get().GetEnumerator();
					Label1:
						<Module>._______ = 1957620381;
						if (enumerator.MoveNext())
						{
							ManagementObject current = (ManagementObject)enumerator.Current;
							int num1 = 14777;
							empty = Convert.ToString(RuntimeHelpers.GetObjectValue(current[<Module>._____<string>(1814773821)]));
							num1 = (int)(sizeof(Guid) + -30525);
							object obj = Type.EmptyTypes.Length + 2;
							while (true)
							{
								switch (obj)
								{
									case 0:
									{
										if (str.Contains(<Module>.___<string>(85258705)))
										{
											isAttached = true;
											return isAttached;
										}
										else if (str.Contains(<Module>.______<string>(1023570339)))
										{
											isAttached = true;
											return isAttached;
										}
										else
										{
											obj = checked((int)5);
											continue;
										}
									}
									case 1:
									{
										return isAttached;
									}
									case 2:
									{
										while (true)
										{
											str = Strings.StrConv(empty, VbStrConv.Lowercase, 0);
											if (str.Contains(<Module>._____<string>(2076862217)))
											{
												isAttached = true;
												return isAttached;
											}
											if (6 * num1 + num1 * 2 == 5001)
											{
												break;
											}
											else if (num1 != -18181)
											{
												break;
											}
										}
										if (str.Contains(<Module>._____<string>(-942719310)))
										{
											isAttached = true;
											return isAttached;
										}
										else if (str.Contains(<Module>.______<string>(1704528494)))
										{
											isAttached = true;
											if (_______ / 316779108 != 1996039184)
											{
												return isAttached;
											}
											obj = Type.EmptyTypes.Length + -2054006470;
											continue;
										}
										else
										{
											_______ = <Module>.C;
											if ((67108864 & (-1736441856 * _______ ^ 8388608 * _______)) != 0)
											{
												length = Type.EmptyTypes.Length + -1990278693;
											}
											else if (num1 % 707 == -3776)
											{
												length = (-9330688 + (num + num >> 1) != num ? Type.EmptyTypes.Length + 1188331054 : Type.EmptyTypes.Length + -1992123313);
											}
											else
											{
												length = Type.EmptyTypes.Length + -6995;
											}
											num1 = length;
											obj = Type.EmptyTypes.Length + 3;
											continue;
										}
									}
									case 3:
									{
										if (str.Contains(<Module>.______<string>(-1269973243)))
										{
											isAttached = true;
											return isAttached;
										}
										else if (str.Contains(<Module>.___<string>(-1971310537)))
										{
											isAttached = true;
											return isAttached;
										}
										else
										{
											if (num1 == -1628)
											{
												goto Label1;
											}
											if (str.Contains(<Module>._____<string>(1720640825)))
											{
												isAttached = true;
												return isAttached;
											}
											else if (str.Contains(<Module>.____<string>(-881048146)))
											{
												isAttached = true;
												return isAttached;
											}
											else if ((_______ + 15 * _______ ^ -8421) == 0)
											{
												obj = sizeof(short) + -1159374780;
												continue;
											}
											else
											{
												obj = sizeof(short) + -2;
												continue;
											}
										}
									}
									case 4:
									{
										break;
									}
									case 5:
									{
										goto Label1;
									}
									default:
									{
										goto case 2;
									}
								}
							}
							isAttached = true;
							return isAttached;
						}
					}
					isAttached = Debugger.IsAttached;
				}
				else
				{
					isAttached = false;
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				isAttached = false;
				ProjectData.ClearProjectError();
			}
			return isAttached;
		}
	}

	public static byte[] _______(byte[] byte_0, string string_0 = "")
	{
		byte[] bytes = null;
		uint num = 0;
		uint[] numArray = null;
		byte[] numArray1 = null;
		int length = 0;
		int length1 = 0;
		int num1 = 0;
		byte[] byte0 = null;
		uint num2 = 0;
		uint num3 = 0;
		int num4;
		object obj;
		try
		{
		Label3:
			string __________ = ______________________________________________________________.__________________;
			string string0 = string_0;
			int length2 = Type.EmptyTypes.Length + 33389;
			num4 = ((length1 + length1 * 7 ^ -6041) == 0 ? (int)(sizeof(double) + -1384965803) : Type.EmptyTypes.Length + 33880);
			int num5 = 78;
			if (Operators.CompareString(string0, <Module>.__________(length2, num4, 78), false) == 0)
			{
				goto Label0;
			}
			obj = sizeof(short) + -2;
		Label8:
			while (true)
			{
			Label9:
				switch (obj)
				{
					case 1:
					{
						length1 = checked((int)byte0.Length) - 1;
						num1 = 0;
						int num6 = A.i0;
						if (((num6 ^ num6 << 7 >> 7) & 10927280) == 0)
						{
							if (length == -17638)
							{
								goto Label5;
							}
							goto Label3;
						}
						else
						{
							goto Label3;
						}
					}
					case 2:
					{
						num = (uint)((ulong)(num + numArray[num2]) & 255L);
						obj = Type.EmptyTypes.Length + 6;
						continue;
					}
					case 3:
					{
						goto Label1;
					}
					case 4:
					{
						while (true)
						{
							num3 = numArray[num2];
							numArray[num2] = numArray[num];
							if (length == 10107)
							{
								break;
							}
						}
						numArray[num] = num3;
						num2++;
						if ((num3 * 307757056 | 1407) - 16441344 == -(9424 & num3) << 11)
						{
							if ((5854 + num5 * -1241513984 | -7609) == -2337)
							{
								goto Label6;
							}
							obj = Type.EmptyTypes.Length + -1032371424;
							continue;
						}
						else
						{
							obj = Type.EmptyTypes.Length + 5;
							continue;
						}
					}
					case 5:
					{
						if (num2 <= 255)
						{
							break;
						}
						num2 = 0;
						num = 0;
						int ________ = <Module>._______________;
						length = ((1 & -(________ * 2 + ________ * 2) - -349) == 1 ? -17638 : Type.EmptyTypes.Length + -438041807);
						if ((4386 ^ (______________________._______ << 11) - 6079) != 0)
						{
							obj = Type.EmptyTypes.Length + 1;
							continue;
						}
						else
						{
							obj = Type.EmptyTypes.Length + 1478133092;
							continue;
						}
					}
					case 6:
					{
						num3 = numArray[num2];
						numArray[num2] = numArray[num];
						if ((4335 ^ <Module>.__________ * 15682) == 0)
						{
							goto Label6;
						}
						obj = Type.EmptyTypes.Length + 8;
						continue;
					}
					case 7:
					{
						if (num2 <= 255)
						{
							goto Label2;
						}
						bytes = Encoding.UTF8.GetBytes(__________);
						if (length != -32656)
						{
							goto case 1;
						}
						num2 = 0;
						break;
					}
					case 8:
					{
						numArray[num] = num3;
						byte0[num1] = (byte)(byte_0[num1] ^ numArray[(int)((ulong)(numArray[num2] + numArray[num]) & 255L)]);
						num1++;
						goto Label5;
					}
					default:
					{
						goto Label6;
					}
				}
				num = (uint)((ulong)(num + bytes[(int)((ulong)num2 % (long)(checked((int)bytes.Length)))] + numArray[num2]) & 255L);
				length = Type.EmptyTypes.Length + 10107;
				obj = Type.EmptyTypes.Length + 4;
			}
		Label6:
			__________ = string_0;
		Label0:
			numArray = new uint[256];
			byte0 = new byte[checked((int)byte_0.Length) - 1 + 1];
		Label1:
			num2 = 0;
		Label2:
			numArray[num2] = num2;
			num2++;
			length = Type.EmptyTypes.Length + -32656;
			obj = Type.EmptyTypes.Length + 7;
			goto Label8;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return numArray1;
	Label5:
		if (num1 > length1)
		{
			numArray1 = byte0;
			return numArray1;
		}
		else
		{
			num2 = (uint)((ulong)num2 + 1L & 255L);
			obj = sizeof(double) + -6;
			goto Label9;
		}
	}

	public static bool ________()
	{
		bool flag;
		try
		{
			flag = (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			flag = false;
			ProjectData.ClearProjectError();
		}
		return flag;
	}

	public static object _________()
	{
		object obj;
		try
		{
			obj = (Operators.CompareString(SystemInformation.PowerStatus.BatteryChargeStatus.ToString(), <Module>._____<string>(-743323372), false) != 0 ? <Module>._____<string>(-924263709) : <Module>._____<string>(943744901));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			obj = <Module>._______<string>(-1908632787);
			ProjectData.ClearProjectError();
		}
		return obj;
	}
}