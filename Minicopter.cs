public class Minicopter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6347
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint fuelStorageID; // 0x14
	public float fuelFraction; // 0x18
	public float pitch; // 0x1C
	public float roll; // 0x20
	public float yaw; // 0x24


	public static void ResetToPool(Minicopter instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Minicopter instance) { }

	public Minicopter Copy() { }

	public static Minicopter Deserialize(Stream stream) { }

	public static Minicopter DeserializeLengthDelimited(Stream stream) { }

	public static Minicopter DeserializeLength(Stream stream, int length) { }

	public static Minicopter Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Minicopter previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Minicopter Deserialize(byte[] buffer, Minicopter instance, bool isDelta = False) { }

	public static Minicopter Deserialize(Stream stream, Minicopter instance, bool isDelta) { }

	public static Minicopter DeserializeLengthDelimited(Stream stream, Minicopter instance, bool isDelta) { }

	public static Minicopter DeserializeLength(Stream stream, int length, Minicopter instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Minicopter instance, Minicopter previous) { }

	public static void Serialize(Stream stream, Minicopter instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Minicopter instance) { }

	public static void SerializeLengthDelimited(Stream stream, Minicopter instance) { }

	public void .ctor() { }

}

public class MiniCopter : BaseHelicopterVehicle, IEngineControllerUser, IEntity // TypeDefIndex: 8292
{	[HeaderAttribute] // RVA: 0x78380 Offset: 0x77780 VA: 0x180078380
	public GameObjectRef fuelStoragePrefab; // 0x4D0
	public float fuelPerSec; // 0x4D8
	public float fuelGaugeMax; // 0x4DC
	private float cachedFuelFraction; // 0x4E0
	public Transform waterSample; // 0x4E8
	public WheelCollider leftWheel; // 0x4F0
	public WheelCollider rightWheel; // 0x4F8
	public WheelCollider frontWheel; // 0x500
	public Transform leftWheelTrans; // 0x508
	public Transform rightWheelTrans; // 0x510
	public Transform frontWheelTrans; // 0x518
	public float cachedrotation_left; // 0x520
	public float cachedrotation_right; // 0x524
	public float cachedrotation_front; // 0x528
	[HeaderAttribute] // RVA: 0x7F380 Offset: 0x7E780 VA: 0x18007F380
	public Transform joystickPositionLeft; // 0x530
	public Transform joystickPositionRight; // 0x538
	public Transform leftFootPosition; // 0x540
	public Transform rightFootPosition; // 0x548
	public AnimationCurve bladeEngineCurve; // 0x550
	public Animator animator; // 0x558
	public float maxRotorSpeed; // 0x560
	public float timeUntilMaxRotorSpeed; // 0x564
	public float rotorBlurThreshold; // 0x568
	public Transform mainRotorBlur; // 0x570
	public Transform mainRotorBlades; // 0x578
	public Transform rearRotorBlades; // 0x580
	public Transform rearRotorBlur; // 0x588
	public float motorForceConstant; // 0x590
	public float brakeForceConstant; // 0x594
	public GameObject preventBuildingObject; // 0x598
	[ServerVar] // RVA: 0x71DA0 Offset: 0x711A0 VA: 0x180071DA0
	public static float population; // 0x0
	[ServerVar] // RVA: 0xAC190 Offset: 0xAB590 VA: 0x1800AC190
	public static float outsidedecayminutes; // 0x4
	[ServerVar] // RVA: 0xAC300 Offset: 0xAB700 VA: 0x1800AC300
	public static float insidedecayminutes; // 0x8
	private VehicleEngineController<MiniCopter> engineController; // 0x5A0
	private float leftWheelVelocity; // 0x5A8
	private float rightWheelVelocity; // 0x5AC
	private float rotorSpeed; // 0x5B0
	private float mainRotorBlurRotation; // 0x5B4
	private float mainRotorRotation; // 0x5B8
	private float rearRotorBlurRotation; // 0x5BC
	private float rearRotorRotation; // 0x5C0
	private float cachedPitch; // 0x5C4
	private float cachedYaw; // 0x5C8
	private float cachedRoll; // 0x5CC
	protected static int fuelAnimationIndex; // 0xC
	protected static int pitchAnimationIndex; // 0x10
	protected static int rollAnimationIndex; // 0x14
	protected static int yawAnimationIndex; // 0x18
	protected int fuelShakeIndex; // 0x5D0
	private Option __menuOption_Menu_FuelStorage; // 0x5D8

	public bool IsStartingUp { get; }
	public VehicleEngineController.EngineState<MiniCopter> CurEngineState { get; }
	public override bool HasMenuOptions { get; }


	public float GetFuelFraction() { }

	[BaseEntity.Menu] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	[BaseEntity.Menu.Description] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	[BaseEntity.Menu.Icon] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	[BaseEntity.Menu.ShowIf] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	public void Menu_FuelStorage(BasePlayer player) { }

	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	public bool get_IsStartingUp() { }

	public VehicleEngineController.EngineState<MiniCopter> get_CurEngineState() { }

	public override void InitShared() { }

	public void Update() { }

	public virtual void UpdateAnimator() { }

	protected virtual float GetMainRotorScale() { }

	public void UpdateRotor(float delta) { }

	public void LateUpdate() { }

	public override void UpdatePlayerModel(BasePlayer player) { }

	public float RemapValue(float toUse, float maxRemap) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	protected override void ClientInit(Entity info) { }

	public void TryUpdateLayerIndicies() { }

	public virtual void UpdateLayerIndicies() { }

	public override bool MountMenuVisible(BasePlayer player) { }

	protected override bool CanPushNow(BasePlayer pusher) { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

