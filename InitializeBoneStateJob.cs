internal struct InitializeBoneStateJob : IJobParallelForTransform // TypeDefIndex: 7318
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public NativeArray<BoneData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public NativeArray<BoneState> State; // 0x10

	// Methods

	// RVA: 0x237D10 Offset: 0x237110 VA: 0x180237D10 Slot: 4
	public void Execute(int index, TransformAccess transform) { }

}

