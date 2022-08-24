public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 973
{
	protected int EffectiveKeySizeValue; 
	private static KeySizes[] s_legalBlockSizes; 
	private static KeySizes[] s_legalKeySizes; 

	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }


	protected void .ctor() { }

	public virtual int get_EffectiveKeySize() { }

	public override int get_KeySize() { }

	public override void set_KeySize(int value) { }

	public static RC2 Create() { }

	private static void .cctor() { }

}

