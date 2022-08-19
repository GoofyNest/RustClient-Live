internal static class StyleValueExtensions // TypeDefIndex: 4718
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA2CC0 Offset: 0x1AA20C0 VA: 0x181AA2CC0
	|-StyleValueExtensions.ToStyleEnum<Int32Enum>
	|-StyleValueExtensions.ToStyleEnum<DisplayStyle>
	|-StyleValueExtensions.ToStyleEnum<Overflow>
	|-StyleValueExtensions.ToStyleEnum<Visibility>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xECFD80 Offset: 0xECF180 VA: 0x180ECFD80
	internal static StyleLength ToStyleLength(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xECFD40 Offset: 0xECF140 VA: 0x180ECFD40
	internal static StyleFloat ToStyleFloat(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal static string DebugString<T>(IStyleValue<T> styleValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE843B0 Offset: 0xE837B0 VA: 0x180E843B0
	|-StyleValueExtensions.DebugString<int>
	|
	|-RVA: 0xE842A0 Offset: 0xE836A0 VA: 0x180E842A0
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0xE84630 Offset: 0xE83A30 VA: 0x180E84630
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-RVA: 0xE84720 Offset: 0xE83B20 VA: 0x180E84720
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0xE84130 Offset: 0xE83530 VA: 0x180E84130
	|-StyleValueExtensions.DebugString<Color>
	|
	|-RVA: 0xE844C0 Offset: 0xE838C0 VA: 0x180E844C0
	|-StyleValueExtensions.DebugString<Length>
	*/

}

