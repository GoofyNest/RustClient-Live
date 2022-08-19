internal struct SimulatePositionsJob : IJob // TypeDefIndex: 7320
{	// Fields
	[ReadOnlyAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public NativeArray<ColliderData> ColliderData; // 0x0
	[ReadOnlyAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public NativeArray<ColliderState> ColliderState; // 0x10
	[ReadOnlyAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public NativeArray<BoneData> BoneData; // 0x20
	public NativeArray<BoneState> BoneState; // 0x30
	public int TickRate; // 0x40
	public float DeltaTime; // 0x44
	public int IterationCount; // 0x48
	public float3 SimulationSpaceDelta; // 0x4C
	public float3 Gravity; // 0x58
	public int StiffnessDepth; // 0x64
	public float LengthModifier; // 0x68
	public bool SiblingConstraints; // 0x6C
	public bool EnableCollisions; // 0x6D
	public float3 Origin; // 0x70
	public quaternion Rotation; // 0x7C
	public float3 Up; // 0x8C
	public float Radius; // 0x98

	// Methods

	// RVA: 0x237D90 Offset: 0x237190 VA: 0x180237D90 Slot: 4
	public void Execute() { }

	// RVA: 0x237D50 Offset: 0x237150 VA: 0x180237D50
	private void AdjustSimulationSpace() { }

	// RVA: 0x237DA0 Offset: 0x2371A0 VA: 0x180237DA0
	private void MovePositions() { }

	// RVA: 0x237D60 Offset: 0x237160 VA: 0x180237D60
	private void ApplyPositionConstraints(NativeArray<float3> newPositions) { }

	// RVA: 0x237DF0 Offset: 0x2371F0 VA: 0x180237DF0
	private void ResolveCollisions() { }

	// RVA: 0x237D80 Offset: 0x237180 VA: 0x180237D80
	private void ApplyRotationConstraints() { }

	// RVA: 0x237DB0 Offset: 0x2371B0 VA: 0x180237DB0
	private float3 RayMarch(in float3 origin, in float3 direction, float radius, float maxDistance) { }

	// RVA: 0x237E00 Offset: 0x237200 VA: 0x180237E00
	private float Scene(in float3 position) { }

	// RVA: 0x22398F0 Offset: 0x2238CF0 VA: 0x1822398F0
	private static float Union(float d1, float d2) { }

	// RVA: 0x22384C0 Offset: 0x22378C0 VA: 0x1822384C0
	private static float Capsule(in float3 p, in float3 a, in float3 b, float r) { }

	// RVA: 0x22397A0 Offset: 0x2238BA0 VA: 0x1822397A0
	private static float3 Slerp(float3 a, float3 b, float t) { }

	// RVA: 0x2238780 Offset: 0x2237B80 VA: 0x182238780
	private static quaternion FromToRotation(float3 from, float3 to) { }

}

