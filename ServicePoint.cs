public class ServicePoint // TypeDefIndex: 3018
{
	private readonly Uri uri; 
	private int connectionLimit; 
	private int maxIdleTime; 
	private int currentConnections; 
	private DateTime idleSince; 
	private DateTime lastDnsResolve; 
	private Version protocolVersion; 
	private IPHostEntry host; 
	private bool usesProxy; 
	private Dictionary<string, WebConnectionGroup> groups; 
	private bool sendContinue; 
	private bool useConnect; 
	private object hostE; 
	private bool useNagle; 
	private BindIPEndPoint endPointCallback; 
	private bool tcp_keepalive; 
	private int tcp_keepalive_time; 
	private int tcp_keepalive_interval; 
	private Timer idleTimer; 
	private object m_ServerCertificateOrBytes; 
	private object m_ClientCertificateOrBytes; 

	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }


	internal void .ctor(Uri uri, int connectionLimit, int maxIdleTime) { }

	public Uri get_Address() { }

	public int get_ConnectionLimit() { }

	public virtual Version get_ProtocolVersion() { }

	public void set_Expect100Continue(bool value) { }

	public bool get_UseNagleAlgorithm() { }

	public void set_UseNagleAlgorithm(bool value) { }

	internal bool get_SendContinue() { }

	internal void set_SendContinue(bool value) { }

	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	internal void KeepAliveSetup(Socket socket) { }

	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	internal bool get_UsesProxy() { }

	internal void set_UsesProxy(bool value) { }

	internal bool get_UseConnect() { }

	internal void set_UseConnect(bool value) { }

	private WebConnectionGroup GetConnectionGroup(string name) { }

	private void RemoveConnectionGroup(WebConnectionGroup group) { }

	private bool CheckAvailableForRecycling(out DateTime outIdleSince) { }

	private void IdleTimerCallback(object obj) { }

	private bool get_HasTimedOut() { }

	internal IPHostEntry get_HostEntry() { }

	internal void SetVersion(Version version) { }

	internal EventHandler SendRequest(HttpWebRequest request, string groupName) { }

	public bool CloseConnectionGroup(string connectionGroupName) { }

	internal void UpdateServerCertificate(X509Certificate certificate) { }

	internal void UpdateClientCertificate(X509Certificate certificate) { }

	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	[CompilerGeneratedAttribute] 
	private void <GetConnectionGroup>

}

