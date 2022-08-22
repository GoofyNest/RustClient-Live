internal class AesTransform : SymmetricTransform // TypeDefIndex: 3196
{	private uint[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly uint[] Rcon; // 0x0
	private static readonly byte[] SBox; // 0x8
	private static readonly byte[] iSBox; // 0x10
	private static readonly uint[] T0; // 0x18
	private static readonly uint[] T1; // 0x20
	private static readonly uint[] T2; // 0x28
	private static readonly uint[] T3; // 0x30
	private static readonly uint[] iT0; // 0x38
	private static readonly uint[] iT1; // 0x40
	private static readonly uint[] iT2; // 0x48
	private static readonly uint[] iT3; // 0x50


	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	protected override void ECB(byte[] input, byte[] output) { }

	private uint SubByte(uint a) { }

	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	private static void .cctor() { }

}

