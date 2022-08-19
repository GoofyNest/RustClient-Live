public class HttpResponseMessage : IDisposable // TypeDefIndex: 5755
{	// Fields
	private HttpResponseHeaders headers; // 0x10
	private string reasonPhrase; // 0x18
	private HttpStatusCode statusCode; // 0x20
	private Version version; // 0x28
	private bool disposed; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HttpContent <Content>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HttpRequestMessage <RequestMessage>k__BackingField; // 0x40

	// Properties
	public HttpContent Content { get; set; }
	public HttpResponseHeaders Headers { get; }
	public bool IsSuccessStatusCode { get; }
	public string ReasonPhrase { get; set; }
	public HttpRequestMessage RequestMessage { set; }
	public HttpStatusCode StatusCode { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x108B620 Offset: 0x108AA20 VA: 0x18108B620
	public void .ctor(HttpStatusCode statusCode) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Content(HttpContent value) { }

	// RVA: 0x108B690 Offset: 0x108AA90 VA: 0x18108B690
	public HttpResponseHeaders get_Headers() { }

	// RVA: 0x108B740 Offset: 0x108AB40 VA: 0x18108B740
	public bool get_IsSuccessStatusCode() { }

	// RVA: 0x108B760 Offset: 0x108AB60 VA: 0x18108B760
	public string get_ReasonPhrase() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_ReasonPhrase(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94A0 Offset: 0x4B88A0 VA: 0x1804B94A0
	public void set_RequestMessage(HttpRequestMessage value) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public HttpStatusCode get_StatusCode() { }

	// RVA: 0x108B7F0 Offset: 0x108ABF0 VA: 0x18108B7F0
	public void set_StatusCode(HttpStatusCode value) { }

	// RVA: 0x108B780 Offset: 0x108AB80 VA: 0x18108B780
	public Version get_Version() { }

	// RVA: 0x1009F60 Offset: 0x1009360 VA: 0x181009F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x108B310 Offset: 0x108A710 VA: 0x18108B310 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108B340 Offset: 0x108A740 VA: 0x18108B340
	public HttpResponseMessage EnsureSuccessStatusCode() { }

	// RVA: 0x108B400 Offset: 0x108A800 VA: 0x18108B400 Slot: 3
	public override string ToString() { }

}

