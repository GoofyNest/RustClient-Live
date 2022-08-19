public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 5775
{	// Fields
	private static readonly Dictionary<string, HeaderInfo> known_headers; // 0x0
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers; // 0x10
	private readonly HttpHeaderKind HeaderKind; // 0x18
	internal Nullable<bool> connectionclose; // 0x1C
	internal Nullable<bool> transferEncodingChunked; // 0x1E

	// Methods

	// RVA: 0x1087590 Offset: 0x1086990 VA: 0x181087590
	private static void .cctor() { }

	// RVA: 0x10897A0 Offset: 0x1088BA0 VA: 0x1810897A0
	protected void .ctor() { }

	// RVA: 0x1089890 Offset: 0x1088C90 VA: 0x181089890
	internal void .ctor(HttpHeaderKind headerKind) { }

	// RVA: 0x10863F0 Offset: 0x10857F0 VA: 0x1810863F0
	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	// RVA: 0x10872B0 Offset: 0x10866B0 VA: 0x1810872B0
	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	// RVA: 0x1086790 Offset: 0x1085B90 VA: 0x181086790
	private HeaderInfo CheckName(string name) { }

	// RVA: 0x1087460 Offset: 0x1086860 VA: 0x181087460
	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9B40 Offset: 0xD8F40 VA: 0x1800D9B40
	// RVA: 0x1086A90 Offset: 0x1085E90 VA: 0x181086A90 Slot: 4
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() { }

	// RVA: 0x1086A90 Offset: 0x1085E90 VA: 0x181086A90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1086EC0 Offset: 0x10862C0 VA: 0x181086EC0
	public bool Remove(string name) { }

	// RVA: 0x1086BE0 Offset: 0x1085FE0 VA: 0x181086BE0
	internal static string GetSingleHeaderString(string key, IEnumerable<string> values) { }

	// RVA: 0x1087030 Offset: 0x1086430 VA: 0x181087030 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFCF80 Offset: 0xDFC380 VA: 0x180DFCF80
	|-HttpHeaders.AddOrRemove<MediaTypeHeaderValue>
	|-HttpHeaders.AddOrRemove<object>
	*/

	// RVA: 0x10868E0 Offset: 0x1085CE0 VA: 0x1810868E0
	private List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo) { }

	// RVA: 0x1086B00 Offset: 0x1085F00 VA: 0x181086B00
	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	// RVA: -1 Offset: -1
	internal T GetValue<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBD53E0 Offset: 0xBD47E0 VA: 0x180BD53E0
	|-HttpHeaders.GetValue<MediaTypeHeaderValue>
	|-HttpHeaders.GetValue<object>
	|-HttpHeaders.GetValue<string>
	|
	|-RVA: 0xBD5140 Offset: 0xBD4540 VA: 0x180BD5140
	|-HttpHeaders.GetValue<Nullable<long>>
	*/

	// RVA: -1 Offset: -1
	internal HttpHeaderValueCollection<T> GetValues<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE7FFB0 Offset: 0xE7F3B0 VA: 0x180E7FFB0
	|-HttpHeaders.GetValues<TransferCodingHeaderValue>
	|-HttpHeaders.GetValues<object>
	|-HttpHeaders.GetValues<string>
	*/

	// RVA: -1 Offset: -1
	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDFCFC0 Offset: 0xDFC3C0 VA: 0x180DFCFC0
	|-HttpHeaders.SetValue<long>
	|
	|-RVA: 0xDFD090 Offset: 0xDFC490 VA: 0x180DFD090
	|-HttpHeaders.SetValue<object>
	*/

}

private class HttpHeaders.HeaderBucket // TypeDefIndex: 5776
{	// Fields
	public object Parsed; // 0x10
	private List<string> values; // 0x18
	public readonly Func<object, string> CustomToString; // 0x20

	// Properties
	public bool HasStringValues { get; }
	public List<string> Values { get; set; }

	// Methods

	// RVA: 0x1083410 Offset: 0x1082810 VA: 0x181083410
	public void .ctor(object parsed, Func<object, string> converter) { }

	// RVA: 0x1083460 Offset: 0x1082860 VA: 0x181083460
	public bool get_HasStringValues() { }

	// RVA: 0x10834A0 Offset: 0x10828A0 VA: 0x1810834A0
	public List<string> get_Values() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Values(List<string> value) { }

	// RVA: 0x10833A0 Offset: 0x10827A0 VA: 0x1810833A0
	public string ParsedToString() { }

}

private sealed class HttpHeaders.<GetEnumerator>d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>>, IDisposable, IEnumerator // TypeDefIndex: 5777
{	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, IEnumerable<string>> <>2__current; // 0x18
	public HttpHeaders <>4__this; // 0x28
	private Dictionary.Enumerator<string, HttpHeaders.HeaderBucket> <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1093370 Offset: 0x1092770 VA: 0x181093370 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1093070 Offset: 0x1092470 VA: 0x181093070 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x1093410 Offset: 0x1092810 VA: 0x181093410
	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0C9C0 Offset: 0xB0BDC0 VA: 0x180B0C9C0 Slot: 4
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10932D0 Offset: 0x10926D0 VA: 0x1810932D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1093320 Offset: 0x1092720 VA: 0x181093320 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

