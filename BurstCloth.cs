public class BurstCloth : MonoBehaviour // TypeDefIndex: 7308
{
internal const int TickRateMultiplier = 60;
internal const int MaximumTickRate = 240;
	private static readonly List<CapsuleParams> CapsuleParamsShared; 
	[HeaderAttribute] 
	public Transform[] RootBones; 
	public bool SiblingConstraints; 
	public int StiffnessDepth; 
	[RangeAttribute] 
	public float LengthModifier; 
	[HeaderAttribute] 
	public BurstClothMaterial Material; 
	public Vector3 Gravity; 
	public Transform SimulationSpace; 
	[HeaderAttribute] 
	public bool EnableCollisions; 
	public float CollisionRadius; 
	[BurstClothCurveRectAttribute] 
	public AnimationCurve CollisionRadiusCurve; 
	[HeaderAttribute] 
	public bool EnableSimulation; 
	[RangeAttribute] 
	public int TickRate; 
	[RangeAttribute] 
	public int MaxTicksPerFrame; 
	[SerializeField] 
	[HideInInspector] 
	private List<BurstCloth.Chain> _chains; 
	[SerializeField] 
	[HideInInspector] 
	private List<BoneData> _boneDataOriginal; 
	private Vector3 _origin; 
	private Quaternion _rotation; 
	private Vector3 _up; 
	private Vector3 _simulationSpaceDelta; 
	private Transform _prevSimulationSpace; 
	private Vector3 _prevSimulationOrigin; 
	private float _accumulator; 
	private int _boneCount; 
	private int _maxBoneDepth; 
	private Dictionary<Transform, int> _boneToIndex; 
	private TransformAccessArray _boneTransforms; 
	private NativeArray<BoneData> _boneData; 
	private NativeArray<BoneState> _boneState; 
	private TransformAccessArray _colliderTransforms; 
	private NativeArray<ColliderData> _colliderData; 
	private NativeArray<ColliderState> _colliderState; 


protected void Initialize() { }

protected virtual void Awake() { }

protected virtual void OnEnable() { }

protected virtual void OnDisable() { }

protected internal virtual void FrameUpdate() { }

internal JobHandle SimulateSystem() { }

private void SetupData() { }

private void SetupManagedData() { }

private void SetupNativeData() { }

protected virtual ValueTuple<Vector3, Quaternion, Vector3> GetOriginTransform() { }

protected virtual void GatherColliders(List<CapsuleParams> colliders) { }

private static ValueTuple<Vector3, float> GetBoneLocalPositionAndLength(Transform parent, Transform child) { }

private ValueTuple<Transform, int> GetSiblingAndIndex(int chainIndex, int depth) { }

private void BuildBoneToIndexMap(Dictionary<Transform, int> boneToIndex) { }

protected static CapsuleParams GetCapsuleParams(CapsuleCollider collider) { }

protected void UpdateCachedMaterialData() { }

public void .ctor() { }

private static void .cctor() { }

}

private struct BurstCloth.Chain // TypeDefIndex: 7309
{
	public List<Transform> Transforms; 

}

private sealed class BurstCloth.<>c // TypeDefIndex: 7310
{
	public static readonly BurstCloth.<>c <>9; 
	public static Func<BurstCloth.Chain, int> <>9__42_0; 
	public static Func<BurstCloth.Chain, int> <>9__42_1; 


private static void .cctor() { }

public void .ctor() { }

internal int <SetupManagedData>b__42_0(BurstCloth.Chain c) { }

internal int <SetupManagedData>b__42_1(BurstCloth.Chain c) { }

}

