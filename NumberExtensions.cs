public static class NumberExtensions // TypeDefIndex: 4844
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static string FormatBytes<T>(T input, bool shortFormat = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE82200 Offset: 0xE81600 VA: 0x180E82200
	|-NumberExtensions.FormatBytes<int>
	|
	|-RVA: 0xE82440 Offset: 0xE81840 VA: 0x180E82440
	|-NumberExtensions.FormatBytes<long>
	|
	|-RVA: 0xE82680 Offset: 0xE81A80 VA: 0x180E82680
	|-NumberExtensions.FormatBytes<ulong>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static T Clamp<T>(T input, T min, T max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EC690 Offset: 0x5EBA90 VA: 0x1805EC690
	|-NumberExtensions.Clamp<int>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226A4A0 Offset: 0x22698A0 VA: 0x18226A4A0
	public static string FormatSeconds(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226A4B0 Offset: 0x22698B0 VA: 0x18226A4B0
	public static string FormatSeconds(long s) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x226A490 Offset: 0x2269890 VA: 0x18226A490
	public static string FormatSecondsLong(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2269940 Offset: 0x2268D40 VA: 0x182269940
	public static string FormatSecondsLong(long s) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2269870 Offset: 0x2268C70 VA: 0x182269870
	public static string FormatNumberShort(ulong i) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2269880 Offset: 0x2268C80 VA: 0x182269880
	public static string FormatNumberShort(long num) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2269810 Offset: 0x2268C10 VA: 0x182269810
	public static string FormatDistance(float num) { }

}

