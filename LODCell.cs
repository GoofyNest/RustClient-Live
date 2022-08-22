public class LODCell : Pool.IPooled // TypeDefIndex: 9928
{	public Vector3 Position; // 0x10
	public float Size; // 0x1C
	public float Distance; // 0x20
	public float DistanceY; // 0x24
	public EnvironmentType Environment; // 0x28
	private ListHashSet<ILOD> members; // 0x30

	public int Count { get; }


	public int get_Count() { }

	public void Initialize(Vector3 position, float size) { }

	public void ChangeLOD(bool force = False) { }

	public void Add(ILOD component, Transform transform) { }

	public void Remove(ILOD component, Transform transform) { }

	public float GetDistance(Transform transform, LODDistanceMode mode = 0) { }

	public float GetDistance(Vector3 worldPos, LODDistanceMode mode = 0) { }

	public static bool op_Implicit(LODCell cell) { }

	public void EnterPool() { }

	public void LeavePool() { }

	public void .ctor() { }

}

