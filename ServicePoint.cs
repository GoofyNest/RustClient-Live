public class ServicePoint // TypeDefIndex: 3018
{	// Fields
	private readonly Uri uri; // 0x10
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

	// Properties
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

	// Methods

	// RVA: 0xFF9EC0 Offset: 0xFF92C0 VA: 0x180FF9EC0
	internal void .ctor(Uri uri, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public Uri get_Address() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_ConnectionLimit() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x5ABEA0 Offset: 0x5AB2A0 VA: 0x1805ABEA0
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x82A660 Offset: 0x829A60 VA: 0x18082A660
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0xE64690 Offset: 0xE63A90 VA: 0x180E64690
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0xFFA5A0 Offset: 0xFF99A0 VA: 0x180FFA5A0
	internal bool get_SendContinue() { }

	// RVA: 0x5ABEA0 Offset: 0x5AB2A0 VA: 0x1805ABEA0
	internal void set_SendContinue(bool value) { }

	// RVA: 0xFF9D50 Offset: 0xFF9150 VA: 0x180FF9D50
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0xFF9750 Offset: 0xFF8B50 VA: 0x180FF9750
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0xFF9930 Offset: 0xFF8D30 VA: 0x180FF9930
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x4B9270 Offset: 0x4B8670 VA: 0x1804B9270
	internal bool get_UsesProxy() { }

	// RVA: 0x4B9470 Offset: 0x4B8870 VA: 0x1804B9470
	internal void set_UsesProxy(bool value) { }

	// RVA: 0xAF1470 Offset: 0xAF0870 VA: 0x180AF1470
	internal bool get_UseConnect() { }

	// RVA: 0xFFA690 Offset: 0xFF9A90 VA: 0x180FFA690
	internal void set_UseConnect(bool value) { }

	// RVA: 0xFF95E0 Offset: 0xFF89E0 VA: 0x180FF95E0
	private WebConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0xFF9AF0 Offset: 0xFF8EF0 VA: 0x180FF9AF0
	private void RemoveConnectionGroup(WebConnectionGroup group) { }

	// RVA: 0xFF8F30 Offset: 0xFF8330 VA: 0x180FF8F30
	private bool CheckAvailableForRecycling(out DateTime outIdleSince) { }

	// RVA: 0xFF9730 Offset: 0xFF8B30 VA: 0x180FF9730
	private void IdleTimerCallback(object obj) { }

	// RVA: 0xFF9FA0 Offset: 0xFF93A0 VA: 0x180FF9FA0
	private bool get_HasTimedOut() { }

	// RVA: 0xFFA0E0 Offset: 0xFF94E0 VA: 0x180FFA0E0
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	internal void SetVersion(Version version) { }

	// RVA: 0xFF9B90 Offset: 0xFF8F90 VA: 0x180FF9B90
	internal EventHandler SendRequest(HttpWebRequest request, string groupName) { }

	// RVA: 0xFF94E0 Offset: 0xFF88E0 VA: 0x180FF94E0
	public bool CloseConnectionGroup(string connectionGroupName) { }

	// RVA: 0xFF9E80 Offset: 0xFF9280 VA: 0x180FF9E80
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0xFF9E40 Offset: 0xFF9240 VA: 0x180FF9E40
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0xFF8E20 Offset: 0xFF8220 VA: 0x180FF8E20
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFF9E30 Offset: 0xFF9230 VA: 0x180FF9E30
	private void <GetConnectionGroup>b__66_0(object s, EventArgs e) { }

}

