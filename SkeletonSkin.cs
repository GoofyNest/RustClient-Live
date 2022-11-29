public class SkeletonSkin : MonoBehaviour // TypeDefIndex: 7365
{
	public SkinnedMeshRenderer SkinnedMeshRenderer; 
	public SkeletonDefinition SkeletonDefinition; 
	public int LOD; 
	public int RootBone; 
	public int[] TargetBones; 
	public Transform[] BoneTransforms; 


	public void Retarget(Skeleton target) { }

	public SkinnedMeshRenderer DuplicateAndRetarget(GameObject host, Skeleton target) { }

	public void .ctor() { }

}

