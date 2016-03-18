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

[HideModuleName]
[StandardModule]
internal sealed class C
{
	private readonly static C.C0<B> a0;

	private readonly static C.C0<A> a1;

	private readonly static C.C0<User> a2;

	private static C.C0<C.C1> a3;

	private readonly static C.C0<C.C2> a4;

	[HelpKeyword("My.Computer")]
	internal static B bzA
	{
		[DebuggerHidden]
		get
		{
			return C.a0.a;
		}
	}

	[HelpKeyword("My.Application")]
	internal static A aZa
	{
		[DebuggerHidden]
		get
		{
			return C.a1.a;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return C.a2.a;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static C.C1 ____
	{
		[DebuggerHidden]
		get
		{
			return C.a3.a;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static C.C2 _____
	{
		[DebuggerHidden]
		get
		{
			return C.a4.a;
		}
	}

	static C()
	{
		C.a0 = new C.C0<B>();
		C.a1 = new C.C0<A>();
		C.a2 = new C.C0<User>();
		C.a3 = new C.C0<C.C1>();
		C.a4 = new C.C0<C.C2>();
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class C1
	{
		public _____________________________________________________________ _;

		public ______________________________________________________________________ __;

		[ThreadStatic]
		private static Hashtable ___;

		public _____________________________________________________________ _
		{
			get
			{
				this._ = C.C1._____<_____________________________________________________________>(this._);
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
					throw new ArgumentException(<Module>.____<string>(1513599099));
				}
				this.______<_____________________________________________________________>(ref this._);
			}
		}

		public ______________________________________________________________________ __
		{
			get
			{
				this.__ = C.C1._____<______________________________________________________________________>(this.__);
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
					throw new ArgumentException(<Module>.____<string>(1513599099));
				}
				this.______<______________________________________________________________________>(ref this.__);
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public C1()
		{
		}

		[DebuggerHidden]
		private static _ _____<_>(_ gparam_0)
		where _ : Form, new()
		{
			_ __;
			if (gparam_0 != null && !gparam_0.IsDisposed)
			{
				switch (Type.EmptyTypes.Length)
				{
					default:
					{
						return gparam_0;
					}
				}
			}
			if (C.C1.___ == null)
			{
				C.C1.___ = new Hashtable();
			}
			else if (C.C1.___.ContainsKey(typeof(_)))
			{
				throw new InvalidOperationException(Utils.GetResourceString(<Module>._______<string>(-712992175), new string[0]));
			}
			C.C1.___.Add(typeof(_), null);
			try
			{
				try
				{
					__ = Activator.CreateInstance<_>();
				}
				catch (TargetInvocationException targetInvocationException) when (targetInvocationException.InnerException != null)
				{
					string str = <Module>.___<string>(-86979368);
					string[] message = new string[] { targetInvocationException.InnerException.Message };
					string resourceString = Utils.GetResourceString(str, message);
					throw new InvalidOperationException(resourceString, targetInvocationException.InnerException);
				}
			}
			finally
			{
				C.C1.___.Remove(typeof(_));
			}
			return __;
		}

		[DebuggerHidden]
		private void ______<_>(ref _ gparam_0)
		where _ : Form
		{
			gparam_0.Dispose();
			gparam_0 = default(_);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type _______()
		{
			return typeof(C.C1);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return this.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return this.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return this.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class C2
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public C2()
		{
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type _()
		{
			return typeof(C.C2);
		}

		[DebuggerHidden]
		private static _ __<_>(_ gparam_0)
		where _ : new()
		{
			if (gparam_0 == null)
			{
				return Activator.CreateInstance<_>();
			}
			return gparam_0;
		}

		[DebuggerHidden]
		private void ___<_>(ref _ gparam_0)
		{
			gparam_0 = default(_);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return this.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return this.GetHashCode();
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return this.ToString();
		}
	}

	[ComVisible(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class C0<T>
	where T : new()
	{
		[ThreadStatic]
		private static T _a;

		internal T a
		{
			[DebuggerHidden]
			get
			{
				if (C.C0<T>._a == null)
				{
					C.C0<T>._a = Activator.CreateInstance<T>();
				}
				return C.C0<T>._a;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public C0()
		{
		}
	}
}