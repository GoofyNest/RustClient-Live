public class WaterVolume : TriggerBase // TypeDefIndex: 10057
{	public Bounds WaterBounds; // 0x30
	private OBB cachedBounds; // 0x48
	private Transform cachedTransform; // 0x98
	public Transform[] cutOffPlanes; // 0xA0
	public bool waterEnabled; // 0xA8


	private void OnEnable() { }

	public bool Test(Vector3 pos, out WaterLevel.WaterInfo info) { }

	public bool Test(Bounds bounds, out WaterLevel.WaterInfo info) { }

	public bool Test(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	private bool CheckCutOffPlanes(Vector3 pos) { }

	private void UpdateCachedTransform() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	public void .ctor() { }

}

