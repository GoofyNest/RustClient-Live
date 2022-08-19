public class Model : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9209
{	// Fields
	public SphereCollider collision; // 0x18
	public Transform rootBone; // 0x20
	public Transform headBone; // 0x28
	public Transform eyeBone; // 0x30
	public Animator animator; // 0x38
	public Skeleton skeleton; // 0x40
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Transform[] boneTransforms; // 0x48
	[HideInInspector] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string[] boneNames; // 0x50
	internal BoneDictionary boneDict; // 0x58
	internal int skin; // 0x60
	private LODGroup _lodGroup; // 0x68

	// Properties
	public LODGroup lodGroup { get; }

	// Methods

	// RVA: 0x771970 Offset: 0x770D70 VA: 0x180771970
	protected void OnEnable() { }

	// RVA: 0x7710E0 Offset: 0x7704E0 VA: 0x1807710E0
	public void BuildBoneDictionary() { }

	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public int GetSkin() { }

	// RVA: 0x7711D0 Offset: 0x7705D0 VA: 0x1807711D0
	private Transform FindBoneInternal(string name) { }

	// RVA: 0x771260 Offset: 0x770660 VA: 0x180771260
	public Transform FindBone(string name) { }

	// RVA: 0x771210 Offset: 0x770610 VA: 0x180771210
	public Transform FindBone(uint hash) { }

	// RVA: 0x771190 Offset: 0x770590 VA: 0x180771190
	public uint FindBoneID(Transform transform) { }

	// RVA: 0x771470 Offset: 0x770870 VA: 0x180771470
	public Transform[] GetBones() { }

	// RVA: 0x7712D0 Offset: 0x7706D0 VA: 0x1807712D0
	public Transform FindClosestBone(Vector3 worldPos) { }

	// RVA: 0x772160 Offset: 0x771560 VA: 0x180772160
	public LODGroup get_lodGroup() { }

	// RVA: 0x771840 Offset: 0x770C40 VA: 0x180771840
	private void OnDisable() { }

	// RVA: 0x771D40 Offset: 0x771140 VA: 0x180771D40
	public void SyncBones(Model other) { }

	// RVA: 0x7720B0 Offset: 0x7714B0 VA: 0x1807720B0
	public void Trigger(string triggerName) { }

	// RVA: 0x7714A0 Offset: 0x7708A0 VA: 0x1807714A0
	public static Transform GetTransform(Transform bone, Vector3 position, BaseEntity entity) { }

	// RVA: 0x770F50 Offset: 0x770350 VA: 0x180770F50
	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	// RVA: 0x771980 Offset: 0x770D80 VA: 0x180771980 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

