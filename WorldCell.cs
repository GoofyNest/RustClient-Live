public class WorldCell // TypeDefIndex: 10080
{	public Vector3 Position; // 0x10
	public float Size; // 0x1C
	public bool Visible; // 0x20
	private List<WorldCell.PrefabInfo> prefabs; // 0x28
	private List<GameObject> instances; // 0x30


	public void .ctor(Vector3 position, float size) { }

	public void Refresh() { }

	private void Show() { }

	private void Hide() { }

	public WorldCell.PrefabInfo Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	public static bool op_Implicit(WorldCell cell) { }

}

public class WorldCell.PrefabInfo // TypeDefIndex: 10081
{	public string category; // 0x10
	public Prefab prefab; // 0x18
	public Vector3 position; // 0x20
	public Quaternion rotation; // 0x2C
	public Vector3 scale; // 0x3C


	public void .ctor(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	public GameObject Spawn() { }

}

