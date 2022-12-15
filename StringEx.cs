public static class StringEx // TypeDefIndex: 6622
{
	private static readonly Regex regexNumeric;
	private static readonly Regex regexAlphaNumeric;


	[ExtensionAttribute]
	public static string Replace(string originalString, string oldValue, string newValue, StringComparison comparisonType) { }

	[ExtensionAttribute]
	public static bool Contains(string haystack, string needle, CompareOptions options) { }

	[ExtensionAttribute]
	public static bool IsLower(string str) { }

	[ExtensionAttribute]
	public static string ToPrintable(string str, int maxLength = 2147483647) { }

	[ExtensionAttribute]
	public static bool IsNumeric(string str) { }

	[ExtensionAttribute]
	public static bool IsAlphaNumeric(string str) { }

	[ExtensionAttribute]
	public static string EscapeRichText(string str) { }

	[IteratorStateMachineAttribute]
	[ExtensionAttribute]
	public static IEnumerable<string> SplitToLines(string input) { }

	[IteratorStateMachineAttribute]
	[ExtensionAttribute]
	public static IEnumerable<string> SplitToChunks(string str, int chunkLength) { }

	[ExtensionAttribute]
	public static uint ManifestHash(string str) { }

	[ExtensionAttribute]
	public static bool StartsWithAny(string str, string[] values) { }

	private static void .cctor() { }

}

private sealed class StringEx.<SplitToLines>d__9 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable // TypeDefIndex: 6623
{
	private int <>1__state;
	private string <>2__current;
	private int <>l__initialThreadId;
	private string input;
	public string <>3__input;
	private StringReader <reader>5__2;

	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute]
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute]
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

private sealed class StringEx.<SplitToChunks>d__10 : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable // TypeDefIndex: 6624
{
	private int <>1__state;
	private string <>2__current;
	private int <>l__initialThreadId;
	private string str;
	public string <>3__str;
	private int chunkLength;
	public int <>3__chunkLength;
	private int <i>5__2;

	private string System.Collections.Generic.IEnumerator<System.String>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute]
	private IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	[DebuggerHiddenAttribute]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

