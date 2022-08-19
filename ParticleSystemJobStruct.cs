public sealed class ParticleSystemJobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 4556
{	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref T data, IntPtr listDataPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A60D0 Offset: 0x17A54D0 VA: 0x1817A60D0
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(ref T data, IntPtr listDataPtr, IntPtr unusedPtr, ref JobRanges ranges, int jobIndex, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B7380 Offset: 0x19B6780 VA: 0x1819B7380
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(ref T data, ref JobRanges ranges, IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17A60B0 Offset: 0x17A54B0 VA: 0x1817A60B0
	|-ParticleSystemJobStruct.ExecuteJobFunction<ParticleSystemIK.ParticleSystemIKJob>.EndInvoke
	*/

}

