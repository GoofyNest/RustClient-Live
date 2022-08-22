public class ServicePointManager // TypeDefIndex: 3019
{	private static HybridDictionary servicePoints; // 0x0
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

	[MonoTODOAttribute] // RVA: 0xB8A50 Offset: 0xB7E50 VA: 0x1800B8A50
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { set; }


	private static void .cctor() { }

	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	public static bool get_CheckCertificateRevocationList() { }

	public static int get_DnsRefreshTimeout() { }

	public static SecurityProtocolType get_SecurityProtocol() { }

	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	public static void set_ServerCertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	internal static void CloseConnectionGroup(string connectionGroupName) { }

}

private class ServicePointManager.SPKey // TypeDefIndex: 3020
{	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	public bool UsesProxy { get; }


	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	public bool get_UsesProxy() { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

}

