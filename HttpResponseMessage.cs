public class HttpResponseMessage : IDisposable // TypeDefIndex: 5755
{	private HttpResponseHeaders headers; // 0x10
	private string reasonPhrase; // 0x18
	private HttpStatusCode statusCode; // 0x20
	private Version version; // 0x28
	private bool disposed; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HttpContent <Content>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HttpRequestMessage <RequestMessage>k__BackingField; // 0x40

	public HttpContent Content { get; set; }
	public HttpResponseHeaders Headers { get; }
	public bool IsSuccessStatusCode { get; }
	public string ReasonPhrase { get; set; }
	public HttpRequestMessage RequestMessage { set; }
	public HttpStatusCode StatusCode { get; set; }
	public Version Version { get; }


	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Content(HttpContent value) { }

	public HttpResponseHeaders get_Headers() { }

	public bool get_IsSuccessStatusCode() { }

	public string get_ReasonPhrase() { }

	public void set_ReasonPhrase(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_RequestMessage(HttpRequestMessage value) { }

	public HttpStatusCode get_StatusCode() { }

	public void set_StatusCode(HttpStatusCode value) { }

	public Version get_Version() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public HttpResponseMessage EnsureSuccessStatusCode() { }

	public override string ToString() { }

}

