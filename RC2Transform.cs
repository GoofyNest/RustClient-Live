internal class RC2Transform : SymmetricTransform // TypeDefIndex: 1007
{	// Fields
	private ushort R0; // 0x58
	private ushort R1; // 0x5A
	private ushort R2; // 0x5C
	private ushort R3; // 0x5E
	private ushort[] K; // 0x60
	private int j; // 0x68
	private static readonly byte[] pitable; // 0x0

	// Methods

	// RVA: 0x1700E40 Offset: 0x1700240 VA: 0x181700E40
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x16FFFE0 Offset: 0x16FF3E0 VA: 0x1816FFFE0 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1700DD0 Offset: 0x17001D0 VA: 0x181700DD0
	private static void .cctor() { }

}

