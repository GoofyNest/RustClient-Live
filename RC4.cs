internal abstract class RC4 : SymmetricAlgorithm // TypeDefIndex: 74
{	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	public override byte[] IV { get; set; }


	public void .ctor() { }

	public override byte[] get_IV() { }

	public override void set_IV(byte[] value) { }

	public static RC4 Create() { }

	private static void .cctor() { }

}

