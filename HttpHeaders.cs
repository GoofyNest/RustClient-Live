public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 5775
{	private static readonly Dictionary<string, HeaderInfo> known_headers; // 0x0
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers; // 0x10
	private readonly HttpHeaderKind HeaderKind; // 0x18
	internal Nullable<bool> connectionclose; // 0x1C
	internal Nullable<bool> transferEncodingChunked; // 0x1E


	private static void .cctor() { }

	protected void .ctor() { }

	internal void .ctor(HttpHeaderKind headerKind) { }

	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	private HeaderInfo CheckName(string name) { }

	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	[IteratorStateMachineAttribute] // RVA: 0xD9B40 Offset: 0xD8F40 VA: 0x1800D9B40
	public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool Remove(string name) { }

	internal static string GetSingleHeaderString(string key, IEnumerable<string> values) { }

	public override string ToString() { }

	internal void AddOrRemove<T>(string name, T value, Func<object, string> converter) { }
	/* GenericInstMethod :
	|
	|-HttpHeaders.AddOrRemove<MediaTypeHeaderValue>
	|-HttpHeaders.AddOrRemove<object>
	*/

	private List<string> GetAllHeaderValues(HttpHeaders.HeaderBucket bucket, HeaderInfo headerInfo) { }

	internal static HttpHeaderKind GetKnownHeaderKind(string name) { }

	internal T GetValue<T>(string name) { }
	/* GenericInstMethod :
	|
	|-HttpHeaders.GetValue<MediaTypeHeaderValue>
	|-HttpHeaders.GetValue<object>
	|-HttpHeaders.GetValue<string>
	|
	|-HttpHeaders.GetValue<Nullable<long>>
	*/

	internal HttpHeaderValueCollection<T> GetValues<T>(string name) { }
	/* GenericInstMethod :
	|
	|-HttpHeaders.GetValues<TransferCodingHeaderValue>
	|-HttpHeaders.GetValues<object>
	|-HttpHeaders.GetValues<string>
	*/

	internal void SetValue<T>(string name, T value, Func<object, string> toStringConverter) { }
	/* GenericInstMethod :
	|
	|-HttpHeaders.SetValue<long>
	|
	|-HttpHeaders.SetValue<object>
	*/

}

private class HttpHeaders.HeaderBucket // TypeDefIndex: 5776
{	public object Parsed; // 0x10
	private List<string> values; // 0x18
	public readonly Func<object, string> CustomToString; // 0x20

	public bool HasStringValues { get; }
	public List<string> Values { get; set; }


	public void .ctor(object parsed, Func<object, string> converter) { }

	public bool get_HasStringValues() { }

	public List<string> get_Values() { }

	public void set_Values(List<string> value) { }

	public string ParsedToString() { }

}

private sealed class HttpHeaders.<GetEnumerator>d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>>, IDisposable, IEnumerator // TypeDefIndex: 5777
{	private int <>1__state; // 0x10
	private KeyValuePair<string, IEnumerable<string>> <>2__current; // 0x18
	public HttpHeaders <>4__this; // 0x28
	private Dictionary.Enumerator<string, HttpHeaders.HeaderBucket> <>7__wrap1; // 0x30

	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

