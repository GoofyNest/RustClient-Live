public class IPEndPoint : EndPoint // TypeDefIndex: 2883
{	public const int MinPort = 0;
	public const int MaxPort = 65535;
	private IPAddress m_Address; // 0x10
	private int m_Port; // 0x18
	internal const int AnyPort = 0;
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public int Port { get; }


	public override AddressFamily get_AddressFamily() { }

	public void .ctor(IPAddress address, int port) { }

	public IPAddress get_Address() { }

	public int get_Port() { }

	public override string ToString() { }

	public override SocketAddress Serialize() { }

	public override EndPoint Create(SocketAddress socketAddress) { }

	public override bool Equals(object comparand) { }

	public override int GetHashCode() { }

	private static void .cctor() { }

}

