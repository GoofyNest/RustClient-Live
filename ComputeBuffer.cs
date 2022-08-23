public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3549
{	internal IntPtr m_Ptr; // 0x10

	public int count { get; }


	protected override void Finalize() { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0xC9560 Offset: 0xC8960 VA: 0x1800C9560
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0xC9610 Offset: 0xC8A10 VA: 0x1800C9610
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

	[FreeFunctionAttribute] // RVA: 0xC9760 Offset: 0xC8B60 VA: 0x1800C9760
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute] // RVA: 0xC9840 Offset: 0xC8C40 VA: 0x1800C9840
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public void GetData(Array data) { }

	[FreeFunctionAttribute] // RVA: 0xC9920 Offset: 0xC8D20 VA: 0x1800C9920
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }

	public IntPtr GetNativeBufferPtr() { }

}

