public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 953
{	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	public override byte[] Key { get; set; }


	protected void .ctor() { }

	public override byte[] get_Key() { }

	public override void set_Key(byte[] value) { }

	public static DES Create() { }

	public static bool IsWeakKey(byte[] rgbKey) { }

	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	private static bool IsLegalKeySize(byte[] rgbKey) { }

	private static ulong QuadWordFromBigEndian(byte[] block) { }

	private static void .cctor() { }

}

