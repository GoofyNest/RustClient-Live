public class Skeleton : MonoBehaviour // TypeDefIndex: 7344
{	// Fields
	public SkeletonDefinition Source; // 0x18
	public GameObject[] Bones; // 0x20

	// Methods

	// RVA: 0x22FA270 Offset: 0x22F9670 VA: 0x1822FA270
	public Transform GetTransform(int id) { }

	// RVA: 0x22FA070 Offset: 0x22F9470 VA: 0x1822FA070
	public Transform GetTransformSlow(string name) { }

	// RVA: 0x22F9F40 Offset: 0x22F9340 VA: 0x1822F9F40
	public int GetBoneId(string boneName) { }

	// RVA: 0x22FA360 Offset: 0x22F9760 VA: 0x1822FA360
	public IEnumerable<Transform> GetTransforms() { }

	// RVA: 0x22FA030 Offset: 0x22F9430 VA: 0x1822FA030
	public GameObject GetGameObject(int id) { }

	// RVA: 0x22F9670 Offset: 0x22F8A70 VA: 0x1822F9670
	public void CopyPositions(Skeleton to) { }

	// RVA: 0x22F9AA0 Offset: 0x22F8EA0 VA: 0x1822F9AA0
	public void CopySkeletonSkins(SkeletonSkin[] renderers, LODGroup lodGroup) { }

	// RVA: 0x22F9420 Offset: 0x22F8820 VA: 0x1822F9420
	private void CopyLodGroup(LODGroup lodGroup, SkeletonSkin[] renderers, SkinnedMeshRenderer[] created) { }

	// RVA: 0x22FA3F0 Offset: 0x22F97F0 VA: 0x1822FA3F0
	private int LookupRendererIndex(SkeletonSkin[] renderers, Renderer renderer) { }

	// RVA: 0x22F9C10 Offset: 0x22F9010 VA: 0x1822F9C10
	private SkinnedMeshRenderer CopySkin(SkeletonSkin renderer) { }

	// RVA: 0x22F9A30 Offset: 0x22F8E30 VA: 0x1822F9A30
	public void CopySkeletonAttachments(SkeletonAttachment[] attachments) { }

	// RVA: 0x22F9210 Offset: 0x22F8610 VA: 0x1822F9210
	private void CopyAttachment(SkeletonAttachment skeletonAttachment) { }

	// RVA: 0x22FA5C0 Offset: 0x22F99C0 VA: 0x1822FA5C0
	private int ReverseLookupBone(GameObject bone) { }

	// RVA: 0x22FA4C0 Offset: 0x22F98C0 VA: 0x1822FA4C0
	public void Rebuild() { }

	// RVA: 0x22F9DF0 Offset: 0x22F91F0 VA: 0x1822F9DF0
	private GameObject FindBoneImpl(in SkeletonDefinition.Bone bone, Transform[] allChildren) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22FA610 Offset: 0x22F9A10 VA: 0x1822FA610
	private Transform <GetTransforms>b__5_0(SkeletonDefinition.Bone x) { }

}

private sealed class Skeleton.<>c__DisplayClass15_0 // TypeDefIndex: 7345
{	// Fields
	public Skeleton <>4__this; // 0x10
	public Transform[] allChildren; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22FA620 Offset: 0x22F9A20 VA: 0x1822FA620
	internal GameObject <Rebuild>b__0(SkeletonDefinition.Bone bone) { }

}

