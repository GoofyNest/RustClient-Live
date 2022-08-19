public class SkeletonSkin : MonoBehaviour // TypeDefIndex: 7353
{	// Fields
	public SkinnedMeshRenderer SkinnedMeshRenderer; // 0x18
	public SkeletonDefinition SkeletonDefinition; // 0x20
	public int LOD; // 0x28
	public int RootBone; // 0x2C
	public int[] TargetBones; // 0x30
	public Transform[] BoneTransforms; // 0x38

	// Methods

	// RVA: 0x22F8E90 Offset: 0x22F8290 VA: 0x1822F8E90
	public void Retarget(Skeleton target) { }

	// RVA: 0x22F8BC0 Offset: 0x22F7FC0 VA: 0x1822F8BC0
	public SkinnedMeshRenderer DuplicateAndRetarget(GameObject host, Skeleton target) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

