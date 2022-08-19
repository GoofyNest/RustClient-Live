internal class WebConnectionData // TypeDefIndex: 3030
{	// Fields
	private HttpWebRequest _request; // 0x10
	public int StatusCode; // 0x18
	public string StatusDescription; // 0x20
	public WebHeaderCollection Headers; // 0x28
	public Version Version; // 0x30
	public Version ProxyVersion; // 0x38
	public Stream stream; // 0x40
	public string[] Challenge; // 0x48
	private ReadState _readState; // 0x50

	// Properties
	public HttpWebRequest request { get; set; }
	public ReadState ReadState { get; set; }

	// Methods

	// RVA: 0x1179400 Offset: 0x1178800 VA: 0x181179400
	public void .ctor() { }

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	public void .ctor(HttpWebRequest request) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public HttpWebRequest get_request() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_request(HttpWebRequest value) { }

	// RVA: 0x8C8B80 Offset: 0x8C7F80 VA: 0x1808C8B80
	public ReadState get_ReadState() { }

	// RVA: 0x1179420 Offset: 0x1178820 VA: 0x181179420
	public void set_ReadState(ReadState value) { }

}

