internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 1013
{	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x17C2F20 Offset: 0x17C2320 VA: 0x1817C2F20
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x17C2910 Offset: 0x17C1D10 VA: 0x1817C2910 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x17C2A90 Offset: 0x17C1E90 VA: 0x1817C2A90
	internal static byte[] GetStrongKey() { }

}

