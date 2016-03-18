using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[StandardModule, HideModuleName]
internal sealed class _____________
{
	[EditorBrowsable(EditorBrowsableState.Never), System.Runtime.InteropServices.ComVisible(false)]
	internal sealed class ________________<_> where _ : new()
	{
		[System.ThreadStatic]
		private static _ _;

		internal _ _
		{
			[System.Diagnostics.DebuggerHidden]
			get
			{
				if (_____________<_>.________________._ == null)
				{
					_____________<_>.________________._ = System.Activator.CreateInstance<_>();
				}
				return _____________<_>.________________._;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never), System.Diagnostics.DebuggerHidden]
		public ________________()
		{
		}
	}

	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms"), EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class ______________
	{
		public _____________________________________________________________ _;

		public ______________________________________________________________________ __;

		[System.ThreadStatic]
		private static System.Collections.Hashtable ___;

		public _____________________________________________________________ _
		{
			get
			{
				this._ = _____________.______________._____<_____________________________________________________________>(this._);
				return this._;
			}
			set
			{
				if (value == this._)
				{
					return;
				}
				if (value != null)
				{
					throw new System.ArgumentException(<Module>.____<string>(1513599099u));
				}
				this.______<_____________________________________________________________>(ref this._);
			}
		}

		public ______________________________________________________________________ __
		{
			get
			{
				this.__ = _____________.______________._____<______________________________________________________________________>(this.__);
				return this.__;
			}
			set
			{
				if (value == this.__)
				{
					return;
				}
				if (value != null)
				{
					throw new System.ArgumentException(<Module>.____<string>(1513599099u));
				}
				this.______<______________________________________________________________________>(ref this.__);
			}
		}

		[System.Diagnostics.DebuggerHidden]
		private static _ _____<_>(_ gparam_0) where _ : Form, new()
		{
			if (gparam_0 != null && !gparam_0.IsDisposed)
			{
				switch (System.Type.EmptyTypes.Length + 0)
				{
				case 0:
					return gparam_0;
				}
				return gparam_0;
			}
			if (_____________.______________.___ != null)
			{
				if (_____________.______________.___.ContainsKey(typeof(_)))
				{
					throw new System.InvalidOperationException(Utils.GetResourceString(<Module>._______<string>(3581975121u), new string[0]));
				}
			}
			else
			{
				_____________.______________.___ = new System.Collections.Hashtable();
			}
			_____________.______________.___.Add(typeof(_), null);
			_ result;
			try
			{
				try
				{
					result = System.Activator.CreateInstance<_>();
					return result;
				}
				object arg_89_0;
				System.Reflection.TargetInvocationException expr_8E = arg_89_0 as System.Reflection.TargetInvocationException;
				int arg_AB_0;
				if (expr_8E == null)
				{
					arg_AB_0 = 0;
				}
				else
				{
					System.Reflection.TargetInvocationException ex = expr_8E;
					ProjectData.SetProjectError(expr_8E);
					arg_AB_0 = (((ex.InnerException != null) > false) ? 1 : 0);
				}
				endfilter(arg_AB_0);
			}
			finally
			{
				_____________.______________.___.Remove(typeof(_));
			}
			return result;
		}

		[System.Diagnostics.DebuggerHidden]
		private void ______<_>(ref _ gparam_0) where _ : Form
		{
			gparam_0.Dispose();
			gparam_0 = default(_);
		}

		[EditorBrowsable(EditorBrowsableState.Never), System.Diagnostics.DebuggerHidden]
		public ______________()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal System.Type _______()
		{
			return typeof(_____________.______________);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class _______________
	{
		[EditorBrowsable(EditorBrowsableState.Never), System.Diagnostics.DebuggerHidden]
		public override bool Equals(object obj)
		{
			return base.Equals(System.Runtime.CompilerServices.RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never), System.Diagnostics.DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never), System.Diagnostics.DebuggerHidden]
		internal System.Type _()
		{
			return typeof(_____________._______________);
		}

		[EditorBrowsable(EditorBrowsableState.Never), System.Diagnostics.DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[System.Diagnostics.DebuggerHidden]
		private static _ __<_>(_ gparam_0) where _ : new()
		{
			if (gparam_0 == null)
			{
				return System.Activator.CreateInstance<_>();
			}
			return gparam_0;
		}

		[System.Diagnostics.DebuggerHidden]
		private void ___<_>(ref _ gparam_0)
		{
			gparam_0 = default(_);
		}

		[EditorBrowsable(EditorBrowsableState.Never), System.Diagnostics.DebuggerHidden]
		public _______________()
		{
		}
	}

	private static readonly _____________<____________>.________________ _ = new _____________<____________>.________________();

	private static readonly _____________<___________>.________________ __ = new _____________<___________>.________________();

	private static readonly _____________<User>.________________ ___ = new _____________<User>.________________();

	private static _____________<_____________.______________>.________________ ____ = new _____________<_____________.______________>.________________();

	private static readonly _____________<_____________._______________>.________________ _____ = new _____________<_____________._______________>.________________();

	[HelpKeyword("My.Computer")]
	internal static ____________ _
	{
		[System.Diagnostics.DebuggerHidden]
		get
		{
			return _____________._._;
		}
	}

	[HelpKeyword("My.Application")]
	internal static ___________ __
	{
		[System.Diagnostics.DebuggerHidden]
		get
		{
			return _____________.__._;
		}
	}

	[HelpKeyword("My.User")]
	internal static User ___
	{
		[System.Diagnostics.DebuggerHidden]
		get
		{
			return _____________.___._;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static _____________.______________ ____
	{
		[System.Diagnostics.DebuggerHidden]
		get
		{
			return _____________.____._;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static _____________._______________ _____
	{
		[System.Diagnostics.DebuggerHidden]
		get
		{
			return _____________._____._;
		}
	}
}
