public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable // TypeDefIndex: 5784
{
	private static readonly Dictionary<string, HeaderInfo> known_headers;
	private readonly Dictionary<string, HttpHeaders.HeaderBucket> headers;
	private readonly HttpHeaderKind HeaderKind;
	internal Nullable<bool> connectionclose;
	internal Nullable<bool> transferEncodingChunked;


	private static void .cctor() { }

	protected void .ctor() { }

	internal void .ctor(HttpHeaderKind headerKind) { }

	private bool AddInternal(string name, IEnumerable<string> values, HeaderInfo headerInfo, bool ignoreInvalid) { }

	public bool TryAddWithoutValidation(string name, IEnumerable<string> values) { }

	private HeaderInfo CheckName(string name) { }

	private bool TryCheckName(string name, out HeaderInfo headerInfo) { }

	[IteratorStateMachineAttribute]
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

private class HttpHeaders.HeaderBucket // TypeDefIndex: 5785
{
	public object Parsed;
	private List<string> values;
	public readonly Func<object, string> CustomToString;

	public bool HasStringValues { get; }
	public List<string> Values { get; set; }


	public void .ctor(object parsed, Func<object, string> converter) { }

	public bool get_HasStringValues() { }

	public List<string> get_Values() { }

	public void set_Values(List<string> value) { }

	public string ParsedToString() { }

}

private sealed class HttpHeaders.<GetEnumerator>d__19 : IEnumerator<KeyValuePair<string, IEnumerable<string>>>, IDisposable, IEnumerator // TypeDefIndex: 5786
{
	private int <>1__state;
	private KeyValuePair<string, IEnumerable<string>> <>2__current;
	public HttpHeaders <>4__this;
	private Dictionary.Enumerator<string, HttpHeaders.HeaderBucket> <>7__wrap1;

	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	private void <>m__Finally1() { }

	[DebuggerHiddenAttribute]
	private KeyValuePair<string, IEnumerable<string>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IEnumerable<System.String>>>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

