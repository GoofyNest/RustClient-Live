public class Skeleton : MonoBehaviour // TypeDefIndex: 7344
{	public SkeletonDefinition Source; // 0x18
	public GameObject[] Bones; // 0x20


	public Transform GetTransform(int id) { }

	public Transform GetTransformSlow(string name) { }

	public int GetBoneId(string boneName) { }

	public IEnumerable<Transform> GetTransforms() { }

	public GameObject GetGameObject(int id) { }

	public void CopyPositions(Skeleton to) { }

	public void CopySkeletonSkins(SkeletonSkin[] renderers, LODGroup lodGroup) { }

	private void CopyLodGroup(LODGroup lodGroup, SkeletonSkin[] renderers, SkinnedMeshRenderer[] created) { }

	private int LookupRendererIndex(SkeletonSkin[] renderers, Renderer renderer) { }

	private SkinnedMeshRenderer CopySkin(SkeletonSkin renderer) { }

	public void CopySkeletonAttachments(SkeletonAttachment[] attachments) { }

	private void CopyAttachment(SkeletonAttachment skeletonAttachment) { }

	private int ReverseLookupBone(GameObject bone) { }

	public void Rebuild() { }

	private GameObject FindBoneImpl(in SkeletonDefinition.Bone bone, Transform[] allChildren) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <GetTransforms>b__5_0(SkeletonDefinition.Bone x) { }

}

private sealed class Skeleton.<>c__DisplayClass15_0 // TypeDefIndex: 7345
{	public Skeleton <>4__this; // 0x10
	public Transform[] allChildren; // 0x18


	public void .ctor() { }

	internal GameObject <Rebuild>b__0(SkeletonDefinition.Bone bone) { }

}

