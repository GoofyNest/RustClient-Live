public class Model : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9209
{	public SphereCollider collision; // 0x18
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

	public LODGroup lodGroup { get; }


	protected void OnEnable() { }

	public void BuildBoneDictionary() { }

	public int GetSkin() { }

	private Transform FindBoneInternal(string name) { }

	public Transform FindBone(string name) { }

	public Transform FindBone(uint hash) { }

	public uint FindBoneID(Transform transform) { }

	public Transform[] GetBones() { }

	public Transform FindClosestBone(Vector3 worldPos) { }

	public LODGroup get_lodGroup() { }

	private void OnDisable() { }

	public void SyncBones(Model other) { }

	public void Trigger(string triggerName) { }

	public static Transform GetTransform(Transform bone, Vector3 position, BaseEntity entity) { }

	public void ApplyVisibility(bool vis, bool animatorVis, bool shadowVis) { }

	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

}

