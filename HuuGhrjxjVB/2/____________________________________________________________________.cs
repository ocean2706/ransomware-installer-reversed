using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

public class ____________________________________________________________________
{
	public string _;

	public string __;

	public int ___;

	public int ____;

	public ____________________________________________________________________()
	{
	}

	public void _()
	{
		MessageBoxIcon messageBoxIcon;
		try
		{
			messageBoxIcon = new MessageBoxIcon();
			MessageBoxButtons messageBoxButton = new MessageBoxButtons();
			switch (this.___)
			{
				case 1:
				{
					messageBoxIcon = MessageBoxIcon.Asterisk;
					break;
				}
				case 2:
				{
					messageBoxIcon = MessageBoxIcon.Question;
					break;
				}
				case 3:
				{
					goto Label0;
				}
				case 4:
				{
					messageBoxIcon = MessageBoxIcon.Exclamation;
					break;
				}
				default:
				{
					if (Type.EmptyTypes.Length + -29162 == -2349)
					{
						goto Label0;
					}
					break;
				}
			}
		Label1:
			switch (this.____)
			{
				case 1:
				{
					messageBoxButton = MessageBoxButtons.OK;
					break;
				}
				case 2:
				{
					messageBoxButton = MessageBoxButtons.YesNo;
					break;
				}
				case 3:
				{
					messageBoxButton = MessageBoxButtons.OKCancel;
					break;
				}
				case 4:
				{
					messageBoxButton = MessageBoxButtons.AbortRetryIgnore;
					break;
				}
				default:
				{
					switch (Type.EmptyTypes.Length)
					{
						case 0:
						{
							break;
						}
						default:
						{
							goto Label0;
						}
					}
					break;
				}
			}
			DialogResult dialogResult = MessageBox.Show(this._, this.__, messageBoxButton, messageBoxIcon);
			______________________________________________________________.______________(<Module>._____<string>(1464211711), string.Concat(<Module>.___<string>(-1789481725), dialogResult.ToString()));
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			Exception exception = exception1;
			______________________________________________________________.______________(<Module>.____<string>(1187660804), string.Concat(<Module>.______<string>(342612184), exception.ToString()));
			ProjectData.ClearProjectError();
		}
		return;
	Label0:
		messageBoxIcon = MessageBoxIcon.Exclamation;
		goto Label1;
	}
}