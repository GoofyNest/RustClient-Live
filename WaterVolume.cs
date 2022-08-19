public class WaterVolume : TriggerBase // TypeDefIndex: 10057
{	// Fields
	public Bounds WaterBounds; // 0x30
	private OBB cachedBounds; // 0x48
	private Transform cachedTransform; // 0x98
	public Transform[] cutOffPlanes; // 0xA0
	public bool waterEnabled; // 0xA8

	// Methods

	// RVA: 0x8994F0 Offset: 0x8988F0 VA: 0x1808994F0
	private void OnEnable() { }

	// RVA: 0x899990 Offset: 0x898D90 VA: 0x180899990
	public bool Test(Vector3 pos, out WaterLevel.WaterInfo info) { }

	// RVA: 0x899C70 Offset: 0x899070 VA: 0x180899C70
	public bool Test(Bounds bounds, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8995B0 Offset: 0x8989B0 VA: 0x1808995B0
	public bool Test(Vector3 start, Vector3 end, float radius, out WaterLevel.WaterInfo info) { }

	// RVA: 0x8992A0 Offset: 0x8986A0 VA: 0x1808992A0
	private bool CheckCutOffPlanes(Vector3 pos) { }

	// RVA: 0x899FA0 Offset: 0x8993A0 VA: 0x180899FA0
	private void UpdateCachedTransform() { }

	// RVA: 0x899410 Offset: 0x898810 VA: 0x180899410 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x89A0E0 Offset: 0x8994E0 VA: 0x18089A0E0
	public void .ctor() { }

}

