internal class DESTransform : SymmetricTransform // TypeDefIndex: 1004
{	internal static readonly int KEY_BIT_SIZE; // 0x0
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


	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	private uint CipherFunct(uint r, int n) { }

	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	private static void BSwap(byte[] byteBuff) { }

	internal void SetKey(byte[] key) { }

	public void ProcessBlock(byte[] input, byte[] output) { }

	protected override void ECB(byte[] input, byte[] output) { }

	internal static byte[] GetStrongKey() { }

	private static void .cctor() { }

}

