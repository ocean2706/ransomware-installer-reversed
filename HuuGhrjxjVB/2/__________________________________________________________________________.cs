using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[HideModuleName]
[StandardModule]
internal sealed class __________________________________________________________________________
{
	private static ResourceManager _;

	private static CultureInfo __;

	public static object ___;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager _
	{
		get
		{
			if (object.ReferenceEquals(__________________________________________________________________________._, null))
			{
				ResourceManager resourceManager = <Module>.________(<Module>.___<string>(-1283015927), typeof(__________________________________________________________________________).Assembly);
				__________________________________________________________________________._ = resourceManager;
			}
			return __________________________________________________________________________._;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo __
	{
		get
		{
			return __________________________________________________________________________.__;
		}
		set
		{
			__________________________________________________________________________.__ = value;
		}
	}

	internal static string ___
	{
		get
		{
			return __________________________________________________________________________._.GetString(<Module>.______<string>(-565375116), __________________________________________________________________________.__);
		}
	}

	internal static byte[] ____
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(__________________________________________________________________________._.GetObject(<Module>._______<string>(2004946176), __________________________________________________________________________.__));
			return (byte[])objectValue;
		}
	}

	internal static string _____
	{
		get
		{
			return __________________________________________________________________________._.GetString(<Module>._____<string>(2093462827), __________________________________________________________________________.__);
		}
	}

	internal static byte[] ______
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(__________________________________________________________________________._.GetObject(<Module>.____<string>(251397721), __________________________________________________________________________.__));
			return (byte[])objectValue;
		}
	}

	internal static string _______
	{
		get
		{
			return __________________________________________________________________________._.GetString(<Module>.___<string>(-1666183870), __________________________________________________________________________.__);
		}
	}
}