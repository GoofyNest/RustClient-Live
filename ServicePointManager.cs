public class ServicePointManager // TypeDefIndex: 3019
{
	private static HybridDictionary servicePoints; 
	private static ICertificatePolicy policy; 
	private static int defaultConnectionLimit; 
	private static int maxServicePointIdleTime; 
	private static int maxServicePoints; 
	private static int dnsRefreshTimeout; 
	private static bool _checkCRL; 
	private static SecurityProtocolType _securityProtocol; 
	private static bool expectContinue; 
	private static bool useNagle; 
	private static ServerCertValidationCallback server_cert_cb; 
	private static bool tcp_keepalive; 
	private static int tcp_keepalive_time; 
	private static int tcp_keepalive_interval; 

	[MonoTODOAttribute] 
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
{
	private Uri uri; 
	private Uri proxy; 
	private bool use_connect; 

public bool UsesProxy { get; }


public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

public bool get_UsesProxy() { }

public override int GetHashCode() { }

public override bool Equals(object obj) { }

}

