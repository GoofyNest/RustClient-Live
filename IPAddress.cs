public class IPAddress // TypeDefIndex: 2882
{	// Fields
	public static readonly IPAddress Any; // 0x0
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

	// Properties
	[ObsoleteAttribute] // RVA: 0xB35B0 Offset: 0xB29B0 VA: 0x1800B35B0
	public long Address { get; }
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }
	internal bool IsBroadcast { get; }

	// Methods

	// RVA: 0x133EA20 Offset: 0x133DE20 VA: 0x18133EA20
	public void .ctor(long newAddress) { }

	// RVA: 0x133E700 Offset: 0x133DB00 VA: 0x18133E700
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x133E910 Offset: 0x133DD10 VA: 0x18133E910
	private void .ctor(ushort[] address, uint scopeid) { }

	// RVA: 0x133E9B0 Offset: 0x133DDB0 VA: 0x18133E9B0
	internal void .ctor(int newAddress) { }

	// RVA: 0x133E3D0 Offset: 0x133D7D0 VA: 0x18133E3D0
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x133E0E0 Offset: 0x133D4E0 VA: 0x18133E0E0
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x133DB70 Offset: 0x133CF70 VA: 0x18133DB70
	private static IPAddress InternalParse(string ipString, bool tryParse) { }

	// RVA: 0x133EAD0 Offset: 0x133DED0 VA: 0x18133EAD0
	public long get_Address() { }

	// RVA: 0x133D8C0 Offset: 0x133CCC0 VA: 0x18133D8C0
	public byte[] GetAddressBytes() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x133EBD0 Offset: 0x133DFD0 VA: 0x18133EBD0
	public long get_ScopeId() { }

	// RVA: 0x133E140 Offset: 0x133D540 VA: 0x18133E140 Slot: 3
	public override string ToString() { }

	// RVA: 0x133DEB0 Offset: 0x133D2B0 VA: 0x18133DEB0
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x133EB40 Offset: 0x133DF40 VA: 0x18133EB40
	internal bool get_IsBroadcast() { }

	// RVA: 0x133D780 Offset: 0x133CB80 VA: 0x18133D780
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x133D8B0 Offset: 0x133CCB0 VA: 0x18133D8B0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x133DA70 Offset: 0x133CE70 VA: 0x18133DA70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x133DFB0 Offset: 0x133D3B0 VA: 0x18133DFB0
	public IPAddress MapToIPv6() { }

	// RVA: 0x133E450 Offset: 0x133D850 VA: 0x18133E450
	private static void .cctor() { }

}

