internal class AesTransform : SymmetricTransform // TypeDefIndex: 3196
{	// Fields
	private uint[] expandedKey; // 0x58
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

	// Methods

	// RVA: 0x2223660 Offset: 0x2222A60 VA: 0x182223660
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x221FB00 Offset: 0x221EF00 VA: 0x18221FB00 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x2223240 Offset: 0x2222640 VA: 0x182223240
	private uint SubByte(uint a) { }

	// RVA: 0x221FB30 Offset: 0x221EF30 VA: 0x18221FB30
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x221C430 Offset: 0x221B830 VA: 0x18221C430
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x2223350 Offset: 0x2222750 VA: 0x182223350
	private static void .cctor() { }

}

