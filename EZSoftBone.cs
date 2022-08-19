public class EZSoftBone : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 7128
{	// Fields
	public const float DeltaTime_Min = 1E-06;
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

	// Properties
	public EZSoftBoneMaterial sharedMaterial { get; set; }
	public Transform simulateSpace { get; set; }

	// Methods

	// RVA: 0x22911D0 Offset: 0x22905D0 VA: 0x1822911D0
	public EZSoftBoneMaterial get_sharedMaterial() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_sharedMaterial(EZSoftBoneMaterial value) { }

	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public Transform get_simulateSpace() { }

	// RVA: 0x2291310 Offset: 0x2290710 VA: 0x182291310
	public void set_simulateSpace(Transform value) { }

	// RVA: 0x228D930 Offset: 0x228CD30 VA: 0x18228D930
	private void Awake() { }

	// RVA: 0x228EBC0 Offset: 0x228DFC0 VA: 0x18228EBC0
	private void OnEnable() { }

	// RVA: 0x228EBB0 Offset: 0x228DFB0 VA: 0x18228EBB0
	private void OnDisable() { }

	// RVA: 0x228E600 Offset: 0x228DA00 VA: 0x18228E600
	private void LateUpdate() { }

	// RVA: 0x228EBB0 Offset: 0x228DFB0 VA: 0x18228EBB0
	public void RevertTransforms() { }

	// RVA: 0x228F380 Offset: 0x228E780 VA: 0x18228F380
	public void RevertTransforms(int startDepth) { }

	// RVA: 0x228DE00 Offset: 0x228D200 VA: 0x18228DE00
	public void InitStructures(bool force = False) { }

	// RVA: 0x228F530 Offset: 0x228E930 VA: 0x18228F530
	public void SetRestState() { }

	// RVA: 0x228DB10 Offset: 0x228CF10 VA: 0x18228DB10
	private void CreateBones() { }

	// RVA: 0x228F440 Offset: 0x228E840 VA: 0x18228F440
	private void SetParentBones() { }

	// RVA: 0x228F5E0 Offset: 0x228E9E0 VA: 0x18228F5E0
	private void SetSiblings() { }

	// RVA: 0x228FA10 Offset: 0x228EE10 VA: 0x18228FA10
	private void SetTreeLength() { }

	// RVA: 0x228F170 Offset: 0x228E570 VA: 0x18228F170
	public void RefreshRadius() { }

	// RVA: 0x2290BB0 Offset: 0x228FFB0 VA: 0x182290BB0
	private void UpdateStructures(float deltaTime) { }

	// RVA: 0x228FD50 Offset: 0x228F150 VA: 0x18228FD50
	private void UpdateBones(EZSoftBone.Bone bone, float deltaTime) { }

	// RVA: 0x2291060 Offset: 0x2290460 VA: 0x182291060
	private void UpdateTransforms() { }

	// RVA: 0x2290A60 Offset: 0x228FE60 VA: 0x182290A60
	private void UpdateSimulationSpace(Transform transform) { }

	// RVA: 0x228ED60 Offset: 0x228E160 VA: 0x18228ED60
	public void PushBonesOutOfDeadZone() { }

	// RVA: 0x228ED40 Offset: 0x228E140 VA: 0x18228ED40
	public void PlayerPreviewVisibility(bool isVisible) { }

	// RVA: 0x228ED50 Offset: 0x228E150 VA: 0x18228ED50 Slot: 4
	public void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x2291140 Offset: 0x2290540 VA: 0x182291140
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x228FD20 Offset: 0x228F120 VA: 0x18228FD20
	internal static bool <SetSiblings>g__HasBoneAtDepth|55_1(EZSoftBone.BoneChain chain, int depth) { }

}

public enum EZSoftBone.UnificationMode // TypeDefIndex: 7129
{	// Fields
	public int value__; // 0x0
	public const EZSoftBone.UnificationMode None = 0;
	public const EZSoftBone.UnificationMode Rooted = 1;
	public const EZSoftBone.UnificationMode Unified = 2;

}

public enum EZSoftBone.DeltaTimeMode // TypeDefIndex: 7130
{	// Fields
	public int value__; // 0x0
	public const EZSoftBone.DeltaTimeMode DeltaTime = 0;
	public const EZSoftBone.DeltaTimeMode SmoothDeltaTime = 1;
	public const EZSoftBone.DeltaTimeMode UnscaledDeltaTime = 2;
	public const EZSoftBone.DeltaTimeMode Constant = 3;

}

private class EZSoftBone.BoneChain // TypeDefIndex: 7131
{	// Fields
	public EZSoftBone.Bone[] childBones; // 0x10

	// Methods

	// RVA: 0x22887E0 Offset: 0x2287BE0 VA: 0x1822887E0
	public void .ctor(Transform origin, Transform systemSpace, Transform transform, List<Transform> endBones, int startDepth) { }

	// RVA: 0x2288740 Offset: 0x2287B40 VA: 0x182288740
	public void InitializeParents() { }

}

private class EZSoftBone.Bone // TypeDefIndex: 7132
{	// Fields
	public EZSoftBone.Bone parentBone; // 0x10
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

	// Methods

	// RVA: 0x2289870 Offset: 0x2288C70 VA: 0x182289870
	public void .ctor(Transform systemSpace, Transform transform, int depth, float boneLength) { }

	// RVA: 0x22891D0 Offset: 0x22885D0 VA: 0x1822891D0
	public void SetTreeLength() { }

	// RVA: 0x2289200 Offset: 0x2288600 VA: 0x182289200
	public void SetTreeLength(float treeLength) { }

	// RVA: 0x2288E10 Offset: 0x2288210 VA: 0x182288E10
	public void SetLeftSibling(EZSoftBone.Bone left) { }

	// RVA: 0x2289090 Offset: 0x2288490 VA: 0x182289090
	public void SetRightSibling(EZSoftBone.Bone right) { }

	// RVA: 0x2288D50 Offset: 0x2288150 VA: 0x182288D50
	public void Inflate(float baseRadius, AnimationCurve radiusCurve) { }

	// RVA: 0x2288C30 Offset: 0x2288030 VA: 0x182288C30
	public void Inflate(float baseRadius, AnimationCurve radiusCurve, EZSoftBoneMaterial material) { }

	// RVA: 0x2288DA0 Offset: 0x22881A0 VA: 0x182288DA0
	public void RevertTransforms(int startDepth) { }

	// RVA: 0x2289290 Offset: 0x2288690 VA: 0x182289290
	public void UpdateTransform(bool siblingRotationConstraints, int startDepth) { }

	// RVA: 0x2288F50 Offset: 0x2288350 VA: 0x182288F50
	public void SetRestState() { }

	// RVA: 0x2289230 Offset: 0x2288630 VA: 0x182289230
	public void UpdateSpace() { }

}

private sealed class EZSoftBone.<>c // TypeDefIndex: 7133
{	// Fields
	public static readonly EZSoftBone.<>c <>9; // 0x0
	public static Func<EZSoftBone.BoneChain, int> <>9__55_0; // 0x8

	// Methods

	// RVA: 0x22913E0 Offset: 0x22907E0 VA: 0x1822913E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22913C0 Offset: 0x22907C0 VA: 0x1822913C0
	internal int <SetSiblings>b__55_0(EZSoftBone.BoneChain c) { }

}

