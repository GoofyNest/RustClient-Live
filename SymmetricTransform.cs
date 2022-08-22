internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 77
{	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }


	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	protected override void Finalize() { }

	private void System.IDisposable.Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual bool get_CanTransformMultipleBlocks() { }

	public virtual int get_InputBlockSize() { }

	public virtual int get_OutputBlockSize() { }

	protected virtual void Transform(byte[] input, byte[] output) { }

	protected abstract void ECB(byte[] input, byte[] output);

	protected virtual void CBC(byte[] input, byte[] output) { }

	protected virtual void CFB(byte[] input, byte[] output) { }

	protected virtual void OFB(byte[] input, byte[] output) { }

	protected virtual void CTS(byte[] input, byte[] output) { }

	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	private bool get_KeepLastBlock() { }

	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	private void Random(byte[] buffer, int start, int length) { }

	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

