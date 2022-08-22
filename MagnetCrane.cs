public class MagnetCrane : GroundVehicle, IGenericLerpTarget<MagnetCrane.MagnetCraneSnapshot>, ILerpInfo // TypeDefIndex: 8406
{	private Option __menuOption_Menu_FuelStorage; // 0x408
	private GenericLerp<MagnetCrane.MagnetCraneSnapshot> animInterp; // 0x460
	private float leftTreadInput; // 0x468
	private float rightTreadInput; // 0x46C
	[HeaderAttribute] // RVA: 0xEA780 Offset: 0xE9B80 VA: 0x1800EA780
	public Animator animator; // 0x470
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform COM; // 0x478
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float arm1Speed; // 0x480
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float arm2Speed; // 0x484
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float turnYawSpeed; // 0x488
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private BaseMagnet Magnet; // 0x490
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MagnetCraneAudio mcAudio; // 0x498
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Rigidbody myRigidbody; // 0x4A0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform[] collisionTestingPoints; // 0x4A8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxDistanceFromOrigin; // 0x4B0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef selfDamageEffect; // 0x4B8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObjectRef explosionEffect; // 0x4C0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform explosionPoint; // 0x4C8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CapsuleCollider driverCollision; // 0x4D0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftHandTarget; // 0x4D8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightHandTarget; // 0x4E0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform leftFootTarget; // 0x4E8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform rightFootTarget; // 0x4F0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float idleFuelPerSec; // 0x4F8
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float maxFuelPerSec; // 0x4FC
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GameObject[] OnTriggers; // 0x500
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TriggerHurtEx magnetDamage; // 0x508
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int engineKW; // 0x510
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CarWheel[] wheels; // 0x518
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private CarSettings carSettings; // 0x520
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem exhaustInner; // 0x528
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private ParticleSystem exhaustOuter; // 0x530
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EmissionToggle lightToggle; // 0x538
	public static readonly Translate.Phrase ReturnMessage; // 0x0
	private const BaseEntity.Flags Flag_ArmMovement = 32768;
	private const BaseEntity.Flags Flag_BaseMovementInput = 262144;
	private static int leftTreadParam; // 0x8
	private static int rightTreadParam; // 0xC
	private static int yawParam; // 0x10
	private static int arm1Param; // 0x14
	private static int arm2Param; // 0x18

	public override bool HasMenuOptions { get; }
	public override float DriveWheelVelocity { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	protected override void ClientInit(Entity info) { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public void SetFrom(MagnetCrane.MagnetCraneSnapshot snapshot) { }

	public MagnetCrane.MagnetCraneSnapshot GetCurrentState() { }

	public void DebugInterpolationState(Interpolator.Segment<MagnetCrane.MagnetCraneSnapshot> segment, List<MagnetCrane.MagnetCraneSnapshot> entries) { }

	protected override void GroundVehicleClientTick() { }

	protected override void OnClientTickStopped() { }

	private void UpdateExhaust() { }

	private void InitAnimInterpolator() { }

	[BaseEntity.Menu] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Description] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Icon] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	public override float get_DriveWheelVelocity() { }

	public override float GetThrottleInput() { }

	public override float GetBrakeInput() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override float GetMaxForwardSpeed() { }

	public override bool CanBeLooted(BasePlayer player) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct MagnetCrane.MagnetCraneSnapshot : ISnapshot<MagnetCrane.MagnetCraneSnapshot> // TypeDefIndex: 8407
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Time>k__BackingField; // 0x0
	public float yaw; // 0x4
	public float arm1; // 0x8
	public float arm2; // 0xC

	public float Time { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_Time(float value) { }

	public void .ctor(float time, float yaw, float arm1, float arm2) { }

	public void MatchValuesTo(MagnetCrane.MagnetCraneSnapshot entry) { }

	public void Lerp(MagnetCrane.MagnetCraneSnapshot prev, MagnetCrane.MagnetCraneSnapshot next, float delta) { }

	public MagnetCrane.MagnetCraneSnapshot GetNew() { }

}

