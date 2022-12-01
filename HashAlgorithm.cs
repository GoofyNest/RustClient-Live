public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 959
{
	protected int HashSizeValue;
	protected internal byte[] HashValue;
	protected int State;
	private bool m_bDisposed;

	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }


	protected void .ctor() { }

	public virtual int get_HashSize() { }

	public virtual byte[] get_Hash() { }

	public byte[] ComputeHash(byte[] buffer) { }

	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	public virtual int get_InputBlockSize() { }

	public virtual int get_OutputBlockSize() { }

	public virtual bool get_CanTransformMultipleBlocks() { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	public void Dispose() { }

	public void Clear() { }

	protected virtual void Dispose(bool disposing) { }

	public abstract void Initialize();

	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	protected abstract byte[] HashFinal();

}

