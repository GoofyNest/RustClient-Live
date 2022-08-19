internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 77
{	// Fields
	protected SymmetricAlgorithm algo; // 0x10
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

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x1752EC0 Offset: 0x17522C0 VA: 0x181752EC0
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x1599FF0 Offset: 0x15993F0 VA: 0x181599FF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17527C0 Offset: 0x1751BC0 VA: 0x1817527C0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1751D70 Offset: 0x1751170 VA: 0x181751D70 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x4BE1F0 Offset: 0x4BD5F0 VA: 0x1804BE1F0 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x1752CD0 Offset: 0x17520D0 VA: 0x181752CD0 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x1751800 Offset: 0x1750C00 VA: 0x181751800 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x1751980 Offset: 0x1750D80 VA: 0x181751980 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x1752690 Offset: 0x1751A90 VA: 0x181752690 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x1751BC0 Offset: 0x1750FC0 VA: 0x181751BC0 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x1751C20 Offset: 0x1751020 VA: 0x181751C20
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1752960 Offset: 0x1751D60 VA: 0x181752960 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17531F0 Offset: 0x17525F0 VA: 0x1817531F0
	private bool get_KeepLastBlock() { }

	// RVA: 0x17524B0 Offset: 0x17518B0 VA: 0x1817524B0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17526F0 Offset: 0x1751AF0 VA: 0x1817526F0
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x1752830 Offset: 0x1751C30 VA: 0x181752830
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x1752140 Offset: 0x1751540 VA: 0x181752140 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1751DF0 Offset: 0x17511F0 VA: 0x181751DF0 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1752BF0 Offset: 0x1751FF0 VA: 0x181752BF0 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

