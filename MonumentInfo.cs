public class MonumentInfo : LandmarkInfo, IPrefabPreProcess // TypeDefIndex: 9965
{
	[HeaderAttribute] 
	public MonumentType Type; 
	[InspectorFlagsAttribute] 
	public MonumentTier Tier; 
	public int MinWorldSize; 
	public Bounds Bounds; 
	public bool HasNavmesh; 
	public bool IsSafeZone; 
	[HideInInspector] 
	public bool WantsDungeonLink; 
	[HideInInspector] 
	public bool HasDungeonLink; 
	[HideInInspector] 
	public DungeonGridInfo DungeonEntrance; 
	[HideInInspector] 
	public float PreventBuildingRadius; 
	[HideInInspector] 
	public Vector3 PreventBuildingOrigin; 

private bool HasApproximatePreventBuildingRadius { get; }


protected override void Awake() { }

public bool CheckPlacement(Vector3 pos, Quaternion rot, Vector3 scale) { }

public float Distance(Vector3 position) { }

public float SqrDistance(Vector3 position) { }

public float Distance(OBB obb) { }

public float SqrDistance(OBB obb) { }

public bool IsInBounds(Vector3 position) { }

public Vector3 ClosestPointOnBounds(Vector3 position) { }

public PathFinder.Point GetPathFinderPoint(int res) { }

public int GetPathFinderRadius(int res) { }

protected void OnDrawGizmosSelected() { }

public static int TierToMask(MonumentTier tier) { }

public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

private DungeonGridInfo FindDungeonEntrance() { }

private bool DetermineHasDungeonLink() { }

private bool DetermineWantsDungeonLink() { }

public bool IsPointWithinApproximatePreventBuildingRadius(Vector3 worldPoint) { }

private bool get_HasApproximatePreventBuildingRadius() { }

private void CalculatePreventBuildingRadius(out Vector3 localSpaceCentre, out float radius) { }

public void .ctor() { }

}

