public class MagnetCrane : GroundVehicle, IGenericLerpTarget<MagnetCrane.MagnetCraneSnapshot>, ILerpInfo // TypeDefIndex: 8406
{	// Fields
	private Option __menuOption_Menu_FuelStorage; // 0x408
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

	// Properties
	public override bool HasMenuOptions { get; }
	public override float DriveWheelVelocity { get; }

	// Methods

	// RVA: 0x573BF0 Offset: 0x572FF0 VA: 0x180573BF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x574D60 Offset: 0x574160 VA: 0x180574D60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x5746B0 Offset: 0x573AB0 VA: 0x1805746B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x572E40 Offset: 0x572240 VA: 0x180572E40 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x574A00 Offset: 0x573E00 VA: 0x180574A00 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x5747A0 Offset: 0x573BA0 VA: 0x1805747A0 Slot: 203
	public void SetFrom(MagnetCrane.MagnetCraneSnapshot snapshot) { }

	// RVA: 0x573AD0 Offset: 0x572ED0 VA: 0x180573AD0 Slot: 204
	public MagnetCrane.MagnetCraneSnapshot GetCurrentState() { }

	// RVA: 0x572EA0 Offset: 0x5722A0 VA: 0x180572EA0 Slot: 205
	public void DebugInterpolationState(Interpolator.Segment<MagnetCrane.MagnetCraneSnapshot> segment, List<MagnetCrane.MagnetCraneSnapshot> entries) { }

	// RVA: 0x573F60 Offset: 0x573360 VA: 0x180573F60 Slot: 202
	protected override void GroundVehicleClientTick() { }

	// RVA: 0x574670 Offset: 0x573A70 VA: 0x180574670 Slot: 201
	protected override void OnClientTickStopped() { }

	// RVA: 0x5748B0 Offset: 0x573CB0 VA: 0x1805748B0
	private void UpdateExhaust() { }

	// RVA: 0x574320 Offset: 0x573720 VA: 0x180574320
	private void InitAnimInterpolator() { }

	[BaseEntity.Menu] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Description] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.Icon] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x73CE0 Offset: 0x730E0 VA: 0x180073CE0
	// RVA: 0x574630 Offset: 0x573A30 VA: 0x180574630
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x574580 Offset: 0x573980 VA: 0x180574580
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x574D50 Offset: 0x574150 VA: 0x180574D50 Slot: 196
	public override float get_DriveWheelVelocity() { }

	// RVA: 0x573F00 Offset: 0x573300 VA: 0x180573F00 Slot: 198
	public override float GetThrottleInput() { }

	// RVA: 0x573A70 Offset: 0x572E70 VA: 0x180573A70 Slot: 199
	public override float GetBrakeInput() { }

	// RVA: 0x5743B0 Offset: 0x5737B0 VA: 0x1805743B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x573BE0 Offset: 0x572FE0 VA: 0x180573BE0 Slot: 197
	public override float GetMaxForwardSpeed() { }

	// RVA: 0x572DD0 Offset: 0x5721D0 VA: 0x180572DD0 Slot: 120
	public override bool CanBeLooted(BasePlayer player) { }

	// RVA: 0x574D20 Offset: 0x574120 VA: 0x180574D20
	public void .ctor() { }

	// RVA: 0x574C10 Offset: 0x574010 VA: 0x180574C10
	private static void .cctor() { }

}

public struct MagnetCrane.MagnetCraneSnapshot : ISnapshot<MagnetCrane.MagnetCraneSnapshot> // TypeDefIndex: 8407
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <Time>k__BackingField; // 0x0
	public float yaw; // 0x4
	public float arm1; // 0x8
	public float arm2; // 0xC

	// Properties
	public float Time { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2270 Offset: 0xF1670 VA: 0x1800F2270 Slot: 4
	public float get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280 Slot: 5
	public void set_Time(float value) { }

	// RVA: 0xF2CA0 Offset: 0xF20A0 VA: 0x1800F2CA0
	public void .ctor(float time, float yaw, float arm1, float arm2) { }

	// RVA: 0xF2C80 Offset: 0xF2080 VA: 0x1800F2C80 Slot: 6
	public void MatchValuesTo(MagnetCrane.MagnetCraneSnapshot entry) { }

	// RVA: 0xF2B40 Offset: 0xF1F40 VA: 0x1800F2B40 Slot: 7
	public void Lerp(MagnetCrane.MagnetCraneSnapshot prev, MagnetCrane.MagnetCraneSnapshot next, float delta) { }

	// RVA: 0xF2B30 Offset: 0xF1F30 VA: 0x1800F2B30 Slot: 8
	public MagnetCrane.MagnetCraneSnapshot GetNew() { }

}

