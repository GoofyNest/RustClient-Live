public class Skeleton : MonoBehaviour // TypeDefIndex: 7358
{
	public SkeletonDefinition Source;
	public GameObject[] Bones;


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

	[CompilerGeneratedAttribute]
	private Transform <GetTransforms>

}

private sealed class Skeleton.<>c__DisplayClass15_0 // TypeDefIndex: 7359
{
	public Skeleton <>4__this;
	public Transform[] allChildren;


	public void .ctor() { }

	internal GameObject <Rebuild>

}

