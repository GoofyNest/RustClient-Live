internal abstract class RC4 : SymmetricAlgorithm // TypeDefIndex: 74
{	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] IV { get; set; }

	// Methods

	// RVA: 0x174F7E0 Offset: 0x174EBE0 VA: 0x18174F7E0
	public void .ctor() { }

	// RVA: 0x174F890 Offset: 0x174EC90 VA: 0x18174F890 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x174F510 Offset: 0x174E910 VA: 0x18174F510
	public static RC4 Create() { }

	// RVA: 0x174F640 Offset: 0x174EA40 VA: 0x18174F640
	private static void .cctor() { }

}

