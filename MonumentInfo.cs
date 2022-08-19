public class MonumentInfo : LandmarkInfo, IPrefabPreProcess // TypeDefIndex: 9965
{	// Fields
	[HeaderAttribute] // RVA: 0xAB0F0 Offset: 0xAA4F0 VA: 0x1800AB0F0
	public MonumentType Type; // 0x30
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public MonumentTier Tier; // 0x34
	public int MinWorldSize; // 0x38
	public Bounds Bounds; // 0x3C
	public bool HasNavmesh; // 0x54
	public bool IsSafeZone; // 0x55
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool WantsDungeonLink; // 0x56
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool HasDungeonLink; // 0x57
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public DungeonGridInfo DungeonEntrance; // 0x58
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float PreventBuildingRadius; // 0x60
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Vector3 PreventBuildingOrigin; // 0x64

	// Properties
	private bool HasApproximatePreventBuildingRadius { get; }

	// Methods

	// RVA: 0x778F30 Offset: 0x778330 VA: 0x180778F30 Slot: 5
	protected override void Awake() { }

	// RVA: 0x7796A0 Offset: 0x778AA0 VA: 0x1807796A0
	public bool CheckPlacement(Vector3 pos, Quaternion rot, Vector3 scale) { }

	// RVA: 0x779C70 Offset: 0x779070 VA: 0x180779C70
	public float Distance(Vector3 position) { }

	// RVA: 0x77A950 Offset: 0x779D50 VA: 0x18077A950
	public float SqrDistance(Vector3 position) { }

	// RVA: 0x779DB0 Offset: 0x7791B0 VA: 0x180779DB0
	public float Distance(OBB obb) { }

	// RVA: 0x77A7F0 Offset: 0x779BF0 VA: 0x18077A7F0
	public float SqrDistance(OBB obb) { }

	// RVA: 0x77A1A0 Offset: 0x7795A0 VA: 0x18077A1A0
	public bool IsInBounds(Vector3 position) { }

	// RVA: 0x7799F0 Offset: 0x778DF0 VA: 0x1807799F0
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x779F50 Offset: 0x779350 VA: 0x180779F50
	public PathFinder.Point GetPathFinderPoint(int res) { }

	// RVA: 0x77A070 Offset: 0x779470 VA: 0x18077A070
	public int GetPathFinderRadius(int res) { }

	// RVA: 0x77A3F0 Offset: 0x7797F0 VA: 0x18077A3F0
	protected void OnDrawGizmosSelected() { }

	// RVA: 0x77AA90 Offset: 0x779E90 VA: 0x18077AA90
	public static int TierToMask(MonumentTier tier) { }

	// RVA: 0x77A640 Offset: 0x779A40 VA: 0x18077A640 Slot: 6
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x779F10 Offset: 0x779310 VA: 0x180779F10
	private DungeonGridInfo FindDungeonEntrance() { }

	// RVA: 0x779B60 Offset: 0x778F60 VA: 0x180779B60
	private bool DetermineHasDungeonLink() { }

	// RVA: 0x779BD0 Offset: 0x778FD0 VA: 0x180779BD0
	private bool DetermineWantsDungeonLink() { }

	// RVA: 0x77A2E0 Offset: 0x7796E0 VA: 0x18077A2E0
	public bool IsPointWithinApproximatePreventBuildingRadius(Vector3 worldPoint) { }

	// RVA: 0x77ABB0 Offset: 0x779FB0 VA: 0x18077ABB0
	private bool get_HasApproximatePreventBuildingRadius() { }

	// RVA: 0x779020 Offset: 0x778420 VA: 0x180779020
	private void CalculatePreventBuildingRadius(out Vector3 localSpaceCentre, out float radius) { }

	// RVA: 0x77AAC0 Offset: 0x779EC0 VA: 0x18077AAC0
	public void .ctor() { }

}

