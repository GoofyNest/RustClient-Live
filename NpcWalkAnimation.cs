public class NpcWalkAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9117
{	public Vector3 HipFudge; // 0x18
	public BaseNpc Npc; // 0x28
	public Animator Animator; // 0x30
	public Transform HipBone; // 0x38
	public Transform LookBone; // 0x40
	public bool UpdateWalkSpeed; // 0x48
	public bool UpdateFacingDirection; // 0x49
	public bool UpdateGroundNormal; // 0x4A
	public Transform alignmentRoot; // 0x50
	public bool LaggyAss; // 0x58
	public bool LookAtTarget; // 0x59
	public float MaxLaggyAssRotation; // 0x5C
	public float MaxWalkAnimSpeed; // 0x60
	public bool UseDirectionBlending; // 0x64
	public bool useTurnPosing; // 0x65
	public float turnPoseScale; // 0x68
	public float laggyAssLerpScale; // 0x6C
	public bool skeletonChainInverted; // 0x70
	private static int ParamWalkSpeed; // 0x0
	private static int ParamWalkSpeedAverage; // 0x4
	private static int ParamWalkDirX; // 0x8
	private static int ParamWalkDirZ; // 0xC
	private static int ParamTurnPose; // 0x10
	private AverageVelocity AverageVelocity; // 0x78
	private Vector3 oldPosition; // 0x80
	private Quaternion hipForward; // 0x8C
	private Quaternion baseHipRotation; // 0x9C
	private Quaternion baseLookRotation; // 0xAC
	[ClientVar] // RVA: 0xD0FE0 Offset: 0xD03E0 VA: 0x1800D0FE0
	[HelpAttribute] // RVA: 0xD0FE0 Offset: 0xD03E0 VA: 0x1800D0FE0
	public static float framebudgetms; // 0x14
	public static NpcWalkAnimation.NPCWalkWorkQueue WorkQueue; // 0x18
	private Vector3 targetUp; // 0xBC
	private Vector3 targetOffset; // 0xC8
	private Vector3 lastForward; // 0xD4
	private bool lastGroundAlignHit; // 0xE0
	private RaycastHit lastGroundAlignInfo; // 0xE4
	private float avgTurnDifference; // 0x110


	public void Start() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public Quaternion GetRotation() { }

	private void QueuedGroundAlign() { }

	private void Update() { }

	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	public void LateUpdate() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class NpcWalkAnimation.NPCWalkWorkQueue : PersistentObjectWorkQueue<NpcWalkAnimation> // TypeDefIndex: 9118
{
	protected override void RunJob(NpcWalkAnimation entity) { }

	protected override bool ShouldAdd(NpcWalkAnimation entity) { }

	public void .ctor() { }

}

