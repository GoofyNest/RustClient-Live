internal class WebConnectionData // TypeDefIndex: 3030
{	private HttpWebRequest _request; // 0x10
	public int StatusCode; // 0x18
	public string StatusDescription; // 0x20
	public WebHeaderCollection Headers; // 0x28
	public Version Version; // 0x30
	public Version ProxyVersion; // 0x38
	public Stream stream; // 0x40
	public string[] Challenge; // 0x48
	private ReadState _readState; // 0x50

	public HttpWebRequest request { get; set; }
	public ReadState ReadState { get; set; }


	public void .ctor() { }

	public void .ctor(HttpWebRequest request) { }

	public HttpWebRequest get_request() { }

	public void set_request(HttpWebRequest value) { }

	public ReadState get_ReadState() { }

	public void set_ReadState(ReadState value) { }

}

