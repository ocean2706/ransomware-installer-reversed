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
		string s = ______________________________________________________________.__________________;
		int arg_29_0 = 8388608;
		int ___________ = <Module>.____________;
		if (Operators.CompareString(string_1, <Module>.__________(((arg_29_0 & (___________ * 8388608 + -8858 ^ ~___________ << 23)) == 0) ? (System.Type.EmptyTypes.Length + 3099) : ((___________ % 1708 == 1721556701) ? (System.Type.EmptyTypes.Length + 1673567021) : (sizeof(System.Guid) + 1290060372)), System.Type.EmptyTypes.Length + 2760, System.Type.EmptyTypes.Length + 110), false) != 0)
		{
			s = string_1;
		}
		System.Security.Cryptography.RijndaelManaged rijndaelManaged = new System.Security.Cryptography.RijndaelManaged();
		System.Security.Cryptography.MD5CryptoServiceProvider mD5CryptoServiceProvider = new System.Security.Cryptography.MD5CryptoServiceProvider();
		string text = <Module>.__________(System.Type.EmptyTypes.Length + 3207, ((___________ << 24) + -301989888 == ___________ << 24) ? 1798868283 : checked((int)2879.0), (((uint)___________ >> 9 & 8388608u) == (uint)(___________ - (___________ - 3954) << 23 & 8388608)) ? (((-47 | 128 * ___________ - 6455) != -39) ? -1678629619 : (((18544 * ___________ & 3) == 0) ? ((~(___________ - (___________ + -3741 | ___________)) == ___________ - -41) ? -2077553378 : checked((int)219.0)) : 1891066686)) : (System.Type.EmptyTypes.Length + -2125133704));
		string result;
		try
		{
			int arg_16D_0 = -1713953234;
			int ____________ = <Module>._____________;
			byte[] array;
			if ((arg_16D_0 ^ (____________ << 20 & ____________) + 7089) != 1965)
			{
				array = new byte[32];
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(s));
				int arg_1C0_0 = System.Type.EmptyTypes.Length + 1;
				while (true)
				{
					switch (arg_1C0_0)
					{
					case 0:
						goto IL_1CF;
					}
					System.Array.Copy(sourceArray, 0, array, 0, 16);
					System.Array.Copy(sourceArray, 0, array, 15, 16);
					arg_1C0_0 = sizeof(uint) + -4;
				}
			}
			IL_1CF:
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = System.Security.Cryptography.CipherMode.ECB;
			System.Security.Cryptography.ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			<Module>.___ = null;
			byte[] array2 = System.Convert.FromBase64String(string_0);
			text = System.Text.Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			string arg_21D_0 = text;
			<Module>._______ = 1818084011;
			result = arg_21D_0;
		}
		catch (System.Exception expr_221)
		{
			ProjectData.SetProjectError(expr_221);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string __(string string_0)
	{
		System.Security.Cryptography.RijndaelManaged rijndaelManaged = new System.Security.Cryptography.RijndaelManaged();
		System.Security.Cryptography.MD5CryptoServiceProvider mD5CryptoServiceProvider = new System.Security.Cryptography.MD5CryptoServiceProvider();
		string text = <Module>.__________(sizeof(byte) + 66008, sizeof(uint) + 66740, System.Type.EmptyTypes.Length + 251);
		string result;
		try
		{
			int num;
			if ((1u & (uint)(~(uint)num) >> 3) != (uint)(6127 + num / 8 & 1))
			{
			}
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
			int arg_D4_0 = sizeof(short) + -2;
			while (true)
			{
				switch (arg_D4_0)
				{
				case 1:
					goto IL_E3;
				}
				System.Array.Copy(sourceArray, 0, array, 0, 16);
				System.Array.Copy(sourceArray, 0, array, 15, 16);
				int ________________ = <Module>._________________;
				int num2;
				arg_D4_0 = ((-1249902593 != ________________ / 29) ? (System.Type.EmptyTypes.Length + 1) : (((((6 * num2 + num2 * 2 ^ -893582246) | num2 - 8794) & 2) != 2) ? 1125071153 : 2090468250));
			}
			IL_E3:
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = System.Security.Cryptography.CipherMode.ECB;
			System.Security.Cryptography.ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] bytes = System.Text.Encoding.Unicode.GetBytes(string_0);
			text = System.Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
			result = text;
		}
		catch (System.Exception expr_121)
		{
			ProjectData.SetProjectError(expr_121);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string ___(string string_0)
	{
		System.Security.Cryptography.RijndaelManaged rijndaelManaged = new System.Security.Cryptography.RijndaelManaged();
		System.Security.Cryptography.MD5CryptoServiceProvider mD5CryptoServiceProvider = new System.Security.Cryptography.MD5CryptoServiceProvider();
		string text = <Module>.__________(System.Type.EmptyTypes.Length + 50374, 49600, sizeof(ushort) + 244);
		string result;
		try
		{
			int num;
			byte[] array;
			if (((-(47 * num + 17 * num) + num ^ (num & 4965)) & 32) == 0)
			{
				array = new byte[32];
				byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
				int arg_BE_0 = ((75 * num + num * 53 | -61) != -61) ? (System.Type.EmptyTypes.Length + 1814130466) : (sizeof(long) + -7);
				while (true)
				{
					switch (arg_BE_0)
					{
					case 0:
						goto IL_CD;
					}
					System.Array.Copy(sourceArray, 0, array, 0, 16);
					System.Array.Copy(sourceArray, 0, array, 15, 16);
					arg_BE_0 = sizeof(byte) + -1;
				}
			}
			IL_CD:
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = System.Security.Cryptography.CipherMode.ECB;
			System.Security.Cryptography.ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = System.Convert.FromBase64String(string_0);
			string arg_10A_0 = System.Text.Encoding.Unicode.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			<Module>._________ = null;
			text = arg_10A_0;
			result = text;
		}
		catch (System.Exception expr_112)
		{
			ProjectData.SetProjectError(expr_112);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string ____(string string_0)
	{
		System.Security.Cryptography.RijndaelManaged rijndaelManaged = new System.Security.Cryptography.RijndaelManaged();
		System.Security.Cryptography.MD5CryptoServiceProvider mD5CryptoServiceProvider = new System.Security.Cryptography.MD5CryptoServiceProvider();
		string text = <Module>.__________(System.Type.EmptyTypes.Length + 28746, 30513, System.Type.EmptyTypes.Length + 162);
		string result;
		try
		{
			byte[] array;
			byte[] sourceArray;
			int arg_65_0;
			int ________________;
			int num;
			do
			{
				array = new byte[32];
				sourceArray = mD5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
				arg_65_0 = 945;
				________________ = <Module>._________________;
			}
			while ((arg_65_0 ^ ________________ / 17698076) + 1543503872 == 32 * (num % 2));
			System.Array.Copy(sourceArray, 0, array, 0, 16);
			System.Array.Copy(sourceArray, 0, array, 15, 16);
			switch (System.Type.EmptyTypes.Length + 0)
			{
			case 0:
			{
				IL_A1:
				rijndaelManaged.Key = array;
				rijndaelManaged.Mode = System.Security.Cryptography.CipherMode.ECB;
				System.Security.Cryptography.ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				byte[] bytes = System.Text.Encoding.ASCII.GetBytes(string_0);
				text = System.Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
				result = text;
				return result;
			}
			}
			goto IL_A1;
		}
		catch (System.Exception expr_DF)
		{
			ProjectData.SetProjectError(expr_DF);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string _____(byte[] byte_0)
	{
		System.Security.Cryptography.RijndaelManaged rijndaelManaged = new System.Security.Cryptography.RijndaelManaged();
		System.Security.Cryptography.MD5CryptoServiceProvider mD5CryptoServiceProvider = new System.Security.Cryptography.MD5CryptoServiceProvider();
		string text = <Module>.__________(checked((int)(unchecked((System.IntPtr)55054))), System.Type.EmptyTypes.Length + 57362, sizeof(double) + 3);
		string result;
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(System.Text.Encoding.ASCII.GetBytes(______________________________________________________________.__________________));
			int arg_C8_0 = sizeof(ulong) + -8;
			while (true)
			{
				switch (arg_C8_0)
				{
				case 1:
					goto IL_D7;
				}
				System.Array.Copy(sourceArray, 0, array, 0, 16);
				System.Array.Copy(sourceArray, 0, array, 15, 16);
				int num;
				int num2;
				arg_C8_0 = (((7679 | num / 1024 / 64281073) != 7679) ? ((num2 / 452375622 + 3605 != -1817526503) ? (System.Type.EmptyTypes.Length + 107451157) : (System.Type.EmptyTypes.Length + 1161485371)) : (System.Type.EmptyTypes.Length + 1));
			}
			IL_D7:
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = System.Security.Cryptography.CipherMode.ECB;
			System.Security.Cryptography.ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			text = System.Convert.ToBase64String(cryptoTransform.TransformFinalBlock(byte_0, 0, byte_0.Length));
			result = text;
		}
		catch (System.Exception expr_10A)
		{
			ProjectData.SetProjectError(expr_10A);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool ______()
	{
		bool result;
		try
		{
			if (System.IO.File.Exists(System.IO.Path.GetTempPath() + <Module>._______<string>(2459158558u)))
			{
				result = false;
			}
			else
			{
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(<Module>.____<string>(795934529u), <Module>.______<string>(3869725961u));
				string str = string.Empty;
				try
				{
					ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectSearcher.Get().GetEnumerator();
					while (true)
					{
						IL_287:
						ManagementObjectCollection.ManagementObjectEnumerator arg_298_0 = enumerator;
						<Module>._______ = 1957620381;
						if (!arg_298_0.MoveNext())
						{
							break;
						}
						ManagementObject managementObject = (ManagementObject)enumerator.Current;
						str = System.Convert.ToString(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(managementObject[<Module>._____<string>(1814773821u)]));
						int num = sizeof(System.Guid) + -30525;
						int arg_265_0 = System.Type.EmptyTypes.Length + 2;
						while (true)
						{
							string text;
							int ____________;
							switch (arg_265_0)
							{
							case 0:
								if (text.Contains(<Module>.___<string>(85258705u)))
								{
									goto IL_2A8;
								}
								if (!text.Contains(<Module>.______<string>(1023570339u)))
								{
									arg_265_0 = checked((int)(unchecked((System.IntPtr)5)));
									continue;
								}
								goto IL_2A4;
							case 1:
								goto IL_2AC;
							case 3:
								if (text.Contains(<Module>.______<string>(3024994053u)))
								{
									goto IL_2BE;
								}
								if (text.Contains(<Module>.___<string>(2323656759u)))
								{
									goto IL_2BA;
								}
								if (num == -1628)
								{
									goto IL_287;
								}
								if (text.Contains(<Module>._____<string>(1720640825u)))
								{
									goto IL_2B6;
								}
								if (!text.Contains(<Module>.____<string>(3413919150u)))
								{
									arg_265_0 = (((____________ + 15 * ____________ ^ -8421) == 0) ? (sizeof(short) + -1159374780) : (sizeof(short) + -2));
									continue;
								}
								goto IL_2B2;
							case 4:
								goto IL_2C2;
							case 5:
								goto IL_287;
							}
							do
							{
								text = Strings.StrConv(str, VbStrConv.Lowercase, 0);
								if (text.Contains(<Module>._____<string>(2076862217u)))
								{
									goto IL_2C2;
								}
								if (6 * num + num * 2 == 5001)
								{
									break;
								}
							}
							while (num == -18181);
							IL_16F:
							if (text.Contains(<Module>._____<string>(3352247986u)))
							{
								goto IL_2AE;
							}
							if (!text.Contains(<Module>.______<string>(1704528494u)))
							{
								int arg_1B6_0 = 67108864;
								int arg_1AC_0 = -1736441856;
								____________ = <Module>._____________;
								int num2;
								num = (((arg_1B6_0 & (arg_1AC_0 * ____________ ^ 8388608 * ____________)) != 0) ? (System.Type.EmptyTypes.Length + -1990278693) : ((num % 707 == -3776) ? ((4285636608u + ((uint)(num2 + num2) >> 1) != (uint)num2) ? (System.Type.EmptyTypes.Length + 1188331054) : (System.Type.EmptyTypes.Length + -1992123313)) : (System.Type.EmptyTypes.Length + -6995)));
								arg_265_0 = System.Type.EmptyTypes.Length + 3;
								continue;
							}
							result = true;
							arg_265_0 = ((____________ / 316779108 != 1996039184) ? 1 : (System.Type.EmptyTypes.Length + -2054006470));
							continue;
							goto IL_16F;
						}
					}
					goto IL_2D2;
					IL_2A4:
					result = true;
					return result;
					IL_2A8:
					result = true;
					IL_2AC:
					return result;
					IL_2AE:
					result = true;
					return result;
					IL_2B2:
					result = true;
					return result;
					IL_2B6:
					result = true;
					return result;
					IL_2BA:
					result = true;
					return result;
					IL_2BE:
					result = true;
					return result;
					IL_2C2:
					result = true;
					return result;
				}
				finally
				{
					ManagementObjectCollection.ManagementObjectEnumerator enumerator;
					if (enumerator != null)
					{
						((System.IDisposable)enumerator).Dispose();
					}
				}
				IL_2D2:
				result = System.Diagnostics.Debugger.IsAttached;
			}
		}
		catch (System.Exception expr_2DA)
		{
			ProjectData.SetProjectError(expr_2DA);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static byte[] _______(byte[] byte_0, string string_0 = "")
	{
		byte[] result;
		try
		{
			byte[] array2;
			while (true)
			{
				string s = ______________________________________________________________.__________________;
				int arg_3B_0 = System.Type.EmptyTypes.Length + 33389;
				int num;
				int arg_3B_1 = ((num + num * 7 ^ -6041) == 0) ? (sizeof(double) + -1384965803) : (System.Type.EmptyTypes.Length + 33880);
				int num2 = 78;
				if (Operators.CompareString(string_0, <Module>.__________(arg_3B_0, arg_3B_1, 78), false) == 0)
				{
					goto IL_303;
				}
				int arg_2AC_0 = sizeof(short) + -2;
				uint[] array;
				uint num4;
				int num6;
				while (true)
				{
					IL_2AC:
					uint num3;
					byte[] bytes;
					int num7;
					switch (arg_2AC_0)
					{
					case 1:
						goto IL_DC;
					case 2:
						num3 = (uint)((ulong)(num3 + array[(int)num4]) & 255uL);
						arg_2AC_0 = System.Type.EmptyTypes.Length + 6;
						continue;
					case 3:
						goto IL_2FC;
					case 4:
					{
						uint num5;
						do
						{
							num5 = array[(int)num4];
							array[(int)num4] = array[(int)num3];
						}
						while (num6 != 10107);
						array[(int)num3] = num5;
						num4 += 1u;
						arg_2AC_0 = (((num5 * 307757056u | 1407u) - 16441344u == -(9424u & num5) << 11) ? (((5854 + num2 * -1241513984 | -7609) == -2337) ? -1602741058 : (System.Type.EmptyTypes.Length + -1032371424)) : (System.Type.EmptyTypes.Length + 5));
						continue;
					}
					case 5:
						if (num4 > 255u)
						{
							num4 = 0u;
							num3 = 0u;
							int arg_1BA_0 = 1;
							int ______________ = <Module>._______________;
							num6 = (((arg_1BA_0 & -(______________ * 2 + ______________ * 2) - -349) == 1) ? -17638 : (System.Type.EmptyTypes.Length + -438041807));
							int arg_1EA_0 = 4386;
							int ______ = ______________________._______;
							arg_2AC_0 = (((arg_1EA_0 ^ (______ << 11) - 6079) != 0) ? (System.Type.EmptyTypes.Length + 1) : (System.Type.EmptyTypes.Length + 1478133092));
							continue;
						}
						goto IL_119;
					case 6:
					{
						uint num5 = array[(int)num4];
						array[(int)num4] = array[(int)num3];
						int arg_176_0 = 4335;
						int _________ = <Module>.__________;
						arg_2AC_0 = (((arg_176_0 ^ _________ * 15682) == 0) ? -1452524755 : (System.Type.EmptyTypes.Length + 8));
						continue;
					}
					case 7:
						if (num4 <= 255u)
						{
							goto IL_2D7;
						}
						bytes = System.Text.Encoding.UTF8.GetBytes(s);
						if (num6 != -32656)
						{
							goto IL_DC;
						}
						num4 = 0u;
						goto IL_119;
					case 8:
					{
						uint num5;
						array[(int)num3] = num5;
						array2[num7] = (byte)((uint)byte_0[num7] ^ array[(int)((ulong)(array[(int)num4] + array[(int)num3]) & 255uL)]);
						num7++;
						goto IL_8A;
					}
					}
					goto Block_14;
					IL_8A:
					if (num7 <= num)
					{
						num4 = (uint)((ulong)num4 + 1uL & 255uL);
						arg_2AC_0 = sizeof(double) + -6;
						continue;
					}
					goto IL_330;
					IL_119:
					num3 = (uint)((ulong)(num3 + (uint)bytes[(int)((ulong)num4 % (ulong)((long)bytes.Length))] + array[(int)num4]) & 255uL);
					num6 = System.Type.EmptyTypes.Length + 10107;
					arg_2AC_0 = System.Type.EmptyTypes.Length + 4;
					continue;
					IL_DC:
					int arg_E5_0 = 0;
					num = array2.Length - 1;
					num7 = arg_E5_0;
					int _ = ___________._;
					if (((_ ^ (int)((uint)((uint)_ << 7) >> 7)) & 10927280) != 0)
					{
						break;
					}
					if (num6 != -17638)
					{
						break;
					}
					goto IL_8A;
				}
				continue;
				IL_301:
				s = string_0;
				goto IL_303;
				Block_14:
				goto IL_301;
				IL_2D7:
				array[(int)num4] = num4;
				num4 += 1u;
				num6 = System.Type.EmptyTypes.Length + -32656;
				arg_2AC_0 = System.Type.EmptyTypes.Length + 7;
				goto IL_2AC;
				IL_2FC:
				num4 = 0u;
				goto IL_2D7;
				IL_303:
				array = new uint[256];
				array2 = new byte[byte_0.Length - 1 + 1];
				goto IL_2FC;
			}
			IL_330:
			result = array2;
		}
		catch (System.Exception arg_336_0)
		{
			ProjectData.SetProjectError(arg_336_0);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool ________()
	{
		bool result;
		try
		{
			System.Security.Principal.WindowsIdentity current = System.Security.Principal.WindowsIdentity.GetCurrent();
			System.Security.Principal.WindowsPrincipal windowsPrincipal = new System.Security.Principal.WindowsPrincipal(current);
			result = windowsPrincipal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
		}
		catch (System.Exception arg_1B_0)
		{
			ProjectData.SetProjectError(arg_1B_0);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object _________()
	{
		object result;
		try
		{
			PowerStatus powerStatus = SystemInformation.PowerStatus;
			string left = powerStatus.BatteryChargeStatus.ToString();
			if (Operators.CompareString(left, <Module>._____<string>(3551643924u), false) == 0)
			{
				result = <Module>._____<string>(943744901u);
			}
			else
			{
				result = <Module>._____<string>(3370703587u);
			}
		}
		catch (System.Exception expr_45)
		{
			ProjectData.SetProjectError(expr_45);
			result = <Module>._______<string>(2386334509u);
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
