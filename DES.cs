public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 953
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x16F9F80 Offset: 0x16F9380 VA: 0x1816F9F80
	protected void .ctor() { }

	// RVA: 0x16FA030 Offset: 0x16F9430 VA: 0x1816FA030 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x16FA130 Offset: 0x16F9530 VA: 0x1816FA130 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x16F9970 Offset: 0x16F8D70 VA: 0x1816F9970
	public static DES Create() { }

	// RVA: 0x16F9B90 Offset: 0x16F8F90 VA: 0x1816F9B90
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x16F99E0 Offset: 0x16F8DE0 VA: 0x1816F99E0
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x16F99C0 Offset: 0x16F8DC0 VA: 0x1816F99C0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x16F9CB0 Offset: 0x16F90B0 VA: 0x1816F9CB0
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x16F9DF0 Offset: 0x16F91F0 VA: 0x1816F9DF0
	private static void .cctor() { }

}

