public class HttpRequestMessage : IDisposable // TypeDefIndex: 5754
{	// Fields
	private HttpRequestHeaders headers; // 0x10
	private HttpMethod method; // 0x18
	private Version version; // 0x20
	private Uri uri; // 0x28
	private bool is_used; // 0x30
	private bool disposed; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private HttpContent <Content>k__BackingField; // 0x38

	// Properties
	public HttpContent Content { get; set; }
	public HttpRequestHeaders Headers { get; }
	public HttpMethod Method { get; set; }
	public Uri RequestUri { get; set; }
	public Version Version { get; }

	// Methods

	// RVA: 0x108AD10 Offset: 0x108A110 VA: 0x18108AD10
	public void .ctor(HttpMethod method, string requestUri) { }

	// RVA: 0x108AE30 Offset: 0x108A230 VA: 0x18108AE30
	public void .ctor(HttpMethod method, Uri requestUri) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public HttpContent get_Content() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	public void set_Content(HttpContent value) { }

	// RVA: 0x108AEF0 Offset: 0x108A2F0 VA: 0x18108AEF0
	public HttpRequestHeaders get_Headers() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public HttpMethod get_Method() { }

	// RVA: 0x108B010 Offset: 0x108A410 VA: 0x18108B010
	public void set_Method(HttpMethod value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public Uri get_RequestUri() { }

	// RVA: 0x108B0B0 Offset: 0x108A4B0 VA: 0x18108B0B0
	public void set_RequestUri(Uri value) { }

	// RVA: 0x108A920 Offset: 0x1089D20 VA: 0x18108A920
	private static bool IsAllowedAbsoluteUri(Uri uri) { }

	// RVA: 0x108AFA0 Offset: 0x108A3A0 VA: 0x18108AFA0
	public Version get_Version() { }

	// RVA: 0x1009F60 Offset: 0x1009360 VA: 0x181009F60 Slot: 4
	public void Dispose() { }

	// RVA: 0x108A8F0 Offset: 0x1089CF0 VA: 0x18108A8F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x108AA90 Offset: 0x1089E90 VA: 0x18108AA90
	internal bool SetIsUsed() { }

	// RVA: 0x108AAA0 Offset: 0x1089EA0 VA: 0x18108AAA0 Slot: 3
	public override string ToString() { }

}

