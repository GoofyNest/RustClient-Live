private sealed class DefaultArrayPool.Bucket<T> // TypeDefIndex: 6271
{	internal readonly int _bufferLength; // 0x0
	private readonly T[][] _buffers; // 0x0
	private readonly int _poolId; // 0x0
	private SpinLock _lock; // 0x0
	private int _index; // 0x0

	internal int Id { get; }


	internal void .ctor(int bufferLength, int numberOfBuffers, int poolId) { }
	/* GenericInstMethod :
	|
	|-DefaultArrayPool.Bucket<byte>..ctor
	|
	|-DefaultArrayPool.Bucket<object>..ctor
	*/

	internal int get_Id() { }
	/* GenericInstMethod :
	|
	|-DefaultArrayPool.Bucket<byte>.get_Id
	|-DefaultArrayPool.Bucket<object>.get_Id
	*/

	internal T[] Rent() { }
	/* GenericInstMethod :
	|
	|-DefaultArrayPool.Bucket<byte>.Rent
	|
	|-DefaultArrayPool.Bucket<object>.Rent
	*/

	internal void Return(T[] array) { }
	/* GenericInstMethod :
	|
	|-DefaultArrayPool.Bucket<byte>.Return
	|
	|-DefaultArrayPool.Bucket<object>.Return
	*/

}

