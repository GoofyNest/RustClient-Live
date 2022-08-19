public class IPEndPoint : EndPoint // TypeDefIndex: 2883
{	// Fields
	public const int MinPort = 0;
	public const int MaxPort = 65535;
	private IPAddress m_Address; // 0x10
	private int m_Port; // 0x18
	internal const int AnyPort = 0;
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x133F460 Offset: 0x133E860 VA: 0x18133F460 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x133F370 Offset: 0x133E770 VA: 0x18133F370
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public IPAddress get_Address() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_Port() { }

	// RVA: 0x133F1D0 Offset: 0x133E5D0 VA: 0x18133F1D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x133F160 Offset: 0x133E560 VA: 0x18133F160 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x133EC40 Offset: 0x133E040 VA: 0x18133EC40 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x133EF50 Offset: 0x133E350 VA: 0x18133EF50 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x133F120 Offset: 0x133E520 VA: 0x18133F120 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x133F280 Offset: 0x133E680 VA: 0x18133F280
	private static void .cctor() { }

}

