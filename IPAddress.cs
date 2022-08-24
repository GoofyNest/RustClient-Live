public class IPAddress // TypeDefIndex: 2882
{
	public static readonly IPAddress Any; 
	public static readonly IPAddress Loopback; 
	public static readonly IPAddress Broadcast; 
	public static readonly IPAddress None; 
internal const long LoopbackMask = 255;
	internal long m_Address; 
	internal string m_ToString; 
	public static readonly IPAddress IPv6Any; 
	public static readonly IPAddress IPv6Loopback; 
	public static readonly IPAddress IPv6None; 
	private AddressFamily m_Family; 
	private ushort[] m_Numbers; 
	private long m_ScopeId; 
	private int m_HashCode; 
internal const int IPv4AddressBytes = 4;
internal const int IPv6AddressBytes = 16;
internal const int NumberOfLabels = 8;

	[ObsoleteAttribute] 
public long Address { get; }
public AddressFamily AddressFamily { get; }
public long ScopeId { get; }
internal bool IsBroadcast { get; }


public void .ctor(long newAddress) { }

public void .ctor(byte[] address, long scopeid) { }

private void .ctor(ushort[] address, uint scopeid) { }

internal void .ctor(int newAddress) { }

public static bool TryParse(string ipString, out IPAddress address) { }

public static IPAddress Parse(string ipString) { }

private static IPAddress InternalParse(string ipString, bool tryParse) { }

public long get_Address() { }

public byte[] GetAddressBytes() { }

public AddressFamily get_AddressFamily() { }

public long get_ScopeId() { }

public override string ToString() { }

public static bool IsLoopback(IPAddress address) { }

internal bool get_IsBroadcast() { }

internal bool Equals(object comparandObj, bool compareScopeId) { }

public override bool Equals(object comparand) { }

public override int GetHashCode() { }

public IPAddress MapToIPv6() { }

private static void .cctor() { }

}

