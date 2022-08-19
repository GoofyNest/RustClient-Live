public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 978
{	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x17B5580 Offset: 0x17B4980 VA: 0x1817B5580
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x17B3210 Offset: 0x17B2610 VA: 0x1817B3210 Slot: 9
	public void Dispose() { }

	// RVA: 0x17B3320 Offset: 0x17B2720 VA: 0x1817B3320
	private void Dispose(bool disposing) { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x17B4CD0 Offset: 0x17B40D0 VA: 0x1817B4CD0 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17B5080 Offset: 0x17B4480 VA: 0x1817B5080 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17B4B40 Offset: 0x17B3F40 VA: 0x1817B4B40
	public void Reset() { }

	// RVA: 0x17B3630 Offset: 0x17B2A30 VA: 0x1817B3630
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x17B2330 Offset: 0x17B1730 VA: 0x1817B2330
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x17B3430 Offset: 0x17B2830 VA: 0x1817B3430
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x17B20F0 Offset: 0x17B14F0 VA: 0x1817B20F0
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x17B4400 Offset: 0x17B3800 VA: 0x1817B4400
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x17B5C40 Offset: 0x17B5040 VA: 0x1817B5C40
	private static int rot1(int val) { }

	// RVA: 0x17B5C50 Offset: 0x17B5050 VA: 0x1817B5C50
	private static int rot2(int val) { }

	// RVA: 0x17B5C60 Offset: 0x17B5060 VA: 0x1817B5C60
	private static int rot3(int val) { }

	// RVA: 0x17B4BC0 Offset: 0x17B3FC0 VA: 0x1817B4BC0
	private static int SubWord(int a) { }

	// RVA: 0x17B4B10 Offset: 0x17B3F10 VA: 0x1817B4B10
	private static int MulX(int x) { }

	// RVA: 0x17B53C0 Offset: 0x17B47C0 VA: 0x1817B53C0
	private static void .cctor() { }

}

