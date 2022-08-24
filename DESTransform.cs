internal class DESTransform : SymmetricTransform // TypeDefIndex: 1004
{
	internal static readonly int KEY_BIT_SIZE; 
	internal static readonly int KEY_BYTE_SIZE; 
	internal static readonly int BLOCK_BIT_SIZE; 
	internal static readonly int BLOCK_BYTE_SIZE; 
	private byte[] keySchedule; 
	private byte[] byteBuff; 
	private uint[] dwordBuff; 
	private static readonly uint[] spBoxes; 
	private static readonly byte[] PC1; 
	private static readonly byte[] leftRotTotal; 
	private static readonly byte[] PC2; 
	internal static readonly uint[] ipTab; 
	internal static readonly uint[] fpTab; 


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

