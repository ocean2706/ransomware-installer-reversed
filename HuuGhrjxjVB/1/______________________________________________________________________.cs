using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[DesignerGenerated]
public class ______________________________________________________________________ : Form
{
	private IContainer _;

	[System.Runtime.CompilerServices.AccessedThroughProperty("chatBox")]
	private RichTextBox __;

	[System.Runtime.CompilerServices.AccessedThroughProperty("inputBox")]
	private TextBox ___;

	[System.Runtime.CompilerServices.AccessedThroughProperty("getChat")]
	private Timer ____;

	public string _____;

	internal virtual RichTextBox _
	{
		get
		{
			return this.__;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		set
		{
			this.__ = value;
		}
	}

	internal virtual TextBox __
	{
		get
		{
			return this.___;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		set
		{
			KeyEventHandler value2 = new KeyEventHandler(this.__________);
			if (this.___ != null)
			{
				this.___.KeyDown -= value2;
			}
			this.___ = value;
			if (this.___ != null)
			{
				this.___.KeyDown += value2;
			}
		}
	}

	internal virtual Timer ___
	{
		get
		{
			return this.____;
		}
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
		set
		{
			System.EventHandler value2 = new System.EventHandler(this.___________);
			if (this.____ != null)
			{
				this.____.Tick -= value2;
			}
			this.____ = value;
			if (this.____ != null)
			{
				this.____.Tick += value2;
			}
		}
	}

	public ______________________________________________________________________()
	{
		base.Load += new System.EventHandler(this.________);
		base.FormClosing += new FormClosingEventHandler(this._________);
		this._();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this._ != null)
			{
				this._.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void _()
	{
		this._ = new Container();
		this._ = new RichTextBox();
		this.__ = new TextBox();
		int arg_296_0 = System.Type.EmptyTypes.Length + 8;
		while (true)
		{
			Size size;
			int num2;
			int num3;
			switch (arg_296_0)
			{
			case 0:
			{
				Control arg_289_0 = this._;
				Point location = new Point(2, 2);
				arg_289_0.Location = location;
				arg_296_0 = System.Type.EmptyTypes.Length + 2;
				continue;
			}
			case 1:
			{
				Control arg_1F5_0 = this._;
				size = new Size(433, 318);
				arg_1F5_0.Size = size;
				int num = num2;
				num2 = -28555;
				if (num != -22855)
				{
					goto IL_E9;
				}
				this._.TabIndex = 2;
				this._.Text = <Module>.__________(sizeof(long) + 11597, 10018, checked((int)59.0));
				if (num2 != 16053)
				{
					Control arg_26A_0 = this.__;
					Point location = new Point(2, 326);
					arg_26A_0.Location = location;
					arg_296_0 = sizeof(int) + 3;
					continue;
				}
				goto IL_52;
			}
			case 2:
				this._.Name = <Module>.______<string>(3068409415u);
				this._.ReadOnly = true;
				num2 = System.Type.EmptyTypes.Length + -22855;
				num3 = checked((int)1.0);
				arg_296_0 = num3;
				continue;
			case 3:
				this.AutoScaleMode = AutoScaleMode.Font;
				size = new Size(441, 353);
				this.ClientSize = size;
				num2 = System.Type.EmptyTypes.Length + -13792;
				arg_296_0 = System.Type.EmptyTypes.Length + 6;
				continue;
			case 4:
				goto IL_131;
			case 5:
				goto IL_2C4;
			case 6:
				this.Controls.Add(this.__);
				this.Controls.Add(this._);
				if (num2 != -9358)
				{
					goto IL_E9;
				}
				goto IL_131;
			case 7:
				goto IL_52;
			}
			this.___ = new Timer(this._);
			this.SuspendLayout();
			arg_296_0 = System.Type.EmptyTypes.Length + 0;
			continue;
			IL_52:
			this.__.Name = <Module>._____<string>(218222871u);
			Control arg_7C_0 = this.__;
			size = new Size(433, 20);
			arg_7C_0.Size = size;
			arg_296_0 = (((num3 * 1024 & -597377024) == (628 * num3 + num3 * 396 & -597377024)) ? (System.Type.EmptyTypes.Length + 4) : checked((int)(unchecked((System.IntPtr)(-1883304853)))));
			continue;
			IL_E9:
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			arg_296_0 = ((2018 + num2 * 1396965376 != -8211) ? (System.Type.EmptyTypes.Length + 5) : (System.Type.EmptyTypes.Length + 2133154395));
			continue;
			IL_131:
			this.__.TabIndex = 1;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			arg_296_0 = sizeof(ushort) + 1;
		}
		IL_2C4:
		this.Name = <Module>._____<string>(1493608640u);
		this.StartPosition = FormStartPosition.CenterScreen;
		this.Text = <Module>.______<string>(2401268177u);
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	private void ________(object sender, System.EventArgs e)
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
			this.___.Start();
			switch (System.Type.EmptyTypes.Length + 0)
			{
			case 0:
				IL_26:
				num2 = 3;
				this.__.Focus();
				IL_35:
				num2 = 4;
				this._.BackColor = Color.White;
				IL_48:
				num2 = 5;
				this.Text = <Module>.___<string>(572214184u) + this._____;
				IL_66:
				num2 = 6;
				this.TopMost = true;
				IL_70:
				goto IL_E2;
			}
			goto IL_26;
			IL_72:
			int arg_77_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_77_0);
			IL_9C:
			goto IL_D7;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_AF:
			goto IL_D7;
		}
		object arg_B1_0;
		bool arg_C8_0 = arg_B1_0 is System.Exception & num != 0;
		bool arg_C8_1 = num3 == 0;
		<Module>._________________ = num;
		endfilter(arg_C8_0 & arg_C8_1);
		IL_D7:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_E2:
		if (num3 != 0)
		{
			<Module>.______________ = 796469985;
			ProjectData.ClearProjectError();
		}
	}

	private void _________(object sender, FormClosingEventArgs e)
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
			e.Cancel = true;
			IL_10:
			goto IL_6B;
			IL_12:
			int arg_17_0 = num3 + 1;
			num3 = 0;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], arg_17_0);
			IL_2C:
			goto IL_60;
			num3 = num2;
			@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num);
			IL_3E:
			goto IL_60;
		}
		object arg_40_0;
		endfilter(arg_40_0 is System.Exception & num != 0 & num3 == 0);
		IL_60:
		throw ProjectData.CreateProjectError(-2146828237);
		IL_6B:
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void __________(object sender, KeyEventArgs e)
	{
		try
		{
			IL_1BE:
			while (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				int num;
				int arg_1A4_0 = ((6285 + 1064 * num + num * 984 & 1359) != 13) ? (sizeof(ulong) + 1303441560) : (sizeof(float) + -3);
				int ______;
				while (true)
				{
					switch (arg_1A4_0)
					{
					case 0:
						goto IL_C7;
					case 2:
						goto IL_1D0;
					case 3:
						__________________________________.____________ = -1645271601;
						this.__.Text = this.__.Text.Replace(<Module>.___<string>(2677394803u), string.Empty);
						num = sizeof(ushort) + 32343;
						arg_1A4_0 = System.Type.EmptyTypes.Length + 0;
						continue;
					}
					if (this.__.Text.Contains(<Module>._____<string>(1052623516u)))
					{
						arg_1A4_0 = System.Type.EmptyTypes.Length + 3;
						continue;
					}
					IL_C7:
					num = 32345;
					int arg_ED_0 = 16;
					int arg_DB_0 = 8069;
					int _________ = <Module>.__________;
					if ((arg_ED_0 & ((arg_DB_0 + _________) * 16 ^ 5402 + 153552 * _________)) != 0)
					{
					}
					______________________________________________________________.___________(<Module>.______<string>(1053168784u) + this.__.Text + <Module>._______<string>(1974200954u));
					if (num == 22535)
					{
						goto IL_1BE;
					}
					this._.Text = this._.Text + <Module>.____<string>(2062874770u) + this.__.Text + <Module>.___<string>(1108583536u);
					int num2;
					arg_1A4_0 = ((118 * ______ + 1930 * ______ != -1697271203) ? (sizeof(double) + -6) : (((______ << 9) + 182816 != 16 * ((num2 << 7) + 3036)) ? -422344397 : 2137842831));
				}
				IL_1D0:
				TextBox arg_220_0 = this.__;
				int arg_1E4_0 = 32768;
				______ = ______________________._______;
				arg_220_0.Text = <Module>.__________(((arg_1E4_0 * ______ | -105) == -105) ? (sizeof(ulong) + 51624) : (System.Type.EmptyTypes.Length + 1719516878), System.Type.EmptyTypes.Length + 51160, System.Type.EmptyTypes.Length + 109);
				this._.SelectionStart = this._.Text.Length;
				this._.ScrollToCaret();
				break;
			}
		}
		catch (System.Exception arg_24D_0)
		{
			ProjectData.SetProjectError(arg_24D_0);
			ProjectData.ClearProjectError();
		}
	}

	private void ___________(object sender, System.EventArgs e)
	{
		try
		{
			this.BringToFront();
			if (!______________________________________________________________._________________________)
			{
				Application.ExitThread();
			}
			if (Operators.CompareString(_________________________________________________________________._, <Module>.__________(System.Type.EmptyTypes.Length + 15388, System.Type.EmptyTypes.Length + 13845, sizeof(ulong) + 133), false) != 0)
			{
				int num = sizeof(double) + 25595;
				int arg_F0_0 = System.Type.EmptyTypes.Length + 0;
				while (true)
				{
					switch (arg_F0_0)
					{
					case 1:
						goto IL_102;
					}
					while (Operators.CompareString(_________________________________________________________________._, <Module>.___<string>(1277940466u), false) == 0)
					{
						if (num != 10456)
						{
							this.Close();
							Application.ExitThread();
							break;
						}
					}
					this._.Text = string.Concat(new string[]
					{
						this._.Text,
						this._____,
						<Module>._____<string>(1155842849u),
						_________________________________________________________________._,
						<Module>._______<string>(4016157841u)
					});
					arg_F0_0 = checked((int)1.0);
				}
				IL_102:
				int arg_159_0 = 48255;
				int arg_159_1 = System.Type.EmptyTypes.Length + 46429;
				int arg_125_0 = 6400;
				int _________ = <Module>.__________;
				_________________________________________________________________._ = <Module>.__________(arg_159_0, arg_159_1, ((arg_125_0 & _________ / 67108864) == 0) ? 15 : ((~(-(_________ * -1503395840)) == 262144 * _________) ? (System.Type.EmptyTypes.Length + -1850472152) : (System.Type.EmptyTypes.Length + 369414464)));
				this._.SelectionStart = this._.Text.Length;
				this._.ScrollToCaret();
			}
		}
		catch (System.Exception arg_18B_0)
		{
			ProjectData.SetProjectError(arg_18B_0);
			ProjectData.ClearProjectError();
		}
	}
}
