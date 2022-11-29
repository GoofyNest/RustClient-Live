internal static class StyleValueExtensions // TypeDefIndex: 4723
{

	[ExtensionAttribute] 
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-StyleValueExtensions.ToStyleEnum<Int32Enum>
	|-StyleValueExtensions.ToStyleEnum<DisplayStyle>
	|-StyleValueExtensions.ToStyleEnum<Overflow>
	|-StyleValueExtensions.ToStyleEnum<Visibility>
	*/

	[ExtensionAttribute] 
	internal static StyleLength ToStyleLength(StyleValue styleValue) { }

	[ExtensionAttribute] 
	internal static StyleFloat ToStyleFloat(StyleValue styleValue) { }

	[ExtensionAttribute] 
	internal static string DebugString<T>(IStyleValue<T> styleValue) { }
	/* GenericInstMethod :
	|
	|-StyleValueExtensions.DebugString<int>
	|
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-StyleValueExtensions.DebugString<float>
	|
	|-StyleValueExtensions.DebugString<Color>
	|
	|-StyleValueExtensions.DebugString<Length>
	*/

}

