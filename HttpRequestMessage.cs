public class HttpRequestMessage : IDisposable // TypeDefIndex: 5754
{	private HttpRequestHeaders headers; // 0x10
	private HttpMethod method; // 0x18
	private Version version; // 0x20
	private Uri uri; // 0x28
	private bool is_used; // 0x30
	private bool disposed; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HttpContent <Content>k__BackingField; // 0x38

	public HttpContent Content { get; set; }
	public HttpRequestHeaders Headers { get; }
	public HttpMethod Method { get; set; }
	public Uri RequestUri { get; set; }
	public Version Version { get; }


	public void .ctor(HttpMethod method, string requestUri) { }

	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Content(HttpContent value) { }

	public HttpRequestHeaders get_Headers() { }

	public HttpMethod get_Method() { }

	public void set_Method(HttpMethod value) { }

	public Uri get_RequestUri() { }

	public void set_RequestUri(Uri value) { }

	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	public Version get_Version() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	internal bool SetIsUsed() { }

	public override string ToString() { }

}

