public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 973
{	protected int EffectiveKeySizeValue; // 0x48
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }


	protected void .ctor() { }

	public virtual int get_EffectiveKeySize() { }

	public override int get_KeySize() { }

	public override void set_KeySize(int value) { }

	public static RC2 Create() { }

	private static void .cctor() { }

}

