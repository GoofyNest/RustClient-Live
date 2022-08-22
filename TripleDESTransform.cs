internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 1013
{	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80


	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	protected override void ECB(byte[] input, byte[] output) { }

	internal static byte[] GetStrongKey() { }

}

