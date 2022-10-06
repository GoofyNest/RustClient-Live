public static class NumberExtensions // TypeDefIndex: 4848
{

	[ExtensionAttribute] 
	public static string FormatBytes<T>(T input, bool shortFormat = False) { }
	/* GenericInstMethod :
	|
	|-NumberExtensions.FormatBytes<int>
	|
	|-NumberExtensions.FormatBytes<long>
	|
	|-NumberExtensions.FormatBytes<ulong>
	*/

	[ExtensionAttribute] 
	public static T Clamp<T>(T input, T min, T max) { }
	/* GenericInstMethod :
	|
	|-NumberExtensions.Clamp<int>
	*/

	[ExtensionAttribute] 
	public static string FormatSeconds(ulong i) { }

	[ExtensionAttribute] 
	public static string FormatSeconds(long s) { }

	[ExtensionAttribute] 
	public static string FormatSecondsLong(ulong i) { }

	[ExtensionAttribute] 
	public static string FormatSecondsLong(long s) { }

	[ExtensionAttribute] 
	public static string FormatNumberShort(ulong i) { }

	[ExtensionAttribute] 
	public static string FormatNumberShort(long num) { }

	[ExtensionAttribute] 
	public static string FormatDistance(float num) { }

}

