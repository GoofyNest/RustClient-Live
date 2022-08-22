public struct UdpReceiveResult : IEquatable<UdpReceiveResult> // TypeDefIndex: 3061
{	private byte[] m_buffer; // 0x0
	private IPEndPoint m_remoteEndPoint; // 0x8

	public byte[] Buffer { get; }


	public void .ctor(byte[] buffer, IPEndPoint remoteEndPoint) { }

	public byte[] get_Buffer() { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(UdpReceiveResult other) { }

}

