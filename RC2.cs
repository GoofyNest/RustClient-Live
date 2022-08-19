public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 973
{	// Fields
	protected int EffectiveKeySizeValue; // 0x48
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x17016E0 Offset: 0x1700AE0 VA: 0x1817016E0
	protected void .ctor() { }

	// RVA: 0x1701790 Offset: 0x1700B90 VA: 0x181701790 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x17017A0 Offset: 0x1700BA0 VA: 0x1817017A0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x17014F0 Offset: 0x17008F0 VA: 0x1817014F0
	public static RC2 Create() { }

	// RVA: 0x1701540 Offset: 0x1700940 VA: 0x181701540
	private static void .cctor() { }

}

