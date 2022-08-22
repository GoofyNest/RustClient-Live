public class IPAddress // TypeDefIndex: 2882
{	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	internal long m_Address; // 0x10
	internal string m_ToString; // 0x18
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private AddressFamily m_Family; // 0x20
	private ushort[] m_Numbers; // 0x28
	private long m_ScopeId; // 0x30
	private int m_HashCode; // 0x38
	internal const int IPv4AddressBytes = 4;
	internal const int IPv6AddressBytes = 16;
	internal const int NumberOfLabels = 8;

	[ObsoleteAttribute] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
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

