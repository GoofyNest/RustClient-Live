public sealed class HttpRequestHeaders : HttpHeaders // TypeDefIndex: 5787
{
	private Nullable<bool> expectContinue;

	public HttpHeaderValueCollection<string> Connection { get; }
	public Nullable<bool> ConnectionClose { get; }
	internal bool ConnectionKeepAlive { get; }
	public Nullable<bool> ExpectContinue { get; }
	public string Host { get; }
	public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding { get; }
	public Nullable<bool> TransferEncodingChunked { get; }


	internal void .ctor() { }

	public HttpHeaderValueCollection<string> get_Connection() { }

	public Nullable<bool> get_ConnectionClose() { }

	internal bool get_ConnectionKeepAlive() { }

	public Nullable<bool> get_ExpectContinue() { }

	public string get_Host() { }

	public HttpHeaderValueCollection<TransferCodingHeaderValue> get_TransferEncoding() { }

	public Nullable<bool> get_TransferEncodingChunked() { }

	internal void AddHeaders(HttpRequestHeaders headers) { }

}

private sealed class HttpRequestHeaders.<>c // TypeDefIndex: 5788
{
	public static readonly HttpRequestHeaders.<>c <>9;
	public static Predicate<string> <>9__19_0;
	public static Predicate<string> <>9__22_0;
	public static Predicate<TransferCodingHeaderValue> <>9__29_0;
	public static Predicate<TransferCodingHeaderValue> <>9__71_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <get_ConnectionClose>

	internal bool <get_ConnectionKeepAlive>

	internal bool <get_ExpectContinue>

	internal bool <get_TransferEncodingChunked>

}

