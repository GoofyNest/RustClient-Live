public class HttpResponseMessage : IDisposable // TypeDefIndex: 5755
{
	private HttpResponseHeaders headers; 
	private string reasonPhrase; 
	private HttpStatusCode statusCode; 
	private Version version; 
	private bool disposed; 
	[CompilerGeneratedAttribute] 
	private HttpContent <Content>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private HttpRequestMessage <RequestMessage>k__BackingField; 

	public HttpContent Content { get; set; }
	public HttpResponseHeaders Headers { get; }
	public bool IsSuccessStatusCode { get; }
	public string ReasonPhrase { get; set; }
	public HttpRequestMessage RequestMessage { set; }
	public HttpStatusCode StatusCode { get; set; }
	public Version Version { get; }


	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGeneratedAttribute] 
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] 
	public void set_Content(HttpContent value) { }

	public HttpResponseHeaders get_Headers() { }

	public bool get_IsSuccessStatusCode() { }

	public string get_ReasonPhrase() { }

	public void set_ReasonPhrase(string value) { }

	[CompilerGeneratedAttribute] 
	public void set_RequestMessage(HttpRequestMessage value) { }

	public HttpStatusCode get_StatusCode() { }

	public void set_StatusCode(HttpStatusCode value) { }

	public Version get_Version() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public HttpResponseMessage EnsureSuccessStatusCode() { }

	public override string ToString() { }

}

