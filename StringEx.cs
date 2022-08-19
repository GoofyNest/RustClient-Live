public static class StringEx // TypeDefIndex: 6608
{	// Fields
	private static readonly Regex regexNumeric; // 0x0
	private static readonly Regex regexAlphaNumeric; // 0x8

	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA7400 Offset: 0x1BA6800 VA: 0x181BA7400
	public static string Replace(string originalString, string oldValue, string newValue, StringComparison comparisonType) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA6F60 Offset: 0x1BA6360 VA: 0x181BA6F60
	public static bool Contains(string haystack, string needle, CompareOptions options) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA7150 Offset: 0x1BA6550 VA: 0x181BA7150
	public static bool IsLower(string str) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA7660 Offset: 0x1BA6A60 VA: 0x181BA7660
	public static string ToPrintable(string str, int maxLength = 2147483647) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA7200 Offset: 0x1BA6600 VA: 0x181BA7200
	public static bool IsNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA70D0 Offset: 0x1BA64D0 VA: 0x181BA70D0
	public static bool IsAlphaNumeric(string str) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA7020 Offset: 0x1BA6420 VA: 0x181BA7020
	public static string EscapeRichText(string str) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4970 Offset: 0xB3D70 VA: 0x1800B4970
	[ExtensionAttribute] // RVA: 0xB4970 Offset: 0xB3D70 VA: 0x1800B4970
	// RVA: 0x1BA7560 Offset: 0x1BA6960 VA: 0x181BA7560
	public static IEnumerable<string> SplitToLines(string input) { }

	[IteratorStateMachineAttribute] // RVA: 0xB4B40 Offset: 0xB3F40 VA: 0x1800B4B40
	[ExtensionAttribute] // RVA: 0xB4B40 Offset: 0xB3F40 VA: 0x1800B4B40
	// RVA: 0x1BA74E0 Offset: 0x1BA68E0 VA: 0x181BA74E0
	public static IEnumerable<string> SplitToChunks(string str, int chunkLength) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA7280 Offset: 0x1BA6680 VA: 0x181BA7280
	public static uint ManifestHash(string str) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BA75D0 Offset: 0x1BA69D0 VA: 0x181BA75D0
	public static bool StartsWithAny(string str, string[] values) { }

	// RVA: 0x1BA77C0 Offset: 0x1BA6BC0 VA: 0x181BA77C0
	private static void .cctor() { }

}

private sealed class StringEx.<SplitToLines>d__9 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable // TypeDefIndex: 6609
{	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private string input; // 0x28
	public string <>3__input; // 0x30
	private StringReader <reader>5__2; // 0x38

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAAB50 Offset: 0x1BA9F50 VA: 0x181BAAB50 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BAA8F0 Offset: 0x1BA9CF0 VA: 0x181BAA8F0 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1BAAC00 Offset: 0x1BAA000 VA: 0x181BAAC00
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAAB00 Offset: 0x1BA9F00 VA: 0x181BAAB00 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAAA60 Offset: 0x1BA9E60 VA: 0x181BAAA60 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAAA60 Offset: 0x1BA9E60 VA: 0x181BAAA60 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class StringEx.<SplitToChunks>d__10 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable // TypeDefIndex: 6610
{	// Fields
	private int <>1__state; // 0x10
	private string <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private string str; // 0x28
	public string <>3__str; // 0x30
	private int chunkLength; // 0x38
	public int <>3__chunkLength; // 0x3C
	private int <i>5__2; // 0x40

	// Properties
	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD824F0 Offset: 0xD818F0 VA: 0x180D824F0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1BAA6C0 Offset: 0x1BA9AC0 VA: 0x181BAA6C0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 6
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAA8A0 Offset: 0x1BA9CA0 VA: 0x181BAA8A0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAA7F0 Offset: 0x1BA9BF0 VA: 0x181BAA7F0 Slot: 4
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1BAA7F0 Offset: 0x1BA9BF0 VA: 0x181BAA7F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

