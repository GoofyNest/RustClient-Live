internal struct UpdateTransformsJob : IJobParallelForTransform // TypeDefIndex: 7321
{	[ReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public NativeArray<BoneData> Data; // 0x0
	[ReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public NativeArray<BoneState> State; // 0x10


	public void Execute(int index, TransformAccess transform) { }

}

