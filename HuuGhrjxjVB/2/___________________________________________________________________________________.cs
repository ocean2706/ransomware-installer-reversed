using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net;
using System.Net.Sockets;

public class ___________________________________________________________________________________
{
	public const int _ = 8192;

	private _________________________________________________________________________________ __;

	private int ___;

	private Socket ____;

	private string _____;

	private int ______;

	private byte[] _______;

	private bool ________;

	public int _
	{
		get
		{
			return this.___;
		}
		private set
		{
			this.___ = value;
		}
	}

	public Socket __
	{
		get
		{
			return this.____;
		}
		private set
		{
			this.____ = value;
		}
	}

	public string ___
	{
		get
		{
			return this._____;
		}
		private set
		{
			this._____ = value;
		}
	}

	public int ____
	{
		get
		{
			return this.______;
		}
		private set
		{
			this.______ = value;
		}
	}

	public ___________________________________________________________________________________(int int_0, string string_0, int int_1, _________________________________________________________________________________ __________________________________________________________________________________0)
	{
		try
		{
			this._ = int_0;
			this.___ = string_0;
			this.____ = int_1;
			this.__ = __________________________________________________________________________________0;
			this.__ = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			___________________________________________________________________________________ __________________________________________ = this;
			this.__.BeginConnect(string_0, int_1, new AsyncCallback(__________________________________________._________), null);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
	}

	private void _________(IAsyncResult iasyncResult_0)
	{
		IPEndPoint localEndPoint = null;
		try
		{
			this.__.EndConnect(iasyncResult_0);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		if (!this.__.Connected)
		{
			this.__.________(this._, false, 0L, 0, this.___);
		}
		else
		{
			try
			{
				this._______ = new byte[8192];
				___________________________________________________________________________________ __________________________________________ = this;
				__________________________________________________________________________.___ = localEndPoint;
				this.__.BeginReceive(this._______, 0, checked((int)this._______.Length), SocketFlags.None, new AsyncCallback(__________________________________________.__________), null);
				<Module>.____________ = -1652138191;
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				this.__.________(this._, false, 0L, 0, this.___);
				this.___________();
				ProjectData.ClearProjectError();
			}
			localEndPoint = (IPEndPoint)this.__.LocalEndPoint;
			this.__.________(this._, true, localEndPoint.Address.Address, localEndPoint.Port, this.___);
		}
	}

	private void __________(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = this.__.EndReceive(iasyncResult_0);
			if (num > 0)
			{
				byte[] numArray = new byte[num - 1 + 1];
				Array.Copy(this._______, numArray, num);
				this.__._____(this._, numArray);
			}
			else
			{
				this.___________();
				return;
			}
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.___________();
			ProjectData.ClearProjectError();
			return;
		}
		try
		{
			___________________________________________________________________________________ __________________________________________ = this;
			this.__.BeginReceive(this._______, 0, checked((int)this._______.Length), SocketFlags.None, new AsyncCallback(__________________________________________.__________), null);
		}
		catch (Exception exception1)
		{
			ProjectData.SetProjectError(exception1);
			this.___________();
			ProjectData.ClearProjectError();
		}
	}

	public void ___________()
	{
		if (!this.________)
		{
			this.________ = true;
			this.__.____(this._);
		}
		try
		{
			this.__.Close();
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			ProjectData.ClearProjectError();
		}
		this.__._______(this._);
	}

	public void ____________(byte[] byte_0)
	{
		try
		{
			this.__.Send(byte_0);
		}
		catch (Exception exception)
		{
			ProjectData.SetProjectError(exception);
			this.___________();
			ProjectData.ClearProjectError();
		}
	}
}