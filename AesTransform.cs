internal class AesTransform : SymmetricTransform // TypeDefIndex: 3196
{
	private uint[] expandedKey; 
	private int Nk; 
	private int Nr; 
	private static readonly uint[] Rcon; 
	private static readonly byte[] SBox; 
	private static readonly byte[] iSBox; 
	private static readonly uint[] T0; 
	private static readonly uint[] T1; 
	private static readonly uint[] T2; 
	private static readonly uint[] T3; 
	private static readonly uint[] iT0; 
	private static readonly uint[] iT1; 
	private static readonly uint[] iT2; 
	private static readonly uint[] iT3; 


	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	protected override void ECB(byte[] input, byte[] output) { }

	private uint SubByte(uint a) { }

	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	private static void .cctor() { }

}

