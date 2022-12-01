private sealed class DefaultArrayPool.Bucket<T> // TypeDefIndex: 6280
{
	internal readonly int _bufferLength;
	private readonly T[][] _buffers;
	private readonly int _poolId;
	private SpinLock _lock;
	private int _index;

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

