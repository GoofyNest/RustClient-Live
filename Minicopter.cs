public class Minicopter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6347
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint fuelStorageID; // 0x14
	public float fuelFraction; // 0x18
	public float pitch; // 0x1C
	public float roll; // 0x20
	public float yaw; // 0x24

	// Methods

	// RVA: 0x1F43620 Offset: 0x1F42A20 VA: 0x181F43620
	public static void ResetToPool(Minicopter instance) { }

	// RVA: 0x1F43570 Offset: 0x1F42970 VA: 0x181F43570
	public void ResetToPool() { }

	// RVA: 0x1F431C0 Offset: 0x1F425C0 VA: 0x181F431C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E1C720 Offset: 0x1E1BB20 VA: 0x181E1C720
	public void CopyTo(Minicopter instance) { }

	// RVA: 0x1F41E70 Offset: 0x1F41270 VA: 0x181F41E70
	public Minicopter Copy() { }

	// RVA: 0x1F42640 Offset: 0x1F41A40 VA: 0x181F42640
	public static Minicopter Deserialize(Stream stream) { }

	// RVA: 0x1F42220 Offset: 0x1F41620 VA: 0x181F42220
	public static Minicopter DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F422A0 Offset: 0x1F416A0 VA: 0x181F422A0
	public static Minicopter DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F42B40 Offset: 0x1F41F40 VA: 0x181F42B40
	public static Minicopter Deserialize(byte[] buffer) { }

	// RVA: 0x1F432F0 Offset: 0x1F426F0 VA: 0x181F432F0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F43CA0 Offset: 0x1F430A0 VA: 0x181F43CA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F43CC0 Offset: 0x1F430C0 VA: 0x181F43CC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Minicopter previous) { }

	// RVA: 0x1F43550 Offset: 0x1F42950 VA: 0x181F43550 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F42E90 Offset: 0x1F42290 VA: 0x181F42E90
	public static Minicopter Deserialize(byte[] buffer, Minicopter instance, bool isDelta = False) { }

	// RVA: 0x1F428E0 Offset: 0x1F41CE0 VA: 0x181F428E0
	public static Minicopter Deserialize(Stream stream, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F41EF0 Offset: 0x1F412F0 VA: 0x181F41EF0
	public static Minicopter DeserializeLengthDelimited(Stream stream, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F42330 Offset: 0x1F41730 VA: 0x181F42330
	public static Minicopter DeserializeLength(Stream stream, int length, Minicopter instance, bool isDelta) { }

	// RVA: 0x1F436D0 Offset: 0x1F42AD0 VA: 0x181F436D0
	public static void SerializeDelta(Stream stream, Minicopter instance, Minicopter previous) { }

	// RVA: 0x1F43B20 Offset: 0x1F42F20 VA: 0x181F43B20
	public static void Serialize(Stream stream, Minicopter instance) { }

	// RVA: 0x1F43C90 Offset: 0x1F43090 VA: 0x181F43C90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F43CA0 Offset: 0x1F430A0 VA: 0x181F43CA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F43A10 Offset: 0x1F42E10 VA: 0x181F43A10
	public static byte[] SerializeToBytes(Minicopter instance) { }

	// RVA: 0x1F43960 Offset: 0x1F42D60 VA: 0x181F43960
	public static void SerializeLengthDelimited(Stream stream, Minicopter instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MiniCopter : BaseHelicopterVehicle, IEngineControllerUser, IEntity // TypeDefIndex: 8292
{	// Fields
	[HeaderAttribute] // RVA: 0x78380 Offset: 0x77780 VA: 0x180078380
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

	// Properties
	public bool IsStartingUp { get; }
	public VehicleEngineController.EngineState<MiniCopter> CurEngineState { get; }
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x763AE0 Offset: 0x762EE0 VA: 0x180763AE0
	public float GetFuelFraction() { }

	[BaseEntity.Menu] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	[BaseEntity.Menu.Description] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	[BaseEntity.Menu.Icon] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	[BaseEntity.Menu.ShowIf] // RVA: 0xAC490 Offset: 0xAB890 VA: 0x1800AC490
	// RVA: 0x764180 Offset: 0x763580 VA: 0x180764180
	public void Menu_FuelStorage(BasePlayer player) { }

	// RVA: 0x764030 Offset: 0x763430 VA: 0x180764030
	public bool Menu_FuelStorage_ShowIf(BasePlayer player) { }

	// RVA: 0x7654B0 Offset: 0x7648B0 VA: 0x1807654B0
	public bool get_IsStartingUp() { }

	// RVA: 0x7653A0 Offset: 0x7647A0 VA: 0x1807653A0
	public VehicleEngineController.EngineState<MiniCopter> get_CurEngineState() { }

	// RVA: 0x763E00 Offset: 0x763200 VA: 0x180763E00 Slot: 28
	public override void InitShared() { }

	// RVA: 0x764F60 Offset: 0x764360 VA: 0x180764F60
	public void Update() { }

	// RVA: 0x7643B0 Offset: 0x7637B0 VA: 0x1807643B0 Slot: 197
	public virtual void UpdateAnimator() { }

	// RVA: 0x4C0690 Offset: 0x4BFA90 VA: 0x1804C0690 Slot: 198
	protected virtual float GetMainRotorScale() { }

	// RVA: 0x7649C0 Offset: 0x763DC0 VA: 0x1807649C0
	public void UpdateRotor(float delta) { }

	// RVA: 0x763ED0 Offset: 0x7632D0 VA: 0x180763ED0
	public void LateUpdate() { }

	// RVA: 0x764780 Offset: 0x763B80 VA: 0x180764780 Slot: 173
	public override void UpdatePlayerModel(BasePlayer player) { }

	// RVA: 0x764380 Offset: 0x763780 VA: 0x180764380
	public float RemapValue(float toUse, float maxRemap) { }

	// RVA: 0x763F10 Offset: 0x763310 VA: 0x180763F10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7638E0 Offset: 0x762CE0 VA: 0x1807638E0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x764390 Offset: 0x763790 VA: 0x180764390
	public void TryUpdateLayerIndicies() { }

	// RVA: 0x764720 Offset: 0x763B20 VA: 0x180764720 Slot: 199
	public virtual void UpdateLayerIndicies() { }

	// RVA: 0x7641C0 Offset: 0x7635C0 VA: 0x1807641C0 Slot: 184
	public override bool MountMenuVisible(BasePlayer player) { }

	// RVA: 0x763880 Offset: 0x762C80 VA: 0x180763880 Slot: 192
	protected override bool CanPushNow(BasePlayer pusher) { }

	// RVA: 0x763AF0 Offset: 0x762EF0 VA: 0x180763AF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x7653F0 Offset: 0x7647F0 VA: 0x1807653F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x764290 Offset: 0x763690 VA: 0x180764290 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x765340 Offset: 0x764740 VA: 0x180765340
	public void .ctor() { }

	// RVA: 0x765260 Offset: 0x764660 VA: 0x180765260
	private static void .cctor() { }

}

