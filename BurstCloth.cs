public class BurstCloth : MonoBehaviour // TypeDefIndex: 7308
{	// Fields
	internal const int TickRateMultiplier = 60;
	internal const int MaximumTickRate = 240;
	private static readonly List<CapsuleParams> CapsuleParamsShared; // 0x0
	[HeaderAttribute] // RVA: 0x94A80 Offset: 0x93E80 VA: 0x180094A80
	public Transform[] RootBones; // 0x18
	public bool SiblingConstraints; // 0x20
	public int StiffnessDepth; // 0x24
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float LengthModifier; // 0x28
	[HeaderAttribute] // RVA: 0x94C30 Offset: 0x94030 VA: 0x180094C30
	public BurstClothMaterial Material; // 0x30
	public Vector3 Gravity; // 0x38
	public Transform SimulationSpace; // 0x48
	[HeaderAttribute] // RVA: 0x94CE0 Offset: 0x940E0 VA: 0x180094CE0
	public bool EnableCollisions; // 0x50
	public float CollisionRadius; // 0x54
	[BurstClothCurveRectAttribute] // RVA: 0x94D40 Offset: 0x94140 VA: 0x180094D40
	public AnimationCurve CollisionRadiusCurve; // 0x58
	[HeaderAttribute] // RVA: 0x94DB0 Offset: 0x941B0 VA: 0x180094DB0
	public bool EnableSimulation; // 0x60
	[RangeAttribute] // RVA: 0x94F20 Offset: 0x94320 VA: 0x180094F20
	public int TickRate; // 0x64
	[RangeAttribute] // RVA: 0x95060 Offset: 0x94460 VA: 0x180095060
	public int MaxTicksPerFrame; // 0x68
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private List<BurstCloth.Chain> _chains; // 0x70
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private List<BoneData> _boneDataOriginal; // 0x78
	private Vector3 _origin; // 0x80
	private Quaternion _rotation; // 0x8C
	private Vector3 _up; // 0x9C
	private Vector3 _simulationSpaceDelta; // 0xA8
	private Transform _prevSimulationSpace; // 0xB8
	private Vector3 _prevSimulationOrigin; // 0xC0
	private float _accumulator; // 0xCC
	private int _boneCount; // 0xD0
	private int _maxBoneDepth; // 0xD4
	private Dictionary<Transform, int> _boneToIndex; // 0xD8
	private TransformAccessArray _boneTransforms; // 0xE0
	private NativeArray<BoneData> _boneData; // 0xE8
	private NativeArray<BoneState> _boneState; // 0xF8
	private TransformAccessArray _colliderTransforms; // 0x108
	private NativeArray<ColliderData> _colliderData; // 0x110
	private NativeArray<ColliderState> _colliderState; // 0x120

	// Methods

	// RVA: 0x2234A40 Offset: 0x2233E40 VA: 0x182234A40
	protected void Initialize() { }

	// RVA: 0x70AFC0 Offset: 0x70A3C0 VA: 0x18070AFC0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x22355E0 Offset: 0x22349E0 VA: 0x1822355E0 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x2235470 Offset: 0x2234870 VA: 0x182235470 Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x22341D0 Offset: 0x22335D0 VA: 0x1822341D0 Slot: 7
	protected internal virtual void FrameUpdate() { }

	// RVA: 0x2236470 Offset: 0x2235870 VA: 0x182236470
	internal JobHandle SimulateSystem() { }

	// RVA: 0x2235640 Offset: 0x2234A40 VA: 0x182235640
	private void SetupData() { }

	// RVA: 0x2235660 Offset: 0x2234A60 VA: 0x182235660
	private void SetupManagedData() { }

	// RVA: 0x2235890 Offset: 0x2234C90 VA: 0x182235890
	private void SetupNativeData() { }

	// RVA: 0x2234810 Offset: 0x2233C10 VA: 0x182234810 Slot: 8
	protected virtual ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	protected virtual void GatherColliders(List<CapsuleParams> colliders) { }

	// RVA: 0x2234420 Offset: 0x2233820 VA: 0x182234420
	private static ValueTuple<Vector3, float> GetBoneLocalPositionAndLength(Transform parent, Transform child) { }

	// RVA: 0x2234950 Offset: 0x2233D50 VA: 0x182234950
	private ValueTuple<Transform, int> GetSiblingAndIndex(int chainIndex, int depth) { }

	// RVA: 0x2233F90 Offset: 0x2233390 VA: 0x182233F90
	private void BuildBoneToIndexMap(Dictionary<Transform, int> boneToIndex) { }

	// RVA: 0x22345B0 Offset: 0x22339B0 VA: 0x1822345B0
	protected static CapsuleParams GetCapsuleParams(CapsuleCollider collider) { }

	// RVA: 0x22368D0 Offset: 0x2235CD0 VA: 0x1822368D0
	protected void UpdateCachedMaterialData() { }

	// RVA: 0x2236E10 Offset: 0x2236210 VA: 0x182236E10
	public void .ctor() { }

	// RVA: 0x2236DA0 Offset: 0x22361A0 VA: 0x182236DA0
	private static void .cctor() { }

}

private struct BurstCloth.Chain // TypeDefIndex: 7309
{	// Fields
	public List<Transform> Transforms; // 0x0

}

private sealed class BurstCloth.<>c // TypeDefIndex: 7310
{	// Fields
	public static readonly BurstCloth.<>c <>9; // 0x0
	public static Func<BurstCloth.Chain, int> <>9__42_0; // 0x8
	public static Func<BurstCloth.Chain, int> <>9__42_1; // 0x10

	// Methods

	// RVA: 0x22399C0 Offset: 0x2238DC0 VA: 0x1822399C0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x2239940 Offset: 0x2238D40 VA: 0x182239940
	internal int <SetupManagedData>b__42_0(BurstCloth.Chain c) { }

	// RVA: 0x2239980 Offset: 0x2238D80 VA: 0x182239980
	internal int <SetupManagedData>b__42_1(BurstCloth.Chain c) { }

}

