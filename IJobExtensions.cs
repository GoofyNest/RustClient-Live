public static class IJobExtensions // TypeDefIndex: 3299
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA0400 Offset: 0x1A9F800 VA: 0x181AA0400
	|-IJobExtensions.Schedule<SimulatePositionsJob>
	*/

}

internal struct IJobExtensions.JobStruct<T> // TypeDefIndex: 3300
{	// Fields
	public static IntPtr jobReflectionData; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A7C90 Offset: 0x17A7090 VA: 0x1817A7C90
	|-IJobExtensions.JobStruct<SimulatePositionsJob>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A7C80 Offset: 0x17A7080 VA: 0x1817A7C80
	|-IJobExtensions.JobStruct<SimulatePositionsJob>.Execute
	*/

}

public sealed class IJobExtensions.JobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 3301
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A60D0 Offset: 0x17A54D0 VA: 0x1817A60D0
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A5FD0 Offset: 0x17A53D0 VA: 0x1817A5FD0
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A60B0 Offset: 0x17A54B0 VA: 0x1817A60B0
	|-IJobExtensions.JobStruct.ExecuteJobFunction<SimulatePositionsJob>.EndInvoke
	*/

}

