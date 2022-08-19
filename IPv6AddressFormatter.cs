internal struct IPv6AddressFormatter // TypeDefIndex: 3012
{
// Namespace: System.Net
internal struct IPv6AddressFormatter // TypeDefIndex: 3012
	// Fields
	private ushort[] address; // 0x0
	private long scopeId; // 0x8

	// Methods

	// RVA: 0x14C4B0 Offset: 0x14B8B0 VA: 0x18014C4B0
	public void .ctor(ushort[] addr, long scopeId) { }

	// RVA: 0x133F710 Offset: 0x133EB10 VA: 0x18133F710
	private static ushort SwapUShort(ushort number) { }

	// RVA: 0x1E1550 Offset: 0x1E0950 VA: 0x1801E1550
	private uint AsIPv4Int() { }

	// RVA: 0x1E15B0 Offset: 0x1E09B0 VA: 0x1801E15B0
	private bool IsIPv4Compatible() { }

	// RVA: 0x1E15C0 Offset: 0x1E09C0 VA: 0x1801E15C0
	private bool IsIPv4Mapped() { }

	// RVA: 0x1E15D0 Offset: 0x1E09D0 VA: 0x1801E15D0 Slot: 3
	public override string ToString() { }

}

