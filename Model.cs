public class Model : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 10946
{
	public SphereCollider collision;
	public Transform rootBone;
	public Transform headBone;
	public Transform eyeBone;
	public Animator animator;
	public Skeleton skeleton;
	[HideInInspector]
	public Transform[] boneTransforms;
	[HideInInspector]
	public string[] boneNames;
	internal BoneDictionary boneDict;
	internal int skin;
	private LODGroup _lodGroup;

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

