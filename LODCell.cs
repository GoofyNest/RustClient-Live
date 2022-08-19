public class LODCell : Pool.IPooled // TypeDefIndex: 9928
{	// Fields
	public Vector3 Position; // 0x10
	public float Size; // 0x1C
	public float Distance; // 0x20
	public float DistanceY; // 0x24
	public EnvironmentType Environment; // 0x28
	private ListHashSet<ILOD> members; // 0x30

	// Properties
	public int Count { get; }

	// Methods

	// RVA: 0x6B80B0 Offset: 0x6B74B0 VA: 0x1806B80B0
	public int get_Count() { }

	// RVA: 0x6B7F80 Offset: 0x6B7380 VA: 0x1806B7F80
	public void Initialize(Vector3 position, float size) { }

	// RVA: 0x6B7A90 Offset: 0x6B6E90 VA: 0x1806B7A90
	public void ChangeLOD(bool force = False) { }

	// RVA: 0x6B7A20 Offset: 0x6B6E20 VA: 0x1806B7A20
	public void Add(ILOD component, Transform transform) { }

	// RVA: 0x6B7FA0 Offset: 0x6B73A0 VA: 0x1806B7FA0
	public void Remove(ILOD component, Transform transform) { }

	// RVA: 0x6B7F10 Offset: 0x6B7310 VA: 0x1806B7F10
	public float GetDistance(Transform transform, LODDistanceMode mode = 0) { }

	// RVA: 0x6B7EC0 Offset: 0x6B72C0 VA: 0x1806B7EC0
	public float GetDistance(Vector3 worldPos, LODDistanceMode mode = 0) { }

	// RVA: 0x6B8100 Offset: 0x6B7500 VA: 0x1806B8100
	public static bool op_Implicit(LODCell cell) { }

	// RVA: 0x6B7E30 Offset: 0x6B7230 VA: 0x1806B7E30 Slot: 4
	public void EnterPool() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x6B8040 Offset: 0x6B7440 VA: 0x1806B8040
	public void .ctor() { }

}

