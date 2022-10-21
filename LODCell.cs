public class LODCell : Pool.IPooled // TypeDefIndex: 11652
{
	public Vector3 Position; 
	public float Size; 
	public float Distance; 
	public float DistanceY; 
	public float Timestamp; 
	public EnvironmentType Environment; 
	private ListHashSet<ILOD> members; 

	public int Count { get; }


	public int get_Count() { }

	public void Initialize(Vector3 position, float size) { }

	public bool NeedsRefresh() { }

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

