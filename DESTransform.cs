internal class DESTransform : SymmetricTransform // TypeDefIndex: 1004
{	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x16F9620 Offset: 0x16F8A20 VA: 0x1816F9620
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x16F7FC0 Offset: 0x16F73C0 VA: 0x1816F7FC0
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x16F84E0 Offset: 0x16F78E0 VA: 0x1816F84E0
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x16F7F10 Offset: 0x16F7310 VA: 0x1816F7F10
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x16F8F70 Offset: 0x16F8370 VA: 0x1816F8F70
	internal void SetKey(byte[] key) { }

	// RVA: 0x16F8AC0 Offset: 0x16F7EC0 VA: 0x1816F8AC0
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x16F8340 Offset: 0x16F7740 VA: 0x1816F8340 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x16F8410 Offset: 0x16F7810 VA: 0x1816F8410
	internal static byte[] GetStrongKey() { }

	// RVA: 0x16F9400 Offset: 0x16F8800 VA: 0x1816F9400
	private static void .cctor() { }

}

