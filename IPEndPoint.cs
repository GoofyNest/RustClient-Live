public class IPEndPoint : EndPoint // TypeDefIndex: 2883
{
	public const int MinPort = 0;
	public const int MaxPort = 65535;
	private IPAddress m_Address;
	private int m_Port;
	internal const int AnyPort = 0;
	internal static IPEndPoint Any;
	internal static IPEndPoint IPv6Any;

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

