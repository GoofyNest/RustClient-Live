public class WaterVolume : TriggerBase // TypeDefIndex: 10057
{
	public Bounds WaterBounds; 
	private OBB cachedBounds; 
	private Transform cachedTransform; 
	public Transform[] cutOffPlanes; 
	public bool waterEnabled; 


private void OnEnable() { }

public bool Test(Vector3 pos, out WaterLevel.WaterInfo info) { }

public bool Test(Bounds bounds, out WaterLevel.WaterInfo info) { }

public bool Test(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

private bool CheckCutOffPlanes(Vector3 pos) { }

private void UpdateCachedTransform() { }

internal override GameObject InterestedInObject(GameObject obj) { }

public void .ctor() { }

}

