internal struct SimulatePositionsJob : IJob // TypeDefIndex: 7320
{	[ReadOnlyAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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


	public void Execute() { }

	private void AdjustSimulationSpace() { }

	private void MovePositions() { }

	private void ApplyPositionConstraints(NativeArray<float3> newPositions) { }

	private void ResolveCollisions() { }

	private void ApplyRotationConstraints() { }

	private float3 RayMarch(in float3 origin, in float3 direction, float radius, float maxDistance) { }

	private float Scene(in float3 position) { }

	private static float Union(float d1, float d2) { }

	private static float Capsule(in float3 p, in float3 a, in float3 b, float r) { }

	private static float3 Slerp(float3 a, float3 b, float t) { }

	private static quaternion FromToRotation(float3 from, float3 to) { }

}

