public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 959
{	// Fields
	protected int HashSizeValue; // 0x10
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20
	private bool m_bDisposed; // 0x24

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x16FD530 Offset: 0x16FC930 VA: 0x1816FD530 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x16FCC50 Offset: 0x16FC050 VA: 0x1816FCC50
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x16FCDA0 Offset: 0x16FC1A0 VA: 0x1816FCDA0
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 14
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x16FD0B0 Offset: 0x16FC4B0 VA: 0x1816FD0B0 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x16FD2C0 Offset: 0x16FC6C0 VA: 0x1816FD2C0 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x16FD040 Offset: 0x16FC440 VA: 0x1816FD040 Slot: 4
	public void Dispose() { }

	// RVA: 0x16FCC10 Offset: 0x16FC010 VA: 0x1816FCC10
	public void Clear() { }

	// RVA: 0x16FCFF0 Offset: 0x16FC3F0 VA: 0x1816FCFF0 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract byte[] HashFinal();

}

