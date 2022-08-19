internal static class StringUtils // TypeDefIndex: 5969
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180CD70 Offset: 0x180C170 VA: 0x18180CD70
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180D130 Offset: 0x180C530 VA: 0x18180D130
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180D2E0 Offset: 0x180C6E0 VA: 0x18180D2E0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180CEC0 Offset: 0x180C2C0 VA: 0x18180CEC0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180CCB0 Offset: 0x180C0B0 VA: 0x18180CCB0
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x180CBC0 Offset: 0x180BFC0 VA: 0x18180CBC0
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x180D4F0 Offset: 0x180C8F0 VA: 0x18180D4F0
	public static Nullable<int> GetLength(string value) { }

	// RVA: 0x180D8A0 Offset: 0x180CCA0 VA: 0x18180D8A0
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0620 Offset: 0x14BFA20 VA: 0x1814C0620
	|-StringUtils.ForgivingCaseSensitiveFind<JsonProperty>
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	*/

	// RVA: 0x180D650 Offset: 0x180CA50 VA: 0x18180D650
	public static string ToCamelCase(string s) { }

	// RVA: 0x180D550 Offset: 0x180C950 VA: 0x18180D550
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x180D5B0 Offset: 0x180C9B0 VA: 0x18180D5B0
	public static bool IsLowSurrogate(char c) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180D610 Offset: 0x180CA10 VA: 0x18180D610
	public static bool StartsWith(string source, char value) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x180CC70 Offset: 0x180C070 VA: 0x18180CC70
	public static bool EndsWith(string source, char value) { }

}

private sealed class StringUtils.<>c__DisplayClass15_0<TSource> // TypeDefIndex: 5970
{	// Fields
	public Func<TSource, string> valueSelector; // 0x0
	public string testValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD55DC0 Offset: 0xD551C0 VA: 0x180D55DC0
	|-StringUtils.<>c__DisplayClass15_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD603E0 Offset: 0xD5F7E0 VA: 0x180D603E0
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__0
	*/

	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD60430 Offset: 0xD5F830 VA: 0x180D60430
	|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__1
	*/

}

