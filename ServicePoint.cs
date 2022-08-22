public class ServicePoint // TypeDefIndex: 3018
{	private readonly Uri uri; // 0x10
	private int connectionLimit; // 0x18
	private int maxIdleTime; // 0x1C
	private int currentConnections; // 0x20
	private DateTime idleSince; // 0x28
	private DateTime lastDnsResolve; // 0x30
	private Version protocolVersion; // 0x38
	private IPHostEntry host; // 0x40
	private bool usesProxy; // 0x48
	private Dictionary<string, WebConnectionGroup> groups; // 0x50
	private bool sendContinue; // 0x58
	private bool useConnect; // 0x59
	private object hostE; // 0x60
	private bool useNagle; // 0x68
	private BindIPEndPoint endPointCallback; // 0x70
	private bool tcp_keepalive; // 0x78
	private int tcp_keepalive_time; // 0x7C
	private int tcp_keepalive_interval; // 0x80
	private Timer idleTimer; // 0x88
	private object m_ServerCertificateOrBytes; // 0x90
	private object m_ClientCertificateOrBytes; // 0x98

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <GetConnectionGroup>b__66_0(object s, EventArgs e) { }

}

