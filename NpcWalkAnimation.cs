public class NpcWalkAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 9117
{	// Fields
	public Vector3 HipFudge; // 0x18
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

	// Methods

	// RVA: 0xA38340 Offset: 0xA37740 VA: 0x180A38340
	public void Start() { }

	// RVA: 0xA38150 Offset: 0xA37550 VA: 0x180A38150
	private void OnEnable() { }

	// RVA: 0xA380D0 Offset: 0xA374D0 VA: 0x180A380D0
	private void OnDisable() { }

	// RVA: 0xA37C80 Offset: 0xA37080 VA: 0x180A37C80
	public Quaternion GetRotation() { }

	// RVA: 0xA381D0 Offset: 0xA375D0 VA: 0x180A381D0
	private void QueuedGroundAlign() { }

	// RVA: 0xA38560 Offset: 0xA37960 VA: 0x180A38560
	private void Update() { }

	// RVA: 0xA37D40 Offset: 0xA37140 VA: 0x180A37D40
	public bool GroundSample(Vector3 origin, out RaycastHit hit) { }

	// RVA: 0xA37E70 Offset: 0xA37270 VA: 0x180A37E70
	public void LateUpdate() { }

	// RVA: 0xA39770 Offset: 0xA38B70 VA: 0x180A39770
	public void .ctor() { }

	// RVA: 0xA39660 Offset: 0xA38A60 VA: 0x180A39660
	private static void .cctor() { }

}

public class NpcWalkAnimation.NPCWalkWorkQueue : PersistentObjectWorkQueue<NpcWalkAnimation> // TypeDefIndex: 9118
{	// Methods

	// RVA: 0xA34510 Offset: 0xA33910 VA: 0x180A34510 Slot: 5
	protected override void RunJob(NpcWalkAnimation entity) { }

	// RVA: 0xA34550 Offset: 0xA33950 VA: 0x180A34550 Slot: 4
	protected override bool ShouldAdd(NpcWalkAnimation entity) { }

	// RVA: 0xA345F0 Offset: 0xA339F0 VA: 0x180A345F0
	public void .ctor() { }

}

