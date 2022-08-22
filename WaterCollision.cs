public class WaterCollision : MonoBehaviour // TypeDefIndex: 10599
{	private ListDictionary<Collider, List<Collider>> ignoredColliders; // 0x18
	private HashSet<Collider> waterColliders; // 0x20


	private void Awake() { }

	public void Clear() { }

	public void Reset(Collider collider) { }

	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	public bool GetIgnore(Bounds bounds) { }

	public bool GetIgnore(Vector3 start, Vector3 end, float radius) { }

	public bool GetIgnore(RaycastHit hit) { }

	public bool GetIgnore(Collider collider) { }

	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	protected void LateUpdate() { }

	public void .ctor() { }

}

