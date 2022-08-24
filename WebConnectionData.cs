internal class WebConnectionData // TypeDefIndex: 3030
{
	private HttpWebRequest _request; 
	public int StatusCode; 
	public string StatusDescription; 
	public WebHeaderCollection Headers; 
	public Version Version; 
	public Version ProxyVersion; 
	public Stream stream; 
	public string[] Challenge; 
	private ReadState _readState; 

	public HttpWebRequest request { get; set; }
	public ReadState ReadState { get; set; }


	public void .ctor() { }

	public void .ctor(HttpWebRequest request) { }

	public HttpWebRequest get_request() { }

	public void set_request(HttpWebRequest value) { }

	public ReadState get_ReadState() { }

	public void set_ReadState(ReadState value) { }

}

