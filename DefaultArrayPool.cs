private sealed class DefaultArrayPool.Bucket<T> // TypeDefIndex: 6271
{	// Fields
	internal readonly int _bufferLength; // 0x0
	private readonly T[][] _buffers; // 0x0
	private readonly int _poolId; // 0x0
	private SpinLock _lock; // 0x0
	private int _index; // 0x0

	// Properties
	internal int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int bufferLength, int numberOfBuffers, int poolId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19294B0 Offset: 0x19288B0 VA: 0x1819294B0
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-RVA: 0x19295A0 Offset: 0x19289A0 VA: 0x1819295A0
	|-DefaultArrayPool.Bucket<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xB9B5A0 Offset: 0xB9A9A0 VA: 0x180B9B5A0
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|-DefaultArrayPool.Bucket<object>.get_Id
	*/

	// RVA: -1 Offset: -1
	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1928EC0 Offset: 0x19282C0 VA: 0x181928EC0
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-RVA: 0x1928C50 Offset: 0x1928050 VA: 0x181928C50
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	// RVA: -1 Offset: -1
	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1929130 Offset: 0x1928530 VA: 0x181929130
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-RVA: 0x19292F0 Offset: 0x19286F0 VA: 0x1819292F0
	|-DefaultArrayPool.Bucket<object>.Return
	*/

}

