public class EZSoftBone : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 7128
{	public const float DeltaTime_Min = 1E-06;
	public const int MaxInstanceCount = 12;
	private static float CurrentFrame; // 0x0
	private static int InstanceNumber; // 0x4
	[FormerlySerializedAsAttribute] // RVA: 0x80940 Offset: 0x7FD40 VA: 0x180080940
	public List<Transform> rootBones; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x80980 Offset: 0x7FD80 VA: 0x180080980
	public List<Transform> endBones; // 0x20
	[SerializeField] // RVA: 0x809B0 Offset: 0x7FDB0 VA: 0x1800809B0
	[FormerlySerializedAsAttribute] // RVA: 0x809B0 Offset: 0x7FDB0 VA: 0x1800809B0
	private EZSoftBoneMaterial _material; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x80BB0 Offset: 0x7FFB0 VA: 0x180080BB0
	public int startDepth; // 0x30
	public int stiffnessDepth; // 0x34
	[FormerlySerializedAsAttribute] // RVA: 0x80C20 Offset: 0x80020 VA: 0x180080C20
	public EZSoftBone.UnificationMode siblingConstraints; // 0x38
	[FormerlySerializedAsAttribute] // RVA: 0x80DA0 Offset: 0x801A0 VA: 0x180080DA0
	public EZSoftBone.UnificationMode lengthUnification; // 0x3C
	[FormerlySerializedAsAttribute] // RVA: 0x80F50 Offset: 0x80350 VA: 0x180080F50
	public bool siblingRotationConstraints; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0x81070 Offset: 0x80470 VA: 0x180081070
	public bool closedSiblings; // 0x41
	[FormerlySerializedAsAttribute] // RVA: 0x811F0 Offset: 0x805F0 VA: 0x1800811F0
	public LayerMask collisionLayers; // 0x44
	[FormerlySerializedAsAttribute] // RVA: 0x812E0 Offset: 0x806E0 VA: 0x1800812E0
	public float radius; // 0x48
	[FormerlySerializedAsAttribute] // RVA: 0x81460 Offset: 0x80860 VA: 0x180081460
	[EZCurveRectAttribute] // RVA: 0x81460 Offset: 0x80860 VA: 0x180081460
	public AnimationCurve radiusCurve; // 0x50
	public float deadZoneRadius; // 0x58
	public float deadZoneExtent; // 0x5C
	[FormerlySerializedAsAttribute] // RVA: 0x815C0 Offset: 0x809C0 VA: 0x1800815C0
	public EZSoftBone.DeltaTimeMode deltaTimeMode; // 0x60
	[FormerlySerializedAsAttribute] // RVA: 0x816F0 Offset: 0x80AF0 VA: 0x1800816F0
	public float constantDeltaTime; // 0x64
	[FormerlySerializedAsAttribute] // RVA: 0x817A0 Offset: 0x80BA0 VA: 0x1800817A0
	[RangeAttribute] // RVA: 0x817A0 Offset: 0x80BA0 VA: 0x1800817A0
	public int iterations; // 0x68
	[FormerlySerializedAsAttribute] // RVA: 0x81930 Offset: 0x80D30 VA: 0x180081930
	public float sleepThreshold; // 0x6C
	[FormerlySerializedAsAttribute] // RVA: 0x81960 Offset: 0x80D60 VA: 0x180081960
	public Vector3 gravity; // 0x70
	[SerializeField] // RVA: 0x819D0 Offset: 0x80DD0 VA: 0x1800819D0
	[FormerlySerializedAsAttribute] // RVA: 0x819D0 Offset: 0x80DD0 VA: 0x1800819D0
	private Transform _simulateSpace; // 0x80
	public float globalRadius; // 0x88
	public Vector3 globalForce; // 0x8C
	public bool collisionEnabled; // 0x98
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EZSoftBone.BoneChain[] structures; // 0xA0
	private Vector3 origin; // 0xA8
	private Vector3 prevOrigin; // 0xB4
	private Vector3 originDelta; // 0xC0
	private bool simulationSpaceChanged; // 0xCC
	private Capsule deadZoneCapsule; // 0xD0
	private bool isVisible; // 0xE4
	private Vector3 forceDirection; // 0xE8

	public EZSoftBoneMaterial sharedMaterial { get; set; }
	public Transform simulateSpace { get; set; }


	public EZSoftBoneMaterial get_sharedMaterial() { }

	public void set_sharedMaterial(EZSoftBoneMaterial value) { }

	public Transform get_simulateSpace() { }

	public void set_simulateSpace(Transform value) { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void LateUpdate() { }

	public void RevertTransforms() { }

	public void RevertTransforms(int startDepth) { }

	public void InitStructures(bool force = False) { }

	public void SetRestState() { }

	private void CreateBones() { }

	private void SetParentBones() { }

	private void SetSiblings() { }

	private void SetTreeLength() { }

	public void RefreshRadius() { }

	private void UpdateStructures(float deltaTime) { }

	private void UpdateBones(EZSoftBone.Bone bone, float deltaTime) { }

	private void UpdateTransforms() { }

	private void UpdateSimulationSpace(Transform transform) { }

	public void PushBonesOutOfDeadZone() { }

	public void PlayerPreviewVisibility(bool isVisible) { }

	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static bool <SetSiblings>g__HasBoneAtDepth|55_1(EZSoftBone.BoneChain chain, int depth) { }

}

public enum EZSoftBone.UnificationMode // TypeDefIndex: 7129
{	public int value__; // 0x0
	public const EZSoftBone.UnificationMode None = 0;
	public const EZSoftBone.UnificationMode Rooted = 1;
	public const EZSoftBone.UnificationMode Unified = 2;

}

public enum EZSoftBone.DeltaTimeMode // TypeDefIndex: 7130
{	public int value__; // 0x0
	public const EZSoftBone.DeltaTimeMode DeltaTime = 0;
	public const EZSoftBone.DeltaTimeMode SmoothDeltaTime = 1;
	public const EZSoftBone.DeltaTimeMode UnscaledDeltaTime = 2;
	public const EZSoftBone.DeltaTimeMode Constant = 3;

}

private class EZSoftBone.BoneChain // TypeDefIndex: 7131
{	public EZSoftBone.Bone[] childBones; // 0x10


	public void .ctor(Transform origin, Transform systemSpace, Transform transform, List<Transform> endBones, int startDepth) { }

	public void InitializeParents() { }

}

private class EZSoftBone.Bone // TypeDefIndex: 7132
{	public EZSoftBone.Bone parentBone; // 0x10
	public Vector3 localPosition; // 0x18
	public Quaternion localRotation; // 0x24
	public EZSoftBone.Bone childBone; // 0x38
	public EZSoftBone.Bone leftBone; // 0x40
	public Vector3 leftPosition; // 0x48
	public EZSoftBone.Bone rightBone; // 0x58
	public Vector3 rightPosition; // 0x60
	public Transform transform; // 0x70
	public Vector3 worldPosition; // 0x78
	public Transform systemSpace; // 0x88
	public Vector3 systemPosition; // 0x90
	public int depth; // 0x9C
	public float boneLength; // 0xA0
	public float treeLength; // 0xA4
	public float normalizedLength; // 0xA8
	public float length; // 0xAC
	public float lengthToLeft; // 0xB0
	public float lengthToRight; // 0xB4
	public float radius; // 0xB8
	public float damping; // 0xBC
	public float stiffness; // 0xC0
	public float resistance; // 0xC4
	public float slackness; // 0xC8
	public Vector3 speed; // 0xCC


	public void .ctor(Transform systemSpace, Transform transform, int depth, float boneLength) { }

	public void SetTreeLength() { }

	public void SetTreeLength(float treeLength) { }

	public void SetLeftSibling(EZSoftBone.Bone left) { }

	public void SetRightSibling(EZSoftBone.Bone right) { }

	public void Inflate(float baseRadius, AnimationCurve radiusCurve) { }

	public void Inflate(float baseRadius, AnimationCurve radiusCurve, EZSoftBoneMaterial material) { }

	public void RevertTransforms(int startDepth) { }

	public void UpdateTransform(bool siblingRotationConstraints, int startDepth) { }

	public void SetRestState() { }

	public void UpdateSpace() { }

}

private sealed class EZSoftBone.<>c // TypeDefIndex: 7133
{	public static readonly EZSoftBone.<>c <>9; // 0x0
	public static Func<EZSoftBone.BoneChain, int> <>9__55_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <SetSiblings>b__55_0(EZSoftBone.BoneChain c) { }

}

