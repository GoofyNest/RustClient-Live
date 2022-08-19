public class WorldCell // TypeDefIndex: 10080
{	// Fields
	public Vector3 Position; // 0x10
	public float Size; // 0x1C
	public bool Visible; // 0x20
	private List<WorldCell.PrefabInfo> prefabs; // 0x28
	private List<GameObject> instances; // 0x30

	// Methods

	// RVA: 0x8A8D00 Offset: 0x8A8100 VA: 0x1808A8D00
	public void .ctor(Vector3 position, float size) { }

	// RVA: 0x8A8800 Offset: 0x8A7C00 VA: 0x1808A8800
	public void Refresh() { }

	// RVA: 0x8A8B60 Offset: 0x8A7F60 VA: 0x1808A8B60
	private void Show() { }

	// RVA: 0x8A86C0 Offset: 0x8A7AC0 VA: 0x1808A86C0
	private void Hide() { }

	// RVA: 0x8A85D0 Offset: 0x8A79D0 VA: 0x1808A85D0
	public WorldCell.PrefabInfo Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x6B8100 Offset: 0x6B7500 VA: 0x1806B8100
	public static bool op_Implicit(WorldCell cell) { }

}

public class WorldCell.PrefabInfo // TypeDefIndex: 10081
{	// Fields
	public string category; // 0x10
	public Prefab prefab; // 0x18
	public Vector3 position; // 0x20
	public Quaternion rotation; // 0x2C
	public Vector3 scale; // 0x3C

	// Methods

	// RVA: 0x892DA0 Offset: 0x8921A0 VA: 0x180892DA0
	public void .ctor(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x892D30 Offset: 0x892130 VA: 0x180892D30
	public GameObject Spawn() { }

}

