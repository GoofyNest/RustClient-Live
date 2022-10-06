public class EZSoftBone : MonoBehaviour, IClientComponent, IPrefabPreProcess // TypeDefIndex: 7163
{
	public const float DeltaTime_Min = 1E-06;
	public const int MaxInstanceCount = 12;
	private static float CurrentFrame; 
	private static int InstanceNumber; 
	[FormerlySerializedAsAttribute] 
	public List<Transform> rootBones; 
	[FormerlySerializedAsAttribute] 
	public List<Transform> endBones; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private EZSoftBoneMaterial _material; 
	[FormerlySerializedAsAttribute] 
	public int startDepth; 
	public int stiffnessDepth; 
	[FormerlySerializedAsAttribute] 
	public EZSoftBone.UnificationMode siblingConstraints; 
	[FormerlySerializedAsAttribute] 
	public EZSoftBone.UnificationMode lengthUnification; 
	[FormerlySerializedAsAttribute] 
	public bool siblingRotationConstraints; 
	[FormerlySerializedAsAttribute] 
	public bool closedSiblings; 
	[FormerlySerializedAsAttribute] 
	public LayerMask collisionLayers; 
	[FormerlySerializedAsAttribute] 
	public float radius; 
	[FormerlySerializedAsAttribute] 
	[EZCurveRectAttribute] 
	public AnimationCurve radiusCurve; 
	public float deadZoneRadius; 
	public float deadZoneExtent; 
	[FormerlySerializedAsAttribute] 
	public EZSoftBone.DeltaTimeMode deltaTimeMode; 
	[FormerlySerializedAsAttribute] 
	public float constantDeltaTime; 
	[FormerlySerializedAsAttribute] 
	[RangeAttribute] 
	public int iterations; 
	[FormerlySerializedAsAttribute] 
	public float sleepThreshold; 
	[FormerlySerializedAsAttribute] 
	public Vector3 gravity; 
	[SerializeField] 
	[FormerlySerializedAsAttribute] 
	private Transform _simulateSpace; 
	public float globalRadius; 
	public Vector3 globalForce; 
	public bool collisionEnabled; 
	[SerializeField] 
	private EZSoftBone.BoneChain[] structures; 
	private Vector3 origin; 
	private Vector3 prevOrigin; 
	private Vector3 originDelta; 
	private bool simulationSpaceChanged; 
	private Capsule deadZoneCapsule; 
	private bool isVisible; 
	private Vector3 forceDirection; 

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

	[CompilerGeneratedAttribute] 
	internal static bool <SetSiblings>g__HasBoneAtDepth|55_1(EZSoftBone.BoneChain chain, int depth) { }

}

public enum EZSoftBone.UnificationMode // TypeDefIndex: 7164
{
	public int value__; 
	public const EZSoftBone.UnificationMode None = 0;
	public const EZSoftBone.UnificationMode Rooted = 1;
	public const EZSoftBone.UnificationMode Unified = 2;

}

public enum EZSoftBone.DeltaTimeMode // TypeDefIndex: 7165
{
	public int value__; 
	public const EZSoftBone.DeltaTimeMode DeltaTime = 0;
	public const EZSoftBone.DeltaTimeMode SmoothDeltaTime = 1;
	public const EZSoftBone.DeltaTimeMode UnscaledDeltaTime = 2;
	public const EZSoftBone.DeltaTimeMode Constant = 3;

}

private class EZSoftBone.BoneChain // TypeDefIndex: 7166
{
	public EZSoftBone.Bone[] childBones; 


	public void .ctor(Transform origin, Transform systemSpace, Transform transform, List<Transform> endBones, int startDepth) { }

	public void InitializeParents() { }

}

private class EZSoftBone.Bone // TypeDefIndex: 7167
{
	public EZSoftBone.Bone parentBone; 
	public Vector3 localPosition; 
	public Quaternion localRotation; 
	public EZSoftBone.Bone childBone; 
	public EZSoftBone.Bone leftBone; 
	public Vector3 leftPosition; 
	public EZSoftBone.Bone rightBone; 
	public Vector3 rightPosition; 
	public Transform transform; 
	public Vector3 worldPosition; 
	public Transform systemSpace; 
	public Vector3 systemPosition; 
	public int depth; 
	public float boneLength; 
	public float treeLength; 
	public float normalizedLength; 
	public float length; 
	public float lengthToLeft; 
	public float lengthToRight; 
	public float radius; 
	public float damping; 
	public float stiffness; 
	public float resistance; 
	public float slackness; 
	public Vector3 speed; 


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

private sealed class EZSoftBone.<>c // TypeDefIndex: 7168
{
	public static readonly EZSoftBone.<>c <>9; 
	public static Func<EZSoftBone.BoneChain, int> <>9__55_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <SetSiblings>b__55_0(EZSoftBone.BoneChain c) { }

}

