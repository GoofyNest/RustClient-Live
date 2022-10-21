public class HttpRequestMessage : IDisposable // TypeDefIndex: 5759
{
	private HttpRequestHeaders headers; 
	private HttpMethod method; 
	private Version version; 
	private Uri uri; 
	private bool is_used; 
	private bool disposed; 
	[CompilerGeneratedAttribute] 
	private HttpContent <Content>k__BackingField; 

	public HttpContent Content { get; set; }
	public HttpRequestHeaders Headers { get; }
	public HttpMethod Method { get; set; }
	public Uri RequestUri { get; set; }
	public Version Version { get; }


	public void .ctor(HttpMethod method, string requestUri) { }

	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGeneratedAttribute] 
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] 
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

