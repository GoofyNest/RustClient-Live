public class WorldCell // TypeDefIndex: 11843
{
	public Vector3 Position;
	public float Size;
	public bool Visible;
	public float Timestamp;
	private List<WorldCell.PrefabInfo> prefabs;
	private List<GameObject> instances;


	public void .ctor(Vector3 position, float size) { }

	public bool NeedsRefresh() { }

	public void Refresh() { }

	private void Show() { }

	private void Hide() { }

	public WorldCell.PrefabInfo Add(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	public static bool op_Implicit(WorldCell cell) { }

}

public class WorldCell.PrefabInfo // TypeDefIndex: 11844
{
	public string category;
	public Prefab prefab;
	public Vector3 position;
	public Quaternion rotation;
	public Vector3 scale;


	public void .ctor(string category, Prefab prefab, Vector3 position, Quaternion rotation, Vector3 scale) { }

	public GameObject Spawn() { }

}

