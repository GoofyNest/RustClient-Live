public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3552
{
	internal IntPtr m_Ptr;

	public int count { get; }


	protected override void Finalize() { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute]
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute]
	private static void DestroyBuffer(ComputeBuffer buf) { }

	public void .ctor(int count, int stride) { }

	public void .ctor(int count, int stride, ComputeBufferType type) { }

	internal void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	public void Release() { }

	public int get_count() { }

	public void SetData(Array data) { }

	public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) { }
	/* GenericInstMethod :
	|
	|-ComputeBuffer.SetData<uint>
	|
	|-ComputeBuffer.SetData<Vector4>
	*/

	[FreeFunctionAttribute]
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute]
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public void GetData(Array data) { }

	[FreeFunctionAttribute]
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }

	public IntPtr GetNativeBufferPtr() { }

}

