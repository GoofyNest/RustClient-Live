public class SkeletonSkin : MonoBehaviour // TypeDefIndex: 7353
{	public SkinnedMeshRenderer SkinnedMeshRenderer; // 0x18
	public SkeletonDefinition SkeletonDefinition; // 0x20
	public int LOD; // 0x28
	public int RootBone; // 0x2C
	public int[] TargetBones; // 0x30
	public Transform[] BoneTransforms; // 0x38


	public void Retarget(Skeleton target) { }

	public SkinnedMeshRenderer DuplicateAndRetarget(GameObject host, Skeleton target) { }

	public void .ctor() { }

}

