public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 1000
{
	private static KeySizes[] s_legalBlockSizes; 
	private static KeySizes[] s_legalKeySizes; 

	public override byte[] Key { get; set; }


	protected void .ctor() { }

	public override byte[] get_Key() { }

	public override void set_Key(byte[] value) { }

	public static TripleDES Create() { }

	public static bool IsWeakKey(byte[] rgbKey) { }

	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	private static bool IsLegalKeySize(byte[] rgbKey) { }

	private static void .cctor() { }

}

