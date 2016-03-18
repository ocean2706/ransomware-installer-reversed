using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

public class ____________________________________________________________________
{
	public string _;

	public string __;

	public int ___;

	public int ____;

	public void _()
	{
		try
		{
			MessageBoxIcon icon = MessageBoxIcon.None;
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			switch (this.___)
			{
			case 1:
				icon = MessageBoxIcon.Asterisk;
				goto IL_69;
			case 2:
				icon = MessageBoxIcon.Question;
				goto IL_69;
			case 3:
				break;
			case 4:
				icon = MessageBoxIcon.Exclamation;
				goto IL_69;
			default:
				if (System.Type.EmptyTypes.Length + -29162 != -2349)
				{
					goto IL_69;
				}
				break;
			}
			IL_66:
			icon = MessageBoxIcon.Exclamation;
			IL_69:
			switch (this.____)
			{
			case 1:
				buttons = MessageBoxButtons.OK;
				break;
			case 2:
				buttons = MessageBoxButtons.YesNo;
				break;
			case 3:
				buttons = MessageBoxButtons.OKCancel;
				break;
			case 4:
				buttons = MessageBoxButtons.AbortRetryIgnore;
				break;
			default:
				switch (System.Type.EmptyTypes.Length + 0)
				{
				case 0:
					goto IL_96;
				}
				goto IL_66;
			}
			IL_96:
			DialogResult dialogResult = MessageBox.Show(this._, this.__, buttons, icon);
			______________________________________________________________.______________(<Module>._____<string>(1464211711u), <Module>.___<string>(2505485571u) + dialogResult.ToString());
		}
		catch (System.Exception expr_D5)
		{
			ProjectData.SetProjectError(expr_D5);
			System.Exception ex = expr_D5;
			______________________________________________________________.______________(<Module>.____<string>(1187660804u), <Module>.______<string>(342612184u) + ex.ToString());
			ProjectData.ClearProjectError();
		}
	}
}
