public class MagnetCrane : GroundVehicle, IGenericLerpTarget<MagnetCrane.MagnetCraneSnapshot>, ILerpInfo // TypeDefIndex: 10111
{
	private Option __menuOption_Menu_FuelStorage; 
	private GenericLerp<MagnetCrane.MagnetCraneSnapshot> animInterp; 
	private float leftTreadInput; 
	private float rightTreadInput; 
	[HeaderAttribute] 
	public Animator animator; 
	[SerializeField] 
	private Transform COM; 
	[SerializeField] 
	private float arm1Speed; 
	[SerializeField] 
	private float arm2Speed; 
	[SerializeField] 
	private float turnYawSpeed; 
	[SerializeField] 
	private BaseMagnet Magnet; 
	[SerializeField] 
	private MagnetCraneAudio mcAudio; 
	[SerializeField] 
	private Rigidbody myRigidbody; 
	[SerializeField] 
	private Transform[] collisionTestingPoints; 
	[SerializeField] 
	private float maxDistanceFromOrigin; 
	[SerializeField] 
	private GameObjectRef selfDamageEffect; 
	[SerializeField] 
	private GameObjectRef explosionEffect; 
	[SerializeField] 
	private Transform explosionPoint; 
	[SerializeField] 
	private CapsuleCollider driverCollision; 
	[SerializeField] 
	private Transform leftHandTarget; 
	[SerializeField] 
	private Transform rightHandTarget; 
	[SerializeField] 
	private Transform leftFootTarget; 
	[SerializeField] 
	private Transform rightFootTarget; 
	[SerializeField] 
	private float idleFuelPerSec; 
	[SerializeField] 
	private float maxFuelPerSec; 
	[SerializeField] 
	private GameObject[] OnTriggers; 
	[SerializeField] 
	private TriggerHurtEx magnetDamage; 
	[SerializeField] 
	private int engineKW; 
	[SerializeField] 
	private CarWheel[] wheels; 
	[SerializeField] 
	private CarSettings carSettings; 
	[SerializeField] 
	private ParticleSystem exhaustInner; 
	[SerializeField] 
	private ParticleSystem exhaustOuter; 
	[SerializeField] 
	private EmissionToggle lightToggle; 
	public static readonly Translate.Phrase ReturnMessage; 
	private const BaseEntity.Flags Flag_ArmMovement = 32768;
	private const BaseEntity.Flags Flag_BaseMovementInput = 262144;
	private static int leftTreadParam; 
	private static int rightTreadParam; 
	private static int yawParam; 
	private static int arm1Param; 
	private static int arm2Param; 

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

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
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

public struct MagnetCrane.MagnetCraneSnapshot : ISnapshot<MagnetCrane.MagnetCraneSnapshot> // TypeDefIndex: 10112
{
	[CompilerGeneratedAttribute] 
	private float <Time>k__BackingField; 
	public float yaw; 
	public float arm1; 
	public float arm2; 

	public float Time { get; set; }


	[CompilerGeneratedAttribute] 
	public float get_Time() { }

	[CompilerGeneratedAttribute] 
	public void set_Time(float value) { }

	public void .ctor(float time, float yaw, float arm1, float arm2) { }

	public void MatchValuesTo(MagnetCrane.MagnetCraneSnapshot entry) { }

	public void Lerp(MagnetCrane.MagnetCraneSnapshot prev, MagnetCrane.MagnetCraneSnapshot next, float delta) { }

	public MagnetCrane.MagnetCraneSnapshot GetNew() { }

}

