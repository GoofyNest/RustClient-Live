public class Minicopter : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6356
{
	public bool ShouldPool;
	private bool _disposed;
	public uint fuelStorageID;
	public float fuelFraction;
	public float pitch;
	public float roll;
	public float yaw;


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

public class MiniCopter : BaseHelicopterVehicle, IEngineControllerUser, IEntity // TypeDefIndex: 10008
{
	[HeaderAttribute]
	public GameObjectRef fuelStoragePrefab;
	public float fuelPerSec;
	public float fuelGaugeMax;
	private float cachedFuelFraction;
	public Transform waterSample;
	public WheelCollider leftWheel;
	public WheelCollider rightWheel;
	public WheelCollider frontWheel;
	public Transform leftWheelTrans;
	public Transform rightWheelTrans;
	public Transform frontWheelTrans;
	public float cachedrotation_left;
	public float cachedrotation_right;
	public float cachedrotation_front;
	[HeaderAttribute]
	public Transform joystickPositionLeft;
	public Transform joystickPositionRight;
	public Transform leftFootPosition;
	public Transform rightFootPosition;
	public AnimationCurve bladeEngineCurve;
	public Animator animator;
	public float maxRotorSpeed;
	public float timeUntilMaxRotorSpeed;
	public float rotorBlurThreshold;
	public Transform mainRotorBlur;
	public Transform mainRotorBlades;
	public Transform rearRotorBlades;
	public Transform rearRotorBlur;
	public float motorForceConstant;
	public float brakeForceConstant;
	public GameObject preventBuildingObject;
	[ServerVar]
	public static float population;
	[ServerVar]
	public static float outsidedecayminutes;
	[ServerVar]
	public static float insidedecayminutes;
	private VehicleEngineController<MiniCopter> engineController;
	private float leftWheelVelocity;
	private float rightWheelVelocity;
	private float rotorSpeed;
	private float mainRotorBlurRotation;
	private float mainRotorRotation;
	private float rearRotorBlurRotation;
	private float rearRotorRotation;
	private float cachedPitch;
	private float cachedYaw;
	private float cachedRoll;
	protected static int fuelAnimationIndex;
	protected static int pitchAnimationIndex;
	protected static int rollAnimationIndex;
	protected static int yawAnimationIndex;
	protected int fuelShakeIndex;
	private Option __menuOption_Menu_FuelStorage;

	public bool IsStartingUp { get; }
	public VehicleEngineController.EngineState<MiniCopter> CurEngineState { get; }
	public override bool HasMenuOptions { get; }


	public float GetFuelFraction() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
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

	public override float InheritedVelocityScale() { }

	public override bool InheritedVelocityDirection() { }

	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

