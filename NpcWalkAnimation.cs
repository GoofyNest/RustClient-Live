public class NpcWalkAnimation : MonoBehaviour, IClientComponent // TypeDefIndex: 10845
{
	public Vector3 HipFudge; 
	public BaseNpc Npc; 
	public Animator Animator; 
	public Transform HipBone; 
	public Transform LookBone; 
	public bool UpdateWalkSpeed; 
	public bool UpdateFacingDirection; 
	public bool UpdateGroundNormal; 
	public Transform alignmentRoot; 
	public bool LaggyAss; 
	public bool LookAtTarget; 
	public float MaxLaggyAssRotation; 
	public float MaxWalkAnimSpeed; 
	public bool UseDirectionBlending; 
	public bool useTurnPosing; 
	public float turnPoseScale; 
	public float laggyAssLerpScale; 
	public bool skeletonChainInverted; 
	private static int ParamWalkSpeed; 
	private static int ParamWalkSpeedAverage; 
	private static int ParamWalkDirX; 
	private static int ParamWalkDirZ; 
	private static int ParamTurnPose; 
	private AverageVelocity AverageVelocity; 
	private Vector3 oldPosition; 
	private Quaternion hipForward; 
	private Quaternion baseHipRotation; 
	private Quaternion baseLookRotation; 
	[ClientVar] 
	[HelpAttribute] 
	public static float framebudgetms; 
	public static NpcWalkAnimation.NPCWalkWorkQueue WorkQueue; 
	private Vector3 targetUp; 
	private Vector3 targetOffset; 
	private Vector3 lastForward; 
	private bool lastGroundAlignHit; 
	private RaycastHit lastGroundAlignInfo; 
	private float avgTurnDifference; 


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

public class NpcWalkAnimation.NPCWalkWorkQueue : PersistentObjectWorkQueue<NpcWalkAnimation> // TypeDefIndex: 10846
{

	protected override void RunJob(NpcWalkAnimation entity) { }

	protected override bool ShouldAdd(NpcWalkAnimation entity) { }

	public void .ctor() { }

}

