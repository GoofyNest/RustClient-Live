public class ServicePointManager // TypeDefIndex: 3019
{	// Fields
	private static HybridDictionary servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties
	[MonoTODOAttribute] // RVA: 0xB8A50 Offset: 0xB7E50 VA: 0x1800B8A50
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { set; }

	// Methods

	// RVA: 0xFF8A80 Offset: 0xFF7E80 VA: 0x180FF8A80
	private static void .cctor() { }

	// RVA: 0xFF8A20 Offset: 0xFF7E20 VA: 0x180FF8A20
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0xFF8B70 Offset: 0xFF7F70 VA: 0x180FF8B70
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0xFF8BD0 Offset: 0xFF7FD0 VA: 0x180FF8BD0
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0xFF8C30 Offset: 0xFF8030 VA: 0x180FF8C30
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0xFF8C90 Offset: 0xFF8090 VA: 0x180FF8C90
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0xFF8CF0 Offset: 0xFF80F0 VA: 0x180FF8CF0
	public static void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	// RVA: 0xFF8240 Offset: 0xFF7640 VA: 0x180FF8240
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0xFF7F30 Offset: 0xFF7330 VA: 0x180FF7F30
	internal static void CloseConnectionGroup(string connectionGroupName) { }

}

private class ServicePointManager.SPKey // TypeDefIndex: 3020
{	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Properties
	public bool UsesProxy { get; }

	// Methods

	// RVA: 0xFF6C00 Offset: 0xFF6000 VA: 0x180FF6C00
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0xFF6C60 Offset: 0xFF6060 VA: 0x180FF6C60
	public bool get_UsesProxy() { }

	// RVA: 0xFF6B20 Offset: 0xFF5F20 VA: 0x180FF6B20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xFF6A00 Offset: 0xFF5E00 VA: 0x180FF6A00 Slot: 0
	public override bool Equals(object obj) { }

}

