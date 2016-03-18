using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Threading;

[StandardModule]
internal sealed class __________________
{
	public static string _;

	static __________________()
	{
		__________________._ = string.Empty;
	}

	public static void _(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
	{
		unsafe
		{
			int num = 0;
			int num1;
			object length;
			try
			{
				int ________ = <Module>._______________;
				(-2599 | ________ * 1319108608 - (________ << 15)) == -2599;
				if (Operators.CompareString(string_0, <Module>.______<string>(1556406989), false) != 0)
				{
					goto Label0;
				}
				length = Type.EmptyTypes.Length + 0;
			Label12:
				switch (length)
				{
					case 1:
					{
						goto Label2;
					}
					case 2:
					{
						string_0 = <Module>.____<string>(1877990161);
						break;
					}
					case 3:
					{
						goto Label3;
					}
					default:
					{
						goto Label1;
					}
				}
			Label13:
				if (Operators.CompareString(string_0, <Module>._____<string>(-710027843), false) == 0)
				{
					num1 = 29020;
					if (((-6913 | (num & 6211) / 19205640) != -6913 ? (int)(sizeof(ushort) + 1377973290) : 29016) != 29016)
					{
						goto Label1;
					}
					string_0 = <Module>.____<string>(648682773);
				}
				if (Operators.CompareString(string_0, <Module>.___<string>(-468068664), false) == 0)
				{
					goto Label5;
				}
			Label9:
				if (Operators.CompareString(string_0, <Module>.______<string>(875448834), false) == 0)
				{
					num1 = -8878;
					int _______ = <Module>.C;
					if (((_______ ^ 1024 * (_______ >> 10)) & -998244352) != 0)
					{
						goto Label2;
					}
					string_0 = <Module>.___<string>(276678256);
				}
				_________________ _________ = new _________________()
				{
					___ = string_0
				};
				num1 = 10192;
				if (Type.EmptyTypes.Length + -8878 != -8878)
				{
					goto Label1;
				}
				_________.____ = string_1;
				_________.______ = Convert.ToInt32(string_2);
				if (num1 == 10192)
				{
					_________._____ = Convert.ToInt32(string_3);
					_________.________ = Convert.ToInt32(string_4);
					_________._______ = Convert.ToInt32(string_5);
					_________________ _________1 = _________;
					(new Thread(new ThreadStart(_________1._))).Start();
					return;
				}
			Label3:
				string_0 = <Module>._____<string>(-1704869615);
				goto Label9;
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				ProjectData.ClearProjectError();
			}
			return;
		Label0:
			if (Operators.CompareString(string_0, <Module>.____<string>(2067794254), false) == 0)
			{
				num1 = 24973;
				string_0 = <Module>.____<string>(185790362);
				goto Label10;
			}
			else
			{
				goto Label10;
			}
		Label1:
			string_0 = <Module>._______<string>(-622817354);
			goto Label0;
		Label2:
			string_0 = <Module>.____<string>(1718620316);
			goto Label11;
		Label5:
			length = Type.EmptyTypes.Length + 3;
			goto Label12;
		Label10:
			if (Operators.CompareString(string_0, <Module>._____<string>(1034167915), false) != 0)
			{
				goto Label11;
			}
			if ((-9999 ^ <Module>.__________ * 8388608 | -2225) == -1)
			{
				length = Type.EmptyTypes.Length + 1;
				goto Label12;
			}
			else
			{
				int ________1 = <Module>.______________;
				if (~((-4673 & ________1 >> 3) << 3) == ________1)
				{
					length = (int)-850050951;
					goto Label12;
				}
				else
				{
					length = checked((int)-1197002384);
					goto Label12;
				}
			}
		Label11:
			if (Operators.CompareString(string_0, <Module>.____<string>(-72080832), false) != 0)
			{
				goto Label13;
			}
			length = sizeof(int) + -2;
			goto Label12;
		}
	}
}