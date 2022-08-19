public abstract class EndPoint // TypeDefIndex: 2873
{	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x155C8A0 Offset: 0x155BCA0 VA: 0x18155C8A0 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x155C860 Offset: 0x155BC60 VA: 0x18155C860 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x155C820 Offset: 0x155BC20 VA: 0x18155C820 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

