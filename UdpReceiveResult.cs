public struct UdpReceiveResult : IEquatable<UdpReceiveResult> // TypeDefIndex: 3061
{	// Fields
	private byte[] m_buffer; // 0x0
	private IPEndPoint m_remoteEndPoint; // 0x8

	// Properties
	public byte[] Buffer { get; }

	// Methods

	// RVA: 0x14CC60 Offset: 0x14C060 VA: 0x18014CC60
	public void .ctor(byte[] buffer, IPEndPoint remoteEndPoint) { }

	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public byte[] get_Buffer() { }

	// RVA: 0x14CBF0 Offset: 0x14BFF0 VA: 0x18014CBF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14CB40 Offset: 0x14BF40 VA: 0x18014CB40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14CAE0 Offset: 0x14BEE0 VA: 0x18014CAE0 Slot: 4
	public bool Equals(UdpReceiveResult other) { }

}

