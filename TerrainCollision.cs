public class TerrainCollision : TerrainExtension // TypeDefIndex: 12143
{
	private ListDictionary<Collider, List<Collider>> ignoredColliders;
	private TerrainCollider terrainCollider;


	public override void Setup() { }

	public void Clear() { }

	public void Reset(Collider collider) { }

	public bool GetIgnore(Vector3 pos, float radius = 0,01) { }

	public bool GetIgnore(RaycastHit hit) { }

	public bool GetIgnore(Collider collider) { }

	public void SetIgnore(Collider collider, Collider trigger, bool ignore = True) { }

	protected void LateUpdate() { }

	public void .ctor() { }

}

