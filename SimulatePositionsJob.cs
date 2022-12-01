internal struct SimulatePositionsJob : IJob // TypeDefIndex: 7334
{
	[ReadOnlyAttribute]
	public NativeArray<ColliderData> ColliderData;
	[ReadOnlyAttribute]
	public NativeArray<ColliderState> ColliderState;
	[ReadOnlyAttribute]
	public NativeArray<BoneData> BoneData;
	public NativeArray<BoneState> BoneState;
	public int TickRate;
	public float DeltaTime;
	public int IterationCount;
	public float3 SimulationSpaceDelta;
	public float3 Gravity;
	public int StiffnessDepth;
	public float LengthModifier;
	public bool SiblingConstraints;
	public bool EnableCollisions;
	public float3 Origin;
	public quaternion Rotation;
	public float3 Up;
	public float Radius;


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

