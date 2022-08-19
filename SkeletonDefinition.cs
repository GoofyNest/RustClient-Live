public class SkeletonDefinition : ScriptableObject // TypeDefIndex: 7347
{	// Fields
	public GameObject SourceObject; // 0x18
	public SkeletonDefinition.Bone[] Bones; // 0x20
	public SkeletonDefinition.RagdollSettings Ragdoll; // 0x28

	// Methods

	// RVA: 0x22F8420 Offset: 0x22F7820 VA: 0x1822F8420
	public SkeletonDefinition.Bone FindBone(string name) { }

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public struct SkeletonDefinition.Bone // TypeDefIndex: 7348
{	// Fields
	public int Id; // 0x0
	public int Depth; // 0x4
	public int Parent; // 0x8
	public string Name; // 0x10
	public GameObject Target; // 0x18
	public BoneFlag Flags; // 0x20

}

public struct SkeletonDefinition.RagdollSettings // TypeDefIndex: 7349
{	// Fields
	public int Pelvis; // 0x0
	public int Head; // 0x4
	public int Spine; // 0x8
	public SkeletonDefinition.RagdollSettings.BodySide Left; // 0xC
	public SkeletonDefinition.RagdollSettings.BodySide Right; // 0x20
	public float Mass; // 0x34
	public float ArmGirth; // 0x38
	public float LegGirth; // 0x3C
	public float HeadSize; // 0x40
	public PhysicMaterial Material; // 0x48

}

public struct SkeletonDefinition.RagdollSettings.BodySide // TypeDefIndex: 7350
{	// Fields
	public int Hip; // 0x0
	public int Knee; // 0x4
	public int Foot; // 0x8
	public int Arm; // 0xC
	public int Elbow; // 0x10

}

private sealed class SkeletonDefinition.<>c__DisplayClass3_0 // TypeDefIndex: 7351
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22FA780 Offset: 0x22F9B80 VA: 0x1822FA780
	internal bool <FindBone>b__0(SkeletonDefinition.Bone x) { }

}

