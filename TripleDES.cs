public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 1000
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x17C39B0 Offset: 0x17C2DB0 VA: 0x1817C39B0
	protected void .ctor() { }

	// RVA: 0x17C3A70 Offset: 0x17C2E70 VA: 0x1817C3A70 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x17C3B40 Offset: 0x17C2F40 VA: 0x1817C3B40 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x17C32A0 Offset: 0x17C26A0 VA: 0x1817C32A0
	public static TripleDES Create() { }

	// RVA: 0x17C35E0 Offset: 0x17C29E0 VA: 0x1817C35E0
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x17C33C0 Offset: 0x17C27C0 VA: 0x1817C33C0
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x17C35C0 Offset: 0x17C29C0 VA: 0x1817C35C0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x17C3810 Offset: 0x17C2C10 VA: 0x1817C3810
	private static void .cctor() { }

}

