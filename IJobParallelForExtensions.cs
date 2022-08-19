public static class IJobParallelForExtensions // TypeDefIndex: 3303
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA04C0 Offset: 0x1A9F8C0 VA: 0x181AA04C0
	|-IJobParallelForExtensions.Schedule<MeshPaintable3D.DrawTextureJob>
	*/

}

internal struct IJobParallelForExtensions.ParallelForJobStruct<T> // TypeDefIndex: 3304
{	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8640 Offset: 0x17A7A40 VA: 0x1817A8640
	|-IJobParallelForExtensions.ParallelForJobStruct<MeshPaintable3D.DrawTextureJob>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A8590 Offset: 0x17A7990 VA: 0x1817A8590
	|-IJobParallelForExtensions.ParallelForJobStruct<MeshPaintable3D.DrawTextureJob>.Execute
	*/

}

public sealed class IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3305
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A60D0 Offset: 0x17A54D0 VA: 0x1817A60D0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A5EF0 Offset: 0x17A52F0 VA: 0x1817A5EF0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A60B0 Offset: 0x17A54B0 VA: 0x1817A60B0
	|-IJobParallelForExtensions.ParallelForJobStruct.ExecuteJobFunction<MeshPaintable3D.DrawTextureJob>.EndInvoke
	*/

}

