public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 978
{
	private CipherMode m_cipherMode; 
	private PaddingMode m_paddingValue; 
	private RijndaelManagedTransformMode m_transformMode; 
	private int m_blockSizeBits; 
	private int m_blockSizeBytes; 
	private int m_inputBlockSize; 
	private int m_outputBlockSize; 
	private int[] m_encryptKeyExpansion; 
	private int[] m_decryptKeyExpansion; 
	private int m_Nr; 
	private int m_Nb; 
	private int m_Nk; 
	private int[] m_encryptindex; 
	private int[] m_decryptindex; 
	private int[] m_IV; 
	private int[] m_lastBlockBuffer; 
	private byte[] m_depadBuffer; 
	private byte[] m_shiftRegister; 
	private static readonly byte[] s_Sbox; 
	private static readonly int[] s_Rcon; 
	private static readonly int[] s_T; 
	private static readonly int[] s_TF; 
	private static readonly int[] s_iT; 
	private static readonly int[] s_iTF; 

public int InputBlockSize { get; }
public int OutputBlockSize { get; }
public bool CanTransformMultipleBlocks { get; }


internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

public void Dispose() { }

private void Dispose(bool disposing) { }

public int get_InputBlockSize() { }

public int get_OutputBlockSize() { }

public bool get_CanTransformMultipleBlocks() { }

public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

public void Reset() { }

private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

private void GenerateKeyExpansion(byte[] rgbKey) { }

private static int rot1(int val) { }

private static int rot2(int val) { }

private static int rot3(int val) { }

private static int SubWord(int a) { }

private static int MulX(int x) { }

private static void .cctor() { }

}

