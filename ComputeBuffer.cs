public sealed class ComputeBuffer : IDisposable // TypeDefIndex: 3549
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public int count { get; }

	// Methods

	// RVA: 0x18206A0 Offset: 0x181FAA0 VA: 0x1818206A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1820480 Offset: 0x181F880 VA: 0x181820480 Slot: 4
	public void Dispose() { }

	// RVA: 0x1820520 Offset: 0x181F920 VA: 0x181820520
	private void Dispose(bool disposing) { }

	[FreeFunctionAttribute] // RVA: 0xC9560 Offset: 0xC8960 VA: 0x1800C9560
	// RVA: 0x1820950 Offset: 0x181FD50 VA: 0x181820950
	private static IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage) { }

	[FreeFunctionAttribute] // RVA: 0xC9610 Offset: 0xC8A10 VA: 0x1800C9610
	// RVA: 0x1820440 Offset: 0x181F840 VA: 0x181820440
	private static void DestroyBuffer(ComputeBuffer buf) { }

	// RVA: 0x1821090 Offset: 0x1820490 VA: 0x181821090
	public void .ctor(int count, int stride) { }

	// RVA: 0x18210C0 Offset: 0x18204C0 VA: 0x1818210C0
	public void .ctor(int count, int stride, ComputeBufferType type) { }

	// RVA: 0x1820F80 Offset: 0x1820380 VA: 0x181820F80
	internal void .ctor(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth) { }

	// RVA: 0x1820480 Offset: 0x181F880 VA: 0x181820480
	public void Release() { }

	// RVA: 0x18210F0 Offset: 0x18204F0 VA: 0x1818210F0
	public int get_count() { }

	// RVA: 0x1820B00 Offset: 0x181FF00 VA: 0x181820B00
	public void SetData(Array data) { }

	// RVA: 0x1820CE0 Offset: 0x18200E0 VA: 0x181820CE0
	public void SetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count) { }

	// RVA: -1 Offset: -1
	public void SetData<T>(NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E4E70 Offset: 0x5E4270 VA: 0x1805E4E70
	|-ComputeBuffer.SetData<uint>
	|
	|-RVA: 0x5E5000 Offset: 0x5E4400 VA: 0x1805E5000
	|-ComputeBuffer.SetData<Vector4>
	*/

	[FreeFunctionAttribute] // RVA: 0xC9760 Offset: 0xC8B60 VA: 0x1800C9760
	// RVA: 0x1820A90 Offset: 0x181FE90 VA: 0x181820A90
	private void InternalSetNativeData(IntPtr data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	[FreeFunctionAttribute] // RVA: 0xC9840 Offset: 0xC8C40 VA: 0x1800C9840
	// RVA: 0x1820A20 Offset: 0x181FE20 VA: 0x181820A20
	private void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x1820730 Offset: 0x181FB30 VA: 0x181820730
	public void GetData(Array data) { }

	[FreeFunctionAttribute] // RVA: 0xC9920 Offset: 0xC8D20 VA: 0x1800C9920
	// RVA: 0x18209B0 Offset: 0x181FDB0 VA: 0x1818209B0
	private void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize) { }

	// RVA: 0x18203E0 Offset: 0x181F7E0 VA: 0x1818203E0
	public static void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes) { }

	// RVA: 0x1820910 Offset: 0x181FD10 VA: 0x181820910
	public IntPtr GetNativeBufferPtr() { }

}

