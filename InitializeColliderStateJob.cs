internal struct InitializeColliderStateJob : IJobParallelForTransform // TypeDefIndex: 7319
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public NativeArray<ColliderData> Data; // 0x0
	[WriteOnlyAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[NativeMatchesParallelForLengthAttribute] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	public NativeArray<ColliderState> State; // 0x10

	// Methods

	// RVA: 0x237D30 Offset: 0x237130 VA: 0x180237D30 Slot: 4
	public void Execute(int index, TransformAccess transform) { }

}

